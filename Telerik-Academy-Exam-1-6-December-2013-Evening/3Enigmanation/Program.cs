using System;
namespace _3Enigmanation
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            input = input.Split('=')[0];
            long rez1 = 0;

            input = input.Trim(new char[] { ' ', '+', '-' });

            string[] k = input.Split(new char[] { '(', ')' });

            string resultStr = "";
           for (int i = 0; i < k.Length;i++ )
        {
            string s = k[i];
            if (s == "")
                continue;

            if (char.IsDigit(s[0]) && char.IsDigit(s[s.Length - 1]))
            {
                rez1 = calc(s); // calc(s) returns  a result  of calculations between '('')'
                resultStr += rez1.ToString();//resultStr is a string that not contains ()
            }
            else
                resultStr += s;

        }

        Console.WriteLine("{0:0.000}",calc(resultStr));

        }

        static long calc(string p)
        {
           long digit = 0;
            long rez = 0;
            long rez1 = 0;
            bool inDigit = false ;
            char operand = ' ';
           p = p.Trim(new char[] {'=',' '});
            
            for(int i=0;i<p.Length;i++ )
            {
                char c = p[i];
        
                if(long.TryParse(c.ToString(),out digit))
                {
                    if(operand!=' '){

                        while (i < p.Length && char.IsDigit(p[i]))
                        {
                            rez1 = rez1 * 10 + int.Parse(p[i].ToString());
                            i++;
                            inDigit = true;
                        }
                        if(inDigit)
                        {
                            i--;
                            inDigit = false;
                        }

                        switch (operand)
                        {
                            case '+':
                                {
                                    rez += rez1;
                                    rez1 = 0;
                                    break;
                                }
                            case '-':
                                {
                                    rez -= rez1;
                                    rez1 = 0;
                                    break;
                                }
                            case '*':
                                {
                                    rez *= rez1;
                                    rez1 = 0;
                                    break;
                                }
                            case '%':
                                {
                                    rez %= rez1;
                                    rez1 = 0;
                                    break;
                                }
                            default:
                                {
                                    throw new ArgumentException(); 
                                    break;
                                }
                        }
                    }
                    else
                    {
                        rez = rez*10 + digit;
                       
                    }
                   
                }
                else
                {
                    if ((c == '+' || c == '-' || c == '*' || c == '%'))
                        operand = c;
                    else continue;
                }
                

            }

            return rez;
        }

    }
}
