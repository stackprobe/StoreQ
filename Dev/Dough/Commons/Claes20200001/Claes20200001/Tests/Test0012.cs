﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Charlotte.Commons;

namespace Charlotte.Tests
{
	/// <summary>
	/// SimpleDateTime テスト
	/// </summary>
	public class Test0012
	{
		public void Test01()
		{
			Console.WriteLine(SimpleDateTime.Now().ToDateTime());
			Console.WriteLine(new SimpleDateTime(SimpleDateTime.Now().ToDateTime()));

			// ----

			SimpleDateTime dt = SimpleDateTime.Now();

			Console.WriteLine(dt); // Now
			Console.WriteLine(dt++); // Now
			Console.WriteLine(dt++); // Now + 1
			Console.WriteLine(dt++); // Now + 2
			Console.WriteLine(dt--); // Now + 3
			Console.WriteLine(dt--); // Now + 2
			Console.WriteLine(dt--); // Now + 1

			Console.WriteLine(dt); // Now
			Console.WriteLine(++dt); // Now + 1
			Console.WriteLine(++dt); // Now + 2
			Console.WriteLine(++dt); // Now + 3
			Console.WriteLine(--dt); // Now + 2
			Console.WriteLine(--dt); // Now + 1
			Console.WriteLine(--dt); // Now

			Console.WriteLine(dt); // Now
			Console.WriteLine(dt += 10); // Now + 10
			Console.WriteLine(dt -= 20); // Now - 10
			Console.WriteLine(dt += 10); // Now
			Console.WriteLine(dt); // Now

			// ----

			Console.WriteLine("done! (TEST-0012-01)");
		}
	}
}
