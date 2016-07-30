using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaptureTime
{
    public partial class Form1 : Form
    {
        ImageList imageListLarge = new ImageList();
        public Form1()
        {
            InitializeComponent();

            ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "m",
            "ss1"}, -1, System.Drawing.Color.Empty, SystemColors.Highlight, null);

            this.lstv_ActivityList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});



            // Initialize the ImageList objects with bitmaps.

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

            imageListLarge.ImageSize = new Size(32, 32);

            lstv_ActivityList.LargeImageList = imageListLarge;


            img.Image = Bitmap.FromFile(Environment.CurrentDirectory + "\\icon\\11.png");

            lstv_ActivityList.Items[0].ImageIndex = 0;
            lstv_ActivityList.Items[1].ImageIndex = 1;
            lstv_ActivityList.Sort();
        }

        public struct Activity
        {
            public int ID;
            public string Name;
            public int ImageIndex;
            public TimeSpan TimeElapsed;
            public DateTime StartActivity;
            public DateTime PinTime;
            public bool Active;
            public bool Enable;
        }



        [Serializable]
        public class CTF
        {
            List<Activity> Activites = new List<Activity>();

            public void startactivity(int activityid)
            {
                if (!Activites[activityid].Active)

                    Activites[activityid] = new Activity() { Active = true, Enable = true, ID = activityid, Name = Activites[activityid].Name, StartActivity = Activites[activityid].StartActivity, PinTime = DateTime.Now, TimeElapsed = Activites[activityid].TimeElapsed };
            }
            public void stopactivity(int activityid)
            {
                if (Activites[activityid].Active)
                {
                    TimeSpan elapsed = DateTime.Now.Subtract(Activites[activityid].PinTime);
                    Activites[activityid] = new Activity() { Active = false, Enable = true, ID = activityid, Name = Activites[activityid].Name, StartActivity = Activites[activityid].StartActivity, PinTime = DateTime.Now, TimeElapsed = Activites[activityid].TimeElapsed + elapsed };

                }

            }
            public int count
            {
                get
                {
                    return Activites.Count;
                }
            }
            public void addactivity(Activity item)
            {
                Activites.Add(item);
            }
            public void deleteactivity(int activityid)
            {
                Activites.RemoveAt(activityid);
            }
        }
        public static void WriteToBinaryFile<t>(string filePath, t source, bool append = false)
        {
            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, source);
            }
        }
        public static t openviafile<t>(string filepath)
        {
            using (Stream stream = File.Open(filepath, FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (t)binaryFormatter.Deserialize(stream);
            }
        }
        CTF ctf_file = new CTF();
        private void Form1_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(Environment.CurrentDirectory + "Data.ctf"))
            {
                ctf_file = openviafile<CTF>(Environment.CurrentDirectory + "Data.ctf");
            }
            else
            {
                 ctf_file = new CTF();
            }
        }

        void updatelist()
        {

        }

        int selectindex;
        private void img_Click(object sender, EventArgs e)
        {
            SelectImage frm_img = new SelectImage();
            frm_img.ShowDialog();
            if (frm_img.Result == DialogResult.OK)
            {
                img.Image = Bitmap.FromFile(Environment.CurrentDirectory + "\\icon\\"+( frm_img.selectindex+1) + ".png");
                selectindex = frm_img.selectindex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_nameactivity.Text!="")
            {
                ctf_file.addactivity(new Activity() { Active = false, Enable = true, ID = ctf_file.count, ImageIndex = selectindex, Name = txt_nameactivity.Text, PinTime = DateTime.Now, StartActivity = DateTime.Now, TimeElapsed = TimeSpan.Zero });
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            WriteToBinaryFile<CTF>(Environment.CurrentDirectory + "Data.ctf", ctf_file);
        }
    }
}
