using System;
using RSSBus;

namespace Arc264y
{
	// Token: 0x02000E1F RID: 3615
	public class rrv
	{
		// Token: 0x0600F773 RID: 63347 RVA: 0x0006ED87 File Offset: 0x0006CF87
		public static void A(RSBContext rsbcontext_0)
		{
			rrv.B(rsbcontext_0, false);
		}

		// Token: 0x0600F774 RID: 63348 RVA: 0x005ED920 File Offset: 0x005EBB20
		public static void B(RSBContext rsbcontext_0, bool bool_0)
		{
			try
			{
				if (!bool_0)
				{
					rsbcontext_0.CallAsync("appGetAzureInstanceIdentityDoc", null, new rrJ());
				}
				else
				{
					rsbcontext_0.Call("appGetAzureInstanceIdentityDoc", null, new rrJ());
				}
			}
			catch (Exception ex)
			{
				rga.Fu("application", "rssbus.lic").kQ(null, ex, "GetInstanceIdentityDoc");
			}
		}

		// Token: 0x0600F775 RID: 63349 RVA: 0x005ED988 File Offset: 0x005EBB88
		public static void Q(string string_0)
		{
			if (!Eyf.UK(string_0, "cdata_arc_starter", true))
			{
				if (!Eyf.UK(string_0, "cdata_arc_standard", true))
				{
					if (!Eyf.UK(string_0, "cdata_arc_professional", true))
					{
						if (!Eyf.UK(string_0, "cdata_arc_enterprise", true))
						{
							if (!Eyf.UK(string_0, "cdata_arc_free_as2", true))
							{
								rrv.t = -1;
							}
							else
							{
								rrv.t = 0;
							}
						}
						else
						{
							rrv.t = 100;
						}
					}
					else
					{
						rrv.t = 25;
					}
				}
				else
				{
					rrv.t = 10;
				}
			}
			else
			{
				rrv.t = 1;
			}
			rrv.w = Eyf.hK(rrv.h, "cdatasoftware") && rrv.t != -1;
		}

		// Token: 0x0600F776 RID: 63350 RVA: 0x005EDA40 File Offset: 0x005EBC40
		public static int L()
		{
			return rrv.t;
		}

		// Token: 0x0600F777 RID: 63351 RVA: 0x001E8D70 File Offset: 0x001E6F70
		public static int u()
		{
			return -1;
		}

		// Token: 0x0600F778 RID: 63352 RVA: 0x001E8D70 File Offset: 0x001E6F70
		public static int m()
		{
			return -1;
		}

		// Token: 0x0600F779 RID: 63353 RVA: 0x001E8D70 File Offset: 0x001E6F70
		public static int G()
		{
			return -1;
		}

		// Token: 0x0600F77A RID: 63354 RVA: 0x001E8D70 File Offset: 0x001E6F70
		public static int W()
		{
			return -1;
		}

		// Token: 0x0600F77B RID: 63355 RVA: 0x005EDA54 File Offset: 0x005EBC54
		public static int n()
		{
			if (rrv.t != 100)
			{
				if (rrv.t != 25)
				{
					if (rrv.t != 10)
					{
						if (rrv.t == 0)
						{
							rrv.K = 2;
						}
					}
					else
					{
						rrv.K = 5;
					}
				}
				else
				{
					rrv.K = 10;
				}
			}
			else
			{
				rrv.K = 20;
			}
			return rrv.K;
		}

		// Token: 0x0600F77C RID: 63356 RVA: 0x005EDAC4 File Offset: 0x005EBCC4
		public static int V()
		{
			return 999;
		}

		// Token: 0x04006896 RID: 26774
		public const string E = "cdatasoftware";

		// Token: 0x04006897 RID: 26775
		private const string U = "cdata_arc_free_as2";

		// Token: 0x04006898 RID: 26776
		private const string i = "cdata_arc_starter";

		// Token: 0x04006899 RID: 26777
		private const string v = "cdata_arc_standard";

		// Token: 0x0400689A RID: 26778
		private const string M = "cdata_arc_professional";

		// Token: 0x0400689B RID: 26779
		private const string S = "cdata_arc_enterprise";

		// Token: 0x0400689C RID: 26780
		public static string f = "";

		// Token: 0x0400689D RID: 26781
		public static string o = "";

		// Token: 0x0400689E RID: 26782
		public static string D = "";

		// Token: 0x0400689F RID: 26783
		public static string h = "";

		// Token: 0x040068A0 RID: 26784
		public static bool w = false;

		// Token: 0x040068A1 RID: 26785
		public static string x = "";

		// Token: 0x040068A2 RID: 26786
		public static int K = 0;

		// Token: 0x040068A3 RID: 26787
		public static int t = -1;
	}
}
