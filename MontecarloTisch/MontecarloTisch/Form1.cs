using System;
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
            var curPos = 10;
            var personenBools = new bool[25];
            
            Int32 remaining;
            
            var rnd = new Random();

            do
            {
                remaining = 25;

                if (personenBools[curPos] == false)
                {
                    personenBools[curPos] = true;
                }

                if (rnd.Next(2) == 0)
                {
                    curPos--;
                }
                else
                {
                    curPos++;
                }


                if (curPos < 0)
                {
                    curPos = personenBools.Length - 1;
                }
                else if (curPos > personenBools.Length - 1)
                {
                    curPos = 0;
                }


                foreach (var person in personenBools)
                {
                    if (person)
                    {
                        remaining--;
                    }
                }
            } while
                (remaining != 0);

            MessageBox.Show(curPos + " bekommt als Letzter Kuchen");
        }
    }
}