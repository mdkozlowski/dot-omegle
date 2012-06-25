namespace OmegleSharp
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.connectToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.reconnectToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.facebookToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.currentbotToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.botSelCleverbotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.botSelJabberwackyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.botsSeltPandoraBotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.botEnabledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.botStartsConversationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.restartBotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.textEntryBox = new System.Windows.Forms.TextBox();
            this.conversationBox = new System.Windows.Forms.WebBrowser();
            this.conversationTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLabel,
            this.statusStripTime});
            this.statusStrip.Location = new System.Drawing.Point(0, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.ShowItemToolTips = true;
            this.statusStrip.Size = new System.Drawing.Size(689, 22);
            this.statusStrip.TabIndex = 0;
            // 
            // statusStripLabel
            // 
            this.statusStripLabel.Name = "statusStripLabel";
            this.statusStripLabel.Size = new System.Drawing.Size(640, 17);
            this.statusStripLabel.Spring = true;
            this.statusStripLabel.Text = "statusStripLabel";
            this.statusStripLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusStripTime
            // 
            this.statusStripTime.Name = "statusStripTime";
            this.statusStripTime.Size = new System.Drawing.Size(34, 17);
            this.statusStripTime.Text = "Time";
            this.statusStripTime.ToolTipText = "Conversation time";
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripButton,
            this.reconnectToolStripButton,
            this.toolStripSeparator2,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.copyToolStripButton,
            this.toolStripSeparator3,
            this.facebookToolStripButton,
            this.toolStripSeparator1,
            this.helpToolStripButton,
            this.currentbotToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(689, 25);
            this.toolStrip.Stretch = true;
            this.toolStrip.TabIndex = 20;
            this.toolStrip.Text = "Toolbar";
            // 
            // connectToolStripButton
            // 
            this.connectToolStripButton.CheckOnClick = true;
            this.connectToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.connectToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("connectToolStripButton.Image")));
            this.connectToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.connectToolStripButton.Name = "connectToolStripButton";
            this.connectToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.connectToolStripButton.Text = "&Connect to Omegle (Ctrl+O)";
            this.connectToolStripButton.Click += new System.EventHandler(this.connectToolStripButton_Click);
            // 
            // reconnectToolStripButton
            // 
            this.reconnectToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.reconnectToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("reconnectToolStripButton.Image")));
            this.reconnectToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reconnectToolStripButton.Name = "reconnectToolStripButton";
            this.reconnectToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.reconnectToolStripButton.Text = "Reconnect (Ctrl+R)";
            this.reconnectToolStripButton.Click += new System.EventHandler(this.reconnectToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save log (Ctrl+S)";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "&Print (Ctrl+P)";
            this.printToolStripButton.Click += new System.EventHandler(this.printToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // facebookToolStripButton
            // 
            this.facebookToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.facebookToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("facebookToolStripButton.Image")));
            this.facebookToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.facebookToolStripButton.Name = "facebookToolStripButton";
            this.facebookToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.facebookToolStripButton.Text = "Fake &Facebook";
            this.facebookToolStripButton.ToolTipText = resources.GetString("facebookToolStripButton.ToolTipText");
            this.facebookToolStripButton.Click += new System.EventHandler(this.facebookToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator1.Visible = false;
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(29, 22);
            this.helpToolStripButton.Text = "He&lp";
            this.helpToolStripButton.Visible = false;
            // 
            // currentbotToolStripButton
            // 
            this.currentbotToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.currentbotToolStripButton.AutoToolTip = false;
            this.currentbotToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botSelCleverbotToolStripMenuItem,
            this.botSelJabberwackyToolStripMenuItem,
            this.botsSeltPandoraBotToolStripMenuItem,
            this.toolStripSeparator4,
            this.botEnabledToolStripMenuItem,
            this.botStartsConversationToolStripMenuItem,
            this.toolStripSeparator5,
            this.restartBotToolStripMenuItem});
            this.currentbotToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("currentbotToolStripButton.Image")));
            this.currentbotToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.currentbotToolStripButton.Name = "currentbotToolStripButton";
            this.currentbotToolStripButton.Size = new System.Drawing.Size(87, 22);
            this.currentbotToolStripButton.Text = "Cleverbot";
            // 
            // botSelCleverbotToolStripMenuItem
            // 
            this.botSelCleverbotToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("botSelCleverbotToolStripMenuItem.Image")));
            this.botSelCleverbotToolStripMenuItem.Name = "botSelCleverbotToolStripMenuItem";
            this.botSelCleverbotToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.botSelCleverbotToolStripMenuItem.Text = "Cleverbot";
            this.botSelCleverbotToolStripMenuItem.Click += new System.EventHandler(this.botSelCleverbotToolStripMenuItem_Click);
            // 
            // botSelJabberwackyToolStripMenuItem
            // 
            this.botSelJabberwackyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("botSelJabberwackyToolStripMenuItem.Image")));
            this.botSelJabberwackyToolStripMenuItem.Name = "botSelJabberwackyToolStripMenuItem";
            this.botSelJabberwackyToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.botSelJabberwackyToolStripMenuItem.Text = "Jabberwacky";
            this.botSelJabberwackyToolStripMenuItem.Click += new System.EventHandler(this.botSelJabberwackyToolStripMenuItem_Click);
            // 
            // botsSeltPandoraBotToolStripMenuItem
            // 
            this.botsSeltPandoraBotToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("botsSeltPandoraBotToolStripMenuItem.Image")));
            this.botsSeltPandoraBotToolStripMenuItem.Name = "botsSeltPandoraBotToolStripMenuItem";
            this.botsSeltPandoraBotToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.botsSeltPandoraBotToolStripMenuItem.Text = "Pandora Bots...";
            this.botsSeltPandoraBotToolStripMenuItem.Click += new System.EventHandler(this.botsSeltPandoraBotToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(209, 6);
            // 
            // botEnabledToolStripMenuItem
            // 
            this.botEnabledToolStripMenuItem.Checked = true;
            this.botEnabledToolStripMenuItem.CheckOnClick = true;
            this.botEnabledToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.botEnabledToolStripMenuItem.Name = "botEnabledToolStripMenuItem";
            this.botEnabledToolStripMenuItem.ShortcutKeyDisplayString = "PgUp";
            this.botEnabledToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.botEnabledToolStripMenuItem.Text = "&Enabled";
            // 
            // botStartsConversationToolStripMenuItem
            // 
            this.botStartsConversationToolStripMenuItem.CheckOnClick = true;
            this.botStartsConversationToolStripMenuItem.Name = "botStartsConversationToolStripMenuItem";
            this.botStartsConversationToolStripMenuItem.ShortcutKeyDisplayString = "PgDn";
            this.botStartsConversationToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.botStartsConversationToolStripMenuItem.Text = "&Starts Conversation";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(209, 6);
            // 
            // restartBotToolStripMenuItem
            // 
            this.restartBotToolStripMenuItem.Name = "restartBotToolStripMenuItem";
            this.restartBotToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.restartBotToolStripMenuItem.Text = "&Restart bot";
            this.restartBotToolStripMenuItem.Click += new System.EventHandler(this.restartBotToolStripMenuItem_Click);
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.BottomToolStripPanel
            // 
            this.toolStripContainer.BottomToolStripPanel.Controls.Add(this.statusStrip);
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.AutoScroll = true;
            this.toolStripContainer.ContentPanel.Controls.Add(this.tableLayoutPanel);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(689, 386);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(689, 433);
            this.toolStripContainer.TabIndex = 21;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.textEntryBox, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.conversationBox, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(689, 386);
            this.tableLayoutPanel.TabIndex = 19;
            // 
            // textEntryBox
            // 
            this.textEntryBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEntryBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEntryBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEntryBox.Location = new System.Drawing.Point(4, 358);
            this.textEntryBox.Name = "textEntryBox";
            this.textEntryBox.Size = new System.Drawing.Size(681, 20);
            this.textEntryBox.TabIndex = 18;
            this.textEntryBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textEntryBox_KeyUp);
            // 
            // conversationBox
            // 
            this.conversationBox.AllowNavigation = false;
            this.conversationBox.AllowWebBrowserDrop = false;
            this.conversationBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conversationBox.Location = new System.Drawing.Point(1, 1);
            this.conversationBox.Margin = new System.Windows.Forms.Padding(0);
            this.conversationBox.MinimumSize = new System.Drawing.Size(20, 20);
            this.conversationBox.Name = "conversationBox";
            this.conversationBox.ScriptErrorsSuppressed = true;
            this.conversationBox.Size = new System.Drawing.Size(687, 353);
            this.conversationBox.TabIndex = 17;
            this.conversationBox.TabStop = false;
            // 
            // conversationTimer
            // 
            this.conversationTimer.Interval = 1000;
            this.conversationTimer.Tick += new System.EventHandler(this.conversationTimer_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 433);
            this.Controls.Add(this.toolStripContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "CleverOmegle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabel;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton helpToolStripButton;
        private System.Windows.Forms.ToolStripButton connectToolStripButton;
        private System.Windows.Forms.ToolStripButton reconnectToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton currentbotToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem botEnabledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem botStartsConversationToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton facebookToolStripButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TextBox textEntryBox;
        private System.Windows.Forms.WebBrowser conversationBox;
        private System.Windows.Forms.ToolStripStatusLabel statusStripTime;
        private System.Windows.Forms.Timer conversationTimer;
        private System.Windows.Forms.ToolStripMenuItem botSelCleverbotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem botsSeltPandoraBotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem botSelJabberwackyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem restartBotToolStripMenuItem;
    }
}

