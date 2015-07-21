using System;
using System.Windows.Forms;

namespace MontecarloTisch
{
    public partial class Form1 : Form
    {
        private readonly Random _rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private int Werkriegtdenkuchenalsletzter(int personenzahl, int startposition)
        {
            var curPos = startposition - 1;
            var personenBools = new bool[personenzahl];


            while (true)
            {
                var remaining = personenzahl;

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
            if ((int) Startposition.Value > (int) Personen.Value)
            {
                Startposition.Value = Personen.Value;
            }
            progressBar1.Value = 0;
            chart1.Series[0].Points.Clear();

            for (var i = 0; i < (int) Personen.Value; i++)
            {
                chart1.Series[0].Points.AddXY(i + 1, 0);
            }

            progressBar1.Maximum = (int) Wiederholungen.Value;

            for (var i = 0; i < (int) Wiederholungen.Value; i++)
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