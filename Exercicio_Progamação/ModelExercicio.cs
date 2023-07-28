using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

        public string Sexto(double n4)
        {

            string resultado = "";
            for (int i = 0; i <= 10; i++) // o i ++ e a cada volta dor for ele conta mais um
            {
                resultado += "\n" + n4 + "*" + i + "=" + (n4 * i);
            }// += pra ficar na mesma variavel

            return resultado;
        }

        public string Setimo(int n5, int n6)
        {
            string resultado = "";

            for (int i = n5; i <= n6; i++)
            {
                resultado += "\n" + (n5 + (1 * i - n5));
            }//Fim do método for

            return resultado;
        }

        public int Oitavo(int um, int dois, int tres, int quatro, int cinco, int seis, int sete, int oito,int nove, int dez)
        {
            return um + dois + tres + quatro + cinco + seis + sete + oito + nove + dez;
        }

        public string Nono()
        {
            string resultado = "";
            for (int i = 101; i <= 199; i += 2)
            {
                Console.WriteLine(i);

            }
            return resultado;

        }

        public int Dez()
        {
            int soma = 0;
            
            do
            {
                Console.WriteLine("Informe um numero");
                int num1 = Convert.ToInt32(Console.ReadLine());
                if (num1 == 0)
                    break;

                soma += num1;
            } while (num1 == 0);
            return soma;
        }

       
        
                         


    }//fim da classe
}//fim do projeto

