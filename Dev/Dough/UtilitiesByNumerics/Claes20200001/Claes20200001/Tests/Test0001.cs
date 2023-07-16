﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Numerics;
using Charlotte.Commons;
using Charlotte.Utilities;

namespace Charlotte.Tests
{
	/// <summary>
	/// MillerRabinTester テスト
	/// </summary>
	public class Test0001
	{
		public void Test01()
		{
			string RES_BIG_PRIMES = @"

345171570260461450792131917359
905830603842026502687610500391
339661018218263282468551767019
210228985843312006223933750641
474408815133232131017276187041
238864271211444134574585599509
387494079530768040659543625217
674375887234556833902326284147
449692934180956421193126503317
683780610293665304318432261359
821806272933533798555260603873
908272281982595331965073385793
786408824226504464630685722741
768472972164182698920193802471
893908818564031432372120593073
707420748246494435399524079717
362646092822307928221108195193
631579876438346047581406677323
580675247320672410993779488507
854359911712923490086418743689

4969079171442122994687766844484804794671
8756189136206915595728450244709541812151
9451967349735473679404261386517702131913
2331056656784934164404186993624186772951
5374111903538717743954091085307014213217
5728430035741959333247477583216902840007
5931322263317451677549457171555534043063
7018317663971231962919954009214685167481
1014878090565481621322701964057882592041
4356356533044265875148523225102434697251

77721621595101925123569939516054984256409183927741
22779387434895850108104537839872222531154820688949
36038352369012692919585566014919860888177873392017
77509441380579701535453173810589877949821091748293
87265670759210142129927657959062991601496682286377

";

			BigInteger[] bigPrimes = SCommon.TextToLines(RES_BIG_PRIMES)
				.Select(line => line.Trim())
				.Where(line => line != "")
				.Select(line => BigInteger.Parse(line))
				.ToArray();

			foreach (BigInteger bigPrime in bigPrimes)
				if (!MillerRabinTester.IsProbablePrime(bigPrime))
					throw new Exception(bigPrime.ToString());

			foreach (BigInteger bigPrime1 in bigPrimes)
				foreach (BigInteger bigPrime2 in bigPrimes)
					if (MillerRabinTester.IsProbablePrime(bigPrime1 * bigPrime2))
						throw new Exception(bigPrime1 + ", " + bigPrime2);

			foreach (BigInteger bigPrime1 in bigPrimes)
				foreach (int smallNumber in Enumerable.Range(2, 300))
					if (MillerRabinTester.IsProbablePrime(bigPrime1 * smallNumber))
						throw new Exception(bigPrime1 + ", " + smallNumber);

			Console.WriteLine("OK! (TEST-0001-01)");
		}
	}
}
