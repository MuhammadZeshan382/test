using System;

namespace Arc264y
{
	// Token: 0x0200124B RID: 4683
	public class ENP : lwZ
	{
		// Token: 0x06012176 RID: 74102 RVA: 0x00078547 File Offset: 0x00076747
		public ENP(string string_0, string string_1, params object[] object_0)
			: base(string_0, string_1, object_0)
		{
		}

		// Token: 0x06012177 RID: 74103 RVA: 0x00078559 File Offset: 0x00076759
		public ENP(END end_0, string string_0, string string_1, params object[] object_0)
			: base(string_0, string_1, object_0)
		{
			this.I = end_0;
		}

		// Token: 0x06012178 RID: 74104 RVA: 0x00078573 File Offset: 0x00076773
		public ENP(string string_0, string string_1, Exception exception_0, params object[] object_0)
			: base(string_0, string_1, exception_0, object_0)
		{
		}

		// Token: 0x06012179 RID: 74105 RVA: 0x00078587 File Offset: 0x00076787
		public ENP(END end_0, string string_0, string string_1, Exception exception_0, params object[] object_0)
			: base(string_0, string_1, exception_0, object_0)
		{
			this.I = end_0;
		}

		// Token: 0x040080B4 RID: 32948
		private END I = null;
	}
}
