using System;
namespace _11NumberAsWords
{
    class Program
    {
        static void Main()
        {
            string[] stotki = new string[] { "One hundred", "Two hundred", "Three hundred", "Four hundred", "Five hundred", "Six hundred", "Seven hundred", "Eight hundred", "Nine hundred" };
            string[] desetki = new string[] {"twenty","thirty","forty","fifty","sixty","seventy","eight","ninety"};
            string[] edinici = new string[] {"zero","one","two","three","four","five","six","seven","eight","nine","ten","eleven","twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nighteen"};

            bool AND = true;
            string and = "and";
            int n =0;
            if( int.TryParse(Console.ReadLine(),out n))
            {


                if(n<20)
                Console.WriteLine(edinici[n]);
                else
                    if (n < 100)
                    {
                        int desetka = n / 10;
                        int edinica = n % 10;

                        Console.WriteLine(desetki[desetka - 2] + " " + ((edinica == 0) ? "" : edinici[edinica]));

                    }
                    else
                    {
                        int stotka = n / 100;
                        int desetka = n % 100 / 10;
                        int edinica = n % 100 % 10 ;

                        if(desetka == 1 )
                        {
                            edinica = n%100;
                            desetka = 0;
                            AND = true;
                        }

                        if (n % 100 == 0)
                            AND = false;

                        Console.WriteLine(stotki[stotka - 1] + " " + (AND? and : "") + " " + ((desetka == 0) ? "" : desetki[desetka - 2]) + " " + ((edinica == 0) ? "" : edinici[edinica]));

                    }

            }

        }
    }
}
