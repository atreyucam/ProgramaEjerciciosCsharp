using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaEjercicios
{
    internal class ClaseInfonumero
    {
        private int numero;
        RespuestaCorrecta correcta = new RespuestaCorrecta();
        mensajeError error = new mensajeError();
        public ClaseInfonumero()
        {

        }

        public void primo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if ((numero % i) == 0)
                {
                    error.respuestaError("El número " + numero + " no es primo");
                    error.ShowDialog();
                }
            }
            correcta.mostrarRespuestaTexto("El número " + numero + " es primo");
            correcta.ShowDialog();

        }
        public void perfecto(int numero)
        {
            int sum = 0;
            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    sum += i;
                }
            }
            if (numero == sum)
            {
                correcta.mostrarRespuestaTexto("El número " + numero + " es perfecto");
                correcta.ShowDialog();
            }
            else
            {
                error.respuestaError("El número " + numero + " no es perfecto");
                error.ShowDialog();
            }
        }
        public void capicua(int numero)
        {
            int aux = numero;
            int invertido = 0;
            while (aux > 0)
            {
                invertido = invertido * 10 + aux % 10;
                aux /= 10;
            }
            if (numero == invertido)
            {
                correcta.mostrarRespuestaTexto("El número " + numero + " es capicúa");
                correcta.ShowDialog();
            }
            else
            {
                error.respuestaError("El número " + numero + " no es capicúa");
                error.ShowDialog();
            }
        }
        public void factorion(int numero)
        {
            int aux = numero;
            int respuesta = 0;
            int[] cifras = new int[10];
            int i = 0;
            while (numero > 0)
            {
                cifras[i] = numero % 10;
                numero = numero / 10;

                i++;
            }

            for (int s = i - 1; s >= 0; s--)
            {
                respuesta = respuesta + fact(cifras[s]);
            }

            if (aux == respuesta)
            {
                correcta.mostrarRespuestaTexto("El número " + numero + " es factorion");
                correcta.ShowDialog();
            }
            else
            {
                error.respuestaError("El número " + aux + " no es factorion");
                error.ShowDialog();
            }
        }
        public int fact(int num)
        {
            int res = 1;
            for (int i = 2; i <= num; i++)
            {
                res = res * i;
            }
            return res;
        }
    }
}
