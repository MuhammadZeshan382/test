using System;

namespace Arc264y
{
	// Token: 0x020014BA RID: 5306
	internal sealed class gPr
	{
		// Token: 0x060134CD RID: 79053 RVA: 0x0007C7B2 File Offset: 0x0007A9B2
		internal gPr(string string_0, Evv evv_0, string string_1, string string_2, bool bool_0)
		{
			this.p = string_0;
			this.e = evv_0;
			this.S = string_1;
			this.g = string_2;
			this.U = bool_0;
		}

		// Token: 0x060134CE RID: 79054 RVA: 0x0076FB50 File Offset: 0x0076DD50
		internal string i()
		{
			return this.p;
		}

		// Token: 0x060134CF RID: 79055 RVA: 0x0076FB68 File Offset: 0x0076DD68
		internal Evv c()
		{
			return this.e;
		}

		// Token: 0x060134D0 RID: 79056 RVA: 0x0076FB80 File Offset: 0x0076DD80
		internal string W()
		{
			return this.S;
		}

		// Token: 0x060134D1 RID: 79057 RVA: 0x0076FB98 File Offset: 0x0076DD98
		internal string t()
		{
			return this.g;
		}

		// Token: 0x060134D2 RID: 79058 RVA: 0x0076FBB0 File Offset: 0x0076DDB0
		internal bool A()
		{
			return this.e == Evv.x;
		}

		// Token: 0x060134D3 RID: 79059 RVA: 0x0076FBC8 File Offset: 0x0076DDC8
		internal bool m()
		{
			return this.U;
		}

		// Token: 0x04008E33 RID: 36403
		private readonly string p;

		// Token: 0x04008E34 RID: 36404
		private readonly Evv e;

		// Token: 0x04008E35 RID: 36405
		private readonly string S;

		// Token: 0x04008E36 RID: 36406
		private readonly string g;

		// Token: 0x04008E37 RID: 36407
		private readonly bool U;
	}
}
