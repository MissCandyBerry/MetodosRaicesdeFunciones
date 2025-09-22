using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_de_Raices_de_Funciones.Implementaciones
{
    public class IteracionResultado
    {
        public double Xi { get; set; }
        public double Xf { get; set; }
        public double Xr { get; set; }
        public double FxXi { get; set; }
        public double FxXr { get; set; }
        public double Producto { get; set; }
        public double Ea { get; set; }
    }

    public class MetodosRaices
    {
        public List<IteracionResultado> Iteraciones { get; private set; } = new List<IteracionResultado>();

        // Metodo de Biseccion
        public double Biseccion(double xi, double xf, double eamax, Func<double, double> f)
        {
            Iteraciones.Clear();
            double xr = 0, ea = 100;
            double xrold = 0;
            int iter = 0;

            do
            {
                xrold = xr;
                xr = (xi + xf) / 2.0;
                double fxi = f(xi);
                double fxr = f(xr);
                double producto = fxi * fxr;

                if (iter == 0)
                    ea = double.NaN;
                else
                    ea = Math.Abs((xr - xrold) / xr) * 100.0;

                Iteraciones.Add(new IteracionResultado
                {
                    Xi = xi,
                    Xf = xf,
                    Xr = xr,
                    FxXi = fxi,
                    FxXr = fxr,
                    Producto = producto,
                    Ea = ea
                });

                // Seleccion de intervalo
                if (producto < 0)
                    xf = xr;
                else
                    xi = xr;

                iter++;
                if (iter > 1000) break;
            } while (iter == 1 || ea > eamax);

            return xr;
        }

        // Metodo de la Regla Falsa
        public double ReglaFalsa(double xi, double xf, double eamax, Func<double, double> f)
        {
            Iteraciones.Clear();
            double xr = xi, ea = 100;
            double xrold = xr;
            int iter = 0;

            do
            {
                xrold = xr;
                double fxi = f(xi);
                double fxf = f(xf);
                xr = xf - fxf * (xi - xf) / (fxi - fxf);
                double fxr = f(xr);
                double producto = fxi * fxr;

                if (iter == 0)
                    ea = double.NaN;
                else
                    ea = Math.Abs((xr - xrold) / xr) * 100.0;

                Iteraciones.Add(new IteracionResultado
                {
                    Xi = xi,
                    Xf = xf,
                    Xr = xr,
                    FxXi = fxi,
                    FxXr = fxr,
                    Producto = producto,
                    Ea = ea
                });

                // Selección de intervalo
                if (producto < 0)
                    xf = xr;
                else
                    xi = xr;

                iter++;
                if (iter > 1000) break;
            } while (iter == 1 || ea > eamax);

            return xr;
        }
    }
}

