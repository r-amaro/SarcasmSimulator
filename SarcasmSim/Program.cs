using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarcasmSim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alex: Hey man! What's with the attitude? Why are you being so rude?");
            string input = Console.ReadLine();
            string space = " ";

            System.Text.StringBuilder sb = new System.Text.StringBuilder("");            

            for (int i = 0; i < input.Length; i++)
            {
                if(i % 2 == 0)//even index
                {
                    if(space != input[i].ToString())//skips if the index is on a space
                    {
                        sb.Append(input[i].ToString().ToUpper());
                    }
                    else
                    {
                        sb.Append(" ");
                    }
                }
                else//odd index
                {
                    if (space != input[i].ToString())//skips if the index is on a space
                    {
                        sb.Append(input[i].ToString().ToLower());
                    }
                    else
                    {
                        sb.Append(" ");
                    }
                }

            }
            Console.WriteLine("You: " + sb);
            Console.WriteLine("Alex: Nice, very mature.");
            Console.ReadLine();
        }
    }
}
