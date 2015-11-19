using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeaasgePanel
{
    public partial class FormMPanel : Form
    {
        PictureBox[,] picBox;
        int xPicBox = 3;
        int yPicBox = 3;
        public FormMPanel()
        {
            InitializeComponent();

            initPicBox(xPicBox, yPicBox); //初始化picbox并显示
            

        }
        private void initPicBox(int xPicBox, int yPicBox)
        {
            picBox = new PictureBox[xPicBox, yPicBox];
            for (int i = 0; i < xPicBox; i++)
                for (int j = 0; j < yPicBox; j++)
                {
                    this.picBox[i, j] = new PictureBox();
                    this.picBox[i, j].Name = "pbx"+ i.ToString() + j.ToString();
                    this.picBox[i, j].Location = new Point(20 + j * 40, 30 + i * 40);
                    this.picBox[i, j].SizeMode = PictureBoxSizeMode.AutoSize;
                    this.picBox[i, j].Size = new System.Drawing.Size(64, 36);
                    this.picBox[i, j].TabStop = false;
                    this.picBox[i, j].Image = iltMPanel.Images[0];
                    
                    this.picBox[i, j].Click += new System.EventHandler(this.picBox_Click);
                    Controls.Add(picBox[i, j]);
                    
                }
           
        }

        private void FormMPanel_Load(object sender, EventArgs e)
        {

        }

        private void picBox_Click(object sender, EventArgs e)
        {
            string str = (sender as PictureBox).Name;
            int i = Convert.ToInt32(str.Substring(3,1));
            int j = Convert.ToInt32(str.Substring(4,1));
            showAllPbx();
            picBox[i, j].Hide();
        }
        private void showAllPbx()
        {
            for (int i = 0; i < xPicBox; i++)
                for (int j = 0; j < yPicBox; j++)
                {
                    this.picBox[i, j].Show();                 
                }
        }



    }
}
