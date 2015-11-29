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
        Expert expert;
        PictureBox[,] picBox;
        Label[,] lblBox;
        int xPicBox =5;  //定义x轴生成多少个信息板
        int yPicBox = 5;  //定义y轴生成多少个信息板

        bool timerStarted;//定义timer控件是否打开
        double timeToCount = 0.00;//允许用户查看的时间

        public FormMPanel()
        {
            InitializeComponent();
            init();
        }
        public void init()
        {
            expert = new Expert();
            initLbl(xPicBox, yPicBox); 
            initPicBox(xPicBox, yPicBox); //初始化picbox并显示
            
            timerStarted = false;
            labelShowTime.Text = timeToCount.ToString();
        }
        private void initLbl(int xPicBox, int yPicBox)
        {
            lblBox = new Label[xPicBox, yPicBox];
           
            for (int i = 0; i < xPicBox; i++)
                for (int j = 0; j < yPicBox; j++)
                {
                    this.lblBox[i, j] = new Label();
                    this.lblBox[i, j].Name = "lbl" + i.ToString() + j.ToString();
                    this.lblBox[i, j].Location = new Point(20 + j * 70, 30 + i * 60);
                    this.lblBox[i, j].Size =  new System.Drawing.Size(64, 36);
                    this.lblBox[i, j].TextAlign = ContentAlignment.TopLeft;                   
                    this.lblBox[i, j].Text = expert.numTable[i, j].ToString();                   
                    this.lblBox[i, j].Hide();
                    Controls.Add(lblBox[i, j]);
                }
        }
        private void initPicBox(int xPicBox, int yPicBox)
        {
            picBox = new PictureBox[xPicBox, yPicBox];
            for (int i = 0; i < xPicBox; i++)
                for (int j = 0; j < yPicBox; j++)
                {
                    this.picBox[i, j] = new PictureBox();
                    this.picBox[i, j].Name = "pbx"+ i.ToString() + j.ToString();
                    this.picBox[i, j].Location = new Point(20 + j * 70, 30 + i * 60);
                    this.picBox[i, j].SizeMode = PictureBoxSizeMode.AutoSize;
//                    this.picBox[i, j].Size = new System.Drawing.Size(64, 36);
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
            
            if(!timerStarted)
            {
                timer.Start();
                timerStarted = true;
            }
            if(timeToCount >= 0)
            {
                string str = (sender as PictureBox).Name;
                int i = Convert.ToInt32(str.Substring(3, 1));
                int j = Convert.ToInt32(str.Substring(4, 1));
                Point nextPont = new Point(i, j);

                if (!expert.isNull())
                {
                    showOnePbx(expert.getLastPoint()); //显示上一个隐藏的一个PicBox
                }
                picBox[i, j].Hide();//隐藏当前PicBox
                lblBox[i, j].Show();
                expert.addPoint(nextPont);//将下一个点添加进路径中
            }

            updateTbx();
        }
        private void showAllPbx()
        {
            for (int i = 0; i < xPicBox; i++)
                for (int j = 0; j < yPicBox; j++)
                {
                    this.picBox[i, j].Show();
                    this.lblBox[i, j].Hide();
                }
        }
        private void showOnePbx(Point One)
        {
            this.lblBox[One.X, One.Y].Hide();
            this.picBox[One.X, One.Y].Show();

        }

        private void timer_Tick(object sender, EventArgs e)
        //实现倒计时
        {
           
                timeToCount += 0.01;
                labelShowTime.Text = timeToCount.ToString();                     
        }
        private void updateTbx()
        {
            tbxShowTrace.Text = expert.printTrace();
        }
        private void btnShowTrace_Click(object sender, EventArgs e)
        {

        }
    }
}
