/*
 * Created by SharpDevelop.
 * User: julioc
 * Date: 11/09/2019
 * Time: 05:22 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PUNTO6
{
	class Program
	{
		public static void Main(string[] args)
		{
			double n, fn;
			Console.WriteLine("digite el valor de N");
			n = int.Parse(Console.ReadLine());
			
			fn = 1/Math.Sqrt(5)[Math.Pow(((1+Math.Sqrt(5))/2),n)-Math.Pow(((1+Math.Sqrt(5))/2),n)];
			                     
			Console.WriteLine("el valor de fn: "+fn);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}