using System;
namespace CarLotSimulator
{
	public class Car
	{
		public Car()
		{
		}





		public Car(string make, string model, int year, bool isDriveable,string honkNoise, string engineNoise)
		{
			Make = make;

			Model = model;

			Year = year;

			IsDriveable = isDriveable;

			EngineNoise = engineNoise;

			HonkNoise = honkNoise; 



		}
		


        public int Year;

		public string Make { get; set; }

		public string Model { get; set; }

		public string EngineNoise { get; set; }

		public string HonkNoise { get; set; }

		public bool IsDriveable;



		public void MakeHonkNoise(string honkNoise)
		{

			Console.WriteLine(honkNoise); 
			


		}


		public void MakeEngineNoise(string engineNoise)

		{

			Console.WriteLine(engineNoise); 



		}


	}

}

