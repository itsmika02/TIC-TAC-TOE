namespace TIC_TAC_TOE_GAME
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGameMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonA1 = new System.Windows.Forms.Button();
            this.ButtonA2 = new System.Windows.Forms.Button();
            this.ButtonA3 = new System.Windows.Forms.Button();
            this.ButtonB1 = new System.Windows.Forms.Button();
            this.ButtonB2 = new System.Windows.Forms.Button();
            this.ButtonB3 = new System.Windows.Forms.Button();
            this.ButtonC1 = new System.Windows.Forms.Button();
            this.ButtonC2 = new System.Windows.Forms.Button();
            this.ButtonC3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuStrip,
            this.HelpMenuStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(526, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenuStrip
            // 
            this.FileMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGameMenuStrip,
            this.ExitMenuStrip});
            this.FileMenuStrip.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileMenuStrip.Name = "FileMenuStrip";
            this.FileMenuStrip.Size = new System.Drawing.Size(50, 24);
            this.FileMenuStrip.Text = "File";
            // 
            // HelpMenuStrip
            // 
            this.HelpMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuStrip});
            this.HelpMenuStrip.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpMenuStrip.Name = "HelpMenuStrip";
            this.HelpMenuStrip.Size = new System.Drawing.Size(61, 24);
            this.HelpMenuStrip.Text = "Help";
            // 
            // NewGameMenuStrip
            // 
            this.NewGameMenuStrip.Name = "NewGameMenuStrip";
            this.NewGameMenuStrip.Size = new System.Drawing.Size(224, 26);
            this.NewGameMenuStrip.Text = "NEW GAME";
            // 
            // ExitMenuStrip
            // 
            this.ExitMenuStrip.Name = "ExitMenuStrip";
            this.ExitMenuStrip.Size = new System.Drawing.Size(224, 26);
            this.ExitMenuStrip.Text = "EXIT";
            this.ExitMenuStrip.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // AboutMenuStrip
            // 
            this.AboutMenuStrip.Name = "AboutMenuStrip";
            this.AboutMenuStrip.Size = new System.Drawing.Size(224, 26);
            this.AboutMenuStrip.Text = "ABOUT";
            this.AboutMenuStrip.Click += new System.EventHandler(this.aBOUTToolStripMenuItem_Click);
            // 
            // ButtonA1
            // 
            this.ButtonA1.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonA1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ButtonA1.Image = ((System.Drawing.Image)(resources.GetObject("ButtonA1.Image")));
            this.ButtonA1.Location = new System.Drawing.Point(97, 75);
            this.ButtonA1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonA1.Name = "ButtonA1";
            this.ButtonA1.Size = new System.Drawing.Size(106, 101);
            this.ButtonA1.TabIndex = 1;
            this.ButtonA1.UseVisualStyleBackColor = true;
            this.ButtonA1.Click += new System.EventHandler(this.button_click);
            // 
            // ButtonA2
            // 
            this.ButtonA2.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonA2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ButtonA2.Image = ((System.Drawing.Image)(resources.GetObject("ButtonA2.Image")));
            this.ButtonA2.Location = new System.Drawing.Point(211, 75);
            this.ButtonA2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonA2.Name = "ButtonA2";
            this.ButtonA2.Size = new System.Drawing.Size(106, 101);
            this.ButtonA2.TabIndex = 2;
            this.ButtonA2.UseVisualStyleBackColor = true;
            this.ButtonA2.Click += new System.EventHandler(this.button_click);
            // 
            // ButtonA3
            // 
            this.ButtonA3.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonA3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ButtonA3.Image = ((System.Drawing.Image)(resources.GetObject("ButtonA3.Image")));
            this.ButtonA3.Location = new System.Drawing.Point(325, 75);
            this.ButtonA3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonA3.Name = "ButtonA3";
            this.ButtonA3.Size = new System.Drawing.Size(106, 101);
            this.ButtonA3.TabIndex = 3;
            this.ButtonA3.UseVisualStyleBackColor = true;
            this.ButtonA3.Click += new System.EventHandler(this.button_click);
            // 
            // ButtonB1
            // 
            this.ButtonB1.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonB1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ButtonB1.Image = ((System.Drawing.Image)(resources.GetObject("ButtonB1.Image")));
            this.ButtonB1.Location = new System.Drawing.Point(97, 182);
            this.ButtonB1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonB1.Name = "ButtonB1";
            this.ButtonB1.Size = new System.Drawing.Size(106, 101);
            this.ButtonB1.TabIndex = 4;
            this.ButtonB1.UseVisualStyleBackColor = true;
            this.ButtonB1.Click += new System.EventHandler(this.button_click);
            // 
            // ButtonB2
            // 
            this.ButtonB2.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonB2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ButtonB2.Image = ((System.Drawing.Image)(resources.GetObject("ButtonB2.Image")));
            this.ButtonB2.Location = new System.Drawing.Point(211, 182);
            this.ButtonB2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonB2.Name = "ButtonB2";
            this.ButtonB2.Size = new System.Drawing.Size(106, 101);
            this.ButtonB2.TabIndex = 5;
            this.ButtonB2.UseVisualStyleBackColor = true;
            this.ButtonB2.Click += new System.EventHandler(this.button_click);
            // 
            // ButtonB3
            // 
            this.ButtonB3.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonB3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ButtonB3.Image = ((System.Drawing.Image)(resources.GetObject("ButtonB3.Image")));
            this.ButtonB3.Location = new System.Drawing.Point(325, 182);
            this.ButtonB3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonB3.Name = "ButtonB3";
            this.ButtonB3.Size = new System.Drawing.Size(106, 101);
            this.ButtonB3.TabIndex = 6;
            this.ButtonB3.UseVisualStyleBackColor = true;
            this.ButtonB3.Click += new System.EventHandler(this.button_click);
            // 
            // ButtonC1
            // 
            this.ButtonC1.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonC1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ButtonC1.Image = ((System.Drawing.Image)(resources.GetObject("ButtonC1.Image")));
            this.ButtonC1.Location = new System.Drawing.Point(97, 291);
            this.ButtonC1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonC1.Name = "ButtonC1";
            this.ButtonC1.Size = new System.Drawing.Size(106, 101);
            this.ButtonC1.TabIndex = 7;
            this.ButtonC1.UseVisualStyleBackColor = true;
            this.ButtonC1.Click += new System.EventHandler(this.button_click);
            // 
            // ButtonC2
            // 
            this.ButtonC2.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonC2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ButtonC2.Image = ((System.Drawing.Image)(resources.GetObject("ButtonC2.Image")));
            this.ButtonC2.Location = new System.Drawing.Point(211, 291);
            this.ButtonC2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonC2.Name = "ButtonC2";
            this.ButtonC2.Size = new System.Drawing.Size(106, 101);
            this.ButtonC2.TabIndex = 8;
            this.ButtonC2.UseVisualStyleBackColor = true;
            this.ButtonC2.Click += new System.EventHandler(this.button_click);
            // 
            // ButtonC3
            // 
            this.ButtonC3.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonC3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ButtonC3.Image = ((System.Drawing.Image)(resources.GetObject("ButtonC3.Image")));
            this.ButtonC3.Location = new System.Drawing.Point(325, 291);
            this.ButtonC3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonC3.Name = "ButtonC3";
            this.ButtonC3.Size = new System.Drawing.Size(106, 101);
            this.ButtonC3.TabIndex = 9;
            this.ButtonC3.UseVisualStyleBackColor = true;
            this.ButtonC3.Click += new System.EventHandler(this.button_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(526, 437);
            this.Controls.Add(this.ButtonC3);
            this.Controls.Add(this.ButtonC2);
            this.Controls.Add(this.ButtonC1);
            this.Controls.Add(this.ButtonB3);
            this.Controls.Add(this.ButtonB2);
            this.Controls.Add(this.ButtonB1);
            this.Controls.Add(this.ButtonA3);
            this.Controls.Add(this.ButtonA2);
            this.Controls.Add(this.ButtonA1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "TIC TAC TOE";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem NewGameMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuStrip;
        private System.Windows.Forms.Button ButtonA1;
        private System.Windows.Forms.Button ButtonA2;
        private System.Windows.Forms.Button ButtonA3;
        private System.Windows.Forms.Button ButtonB1;
        private System.Windows.Forms.Button ButtonB2;
        private System.Windows.Forms.Button ButtonB3;
        private System.Windows.Forms.Button ButtonC1;
        private System.Windows.Forms.Button ButtonC2;
        private System.Windows.Forms.Button ButtonC3;
    }
}

