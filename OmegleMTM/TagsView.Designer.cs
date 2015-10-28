namespace OmegleMTM
{
    partial class TagsView
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
            this.lbTags = new System.Windows.Forms.ListBox();
            this.tbTagEntry = new System.Windows.Forms.TextBox();
            this.flpOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.flpOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTags
            // 
            this.lbTags.FormattingEnabled = true;
            this.lbTags.ItemHeight = 25;
            this.lbTags.Location = new System.Drawing.Point(13, 13);
            this.lbTags.Name = "lbTags";
            this.lbTags.Size = new System.Drawing.Size(501, 604);
            this.lbTags.TabIndex = 0;
            // 
            // tbTagEntry
            // 
            this.tbTagEntry.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbTagEntry.Location = new System.Drawing.Point(0, 623);
            this.tbTagEntry.Multiline = true;
            this.tbTagEntry.Name = "tbTagEntry";
            this.tbTagEntry.Size = new System.Drawing.Size(690, 51);
            this.tbTagEntry.TabIndex = 1;
            // 
            // flpOptions
            // 
            this.flpOptions.Controls.Add(this.btnAdd);
            this.flpOptions.Controls.Add(this.btnRemove);
            this.flpOptions.Location = new System.Drawing.Point(521, 13);
            this.flpOptions.Name = "flpOptions";
            this.flpOptions.Size = new System.Drawing.Size(157, 604);
            this.flpOptions.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(154, 64);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(3, 73);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(154, 69);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // TagsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 674);
            this.Controls.Add(this.flpOptions);
            this.Controls.Add(this.tbTagEntry);
            this.Controls.Add(this.lbTags);
            this.Name = "TagsView";
            this.Text = "TagsView";
            this.flpOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbTagEntry;
        private System.Windows.Forms.FlowLayoutPanel flpOptions;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        public System.Windows.Forms.ListBox lbTags;
    }
}