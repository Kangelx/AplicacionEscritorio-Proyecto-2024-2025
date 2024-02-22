using AplicacionIncidenciasProyecto.ControlVariables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AplicacionIncidenciasProyecto
{
    internal class VerificaciónEntradaDatos
    {
        static bool ValidarDNI(string dni)
        {
            // Comprobar la longitud del DNI
            if (dni.Length != 9)
                return false;

            // Extraer el número del DNI (los primeros 8 dígitos)
            string numerosDNI = dni.Substring(0, 8);

            // Extraer la letra del DNI (último carácter)
            char letraDNI = char.ToUpper(dni[8]);

            // Calcular la letra de control
            char letraControlCalculada = CalcularLetraControl(numerosDNI);

            // Verificar si la letra de control coincide con la calculada
            return letraControlCalculada == letraDNI;
        }

        static char CalcularLetraControl(string numerosDNI)
        {
            // Tabla de letras de control
            string tablaLetras = "TRWAGMYFPDXBNJZSQVHLCKE";

            // Calcular el índice de la tabla
            int indice = int.Parse(numerosDNI) % 23;

            // Devolver la letra correspondiente al índice calculado
            return tablaLetras[indice];
        }

        static bool verificaLongitudString(int longitud, string valor)
        {
            bool devuelve = false;
            if (valor.Length <= longitud) devuelve = true;
            return devuelve;

        }

        
    }
}
