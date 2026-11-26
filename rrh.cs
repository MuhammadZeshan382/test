using System;
using System.Diagnostics;
using RSSBus;

namespace Arc264y
{
	// Token: 0x02000E22 RID: 3618
	public class rrh
	{
		// Token: 0x0600F783 RID: 63363 RVA: 0x005EDBDC File Offset: 0x005EBDDC
		public static string x(string string_0)
		{
			if (string_0 != null)
			{
				try
				{
					string_0 = Eyf.Dx(string_0);
					lcc lcc = new lcc();
					foreach (int num in string_0)
					{
						if (num < 97 || num > 109)
						{
							if (num < 110 || num > 122)
							{
								if (num < 65 || num > 77)
								{
									if (num >= 78 && num <= 90)
									{
										num -= 13;
									}
								}
								else
								{
									num += 13;
								}
							}
							else
							{
								num -= 13;
							}
						}
						else
						{
							num += 13;
						}
						lcc.MPN(0, (char)(num & 255));
					}
					return lcc.ToString();
				}
				catch (Exception)
				{
					return null;
				}
			}
			return string_0;
		}

		// Token: 0x0600F784 RID: 63364 RVA: 0x005EDCB0 File Offset: 0x005EBEB0
		public static string m(string string_0, string string_1)
		{
			rrs rrs = new rrs(string_0);
			rrs.om(string_1);
			return Eyf.Im(rrs.Hy());
		}

		// Token: 0x0600F785 RID: 63365 RVA: 0x005EDCD8 File Offset: 0x005EBED8
		public static void p(string string_0, string string_1, string string_2, bool bool_0)
		{
			if ((DateTime.Now - rrh.P).TotalHours > 24.0)
			{
				lock (rrh.A)
				{
					if ((DateTime.Now - rrh.P).TotalHours > 24.0)
					{
						string text = Eyf.tg(Eyf.th());
						string text2 = string.Concat(new object[]
						{
							"start=",
							Process.GetCurrentProcess().StartTime,
							"&now=",
							text,
							"&nodeid=",
							string_1,
							"&sno=",
							string_2,
							"&machine=",
							Environment.MachineName
						});
						string text3 = "http://" + string_0 + "/lic/m/?info=" + Eyf.lO(rrh.x(text2));
						string text4 = "";
						try
						{
							text4 = rrh.m(string_0, text3);
						}
						catch (Exception)
						{
							if (!bool_0)
							{
								throw new RSBException("InvalidLicense", "Unable to check license.  Make sure the application can connect to ping.cdata.com.");
							}
						}
						rrh.P = DateTime.Now;
						string text5 = rrh.x(Eyf.OU(Eyf.Oh(text4)));
						if ((!bool_0 && !text5.StartsWith(Eyf.Dx(text))) || text5.Contains("_ko_"))
						{
							throw new RSBException("InvalidLicense", Eyf.OS(rrB.d, EEJ.MG()));
						}
					}
				}
			}
		}

		// Token: 0x0600F786 RID: 63366 RVA: 0x005EDEA8 File Offset: 0x005EC0A8
		public static int H(long long_0)
		{
			long secondsRemaining = long_0 - lyc.G() / 1000L;
			return secondsRemaining >= 0L ? (int)(secondsRemaining / 86400L) : 0;
		}

		// Token: 0x0600F787 RID: 63367 RVA: 0x005EDF00 File Offset: 0x005EC100
		public static bool r(long long_0)
		{
			return rrh.H(long_0) > 0;
		}

		// Token: 0x0600F788 RID: 63368 RVA: 0x005EDF18 File Offset: 0x005EC118
		public static bool K(byte[] byte_0)
		{
			return byte_0 != null && byte_0.Length > 5 && lXu.s(byte_0[5]);
		}

		// Token: 0x0600F789 RID: 63369 RVA: 0x005EDF3C File Offset: 0x005EC13C
		public static int j()
		{
			DateTime now = DateTime.Now;
			return lXu.pp(now.Year, now.Month, now.Day);
		}

		// Token: 0x0600F78A RID: 63370 RVA: 0x005EDF70 File Offset: 0x005EC170
		public static int f(byte[] byte_0)
		{
			int num;
			if (byte_0 == null || byte_0.Length < 16)
			{
				num = -1;
			}
			else
			{
				num = lXu.pp(2000 + (int)(10 * (byte_0[14] - 48)) + (int)(byte_0[15] - 48), (int)(10 * (byte_0[10] - 48) + (byte_0[11] - 48)), (int)(10 * (byte_0[12] - 48) + (byte_0[13] - 48)));
			}
			return num;
		}

		// Token: 0x0600F78B RID: 63371 RVA: 0x005EDFD4 File Offset: 0x005EC1D4
		public static bool G(byte[] byte_0)
		{
			return byte_0 != null && byte_0.Length > 6 && byte_0[6] == 89;
		}

		// Token: 0x0600F78C RID: 63372 RVA: 0x005EDFF4 File Offset: 0x005EC1F4
		public static bool t(byte[] byte_0)
		{
			return byte_0 != null && byte_0.Length > 5 && byte_0[5] == 65;
		}

		// Token: 0x0600F78D RID: 63373 RVA: 0x005EE014 File Offset: 0x005EC214
		public static string W(int int_0, string string_0, string string_1, string string_2, string string_3, string string_4)
		{
			lmD<int, string> lmD = new lmD<int, string>();
			lmD.H(8, "This system contains a license for {0} that has been installed but not activated.  You must re-activate this license on this system");
			lmD.H(9, "This system contains a license for {0} that has expired.  Please visit {1} or email {2} for information on purchasing a license or extending your license");
			lmD.H(-1, "Could not find a valid license for using {0} on this system.  To activate a trial license, please find your product key in your email, or apply a product key to register the product");
			return rrh.D(int_0, string_0, string_1, string_2, string_3, string_4, lmD);
		}

		// Token: 0x0600F78E RID: 63374 RVA: 0x005EE060 File Offset: 0x005EC260
		public static string D(int int_0, string string_0, string string_1, string string_2, string string_3, string string_4, lmD<int, string> lmD_0)
		{
			string text = string_1;
			if (int_0 == 0 || int_0 == 8 || int_0 == 9)
			{
				if (string_0 != null && string_0.Length > 0)
				{
					text = string_0;
				}
				text = Eyf.OC(text, "-", "");
				if (!text.StartsWith("X"))
				{
					text = "X" + text;
				}
				lcc lcc = new lcc();
				for (int i = 0; i < text.Length; i++)
				{
					if (i > 0 && i % 5 == 0)
					{
						lcc.MPI('-');
					}
					lcc.MPI((i >= text.Length - 6) ? '*' : text[i]);
				}
				text = lcc.ToString();
			}
			if (int_0 != 0)
			{
				char c = (char)(65 + int_0);
				switch (int_0)
				{
				case 8:
					string_2 += Eyf.IB(lmD_0.m(8), false, new object[] { string_3 });
					break;
				case 9:
					string_2 += Eyf.IB(lmD_0.m(9), false, new object[]
					{
						string_3,
						EEJ.MH(),
						EEJ.MW()
					});
					break;
				default:
					string_2 += Eyf.IB(lmD_0.m(-1), false, new object[] { string_3 });
					break;
				}
				throw new RSBException("rsb:license", string.Concat(new object[] { string_2, " [code: ", c, " nodeid: ", string_4, "]." }));
			}
			return text;
		}

		// Token: 0x0600F78F RID: 63375 RVA: 0x005EE238 File Offset: 0x005EC438
		public static lmr<string> i(int int_0, byte[] byte_0, string[] string_0)
		{
			lmr<string> lmr = new lmr<string>();
			lmr<string> lmr2;
			if (byte_0 != null && byte_0.Length >= int_0)
			{
				int num = int_0;
				while (num < byte_0.Length && num + 3 < byte_0.Length)
				{
					bool flag = true;
					for (int i = 0; i < string_0.Length; i++)
					{
						byte[] array = Eyf.IV(string_0[i]);
						if (lXu.mG(byte_0[num]) == lXu.mG(array[0]) && lXu.mG(byte_0[num + 1]) == lXu.mG(array[1]) && lXu.mG(byte_0[num + 2]) == lXu.mG(array[2]) && lXu.mG(byte_0[num + 3]) == lXu.mG(array[3]))
						{
							lmr.Add(string_0[i]);
							flag = false;
							break;
						}
					}
					if (flag)
					{
						break;
					}
					num += 4;
				}
				lmr2 = lmr;
			}
			else
			{
				lmr2 = lmr;
			}
			return lmr2;
		}

		// Token: 0x040068A4 RID: 26788
		private static DateTime P = new DateTime(0L);

		// Token: 0x040068A5 RID: 26789
		private static object A = new object();
	}
}
