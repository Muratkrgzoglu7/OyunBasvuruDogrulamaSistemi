using System;
using System.Collections.Generic;
using System.Text;

namespace Gamer
{
	class UserValidationManager : IUserValidationService
	{
		public bool Validation(Gamer gamer)
		{
			if (gamer.Id==1&&gamer.FirstName=="MURAT"&&gamer.LastName=="KARAGÖZ"&&gamer.BirtYear=="123"&&gamer.NationaltyId==12345)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
