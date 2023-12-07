using System;
using System.Collections.Generic;

namespace DesignPattern_Csharp
{
	public class ClsSingleTon
	{
		public static int intCounter;
		private ClsSingleTon()
		{
			// This is a private constructor
		}
		public static void Hit()
		{
			intCounter++;
		}
		public static int getTotalHits()
		{
			return intCounter;
		}
	}
}

