using System;

namespace Arc264y
{
	// Token: 0x020014BF RID: 5311
	public class gPc
	{
		// Token: 0x060134EB RID: 79083 RVA: 0x0007C888 File Offset: 0x0007AA88
		internal void u(gPg gPg_0)
		{
			this.p.Add(gPg_0);
		}

		// Token: 0x060134EC RID: 79084 RVA: 0x00770538 File Offset: 0x0076E738
		public lmr<gPg> W()
		{
			lmr<gPg> lmr = new lmr<gPg>();
			lmr.r(this.p);
			return lmr;
		}

		// Token: 0x060134ED RID: 79085 RVA: 0x0077055C File Offset: 0x0076E75C
		public gPg f(string string_0)
		{
			using (lmg<gPg> lmg = this.p.O())
			{
				while (lmg.MoveNext())
				{
					gPg gPg = lmg.Current;
					if (Eyf.hK(gPg.i(), string_0))
					{
						return gPg;
					}
				}
			}
			return null;
		}

		// Token: 0x060134EE RID: 79086 RVA: 0x007705C0 File Offset: 0x0076E7C0
		public bool L()
		{
			using (lmg<gPg> lmg = this.p.O())
			{
				while (lmg.MoveNext())
				{
					gPg gPg = lmg.Current;
					if (gPg.H())
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x04008E94 RID: 36500
		private readonly lmr<gPg> p = new lmr<gPg>();
	}
}
