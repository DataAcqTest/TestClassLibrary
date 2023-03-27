using System;
using System.Globalization;

namespace TestClassLibrary
{
	public static class Utility
	{
		public static string Convert(String input)
		{
			return "Prefix" + input.ToUpper();
		}
	}
}
