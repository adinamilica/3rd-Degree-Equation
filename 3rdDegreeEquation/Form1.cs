namespace _3rdDegreeEquation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RootsCalculator_Click(object sender, EventArgs e)
        {
            Complex p = new Complex();
            Complex q = new Complex();
            Complex delta = new Complex();

            Complex a = new Complex();
            a.Re = Convert.ToInt32(Coefficient_a_re.Text);
            a.Im = Convert.ToInt32(Coefficient_a_Im.Text);

            Complex b = new Complex();
            b.Re = Convert.ToInt32(Coefficient_b_re.Text);
            b.Im = Convert.ToInt32(Coefficient_b_Im.Text);


            Complex c = new Complex();
            c.Re = Convert.ToInt32(Coefficient_c_re.Text);
            c.Im = Convert.ToInt32(Coefficient_c_Im.Text);


            Complex d = new Complex();
            d.Re = Convert.ToInt32(Coefficient_d_re.Text);
            d.Im = Convert.ToInt32(Coefficient_d_Im.Text);



            Complex t = new Complex();

            Complex alpha = new Complex();

            Complex j=new Complex();
           

            Complex z1 = Complex.setReIm(0, 1);
            p = (-(b * b) + 3 * a * c) / (3 * a * a);
            q = (2 * b * b * b + 27 * d * a * a - 9 * a * b * c) / (27 * a * a * a);

            delta = q * q + (4 * p * p * p / 27);

            t = (-q + delta.sqrt(2)) / 2;

            alpha = t.sqrt(3);

            j = (-1 + z1 * Math.Sqrt(3)) / 2;

            Complex h = b / (3 * a);

            if(delta!=0)
            {

                Root1.Text = j.pow(0) * alpha - j.pow(2 * 0) * (p / (3 * alpha)) - h + " ";

                Root2.Text = j.pow(1) * alpha - j.pow(2 * 1) * (p / (3 * alpha)) - h + " ";

                Root3.Text = j.pow(2) * alpha - j.pow(2 * 2) * (p / (3 * alpha)) - h + " ";

            }

            else
            {

                alpha = (-p / 3).sqrt(2);

                Root1.Text = 2 * alpha - b / 3 * a + " ";

                Root2.Text = -alpha - b / 3 * a + " ";

            }




            
        }
    }
}