using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            countword();
            Console.WriteLine();
            CheckStringEqual();
            Console.WriteLine();
            CountAlphaNo();
            Console.WriteLine();
            ascending();
            Console.WriteLine();
        }


        public static void countword()
        {
            string s = "hello wel come to home";

            Console.WriteLine(s);

            int w = 1;
            int l = 0;

            while (l <= s.Length - 1)
            {
                if (s[l] == ' ' || s[l] == '\n' || s[l] == '\t')
                {
                    w++;
                }
                l++;
            }

            Console.WriteLine("Total word: {0}", w);

        }

        public static void CheckStringEqual()
        {
            string s1 = "hello welcome";
            string s2 = "hello welcome";

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            int l1 = s1.Length;
            int l2 = s2.Length;

            int flag = 0;
            int n = 0;
            int i = 0;

            if(l1 == l2)
            {
                for(i=0;  i<l1; i++)
                {
                    if (s1[i] != s2[i])
                    {
                        n = 1;
                        i = l1;
                    }
                }
            }

            if(l1 == l2)
            {
                flag = 0;
            }
            else if(l1 > l2)
            {
                 flag = 1;
            }
            else if(l1 < l2)
            {
                flag = -1;
            }


            if(flag == 0)
            {
                if (n == 0)
                {
                    Console.WriteLine("Both string and length are equal");
                }
                else
                {
                    Console.WriteLine("Both string equal but length are not equal");
                }
            }
            else if(flag == -1)
            {
                Console.WriteLine("Length of first string is small than second string");
            }
            else
            {
                Console.WriteLine("Length of first string greater than second string");
            }

        }


        public static void CountAlphaNo()
        {
            string s = "codejava67123@#$";

            Console.WriteLine(s);

            int i = 0, c = 0, c1 = 0, c2 = 0;
            int l = s.Length;


            while( i < l )
            {
                if (s[i] >= 'a' && s[i] <= 'z' || s[i] >= 'A' && s[i] <= 'Z')
                {
                    c++;
                }
                else if (s[i] >= '0' && s[i] <= '9')
                {
                    c1++;
                }
                else
                {
                    c2++;
                }
                i++;
            }

            Console.WriteLine("Alphabets:  {0}", c);
            Console.WriteLine("Digit:  {0}", c1);
            Console.WriteLine("Special:  {0}", c2);

        }


        public static void ascending()
        {
            string s = "welcome";
            Console.WriteLine(s);

            char[] a;
            char ch;

            int l = s.Length;
            a = s.ToCharArray(0, l);

            

            for(int i=0; i<l; i++)
            {
                for(int j=i+1; j<l-i; j++)
                {
                    if (a[i] > a[j])
                    {
                        ch = a[i];
                        a[i] = a[j];
                        a[j] = ch;
                    }
                }
            }


            Console.Write("After sorting the string appears like : \n");
            foreach (char c in a)
            {
                ch = c;
                Console.Write("{0} ", ch);
               
            }
            
            
        }
    }
}
