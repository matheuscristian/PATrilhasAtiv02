/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 29/01/2025
 * Time: 08:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace g
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite dois números: ");
			
			double n1, n2;
			n1 = Double.Parse(Console.ReadLine());
			n2 = Double.Parse(Console.ReadLine());
			
			Console.WriteLine("A subtração dos dois números é: {0}", n1 - n2);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}