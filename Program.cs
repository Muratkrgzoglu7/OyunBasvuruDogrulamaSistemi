using System;

namespace Gamer
{
	class Program
	{
		static void Main(string[] args)
		{
			GamerManager gamerManager = new GamerManager(new UserValidationManager());
			gamerManager.Add(new Gamer { Id = 1, FirstName = "MURAT", LastName = "KARAGÖZ", BirtYear = "123", NationaltyId = 12345 });
		}
	}
}
