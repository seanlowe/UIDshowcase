namespace WindowsFormsApplication1
{
    partial class frmQandA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQandA));
            this.flpQuestion = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlQ1 = new System.Windows.Forms.Panel();
            this.lblQ1 = new System.Windows.Forms.Label();
            this.pnlA1 = new System.Windows.Forms.Panel();
            this.lblA1 = new System.Windows.Forms.Label();
            this.pnlQ2 = new System.Windows.Forms.Panel();
            this.lblQ2 = new System.Windows.Forms.Label();
            this.pnlA2 = new System.Windows.Forms.Panel();
            this.lblA2 = new System.Windows.Forms.Label();
            this.pnlQ3 = new System.Windows.Forms.Panel();
            this.lblQ3 = new System.Windows.Forms.Label();
            this.pnlA3 = new System.Windows.Forms.Panel();
            this.lblA3 = new System.Windows.Forms.Label();
            this.pnlQ4 = new System.Windows.Forms.Panel();
            this.lblQ4 = new System.Windows.Forms.Label();
            this.pnlA4 = new System.Windows.Forms.Panel();
            this.lblA4 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.flpQuestion.SuspendLayout();
            this.pnlQ1.SuspendLayout();
            this.pnlA1.SuspendLayout();
            this.pnlQ2.SuspendLayout();
            this.pnlA2.SuspendLayout();
            this.pnlQ3.SuspendLayout();
            this.pnlA3.SuspendLayout();
            this.pnlQ4.SuspendLayout();
            this.pnlA4.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpQuestion
            // 
            this.flpQuestion.BackColor = System.Drawing.Color.Transparent;
            this.flpQuestion.Controls.Add(this.pnlQ1);
            this.flpQuestion.Controls.Add(this.pnlA1);
            this.flpQuestion.Controls.Add(this.pnlQ2);
            this.flpQuestion.Controls.Add(this.pnlA2);
            this.flpQuestion.Controls.Add(this.pnlQ3);
            this.flpQuestion.Controls.Add(this.pnlA3);
            this.flpQuestion.Controls.Add(this.pnlQ4);
            this.flpQuestion.Controls.Add(this.pnlA4);
            this.flpQuestion.Location = new System.Drawing.Point(1, 128);
            this.flpQuestion.Name = "flpQuestion";
            this.flpQuestion.Padding = new System.Windows.Forms.Padding(10);
            this.flpQuestion.Size = new System.Drawing.Size(963, 533);
            this.flpQuestion.TabIndex = 0;
            this.flpQuestion.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // pnlQ1
            // 
            this.pnlQ1.AutoSize = true;
            this.pnlQ1.Controls.Add(this.lblQ1);
            this.pnlQ1.Location = new System.Drawing.Point(13, 13);
            this.pnlQ1.Name = "pnlQ1";
            this.pnlQ1.Size = new System.Drawing.Size(441, 29);
            this.pnlQ1.TabIndex = 0;
            // 
            // lblQ1
            // 
            this.lblQ1.AutoSize = true;
            this.lblQ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ1.Location = new System.Drawing.Point(3, 0);
            this.lblQ1.Name = "lblQ1";
            this.lblQ1.Size = new System.Drawing.Size(435, 29);
            this.lblQ1.TabIndex = 0;
            this.lblQ1.Text = "How do I delete an Item from the order?";
            this.lblQ1.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // pnlA1
            // 
            this.pnlA1.AutoSize = true;
            this.pnlA1.Controls.Add(this.lblA1);
            this.pnlA1.Location = new System.Drawing.Point(13, 48);
            this.pnlA1.Name = "pnlA1";
            this.pnlA1.Size = new System.Drawing.Size(1713, 36);
            this.pnlA1.TabIndex = 1;
            // 
            // lblA1
            // 
            this.lblA1.AutoSize = true;
            this.lblA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA1.Location = new System.Drawing.Point(3, 11);
            this.lblA1.Name = "lblA1";
            this.lblA1.Size = new System.Drawing.Size(1707, 25);
            this.lblA1.TabIndex = 1;
            this.lblA1.Text = resources.GetString("lblA1.Text");
            this.lblA1.Visible = false;
            this.lblA1.Click += new System.EventHandler(this.label3_Click);
            // 
            // pnlQ2
            // 
            this.pnlQ2.AutoSize = true;
            this.pnlQ2.Controls.Add(this.lblQ2);
            this.pnlQ2.Location = new System.Drawing.Point(13, 90);
            this.pnlQ2.Name = "pnlQ2";
            this.pnlQ2.Size = new System.Drawing.Size(620, 29);
            this.pnlQ2.TabIndex = 2;
            // 
            // lblQ2
            // 
            this.lblQ2.AutoSize = true;
            this.lblQ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ2.Location = new System.Drawing.Point(3, 0);
            this.lblQ2.Name = "lblQ2";
            this.lblQ2.Size = new System.Drawing.Size(614, 29);
            this.lblQ2.TabIndex = 0;
            this.lblQ2.Text = "How do I add toppings and extras to certain order items?";
            this.lblQ2.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // pnlA2
            // 
            this.pnlA2.AutoSize = true;
            this.pnlA2.Controls.Add(this.lblA2);
            this.pnlA2.Location = new System.Drawing.Point(13, 125);
            this.pnlA2.Name = "pnlA2";
            this.pnlA2.Size = new System.Drawing.Size(2954, 36);
            this.pnlA2.TabIndex = 3;
            // 
            // lblA2
            // 
            this.lblA2.AutoSize = true;
            this.lblA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA2.Location = new System.Drawing.Point(3, 11);
            this.lblA2.Name = "lblA2";
            this.lblA2.Size = new System.Drawing.Size(2948, 25);
            this.lblA2.TabIndex = 1;
            this.lblA2.Text = resources.GetString("lblA2.Text");
            this.lblA2.Visible = false;
            this.lblA2.Click += new System.EventHandler(this.label5_Click);
            // 
            // pnlQ3
            // 
            this.pnlQ3.AutoSize = true;
            this.pnlQ3.Controls.Add(this.lblQ3);
            this.pnlQ3.Location = new System.Drawing.Point(13, 167);
            this.pnlQ3.Name = "pnlQ3";
            this.pnlQ3.Size = new System.Drawing.Size(436, 29);
            this.pnlQ3.TabIndex = 4;
            // 
            // lblQ3
            // 
            this.lblQ3.AutoSize = true;
            this.lblQ3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ3.Location = new System.Drawing.Point(3, 0);
            this.lblQ3.Name = "lblQ3";
            this.lblQ3.Size = new System.Drawing.Size(430, 29);
            this.lblQ3.TabIndex = 0;
            this.lblQ3.Text = "I need to refund an order, what do I do?";
            this.lblQ3.Click += new System.EventHandler(this.label6_Click);
            // 
            // pnlA3
            // 
            this.pnlA3.AutoSize = true;
            this.pnlA3.Controls.Add(this.lblA3);
            this.pnlA3.Location = new System.Drawing.Point(13, 202);
            this.pnlA3.Name = "pnlA3";
            this.pnlA3.Size = new System.Drawing.Size(2847, 36);
            this.pnlA3.TabIndex = 5;
            // 
            // lblA3
            // 
            this.lblA3.AutoSize = true;
            this.lblA3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA3.Location = new System.Drawing.Point(3, 11);
            this.lblA3.Name = "lblA3";
            this.lblA3.Size = new System.Drawing.Size(2841, 25);
            this.lblA3.TabIndex = 1;
            this.lblA3.Text = resources.GetString("lblA3.Text");
            this.lblA3.Visible = false;
            this.lblA3.Click += new System.EventHandler(this.label7_Click);
            // 
            // pnlQ4
            // 
            this.pnlQ4.AutoSize = true;
            this.pnlQ4.Controls.Add(this.lblQ4);
            this.pnlQ4.Location = new System.Drawing.Point(13, 244);
            this.pnlQ4.Name = "pnlQ4";
            this.pnlQ4.Size = new System.Drawing.Size(556, 29);
            this.pnlQ4.TabIndex = 6;
            // 
            // lblQ4
            // 
            this.lblQ4.AutoSize = true;
            this.lblQ4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ4.Location = new System.Drawing.Point(3, 0);
            this.lblQ4.Name = "lblQ4";
            this.lblQ4.Size = new System.Drawing.Size(550, 29);
            this.lblQ4.TabIndex = 0;
            this.lblQ4.Text = "How do I add employees to the register database?";
            this.lblQ4.Click += new System.EventHandler(this.label8_Click);
            // 
            // pnlA4
            // 
            this.pnlA4.AutoSize = true;
            this.pnlA4.Controls.Add(this.lblA4);
            this.pnlA4.Location = new System.Drawing.Point(13, 279);
            this.pnlA4.Name = "pnlA4";
            this.pnlA4.Size = new System.Drawing.Size(2963, 36);
            this.pnlA4.TabIndex = 7;
            // 
            // lblA4
            // 
            this.lblA4.AutoSize = true;
            this.lblA4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA4.Location = new System.Drawing.Point(3, 11);
            this.lblA4.Name = "lblA4";
            this.lblA4.Size = new System.Drawing.Size(2957, 25);
            this.lblA4.TabIndex = 1;
            this.lblA4.Text = resources.GetString("lblA4.Text");
            this.lblA4.Visible = false;
            this.lblA4.Click += new System.EventHandler(this.label9_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(432, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(62, 29);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "FAQ";
            // 
            // frmQandA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(967, 709);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.flpQuestion);
            this.Name = "frmQandA";
            this.Text = "Frequently Asked Questions";
            this.flpQuestion.ResumeLayout(false);
            this.flpQuestion.PerformLayout();
            this.pnlQ1.ResumeLayout(false);
            this.pnlQ1.PerformLayout();
            this.pnlA1.ResumeLayout(false);
            this.pnlA1.PerformLayout();
            this.pnlQ2.ResumeLayout(false);
            this.pnlQ2.PerformLayout();
            this.pnlA2.ResumeLayout(false);
            this.pnlA2.PerformLayout();
            this.pnlQ3.ResumeLayout(false);
            this.pnlQ3.PerformLayout();
            this.pnlA3.ResumeLayout(false);
            this.pnlA3.PerformLayout();
            this.pnlQ4.ResumeLayout(false);
            this.pnlQ4.PerformLayout();
            this.pnlA4.ResumeLayout(false);
            this.pnlA4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpQuestion;
        private System.Windows.Forms.Panel pnlQ1;
        private System.Windows.Forms.Panel pnlA1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblQ1;
        private System.Windows.Forms.Label lblA1;
        private System.Windows.Forms.Panel pnlQ2;
        private System.Windows.Forms.Label lblQ2;
        private System.Windows.Forms.Panel pnlA2;
        private System.Windows.Forms.Panel pnlQ3;
        private System.Windows.Forms.Label lblQ3;
        private System.Windows.Forms.Panel pnlA3;
        private System.Windows.Forms.Label lblA3;
        private System.Windows.Forms.Panel pnlQ4;
        private System.Windows.Forms.Label lblQ4;
        private System.Windows.Forms.Panel pnlA4;
        private System.Windows.Forms.Label lblA4;
        private System.Windows.Forms.Label lblA2;
    }
}

