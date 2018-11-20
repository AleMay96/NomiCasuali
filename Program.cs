using System;

namespace CasualNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] students = { "Luca", "Stefano", "Fabio", "Andrea", "Valerio", "Francesco", "Cristian", "Nicoletta", "Federico", "Alessio", "Gianluca", "Marco" };

            PrintStudent(students);
        }


        static void PrintStudent(string[] students)
        {
            //creo un array che conterrà
            //12 numeri interi casuali e tutti diversi tra loro
            int [] indexRandom = new int[12];

            Random r = new Random();


            bool not_present = true;


            //finchè l'ultimo elemento non conterrà un numero fra 1 e 12
            while (indexRandom[11]==0)
            {
                not_present = true;

                int x = r.Next(1, 13); //genero un numero casuale fra 1 e 12


                //controllo tutto l'array: se l'ultimo numero generato è già presente, termino il for
                for (int i = 0; i < indexRandom.Length; i++)
                {
    
                    if (indexRandom[i] == x)
                    {
                        not_present = false;
                        break;
                    }
                }


                if (not_present)
                {
                    for (int i = 0; i < indexRandom.Length; i++)
                    {
                        //se non è presente, metto il numero generato nell'array nella prima posizione disponibile,
                        //quella che contiene lo 0 subito dopo l'ultimo numero inserito, e poi esco dal ciclo
                        if (indexRandom[i] == 0)
                        {
                            indexRandom[i] = x;
                            break;
                        }
                    }
                }
            }


         
            
            for (int i = 0; i < students.Length; i+=2)
            {
                Console.Write(students[indexRandom[i]-1].PadRight(11) +  "||".PadRight(5) + students[indexRandom[i+1] - 1].PadRight(10));
                Console.WriteLine();
            }

         }
            
            
       
      

        }
    }

