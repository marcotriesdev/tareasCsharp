using System;


namespace radioApp{

	class calcularRadio {
		static void Main(string[] args){

			double varRadio;
			double area;
			Console.WriteLine("CALCULAR AREA DE CIRCULO");

			//INPUT
			Console.WriteLine("Ingrese el radio del círculo");
			varRadio = double.Parse(Console.ReadLine());
			area = Math.PI * (varRadio*varRadio);

			//OUTPUT
			Console.WriteLine($"El área del circulo es: {area}. ");
			Console.ReadLine();




		}
	}

}

