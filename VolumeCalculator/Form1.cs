using System.Diagnostics;

namespace VolumeCalculator
{
    public partial class Form1 : Form
    {
        //constant value of Pi used in program
        const double Pi = 3.14;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Button_Calculate_Click(object sender, EventArgs e)
        {
            if (RadioButton_Cube.Checked == true)
            {
                double Cube_s;
                double Cube_V;

                Cube_s = double.Parse(TextBox_Cube_s.Text);
                Cube_V = Math.Pow(Cube_s, 3);  //Formula: V = s^3
                TextBox_Cube_V.Text = Cube_V.ToString();
            }
            if (RadioButton_Prism.Checked == true)
            {
                double Prism_l; double Prism_w; double Prism_h;
                double Prism_V;

                Prism_l = double.Parse(TextBox_Prism_l.Text);
                Prism_w = double.Parse(TextBox_Prism_l.Text);
                Prism_h = double.Parse(TextBox_Prism_l.Text);
                Prism_V = Prism_l * Prism_w * Prism_h;  //formula: V = l* w * h
                TextBox_Prism_V.Text = Prism_V.ToString();
            }
            if (RadioButton_Cylinder.Checked == true)
            {
                double Cylinder_r; double Cylinder_h;
                double Cylinder_V;
                Cylinder_r = double.Parse(TextBox_Cylinder_r.Text);
                Cylinder_h = double.Parse(TextBox_Cylinder_h.Text);
                Cylinder_V = Pi * Math.Pow(Cylinder_r, 2) * Cylinder_h; // Formula: V = Pi * r^2 * h
                TextBox_Cylinder_V.Text = Cylinder_V.ToString();
            }

            if (RadioButton_Pyramid.Checked == true)
            {
                double Pyramid_s; double Pyramid_h;
                double Prism_V;

                Pyramid_s = double.Parse(TextBox_Pyramid_s.Text);
                Pyramid_h = double.Parse(TextBox_Pyramid_s.Text);

                Prism_V = (1.0 / 3.0) * Math.Pow(Pyramid_s, 2) * Pyramid_h; //Formula: V = (1/3) * s^3 * h
                TextBox_Pyramid_V.Text = Prism_V.ToString();
            }
        }
    }
}