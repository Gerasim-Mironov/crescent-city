using System;
using System.Collections;
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
        private int[,] net;
        private Panel[,] blocks;

        private bool xturn = true;

        private bool soloGame = true;
        public Form1()
        {
            InitializeComponent();

            net = new int[3, 3] { { 0, 0, 0 },
                                  { 0, 0, 0 },
                                  { 0, 0, 0 } };
            blocks = new Panel[3, 3] { {panel1, panel2, panel3},
                                     {panel4, panel5, panel6 },
                                     {panel7, panel8, panel9 } };

            greetings vh = new greetings();
            DialogResult melly = vh.ShowDialog();

            switch(melly)
            {
                case DialogResult.Yes:
                    {
                        soloGame = true;
                    }break;
                case DialogResult.No:
                    {
                        soloGame = false;
                    }break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (soloGame == false)
            {
                foreach (Panel item in blocks)
                {
                    item.Click += panelClick;
                }
            }
            else
            {
                foreach(Panel item in blocks)
                {
                    item.Click += Karmageddon;
                }
            }
        }        


        private void panelClick(object sender, EventArgs e)
        {
            Panel lang = sender as Panel;

            Graphics g = Graphics.FromHwnd(lang.Handle);
            
            for (uint m = 0; m < 3; m++)
            {
                for (uint t = 0; t < 3; t++)
                {
                    if (blocks[m, t] == lang)
                    {
                        if (net[m, t] != 0)
                            break;
                        else
                        {
                            if (xturn == true)
                            {
                                Pen p = new Pen(Brushes.Blue, 3f);

                                g.DrawLine(p, 0, 0, 120, 120);
                                g.DrawLine(p, 120, 0, 0, 120);


                                for (uint i = 0; i < 3; i++)
                                {
                                    for (uint l = 0; l < 3; l++)
                                    {
                                        if (blocks[i, l] == lang)
                                        {
                                            net[i, l] = 1;
                                        }
                                    }
                                }
                                xturn = false;
                            }
                            else
                            {
                                Pen p = new Pen(Brushes.Red, 3f);

                                g.DrawEllipse(p, 0, 0, 122, 115);

                                for (uint i = 0; i < 3; i++)
                                {
                                    for (uint l = 0; l < 3; l++)
                                    {
                                        if (blocks[i, l] == lang)
                                        {
                                            net[i, l] = 2;
                                        }
                                    }
                                }
                                xturn = true;
                            }

                            uint cvv = check();
                            finishingAnimation(cvv);
                        }
                    }
                }
            }
        }
        private void Karmageddon(object sender, EventArgs e)
        {
            Panel lang = sender as Panel;

            Graphics g = Graphics.FromHwnd(lang.Handle);

            for (uint m = 0; m < 3; m++)
            {
                for (uint t = 0; t < 3; t++)
                {
                    if (blocks[m, t] == lang)
                    {
                        if (net[m, t] != 0)
                            break;
                        else
                        {
                            Pen p = new Pen(Brushes.Blue, 3f);

                            g.DrawLine(p, 0, 0, 120, 120);
                            g.DrawLine(p, 120, 0, 0, 120);

                            for (uint i = 0; i < 3; i++)
                            {
                                for (uint l = 0; l < 3; l++)
                                {
                                    if (blocks[i, l] == lang)
                                    {
                                        net[i, l] = 1;
                                    }
                                }
                            }
                            
                            uint crl = check();
                            finishingAnimation(crl);
                        }
                    }
                }
            }

            bool cycleMatter = false;
            for (uint s = 0; s < 3; s++)
            {
                for (uint l = 0; l < 3; l++)
                {
                    if (net[s, l] == 0)
                    {
                        net[s, l] = 2;

                        lang = blocks[s, l];
                        g = Graphics.FromHwnd(lang.Handle);
                        Pen p = new Pen(Brushes.Red, 3f);
                        g.DrawEllipse(p, 0, 0, 122, 115);

                        cycleMatter = true;
                    }

                    if (cycleMatter == true)
                        break;
                }

                if (cycleMatter == true)
                    break;
            }


            uint cvv = check();
            finishingAnimation(cvv);
        }

        internal uint check()
        {
            if (net[0, 0] == 1 && net[0, 1] == 1 && net[0, 2] == 1)
                return 1;
            if (net[1, 0] == 1 && net[1, 1] == 1 && net[1, 2] == 1)
                return 1;
            if (net[2, 0] == 1 && net[2, 1] == 1 && net[2, 2] == 1)
                return 1;
            if (net[0, 0] == 1 && net[1, 0] == 1 && net[2, 0] == 1)
                return 1;
            if (net[1, 0] == 1 && net[1, 1] == 1 && net[1, 2] == 1)
                return 1;
            if (net[0, 0] == 1 && net[1, 1] == 1 && net[2, 0] == 1)
                return 1;
            if (net[2, 0] == 1 && net[1, 1] == 1 && net[0, 2] == 1)
                return 1;
            if (net[0, 2] == 1 && net[1, 1] == 1 && net[2, 2] == 1)
                return 1;
            if (net[0, 2] == 1 && net[1, 0] == 1 && net[2, 0] == 1)
                return 1;

            if (net[0, 0] == 2 && net[0, 1] == 2 && net[0, 2] == 2)
                return 2;
            if (net[1, 0] == 2 && net[1, 1] == 2 && net[1, 2] == 2)
                return 2;
            if (net[2, 0] == 2 && net[2, 1] == 2 && net[2, 2] == 2)
                return 2;
            if (net[0, 0] == 2 && net[1, 0] == 2 && net[2, 0] == 2)
                return 2;
            if (net[1, 0] == 2 && net[1, 1] == 2 && net[1, 2] == 2)
                return 2;
            if (net[0, 0] == 2 && net[1, 1] == 2 && net[2, 0] == 2)
                return 2;
            if (net[2, 0] == 2 && net[1, 1] == 2 && net[0, 2] == 2)
                return 2;
            if (net[0, 2] == 2 && net[1, 1] == 2 && net[2, 2] == 2)
                return 2;
            if (net[0, 2] == 2 && net[1, 0] == 2 && net[2, 0] == 2)
                return 2;

            if (draw() == false)
            {
                ;
            }
            else
                return 3;

            return 0;
        }
        internal bool draw()
        {
            foreach(int item in net)
            {
                if(item == 0)
                {
                    return false;
                }
            }

            return true;
        }

        internal void finishingAnimation(uint winner)
        {
            switch (winner)
            {
                case 3:
                    {
                        MessageBox.Show("ничья.", "игра говорит");
                        this.Refresh();
                        refreshTable();
                    }
                    break;
                case 1:
                    {
                        MessageBox.Show("крестики победили.", "игра говорит");
                        this.Refresh();
                        refreshTable();
                    }
                    break;
                case 2:
                    {
                        MessageBox.Show("нолики победили.", "игра говорит");
                        this.Refresh();
                        refreshTable();
                    }
                    break;
                default:
                    {

                    }
                    break;
            }
        }

        internal void refreshTable()
        {
            net = new int[3, 3] { { 0, 0, 0 },
                                  { 0, 0, 0 },
                                  { 0, 0, 0 } };
        }

    }
}
