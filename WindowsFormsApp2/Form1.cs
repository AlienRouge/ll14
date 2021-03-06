using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        float[] _values;
        float _me;
        float _de;
        int n;
        readonly float[] _ranges = {7.8145f,14.057f,18.307f,22.362f };
        int _stage;

        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            var rnd = new Random();
            _me = (float)MeanValue.Value;
            _de = (float)DispersValue.Value;

            n = Convert.ToInt32(NumberOfExper.Text);
            _stage = NumberOfExper.SelectedIndex;
            _values = new float[n];
            float me2 = 0;
            float de2 = 0;
            for (int i = 0; i< n; i++)
            {
                double a1 = rnd.NextDouble();
                double a2 = rnd.NextDouble();
                double kor = Math.Sqrt(-2 * Math.Log(a1));
                double cos = Math.Cos(2 * Math.PI * a2);
                float x = (float)(kor * cos * Math.Sqrt(_de) + _me);
                _values[i] = x;
                me2 += x;
                de2 += (float)Math.Pow(x, 2);
            }
            me2 /= n;
            de2 /= n;
            de2 -= (float)Math.Pow(me2, 2);
            Stats(n, me2, de2);
        }



        void Stats(int numbers, float me2, float de2)
        {
            double max;
            var min = max = _values[0];
            foreach (var t in _values)
            {
                if (t < min) min = t;
                if (t > max) max = t;
            }
            double smallKoef = (max - min) * 0.05;
            double interval = (max - min) + smallKoef;
            
            int k = (int)Math.Round( Math.Log(numbers)/Math.Log(2) + 1);
            double step = interval / k;

            double q = min - smallKoef / 2;
            int[] stat = new int[k];
            float chi = 0;

            for (int i = 0; i < k; i++)
            {
                stat[i] = Check(q, q + step);
                float p = (float)(q + step - q) * Density( (float)(q + step + q) / 2);
                chi += (float)Math.Pow(stat[i], 2) / (numbers * p);
                chart1.Series[1].Points.AddXY(q,Density((float)(q + step + q) / 2));
                chart1.Series[0].Points.AddXY(q, (double)stat[i]/numbers);
                q += step;
            }

            chi -= numbers;
            SetStatInfo(chi,me2,de2);

            foreach (var t in stat)
            {
                Console.WriteLine(t);

            }
            Console.WriteLine(chi);
            Console.WriteLine("--------------" + k + "------------------");
        }


        private void SetStatInfo(float chi, float me2, float de2)
        {
            ResChi.Text = chi < _ranges[_stage] ? $"{chi} < {_ranges[_stage]}  is {false}" : $"{chi} > {_ranges[_stage]}  is {true}";
            RelAver.Text = $@"{me2} (error = {Math.Round(Math.Abs(me2 - _me) / Math.Abs(me2) * 100)}%)";
            RelVariance.Text = $@"{de2} (errors = {Math.Round(Math.Abs(de2 - _de) / Math.Abs(de2) * 100, 2)}%)";
        }

        private int Check(double a, double b )
        {
            return _values.Count(t => t >= a && t < b);
        }

        private float Density( float x)
        {
            var value = (float)Math.Pow(Math.E,Math.Pow((x - _me),2)/(-2*Math.Pow(_de,2)));
            return value/ (float)(_de * Math.Sqrt(2*Math.PI));
        }
    }
}
