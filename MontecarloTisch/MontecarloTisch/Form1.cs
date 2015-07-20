using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MontecarloTisch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 curPos = 10;
            Boolean[] personenBools = new bool[25];
            
            Int32 remaining;
            

            Random rnd = new Random();

            do
            {
                remaining = 25;

                if (personenBools[curPos] == false)
                {
                    personenBools[curPos] = true;
                }

                if (rnd.Next(1) == 0)
                {
                    curPos--;
                }
                else
                {
                    curPos++;
                }


                if (curPos < 0)
                {
                    curPos = personenBools.Length -1;
                }
                else if (curPos > personenBools.Length-1)
                {
                    curPos = 0;
                }

               

                foreach (Boolean person in personenBools)
                {
                    if (person)
                    {
                        remaining--;
                    }
                }

            } while
                (remaining != 0);

            MessageBox.Show(curPos.ToString() + " bekommt als Letzter Kuchen");

        }
    }
}