using System;

namespace Arc264y
{
	// Token: 0x020014BC RID: 5308
	public class gPg
	{
		// Token: 0x060134D5 RID: 79061 RVA: 0x0007C7DF File Offset: 0x0007A9DF
		internal gPg(string string_0, int int_0, int int_1, int int_2, bool bool_0)
		{
			this.Y = string_0;
			this.e = int_0;
			this.p = int_1;
			this.D = int_2;
			this.N = bool_0;
		}

		// Token: 0x060134D6 RID: 79062 RVA: 0x0076FBDC File Offset: 0x0076DDDC
		public string i()
		{
			return this.Y;
		}

		// Token: 0x060134D7 RID: 79063 RVA: 0x0076FBF4 File Offset: 0x0076DDF4
		public int G()
		{
			return this.e;
		}

		// Token: 0x060134D8 RID: 79064 RVA: 0x0076FC0C File Offset: 0x0076DE0C
		public int V()
		{
			return this.p;
		}

		// Token: 0x060134D9 RID: 79065 RVA: 0x0076FC24 File Offset: 0x0076DE24
		public int E()
		{
			return this.D;
		}

		// Token: 0x060134DA RID: 79066 RVA: 0x0076FC3C File Offset: 0x0076DE3C
		public bool H()
		{
			return this.N;
		}

		// Token: 0x04008E7D RID: 36477
		public const string K = "MFT";

		// Token: 0x04008E7E RID: 36478
		public const string r = "EDI";

		// Token: 0x04008E7F RID: 36479
		public const string j = "Database";

		// Token: 0x04008E80 RID: 36480
		public const string b = "Other";

		// Token: 0x04008E81 RID: 36481
		public const string L = "Ports";

		// Token: 0x04008E82 RID: 36482
		private readonly string Y;

		// Token: 0x04008E83 RID: 36483
		private readonly int e;

		// Token: 0x04008E84 RID: 36484
		private readonly int p;

		// Token: 0x04008E85 RID: 36485
		private readonly int D;

		// Token: 0x04008E86 RID: 36486
		private readonly bool N;
	}
}
