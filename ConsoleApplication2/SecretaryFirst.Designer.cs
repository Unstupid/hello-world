namespace ConsoleApplication2
{
    partial class SecretaryFirst
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
            this.LogOnDetailsSecretary_btn = new System.Windows.Forms.Button();
            this.Member_Details_btn = new System.Windows.Forms.Button();
            this.SeedStuff_btn = new System.Windows.Forms.Button();
            this.LogOutSecretary_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogOnDetailsSecretary_btn
            // 
            this.LogOnDetailsSecretary_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LogOnDetailsSecretary_btn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOnDetailsSecretary_btn.ForeColor = System.Drawing.Color.Yellow;
            this.LogOnDetailsSecretary_btn.Location = new System.Drawing.Point(28, 156);
            this.LogOnDetailsSecretary_btn.Name = "LogOnDetailsSecretary_btn";
            this.LogOnDetailsSecretary_btn.Size = new System.Drawing.Size(115, 72);
            this.LogOnDetailsSecretary_btn.TabIndex = 4;
            this.LogOnDetailsSecretary_btn.Text = "Edit Secretary";
            this.LogOnDetailsSecretary_btn.UseVisualStyleBackColor = false;
            this.LogOnDetailsSecretary_btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // Member_Details_btn
            // 
            this.Member_Details_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Member_Details_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Member_Details_btn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Member_Details_btn.ForeColor = System.Drawing.Color.Yellow;
            this.Member_Details_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Member_Details_btn.Location = new System.Drawing.Point(28, 24);
            this.Member_Details_btn.Name = "Member_Details_btn";
            this.Member_Details_btn.Size = new System.Drawing.Size(115, 72);
            this.Member_Details_btn.TabIndex = 7;
            this.Member_Details_btn.Text = "Edit Members Attributes";
            this.Member_Details_btn.UseVisualStyleBackColor = false;
            this.Member_Details_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // SeedStuff_btn
            // 
            this.SeedStuff_btn.BackgroundImage = global::ConsoleApplication2.Properties.Resources.Catalogue;
            this.SeedStuff_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SeedStuff_btn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeedStuff_btn.Location = new System.Drawing.Point(154, 24);
            this.SeedStuff_btn.Name = "SeedStuff_btn";
            this.SeedStuff_btn.Size = new System.Drawing.Size(118, 72);
            this.SeedStuff_btn.TabIndex = 5;
            this.SeedStuff_btn.Text = "Seed Catalogues";
            this.SeedStuff_btn.UseVisualStyleBackColor = true;
            this.SeedStuff_btn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // LogOutSecretary_btn
            // 
            this.LogOutSecretary_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LogOutSecretary_btn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutSecretary_btn.ForeColor = System.Drawing.Color.Yellow;
            this.LogOutSecretary_btn.Location = new System.Drawing.Point(154, 156);
            this.LogOutSecretary_btn.Name = "LogOutSecretary_btn";
            this.LogOutSecretary_btn.Size = new System.Drawing.Size(118, 72);
            this.LogOutSecretary_btn.TabIndex = 8;
            this.LogOutSecretary_btn.Text = "Log Out";
            this.LogOutSecretary_btn.UseVisualStyleBackColor = false;
            // 
            // SecretaryFirst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LogOutSecretary_btn);
            this.Controls.Add(this.Member_Details_btn);
            this.Controls.Add(this.SeedStuff_btn);
            this.Controls.Add(this.LogOnDetailsSecretary_btn);
            this.Name = "SecretaryFirst";
            this.Text = "Pick Something to do";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LogOnDetailsSecretary_btn;
        private System.Windows.Forms.Button SeedStuff_btn;
        private System.Windows.Forms.Button Member_Details_btn;
        private System.Windows.Forms.Button LogOutSecretary_btn;
    }
}