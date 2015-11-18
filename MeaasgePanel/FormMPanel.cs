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
        PictureBox[][] picBox;
        int xPicBox = 3;
        int yPicBox = 3;
        public FormMPanel()
        {
            InitializeComponent();
            initPicBox(xPicBox, yPicBox); //初始化picbox并显示
            

        }
        private void initPicBox(int xPicBox, int yPicBox)
        {
            for (int i = 0; i < xPicBox; i++)
                for (int j = 0; j < yPicBox; j++)
                { 
                    picBox[i][j] = new PictureBox(); 
                    picBox[i][j].Location = new Point(20 + j * 10 ,30 + i * 10);
                }
        }

    }
}
