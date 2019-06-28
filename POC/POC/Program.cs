using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri1686();
        }

        static void Uri2918()
        {
            string input;
            while ((input = Console.ReadLine()) != null && input != "")
            {
                string[] str = input.Split();

                long l = long.Parse(str[0]);
                long r = long.Parse(str[1]);

                long sum = 0;
                for (long i = l; i <= r; i++)
                {
                    long val = 0;
                    char[] s = (i.ToString()).ToCharArray();
                    for (long j = 0; j < s.LongLength; j++)
                    {
                        val += long.Parse(s[j].ToString());
                    }

                    sum += val;
                }
                Console.WriteLine(sum);
            }
        }

        static void Uri1240()
        {
            long n = long.Parse(Console.ReadLine());
            long i = 0;
            while (i < n)
            {
                string l = Console.ReadLine();
                string r = Console.ReadLine();

                if (l.Length >= r.Length)
                {
                    char[] n1 = l.ToCharArray();
                    char[] n2 = r.ToCharArray();

                    bool tem = true;
                    for (var j = n2.Length - 1; j > 0; j--)
                    {
                        if (n2[j] != n1[j + n1.Length - n2.Length])
                        {
                            tem = false;
                            break;
                        }
                    }

                    if (tem)
                    {
                        Console.WriteLine("encaixa");
                    }
                    else
                    {
                        Console.WriteLine("nao encaixa");
                    }
                }
                else
                {
                    Console.WriteLine("nao encaixa");
                }
                i++;
            }
        }

        static void Uri1257()
        {
            char[] moc =
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
            };

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int sum = 0;

                string val = Console.ReadLine();
                int num = int.Parse(val);

                for (int p = 0; p < num; p++)
                {
                    string input = Console.ReadLine();
                    char[] arr = input.ToCharArray();

                    for (int j = 0; j < arr.Length; j++)
                    {
                        int k;
                        if (!int.TryParse(arr[j].ToString(), out k))
                        {
                            for (k = 0; k < moc.Length; k++)
                            {
                                if (moc[k] == arr[j])
                                {
                                    break;
                                }
                            }
                        }
                        int alphabet = k;
                        int element = p;
                        int position = j;

                        sum += alphabet + element + position;
                    }
                }

                Console.WriteLine(sum);
            }
        }

        static void Uri1237()
        {
            string input;
            while ((input = Console.ReadLine()) != null && input != "")
            {
                string input2 = Console.ReadLine();

                char[] arr = input.ToCharArray();

                int max = 0;
                string combo = @"";
                for (int i = 0; i < arr.Length; i++)
                {
                    combo += arr[i];
                    if (input2.Contains(combo))
                    {
                        if (combo.Length > max)
                        {
                            max++;
                        }
                    }
                    else
                    {
                        combo = "";
                    }
                }

                Console.WriteLine(max);
            }
        }

        static void Uri1686()
        {
            
        }
    }
}
