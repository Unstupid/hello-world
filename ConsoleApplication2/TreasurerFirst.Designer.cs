namespace ConsoleApplication2
{
    partial class TreasurerFirst
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
            this.LogOutTreasurer_btn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Rent_btn = new System.Windows.Forms.Button();
            this.SeedStuff_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogOutTreasurer_btn
            // 
            this.LogOutTreasurer_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LogOutTreasurer_btn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutTreasurer_btn.ForeColor = System.Drawing.Color.Yellow;
            this.LogOutTreasurer_btn.Location = new System.Drawing.Point(151, 149);
            this.LogOutTreasurer_btn.Name = "LogOutTreasurer_btn";
            this.LogOutTreasurer_btn.Size = new System.Drawing.Size(105, 72);
            this.LogOutTreasurer_btn.TabIndex = 1;
            this.LogOutTreasurer_btn.Text = "Log Out";
            this.LogOutTreasurer_btn.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(20, 149);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 72);
            this.button4.TabIndex = 3;
            this.button4.Text = "Edit Treasurer";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Rent_btn
            // 
            this.Rent_btn.BackgroundImage = global::ConsoleApplication2.Properties.Resources.Piggybank;
            this.Rent_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Rent_btn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rent_btn.Location = new System.Drawing.Point(20, 36);
            this.Rent_btn.Name = "Rent_btn";
            this.Rent_btn.Size = new System.Drawing.Size(105, 73);
            this.Rent_btn.TabIndex = 0;
            this.Rent_btn.Text = "Rent Stuff";
            this.Rent_btn.UseMnemonic = false;
            this.Rent_btn.UseVisualStyleBackColor = true;
            this.Rent_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // SeedStuff_btn
            // 
            this.SeedStuff_btn.BackgroundImage = global::ConsoleApplication2.Properties.Resources.Seeds;
            this.SeedStuff_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeedStuff_btn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeedStuff_btn.Location = new System.Drawing.Point(151, 36);
            this.SeedStuff_btn.Name = "SeedStuff_btn";
            this.SeedStuff_btn.Size = new System.Drawing.Size(105, 73);
            this.SeedStuff_btn.TabIndex = 2;
            this.SeedStuff_btn.Text = "Seed Stuff";
            this.SeedStuff_btn.UseVisualStyleBackColor = true;
            // 
            // TreasurerFirst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.SeedStuff_btn);
            this.Controls.Add(this.LogOutTreasurer_btn);
            this.Controls.Add(this.Rent_btn);
            this.Name = "TreasurerFirst";
            this.Text = "Pick Something To Do";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Rent_btn;
        private System.Windows.Forms.Button LogOutTreasurer_btn;
        private System.Windows.Forms.Button SeedStuff_btn;
        private System.Windows.Forms.Button button4;
    }
}