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
    public partial class TagsView : Form
    {

        public TagsView()
        {
            InitializeComponent();
        }
        public TagsView(string[] tags)
        {
            InitializeComponent();
            foreach (var t in tags)
                lbTags.Items.Add(t);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lbTags.Items.Add(tbTagEntry.Text);
            tbTagEntry.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var rmv = lbTags.SelectedIndex;
            lbTags.Items.RemoveAt(rmv);
        }
    }
}
