namespace CaptureTime
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("fff", 1);
            this.button1 = new System.Windows.Forms.Button();
            this.txt_nameactivity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstv_ActivityList = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_TodayTime = new System.Windows.Forms.Label();
            this.lbl_AllTime = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Activity";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_nameactivity
            // 
            this.txt_nameactivity.Location = new System.Drawing.Point(120, 383);
            this.txt_nameactivity.Name = "txt_nameactivity";
            this.txt_nameactivity.Size = new System.Drawing.Size(188, 22);
            this.txt_nameactivity.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name Activity:";
            // 
            // lstv_ActivityList
            // 
            this.lstv_ActivityList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.lstv_ActivityList.Location = new System.Drawing.Point(12, 12);
            this.lstv_ActivityList.Name = "lstv_ActivityList";
            this.lstv_ActivityList.Size = new System.Drawing.Size(296, 269);
            this.lstv_ActivityList.TabIndex = 3;
            this.lstv_ActivityList.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Today Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "All Time:";
            // 
            // lbl_TodayTime
            // 
            this.lbl_TodayTime.AutoSize = true;
            this.lbl_TodayTime.Location = new System.Drawing.Point(110, 307);
            this.lbl_TodayTime.Name = "lbl_TodayTime";
            this.lbl_TodayTime.Size = new System.Drawing.Size(16, 17);
            this.lbl_TodayTime.TabIndex = 4;
            this.lbl_TodayTime.Text = "0";
            // 
            // lbl_AllTime
            // 
            this.lbl_AllTime.AutoSize = true;
            this.lbl_AllTime.Location = new System.Drawing.Point(110, 335);
            this.lbl_AllTime.Name = "lbl_AllTime";
            this.lbl_AllTime.Size = new System.Drawing.Size(16, 17);
            this.lbl_AllTime.TabIndex = 4;
            this.lbl_AllTime.Text = "0";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LawnGreen;
            this.button2.Location = new System.Drawing.Point(236, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 51);
            this.button2.TabIndex = 5;
            this.button2.Text = "active";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(236, 343);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 33);
            this.button3.TabIndex = 6;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // img
            // 
            this.img.Location = new System.Drawing.Point(253, 411);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(55, 55);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img.TabIndex = 7;
            this.img.TabStop = false;
            this.img.Click += new System.EventHandler(this.img_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 511);
            this.Controls.Add(this.img);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl_AllTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_TodayTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstv_ActivityList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nameactivity);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_nameactivity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstv_ActivityList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_TodayTime;
        private System.Windows.Forms.Label lbl_AllTime;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox img;
    }
}

