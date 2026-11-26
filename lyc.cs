using System;

namespace Arc264y
{
	// Token: 0x02000B1E RID: 2846
	internal sealed class lyc
	{
		// Token: 0x0600DE68 RID: 56936 RVA: 0x003B6670 File Offset: 0x003B4870
		internal static long G()
		{
			return (DateTime.UtcNow.Ticks - 621355968000000000L) / 10000L;
		}

		// Token: 0x0600DE69 RID: 56937 RVA: 0x0004819A File Offset: 0x0004639A
		internal static void E(Array array_0, int int_0, Array array_1, int int_1, int int_2)
		{
			Array.Copy(array_0, int_0, array_1, int_1, int_2);
		}
	}
}
