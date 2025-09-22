using Metodos_de_Raices_de_Funciones.Implementaciones;

namespace Metodos_de_Raices_de_Funciones
{
    public partial class Form1 : Form
    {
        MetodosRaices metodos = new MetodosRaices();

        public Form1()
        {
            InitializeComponent();
            cmbMetodo.SelectedIndex = 0;
            dgvIteraciones.AutoGenerateColumns = false;
            dgvIteraciones.Columns.Clear();
            dgvIteraciones.Columns.Add("xi", "xi");
            dgvIteraciones.Columns.Add("xf", "xf");
            dgvIteraciones.Columns.Add("xr", "xr");
            dgvIteraciones.Columns.Add("fxi", "f(xi)");
            dgvIteraciones.Columns.Add("fxr", "f(xr)");
            dgvIteraciones.Columns.Add("producto", "f(xi)·f(xr)");
            dgvIteraciones.Columns.Add("ea", "ea (%)");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double xi, xf, eamax;
            lblResultado.Text = "";
            dgvIteraciones.Rows.Clear();

            if (!double.TryParse(txtXi.Text, out xi) ||
                !double.TryParse(txtXf.Text, out xf) ||
                !double.TryParse(txtEamax.Text, out eamax))
            {
                MessageBox.Show("Por favor ingresa valores numericos validos.");
                return;
            }

            // Funcion a usar: y = x^3 - 5
            Func<double, double> f = (x) => Math.Pow(x, 3) - 5;
            double raiz = 0;

            if (cmbMetodo.SelectedItem.ToString() == "Biseccion")
                raiz = metodos.Biseccion(xi, xf, eamax, f);
            else
                raiz = metodos.ReglaFalsa(xi, xf, eamax, f);

            lblResultado.Text = $"Raiz aproximada: {raiz:F6}\nIteraciones: {metodos.Iteraciones.Count}";

            foreach (var it in metodos.Iteraciones)
            {
                dgvIteraciones.Rows.Add(
                    it.Xi.ToString("F6"),
                    it.Xf.ToString("F6"),
                    it.Xr.ToString("F6"),
                    it.FxXi.ToString("F6"),
                    it.FxXr.ToString("F6"),
                    it.Producto.ToString("F6"),
                    double.IsNaN(it.Ea) ? "" : it.Ea.ToString("F6")
                );
            }
        
    }
    }
}
