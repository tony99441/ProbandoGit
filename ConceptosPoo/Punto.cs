using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConceptosPoo
{
    class Punto
    {
        public Punto(int x, int y) {

            this.x = x;
            this.y = y;
            contadorobjetos++;

        }
        public Punto() {

            this.x = 0;
            this.y = 0;
            contadorobjetos++;
        }

        public double MedirDistancia(Punto otroPunto) {
            int xdif = this.x - otroPunto.y;
            int ydfi = this.y - otroPunto.y;

            double distanciaPuntos = Math.Sqrt(Math.Pow(xdif, 2) + Math.Pow(ydfi, 2));
            return distanciaPuntos;

        }


        public static int contanto() {
            return contadorobjetos;
        }

        private int x, y;

    private static int contadorobjetos = 0;

}

}
