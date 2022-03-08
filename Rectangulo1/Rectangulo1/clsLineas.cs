using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangulo1
{
    /// <summary>
    /// Pedro Andres Lara Campo
    /// Dibujar Lineas
    /// 07/03/2022
    /// </summary>
    class clsLineas
    {
        private int xInicio;
        private int yInicio;
        private int xFinal;
        private int yFinal;

        private static int contar = 0;
        public clsLineas()
        {
            xInicio = 0;
            yInicio = 0;
            xFinal = 0;
            yFinal = 0;
        }

        public clsLineas(int xInicio, int yInicio, int xFinal, int yFinal)
        {
            this.xInicio = xInicio;
            this.yInicio = yInicio;
            this.xFinal = xFinal;
            this.yFinal = yFinal;
        }

        public clsLineas(double xInicio, double yInicio, double xFinal, double yFinal)
        {
            this.xInicio = (int)xInicio;
            this.yInicio = (int)yInicio;
            this.xFinal = (int)xFinal;
            this.yFinal = (int)yFinal;
        }

        public int obtenXInicio()
        {
            return xInicio;
        }

        public int obtenYInicio()
        {
            return yInicio;
        }

        public int obtenXFinal()
        {
            return xFinal;
        }

        public int obtenYFinal()
        {
            return yFinal;
        }

        public void cambiarXInicio(int xInicio)
        {
            this.xInicio = xInicio;
        }

        public void cambiarYInicio(int yInicio)
        {
            this.yInicio = yInicio;
        }

        public void cambiarXFinal(int xFinal)
        {
            this.xFinal = xFinal;
        }

        public void cambiarYFinal(int yFinal)
        {
            this.yFinal = yFinal;
        }

        public static int obtenCuenta()
        {
            contar += 1;
            return contar;
        }
    }
}
