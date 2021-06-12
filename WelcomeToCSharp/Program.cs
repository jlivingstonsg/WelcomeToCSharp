using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WelcomeToCSharp
{
    class man
{
    string namn16;
    int hälsa16;
    int styrka16;
    int tur16;
    public man(string namn16, int hälsa16, int styrka16, int tur16)
    {
        this.namn16 = namn16;
        this.hälsa16 = hälsa16;
        this.styrka16 = styrka16;
        this.tur16 = tur16;
    }
    public string getnamn16()
    {
        return this.namn16;
    }
    public int gethälsa16()
    {
        return this.hälsa16;
    }
    public int getstyrka16()
    {
        return this.styrka16;
    }
    public int gettur16()
    {
        return this.tur16;
    }
    public void display()
    {
        Console.WriteLine("Spelare: " + this.namn16);
        Console.WriteLine("Hälsa: " + this.hälsa16);
        Console.WriteLine("Styrka: " + this.styrka16);
        Console.WriteLine("Tur: " + this.tur16);
    }
}
public class Program
{
    static void Main()
    {
        int uppgift;
        int day = 1;
        DateTimeOffset dateTimeObj = DateTime.Now;

        do
        {
            Console.Write("-------------------   \nVilken uppgift? ( 0 till 16 ) Noll avslutar programmet. Uppgift:  ");
            int uppgift1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------");
            uppgift = uppgift1;

            if (uppgift == 1)
            {
                Console.WriteLine("Hello World");
            }

            if (uppgift == 2)
            {
                Console.WriteLine("Förnamn, Efternamn, Ålder ?");
                string namnalder = Console.ReadLine();
                Console.WriteLine("Ditt namn och ålder är: " + namnalder + "!");
            }

            if (uppgift == 3)
            {

                switch (day)
                {
                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("____________Ändrar färg______________ ");
                    day += 1;
                    break;

                case 2:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("_____________Ändrar färg________________ ");
                    day -= 1;
                    break;
                }
            }

            if (uppgift == 4)
            {
                Console.WriteLine(dateTimeObj.UtcDateTime.ToString("d MMM yyyy"));
            }


            if (uppgift == 5)
            {
                Console.WriteLine("Ta reda på största talet. Skriv in första talet och använd ',' för decimaltal. ");
                double tal51 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Skriv det andra talet.");
                double tal52 = Convert.ToDouble(Console.ReadLine());
                if (tal51 > tal52)
                {
                    Console.WriteLine("Det första var störst.");
                }
                else
                {
                    Console.WriteLine("Det andra var störst.");
                }

            }



            if (uppgift == 6)
            {
                Random rnd = new Random();
                int rand6 = rnd.Next(1, 101);
                Console.WriteLine("Gissa heltalet mellan 1 och 100? Avsluta med facit.");
                double tal61 = Convert.ToDouble(Console.ReadLine());
                int num62 = 0;
                do
                {
                    num62 += 1;
                    Console.WriteLine("Försök igen. Antal försök: " + num62 + "  _________ Facit: " + rand6);
                    tal61 = Convert.ToDouble(Console.ReadLine());
                }
                while (tal61 != rand6 & tal61 != 0 & tal61 >= 0 & tal61 < 101);
                if (tal61 == rand6)
                {
                    num62 += 1;
                    Console.WriteLine("Rätt tal på " + num62 + "'e försöket.");
                }
                else
                {
                    Console.WriteLine("Tack för idag.");
                }

            }


            if (uppgift == 7)
            {
                Console.WriteLine("Skriv lite text som sparas i en fil. ");
                string filetext7 = Console.ReadLine();

                using (StreamWriter writer = new StreamWriter("filetext7.txt", true)) //// true to append data to the file
                {
                    writer.WriteLine(filetext7);
                }

            }


            if (uppgift == 8)
            {
                Console.WriteLine("Text hämtas från filen i uppgift 7. ");
                    Console.WriteLine("__________________________________________________________ ");

                    string lines = File.ReadAllText(@"C:\Users\Magi.MAGI-VAIO\source\repos\WelcomeToCSharp\WelcomeToCSharp\bin\Debug\filetext7.txt", Encoding.UTF8);
                Console.WriteLine(lines);
                    Console.WriteLine("__________________________________________________________");
                }


                if (uppgift == 9)
            {
                Console.WriteLine("Skriv ett decimaltal med ',' och få tillbaka roten ur, upphöjt till 2 och upphöjt till 10 ");
                double tal9x = Convert.ToDouble(Console.ReadLine());
                double tal9y = Math.Pow(tal9x, 10);
                Console.WriteLine("Talet blir " + tal9y);
            }

            if (uppgift == 10)
            {
                Console.WriteLine("Skriver ut en multiplikationstabell 10*10 \n------------------------------------------------------- ");
                for (int i = 1; i <= 10; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        Console.Write(i * j + "\t");
                    }
                    Console.Write("\n");
                }
            }

            if (uppgift == 11)
            {
                Console.WriteLine("Slumpar fram 10 tal och sorterar dem.  ");

                int[] arr11 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                Random random = new Random();
                arr11 = arr11.OrderBy(x => random.Next()).ToArray();
                foreach (var i in arr11)
                {
                    Console.Write(" " + i + " ");
                }
                Console.WriteLine("  ");

                Array.Sort(arr11);

                foreach (var i in arr11)
                {
                    Console.Write(" " + i + " ");
                }
                Console.WriteLine("  ");
                Console.WriteLine("  ");



            }

            if (uppgift == 12)
            {
                bool tf;
                string text;
                Console.WriteLine("  Palindrome ? ");

                Console.Write(" Skriv ett ord:    ");
                text = Console.ReadLine();
                do
                {
                    if (text.Length <= 1)
                    {
                        Console.WriteLine("--------\n Palindrome.");
                        break;
                    }
                    else
                    {
                        if (text[0] != text[text.Length - 1])
                        {
                            Console.WriteLine("-------\n Inte Palindrome.");
                            break;
                        }
                        else
                            text = (text.Substring(1, text.Length - 2));
                    }
                }
                while (text.Length >= 0);

            }

            if (uppgift == 13)
            {
                Console.WriteLine("Skriv två tal så skriver vi ut dem och alla heltal mellan dem. \nSkriv in det minsta första.\n-------- ");
                int tal131 = Convert.ToInt32(Console.ReadLine()) + 1;
                Console.WriteLine("Skriv det andra talet.");
                int tal132 = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.WriteLine("-----------------------------");
                int i;
                for (i = tal131; i <= tal132; i++)
                {
                    Console.Write(" " + i + " ");
                }

            }


            if (uppgift == 14)
            {
                Console.Write("Skriv in ett antal värden (komma-separerade) som sorteras och skrivs ut. \nUdda först sedan jämna.\nDina tal: ");
                string array14 = (Console.ReadLine());
                int[] arr = Array.ConvertAll(array14.Split(','), int.Parse);
                int n = arr.Length;

                // Current indexes from left and right
                int l = 0, r = n - 1;

                // Count of odd numbers
                int k = 0;

                while (l < r)
                {

                    // Find first even number
                    // from left side.
                    while (arr[l] % 2 != 0)
                    {
                        l++;
                        k++;
                    }

                    // Find first odd number from right side.
                    while (arr[r] % 2 == 0 && l < r)
                        r--;

                    // Swap even number present
                    // on left and odd
                    // number right.
                    if (l < r)
                    {
                        // swap arr[l] arr[r]
                        int temp = arr[l];
                        arr[l] = arr[r];
                        arr[r] = temp;
                    }
                }

                // Sort odd number in descending order
                Array.Sort(arr, 0, k);
                Array.Reverse(arr, 0, k);


                // Sort even number in ascending order
                Array.Sort(arr, k, n - k);


                Console.WriteLine(String.Join("   ", arr));


            }



            if (uppgift == 15)
            {
                Console.Write("Skriv in ett antal värden (komma-separerade) som adderas. \nDina tal: ");
                string array15 = (Console.ReadLine());
                int[] arr152 = Array.ConvertAll(array15.Split(','), int.Parse);

                var sum = 0;
                for (var i = 0; i < arr152.Length; i++)
                {
                    sum += arr152[i];
                }
                Console.WriteLine("Summan blir: " + sum);

            }

            if (uppgift == 16)
            {
                Console.WriteLine("Ge oss ett namn på en spelkaraktär så slumpar vi egenskaper.");
                string karaktar16 = Console.ReadLine();

                System.Random random = new System.Random();
                int hälsa16 = random.Next(0, 100);
                int styrka16 = random.Next(0, 100);
                int tur16 = random.Next(0, 100);
                string man16 = karaktar16;
                man m1 = new man(man16, hälsa16, styrka16, tur16);


                Console.WriteLine("Ge oss ett namn på en spelmotståndare så slumpar vi egenskaper.");
                string motstandare16 = Console.ReadLine();


                hälsa16 = random.Next(0, 100);
                styrka16 = random.Next(0, 100);
                tur16 = random.Next(0, 100);
                man16 = motstandare16;
                man m2 = new man(man16, hälsa16, styrka16, tur16);
                Console.WriteLine("------------------------------ ");

                m1.display();
                Console.WriteLine("------------------------------ ");

                m2.display();

            }



        }
        while (uppgift > 0 & uppgift <= 16);
    }
}

}