namespace HashApp;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnquit = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.pnSelect = new System.Windows.Forms.Panel();
            this.rbSha512 = new System.Windows.Forms.RadioButton();
            this.rbsha384 = new System.Windows.Forms.RadioButton();
            this.rbSha256 = new System.Windows.Forms.RadioButton();
            this.rbSha1 = new System.Windows.Forms.RadioButton();
            this.rbMd5 = new System.Windows.Forms.RadioButton();
            this.btnApply = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.pnSelect.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(389, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnquit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 22);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // mnquit
            // 
            this.mnquit.Name = "mnquit";
            this.mnquit.Size = new System.Drawing.Size(107, 22);
            this.mnquit.Text = "&Quit";
            this.mnquit.Click += new System.EventHandler(this.mnquit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the text to hash:";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(15, 56);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtText.Size = new System.Drawing.Size(362, 67);
            this.txtText.TabIndex = 2;
            // 
            // pnSelect
            // 
            this.pnSelect.BackColor = System.Drawing.Color.White;
            this.pnSelect.Controls.Add(this.rbSha512);
            this.pnSelect.Controls.Add(this.rbsha384);
            this.pnSelect.Controls.Add(this.rbSha256);
            this.pnSelect.Controls.Add(this.rbSha1);
            this.pnSelect.Controls.Add(this.rbMd5);
            this.pnSelect.Location = new System.Drawing.Point(6, 129);
            this.pnSelect.Name = "pnSelect";
            this.pnSelect.Size = new System.Drawing.Size(383, 30);
            this.pnSelect.TabIndex = 3;
            // 
            // rbSha512
            // 
            this.rbSha512.AutoSize = true;
            this.rbSha512.Location = new System.Drawing.Point(300, 5);
            this.rbSha512.Name = "rbSha512";
            this.rbSha512.Size = new System.Drawing.Size(74, 20);
            this.rbSha512.TabIndex = 4;
            this.rbSha512.TabStop = true;
            this.rbSha512.Text = "SHA512";
            this.rbSha512.UseVisualStyleBackColor = true;
            // 
            // rbsha384
            // 
            this.rbsha384.AutoSize = true;
            this.rbsha384.Location = new System.Drawing.Point(220, 5);
            this.rbsha384.Name = "rbsha384";
            this.rbsha384.Size = new System.Drawing.Size(74, 20);
            this.rbsha384.TabIndex = 3;
            this.rbsha384.TabStop = true;
            this.rbsha384.Text = "SHA384";
            this.rbsha384.UseVisualStyleBackColor = true;
            // 
            // rbSha256
            // 
            this.rbSha256.AutoSize = true;
            this.rbSha256.Location = new System.Drawing.Point(140, 5);
            this.rbSha256.Name = "rbSha256";
            this.rbSha256.Size = new System.Drawing.Size(74, 20);
            this.rbSha256.TabIndex = 2;
            this.rbSha256.TabStop = true;
            this.rbSha256.Text = "SHA256";
            this.rbSha256.UseVisualStyleBackColor = true;
            // 
            // rbSha1
            // 
            this.rbSha1.AutoSize = true;
            this.rbSha1.Location = new System.Drawing.Point(69, 5);
            this.rbSha1.Name = "rbSha1";
            this.rbSha1.Size = new System.Drawing.Size(60, 20);
            this.rbSha1.TabIndex = 1;
            this.rbSha1.TabStop = true;
            this.rbSha1.Text = "SHA1";
            this.rbSha1.UseVisualStyleBackColor = true;
            // 
            // rbMd5
            // 
            this.rbMd5.AutoSize = true;
            this.rbMd5.Checked = true;
            this.rbMd5.Location = new System.Drawing.Point(10, 4);
            this.rbMd5.Name = "rbMd5";
            this.rbMd5.Size = new System.Drawing.Size(53, 20);
            this.rbMd5.TabIndex = 0;
            this.rbMd5.TabStop = true;
            this.rbMd5.Text = "MD5";
            this.rbMd5.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(271, 165);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(106, 32);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "output text:";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 203);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(362, 91);
            this.txtOutput.TabIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 300);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(389, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbStatus
            // 
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(389, 322);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.pnSelect);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Creating a Hash with C#";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnSelect.ResumeLayout(false);
            this.pnSelect.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
    
    private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnquit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Panel pnSelect;
        private System.Windows.Forms.RadioButton rbSha512;
        private System.Windows.Forms.RadioButton rbsha384;
        private System.Windows.Forms.RadioButton rbSha256;
        private System.Windows.Forms.RadioButton rbSha1;
        private System.Windows.Forms.RadioButton rbMd5;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbStatus;

    #endregion
}
