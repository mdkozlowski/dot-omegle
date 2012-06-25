using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using dotOmegle;

namespace OmegleSharp
{
    public partial class PandoraBotSelectionForm : Form
    {
        /// <summary>Gets or sets the name of the bot.</summary>
        /// <value>The name of the bot.</value>
        public string BotName { get; protected set; }

        /// <summary>Gets or sets the bot id.</summary>
        /// <value>The bot id.</value>
        public string BotId { get; protected set; }

        /// <summary>Gets or sets the custom bots.</summary>
        /// <value>The custom bots.</value>
        public PandoraBotRecord[] CustomBots { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PandoraBotSelectionForm"/> class.
        /// </summary>
        public PandoraBotSelectionForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void PandoraBotSelectionForm_Load(object sender, EventArgs e)
        {
            BotName = null;
            BotId = null;

            ListViewColumnSorter sorter = new ListViewColumnSorter();
            sorter.SortColumn = 2;

            botList.ListViewItemSorter = sorter;
        }

        /// <summary>
        /// Handles the Shown event of the form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void PandoraBotSelectionForm_Shown(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
        }

        /// <summary>Handles the DoubleClick event of the botList control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void botList_DoubleClick(object sender, EventArgs e)
        {
            btnOk.PerformClick();
        }

        /// <summary>Handles the Click event of the btnCancel control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            BotName = null;
            BotId = null;
        }

        /// <summary>Clears the list.</summary>
        private void ClearList()
        {
            this.Invoke(new MethodInvoker(delegate { botList.Items.Clear(); }));
        }

        /// <summary>Adds a bot.</summary>
        /// <param name="groupKey">The group key.</param>
        /// <param name="botRecord">The bot record.</param>
        private void AddBot(string groupKey, PandoraBotRecord botRecord)
        {
            AddBot(groupKey, botRecord.Name, botRecord.Id, botRecord.Interactions);
        }

        /// <summary>Adds a bot.</summary>
        /// <param name="groupKey">The group key.</param>
        /// <param name="name">The name.</param>
        /// <param name="botId">The bot id.</param>
        /// <param name="botInteractions">Number of bot interactions.</param>
        /// <param name="tag">A tag value.</param>
        private void AddBot(string groupKey, string name,
            string botId = null, string botInteractions = null, object tag = null)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                ListViewItem item = new ListViewItem(name);

                if (botInteractions == null)
                    item.SubItems.Add("");
                else
                    item.SubItems.Add(botInteractions);

                if (botId != null)
                {
                    item.SubItems.Add(botId);
                    item.Tag = tag;
                }
                else
                    item.Tag = "__noid";

                for (int i = 0; i < botList.Groups[groupKey].Items.Count; i++)
                {
                    if (botList.Groups[groupKey].Items[i].Tag != null &&
                        botList.Groups[groupKey].Items[i].Tag.ToString() == "__noid")
                        botList.Items.Remove(botList.Groups[groupKey].Items[i]);
                }

                botList.Items.Add(item);
                botList.Groups[groupKey].Items.Add(item);
            }));
        }

        /// <summary>Refreshes the bot list.</summary>
        private void refreshBotList()
        {
            PostSubmitter popular_list = new PostSubmitter();

            popular_list.Url = "http://www.pandorabots.com/botmaster/en/mostactive";
            popular_list.Type = PostSubmitter.PostTypeEnum.Get;

            string list_html = string.Empty;

            bool error;

            do
            {
                error = false;
                try { list_html = popular_list.Post(); }
                catch (WebException) { error = true; }
            }
            while (error &&
                MessageBox.Show(this, "Could not connect to Pandora Bots.", "Network error", MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Warning) == DialogResult.Retry);

            if (error)
            {
                BotName = null;
                BotId = null;
                return;
            }

            ClearList();

            string pattern =
                "<td.*>\\s*<a.*?href\\s*=\\s*[\"\']/pandora/talk\\?botid=(?<botid>.*?)[\'\"].*?>" +
                "(?<botname>.*)</a>\\s*</td>\\s*<td.*>\\s*(?<interactions>\\d+)\\s*</td>";

            Regex regx = new Regex(pattern);
            MatchCollection matches = regx.Matches(list_html);

            if (matches.Count > 0)
            {
                foreach (Match m in matches)
                {
                    GroupCollection g = m.Groups;

                    Group botId = g["botid"];
                    Group botName = g["botname"];
                    Group botInteractions = g["interactions"];

                    if (!botName.Success || !botId.Success)
                        continue;

                    AddBot("popular",
                        HttpUtility.HtmlDecode(botName.Value),
                        HttpUtility.HtmlDecode(botId.Value),
                        HttpUtility.HtmlDecode(botInteractions.Value));
                }
            }
            else
                AddBot("popular", "List not available.");

            if (CustomBots != null)
            {
                foreach (PandoraBotRecord bot in CustomBots)
                    AddBot("custom", bot.Name, bot.Id);
            }
            else
                AddBot("custom", "None added.");
        }

        /// <summary>Handles the Click event of the btnOk control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (botList.SelectedItems[0].SubItems.Count > 2)
            {
                BotName = botList.SelectedItems[0].Text;
                BotId = botList.SelectedItems[0].SubItems[2].Text;
            }
        }

        /// <summary>Adjusts the listView columns.</summary>
        /// <param name="listView">The listView control.</param>
        private static void AdjustViewColumns(ListView listView)
        {
            int w = listView.Size.Width - SystemInformation.VerticalScrollBarWidth;

            switch (listView.BorderStyle)
            {
                case BorderStyle.Fixed3D: w -= 4; break;
                case BorderStyle.FixedSingle: w -= 2; break;
            }

            for (int ix = 0; ix < listView.Columns.Count; ++ix)
            {
                if (listView.Columns[ix].Width < w)
                    w -= listView.Columns[ix].Width;
                else
                {
                    listView.Columns[ix].Width = w;
                    // Hide columns that can't fit
                    for (int jx = ix + 1; jx < listView.Columns.Count; ++jx)
                        listView.Columns[jx].Width = 0;
                    return;
                }
            }

            // Widen first column to fill listView
            listView.Columns[0].Width += w;
        }

        /// <summary>Handles the Click event of the btnRefresh control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    this.UseWaitCursor = true;
                    btnRefresh.Enabled = false;
                    btnAdd.Enabled = false;
                    btnCancel.Enabled = false;
                    toolStripStatusImage.Visible = true;
                    toolStripStatusLabel.Text = "Loading...";
                }));

                refreshBotList();

                this.Invoke(new MethodInvoker(delegate
                {
                    this.UseWaitCursor = false;
                    btnRefresh.Enabled = true;
                    btnAdd.Enabled = true;
                    btnCancel.Enabled = true;
                    toolStripStatusImage.Visible = false;

                    IEnumerable<ListViewItem> items =
                        botList.Groups["popular"].Items.OfType<ListViewItem>();

                    int count = items.Where(i => i.SubItems.Count > 2).Count();

                    toolStripStatusLabel.Text = String.Format("{0} bot{1} available.",
                        count.ToString(), count == 1 ? string.Empty : "s");

                    AdjustViewColumns(botList);
                }));
            }));
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the botList control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void botList_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = botList.SelectedItems.Count > 0
                && botList.SelectedItems[0].SubItems.Count > 2;
        }

        /// <summary>Handles the Click event of the btnAdd control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            PandoraBotAddCustom frmCustom = new PandoraBotAddCustom();

            if (frmCustom.ShowDialog(this) == DialogResult.OK && frmCustom.BotRecord != null)
                AddBot("custom", frmCustom.BotRecord);
        }
    }

    /// <summary>
    /// Provides sorting for the ListView control.
    /// </summary>
    public class ListViewColumnSorter : IComparer
    {
        /// <summary>
        /// Case insensitive comparer object
        /// </summary>
        private CaseInsensitiveComparer ObjectCompare;

        /// <summary>
        /// Gets or sets the number of the column to which to apply the sorting operation (Defaults to '0').
        /// </summary>
        public int SortColumn { get; set; }

        /// <summary>
        /// Gets or sets the order of sorting to apply (for example, 'Ascending' or 'Descending').
        /// </summary>
        public SortOrder Order { get; set; }

        /// <summary>
        /// Class constructor.  Initializes various elements
        /// </summary>
        public ListViewColumnSorter()
        {
            // Initialize the column to '0'
            SortColumn = 0;

            // Initialize the sort order to 'none'
            Order = SortOrder.None;

            // Initialize the CaseInsensitiveComparer object
            ObjectCompare = new CaseInsensitiveComparer();
        }

        /// <summary>
        /// This method is inherited from the IComparer interface.  It compares the two objects passed using a case insensitive comparison.
        /// </summary>
        /// <param name="x">First object to be compared</param>
        /// <param name="y">Second object to be compared</param>
        /// <returns>The result of the comparison. "0" if equal, negative if 'x' is less than 'y' and positive if 'x' is greater than 'y'</returns>
        public int Compare(object x, object y)
        {
            int compareResult;
            ListViewItem listviewX, listviewY;

            // Cast the objects to be compared to ListViewItem objects
            listviewX = (ListViewItem)x;
            listviewY = (ListViewItem)y;

            // Compare the two items

            if (SortColumn < listviewX.SubItems.Count && SortColumn < listviewY.SubItems.Count)
                compareResult = ObjectCompare.Compare(listviewX.SubItems[SortColumn].Text, listviewY.SubItems[SortColumn].Text);
            else
                compareResult = 0;

            // Calculate correct return value based on object comparison
            if (Order == SortOrder.Ascending)
            {
                // Ascending sort is selected, return normal result of compare operation
                return compareResult;
            }
            else if (Order == SortOrder.Descending)
            {
                // Descending sort is selected, return negative result of compare operation
                return (-compareResult);
            }
            else
            {
                // Return '0' to indicate they are equal
                return 0;
            }
        }
    }

    /// <summary>Holds a bot record.</summary>
    public class PandoraBotRecord
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PandoraBotRecord"/> class.
        /// </summary>
        public PandoraBotRecord()
        {
            this.Name = null;
            this.Id = null;
            this.Interactions = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PandoraBotRecord"/> class.
        /// </summary>
        /// <param name="Name">The name.</param>
        /// <param name="Id">The id.</param>
        /// <param name="Interactions">Number of interactions.</param>
        public PandoraBotRecord(string Name, string Id, string Interactions = null)
        {
            this.Name = Name;
            this.Id = Id;
            this.Interactions = Interactions;
        }

        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>Gets or sets the id.</summary>
        /// <value>The id.</value>
        public string Id { get; set; }

        /// <summary>Gets or sets the interactions.</summary>
        /// <value>Number of interactions.</value>
        public string Interactions { get; set; }
    }
}