using System;

namespace Mayor{

	class Mayor{


		static void Main(string[] args){

			int[] Numeros = new int[3];
			int Mayor;

			Console.WriteLine("ELEGIR NUMERO MAYOR ENTRE 3 OPCIONES");

			Console.WriteLine("Ingrese 3 números");

			Numeros[0] = int.Parse(Console.ReadLine());
			Numeros[1] = int.Parse(Console.ReadLine());
			Numeros[2] = int.Parse(Console.ReadLine());

			Mayor = Math.Max(Numeros[0],Numeros[1]);
			Mayor = Math.Max(Mayor,Numeros[2]);

			Console.WriteLine($"El numero mayor es: {Mayor}");

			Console.ReadLine();
			

		}


	}


}