using System;
using System.Collections.Generic;

namespace Arc264y
{
	// Token: 0x02000E25 RID: 3621
	public class rro
	{
		// Token: 0x0600F797 RID: 63383 RVA: 0x005EE390 File Offset: 0x005EC590
		public bool t()
		{
			return this.M;
		}

		// Token: 0x0600F798 RID: 63384 RVA: 0x005EE3A4 File Offset: 0x005EC5A4
		public bool s()
		{
			return this.Q;
		}

		// Token: 0x0600F799 RID: 63385 RVA: 0x005EE3B8 File Offset: 0x005EC5B8
		public int y()
		{
			return this.K;
		}

		// Token: 0x0600F79A RID: 63386 RVA: 0x005EE3D0 File Offset: 0x005EC5D0
		public bool r()
		{
			return this.g;
		}

		// Token: 0x0600F79B RID: 63387 RVA: 0x005EE3E4 File Offset: 0x005EC5E4
		public bool m()
		{
			return this.j;
		}

		// Token: 0x0600F79C RID: 63388 RVA: 0x005EE3F8 File Offset: 0x005EC5F8
		public bool x()
		{
			return this.O;
		}

		// Token: 0x0600F79D RID: 63389 RVA: 0x005EE40C File Offset: 0x005EC60C
		public bool n()
		{
			return this.N == 0;
		}

		// Token: 0x0600F79E RID: 63390 RVA: 0x005EE424 File Offset: 0x005EC624
		public bool E()
		{
			return this.N > -1;
		}

		// Token: 0x0600F79F RID: 63391 RVA: 0x005EE43C File Offset: 0x005EC63C
		public bool G()
		{
			return this.N >= 1;
		}

		// Token: 0x0600F7A0 RID: 63392 RVA: 0x005EE458 File Offset: 0x005EC658
		public bool wt()
		{
			return this.N >= 10;
		}

		// Token: 0x0600F7A1 RID: 63393 RVA: 0x005EE474 File Offset: 0x005EC674
		public bool ws()
		{
			return this.N >= 25;
		}

		// Token: 0x0600F7A2 RID: 63394 RVA: 0x005EE490 File Offset: 0x005EC690
		public bool wy()
		{
			return this.N >= 100;
		}

		// Token: 0x0600F7A3 RID: 63395 RVA: 0x005EE4AC File Offset: 0x005EC6AC
		public bool wf()
		{
			return this.N >= 999;
		}

		// Token: 0x0600F7A4 RID: 63396 RVA: 0x005EE4CC File Offset: 0x005EC6CC
		public string wr()
		{
			string text;
			if (!this.wf())
			{
				if (!this.wy())
				{
					if (!this.ws())
					{
						if (!this.wt())
						{
							if (!this.G())
							{
								if (!this.n())
								{
									text = "No valid license";
								}
								else
								{
									text = "Free";
								}
							}
							else
							{
								text = "Starter";
							}
						}
						else
						{
							text = "Standard";
						}
					}
					else
					{
						text = "Professional";
					}
				}
				else
				{
					text = "Enterprise";
				}
			}
			else
			{
				text = "Unlimited";
			}
			return text;
		}

		// Token: 0x0600F7A5 RID: 63397 RVA: 0x005EE554 File Offset: 0x005EC754
		public string wV()
		{
			return (!Eyf.lx(this.H)) ? this.H : "[NO-VALID-LICENSE]";
		}

		// Token: 0x0600F7A6 RID: 63398 RVA: 0x005EE580 File Offset: 0x005EC780
		public string wm()
		{
			return this.e;
		}

		// Token: 0x0600F7A7 RID: 63399 RVA: 0x005EE598 File Offset: 0x005EC798
		public string wu(string string_0)
		{
			if (!Eyf.lx(string_0))
			{
				string_0 = Eyf.Dn(string_0);
				if (this.X.ContainsKey(string_0))
				{
					return this.X.m(string_0);
				}
			}
			return null;
		}

		// Token: 0x0600F7A8 RID: 63400 RVA: 0x005EE5DC File Offset: 0x005EC7DC
		public bool wx(string string_0, bool bool_0)
		{
			return Eyf.CZ(this.wu(string_0), bool_0);
		}

		// Token: 0x0600F7A9 RID: 63401 RVA: 0x005EE5F8 File Offset: 0x005EC7F8
		public int wn(string string_0, int int_0)
		{
			int num;
			try
			{
				num = Eyf.CF(this.wu(string_0), int_0);
			}
			catch (Exception)
			{
				num = int_0;
			}
			return num;
		}

		// Token: 0x0600F7AA RID: 63402 RVA: 0x005EE62C File Offset: 0x005EC82C
		public int wE()
		{
			return this.N;
		}

		// Token: 0x0600F7AB RID: 63403 RVA: 0x005EE644 File Offset: 0x005EC844
		private bool wG(string string_0)
		{
			return !Eyf.lx(string_0) && this.w.Contains(Eyf.Dn(string_0));
		}

		// Token: 0x0600F7AC RID: 63404 RVA: 0x005EE674 File Offset: 0x005EC874
		public bool It(rrQ rrQ_0)
		{
			return rrQ_0 != null && this.E() && (this.N >= rrQ_0.s() || this.wG(rrQ_0.W()));
		}

		// Token: 0x0600F7AD RID: 63405 RVA: 0x005EE6BC File Offset: 0x005EC8BC
		public string[] Is()
		{
			HashSet<string> hashSet = this.w;
			string[] array = new string[hashSet.Count];
			int num = 0;
			foreach (string text in hashSet)
			{
				array[num++] = text;
			}
			return array;
		}

		// Token: 0x0600F7AE RID: 63406 RVA: 0x0006EE0D File Offset: 0x0006D00D
		public void Iy(int int_0)
		{
			this.N = int_0;
		}

		// Token: 0x0600F7AF RID: 63407 RVA: 0x005EE728 File Offset: 0x005EC928
		public void If(string string_0)
		{
			int num = -1;
			if (!Eyf.hK(string_0, "Unlimited"))
			{
				if (!Eyf.hK(string_0, "Enterprise"))
				{
					if (!Eyf.hK(string_0, "Professional"))
					{
						if (!Eyf.hK(string_0, "Standard"))
						{
							if (!Eyf.hK(string_0, "Starter") && !Eyf.hK(string_0, "Express"))
							{
								if (Eyf.hK(string_0, "Free"))
								{
									num = 0;
								}
							}
							else
							{
								num = 1;
							}
						}
						else
						{
							num = 10;
						}
					}
					else
					{
						num = 25;
					}
				}
				else
				{
					num = 100;
				}
			}
			else
			{
				num = 999;
			}
			this.Iy(num);
		}

		// Token: 0x0600F7B0 RID: 63408 RVA: 0x0006EE16 File Offset: 0x0006D016
		public void Ir(bool bool_0)
		{
			this.j = bool_0;
		}

		// Token: 0x0600F7B1 RID: 63409 RVA: 0x0006EE1F File Offset: 0x0006D01F
		public void IV(bool bool_0)
		{
			this.M = bool_0;
		}

		// Token: 0x0600F7B2 RID: 63410 RVA: 0x0006EE28 File Offset: 0x0006D028
		public void Im(bool bool_0)
		{
			this.Q = bool_0;
		}

		// Token: 0x0600F7B3 RID: 63411 RVA: 0x0006EE31 File Offset: 0x0006D031
		public void Iu(bool bool_0)
		{
			this.O = bool_0;
		}

		// Token: 0x0600F7B4 RID: 63412 RVA: 0x0006EE3A File Offset: 0x0006D03A
		public void Ix(bool bool_0)
		{
			this.g = bool_0;
		}

		// Token: 0x0600F7B5 RID: 63413 RVA: 0x0006EE43 File Offset: 0x0006D043
		public void In(int int_0)
		{
			this.K = int_0;
		}

		// Token: 0x0600F7B6 RID: 63414 RVA: 0x0006EE4C File Offset: 0x0006D04C
		public void IE(string string_0)
		{
			this.H = string_0;
		}

		// Token: 0x0600F7B7 RID: 63415 RVA: 0x0006EE55 File Offset: 0x0006D055
		public void IG(string string_0)
		{
			this.e = string_0;
		}

		// Token: 0x0600F7B8 RID: 63416 RVA: 0x005EE7D0 File Offset: 0x005EC9D0
		public void tC(string string_0, string string_1)
		{
			if (!Eyf.lx(string_0))
			{
				string_0 = Eyf.Dn(string_0);
				if (string_1 != null)
				{
					this.X.H(string_0, string_1);
				}
				else if (this.X.ContainsKey(string_0))
				{
					this.X.E(string_0);
				}
			}
		}

		// Token: 0x0600F7B9 RID: 63417 RVA: 0x005EE82C File Offset: 0x005ECA2C
		public void tw(string[] string_0)
		{
			HashSet<string> hashSet = new HashSet<string>();
			if (string_0 != null)
			{
				foreach (string text in string_0)
				{
					if (!Eyf.lx(text))
					{
						hashSet.Add(Eyf.Dn(text));
					}
				}
			}
			this.w = hashSet;
		}

		// Token: 0x0600F7BA RID: 63418 RVA: 0x005EE880 File Offset: 0x005ECA80
		public void tI(rro rro_0)
		{
			this.j = rro_0.j;
			this.g = rro_0.g;
			this.M = rro_0.M;
			this.Q = rro_0.Q;
			this.K = rro_0.K;
			this.H = rro_0.H;
			this.e = rro_0.e;
			lyh lyh = Eyf.Aq<string, string>(rro_0.X);
			while (lyh.MPP())
			{
				string text = (string)lyh.MPX();
				this.X.H(text, rro_0.wu(text));
			}
			this.tw(rro_0.Is());
		}

		// Token: 0x040068A9 RID: 26793
		public const int u = -1;

		// Token: 0x040068AA RID: 26794
		public const int T = 0;

		// Token: 0x040068AB RID: 26795
		public const int V = 1;

		// Token: 0x040068AC RID: 26796
		public const int P = 10;

		// Token: 0x040068AD RID: 26797
		public const int f = 25;

		// Token: 0x040068AE RID: 26798
		public const int C = 100;

		// Token: 0x040068AF RID: 26799
		public const int i = 999;

		// Token: 0x040068B0 RID: 26800
		private bool j = false;

		// Token: 0x040068B1 RID: 26801
		private bool g = false;

		// Token: 0x040068B2 RID: 26802
		private bool M = false;

		// Token: 0x040068B3 RID: 26803
		private bool Q = false;

		// Token: 0x040068B4 RID: 26804
		private bool O = false;

		// Token: 0x040068B5 RID: 26805
		private int K = 0;

		// Token: 0x040068B6 RID: 26806
		private string H = "";

		// Token: 0x040068B7 RID: 26807
		private string e = "";

		// Token: 0x040068B8 RID: 26808
		private lmD<string, string> X = new lmD<string, string>();

		// Token: 0x040068B9 RID: 26809
		private HashSet<string> w = new HashSet<string>();

		// Token: 0x040068BA RID: 26810
		private int N = -1;
	}
}
