using System;

namespace Arc264y
{
	// Token: 0x020014AF RID: 5295
	public class guQ
	{
		// Token: 0x06013414 RID: 78868 RVA: 0x0076A134 File Offset: 0x00768334
		public static rrQ s(string string_0)
		{
			rrQ rrQ2;
			if (string_0 != null)
			{
				foreach (rrQ rrQ in guQ.y)
				{
					string text = rrQ.W();
					if (lcP.nt(text, string_0))
					{
						return rrQ;
					}
				}
				rrQ2 = null;
			}
			else
			{
				rrQ2 = null;
			}
			return rrQ2;
		}

		// Token: 0x06013415 RID: 78869 RVA: 0x0076A18C File Offset: 0x0076838C
		public static string[] c(string string_0)
		{
			string[] array3;
			if (!Eyf.lx(string_0))
			{
				string text = gPf.f(string_0);
				bool[] array = new bool[guQ.y.Length];
				int num = 0;
				for (int i = 0; i < guQ.y.Length; i++)
				{
					string text2 = gPf.f(guQ.y[i].W());
					if (text.IndexOf(text2) >= 0)
					{
						array[i] = true;
						num++;
					}
				}
				string[] array2 = new string[num];
				int num2 = 0;
				for (int i = 0; i < guQ.y.Length; i++)
				{
					if (array[i])
					{
						array2[num2++] = guQ.y[i].W();
					}
				}
				array3 = array2;
			}
			else
			{
				array3 = new string[0];
			}
			return array3;
		}

		// Token: 0x06013416 RID: 78870 RVA: 0x0076A24C File Offset: 0x0076844C
		public static string r(rro rro_0)
		{
			string text = "";
			string text2;
			if (rro_0 != null)
			{
				foreach (rrQ rrQ in guQ.y)
				{
					if (rro_0.It(rrQ))
					{
						text = ((!Eyf.lx(text)) ? (text + "," + rrQ.W()) : rrQ.W());
					}
				}
				text2 = text;
			}
			else
			{
				text2 = text;
			}
			return text2;
		}

		// Token: 0x04008DE2 RID: 36322
		public static rrQ Q = new rrQ("IVLT", 100);

		// Token: 0x04008DE3 RID: 36323
		private static rrQ[] y = new rrQ[] { guQ.Q };
	}
}
