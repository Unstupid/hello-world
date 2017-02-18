namespace ConsoleApplication2
{
    partial class LogInScreen_form
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
            this.LogOn_btn = new System.Windows.Forms.Button();
            this.Username_lbl = new System.Windows.Forms.Label();
            this.Password_lbl = new System.Windows.Forms.Label();
            this.EnteredUsername_txt = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LogOn_btn
            // 
            this.LogOn_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LogOn_btn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOn_btn.ForeColor = System.Drawing.Color.Yellow;
            this.LogOn_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOn_btn.Location = new System.Drawing.Point(73, 174);
            this.LogOn_btn.Name = "LogOn_btn";
            this.LogOn_btn.Size = new System.Drawing.Size(127, 66);
            this.LogOn_btn.TabIndex = 0;
            this.LogOn_btn.Text = "Log On";
            this.LogOn_btn.UseVisualStyleBackColor = false;
            // 
            // Username_lbl
            // 
            this.Username_lbl.AutoSize = true;
            this.Username_lbl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_lbl.Location = new System.Drawing.Point(18, 53);
            this.Username_lbl.Name = "Username_lbl";
            this.Username_lbl.Size = new System.Drawing.Size(104, 18);
            this.Username_lbl.TabIndex = 1;
            this.Username_lbl.Text = "Username:";
            this.Username_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // Password_lbl
            // 
            this.Password_lbl.AutoSize = true;
            this.Password_lbl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_lbl.Location = new System.Drawing.Point(18, 116);
            this.Password_lbl.Name = "Password_lbl";
            this.Password_lbl.Size = new System.Drawing.Size(101, 18);
            this.Password_lbl.TabIndex = 2;
            this.Password_lbl.Text = "Password:";
            this.Password_lbl.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // EnteredUsername_txt
            // 
            this.EnteredUsername_txt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnteredUsername_txt.Location = new System.Drawing.Point(128, 50);
            this.EnteredUsername_txt.Name = "EnteredUsername_txt";
            this.EnteredUsername_txt.Size = new System.Drawing.Size(115, 27);
            this.EnteredUsername_txt.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(128, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 27);
            this.textBox2.TabIndex = 4;
            // 
            // LogInScreen_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.EnteredUsername_txt);
            this.Controls.Add(this.Password_lbl);
            this.Controls.Add(this.Username_lbl);
            this.Controls.Add(this.LogOn_btn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.Name = "LogInScreen_form";
            this.Text = "Log In Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogOn_btn;
        private System.Windows.Forms.Label Username_lbl;
        private System.Windows.Forms.Label Password_lbl;
        private System.Windows.Forms.TextBox EnteredUsername_txt;
        private System.Windows.Forms.TextBox textBox2;
    }
}