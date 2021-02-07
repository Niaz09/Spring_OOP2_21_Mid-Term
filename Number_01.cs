using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_38770_3__Lab_03_
{
    class Program
    {
        static void Main(string[] args)
        {
			int i;
			Console.WriteLine("Even numbers between 1 and 100:\n");
			for (i = 1; i <= 100; i++)
			{
				if (i % 2 == 0)
				{
					Console.WriteLine(i + " ");
				}
			}
		}
    }
}
