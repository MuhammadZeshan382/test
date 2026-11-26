using System;

namespace Arc264y
{
	// Token: 0x020014BD RID: 5309
	public class gPy
	{
		// Token: 0x060134DB RID: 79067 RVA: 0x0076FC50 File Offset: 0x0076DE50
		public void m(string string_0, Evv evv_0, string string_1, string string_2, bool bool_0)
		{
			Eyf.FO(string_0, "WorkspaceId", new object[0]);
			Eyf.FO(string_1, "ConnectorId", new object[0]);
			Eyf.FO(string_2, "ConnectorType", new object[0]);
			bool flag = bool_0 && gPm.i(evv_0, string_2);
			this.P.Add(new gPr(string_0, evv_0, string_1, string_2, flag));
		}

		// Token: 0x060134DC RID: 79068 RVA: 0x0076FCB8 File Offset: 0x0076DEB8
		public void s(string string_0, int int_0)
		{
			Eyf.FO(string_0, "ConnectorType", new object[0]);
			if (int_0 > 0)
			{
				string text = Eyf.Dx(string_0);
				int num = ((!this.G.ContainsKey(text)) ? 0 : this.G.m(text));
				this.G.H(text, num + int_0);
			}
		}

		// Token: 0x060134DD RID: 79069 RVA: 0x0076FD14 File Offset: 0x0076DF14
		internal lmr<gPr> E()
		{
			return this.P;
		}

		// Token: 0x060134DE RID: 79070 RVA: 0x0076FD2C File Offset: 0x0076DF2C
		internal lmD<string, int> H()
		{
			return this.G;
		}

		// Token: 0x04008E87 RID: 36487
		private readonly lmr<gPr> P = new lmr<gPr>();

		// Token: 0x04008E88 RID: 36488
		private readonly lmD<string, int> G = new lmD<string, int>();
	}
}
