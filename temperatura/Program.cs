using System;

namespace temperatura
{
	class convertirTemperatura{
		static void Main(string[] args){

			double Celsius;
			double Fahrenheit;

			Console.WriteLine("CONVERTIDOR DE CELSIUS A FAHRENHEIT");
			
			Console.WriteLine("Escriba un numero de grados Celsius");
			Celsius = double.Parse(Console.ReadLine());

			Fahrenheit = (Celsius *9/5) + 32;

			Console.WriteLine($"{Celsius} grados Celsius , equivale a {Fahrenheit} grados Fahrenheit.");

			Console.ReadLine();


		}
	}
}