using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Progamação
{
    class ControlExercicio
    {
        ModelExercicio ModelExercicio;

        public ControlExercicio()
        {
            ModelExercicio = new ModelExercicio();

        }//fim do control

        public int Menu()
        {
            Console.WriteLine("Escolha a opcao que deseja" +
                "\n0.Clique 0 para sair"+
                "\n1.Deseja obter o dobro e o triplo do numero digitado"+
                "\n2.Deseja calcular 30% do seu salario"+
                "\n3.Deseja ver se o  umero é par ou impar negativo ou positivo"+
                "\n4.Deseja ver os numeros inteiors de 1 a 100"
                );
            int opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }

        public void Coletar()
        {
            Console.WriteLine("Informe o primeiro numero ");
            this.ModelExercicio.Getnum1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o segundo numero");
            this.ModelExercicio.Getnum2 = Convert.ToInt32(Console.ReadLine());
        }



        public void Operacao()
        {
            int opcao = 0;
            do
            {
                opcao = Menu();
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Sair");
                        break;
                    case 1:
                        
                        Console.WriteLine("Informe seu salario");
                        double n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Esse é resultado do dobro "+ this.ModelExercicio.Primeiro(n1));
                        Console.WriteLine("Esse é triplo " + this.ModelExercicio.Segundo(n1));
                        break;

                    case 2:
                        Console.WriteLine("Informe um numero");
                        double nn1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Esse é o resultado: "+ this.ModelExercicio.Salario(nn1));
                        break;

                    case 3:
                        Console.WriteLine("Informe um numero");
                        double n3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ele é negativo ou positivo: " + this.ModelExercicio.Terceiro(n3));
                        Console.WriteLine("Ele é negativo ou positivo: " + this.ModelExercicio.Quarto(n3));                       
                        break;

                    case 4:
                        Console.WriteLine();
                        break;
                }

            }while(opcao != 0);
            
        }
    }
}
