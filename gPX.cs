using System;

namespace Arc264y
{
	// Token: 0x020014C0 RID: 5312
	internal sealed class gPX
	{
		// Token: 0x060134F0 RID: 79088 RVA: 0x0007C8A9 File Offset: 0x0007AAA9
		internal gPX(lmr<gPr> lmr_0, lmD<string, int> lmD_0, lmD<string, int> lmD_1)
		{
			this.P = lmr_0;
			this.W = ((lmD_0 == null) ? new lmD<string, int>() : lmD_0);
			this.r = ((lmD_1 == null) ? new lmD<string, int>() : lmD_1);
		}

		// Token: 0x060134F1 RID: 79089 RVA: 0x00770620 File Offset: 0x0076E820
		internal bool c()
		{
			return this.P != null;
		}

		// Token: 0x060134F2 RID: 79090 RVA: 0x0077063C File Offset: 0x0076E83C
		internal lmr<gPr> p()
		{
			return this.P;
		}

		// Token: 0x060134F3 RID: 79091 RVA: 0x00770654 File Offset: 0x0076E854
		internal lmD<string, int> x()
		{
			return this.W;
		}

		// Token: 0x060134F4 RID: 79092 RVA: 0x0077066C File Offset: 0x0076E86C
		internal lmD<string, int> t()
		{
			return this.r;
		}

		// Token: 0x060134F5 RID: 79093 RVA: 0x00770684 File Offset: 0x0076E884
		internal void m(string string_0, int int_0)
		{
			for (int i = 0; i < int_0; i++)
			{
				this.P.Add(new gPr(null, Evv.q, null, string_0, false));
			}
		}

		// Token: 0x060134F6 RID: 79094 RVA: 0x007706B4 File Offset: 0x0076E8B4
		internal gPX E(gPy gPy_0)
		{
			lmr<gPr> lmr = gPy_0.E();
			lmr<gPr> lmr2 = new lmr<gPr>();
			gPr gPr;
			if (this.P != null)
			{
				using (lmg<gPr> lmg = this.P.O())
				{
					while (lmg.MoveNext())
					{
						gPr = lmg.Current;
						if (!gPX.u(gPr, lmr))
						{
							lmr2.Add(gPr);
						}
					}
					goto IL_0018;
				}
				goto IL_00A1;
			}
			IL_0018:
			int num = 0;
			IL_001A:
			bool flag;
			int num2;
			if (num < lmr.G())
			{
				gPr = lmr.y(num);
				flag = false;
				num2 = num + 1;
				goto IL_0053;
			}
			lmD<string, int> lmD = new lmD<string, int>();
			lyh lyh = Eyf.AS<string, int>(this.W);
			while (lyh.MPP())
			{
				string text = (string)lyh.MPX();
				lmD.H(text, this.W.m(text));
			}
			gPX gPX = new gPX(lmr2, lmD, this.r);
			lmD<string, int> lmD2 = gPy_0.H();
			lyh = Eyf.AS<string, int>(lmD2);
			while (lyh.MPP())
			{
				string text = (string)lyh.MPX();
				gPX.H(text, lmD2.m(text));
			}
			return gPX;
			IL_003B:
			bool flag2;
			if (!flag2)
			{
				if (!flag)
				{
					lmr2.Add(gPr);
				}
				num++;
				goto IL_001A;
			}
			flag = gPX.y(gPr, lmr.y(num2));
			num2++;
			IL_0053:
			if (num2 >= lmr.G())
			{
				flag2 = false;
				goto IL_003B;
			}
			IL_00A1:
			flag2 = !flag;
			goto IL_003B;
		}

		// Token: 0x060134F7 RID: 79095 RVA: 0x00770828 File Offset: 0x0076EA28
		private static bool u(gPr gPr_0, lmr<gPr> lmr_0)
		{
			using (lmg<gPr> lmg = lmr_0.O())
			{
				while (lmg.MoveNext())
				{
					gPr gPr = lmg.Current;
					if (!gPX.B(gPr.c()))
					{
						if (!gPX.B(gPr_0.c()) && Eyf.hK(gPr_0.W(), gPr.W()))
						{
							return true;
						}
					}
					else if (Eyf.hK(gPr_0.i(), gPr.i()))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060134F8 RID: 79096 RVA: 0x005FDCA4 File Offset: 0x005FBEA4
		private static bool B(Evv evv_0)
		{
			return evv_0 == Evv.x || evv_0 == Evv.J;
		}

		// Token: 0x060134F9 RID: 79097 RVA: 0x007708C8 File Offset: 0x0076EAC8
		private static bool y(gPr gPr_0, gPr gPr_1)
		{
			return Eyf.hK(gPr_0.i(), gPr_1.i()) && Eyf.hK(gPr_0.W(), gPr_1.W());
		}

		// Token: 0x060134FA RID: 79098 RVA: 0x007708FC File Offset: 0x0076EAFC
		internal void H(string string_0, int int_0)
		{
			string text = Eyf.Dx(string_0);
			int num = ((!this.W.ContainsKey(text)) ? 0 : this.W.m(text));
			this.W.H(text, num + int_0);
		}

		// Token: 0x060134FB RID: 79099 RVA: 0x00770940 File Offset: 0x0076EB40
		internal lyv<string> K()
		{
			lyv<string> lyv2;
			if (this.P != null)
			{
				lyv<string> lyv = new lyv<string>();
				using (lmg<gPr> lmg = this.P.O())
				{
					while (lmg.MoveNext())
					{
						gPr gPr = lmg.Current;
						string text = gPr.t();
						if (guo.bu(text, false) != 20)
						{
							lyv.Add(text);
						}
						else if (!gPr.A())
						{
							if (!gPr.m())
							{
								lyv.Add(text);
							}
						}
						else
						{
							lyv.Add(text);
							lyv.Add(text);
						}
					}
				}
				lyv2 = lyv;
			}
			else
			{
				lyv2 = null;
			}
			return lyv2;
		}

		// Token: 0x060134FC RID: 79100 RVA: 0x00770A00 File Offset: 0x0076EC00
		internal int D()
		{
			int num = 0;
			lyh lyh = Eyf.AS<string, int>(this.r);
			while (lyh.MPP())
			{
				int num2 = this.r.m((string)lyh.MPX());
				if (num2 <= 1)
				{
					num++;
				}
				else
				{
					num += 2;
				}
			}
			return num;
		}

		// Token: 0x04008E95 RID: 36501
		private readonly lmr<gPr> P;

		// Token: 0x04008E96 RID: 36502
		private readonly lmD<string, int> W;

		// Token: 0x04008E97 RID: 36503
		private readonly lmD<string, int> r;
	}
}
