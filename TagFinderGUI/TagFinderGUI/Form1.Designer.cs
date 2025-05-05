namespace TagFinderGUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblUrl;
        private TextBox txtUrl;
        private Label lblTag;
        private TextBox txtTag;
        private Button btnFindTags;
        private ListBox lstResults;
        private Label lblStatus;
        private Panel topPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblUrl = new Label();
            txtUrl = new TextBox();
            lblTag = new Label();
            txtTag = new TextBox();
            btnFindTags = new Button();
            lstResults = new ListBox();
            lblStatus = new Label();
            topPanel = new Panel();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // lblUrl
            // 
            lblUrl.ForeColor = Color.White;
            lblUrl.Location = new Point(0, 15);
            lblUrl.Name = "lblUrl";
            lblUrl.Size = new Size(42, 23);
            lblUrl.TabIndex = 0;
            lblUrl.Text = "URL:";
            // 
            // txtUrl
            // 
            txtUrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUrl.Location = new Point(48, 15);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(489, 27);
            txtUrl.TabIndex = 1;
            // 
            // lblTag
            // 
            lblTag.ForeColor = Color.White;
            lblTag.Location = new Point(543, 19);
            lblTag.Name = "lblTag";
            lblTag.Size = new Size(48, 23);
            lblTag.TabIndex = 2;
            lblTag.Text = "Tag:";
            // 
            // txtTag
            // 
            txtTag.Location = new Point(597, 16);
            txtTag.Name = "txtTag";
            txtTag.Size = new Size(61, 27);
            txtTag.TabIndex = 3;
            // 
            // btnFindTags
            // 
            btnFindTags.BackColor = Color.MediumSlateBlue;
            btnFindTags.FlatStyle = FlatStyle.Flat;
            btnFindTags.Font = new Font("Snap ITC", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFindTags.ForeColor = Color.IndianRed;
            btnFindTags.Location = new Point(695, 13);
            btnFindTags.Name = "btnFindTags";
            btnFindTags.Size = new Size(75, 29);
            btnFindTags.TabIndex = 4;
            btnFindTags.Text = "GO";
            btnFindTags.UseVisualStyleBackColor = false;
            btnFindTags.Click += BtnFindTags_Click;
            // 
            // lstResults
            // 
            lstResults.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstResults.BackColor = Color.Turquoise;
            lstResults.Font = new Font("Consolas", 10F);
            lstResults.Location = new Point(10, 69);
            lstResults.Name = "lstResults";
            lstResults.Size = new Size(762, 384);
            lstResults.TabIndex = 0;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.Gray;
            lblStatus.Location = new Point(10, 370);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(53, 20);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Ready.";
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.DarkSlateBlue;
            topPanel.Controls.Add(lblUrl);
            topPanel.Controls.Add(txtUrl);
            topPanel.Controls.Add(lblTag);
            topPanel.Controls.Add(txtTag);
            topPanel.Controls.Add(btnFindTags);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Padding = new Padding(10);
            topPanel.Size = new Size(782, 50);
            topPanel.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(782, 465);
            Controls.Add(lstResults);
            Controls.Add(lblStatus);
            Controls.Add(topPanel);
            Name = "Form1";
            Text = "TagFinder";
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}