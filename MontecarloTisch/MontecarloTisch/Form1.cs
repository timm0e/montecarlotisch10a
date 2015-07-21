using System;
using System.Diagnostics;
using System.Windows.Forms;

//Punkt von Person 0 = 1, nicht 0

namespace MontecarloTisch
{
    public partial class Form1 : Form
    {
        readonly Random _rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }


        private int Werkriegtdenkuchenalsletzter(int personenzahl, int startposition)
        {
            var curPos = startposition;
            var personenBools = new bool[personenzahl];

            Int32 remaining;

            

            while (true)
            {
                remaining = personenzahl;

                foreach (var person in personenBools)
                {
                    if (person)
                    {
                        remaining--;
                    }
                }

                if (remaining == 0)
                {
                    break;
                }

               
                

                if (_rnd.Next(2) == 0)
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


                if (personenBools[curPos] == false)
                {
                    personenBools[curPos] = true;
                }
               

               

            } 

            
            return curPos;
            
        }


        private void StartButton_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            chart1.Series[0].Points.Clear();

            for (int i = 0; i < (int) Personen.Value; i++)
            {
                chart1.Series[0].Points.AddXY(i + 1, 0);
            }

            progressBar1.Maximum = (int) Wiederholungen.Value;

            for (int i = 0; i < (int) Wiederholungen.Value; i++)
            {
                var loser = Werkriegtdenkuchenalsletzter((int) Personen.Value, (int) Startposition.Value);
                chart1.Series[0].Points[loser].SetValueY(chart1.Series[0].Points[loser].YValues[0] + 1);
                progressBar1.Value++;
            }
        }

        private void zufallsButton_Click(object sender, EventArgs e)
        {
            
            Startposition.Value = _rnd.Next((int) Personen.Value + 1);
        }
    }
}