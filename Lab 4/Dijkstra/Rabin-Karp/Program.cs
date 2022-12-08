using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Rabin_Karp
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int[] value = Algorithm.SearchString(
				"хто грає в DOTA2, в того нема життя соцыального",
                "DOTA2"
            );
			foreach (var item in value)
				Console.WriteLine("Индекс =" + item);

            value = Algorithm.Mine(
               "хто грає в DOTA2, в того нема життя соцыального",
                "DOTA2"
            );
            foreach (var item in value)
                Console.WriteLine(item);
        }
		
	}
}
