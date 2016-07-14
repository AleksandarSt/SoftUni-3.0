using System;
using System.Text.RegularExpressions;

namespace Telephony
{
	public class Smartphone : ICallable, IBrowsable
	{
		public void CallNumber(string number)
		{
			if (CanCallNumber(number))
			{
				Console.WriteLine($"Calling... {number}");
			}
			else
			{
				Console.WriteLine("Invalid number!");
			}
		}

		public void BrowseWebSite(string url)
		{
			if (CanBrowseWebSite(url))
			{
				Console.WriteLine($"Browsing: {url}!");
			}
			else
			{
				Console.WriteLine("Invalid URL!");
			}
		}

		private bool CanCallNumber(string number)
		{
			string pattern = @"^[0-9]*$";
			Regex regex = new Regex(pattern);

			return regex.IsMatch(number);
		}

		private bool CanBrowseWebSite(string url)
		{
			string pattern = @"^\D*$";
			Regex regex = new Regex(pattern);

			return regex.IsMatch(url);
		}
	}
}
