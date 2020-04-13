using System;
using System.Collections.Generic;
using System.Text;

namespace at_marlao_1
{
    class CALCULADORA
    { private new List<double> listNumero = new List<double>();

            public void AddNumero(double num)
            {
                this.listNumero.Add(num);

            }
            public double Somar()
            {
                double resultado = 0;
                foreach (double numero in this.listNumero)
                {
                    resultado += numero;
                }
                this.listNumero.Clear();
                return resultado;
            }
            public double Subtrair()
            {
                double resultado = this.listNumero[0];
                this.listNumero.RemoveAt(0);
                foreach (double numero in this.listNumero)
                {
                    resultado -= numero;
                }
                this.listNumero.Clear();
                return resultado;
            }
            public double Multi()
            {
                double resultado = this.listNumero[0];
                this.listNumero.RemoveAt(0);
                foreach (double numero in this.listNumero)
                {

                    resultado *= numero;
                }
                this.listNumero.Clear();
                return resultado;
            }
            public double Divisao()
            {
                double resultado = this.listNumero[0];
                this.listNumero.RemoveAt(0);
                foreach (double numero in this.listNumero)
                {

                    resultado /= numero;
                }
                this.listNumero.Clear();
                return resultado;
             }
        public double quadrado()
        {
            double resultado = this.listNumero[0];
            
            foreach (double numero in this.listNumero)
            {

                resultado =Math.Pow( numero, 2);
            }
            this.listNumero.Clear();
        
            return resultado;
        }




    }
        }

    



