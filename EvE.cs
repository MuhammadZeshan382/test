using System;

namespace Arc264y
{
	// Token: 0x02001286 RID: 4742
	public class EvE
	{
		// Token: 0x060122B6 RID: 74422 RVA: 0x00078AA1 File Offset: 0x00076CA1
		internal EvE(string string_0, EJv ejv_0)
		{
			lZh.B(string_0, "Type", new object[0]);
			this.a = string_0;
			this.F = ejv_0;
		}

		// Token: 0x060122B7 RID: 74423 RVA: 0x006F92C4 File Offset: 0x006F74C4
		public string O()
		{
			return this.a;
		}

		// Token: 0x060122B8 RID: 74424 RVA: 0x006F92DC File Offset: 0x006F74DC
		public EJv s()
		{
			return this.F;
		}

		// Token: 0x060122B9 RID: 74425 RVA: 0x006F92F4 File Offset: 0x006F74F4
		public static Evu V()
		{
			if (EvE.C == null)
			{
				lock (EvE.i)
				{
					if (EvE.C == null)
					{
						EvE.C = new EvE.Hw();
					}
				}
			}
			return EvE.C;
		}

		// Token: 0x060122BA RID: 74426 RVA: 0x006F935C File Offset: 0x006F755C
		public static EvD m()
		{
			return new Evg(EvE.V());
		}

		// Token: 0x060122BB RID: 74427 RVA: 0x006F9378 File Offset: 0x006F7578
		public static EvD B(Evu evu_0)
		{
			return new Evg(evu_0);
		}

		// Token: 0x0400814D RID: 33101
		private readonly string a;

		// Token: 0x0400814E RID: 33102
		private readonly EJv F;

		// Token: 0x0400814F RID: 33103
		private static object i = new object();

		// Token: 0x04008150 RID: 33104
		private static Evu C = null;

		// Token: 0x02001287 RID: 4743
		private sealed class Hw : Evu
		{
			// Token: 0x060122BD RID: 74429 RVA: 0x006F9390 File Offset: 0x006F7590
			public Hw()
			{
				try
				{
					this.a = ENa.W(giw.p(), "Default", Evv.q);
				}
				catch (lwZ lwZ)
				{
					throw new ENP("DefaultMgrInfo", Eyf.eD(lwZ), lwZ, new object[0]);
				}
			}

			// Token: 0x060122BE RID: 74430 RVA: 0x006F93E4 File Offset: 0x006F75E4
			public string FRh()
			{
				return this.a;
			}

			// Token: 0x060122BF RID: 74431 RVA: 0x006F267C File Offset: 0x006F087C
			public rDr FRg()
			{
				return giw.Ti();
			}

			// Token: 0x04008151 RID: 33105
			private readonly string a;
		}
	}
}
