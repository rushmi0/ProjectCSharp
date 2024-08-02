namespace Project
{
    partial class challenge
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
            this.txtjpn = new System.Windows.Forms.TextBox();
            this.txteng = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time_label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtjpn
            // 
            this.txtjpn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtjpn.Enabled = false;
            this.txtjpn.Font = new System.Drawing.Font("Nineteen Ninety Three", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtjpn.Location = new System.Drawing.Point(-2, -3);
            this.txtjpn.Name = "txtjpn";
            this.txtjpn.Size = new System.Drawing.Size(1020, 369);
            this.txtjpn.TabIndex = 5;
            this.txtjpn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txteng
            // 
            this.txteng.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txteng.Enabled = false;
            this.txteng.Font = new System.Drawing.Font("Nineteen Ninety Three", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txteng.Location = new System.Drawing.Point(-2, 454);
            this.txteng.Name = "txteng";
            this.txteng.Size = new System.Drawing.Size(1020, 80);
            this.txteng.TabIndex = 7;
            this.txteng.Text = "Type your answer here";
            this.txteng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txteng.Enter += new System.EventHandler(this.txteng_Enter);
            this.txteng.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txteng_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.Font = new System.Drawing.Font("Nineteen Ninety Three", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(419, 555);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 60);
            this.button1.TabIndex = 8;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Nineteen Ninety Three", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(127, 564);
            this.textName.MaxLength = 7;
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(180, 46);
            this.textName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nineteen Ninety Three", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 575);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "NAME";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.Font = new System.Drawing.Font("Nineteen Ninety Three", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(887, 580);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 35);
            this.button2.TabIndex = 11;
            this.button2.Text = "To menu";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time_label2
            // 
            this.time_label2.AutoSize = true;
            this.time_label2.Font = new System.Drawing.Font("Nineteen Ninety Three", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_label2.Location = new System.Drawing.Point(34, 23);
            this.time_label2.Name = "time_label2";
            this.time_label2.Size = new System.Drawing.Size(0, 35);
            this.time_label2.TabIndex = 12;
            this.time_label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Snow;
            this.button3.Font = new System.Drawing.Font("Nineteen Ninety Three", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(655, 555);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 60);
            this.button3.TabIndex = 13;
            this.button3.Text = "Save your score";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nineteen Ninety Three", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(491, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "You have 20 second to answer as fast as you can do.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nineteen Ninety Three", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Press key Enter to check your answer.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nineteen Ninety Three", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(36, 537);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "*Please insert name under 7 character";
            // 
            // challenge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 627);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.time_label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txteng);
            this.Controls.Add(this.txtjpn);
            this.MaximumSize = new System.Drawing.Size(1037, 674);
            this.MinimumSize = new System.Drawing.Size(1037, 674);
            this.Name = "challenge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Challenge";
            this.Load += new System.EventHandler(this.challenge_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtjpn;
        private System.Windows.Forms.TextBox txteng;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label time_label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}