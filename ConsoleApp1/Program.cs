using System;
using System.Threading;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args){


			Console.WriteLine("Write custom number of Minutes");
			string number = Console.ReadLine(); 
			Random r = new Random();
			int minutes = 120;

			if (int.TryParse(number, out int n)&&n>0)
				minutes = n;

			Console.WriteLine($"Start time {DateTime.Now.TimeOfDay}");
			for (int j = 0; j < minutes; j++){

				int countOfJ = r.Next(1,120);
				int countOfK = r.Next(1,120);
				Console.WriteLine($"Iteration Time: {DateTime.Now.TimeOfDay} \tN: {j} \tJ: {countOfJ} \tK: {countOfK} ");


				for (int i = 0; i < countOfJ; i++){
					Thread.Sleep(r.Next(100,1000));
					Keyboard.Send(Keyboard.ScanCodeShort.KEY_J);
				}

				for (int i = 0; i < countOfK; i++){
					Thread.Sleep(r.Next(100,1000));
					Keyboard.Send(Keyboard.ScanCodeShort.KEY_K);
				}
			}
			Console.WriteLine($"Start time {DateTime.Now.TimeOfDay}");

			Console.ReadKey();
		}
	}
}