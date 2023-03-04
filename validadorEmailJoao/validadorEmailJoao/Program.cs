using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validadorEmailJoao
{
    class Program
    {


        static void Main(string[] args)
        {
            string email;
            string local = "";
            string dominio = "";
            int posicao = 0;

            Console.WriteLine("Insira seu E-mail para ser validado: ");
            email = Console.ReadLine();

            if (email.Length > 81)
            {
                Console.WriteLine("Email invalido");
            }
            else
            {
                for (int i = 0; i < email.Length; i++)
                {
                    if (email[i] == '@')
                    {
                        posicao = i;
                        i = email.Length;

                    }
                    else
                    {
                        local += email.Substring(i, 1);
                    }

                }

                if (posicao == 0)
                {
                    Console.WriteLine("Email invalido");
                }
                else
                {
                    for (int i = posicao; i < email.Length; i++)
                    {
                        dominio += email.Substring(i, 1);
                    }

                    if (local.Length > 60)
                    {
                        Console.WriteLine("Email invalido");
                    }
                    else
                    {

                        for (int i = 0; i < email.Length; i++)
                        {
                            if (email[0] == '_' || email[0] == '-' || email[0] == '.')
                            {
                                Console.WriteLine("Email invalido");
                                i = email.Length;
                            }
                            if (char.IsDigit(email[0]))
	                        {
                                Console.WriteLine("Email invalido");
                                i = email.Length;
	                        }
                          
                        }

                        if (dominio.Length > 20)
	                    {
                            Console.WriteLine("Email invalido");
	                    }
                        else
	                    {
                            Console.WriteLine("Local: " + local + " e dominio: " + dominio);
                            Console.WriteLine("O tamanho do seu e-mail: " + email.Length);
                            Console.WriteLine("o tamanho do local: " + local.Length);
                            Console.WriteLine("o tamanho do Dominio: " + dominio.Length);

	                    }

                    }

                }

            }


            
            
            Console.ReadKey();



        }

    }
}

