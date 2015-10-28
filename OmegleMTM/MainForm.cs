using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OmegleMTM
{
    public partial class MainForm : Form
    {
        MTM mtmConvo;
        public MainForm()
        {
            var newtags = new string[] { };
            mtmConvo = new MTM(newtags);
            InitializeComponent();
            this.tlpChatWindow.Controls.Add(mtmConvo.ChatBrowser.ChatBrowser);
            mtmConvo.ChatBrowser.ChatBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            mtmConvo.ChatBrowser.ChatBrowser.Location = new System.Drawing.Point(0, 40);
            mtmConvo.ChatBrowser.ChatBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            mtmConvo.ChatBrowser.ChatBrowser.Name = "wbChatWindow";
            mtmConvo.ChatBrowser.ChatBrowser.Size = new System.Drawing.Size(1197, 975);
            mtmConvo.StatusChanged += MtmConvo_StatusChanged;
        }

        private void MtmConvo_StatusChanged(object sender, MTM.StatusEventArgs se)
        {
            var text = "";
            if (se.Stranger1IsTyping)
                text += "Stranger1 is typing;";
            if (se.Stranger2IsTyping)
                text += "Stranger2 is typing;";
            CurrentStatus.Text = text;

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Run(new AboutBox());
            var ab = new AboutBox();
            ab.Show();
        }

        private void btnConversationConnect_Click(object sender, EventArgs e)
        {
            Action connect =
                () => mtmConvo.ConnectStrangers();
            connect.Invoke();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Action<MTM.Strangers, string> sendmessage =
                (st1, tbt) => mtmConvo.SendMessage(st1, tbt);
            if (lbStrangers.SelectedIndex == 0)
                sendmessage.Invoke(MTM.Strangers.Stranger1, tbText.Text);
            else
                sendmessage.Invoke(MTM.Strangers.Stranger2, tbText.Text);
        }
        private void modifyTagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var modifytags = new TagsView(mtmConvo.Tags.ToArray());
            modifytags.Show();
            modifytags.FormClosing += (s, events) =>
            {
                var items = modifytags.lbTags.Items.Cast<string>().ToList();
                mtmConvo.Tags = items;
            };
        }
        /// <summary>
        /// Opens the print dialog for the chat
        /// TODO: save as html, make printing a seperate option
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mtmConvo.ChatBrowser.ChatBrowser.ShowPrintDialog();
        }

        private void resetChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //mtmConvo.ChatBrowser.PrintMessage("OmegleMTM", "ChatReser", Color.DarkGreen);
            Action reset = () => mtmConvo.Reset();
            reset.Invoke();
        }
    }
}
