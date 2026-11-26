using System;

namespace Arc264y
{
	// Token: 0x02000E23 RID: 3619
	internal sealed class rrs : PZh
	{
		// Token: 0x0600F792 RID: 63378 RVA: 0x0006EDAF File Offset: 0x0006CFAF
		public rrs(string string_0)
			: base(null, new object())
		{
			this.h = string_0;
			this.JXe(1);
			this.HN(0L);
		}

		// Token: 0x0600F793 RID: 63379 RVA: 0x005EE318 File Offset: 0x005EC518
		public override void YX(string string_0, bool[] bool_0)
		{
			if (!Eyf.lx(string_0))
			{
				int num = string_0.IndexOf("://");
				if (num >= 0)
				{
					bool_0[0] = Eyf.UK(lcP.IG(string_0, num + 3), this.h, true);
				}
			}
		}

		// Token: 0x040068A6 RID: 26790
		private string h = null;
	}
}
