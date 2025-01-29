/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 29/01/2025
 * Time: 08:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace j
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Digite um número: ");
			
			double n1;
			n1 = Double.Parse(Console.ReadLine());
			
			Console.WriteLine("O resto da divisão por 2 do número é: {0}", n1 % 2);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}