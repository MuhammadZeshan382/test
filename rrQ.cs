using System;

namespace Arc264y
{
	// Token: 0x02000E24 RID: 3620
	public class rrQ
	{
		// Token: 0x0600F794 RID: 63380 RVA: 0x0006EDE1 File Offset: 0x0006CFE1
		public rrQ(string string_0, int int_0)
		{
			Eyf.FO(string_0, "flag", new object[0]);
			this.K = Eyf.Dn(string_0);
			this.t = int_0;
		}

		// Token: 0x0600F795 RID: 63381 RVA: 0x005EE360 File Offset: 0x005EC560
		public string W()
		{
			return this.K;
		}

		// Token: 0x0600F796 RID: 63382 RVA: 0x005EE378 File Offset: 0x005EC578
		public int s()
		{
			return this.t;
		}

		// Token: 0x040068A7 RID: 26791
		private readonly string K;

		// Token: 0x040068A8 RID: 26792
		private readonly int t;
	}
}
