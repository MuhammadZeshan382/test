using System;
using RSSBus;

namespace Arc264y
{
	// Token: 0x02000E19 RID: 3609
	public class rrc
	{
		// Token: 0x0600F73C RID: 63292 RVA: 0x005ED14C File Offset: 0x005EB34C
		public static void O(rri rri_0, RSBContext rsbcontext_0)
		{
			lock (rrc.j)
			{
				rrc.t = rri_0;
				rrc.t.FJz(rsbcontext_0);
			}
		}

		// Token: 0x0600F73D RID: 63293 RVA: 0x005ED19C File Offset: 0x005EB39C
		public static bool s()
		{
			return rrc.W.t();
		}

		// Token: 0x0600F73E RID: 63294 RVA: 0x005ED1B4 File Offset: 0x005EB3B4
		public static bool x()
		{
			return rrc.W.s();
		}

		// Token: 0x0600F73F RID: 63295 RVA: 0x005ED1CC File Offset: 0x005EB3CC
		public static bool f()
		{
			return rrc.W.x();
		}

		// Token: 0x0600F740 RID: 63296 RVA: 0x005ED1E4 File Offset: 0x005EB3E4
		public static int B()
		{
			return rrc.W.y();
		}

		// Token: 0x0600F741 RID: 63297 RVA: 0x005ED200 File Offset: 0x005EB400
		public static bool r()
		{
			return rrc.W.r();
		}

		// Token: 0x0600F742 RID: 63298 RVA: 0x005ED218 File Offset: 0x005EB418
		public static bool m()
		{
			return rrc.W.m();
		}

		// Token: 0x0600F743 RID: 63299 RVA: 0x005ED230 File Offset: 0x005EB430
		public static bool p()
		{
			return rrc.W.n();
		}

		// Token: 0x0600F744 RID: 63300 RVA: 0x005ED248 File Offset: 0x005EB448
		public static bool Q()
		{
			return rrc.W.E();
		}

		// Token: 0x0600F745 RID: 63301 RVA: 0x005ED260 File Offset: 0x005EB460
		public static bool E()
		{
			return rrc.W.G();
		}

		// Token: 0x0600F746 RID: 63302 RVA: 0x005ED278 File Offset: 0x005EB478
		public static bool V()
		{
			return rrc.W.wt();
		}

		// Token: 0x0600F747 RID: 63303 RVA: 0x005ED290 File Offset: 0x005EB490
		public static bool K()
		{
			return rrc.W.ws();
		}

		// Token: 0x0600F748 RID: 63304 RVA: 0x005ED2A8 File Offset: 0x005EB4A8
		public static bool G()
		{
			return rrc.W.wy();
		}

		// Token: 0x0600F749 RID: 63305 RVA: 0x005ED2C0 File Offset: 0x005EB4C0
		public static bool D()
		{
			return rrc.W.wf();
		}

		// Token: 0x0600F74A RID: 63306 RVA: 0x005ED2D8 File Offset: 0x005EB4D8
		public static bool sO(rrQ rrQ_0)
		{
			return rrc.W.It(rrQ_0);
		}

		// Token: 0x0600F74B RID: 63307 RVA: 0x005ED2F0 File Offset: 0x005EB4F0
		public static string[] ss()
		{
			return rrc.W.Is();
		}

		// Token: 0x0600F74C RID: 63308 RVA: 0x005ED30C File Offset: 0x005EB50C
		public static string sx()
		{
			return rrc.W.wr();
		}

		// Token: 0x0600F74D RID: 63309 RVA: 0x005ED328 File Offset: 0x005EB528
		public static string sT()
		{
			return rrc.W.wV();
		}

		// Token: 0x0600F74E RID: 63310 RVA: 0x005ED344 File Offset: 0x005EB544
		public static string sf(string string_0)
		{
			return rrc.W.wu(string_0);
		}

		// Token: 0x0600F74F RID: 63311 RVA: 0x005ED360 File Offset: 0x005EB560
		public static bool sh(string string_0, bool bool_0)
		{
			return rrc.W.wx(string_0, bool_0);
		}

		// Token: 0x0600F750 RID: 63312 RVA: 0x005ED37C File Offset: 0x005EB57C
		public static int sC(string string_0, int int_0)
		{
			return rrc.W.wn(string_0, int_0);
		}

		// Token: 0x0600F751 RID: 63313 RVA: 0x005ED398 File Offset: 0x005EB598
		public static int sB()
		{
			return rrc.W.wE();
		}

		// Token: 0x0600F752 RID: 63314 RVA: 0x005ED3B4 File Offset: 0x005EB5B4
		public static void sr(int int_0)
		{
			lock (rrc.j)
			{
				rrc.W.Iy(int_0);
			}
		}

		// Token: 0x0600F753 RID: 63315 RVA: 0x005ED3FC File Offset: 0x005EB5FC
		public static void sm(string string_0)
		{
			lock (rrc.j)
			{
				rrc.W.If(string_0);
			}
		}

		// Token: 0x0600F754 RID: 63316 RVA: 0x005ED444 File Offset: 0x005EB644
		public static void sp(bool bool_0)
		{
			lock (rrc.j)
			{
				rrc.W.Ir(bool_0);
			}
		}

		// Token: 0x0600F755 RID: 63317 RVA: 0x005ED48C File Offset: 0x005EB68C
		public static void sQ(bool bool_0)
		{
			lock (rrc.j)
			{
				rrc.W.IV(bool_0);
			}
		}

		// Token: 0x0600F756 RID: 63318 RVA: 0x005ED4D4 File Offset: 0x005EB6D4
		public static void sY(bool bool_0)
		{
			lock (rrc.j)
			{
				rrc.W.Im(bool_0);
			}
		}

		// Token: 0x0600F757 RID: 63319 RVA: 0x005ED51C File Offset: 0x005EB71C
		public static void sl(bool bool_0)
		{
			lock (rrc.j)
			{
				rrc.W.Iu(bool_0);
			}
		}

		// Token: 0x0600F758 RID: 63320 RVA: 0x005ED564 File Offset: 0x005EB764
		public static void sE(bool bool_0)
		{
			lock (rrc.j)
			{
				rrc.W.Ix(bool_0);
			}
		}

		// Token: 0x0600F759 RID: 63321 RVA: 0x005ED5AC File Offset: 0x005EB7AC
		public static void sa(int int_0)
		{
			lock (rrc.j)
			{
				rrc.W.In(int_0);
			}
		}

		// Token: 0x0600F75A RID: 63322 RVA: 0x005ED5F4 File Offset: 0x005EB7F4
		public static void sV(string string_0)
		{
			lock (rrc.j)
			{
				rrc.W.IE(string_0);
			}
		}

		// Token: 0x0600F75B RID: 63323 RVA: 0x005ED63C File Offset: 0x005EB83C
		public static void sK(string string_0, string string_1)
		{
			lock (rrc.j)
			{
				rrc.W.tC(string_0, string_1);
			}
		}

		// Token: 0x0600F75C RID: 63324 RVA: 0x005ED684 File Offset: 0x005EB884
		public static void sj(string[] string_0)
		{
			lock (rrc.j)
			{
				rrc.W.tw(string_0);
			}
		}

		// Token: 0x0600F75D RID: 63325 RVA: 0x005ED6CC File Offset: 0x005EB8CC
		public static void sU(object[] object_0)
		{
			if (rrc.t == null)
			{
				throw new RSBException("CheckLicense", "License handler must be set.");
			}
			rrc.t.FbC(object_0);
		}

		// Token: 0x04006886 RID: 26758
		private static object j = new object();

		// Token: 0x04006887 RID: 26759
		private static rri t = null;

		// Token: 0x04006888 RID: 26760
		private static rro W = new rro();
	}
}
