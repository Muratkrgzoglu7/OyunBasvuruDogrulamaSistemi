using System;
using System.Collections.Generic;
using System.Text;

namespace Gamer
{
	interface IGamerService
	{
		void Add(Gamer gamer);
		void Updated(Gamer gamer);
		void Deleted(Gamer gamer);
	}
}
