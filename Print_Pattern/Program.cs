using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Print_Pattern
{
     class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number of rows:-");
            n=Convert.ToInt32(Console.ReadLine());
            Hollow_square(n);
            Console.Write("-------------------------------------------");
            Console.WriteLine(" ");
            Number_triangle_Pattern(n);
            Console.Write("-------------------------------------------");
            Console.WriteLine(" ");
            Number_increasing_Pyramid_Pattern(n);
            Console.Write("-------------------------------------------");
            Console.WriteLine(" ");
            Number_increasing_reverse_Pyramid_Pattern(n);
            Console.Write("-------------------------------------------");
            Console.WriteLine(" ");
            Number_changing_Pyramid_Pattern(n);
            Console.Write("-------------------------------------------");
            Console.WriteLine(" ");
            Zero_One_Triangle_Pattern(n);
            Console.Write("-------------------------------------------");
            Console.WriteLine(" ");
            Palindrome_Triangle_Pattern(n);
            Console.Write("-------------------------------------------");
            Console.WriteLine(" ");
            Rhombus_Pattern(n);
            Console.Write("-------------------------------------------");
            Console.WriteLine(" ");
            Diamond_Star_Pattern(n);
            Console.Write("-------------------------------------------");
            Console.WriteLine(" ");
            Mirror_Image_Triangle_Pattern(n);
            Console.Write("-------------------------------------------");
            Console.WriteLine(" ");
            Hollow_Triangle_Pattern(n);
            Console.Write("-------------------------------------------");
            Console.WriteLine(" ");
            Hollow_Reverse_Triangle_Pattern(n);
            Console.Write("-------------------------------------------");
            Console.WriteLine(" ");
            Hollow_Hourglass_Pattern(n);
            Console.Write("-------------------------------------------");
            Console.WriteLine(" ");
            Hollow_Diamond_Pyramid(n);
            Console.Write("-------------------------------------------");
            Console.WriteLine(" ");
            Pascal_Triangle(n);
            Console.Write("-------------------------------------------");
            Console.WriteLine(" ");





            Console.ReadKey(); 
        }
        public static void Hollow_square(int n)
        {
            for(int i = 0;i<n;i++)
            {
                Console.Write("*");
                for(int j = 1;j<n-1;j++)
                {
                    if(i==0||i==n-1)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("*");
            }
        }
        
        public static void Number_triangle_Pattern(int n)
        {
            for(int i=1;i<=n;i++)
            {
                for(int s=n;s>i;s--)
                {
                    Console.Write(" ");
                }
                for(int k = 1; k <= i; k++)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public static void Number_increasing_Pyramid_Pattern(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(j);
                    Console.Write(' ');
                }
                Console.WriteLine() ;
            }
        }

        public static void Number_increasing_reverse_Pyramid_Pattern(int n)
        {
            for (int i = n; i >=1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }

        }

        public static void Number_changing_Pyramid_Pattern(int n)
        {
            int count = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(count);
                    count++;                  
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

        public static void Zero_One_Triangle_Pattern(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if((i+j)%2==0)
                    {
                        Console.Write(1);
                    }
                    else
                    {
                        Console.Write(0);
                    }
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

        }

        public static void Palindrome_Triangle_Pattern(int n)
        {
            for(int  i = 1; i <= n;i++)
            {
                for(int s=n; s>=i;s--)
                {
                    Console.Write("  ");
                }
                for(int j=i; j>=1;j--)
                {
                    Console.Write(j + " ");
                    
                }
                for (int k = 2; k <= i; k++)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Rhombus_Pattern(int n) 
        {
            for(int i=1; i<=n;i++)
            {
                for(int s=n-1;s>=i;s--)
                {
                    Console.Write(" ");
                }
                for(int k=1;k<=n;k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
         
        public static void Diamond_Star_Pattern(int n)
        {

            // for upper half
            for (int i=1;i<=n;i++)
            {
                
                for (int s=n-1;s>=i;s--)
                {
                    Console.Write(" ");
                }
                for(int j=1;j<=(2*i-1);j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();


            }

            // for Lower half
            for (int i = n-1; i >= 1; i--)
            {
                for (int s = n - 1; s >= i; s--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();


            }
        }

        public static void Mirror_Image_Triangle_Pattern(int n)
        {
            for(int i=1;i<=n;i++)
            {
                for(int s=1;s<i;s++)
                {
                    Console.Write(' ');
                }
                for(int j=i;j<=n;j++)
                {
                    Console.Write(j+ " ");
                }
                Console.WriteLine();
            }
            for (int i = n-1; i >= 1; i--)
            {
                for (int s = 1; s < i; s++)
                {
                    Console.Write(' ');
                }
                for (int j = i; j <= n; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Hollow_Triangle_Pattern(int n)
        {
            for(int i=1;i<=n;i++)
            {
                for(int s=n-1;s>=i;s--)
                {
                    Console.Write(" ");
                }
                for(int j=1;j<2*i-1;j++)
                {
                    if(i==1||j==1||i==n)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                   
                }
                Console.Write("*");
                Console.WriteLine();
            }
        }

        public static void Hollow_Reverse_Triangle_Pattern(int n)
        {
            for (int i = n; i >=1 ; i--)
            {
                for (int s = n - 1; s >= i; s--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < ((2 * i) - 1); j++)
                {
                    if (i == 1 || j == 1 || i == n)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(' ');
                    }

                }
                Console.Write("*");
                Console.WriteLine();
            }

        }

        public static void Hollow_Hourglass_Pattern(int n)
        {
            //for upper half
            for (int i = n; i >= 1; i--)
            {
                for (int s = n - 1; s >= i; s--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < ((2 * i) - 1); j++)
                {
                    if (i == 1 || j == 1 || i == n)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(' ');
                    }

                }
                Console.Write("*");
                Console.WriteLine();
            }
            //for lower half
            for (int i = 2; i <= n; i++)
            {
                for (int s = n - 1; s >= i; s--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < ((2 * i) - 1); j++)
                {
                    if (i == 1 || j == 1 || i == n)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(' ');
                    }

                }
                Console.Write("*");
                Console.WriteLine();
            }

        }

        public static void Hollow_Diamond_Pyramid(int n)
        {
            // for upper half
            for (int i = 1; i <= n; i++)
            {
                for (int s = n - 1; s >= i; s--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < ((2 * i) - 1); j++)
                {
                    if (i == 1 || j == 1 )
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(' ');
                    }

                }
                Console.Write("*");
                Console.WriteLine();
            }
            //for lower Half
            for (int i = n-1; i >= 1; i--)
            {
                for (int s = n - 1; s >= i; s--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < ((2 * i) - 1); j++)
                {
                    if (i == 1 || j == 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(' ');
                    }

                }
                Console.Write("*");
                Console.WriteLine();
            }

        }

        public static void Pascal_Triangle(int n)
        {
            
            for (int i=0;i<n; i++)
            {
                int c = 1;
                for (int j=0;j<n-i;j++)
                {
                    Console.Write(" ");
                }
                 for(int k=0;k<=i;k++)
                {
                    Console.Write(c + " ");
                    c = c * (i - k) / (k + 1);
                    
                    
                }
                Console.WriteLine();
            }
        }
    }
   
}
