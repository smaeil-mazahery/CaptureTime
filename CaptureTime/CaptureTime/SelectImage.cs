using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaptureTime
{
    public partial class SelectImage : Form
    {
        public SelectImage()
        {
            InitializeComponent();

            ListViewItem listViewItem1 = new ListViewItem("1");

            this.lstv_Images.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            new ListViewItem("1"),
            new ListViewItem("2"),
            new ListViewItem("3"),
            new ListViewItem("4"),
            new ListViewItem("5"),
            new ListViewItem("6"),
            new ListViewItem("7"),
            new ListViewItem("8"),
            new ListViewItem("9"),
            new ListViewItem("10"),
            new ListViewItem("11")

            });


            ImageList imageListLarge = new ImageList();
            imageListLarge.Images.Add(Bitmap.FromFile(Environment.CurrentDirectory + "\\icon\\1.png"));
            imageListLarge.Images.Add(Bitmap.FromFile(Environment.CurrentDirectory + "\\icon\\2.png"));
            imageListLarge.Images.Add(Bitmap.FromFile(Environment.CurrentDirectory + "\\icon\\3.png"));
            imageListLarge.Images.Add(Bitmap.FromFile(Environment.CurrentDirectory + "\\icon\\4.png"));
            imageListLarge.Images.Add(Bitmap.FromFile(Environment.CurrentDirectory + "\\icon\\5.png"));
            imageListLarge.Images.Add(Bitmap.FromFile(Environment.CurrentDirectory + "\\icon\\6.png"));
            imageListLarge.Images.Add(Bitmap.FromFile(Environment.CurrentDirectory + "\\icon\\7.png"));
            imageListLarge.Images.Add(Bitmap.FromFile(Environment.CurrentDirectory + "\\icon\\8.png"));
            imageListLarge.Images.Add(Bitmap.FromFile(Environment.CurrentDirectory + "\\icon\\9.png"));
            imageListLarge.Images.Add(Bitmap.FromFile(Environment.CurrentDirectory + "\\icon\\10.png"));
            imageListLarge.Images.Add(Bitmap.FromFile(Environment.CurrentDirectory + "\\icon\\11.png"));
            imageListLarge.Images.Add(Bitmap.FromFile(Environment.CurrentDirectory + "\\icon\\12.png"));
            imageListLarge.ImageSize = new Size(32, 32);

            lstv_Images.LargeImageList = imageListLarge;

            lstv_Images.Items[0].ImageIndex = 0;
            lstv_Images.Items[1].ImageIndex = 1;
            lstv_Images.Items[2].ImageIndex = 2;
            lstv_Images.Items[3].ImageIndex = 3;
            lstv_Images.Items[4].ImageIndex = 4;
            lstv_Images.Items[5].ImageIndex = 5;
            lstv_Images.Items[6].ImageIndex = 6;
            lstv_Images.Items[7].ImageIndex = 7;
            lstv_Images.Items[8].ImageIndex = 8;
            lstv_Images.Items[9].ImageIndex = 9;
            lstv_Images.Items[10].ImageIndex = 10;


        }
        public int selectindex;
        public DialogResult Result;
        private void button1_Click(object sender, EventArgs e)
        {
            if(lstv_Images.SelectedItems.Count>0)
            {
                selectindex = lstv_Images.SelectedItems[0].Index;
                Result = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Select an Item");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Result = DialogResult.Cancel;
            this.Close();
        }
    }
}
