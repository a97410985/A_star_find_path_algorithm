using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_star_find_path_algorithm
{
    public partial class Form1 : Form
    {
        const int ROW = 10;
        const int COL = 10;
        const int gridWid = 70;
        const int gridHgt = 70;
        const int UpperLeftCornerX = 30;
        const int UpperLeftCornerY = 30;


        Button[,] BtnMap = new Button[COL, ROW]; // x先，y後
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_setup_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < COL; i++)
            {
                for (int j = 0; j < ROW; j++)
                {
                    BtnMap[i, j] = new Button();
                    Controls.Add(BtnMap[i, j]);
                    BtnMap[i, j].Location = new Point(UpperLeftCornerX+i*gridWid, UpperLeftCornerY+j*gridHgt);
                    BtnMap[i, j].Width = gridWid;
                    BtnMap[i, j].Height = gridHgt;
                    BtnMap[i, j].Text = "12  34\n\n56";
                }
            }
            btn_setup.Enabled = false;
        }
    }
}
