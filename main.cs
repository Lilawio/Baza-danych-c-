using System;
using System.IO;
using System.Reflection.Metadata;

namespace porjekt1
{
    class Program  
    {
    static void Main()
        {
            string[] name =  {"", "", "", "", "", "", "", "", "", ""};
            string[] surname = { "", "", "", "", "", "", "", "", "", ""};
            byte[] age = {0,0,0,0,0,0,0,0,0,0};
            decimal[] earn = {0,0,0,0,0,0,0,0,0,0};
            bool[] tablica = {false, false, false, false, false, false, false, false, false,false};
            decimal zarobki = 0;
            byte rok = 0;
            int i = 0;
            int j = 0;
            int place = 10;
            while (true)   //zczytuje z pliku i zapisywało do bazy danych jakiejs
            {                               
                Console.WriteLine("Wybierz jedno (1,2,3,4) - Lista, wprowadź, wyjście, wprowadzenie danych ");
                string choice = Console.ReadLine();
                if ("1" == choice)
                {
                    Console.WriteLine("Dane to : ");
                    Console.WriteLine("Name          |Surname           |Age  |Earning     |Gender ");
                    for (int k = 0; k < i; k++)
                    { 
                        if (tablica[k] == true)
                        {
                            Console.WriteLine(name[k] + "    " + "|" + surname[k] + "        " + "|" +  age[k] + "  " + "|"+ earn[k] + "         " + "|" + "Mężczyzna");
                        }
                        else if (tablica[k] == false)
                        {
                            Console.WriteLine(name[k] + "    " + "|" + surname[k] + "        " + "|" + age[k] + "  " + "|" + earn[k] + "         " + "|" + "Kobieta");
                        }
                    }
                }
                else if ("2" == choice)
                {
                    while (true)
                    {
                        Console.WriteLine("Podaj imie- ");
                        while (true)
                        {
                            string Name = Console.ReadLine();
                            if (Name.Length < 25)
                            {
                                name[i] = Name;
                                break;
                            }
                            Console.WriteLine("Podaj imię krótsze niż 25 znaków");
                        }                        
                        
                        Console.WriteLine("Podaj nazwisko- ");                       
                        while (true)
                        {
                            string Surname = Console.ReadLine();
                            if (Surname.Length < 40)
                            {
                                surname[i] = Surname;
                                break;
                            }
                            Console.WriteLine("Podaj nazwisko krótsze niż 40 znaków");
                        }

                        Console.WriteLine("Podaj wiek- ");
                        while (true)
                        {
                            try
                            {
                                string Age = Console.ReadLine();
                                rok = byte.Parse(Age);
                                if (rok > 0)
                                {                                   
                                    age[i] = rok;
                                    break;
                                }                               
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Podaj liczbę większą niż 0 - ");
                            }
                        }
                        Console.WriteLine("Podaj zarobki - ");
                        while (true)
                        {
                            try
                            {
                                string Earning = Console.ReadLine();
                                zarobki = Decimal.Parse(Earning);
                                if (zarobki>0)
                                {                                   
                                    earn[i] = zarobki;
                                    break;
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Podaj liczbę większą niż 0");
                            }
                        }
                        Console.WriteLine("Podaj płeć(M/K)");
                        string Gender = Console.ReadLine();
                        bool gender = true;
                        if (Gender == "M")
                        {
                            gender = true;
                        }
                        else if (Gender == "K")
                        {
                            gender = false;
                        }                                 
                        tablica[i] = gender;
                        i++;
                        j++;
                        Console.WriteLine("Pozostało" + " " + (place - j) + " " + "miejsc do zapisania");
                        break;   
                        /*Console.WriteLine("Jeśli chcesz wrócić do menu to kliknij Backspace");
                        Console.ReadKey();
                        if (Console.ReadKey().Key == ConsoleKey.Backspace) 
                        {
                            break;
                        }*/
                    }
                }
                else if ("3"==choice)
                {
                    break;
                }
                else if ("4"==choice)
                {
                    Console.WriteLine("Wpisz nazwę pliku np. c:.temp.Test.txt)");
                    string file = @"d:\ok\ok.txt";
                    string[] czytanko = File.ReadAllLines(file);
                    foreach (string k in czytanko)
                    {
                        Console.WriteLine(k);
                    }
                }
            }
        }
    }
}

