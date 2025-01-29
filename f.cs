/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 29/01/2025
 * Time: 08:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace f
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Digite um número: ");
			
			double n1;
			n1 = Double.Parse(Console.ReadLine());
			
			Console.WriteLine("A raiz quadrada do número é: {0}", Math.Sqrt(n1));
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}