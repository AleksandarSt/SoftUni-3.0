using System;
using System.Collections.Generic;
using System.Linq;

namespace Telephony
{
	class Startup
	{
		static void Main()
		{
			string[] numbersToCall = Console.ReadLine().Split();
			string[] websitesToCall = Console.ReadLine().Split();

			var smarthphone=new Smartphone();

			foreach (var number in numbersToCall)
			{
				smarthphone.CallNumber(number);
			}

			foreach (var url in websitesToCall)
			{
				smarthphone.BrowseWebSite(url);
			}
		}
	}
}
