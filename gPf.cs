using System;

namespace Arc264y
{
	// Token: 0x020014C1 RID: 5313
	internal sealed class gPf
	{
		// Token: 0x060134FD RID: 79101 RVA: 0x00770A54 File Offset: 0x0076EC54
		public static int u()
		{
			int num = 999;
			try
			{
				num = Environment.ProcessorCount;
			}
			catch (Exception)
			{
			}
			return num;
		}

		// Token: 0x060134FE RID: 79102 RVA: 0x00770A88 File Offset: 0x0076EC88
		public static string G(string string_0, int int_0)
		{
			lcc lcc = new lcc("Arc");
			bool flag = !Eyf.lx(string_0) && !Eyf.hK("Arc", string_0) && !Eyf.hK("CData Arc", string_0);
			if (int_0 == 0 && flag)
			{
				lcc.MPI(".").MPI(lZh.uv(string_0));
			}
			if (int_0 == 1)
			{
				lcc.MPI(".").MPI((!flag) ? "app" : lZh.uv(string_0)).MPI(".cloud");
			}
			if (int_0 == 2)
			{
				lcc.MPI(".").MPI((!flag) ? "app" : lZh.uv(string_0)).MPI(".")
					.MPI(lZh.uv(giw.D()));
			}
			lcc.MPI(".lic");
			return lcc.ToString();
		}

		// Token: 0x060134FF RID: 79103 RVA: 0x00770B80 File Offset: 0x0076ED80
		public static string j(string string_0)
		{
			return gPf.s(giw.p(), Eyf.Dx(string_0));
		}

		// Token: 0x06013500 RID: 79104 RVA: 0x00770BA0 File Offset: 0x0076EDA0
		public static string s(string string_0, string string_1)
		{
			return Eyf.VU(string_0, Eyf.Dx(string_1));
		}

		// Token: 0x06013501 RID: 79105 RVA: 0x00770BBC File Offset: 0x0076EDBC
		public static string V(string string_0)
		{
			return gPf.c(giw.p(), string_0);
		}

		// Token: 0x06013502 RID: 79106 RVA: 0x00770BD8 File Offset: 0x0076EDD8
		public static string c(string string_0, string string_1)
		{
			string text = gPf.s(string_0, gPf.G(string_1, 1));
			string text4;
			if (!Ecg.MG(text))
			{
				text = gPf.s(string_0, gPf.G(string_1, 2));
				if (!Ecg.MG(text))
				{
					text = gPf.s(string_0, gPf.G(string_1, 0));
					if (!Ecg.MG(text))
					{
						string text2 = gPf.i(string_1);
						if (!Eyf.hK(text2, string_1))
						{
							string text3 = gPf.c(string_0, text2);
							if (Ecg.MG(text3))
							{
								return text3;
							}
						}
						text4 = text;
					}
					else
					{
						text4 = text;
					}
				}
				else
				{
					text4 = text;
				}
			}
			else
			{
				text4 = text;
			}
			return text4;
		}

		// Token: 0x06013503 RID: 79107 RVA: 0x00770C68 File Offset: 0x0076EE68
		public static string f(string string_0)
		{
			string text;
			if (!Eyf.lx(string_0))
			{
				text = lXu.W(string_0.Trim());
			}
			else
			{
				text = string_0;
			}
			return text;
		}

		// Token: 0x06013504 RID: 79108 RVA: 0x00770C94 File Offset: 0x0076EE94
		public static string i(string string_0)
		{
			string text2;
			if (!Eyf.lx(string_0) && string_0.Length >= 2)
			{
				string text = Eyf.Dx(string_0);
				if (text[string_0.Length - 2] != 'v' || !char.IsDigit(text[string_0.Length - 1]))
				{
					text2 = string_0;
				}
				else
				{
					text2 = lcP.IZ(string_0, 0, string_0.Length - 2);
				}
			}
			else
			{
				text2 = string_0;
			}
			return text2;
		}

		// Token: 0x04008E98 RID: 36504
		public const int g = 0;

		// Token: 0x04008E99 RID: 36505
		public const int t = 1;

		// Token: 0x04008E9A RID: 36506
		public const int U = 2;
	}
}
