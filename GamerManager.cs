using System;
using System.Collections.Generic;
using System.Text;

namespace Gamer
{
	class GamerManager : IGamerService
	{
		IUserValidationService _userValidationService;
		public GamerManager(IUserValidationService userValidationService)
		{
			_userValidationService = userValidationService;
		}
		public void Deleted(Gamer gamer)
		{
			Console.WriteLine("Kayıt Başarıyla Silindi");
		}

		public void Add(Gamer gamer)
		{
			if (_userValidationService.Validation(gamer)==true)
			{
				Console.WriteLine("Kayıt Başarıyla Eklendi. Doğrulama Tamamlandı");
			}
			else
			{
				Console.WriteLine("Kayıt Başarısız. Doğrulama Tamamlanamadı");
			}
		}

		public void Updated(Gamer gamer)
		{
			Console.WriteLine("Kayıt Başarıyla Güncellendi");
		}
	}
}
