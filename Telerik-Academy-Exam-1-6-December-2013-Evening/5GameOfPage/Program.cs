using System;
namespace _5GameOfPage
{
    class Program
    {
        static string[] matrix = new string[18];
       
        static void Main()
        {
           //adding 0's arround the matrix
            matrix[0] = new string('0',18);
            matrix[17] = new string('0',18);
           


            for(int i=1;i<=16;i++)
            {
                matrix[i] ="0"+Console.ReadLine()+"0";// reading the matrix
            }

            bool pay = false;
            decimal cost = 0.00m;
            int row = 0;
            int colum = 0;

            while(!pay)
            {
               string question =  Console.ReadLine();
                if(question.Equals("paypal"))
                {
                    Console.WriteLine("{0:F2}",cost);
                    pay = true;
                    continue;
                }
                else
                {   
                    row = int.Parse(Console.ReadLine()) + 1;
                    colum = int.Parse(Console.ReadLine()) + 1;

                    if(question.Equals("what is"))
                    {
                        Console.WriteLine(whatIs(row, colum));

                    }else
                        if (question.Equals("buy"))
                    {
                        string rezult = whatIs(row,colum);
                        if (rezult.Equals("cookie"))
                        {
                            // delete the cookie from the tray
                            char[] a = matrix[row - 1].ToCharArray();
                            a[colum-1]='0';
                            a[colum] = '0';
                            a[colum+1] = '0';
                            char[] b = matrix[row].ToCharArray();
                            b[colum - 1] = '0';
                            b[colum] = '0';
                            b[colum + 1] = '0';
                             char[] c = matrix[row+1].ToCharArray();
                            c[colum - 1] = '0';
                            c[colum] = '0';
                            c[colum + 1] = '0';
                            matrix[row - 1] = new string(a) ;
                            matrix[row] = new string(b);
                            matrix[row + 1] = new string(c);

                            cost += 1.79m;

                        }
                        else
                            if (rezult.Equals("broken cookie") || rezult.Equals("cookie crumb"))
                            {
                                Console.WriteLine("page");
                            }
                            else
                                Console.WriteLine("smile");
                    }
                }
                
            }



        }

        static string whatIs(int row, int colum)
        {
           
                string k = matrix[row - 1].Substring(colum - 1, 3) + matrix[row].Substring(colum - 1, 1)+matrix[row].Substring(colum +1, 1) + matrix[row + 1].Substring(colum - 1, 3); // arrow of all pices  from the cookie except the  central one
                  
                if (matrix[row][colum] == '1')
                {
                      if(!k.Contains("1"))
                    {
                        return "cookie crumb";

                    }
                      else
                      {
                          if(k.Contains("0"))
                          {
                              return "broken cookie";
                          }
                          else
                          {
                              return "cookie";
                          }
                      }

                }
                else
                {                  
                        return "smile";
                }
            }

        }
    }

