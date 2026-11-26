using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using RSSBus;

namespace Arc264y
{
	// Token: 0x020014BE RID: 5310
	internal sealed class gPm
	{
		// Token: 0x060134E0 RID: 79072 RVA: 0x0007C82A File Offset: 0x0007AA2A
		internal gPm(string string_0, bool bool_0)
		{
			this.p = string_0;
			this.C = bool_0;
		}

		// Token: 0x060134E1 RID: 79073 RVA: 0x0076FD44 File Offset: 0x0076DF44
		internal static bool E(string string_0)
		{
			return "|eancom|edifact|hl7|iatapadis|tradacoms|x12|".Contains("|" + Eyf.Dx(string_0) + "|");
		}

		// Token: 0x060134E2 RID: 79074 RVA: 0x0076FD70 File Offset: 0x0076DF70
		internal static bool i(Evv evv_0, string string_0)
		{
			return evv_0 != Evv.x && gPm.E(string_0) && guo.bu(string_0, false) == 20;
		}

		// Token: 0x060134E3 RID: 79075 RVA: 0x0076FD9C File Offset: 0x0076DF9C
		internal void x()
		{
			lock (this)
			{
				this.U = null;
			}
		}

		// Token: 0x060134E4 RID: 79076 RVA: 0x0076FDDC File Offset: 0x0076DFDC
		internal lmr<gPr> u(bool bool_0)
		{
			if (!bool_0)
			{
				lmr<gPr> lmr = this.c();
				if (lmr != null)
				{
					return lmr;
				}
			}
			ENw enw = ENo.y(ENs.j());
			lmr<string> lmr2 = enw.Fdq(Evv.u);
			lmr<string> lmr3 = new lmr<string>();
			lmr<gPr> lmr4 = new lmr<gPr>();
			using (lmg<string> lmg = lmr2.O())
			{
				while (lmg.MoveNext())
				{
					string text = lmg.Current;
					if (enw.FdN(text))
					{
						ENo eno = enw.Fdw(text, Evv.u);
						Evv evv = eno.W();
						ENE ene = enw.Fdk(eno);
						try
						{
							lmr<string> lmr5 = ene.FYh();
							lmr3.r(lmr5);
							using (lmg<string> lmg2 = lmr5.O())
							{
								while (lmg2.MoveNext())
								{
									string text2 = lmg2.Current;
									try
									{
										if (!this.C || ene.FYM(text2))
										{
											string text3 = ene.FYo(text2);
											bool flag = false;
											if (gPm.i(evv, text3))
											{
												flag = ene.FYU(text2).y().s("DynamicallyProcessPartners");
											}
											lmr4.Add(new gPr(text, evv, text2, text3, flag));
										}
									}
									catch (Exception)
									{
									}
								}
							}
						}
						finally
						{
							ene.FYe();
						}
					}
				}
			}
			lock (this)
			{
				this.U = new lmr<gPr>();
				this.U.r(lmr4);
				this.h = lyc.G() + 10000L;
				this.D = gPm.j(lmr2);
				this.l = gPm.j(lmr3);
			}
			return lmr4;
		}

		// Token: 0x060134E5 RID: 79077 RVA: 0x0076FFE4 File Offset: 0x0076E1E4
		private lmr<gPr> c()
		{
			lmr<gPr> lmr4;
			lock (this)
			{
				if (this.U != null)
				{
					lmr<gPr> lmr = new lmr<gPr>();
					if (this.h <= lyc.G())
					{
						if (this.D != null && this.l != null)
						{
							if (lyc.G() - this.h < 86400000L)
							{
								ENw enw = ENo.y(ENs.j());
								lmr<string> lmr2 = enw.Fdq(Evv.u);
								if (Eyf.hr(this.D, gPm.j(lmr2)))
								{
									lmr<string> lmr3 = new lmr<string>();
									using (lmg<string> lmg = lmr2.O())
									{
										while (lmg.MoveNext())
										{
											string text = lmg.Current;
											if (enw.FdN(text))
											{
												ENo eno = enw.Fdw(text, Evv.u);
												ENE ene = enw.Fdk(eno);
												try
												{
													lmr3.r(ene.FYh());
												}
												finally
												{
													ene.FYe();
												}
											}
										}
									}
									if (Eyf.hr(this.l, gPm.j(lmr3)))
									{
										this.h = lyc.G() + 10000L;
										lmr.r(this.U);
										lmr4 = lmr;
									}
									else
									{
										lmr4 = null;
									}
								}
								else
								{
									lmr4 = null;
								}
							}
							else
							{
								lmr4 = null;
							}
						}
						else
						{
							lmr4 = null;
						}
					}
					else
					{
						lmr.r(this.U);
						lmr4 = lmr;
					}
				}
				else
				{
					lmr4 = null;
				}
			}
			return lmr4;
		}

		// Token: 0x060134E6 RID: 79078 RVA: 0x007701BC File Offset: 0x0076E3BC
		internal lmD<string, int> y(bool bool_0)
		{
			lmD<string, int> lmD = new lmD<string, int>();
			lmD<string, int> lmD2;
			if (!Eyf.lx(this.p))
			{
				lmr<string> lmr = Eyf.Ox(Eyf.xD(this.p, true, '|', false, true));
				if (lmr.G() > 0)
				{
					lock (gPm.J)
					{
						if (bool_0 || gPm.V < lyc.G())
						{
							try
							{
								EoN eoN = null;
								try
								{
									eoN = EoJ.PV(new Eoa(giw.Ab(), EQB.OH()));
									gPm.Y = new lmD<string, int>();
									using (lmg<string> lmg = lmr.O())
									{
										while (lmg.MoveNext())
										{
											string text = lmg.Current;
											gPm.Y.H(Eyf.Dx(text), eoN.obX(text).G());
										}
									}
								}
								finally
								{
									if (eoN != null)
									{
										eoN.obY();
									}
								}
							}
							catch (RSBException ex)
							{
								rga.Fu("application", "arc.core.lic").kQ(Eyf.OS("License internal error: {0}", Eyf.eD(ex)), ex, "CalcConnectionCount");
							}
							gPm.V = lyc.G() + 10000L;
						}
						lyh lyh = Eyf.AS<string, int>(gPm.Y);
						while (lyh.MPP())
						{
							string text = (string)lyh.MPX();
							lmD.H(text, gPm.Y.m(text));
						}
					}
					lmD2 = lmD;
				}
				else
				{
					lmD2 = lmD;
				}
			}
			else
			{
				lmD2 = lmD;
			}
			return lmD2;
		}

		// Token: 0x060134E7 RID: 79079 RVA: 0x007703B4 File Offset: 0x0076E5B4
		internal static lmD<string, int> f()
		{
			lmD<string, int> lmD = new lmD<string, int>();
			lmr<EsJ> lmr = EsN.t().V().c();
			using (lmg<EsJ> lmg = lmr.O())
			{
				while (lmg.MoveNext())
				{
					EsJ esJ = lmg.Current;
					if (esJ.olU())
					{
						if (!lmD.ContainsKey(esJ.j()))
						{
							lmD.H(esJ.j(), 1);
						}
						else
						{
							lmD.H(esJ.j(), lmD.m(esJ.j()) + 1);
						}
					}
				}
			}
			return lmD;
		}

		// Token: 0x060134E8 RID: 79080 RVA: 0x00770460 File Offset: 0x0076E660
		private static string j(lmr<string> lmr_0)
		{
			if (lmr_0 != null)
			{
				if (gPm.m == null)
				{
					gPm.m = new Comparison<string>(gPm.n);
				}
				Eyf.Or<string>(lmr_0, Comparer<string>.Create(gPm.m));
				try
				{
					lcc lcc = new lcc();
					using (lmg<string> lmg = lmr_0.O())
					{
						while (lmg.MoveNext())
						{
							string text = lmg.Current;
							if (text != null)
							{
								lcc.MPI(text).MPI("|");
							}
						}
					}
					return Eyf.nx(Eyf.OV("SHA-256", Eyf.IV(lcc.ToString())), true);
				}
				catch (Exception)
				{
					return null;
				}
			}
			return null;
		}

		// Token: 0x060134E9 RID: 79081 RVA: 0x006F629C File Offset: 0x006F449C
		[CompilerGenerated]
		private static int n(string string_0, string string_1)
		{
			return string_0.CompareTo(string_1);
		}

		// Token: 0x04008E89 RID: 36489
		private const string B = "|eancom|edifact|hl7|iatapadis|tradacoms|x12|";

		// Token: 0x04008E8A RID: 36490
		private static object J = new object();

		// Token: 0x04008E8B RID: 36491
		private static lmD<string, int> Y = new lmD<string, int>();

		// Token: 0x04008E8C RID: 36492
		private static long V = 0L;

		// Token: 0x04008E8D RID: 36493
		private readonly string p;

		// Token: 0x04008E8E RID: 36494
		private readonly bool C;

		// Token: 0x04008E8F RID: 36495
		private lmr<gPr> U = null;

		// Token: 0x04008E90 RID: 36496
		private long h = 0L;

		// Token: 0x04008E91 RID: 36497
		private string D = null;

		// Token: 0x04008E92 RID: 36498
		private string l = null;

		// Token: 0x04008E93 RID: 36499
		[CompilerGenerated]
		private static Comparison<string> m;
	}
}
