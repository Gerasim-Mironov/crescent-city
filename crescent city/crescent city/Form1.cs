using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crescent_city
{
    public partial class Form1 : Form
    {
        private int[,] net = new int[,] { { 0, 0, 0 },
                                          { 0, 0, 0 },
                                          { 0, 0, 0 } };
        public Form1()
        {
            InitializeComponent();

            greetings vh = new greetings();
            DialogResult melly = vh.ShowDialog();

            switch(melly)
            {
                case DialogResult.Yes:
                    {

                    }break;
                case DialogResult.No:
                    {

                    }break;
            }
        }

        private int soloGameplay()
        {
            //fill  it...
            return 0x29a;
        }
        private int duoGameplay()
        {
            //fill  it...
            return 0x29a;
        }

        internal void finishingAnimation(int winner)
        {
            switch(winner)
            {
                case 0:
                    {
                        MessageBox.Show("ничья", "god's voice");
                    }break;
                case 1:
                    {
                        MessageBox.Show("красава, победил!", "god's voice");
                    }break;
                case 2:
                    {
                        MessageBox.Show("хахаха, лооол...", "god's voice");
                    }break;
                default:
                    {
                        MessageBox.Show("///vrrrrr beep beeep;", "god's voice");
                        this.Close();
                    }break;
            }
        }
    }
}
