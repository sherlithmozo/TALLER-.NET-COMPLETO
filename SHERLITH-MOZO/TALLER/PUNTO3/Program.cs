/*
 * Created by SharpDevelop.
 * User: julioc
 * Date: 11/09/2019
 * Time: 04:13 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PUNTO3
{
	class Program
	{
		public static void Main(string[] args)
		{
			int mes;
			Console.WriteLine("digite el numero del mes");
			mes = int.Parse(Console.ReadLine());
			if(mes==1){
				Console.WriteLine("el mes enero: "+mes+"tiene 31 dias");
			}else if(mes==2){
				Console.WriteLine("el mes febrero: "+mes+"tiene 28 dias");
			}else if(mes==3){
				Console.WriteLine("el mes febrero: "+mes+"tiene 31 dias");
			}else if(mes==4){
				Console.WriteLine("el mes abril: "+mes+"tiene 30 dias");
			}else if(mes==5){
				Console.WriteLine("el mes mayo: "+mes+"tiene 31 dias");
			}else if(mes==6){
				Console.WriteLine("el mes junio: "+mes+"tiene 30 dias");
			}else if(mes==7){
				Console.WriteLine("el mes julio: "+mes+"tiene 31 dias");
			}else if(mes==8){
				Console.WriteLine("el mes agosto: "+mes+"tiene 31 dias");
			}else if(mes==9){
				Console.WriteLine("el mes septiembre: "+mes+"tiene 30 dias");
			}else if(mes==10){
				Console.WriteLine("el mes octubre: "+mes+"tiene 30 dias");
			}else if(mes==11){
				Console.WriteLine("el mes noviembre: "+mes+"tiene 31 dias");
			}else if(mes==12){
				Console.WriteLine("el mes diciembre: "+mes+"tiene 31 dias");
			}else{
				Console.WriteLine("digite el numero del mes");
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}