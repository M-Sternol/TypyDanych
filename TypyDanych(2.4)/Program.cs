namespace TypyDanych_2._4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            { 
                Console.WriteLine("====Typy Danych 4 lekcja 2 tyg=====");
                Console.WriteLine("Wybierz zadanie 1-5");
                Console.WriteLine("6.Wyjście z aplikacji");
                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Zadanie 1." + "\n");
                        // Dane pracownika 1
                        string firstname1 = "Jan";
                        string lastname1 = "Kowalski";
                        int age1 = 30;
                        char sex1 = 'm';
                        string pesel1 = "85021012345";
                        long employeenumber1 = 2509324094;

                        // Dane pracownika 2
                        string firstname2 = "Anna";
                        string lastname2 = "Nowak";
                        int age2 = 28;
                        char sex2 = 'k';
                        string pesel2 = "91030567890";
                        long employeenumber2 = 3510293456;

                        // Wyświetlanie informacji o pracowniku numer 1 
                        Console.WriteLine("Informacje o pracowniku 1:");
                        Console.WriteLine("Imię: " + firstname1);
                        Console.WriteLine("Nazwisko: " + lastname1);
                        Console.WriteLine("Wiek: " + age1);
                        Console.WriteLine("Płeć: " + sex1);
                        Console.WriteLine("PESEL: " + pesel1);
                        Console.WriteLine("Numer pracownika: " + employeenumber1);
                        Console.WriteLine();
                        // Wyświetlanie informacji o pracowniku numer 2
                        Console.WriteLine("Informacje o pracowniku 2:");
                        Console.WriteLine("Imię: " + firstname2);
                        Console.WriteLine("Nazwisko: " + lastname2);
                        Console.WriteLine("Wiek: " + age2);
                        Console.WriteLine("Płeć: " + sex2);
                        Console.WriteLine("PESEL: " + pesel2);
                        Console.WriteLine("Numer pracownika: " + employeenumber2);
                        Console.WriteLine();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Zadanie 2." + "\n");
                        char Value1 = 'A';
                        char Value2 = 'B';
                        char Value3 = 'C';
                        //Wyświetla zmienną w kolejności A,B,C
                        Console.WriteLine("Zmienne w pierwotnej postaci" + "\n");
                        Console.WriteLine(Value1);
                        Console.WriteLine(Value2);
                        Console.WriteLine(Value3 + "\n");
                        //Wyświetla zmienną w kolejności odwrotnej C,B,A
                        Console.WriteLine("Zmienne w odwrotnej kolejności:" + "\n");
                        Console.WriteLine(Value3);
                        Console.WriteLine(Value2);
                        Console.WriteLine(Value1);
                        Console.WriteLine();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Zadanie numer 3." + "\n");
                        Console.WriteLine("Podaj szerokość prostokąta: ");
                        double width = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Podaj długość prostokąta: ");
                        double length = Convert.ToDouble(Console.ReadLine());

                        double diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(length, 2));
                        double rouding = Math.Round(diagonal, 2);

                        Console.WriteLine($"Długość przekątnej: {rouding} cm " + "\n");
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Zadanie numer 4." + "\n");
                        int nub1 = 10;
                        string text = "Szkoła Dotneta";
                        double nub2 = 12.5;

                        Console.WriteLine("Zawartość zmiennych:");
                        Console.WriteLine("Liczba 1: " + nub1);
                        Console.WriteLine("Tekst: " + text);
                        Console.WriteLine("Liczba 2: " + nub2 + "\n" );
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Zadanie 5." + "\n");
                        Console.WriteLine("Podaj swoje dane personalne:" + "\n");

                        Console.Write("Imię: ");
                        string firstname = Console.ReadLine();

                        Console.Write("Nazwisko: ");
                        string lastname = Console.ReadLine();

                        Console.Write("Numer telefonu: ");
                        string phonenumber = Console.ReadLine();

                        Console.Write("Adres email: ");
                        string email = Console.ReadLine();

                        Console.Write("Wzrost (w cm): ");
                        int growth = int.Parse(Console.ReadLine());

                        Console.Write("Waga (w kg): ");
                        double weight = double.Parse(Console.ReadLine());

                        // Wyświetlanie wprowadzonych danych
                        Console.WriteLine("\nPodane dane personalne:" + "\n");
                        Console.WriteLine("Imię: " + firstname);
                        Console.WriteLine("Nazwisko: " + lastname );
                        Console.WriteLine("Numer telefonu: " + phonenumber);
                        Console.WriteLine("Adres email: " + email);
                        Console.WriteLine("Wzrost: " + growth + " cm");
                        Console.WriteLine("Waga: " + weight + " kg" + "\n");
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Do zobaczenia!");
                        isRunning = false;
                        break;
                    default: Console.WriteLine("Nieprawidłowa operacja!");
                        break;
                }
            }
        }
    }
}