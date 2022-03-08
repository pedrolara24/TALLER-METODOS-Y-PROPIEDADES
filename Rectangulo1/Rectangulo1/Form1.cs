using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rectangulo1
{
    public partial class Form1 : Form
    {
        Graphics grafico;
        public Form1()
        {
            InitializeComponent();
            grafico = CreateGraphics();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtX_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtY_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            try
            {
                double xInicio = double.Parse(txtXinicial.Text);
                double yInicio = double.Parse(txtYinicial.Text);
                double xFinal = double.Parse(txtXfinal.Text);
                double yFinal = double.Parse(txtYfinal.Text);

                clsLineas Rectangulo = new clsLineas(xInicio, yInicio, xFinal, yFinal);

                Pen blackPen = new Pen(Color.Black, 3);

                PointF point1 = new PointF(Rectangulo.obtenXInicio(), Rectangulo.obtenYInicio());
                PointF point2 = new PointF(Rectangulo.obtenXFinal(), Rectangulo.obtenYFinal());

                grafico.DrawLine(blackPen, point1, point2);

                txtCantidadLineas.Text = Convert.ToString(clsLineas.obtenCuenta());

            }
            catch (Exception)
            {

                MessageBox.Show("Digite el valor en tipo numerico");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
