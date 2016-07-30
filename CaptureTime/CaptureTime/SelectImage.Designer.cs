namespace CaptureTime
{
    partial class SelectImage
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
            this.lstv_Images = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstv_Images
            // 
            this.lstv_Images.Location = new System.Drawing.Point(12, 12);
            this.lstv_Images.Name = "lstv_Images";
            this.lstv_Images.Size = new System.Drawing.Size(419, 278);
            this.lstv_Images.TabIndex = 0;
            this.lstv_Images.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(220, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SelectImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 355);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstv_Images);
            this.Name = "SelectImage";
            this.Text = "SelectImage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstv_Images;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}