using System;

namespace tareaCalculadora
{
	class Calculadora {

	
	 static void Main(string[] args){

		int numero_1;
		int numero_2;

		
		Console.WriteLine("CALCULADORA");

		//INPUT
		Console.WriteLine("Introduzca el primer número:");
		numero_1 = int.Parse(Console.ReadLine());
		Console.WriteLine("Introduzca el segundo número:");
		numero_2 = int.Parse(Console.ReadLine());

		//RESULTADOS:
		Console.WriteLine($"Suma: {numero_1}+{numero_2}={numero_1+numero_2}");
		Console.WriteLine($"Multiplicación: {numero_1}*{numero_2}={numero_1*numero_2}");
		Console.WriteLine($"División: {numero_1}/{numero_2}={numero_1/numero_2}");
		Console.WriteLine($"Residuo: {numero_1}%{numero_2}={numero_1%numero_2}");
		
		//WAIT
		Console.ReadLine();


		}
	}
}