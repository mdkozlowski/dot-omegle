using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OmegleSharp
{
    public partial class PandoraBotAddCustom : Form
    {
        public PandoraBotRecord BotRecord { get; protected set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PandoraBotAddCustom"/> class.
        /// </summary>
        public PandoraBotAddCustom()
        {
            InitializeComponent();

            BotRecord = null;
        }

        /// <summary>Handles the Load event of the form.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void PandoraBotAddCustom_Load(object sender, EventArgs e)
        {
            if (BotRecord != null)
            {
                txtBotName.Text = BotRecord.Name;
                txtBotId.Text = BotRecord.Id;
            }

            txtBotName.Focus();
        }

        /// <summary>Handles the Enter/Click events of the TextBox controls.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void TextBox_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).SelectAll();
        }

        /// <summary>Handles the TextChanged event of the TextBox controls.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = txtBotId.Text.Trim().Length > 0 & txtBotName.Text.Length > 0;
        }

        /// <summary>Handles the Click event of the btnOk control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            BotRecord = new PandoraBotRecord(txtBotName.Text, txtBotId.Text);
        }

        /// <summary>Handles the Click event of the btnCancel control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            BotRecord = null;
        }
    }
}