/*
 * Created by SharpDevelop.
 * User: julioc
 * Date: 11/09/2019
 * Time: 04:01 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PUNTO2
{
	class Program
	{
		public static void Main(string[] args)
		{
			double radio, opcion, area, b, h;
			Console.WriteLine("digite 1 para el area del circulo");
			Console.WriteLine("digite 2 para el area del rectangulo");
			Console.WriteLine("digite 3 para el area del triangulo");
			opcion = int.Parse(Console.ReadLine());
			
			if(opcion==1){
				Console.WriteLine("digite el radio del circulo");
				radio = int.Parse(Console.ReadLine());				                 
				area = Math.PI*Math.Pow(radio,2);
				Console.WriteLine("el area del circulo es: "+area);
			}else if(opcion==2){
				Console.WriteLine("digite la base del rectangulo");
				b = int.Parse(Console.ReadLine());		
				Console.WriteLine("digite la altura del rectangulo");
				h = int.Parse(Console.ReadLine());		
				area = b*h;
				Console.WriteLine("el area del ractangulo es: "+area);
						
			}else if(opcion==3){
				Console.WriteLine("digite la base del triangulo");
				b = int.Parse(Console.ReadLine());		
				Console.WriteLine("digite la altura del triangulo");
				h = int.Parse(Console.ReadLine());		
				area = (b*h)/2;
				Console.WriteLine("el area del triangulo es: "+area);
			}else{
				Console.WriteLine("digite opcion");
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}