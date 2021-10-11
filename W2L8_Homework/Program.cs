using System;

namespace W2L8_Homework
{
    class Program
    {
        public static void Main(string[] args)
        {
            int choption = 0;
            Console.WriteLine("Który program chcesz uruchomić: ");
            choption = int.Parse(Console.ReadLine());

            switch (choption)
            {
                case 1:    
                    Program1();
                    break;  
                case 2:
                    Program2();
                    break;
                case 3:
                    Program3();
                    break;
                case 4:
                    Program4();
                    break;
                case 5:
                    Program5();
                    break;
                case 6:
                    Program6();
                    break;
                case 7:
                    Program7();
                    break;
                case 8:
                    Program8();
                    break;
                case 9:
                    Program9();
                    break;
                case 10:
                    Program10();
                    break;

                default:
                    Console.WriteLine("Nie ma takiego programu");
                    break;
            }

            Console.ReadKey();
        }


        //Program 1
        public static void Program1()
        {
            Console.WriteLine("Program 1\n");
            int count = 0;
            int l = 0;
            Console.WriteLine("Liczby pierwsze w przedziale 0..100: ");
            //Petla 100 elementow
            for (int i = 1; i < 101; i++)
            {
                count = 0;
                if (i > 1)
                {   //petla od 2 (0 oraz 1 nie sa liczbami pierwszymi)
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            count = 1;   //nie jest liczba pierwsza
                            break;
                        }
                    }
                    if (count == 0)   //jest liczba pierwsza
                    {
                        l++; //zwiększ licznik liczb pierwszych
                        Console.Write(i + "  ");                      
                    }
                }
                
            }
            Console.WriteLine("Total :" + l);
        }

        //Program 2
        public static void Program2()
        {
            Console.WriteLine("Program 2\n");
            int l = 0;
            int total = 0;
            do
            {
                if (l % 2 == 0)
                {
                    Console.Write(l + "  ");
                    total++;
                }
                l++;    
            }
            while (l <= 1000);
            Console.WriteLine("Total: " + total);

        }

        //Program 3
        private static void Program3()
        {
            //ciag fibonacciego to taki ciag gdzie kazda kolejna liczba jest suma poprzednich Fnie ~ 0 1 1 2 3 5 8 13

            Console.WriteLine("Program 3\n");
            int a = 0;
            int b = 1;
            int suma;

            Console.WriteLine("Podaj ilosc liczb do wydrukowania ciagu Fibonacciego 0 1 {ciag fibonacciego}: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write(a + " ");
            Console.Write(b + " dalszy ciag: \n");
           

            for(int i = 0 ; i < n; i++)
            {
                suma = a + b;

                
                a = b;
                b = suma;

                Console.Write(suma + " ");

            }
        }
        //Program 4
        private static void Program4()

        {
            //Patterns
            Console.WriteLine("Program 4\n");
            
            Console.WriteLine("Podaj liczbę całkowitą: ");
            int n = int.Parse(Console.ReadLine());
            int c = 1;
            int rows=0;

            if (n == 1)
            {
                rows = 1;
            }
            else if (n > 1 && n <= 3)
            {
                rows = 2;
            }

            else if (n > 3 && n <= 6)
            {
                rows = 3;
            }
            else if (n > 3 && n <= 10)
            {
                rows = 4;
            }
            else if (n > 11 && n <= 15)
            {
                rows = 5;
            }
            else if (n > 15 && n <= 21)
            {
                rows = 6;
            }
            else
                rows = n;

            for (int a = 1; a <= rows; a++)
            {
                for (int b = 1; b <= a; b++)
                {
                    Console.Write(" " + c);
                    c++;
                }
                Console.Write("\n");
            } 
        }
        //Program 5
        private static void Program5()

        {

            //dla liczb od 0 do 20 oblicz a^3 potege

            Console.WriteLine("Program 5\n");
            double exp_value = 0;

            Console.WriteLine("Obliczenie trzeciej potegi wg wzoru i^3: ");
            //double i= 3;
            for (int i = 1; i <= 20; i++)
            {
                //funkcja potegowania
                exp_value = Math.Pow(i,3);

                Console.Write(exp_value + " ");

            }
        }


        //Program 6
        private static void Program6()

        {

            //dla liczb od 0 do 20 oblicz sume wg wzoru

            Console.WriteLine("Program 6\n");
            float a = 1;
            float suma = 0;
            float total = 0;

            Console.WriteLine("Obliczenie sumy wg wzoru a + a/2 + a/3 + a/4 etc.: ");
           
            for (float i = 1; i <= 20 ; i++)
            {
                suma = a / i;

                total = total + suma;
              

               // Console.Write(suma + " ");

            }
            Console.WriteLine("\n Total: " + total);
        }

        //Program 7
        private static void Program7()

        {
            Console.WriteLine("Program 6\n");
            
            //druk rosnaco
            int x, y, z;
            for (x = 1; x <= 5; x++)
            {
                for (y = x; y < 5; y++)
                {
                    Console.Write(" ");
                }
                for (z = 1; z < (x * 2); z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
            //druk malejaco
            for (x = 5; x >= 1; x--)
            {
                for (y = 6; y > x; y--)
                {
                    Console.Write(" ");
                }
                for (z = 2; z < (x * 2)-1; z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }



        }
        //Program 8
        private static void Program8()

        {
            Console.WriteLine("Program 8\n");

            string my_word;
            string my_word_reverse = string.Empty;

            Console.WriteLine("Wprowadz lancuch znakow: ");
            my_word = Console.ReadLine();

            Console.WriteLine("Wprowadzone słowo: " + my_word);

            for (int i = my_word.Length-1 ; i >= 0; i--)
            {
                my_word_reverse = my_word_reverse + my_word[i];
            }
            Console.Write($"Wpisany lancuch znakow od tylu : {my_word_reverse} ");
            Console.ReadLine();


        }

        //Program 9
        private static void Program9()

        {
            Console.WriteLine("Podaj liczbę w sytemie dziesiętnym");
            int a = int.Parse(Console.ReadLine());

            string d = "";
            while (a > 0)
            {
                d = d + (a % 2);
                a = a / 2;
                
            }
            string bin = string.Empty;
            for (int i = d.Length - 1; i >= 0; i--)
            {
                bin = bin + d[i];
            }

            Console.WriteLine(bin);

        }

        //Program 10
        private static void Program10()

        {

            Console.WriteLine("Podaj pierwsza liczbę ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj pierwsza liczbę ");
            int y = int.Parse(Console.ReadLine());

            int mul = x * y;

            while (x != y)
            {
                if (x > y)
                    x = x - y;
                else
                    y = y - x;
            }

            Console.WriteLine("Najmniejsza wspolna wielokrotnosc: (NWD) to: " + mul/x);

        }

    }




}
