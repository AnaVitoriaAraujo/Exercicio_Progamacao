using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Progamação
{
    class ModelExercicio
    {
        private double num1;
        private double num2;
   

        public ModelExercicio()
        {
            Getnum1 = 0;
            Getnum2 = 0;
        }
    
        public double Getnum1
        {
            get { return this.num1;}
            set { this.num1 = value;}

        }

        public double Getnum2
        {
            get { return this.num2;}
            set { this.num2 = value;}
        }

        public double Primeiro(double n1)
        {
            double resultado = n1 * 2;


            return resultado;
        }

        public double Segundo(double n1)
        {
            double resul = Getnum1 * 3;
            return resul;
        }

        public double Salario(double nn1)
        {
            double soma = nn1 * 30 / 100;
            double sal = soma + nn1;
            return sal;
        }

        public string Terceiro(double n3)
        {
            
            if(n3 > 0)
            {
                return "È POSITIVO";
            }

            return "É negativo";
        }

        public string Quarto(double n3)
        {            
            if(n3 % 2 != 0)
            {
                return "Ele é impar";
            }
                return "Ele é par";                     
        }

        
        public int Quinto()
        {
            int som = 0;
            for (int i = 0; i <= 100; i++)
            {
                som += i;
            }
            return som;
            
        }
        
    }//fim da classe
}//fim do projeto

