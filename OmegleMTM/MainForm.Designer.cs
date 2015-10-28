namespace OmegleMTM
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveChatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyTagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetChatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.CurrentStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbText = new System.Windows.Forms.TextBox();
            this.lbStrangers = new System.Windows.Forms.ListBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnConversationConnect = new System.Windows.Forms.Button();
            this.tlpChatWindow = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1197, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveChatToolStripMenuItem,
            this.modifyTagsToolStripMenuItem,
            this.resetChatToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(64, 38);
            this.fIleToolStripMenuItem.Text = "File";
            // 
            // saveChatToolStripMenuItem
            // 
            this.saveChatToolStripMenuItem.Name = "saveChatToolStripMenuItem";
            this.saveChatToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.saveChatToolStripMenuItem.Text = "Save Chat";
            this.saveChatToolStripMenuItem.Click += new System.EventHandler(this.saveChatToolStripMenuItem_Click);
            // 
            // modifyTagsToolStripMenuItem
            // 
            this.modifyTagsToolStripMenuItem.Name = "modifyTagsToolStripMenuItem";
            this.modifyTagsToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.modifyTagsToolStripMenuItem.Text = "Modify Tags";
            this.modifyTagsToolStripMenuItem.Click += new System.EventHandler(this.modifyTagsToolStripMenuItem_Click);
            // 
            // resetChatToolStripMenuItem
            // 
            this.resetChatToolStripMenuItem.Name = "resetChatToolStripMenuItem";
            this.resetChatToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.resetChatToolStripMenuItem.Text = "Reset Chat";
            this.resetChatToolStripMenuItem.Click += new System.EventHandler(this.resetChatToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 38);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 38);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CurrentStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1115);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1197, 37);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "MainStatusStrip";
            // 
            // CurrentStatus
            // 
            this.CurrentStatus.Name = "CurrentStatus";
            this.CurrentStatus.Size = new System.Drawing.Size(159, 32);
            this.CurrentStatus.Text = "CurrentStatus";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.tbText);
            this.panel1.Controls.Add(this.lbStrangers);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.btnConversationConnect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 1015);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1197, 100);
            this.panel1.TabIndex = 2;
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(347, 6);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(677, 89);
            this.tbText.TabIndex = 3;
            // 
            // lbStrangers
            // 
            this.lbStrangers.FormattingEnabled = true;
            this.lbStrangers.ItemHeight = 25;
            this.lbStrangers.Items.AddRange(new object[] {
            "Stranger1",
            "Stranger2"});
            this.lbStrangers.Location = new System.Drawing.Point(165, 4);
            this.lbStrangers.Name = "lbStrangers";
            this.lbStrangers.Size = new System.Drawing.Size(173, 79);
            this.lbStrangers.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(1030, 11);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(148, 85);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnConversationConnect
            // 
            this.btnConversationConnect.Location = new System.Drawing.Point(12, 6);
            this.btnConversationConnect.Name = "btnConversationConnect";
            this.btnConversationConnect.Size = new System.Drawing.Size(146, 91);
            this.btnConversationConnect.TabIndex = 0;
            this.btnConversationConnect.Text = "Connect";
            this.btnConversationConnect.UseVisualStyleBackColor = true;
            this.btnConversationConnect.Click += new System.EventHandler(this.btnConversationConnect_Click);
            // 
            // tlpChatWindow
            // 
            this.tlpChatWindow.ColumnCount = 1;
            this.tlpChatWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpChatWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpChatWindow.Location = new System.Drawing.Point(0, 42);
            this.tlpChatWindow.Name = "tlpChatWindow";
            this.tlpChatWindow.RowCount = 1;
            this.tlpChatWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpChatWindow.Size = new System.Drawing.Size(1197, 973);
            this.tlpChatWindow.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 1152);
            this.Controls.Add(this.tlpChatWindow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "OmegleMTM";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveChatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel CurrentStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnConversationConnect;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.ListBox lbStrangers;
        private System.Windows.Forms.TableLayoutPanel tlpChatWindow;
        private System.Windows.Forms.ToolStripMenuItem modifyTagsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetChatToolStripMenuItem;
    }
}

