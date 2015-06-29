using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19SpiralMatrix
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[ , ] matrix = new int[n,n];

            int x1 = 0;
            int y1 = 0;
            int x2 = n-1 ;
            int y2 = n -1 ;

            int i=0;
            int j =0;

            int pomX=1;
            int pomY=1;
         
            bool nasokaLD = true;
            bool nasokaGD = false;
            bool nasokaDL = false;
            bool nasokaDG = false;

           int counter = 1;
            while(counter <=(n*n))
            {
               
                if(nasokaLD && i<x2 )
                {

                    matrix[j,i] = counter;
                    counter++;
                    i+=pomX;
                    continue;

                }else
                    if(nasokaLD && i==x2)
                    {
                        matrix[j,i] = counter;
                        counter++;
                        x2 --;
                        y1++;

                        nasokaLD = false;
                        nasokaGD = true;

                        pomX *= (-1);

                        j+=pomY;

                        continue;
                    }


                if(nasokaGD && j<y2 )
                {
                    matrix[j,i] = counter;
                    counter++;
                    j+=pomY;
                    continue;
                }
                else
                    if(nasokaGD && j==y2)
                    {
                        matrix[j,i] = counter;
                        counter++;
                        y2 --;
                       
                        nasokaGD = false;
                        nasokaDL = true;

                        pomY *= (-1);

                        
                        i+=pomX;
                        continue;
                    }



                if(nasokaDL && i>x1)
                {
                     matrix[j,i] = counter;
                    counter++;
                    i+=pomX;
                    continue;
                }
                else
                    if(nasokaDL && i==x1)
                    {
                         matrix[j,i] = counter;
                        counter++;
                        x1 ++;
                        nasokaDL = false;
                        nasokaDG = true;
                        
                        pomX*=(-1);

                        j+=pomY;
                        continue;

                    }


                if(nasokaDG && j>y1)
                {
                     matrix[j,i] = counter;
                    counter++;
                    j+=pomY;
                    continue;
                }
                else
                    if(nasokaDG && j==y1)
                    {
                         matrix[j,i] = counter;
                        counter++;                     
                        nasokaDG = false;
                        nasokaLD = true;
        
                        pomY *= (-1);

                        i+=pomX;
                        continue;

                    }


                      
                } 
            for(int l = 0;l<n;l++)
            {
                for (int k = 0; k < n; k++)
                    Console.Write(matrix[l, k]);
                Console.Write("\n");
            }
                
            }
        }
    }

