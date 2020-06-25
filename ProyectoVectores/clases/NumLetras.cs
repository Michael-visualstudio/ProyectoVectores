using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVectores.clases
{
    public class NumLetras
    {
        private static string[] unidades = new string[]{"", "uno", "dos", "tres", "cuatro",
        "cinco", "seis", "siete", "ocho", "nueve", "diez", "once", "doce", "trece", "catorce",
        "quince", "diesiseis", "diesisiete", "diesiocho", "diesinueve"};

        private static string[] decenas = new string[] {"cero", "diez", "veinte", "treinta", "cuarenta",
        "cincuenta", "sesenta", "setenta", "ochenta", "noventa"};

        private static string[] centenas = new string[] {"cero","cien", "doscientos", "trescientos",
        "cuatrocientos", "quinientos", "seiscientos", "setecientos", "ochocientos",
        "novecientos"};

        private static string[] unidadmil = new string[] {"cero", "mil", "dosmil", "tresmil", "cuatromil",
        "cincomil", "seismil", "sietemil", "ochomil","nuevemil"};

        private static string[] decenamil = new string[] {"cero", "diezmil", "veintemil", "treintamil", "cuarentamil",
        "cincuentamil", "sesentamil", "setentamil", "ochentamil","noventamil"};

        private static string[] centenamil = new string[] {"cero", "cienmil", "doscientosmil", "trescientosmil", "cuatroscientomil",
        "quinientosmil", "seiscientosmil", "setescientosmil", "ochoscientosmil","novecientosmil"};

        private static string[] unidadmillones = new string[] {"cero", "un millon", "dosmilones", "tresmillones", "cuatromillones",
        "cincomillones", "seismillones", "sietemillones", "ochomillones","nuevemillones"};

        private static string[] decenamillones = new string[] {"cero", "diezmil", "veintemil", "treintamil", "cuarentamil",
        "cincuentamillones", "sesentamillones", "setentamillones", "ochentamillones","noventamillones"};

        private static string[] centenamillones = new string[] {"cero", "cienmil", "doscientosmillones", "trescientosmillones", "cuatroscientomillones",
        "quinientosmillones", "seiscientosmillones", "setescientosmillones", "ochoscientosmillones","novecientosmillones"};

        public static string getUnidades(int num)
        {
            string aux = "";
            if (num < 20)
                aux = unidades[num];
            else if (num == 0)
                aux = "cero";
            return aux;
        }
        public static string getDecenas(int num)
        {
            string aux = "";
            if (num >= 20 && num < 100)
            {
                aux = decenas[num / 10];
                if (num % 10 != 0)
                {
                    aux = aux + " y " + unidades[num % 10];
                }
            }
            return aux;
        }
        public static string getLetras(int num)
        {
            string aux = "";
            if (num < 20)
                aux = getUnidades(num);
            else if (num < 100)
                aux = getDecenas(num);
            else if (num < 1000)
            {
                if (num == 100)
                    aux = "cien";
                aux = centenas[num / 100];
                if(num % 100 < 20)
                {
                    aux = aux + " " + getUnidades(num % 100);
                }
                else
                    aux = aux + " " + getDecenas(num % 100);
            }
            return aux;
        }
        public static Int32 getMayor(int num)
        {
            Int32 i = 10;
            while(i< num)
            {
                i *= 10;
            }
            return i;
        }
    }
}
