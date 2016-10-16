using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki_z_Chińczyka___gra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#####");
            Console.WriteLine("  # ");
            Console.WriteLine("#####");
            Console.WriteLine("  # ");
            Console.WriteLine("#####");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Witaj w sklepie. Sprzedajemy zabawki prosto z Chin!");
            Console.WriteLine("Twoim celem będzie zakupienie wystarczajacej ilości przedmiotów.");
            Console.WriteLine("Jeśli ci się nie uda, to film będzie za krótki, a wyświetlenia spadną.");
            Console.WriteLine("Masz 3 złote. Musisz wybierać mądrze: liczy się nie tylko ilosć,");
            Console.WriteLine("ale również jakosć. Wszystko kosztuje tyle samo.");
        beginning:
            Console.WriteLine("Możesz kupić:");
            Console.WriteLine("1: Telefon dla dzieci za 1 złoty,");
            Console.WriteLine("2: Beton w proszku,");
            Console.WriteLine("3: Monotlenek diwodoru prosto z Morza Południowochinskiego,");
            Console.WriteLine("4. Mózg do jedzenia,");
            Console.WriteLine("5. Podręcznik Chiński w pięć sekund");
            Console.WriteLine("Wybierz poprzez wpisanie numeru od 1 do 5.");
            string userValue = Console.ReadLine();

            if (userValue == "1")
            {
                Console.WriteLine("Statystyki:");
                Console.WriteLine("Jakość: 5");
                Console.WriteLine("Ilosć: 1");
                Console.WriteLine("Czy kupujesz? (tak/nie)");
                string userValue1 = Console.ReadLine();
                if (userValue1 == "tak")
                {
                beginning2:
                    int x = 5;
                    int y = 1;
                    Console.WriteLine("Pora na kolejną rzecz:");
                    Console.WriteLine("2. Beton w proszku,");
                    Console.WriteLine("3. Monotlenek diwodoru prosto z Morza Południowochinskiego");
                    Console.WriteLine("4. Mózg do jedzenia,");
                    Console.WriteLine("5. Podręcznik Chiński w pięć sekund");
                    Console.WriteLine("Wybierz od 2 do 5");
                    string userValue11 = Console.ReadLine();


                    if (userValue11 == "2") 
                    {
                        Console.WriteLine("Statystyki:");
                        Console.WriteLine("Jakość: 4");
                        Console.WriteLine("Ilosć: 2");
                        Console.WriteLine("Czy kupujesz? (tak/nie)");
                        string userValue111 = Console.ReadLine();
                        if (userValue111 == "tak")
                        {
                        beginning3:
                            int a = 4;
                            int b = 2;
                            Console.WriteLine("Pora to zakończyć:");
                            Console.WriteLine("3. Monotlenek diwodoru prosto z Morza Południowochinskiego");
                            Console.WriteLine("4. Mózg do jedzenia,");
                            Console.WriteLine("5. Podręcznik Chiński w pięć sekund");
                            Console.WriteLine("Wybierz od 3 do 5");
                            string userValue1111 = Console.ReadLine();
                            if (userValue1111 == "3")
                            {
                                beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 3");
                                Console.WriteLine("Ilosć: 3");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                   int c = 3;
                                   int d = 3;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            if (userValue1111 == "4")
                            {
                                beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 2");
                                Console.WriteLine("Ilosć: 4");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    int c = 2;
                                    int d = 4;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }

                            }
                            if (userValue1111 == "5")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 1");
                                Console.WriteLine("Ilosć: 5");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    int c = 1;
                                    int d = 5;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            else

                            {
                                goto beginning3;
                            }

                        }
                        else
                        {
                            goto beginning2;
                        }
                    }

                    else if (userValue11 == "3")
                    {
                        Console.WriteLine("Statystyki:");
                        Console.WriteLine("Jakość: 3");
                        Console.WriteLine("Ilosć: 3");
                        Console.WriteLine("Czy kupujesz? (tak/nie)");
                        string userValue111 = Console.ReadLine();
                        if (userValue111 == "tak")
                        {
                        beginning3:
                            int a = 3;
                            int b = 3;
                            Console.WriteLine("Pora to zakończyć:");
                            Console.WriteLine("2.Beton w proszku,");
                            Console.WriteLine("4. Mózg do jedzenia,");
                            Console.WriteLine("5. Podręcznik Chiński w pięć sekund");
                            Console.WriteLine("Wybierz od 2 do 4");
                            string userValue1111 = Console.ReadLine();
                            if (userValue1111 == "2")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 4");
                                Console.WriteLine("Ilosć: 2");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    int c = 4;
                                    int d = 2;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            if (userValue1111 == "4")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 2");
                                Console.WriteLine("Ilosć: 4");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    {
                                        int c = 2;
                                        int d = 4;
                                        Console.WriteLine("Wydałeś już wszystko.");
                                        Console.WriteLine("Pora nakręcic ten film.");
                                        int e = x + a + c;
                                        int f = y + b + d;
                                        int z = e / f;
                                        if (z == 2)
                                        {
                                            Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                            Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                            Console.WriteLine("aby nikt się nie nudził!");
                                        }
                                        if (z < 2)
                                        {

                                            Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                        }

                                        if (z > 2)
                                        {
                                            Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                        }
                                    }
                                    }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            if (userValue1111 == "5")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 1");
                                Console.WriteLine("Ilosć: 5");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    {
                                        int c = 1;
                                        int d = 5;
                                        Console.WriteLine("Wydałeś już wszystko.");
                                        Console.WriteLine("Pora nakręcic ten film.");
                                        int e = x + a + c;
                                        int f = y + b + d;
                                        int z = e / f;
                                        if (z == 2)
                                        {
                                            Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                            Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                            Console.WriteLine("aby nikt się nie nudził!");
                                        }
                                        if (z < 2)
                                        {

                                            Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                        }

                                        if (z > 2)
                                        {
                                            Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                        }
                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            else
                            {
                                goto beginning3;
                            }

                        }
                        else
                        {
                            goto beginning2;
                        }
                    }
                    else if (userValue11 == "4")
                    {
                        Console.WriteLine("Statystyki:");
                        Console.WriteLine("Jakość: 2");
                        Console.WriteLine("Ilosć: 4");
                        Console.WriteLine("Czy kupujesz? (tak/nie)");
                        string userValue111 = Console.ReadLine();
                        if (userValue111 == "tak")
                        {
                        beginning3:
                            int a = 2;
                            int b = 4;
                            Console.WriteLine("Pora to zakończyć:");
                            Console.WriteLine("2. Beton w proszku,");
                            Console.WriteLine("3. Monotlenek diwodoru prosto z Morza Południowochinskiego,");
                            Console.WriteLine("5. Podręcznik Chiński w pięć sekund");
                            Console.WriteLine("Wybierz od 2,3 kub 5");
                            string userValue1111 = Console.ReadLine();
                            if (userValue1111 == "2")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 4");
                                Console.WriteLine("Ilosć: 2");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    {
                                        int c = 4;
                                        int d = 2;
                                        Console.WriteLine("Wydałeś już wszystko.");
                                        Console.WriteLine("Pora nakręcic ten film.");
                                        int e = x + a + c;
                                        int f = y + b + d;
                                        int z = e / f;
                                        if (z == 2)
                                        {
                                            Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                            Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                            Console.WriteLine("aby nikt się nie nudził!");
                                        }
                                        if (z < 2)
                                        {

                                            Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                        }

                                        if (z > 2)
                                        {
                                            Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                        }
                                    }
                                    }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            if (userValue1111 == "3")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 3");
                                Console.WriteLine("Ilosć: 3");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    {
                                        int c = 3;
                                        int d = 3;
                                        Console.WriteLine("Wydałeś już wszystko.");
                                        Console.WriteLine("Pora nakręcic ten film.");
                                        int e = x + a + c;
                                        int f = y + b + d;
                                        int z = e / f;
                                        if (z == 2)
                                        {
                                            Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                            Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                            Console.WriteLine("aby nikt się nie nudził!");
                                        }
                                        if (z < 2)
                                        {

                                            Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                        }

                                        if (z > 2)
                                        {
                                            Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                        }
                                    }
                                    }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            else

                            {
                                goto beginning3;
                            }
                            if (userValue1111 == "5")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 1");
                                Console.WriteLine("Ilosć: 5");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    {
                                        int c = 1;
                                        int d = 5;
                                        Console.WriteLine("Wydałeś już wszystko.");
                                        Console.WriteLine("Pora nakręcic ten film.");
                                        int e = x + a + c;
                                        int f = y + b + d;
                                        int z = e / f;
                                        if (z == 2)
                                        {
                                            Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                            Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                            Console.WriteLine("aby nikt się nie nudził!");
                                        }
                                        if (z < 2)
                                        {

                                            Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                        }

                                        if (z > 2)
                                        {
                                            Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                        }
                                    }
                                    }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            }
                        else
                        {
                            goto beginning2;
                        }
                    }


                    else if (userValue11 == "5")
                    {
                        Console.WriteLine("Statystyki:");
                        Console.WriteLine("Jakość: 1");
                        Console.WriteLine("Ilosć: 5");
                        Console.WriteLine("Czy kupujesz? (tak/nie)");
                        string userValue111 = Console.ReadLine();
                        if (userValue111 == "tak")
                        {
                        beginning3:
                            int a = 1;
                            int b = 5;
                            Console.WriteLine("Pora to zakończyć:");
                            Console.WriteLine("2. Beton w proszku,");
                            Console.WriteLine("3. Monotlenek diwodoru prosto z Morza Południowochinskiego,");
                            Console.WriteLine("4. Mózg do jedzenia.");
                            Console.WriteLine("Wybierz 2, 3, lub 4");
                            string userValue1111 = Console.ReadLine();
                            if (userValue1111 == "2")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 4");
                                Console.WriteLine("Ilosć: 2");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    {
                                        int c = 4;
                                        int d = 2;
                                        Console.WriteLine("Wydałeś już wszystko.");
                                        Console.WriteLine("Pora nakręcic ten film.");
                                        int e = x + a + c;
                                        int f = y + b + d;
                                        int z = e / f;
                                        if (z == 2)
                                        {
                                            Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                            Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                            Console.WriteLine("aby nikt się nie nudził!");
                                        }
                                        if (z < 2)
                                        {

                                            Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                        }

                                        if (z > 2)
                                        {
                                            Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                        }
                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            if (userValue1111 == "3")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 3");
                                Console.WriteLine("Ilosć: 3");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    {
                                        int c = 3;
                                        int d = 3;
                                        Console.WriteLine("Wydałeś już wszystko.");
                                        Console.WriteLine("Pora nakręcic ten film.");
                                        int e = x + a + c;
                                        int f = y + b + d;
                                        int z = e / f;
                                        if (z == 2)
                                        {
                                            Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                            Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                            Console.WriteLine("aby nikt się nie nudził!");
                                        }
                                        if (z < 2)
                                        {

                                            Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                        }

                                        if (z > 2)
                                        {
                                            Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                        }
                                    }
                                    }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            else

                            {
                                goto beginning3;
                            }
                            if (userValue1111 == "4")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 2");
                                Console.WriteLine("Ilosć: 4");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    {
                                        int c = 2;
                                        int d = 4;
                                        Console.WriteLine("Wydałeś już wszystko.");
                                        Console.WriteLine("Pora nakręcic ten film.");
                                        int e = x + a + c;
                                        int f = y + b + d;
                                        int z = e / f;
                                        if (z == 2)
                                        {
                                            Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                            Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                            Console.WriteLine("aby nikt się nie nudził!");
                                        }
                                        if (z < 2)
                                        {

                                            Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                        }

                                        if (z > 2)
                                        {
                                            Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                        }
                                    }
                                    }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                        }
                        }
                    else
                    {
                        goto beginning2;
                    }

                }
                else
                {
                    goto beginning;
                }
            }


            else if (userValue == "2")
            {
                Console.WriteLine("Statystyki:");
                Console.WriteLine("Jakość: 4");
                Console.WriteLine("Ilosć: 2");
                Console.WriteLine("Czy kupujesz? (tak/nie)");
                string userValue2 = Console.ReadLine();
                if (userValue2 == "tak")
                {
                beginning2:
                    int x = 4;
                    int y = 2;
                    Console.WriteLine("Pora na kolejną rzecz:");
                    Console.WriteLine("1: Telefon dla dzieci za 1 złoty,");
                    Console.WriteLine("3: Monotlenek diwodoru prosto z Morza Południowochinskiego,");
                    Console.WriteLine("4. Mózg do jedzenia,");
                    Console.WriteLine("5. Podręcznik Chiński w pięć sekund");
                    string userValue22 = Console.ReadLine();


                    if (userValue22 == "1")
                    {
                        Console.WriteLine("Statystyki:");
                        Console.WriteLine("Jakość: 5");
                        Console.WriteLine("Ilosć: 1");
                        Console.WriteLine("Czy kupujesz? (tak/nie)");
                        string userValue222 = Console.ReadLine();
                        if (userValue222 == "tak")
                        {
                        beginning3:
                            int a = 5;
                            int b = 1;
                            Console.WriteLine("Pora to zakończyć:");
                            Console.WriteLine("3. Monotlenek diwodoru prosto z Morza Południowochinskiego,");
                            Console.WriteLine("4. Mózg do jedzenia,");
                            Console.WriteLine("5. Podręcznik Chiński w pięć sekund");
                            Console.WriteLine("Wybierz od 3 do 5.");
                            string userValue1111 = Console.ReadLine();
                            if (userValue1111 == "3")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 3");
                                Console.WriteLine("Ilosć: 3");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    {
                                        int c = 3;
                                        int d = 3;
                                        Console.WriteLine("Wydałeś już wszystko.");
                                        Console.WriteLine("Pora nakręcic ten film.");
                                        int e = x + a + c;
                                        int f = y + b + d;
                                        int z = e / f;
                                        if (z == 2)
                                        {
                                            Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                            Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                            Console.WriteLine("aby nikt się nie nudził!");
                                        }
                                        if (z < 2)
                                        {

                                            Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                        }

                                        if (z > 2)
                                        {
                                            Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                        }
                                    }
                                    }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            if (userValue1111 == "4")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 2");
                                Console.WriteLine("Ilosć: 4");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    {
                                        int c = 2;
                                        int d = 4;
                                        Console.WriteLine("Wydałeś już wszystko.");
                                        Console.WriteLine("Pora nakręcic ten film.");
                                        int e = x + a + c;
                                        int f = y + b + d;
                                        int z = e / f;
                                        if (z == 2)
                                        {
                                            Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                            Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                            Console.WriteLine("aby nikt się nie nudził!");
                                        }
                                        if (z < 2)
                                        {

                                            Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                        }

                                        if (z > 2)
                                        {
                                            Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                        }
                                    }
                                    }
                                else
                                {
                                    goto beginning4;
                                }

                            }
                            if (userValue1111 == "5")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 1");
                                Console.WriteLine("Ilosć: 5");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    {
                                        int c = 1;
                                        int d = 5;
                                        Console.WriteLine("Wydałeś już wszystko.");
                                        Console.WriteLine("Pora nakręcic ten film.");
                                        int e = x + a + c;
                                        int f = y + b + d;
                                        int z = e / f;
                                        if (z == 2)
                                        {
                                            Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                            Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                            Console.WriteLine("aby nikt się nie nudził!");
                                        }
                                        if (z < 2)
                                        {

                                            Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                        }

                                        if (z > 2)
                                        {
                                            Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                        }
                                    }
                                    }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            else

                            {
                                goto beginning3;
                            }
                        }
                        }

                    else if (userValue22 == "3")
                    {
                        Console.WriteLine("Statystyki:");
                        Console.WriteLine("Jakość: 3");
                        Console.WriteLine("Ilosć: 3");
                        Console.WriteLine("Czy kupujesz? (tak/nie)");
                        string userValue222 = Console.ReadLine();
                        if (userValue222 == "tak")
                        {
                        beginning3:
                            int a = 3;
                            int b = 3;
                            Console.WriteLine("Pora to zakończyć:");
                            Console.WriteLine("1. Telefon dla dzieci za 1 złoty,");
                            Console.WriteLine("4. Mózg do jedzenia,");
                            Console.WriteLine("5. Podręcznik Chiński w pięć sekund");
                            Console.WriteLine("Wybierz od 1, 4 lub 5");
                            string userValue1111 = Console.ReadLine();
                            if (userValue1111 == "1")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 5");
                                Console.WriteLine("Ilosć: 1");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    {
                                        int c = 5;
                                        int d = 1;
                                        Console.WriteLine("Wydałeś już wszystko.");
                                        Console.WriteLine("Pora nakręcic ten film.");
                                        int e = x + a + c;
                                        int f = y + b + d;
                                        int z = e / f;
                                        if (z == 2)
                                        {
                                            Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                            Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                            Console.WriteLine("aby nikt się nie nudził!");
                                        }
                                        if (z < 2)
                                        {

                                            Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                        }

                                        if (z > 2)
                                        {
                                            Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                        }
                                    }
                                    }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            if (userValue1111 == "4")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 2");
                                Console.WriteLine("Ilosć: 4");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    {
                                        int c = 2;
                                        int d = 4;
                                        Console.WriteLine("Wydałeś już wszystko.");
                                        Console.WriteLine("Pora nakręcic ten film.");
                                        int e = x + a + c;
                                        int f = y + b + d;
                                        int z = e / f;
                                        if (z == 2)
                                        {
                                            Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                            Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                            Console.WriteLine("aby nikt się nie nudził!");
                                        }
                                        if (z < 2)
                                        {

                                            Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                        }

                                        if (z > 2)
                                        {
                                            Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                        }
                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }

                            }
                            if (userValue1111 == "5")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 1");
                                Console.WriteLine("Ilosć: 5");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    {
                                        int c = 1;
                                        int d = 5;
                                        Console.WriteLine("Wydałeś już wszystko.");
                                        Console.WriteLine("Pora nakręcic ten film.");
                                        int e = x + a + c;
                                        int f = y + b + d;
                                        int z = e / f;
                                        if (z == 2)
                                        {
                                            Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                            Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                            Console.WriteLine("aby nikt się nie nudził!");
                                        }
                                        if (z < 2)
                                        {

                                            Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                        }

                                        if (z > 2)
                                        {
                                            Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                        }
                                    }
                                    }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            else

                            {
                                goto beginning3;
                            }
                        }
                        }
                    else if (userValue22 == "4")
                    {
                        Console.WriteLine("Statystyki:");
                        Console.WriteLine("Jakość: 2");
                        Console.WriteLine("Ilosć: 4");
                        Console.WriteLine("Czy kupujesz? (tak/nie)");
                        string userValue222 = Console.ReadLine();
                        if (userValue222 == "tak")
                        {
                        beginning3:
                            int a = 2;
                            int b = 4;
                            Console.WriteLine("Pora to zakończyć:");
                            Console.WriteLine("1.Telefon dla dzieci za 1 złoty,");
                            Console.WriteLine("3. Monotlenek diwodoru prosto z Morza Południowochinskiego");
                            Console.WriteLine("5. Podręcznik Chiński w pięć sekund");
                            Console.WriteLine("Wybierz od 3 do 5");
                            string userValue1111 = Console.ReadLine();
                            if (userValue1111 == "1")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 5");
                                Console.WriteLine("Ilosć: 1");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    {
                                        int c = 5;
                                        int d = 1;
                                        Console.WriteLine("Wydałeś już wszystko.");
                                        Console.WriteLine("Pora nakręcic ten film.");
                                        int e = x + a + c;
                                        int f = y + b + d;
                                        int z = e / f;
                                        if (z == 2)
                                        {
                                            Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                            Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                            Console.WriteLine("aby nikt się nie nudził!");
                                        }
                                        if (z < 2)
                                        {

                                            Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                        }

                                        if (z > 2)
                                        {
                                            Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                        }
                                    }
                                    }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            if (userValue1111 == "3")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 3");
                                Console.WriteLine("Ilosć: 3");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    {
                                        int c = 3;
                                        int d = 3;
                                        Console.WriteLine("Wydałeś już wszystko.");
                                        Console.WriteLine("Pora nakręcic ten film.");
                                        int e = x + a + c;
                                        int f = y + b + d;
                                        int z = e / f;
                                        if (z == 2)
                                        {
                                            Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                            Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                            Console.WriteLine("aby nikt się nie nudził!");
                                        }
                                        if (z < 2)
                                        {

                                            Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                        }

                                        if (z > 2)
                                        {
                                            Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                        }
                                    }
                                    }
                                else
                                {
                                    goto beginning4;
                                }

                            }
                            if (userValue1111 == "5")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 1");
                                Console.WriteLine("Ilosć: 5");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    {
                                        int c = 1;
                                        int d = 5;
                                        Console.WriteLine("Wydałeś już wszystko.");
                                        Console.WriteLine("Pora nakręcic ten film.");
                                        int e = x + a + c;
                                        int f = y + b + d;
                                        int z = e / f;
                                        if (z == 2)
                                        {
                                            Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                            Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                            Console.WriteLine("aby nikt się nie nudził!");
                                        }
                                        if (z < 2)
                                        {

                                            Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                        }

                                        if (z > 2)
                                        {
                                            Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                        }
                                    }
                                    }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            else

                            {
                                goto beginning3;
                            }
                        }
                        }

                    else if (userValue22 == "5")
                    {
                        Console.WriteLine("Statystyki:");
                        Console.WriteLine("Jakość: 1");
                        Console.WriteLine("Ilosć: 5");
                        Console.WriteLine("Czy kupujesz? (tak/nie)");
                        string userValue222 = Console.ReadLine();
                        if (userValue222 == "tak")
                        {
                        beginning3:
                            int a = 1;
                            int b = 5;
                            Console.WriteLine("Pora to zakończyć:");
                            Console.WriteLine("1.Telefon dla dzieci za 1 złoty,");
                            Console.WriteLine("3. Monotlenek diwodoru prosto z Morza Południowochinskiego");
                            Console.WriteLine("4. Mózg do jedzenia.");
                            Console.WriteLine("Wybierz od 1, 3, lub 4.");
                            string userValue1111 = Console.ReadLine();
                            if (userValue1111 == "1")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 5");
                                Console.WriteLine("Ilosć: 1");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    {
                                        int c = 5;
                                        int d = 1;
                                        Console.WriteLine("Wydałeś już wszystko.");
                                        Console.WriteLine("Pora nakręcic ten film.");
                                        int e = x + a + c;
                                        int f = y + b + d;
                                        int z = e / f;
                                        if (z == 2)
                                        {
                                            Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                            Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                            Console.WriteLine("aby nikt się nie nudził!");
                                        }
                                        if (z < 2)
                                        {

                                            Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                        }

                                        if (z > 2)
                                        {
                                            Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                        }
                                    }
                                    }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            if (userValue1111 == "3")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 3");
                                Console.WriteLine("Ilosć: 3");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    {
                                        int c = 3;
                                        int d = 3;
                                        Console.WriteLine("Wydałeś już wszystko.");
                                        Console.WriteLine("Pora nakręcic ten film.");
                                        int e = x + a + c;
                                        int f = y + b + d;
                                        int z = e / f;
                                        if (z == 2)
                                        {
                                            Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                            Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                            Console.WriteLine("aby nikt się nie nudził!");
                                        }
                                        if (z < 2)
                                        {

                                            Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                        }

                                        if (z > 2)
                                        {
                                            Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                        }
                                    }
                                    }
                                else
                                {
                                    goto beginning4;
                                }

                            }
                            if (userValue1111 == "4")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 2");
                                Console.WriteLine("Ilosć: 4");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    {
                                        int c = 2;
                                        int d = 4;
                                        Console.WriteLine("Wydałeś już wszystko.");
                                        Console.WriteLine("Pora nakręcic ten film.");
                                        int e = x + a + c;
                                        int f = y + b + d;
                                        int z = e / f;
                                        if (z == 2)
                                        {
                                            Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                            Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                            Console.WriteLine("aby nikt się nie nudził!");
                                        }
                                        if (z < 2)
                                        {

                                            Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                        }

                                        if (z > 2)
                                        {
                                            Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                        }
                                    }
                                    }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            else

                            {
                                goto beginning3;
                            }
                        }

                        }
                    else
                    {
                        goto beginning2;
                    }
                }
                else
                {
                    goto beginning;
                }

            }

            else if (userValue == "3")
            {
                Console.WriteLine("Statystyki:");
                Console.WriteLine("Jakość: 3");
                Console.WriteLine("Ilosć: 3");
                Console.WriteLine("Czy kupujesz? (tak/nie)");
                string userValue3 = Console.ReadLine();
                if (userValue3 == "tak")
                {
                beginning2:
                    int x = 3;
                    int y = 3;
                    Console.WriteLine("Pora na kolejną rzecz:");
                    Console.WriteLine("1: Telefon dla dzieci za 1 złoty,");
                    Console.WriteLine("2:Beton w proszku,");
                    Console.WriteLine("4. Mózg do jedzenia,");
                    Console.WriteLine("5. Podręcznik Chiński w pięć sekund");
                    string userValue33 = Console.ReadLine();
                    if (userValue33 == "1")
                    {
                        Console.WriteLine("Statystyki:");
                        Console.WriteLine("Jakość: 5");
                        Console.WriteLine("Ilosć: 1");
                        Console.WriteLine("Czy kupujesz? (tak/nie)");
                        string userValue333 = Console.ReadLine();
                        if (userValue333 == "tak")
                        {
                        beginning3:
                            int a = 5;
                            int b = 1;
                            Console.WriteLine("Pora to zakończyć:");
                            Console.WriteLine("2.Beton w proszku,");
                            Console.WriteLine("4. Mózg do jedzenia");
                            Console.WriteLine("5. Podręcznik Chiński w pięć sekund");
                            Console.WriteLine("Wybierz 2, 3 lub 5");
                            string userValue1111 = Console.ReadLine();
                            if (userValue1111 == "2")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 4");
                                Console.WriteLine("Ilosć: 2");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    int c = 4;
                                    int d = 2;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            if (userValue1111 == "4")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 2");
                                Console.WriteLine("Ilosć: 4");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    int c = 2;
                                    int d = 4;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }

                            }
                            if (userValue1111 == "5")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 1");
                                Console.WriteLine("Ilosć: 5");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    int c = 1;
                                    int d = 5;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            else

                            {
                                goto beginning3;
                            }
                        }

                        }

                    else if (userValue33 == "2")
                    {
                        Console.WriteLine("Statystyki:");
                        Console.WriteLine("Jakość: 4");
                        Console.WriteLine("Ilosć: 2");
                        Console.WriteLine("Czy kupujesz? (tak/nie)");
                        string userValue333 = Console.ReadLine();
                        if (userValue333 == "tak")
                        {
                        beginning3:
                            int a = 4;
                            int b = 2;
                            Console.WriteLine("Pora to zakończyć:");
                            Console.WriteLine("1.Telefon dla dzieci za 1 złoty,");
                            Console.WriteLine("4.Mózg do jedzenia,");
                            Console.WriteLine("5. Podręcznik Chiński w pięć sekund");
                            Console.WriteLine("Wybierz od 1, 4 lub 5");
                            string userValue1111 = Console.ReadLine();
                            if (userValue1111 == "1")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 5");
                                Console.WriteLine("Ilosć: 1");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    int c = 5;
                                    int d = 1;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            if (userValue1111 == "4")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 2");
                                Console.WriteLine("Ilosć: 4");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    int c = 2;
                                    int d = 4;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }

                            }
                            if (userValue1111 == "5")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 1");
                                Console.WriteLine("Ilosć: 5");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    int c = 1;
                                    int d = 5;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            else

                            {
                                goto beginning3;
                            }
                        }

                        }
                    else if (userValue33 == "4")
                    {
                        Console.WriteLine("Statystyki:");
                        Console.WriteLine("Jakość: 2");
                        Console.WriteLine("Ilosć: 4");
                        Console.WriteLine("Czy kupujesz? (tak/nie)");
                        string userValue333 = Console.ReadLine();
                        if (userValue333 == "tak")
                        {
                        beginning3:
                            int a = 2;
                            int b = 4;
                            Console.WriteLine("Pora to zakończyć:");
                            Console.WriteLine("1.Telefon dla dzieci za 1 złoty,");
                            Console.WriteLine("2. beton w prszku");
                            Console.WriteLine("5. Podręcznik Chiński w pięć sekund");
                            Console.WriteLine("Wybierz 1, 2 lub 5.");
                            string userValue1111 = Console.ReadLine();
                            if (userValue1111 == "1")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 5");
                                Console.WriteLine("Ilosć: 1");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    int c = 5;
                                    int d = 1;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            if (userValue1111 == "2")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 4");
                                Console.WriteLine("Ilosć: 2");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    int c = 4;
                                    int d = 2;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }

                            }
                            if (userValue1111 == "5")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 1");
                                Console.WriteLine("Ilosć: 5");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    int c = 1;
                                    int d = 5;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            else

                            {
                                goto beginning3;
                            }
                        }
                        }

                    else if (userValue33 == "5")
                    {
                        Console.WriteLine("Statystyki:");
                        Console.WriteLine("Jakość: 1");
                        Console.WriteLine("Ilosć: 5");
                        Console.WriteLine("Czy kupujesz? (tak/nie)");
                        string userValue333 = Console.ReadLine();
                        if (userValue333 == "tak")
                        {
                        beginning3:
                            int a = 1;
                            int b = 5;
                            Console.WriteLine("Pora to zakończyć:");
                            Console.WriteLine("1.Telefon dla dzieci za 1 złoty,");
                            Console.WriteLine("2. Monotlenek diwodoru prosto z Morza Południowochinskiego");
                            Console.WriteLine("4. beton w proszku.");
                            Console.WriteLine("Wybierz 1, 3, lub 4.");
                            string userValue1111 = Console.ReadLine();
                            if (userValue1111 == "1")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 5");
                                Console.WriteLine("Ilosć: 1");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    int c = 5;
                                    int d = 1;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            if (userValue1111 == "2")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 4");
                                Console.WriteLine("Ilosć: 2");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    int c = 4;
                                    int d = 2;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }

                            }
                            if (userValue1111 == "4")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 2");
                                Console.WriteLine("Ilosć: 4");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    int c = 2;
                                    int d = 4;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            else

                            {
                                goto beginning3;
                            }
                        }

                        }
                    else
                    {
                        goto beginning2;
                    }
                }
                else
                {
                    goto beginning;
                }

            }

            else if (userValue == "4")
            {
                Console.WriteLine("Statystyki:");
                Console.WriteLine("Jakość: 2");
                Console.WriteLine("Ilosć: 4");
                Console.WriteLine("Czy kupujesz? (tak/nie)");
                string userValue4 = Console.ReadLine();
                if (userValue4 == "tak")
                {
                beginning2:
                    int x = 2;
                    int y = 4;
                    Console.WriteLine("Pora na kolejną rzecz:");
                    Console.WriteLine("1: Telefon dla dzieci za 1 złoty,");
                    Console.WriteLine("2:Beton w proszku,");
                    Console.WriteLine("3: Monotlenek diwodoru prosto z Morza Południowochinskiego,");
                    Console.WriteLine("5. Podręcznik Chiński w pięć sekund");
                    string userValue44 = Console.ReadLine();
                    if (userValue44 == "1")
                    {
                        Console.WriteLine("Statystyki:");
                        Console.WriteLine("Jakość: 5");
                        Console.WriteLine("Ilosć: 1");
                        Console.WriteLine("Czy kupujesz? (tak/nie)");
                        string userValue444 = Console.ReadLine();
                        if (userValue444 == "tak")
                        {
                        beginning3:
                            int a = 5;
                            int b = 1;
                            Console.WriteLine("Pora to zakończyć:");
                            Console.WriteLine("2.Beton w proszku,");
                            Console.WriteLine("3. Monotlenek diwodoru prosto z Morza Południowochinskiego");
                            Console.WriteLine("5. Podręcznik Chiński w pięć sekund");
                            Console.WriteLine("Wybierz 2, 3 albo 5.");
                            string userValue1111 = Console.ReadLine();
                            if (userValue1111 == "2")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 4");
                                Console.WriteLine("Ilosć: 2");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    int c = 4;
                                    int d = 2;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            if (userValue1111 == "3")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 3");
                                Console.WriteLine("Ilosć: 3");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    int c = 3;
                                    int d = 3;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }

                            }
                            if (userValue1111 == "5")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 1");
                                Console.WriteLine("Ilosć: 5");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    int c = 1;
                                    int d = 5;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            else

                            {
                                goto beginning3;
                            }
                        }

                    }

                    else if (userValue44 == "2")
                    {
                        Console.WriteLine("Statystyki:");
                        Console.WriteLine("Jakość: 4");
                        Console.WriteLine("Ilosć: 2");
                        Console.WriteLine("Czy kupujesz? (tak/nie)");
                        string userValue444 = Console.ReadLine();
                        if (userValue444 == "tak")
                        {
                        beginning3:
                            int a = 4;
                            int b = 2;
                            Console.WriteLine("Pora to zakończyć:");
                            Console.WriteLine("1.Telefon dla dzieci za 1 złoty,");
                            Console.WriteLine("3. Monotlenek diwodoru prosto z Morza Południowochinskiego");
                            Console.WriteLine("5. Podręcznik Chiński w pięć sekund");
                            Console.WriteLine("Wybierz 1, 3 lub 5");
                            string userValue1111 = Console.ReadLine();
                            if (userValue1111 == "1")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 5");
                                Console.WriteLine("Ilosć: 1");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    int c = 5;
                                    int d = 1;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            if (userValue1111 == "3")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 3");
                                Console.WriteLine("Ilosć: 3");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    int c = 3;
                                    int d = 3;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }

                            }
                            if (userValue1111 == "5")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 1");
                                Console.WriteLine("Ilosć: 5");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    int c = 1;
                                    int d = 5;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            else

                            {
                                goto beginning3;
                            }
                        }

                    }
                    else if (userValue44 == "3")
                    {
                        Console.WriteLine("Statystyki:");
                        Console.WriteLine("Jakość: 3");
                        Console.WriteLine("Ilosć: 3");
                        Console.WriteLine("Czy kupujesz? (tak/nie)");
                        string userValue444 = Console.ReadLine();
                        if (userValue444 == "tak")
                        {
                        beginning3:
                            int a = 3;
                            int b = 3;
                            Console.WriteLine("Pora to zakończyć:");
                            Console.WriteLine("1.Telefon dla dzieci za 1 złoty,");
                            Console.WriteLine("2.Beton w proszku,");
                            Console.WriteLine("5. Podręcznik Chiński w pięć sekund");
                            Console.WriteLine("Wybierz 1, 2 lub 5");
                            string userValue1111 = Console.ReadLine();
                            if (userValue1111 == "1")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 5");
                                Console.WriteLine("Ilosć: 1");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    int c = 5;
                                    int d = 1;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            if (userValue1111 == "2")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 4");
                                Console.WriteLine("Ilosć: 2");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    int c = 4;
                                    int d = 2;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }

                            }
                            if (userValue1111 == "5")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 1");
                                Console.WriteLine("Ilosć: 5");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    int c = 1;
                                    int d = 5;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            else

                            {
                                goto beginning3;
                            }
                        }
                    }

                    else if (userValue44 == "5")
                    {
                        Console.WriteLine("Statystyki:");
                        Console.WriteLine("Jakość: 1");
                        Console.WriteLine("Ilosć: 5");
                        Console.WriteLine("Czy kupujesz? (tak/nie)");
                        string userValue444 = Console.ReadLine();
                        if (userValue444 == "tak")
                        {
                        beginning3:
                            int a = 1;
                            int b = 5;
                            Console.WriteLine("Pora to zakończyć:");
                            Console.WriteLine("1.Telefon dla dzieci za 1 złoty,");
                            Console.WriteLine("2.Beton w proszku,");
                            Console.WriteLine("3. Monotlenek diwodoru prosto z Morza Południowochinskiego,");
                            Console.WriteLine("Wybierz od 1 do 3.");
                            string userValue1111 = Console.ReadLine();
                            if (userValue1111 == "1")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 5");
                                Console.WriteLine("Ilosć: 1");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    int c = 5;
                                    int d = 1;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            if (userValue1111 == "2")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 4");
                                Console.WriteLine("Ilosć: 2");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    int c = 4;
                                    int d = 2;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }

                            }
                            if (userValue1111 == "3")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość:3");
                                Console.WriteLine("Ilosć: 3");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    int c = 3;
                                    int d = 3;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            else

                            {
                                goto beginning3;
                            }
                        }
                }
                    else
                    {
                        goto beginning2;
                    }
                }
                else
                {
                    goto beginning;
                }

            }

            else if (userValue == "5")
            {
                Console.WriteLine("Statystyki:");
                Console.WriteLine("Jakość: 1");
                Console.WriteLine("Ilosć: 5");
                Console.WriteLine("Czy kupujesz? (tak/nie)");
                string userValue5 = Console.ReadLine();
                if (userValue5 == "tak")
                {
                beginning2:
                    int x = 1;
                    int y = 5;
                    Console.WriteLine("Pora na kolejną rzecz:");
                    Console.WriteLine("1: Telefon dla dzieci za 1 złoty,");
                    Console.WriteLine("2:Beton w proszku,");
                    Console.WriteLine("3: Monotlenek diwodoru prosto z Morza Południowochinskiego,");
                    Console.WriteLine("4. Mózg do jedzenia.");
                    string userValue55 = Console.ReadLine();
                    if (userValue55 == "1")
                    {
                        Console.WriteLine("Statystyki:");
                        Console.WriteLine("Jakość: 5");
                        Console.WriteLine("Ilosć: 1");
                        Console.WriteLine("Czy kupujesz? (tak/nie)");
                        string userValue555 = Console.ReadLine();
                        if (userValue555 == "tak")
                        {
                        beginning3:
                            int a = 5;
                            int b = 1;
                            Console.WriteLine("Pora to zakończyć:");
                            Console.WriteLine("2. Beton w proszku,");
                            Console.WriteLine("3. Monotlenek diwodoru prosto z Morza Południowochinskiego,");
                            Console.WriteLine("4. Mózg do jedzenia.");
                            Console.WriteLine("Wybierz 2, 3, lub 4");
                            string userValue1111 = Console.ReadLine();
                            if (userValue1111 == "2")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 4");
                                Console.WriteLine("Ilosć: 2");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    int c = 4;
                                    int d = 2;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            if (userValue1111 == "3")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 3");
                                Console.WriteLine("Ilosć: 3");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    int c = 3;
                                    int d = 3;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            else

                            {
                                goto beginning3;
                            }
                            if (userValue1111 == "4")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 2");
                                Console.WriteLine("Ilosć: 4");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    int c = 2;
                                    int d = 4;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                        }


                        }

                    else if (userValue55 == "2")
                    {
                        Console.WriteLine("Statystyki:");
                        Console.WriteLine("Jakość: 4");
                        Console.WriteLine("Ilosć: 2");
                        Console.WriteLine("Czy kupujesz? (tak/nie)");
                        string userValue555 = Console.ReadLine();
                        if (userValue555 == "tak")
                        {
                        beginning3:
                            int a = 4;
                            int b = 2;
                            Console.WriteLine("Pora to zakończyć:");
                            Console.WriteLine("1.Telefon dla dzieci za 1 złoty,");
                            Console.WriteLine("3. Monotlenek diwodoru prosto z Morza Południowochinskiego");
                            Console.WriteLine("4. Mózg do jedzenia.");
                            Console.WriteLine("Wybierz od 1, 3, lub 4.");
                            string userValue1111 = Console.ReadLine();
                            if (userValue1111 == "1")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 5");
                                Console.WriteLine("Ilosć: 1");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    int c = 5;
                                    int d = 1;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            if (userValue1111 == "3")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 3");
                                Console.WriteLine("Ilosć: 3");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    int c = 3;
                                    int d = 3;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }

                            }
                            if (userValue1111 == "4")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 2");
                                Console.WriteLine("Ilosć: 4");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    int c = 2;
                                    int d = 4;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            else

                            {
                                goto beginning3;
                            }
                        }

                        }
                    else if (userValue55 == "3")
                    {
                        Console.WriteLine("Statystyki:");
                        Console.WriteLine("Jakość: 3");
                        Console.WriteLine("Ilosć: 3");
                        Console.WriteLine("Czy kupujesz? (tak/nie)");
                        string userValue111 = Console.ReadLine();
                        if (userValue111 == "tak")
                        {
                        beginning3:
                            int a = 3;
                            int b = 3;
                            Console.WriteLine("Pora to zakończyć:");
                            Console.WriteLine("1.Telefon dla dzieci za 1 złoty,");
                            Console.WriteLine("2.Beton w proszku,");
                            Console.WriteLine("4. Mózg do jedzenia.");
                            Console.WriteLine("Wybierz 1, 2, lub 4.");
                            string userValue1111 = Console.ReadLine();
                            if (userValue1111 == "1")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 5");
                                Console.WriteLine("Ilosć: 1");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    int c = 5;
                                    int d = 1;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            if (userValue1111 == "2")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 4");
                                Console.WriteLine("Ilosć: 2");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    int c = 4;
                                    int d = 2;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }

                            }
                            if (userValue1111 == "4")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 2");
                                Console.WriteLine("Ilosć: 4");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    int c = 2;
                                    int d = 4;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            else

                            {
                                goto beginning3;
                            }
                        }
                        }

                    else if (userValue55 == "4")
                    {
                        Console.WriteLine("Statystyki:");
                        Console.WriteLine("Jakość: 2");
                        Console.WriteLine("Ilosć: 4");
                        Console.WriteLine("Czy kupujesz? (tak/nie)");
                        string userValue555 = Console.ReadLine();
                        if(userValue555 == "tak")
                        {
                        beginning3:
                            int a = 2;
                            int b = 4;
                            Console.WriteLine("Pora to zakończyć:");
                            Console.WriteLine("1.Telefon dla dzieci za 1 złoty,");
                            Console.WriteLine("2.Beton w proszku,");
                            Console.WriteLine("3. Monotlenek diwodoru prosto z Morza Południowochinskiego,");
                            Console.WriteLine("Wybierz od 1 do 3.");
                            string userValue1111 = Console.ReadLine();
                            if (userValue1111 == "1")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 5");
                                Console.WriteLine("Ilosć: 1");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    int c = 5;
                                    int d = 1;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            if (userValue1111 == "2")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość: 4");
                                Console.WriteLine("Ilosć: 2");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    int c = 4;
                                    int d = 2;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }

                            }
                            if (userValue1111 == "3")
                            {
                            beginning4:
                                Console.WriteLine("Statystyki:");
                                Console.WriteLine("Jakość:3");
                                Console.WriteLine("Ilosć: 3");
                                Console.WriteLine("Czy kupujesz? (tak/nie)");
                                string userValue11111 = Console.ReadLine();
                                if (userValue11111 == "tak")
                                {
                                    int c = 3;
                                    int d = 3;
                                    Console.WriteLine("Wydałeś już wszystko.");
                                    Console.WriteLine("Pora nakręcic ten film.");
                                    int e = x + a + c;
                                    int f = y + b + d;
                                    int z = e / f;
                                    if (z == 2)
                                    {
                                        Console.WriteLine("Gratulacje, twój film był na tyle długi,");
                                        Console.WriteLine("że nikt nie narzekał i wystarczająco wartościowy,");
                                        Console.WriteLine("aby nikt się nie nudził!");
                                    }
                                    if (z < 2)
                                    {

                                        Console.WriteLine("Coś nudne te wszystkie rzeczy, za dużo ich nakupiłeś.");
                                    }

                                    if (z > 2)
                                    {
                                        Console.WriteLine("Czekaliśmy tydzień na tak krótki filmik?!");

                                    }
                                }
                                else
                                {
                                    goto beginning4;
                                }
                            }
                            else

                            {
                                goto beginning3;
                            }
                        }

                    }
                    else
                    {
                        goto beginning2;
                    }
                }
                else
                {
                    goto beginning;
                }

            }
            else
            {
                goto beginning;

            }
                       
                Console.ReadLine();
        }
    }
}

