
namespace SteamServerCreationTool.Forms
{
    partial class ServerListSearchForm
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
            this.SearchField = new System.Windows.Forms.TextBox();
            this.ResultsList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchField
            // 
            this.SearchField.Location = new System.Drawing.Point(6, 19);
            this.SearchField.Name = "SearchField";
            this.SearchField.Size = new System.Drawing.Size(266, 20);
            this.SearchField.TabIndex = 0;
            this.SearchField.TextChanged += new System.EventHandler(this.SearchField_TextChanged);
            // 
            // ResultsList
            // 
            this.ResultsList.FormattingEnabled = true;
            this.ResultsList.Location = new System.Drawing.Point(6, 19);
            this.ResultsList.Name = "ResultsList";
            this.ResultsList.ScrollAlwaysVisible = true;
            this.ResultsList.Size = new System.Drawing.Size(266, 160);
            this.ResultsList.TabIndex = 1;
            this.ResultsList.SelectedIndexChanged += new System.EventHandler(this.ResultsList_SelectedIndexChanged);
            this.ResultsList.DoubleClick += new System.EventHandler(this.ResultsList_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchField);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 49);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter a name of a server:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ResultsList);
            this.groupBox2.Location = new System.Drawing.Point(12, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 185);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select an item to select it in the application:";
            // 
            // ServerListSearchForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(302, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServerListSearchForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Server Search";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox SearchField;
        private System.Windows.Forms.ListBox ResultsList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}