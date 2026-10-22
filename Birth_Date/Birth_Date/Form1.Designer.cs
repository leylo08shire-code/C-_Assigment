namespace Birth_Date
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtdayoftheweek = new System.Windows.Forms.Label();
            this.txtmonthtext = new System.Windows.Forms.Label();
            this.txtdayofmonth = new System.Windows.Forms.Label();
            this.txtyeartext = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dateoutputlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(156, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show Date";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(272, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(386, 319);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtdayoftheweek
            // 
            this.txtdayoftheweek.AutoSize = true;
            this.txtdayoftheweek.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdayoftheweek.Location = new System.Drawing.Point(173, 65);
            this.txtdayoftheweek.Name = "txtdayoftheweek";
            this.txtdayoftheweek.Size = new System.Drawing.Size(264, 29);
            this.txtdayoftheweek.TabIndex = 3;
            this.txtdayoftheweek.Text = "Enter the day of week";
            // 
            // txtmonthtext
            // 
            this.txtmonthtext.AutoSize = true;
            this.txtmonthtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmonthtext.Location = new System.Drawing.Point(98, 98);
            this.txtmonthtext.Name = "txtmonthtext";
            this.txtmonthtext.Size = new System.Drawing.Size(339, 29);
            this.txtmonthtext.TabIndex = 4;
            this.txtmonthtext.Text = "Enter the name of the month";
            this.txtmonthtext.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtdayofmonth
            // 
            this.txtdayofmonth.AutoSize = true;
            this.txtdayofmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdayofmonth.Location = new System.Drawing.Point(64, 131);
            this.txtdayofmonth.Name = "txtdayofmonth";
            this.txtdayofmonth.Size = new System.Drawing.Size(373, 29);
            this.txtdayofmonth.TabIndex = 5;
            this.txtdayofmonth.Text = "Enter the numeric day of month";
            // 
            // txtyeartext
            // 
            this.txtyeartext.AutoSize = true;
            this.txtyeartext.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtyeartext.Location = new System.Drawing.Point(262, 166);
            this.txtyeartext.Name = "txtyeartext";
            this.txtyeartext.Size = new System.Drawing.Size(175, 29);
            this.txtyeartext.TabIndex = 6;
            this.txtyeartext.Text = "Enter the year";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(455, 74);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(455, 107);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(455, 140);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(173, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(455, 175);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(173, 20);
            this.textBox4.TabIndex = 10;
            // 
            // dateoutputlabel
            // 
            this.dateoutputlabel.AutoSize = true;
            this.dateoutputlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dateoutputlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateoutputlabel.Location = new System.Drawing.Point(109, 215);
            this.dateoutputlabel.Name = "dateoutputlabel";
            this.dateoutputlabel.Size = new System.Drawing.Size(631, 89);
            this.dateoutputlabel.TabIndex = 11;
            this.dateoutputlabel.Text = "                                                                                 " +
    "       \r\n\r\n                                       ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateoutputlabel);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtyeartext);
            this.Controls.Add(this.txtdayofmonth);
            this.Controls.Add(this.txtmonthtext);
            this.Controls.Add(this.txtdayoftheweek);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label txtdayoftheweek;
        private System.Windows.Forms.Label txtmonthtext;
        private System.Windows.Forms.Label txtdayofmonth;
        private System.Windows.Forms.Label txtyeartext;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label dateoutputlabel;
    }
}

