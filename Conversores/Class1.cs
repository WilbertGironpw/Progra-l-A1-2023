using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversores
{

    class Class1
    {
        String[][] etiquetas = new String[][] {
            new String[] { "", "" },
            new String[] { "Dolar", "Euro", "Quetzal", "Lempira", "Colon SV", "Cordoba", "Colon CR", "Yenes", "Libras Esterlinas", "Rupia india"},
            new String[] { "Metro", "Pie cuadrado", "Vara cuadrada", "Yarda cuadrada", "Tarea", "Manzanas", "Hectareas",}
         };
        double[][] valores = new double[][] {
            new double[] { 1, 0.92, 7.86, 24.62, 8.75, 36.56, 535.14, 146.25, 0.79, 83.72 }, // Moneda
            new double[] { 1, 10.7639, 1.43, 1.19599, 0.002285714285, 0.0001434, 0.0001, }
        };

        public double convertir(int tipo, int de, int a, double cantidad)
        {
            return valores[tipo][a] / valores[tipo][de] * cantidad;
        }
    }
}
