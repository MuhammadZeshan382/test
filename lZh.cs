using System;
using System.Collections;
using System.IO;
using RSSBus;

namespace Arc264y
{
	// Token: 0x02000D91 RID: 3473
	internal class lZh
	{
		// Token: 0x0600F3AB RID: 62379 RVA: 0x005D8AD8 File Offset: 0x005D6CD8
		private static string D(int int_0)
		{
			string text;
			switch (int_0)
			{
			case 0:
				text = "init";
				break;
			case 1:
				text = "starting";
				break;
			case 2:
				text = "started";
				break;
			case 3:
				text = "stopped";
				break;
			case 4:
				text = "stopping";
				break;
			default:
				text = "unknown";
				break;
			}
			return text;
		}

		// Token: 0x0600F3AC RID: 62380 RVA: 0x005D8B34 File Offset: 0x005D6D34
		private static void r(int int_0, int int_1, int[] int_2)
		{
			lcc lcc = new lcc();
			if (int_2 != null && int_2.Length > 0)
			{
				foreach (int num in int_2)
				{
					if (int_1 == num)
					{
						return;
					}
					lcc.MPI(lZh.D(num)).MPI(", ");
				}
			}
			else
			{
				lcc.MPI("N/A, ");
			}
			throw new RSBException("AppState", string.Concat(new string[]
			{
				"Current state is ",
				lZh.D(int_0),
				", expected state(s): ",
				lcc.ToString(),
				"but it is ",
				lZh.D(int_1),
				"."
			}));
		}

		// Token: 0x0600F3AD RID: 62381 RVA: 0x005D8C00 File Offset: 0x005D6E00
		public static bool E(int int_0)
		{
			return lZh.J == int_0;
		}

		// Token: 0x0600F3AE RID: 62382 RVA: 0x005D8C18 File Offset: 0x005D6E18
		public static bool c()
		{
			return lZh.J < 2;
		}

		// Token: 0x0600F3AF RID: 62383 RVA: 0x005D8C30 File Offset: 0x005D6E30
		public static bool f()
		{
			return lZh.J == 4 || lZh.J == 3;
		}

		// Token: 0x0600F3B0 RID: 62384 RVA: 0x005D8C54 File Offset: 0x005D6E54
		public static void i(int int_0)
		{
			lock (lZh.m)
			{
				switch (lZh.J)
				{
				case 0:
					lZh.J = int_0;
					break;
				case 1:
					lZh.r(lZh.J, int_0, new int[] { 2 });
					lZh.J = int_0;
					break;
				case 2:
					lZh.r(lZh.J, int_0, new int[] { 4, 3 });
					lZh.J = int_0;
					break;
				case 3:
					if (lZh.e)
					{
						lZh.r(lZh.J, int_0, new int[] { 1, 3 });
					}
					else
					{
						lZh.r(lZh.J, int_0, new int[0]);
					}
					lZh.J = int_0;
					break;
				case 4:
					lZh.r(lZh.J, int_0, new int[] { 3 });
					lZh.J = int_0;
					break;
				default:
					throw new RSBException("AppState", "Unknown state value: " + int_0 + ".");
				}
			}
		}

		// Token: 0x0600F3B1 RID: 62385 RVA: 0x0006E175 File Offset: 0x0006C375
		public static void Q(object object_0, string string_0, params object[] object_1)
		{
			Eyf.Fn<object>(object_0, string_0, object_1);
		}

		// Token: 0x0600F3B2 RID: 62386 RVA: 0x0006E17F File Offset: 0x0006C37F
		public static void B(string string_0, string string_1, params object[] object_0)
		{
			Eyf.FO(string_0, string_1, object_0);
		}

		// Token: 0x0600F3B3 RID: 62387 RVA: 0x000FBD30 File Offset: 0x000F9F30
		public static bool Z()
		{
			return true;
		}

		// Token: 0x0600F3B4 RID: 62388 RVA: 0x005D8D7C File Offset: 0x005D6F7C
		public static void uD(string string_0)
		{
			if (null != string_0)
			{
				lfv.f("currentWorkspace", string_0);
			}
			else
			{
				lfv.D("currentWorkspace");
			}
		}

		// Token: 0x0600F3B5 RID: 62389 RVA: 0x005D8DAC File Offset: 0x005D6FAC
		public static string uu()
		{
			return (string)lfv.m("currentWorkspace");
		}

		// Token: 0x0600F3B6 RID: 62390 RVA: 0x005D8DCC File Offset: 0x005D6FCC
		public static void uP(string string_0)
		{
			if (null != string_0)
			{
				lfv.f("currentResource", string_0);
			}
			else
			{
				lfv.D("currentResource");
			}
		}

		// Token: 0x0600F3B7 RID: 62391 RVA: 0x005D8DFC File Offset: 0x005D6FFC
		public static string ul()
		{
			return (string)lfv.m("currentResource");
		}

		// Token: 0x0600F3B8 RID: 62392 RVA: 0x0006E189 File Offset: 0x0006C389
		public static void ur()
		{
			lfv.D("currentResource");
		}

		// Token: 0x0600F3B9 RID: 62393 RVA: 0x005D8E1C File Offset: 0x005D701C
		public static void uE(RSBContext rsbcontext_0)
		{
			if (rsbcontext_0 is lNE)
			{
				lJN lJN = ((lNE)rsbcontext_0).j();
				string text = ((lJN.H.L != null) ? lJN.H.L : "");
				lfv.f("currentOperation", text);
			}
		}

		// Token: 0x0600F3BA RID: 62394 RVA: 0x005D8E70 File Offset: 0x005D7070
		public static void ug(string string_0)
		{
			if (null != string_0)
			{
				lfv.f("currentOperation", string_0);
			}
			else
			{
				lfv.D("currentOperation");
			}
		}

		// Token: 0x0600F3BB RID: 62395 RVA: 0x005D8EA0 File Offset: 0x005D70A0
		public static string uy()
		{
			return (string)lfv.m("currentOperation");
		}

		// Token: 0x0600F3BC RID: 62396 RVA: 0x005D8EC0 File Offset: 0x005D70C0
		public static void um(string string_0)
		{
			if (null != string_0)
			{
				lfv.f("currentModule", string_0);
			}
			else
			{
				lfv.D("currentModule");
			}
		}

		// Token: 0x0600F3BD RID: 62397 RVA: 0x005D8EF0 File Offset: 0x005D70F0
		public static string uc()
		{
			return (string)lfv.m("currentModule");
		}

		// Token: 0x0600F3BE RID: 62398 RVA: 0x005D8F10 File Offset: 0x005D7110
		public static string uX(Exception exception_0)
		{
			string text;
			if (exception_0 == null)
			{
				text = null;
			}
			else
			{
				lcc lcc = new lcc();
				lcc.MPI("Stack Trace: ").MPI(Eyf.u).MPI(Eyf.em(exception_0));
				while (exception_0.InnerException != null)
				{
					exception_0 = exception_0.InnerException;
					string text2 = exception_0.Message;
					if (exception_0 is RSBException)
					{
						text2 = "[" + ((RSBException)exception_0).GetCode() + "] " + text2;
					}
					lcc.MPI(Eyf.u).MPI("Inner Exception: " + text2);
					lcc.MPI(Eyf.u).MPI("Inner Stack Trace: ");
					lcc.MPI(Eyf.u).MPI(Eyf.em(exception_0));
				}
				text = lcc.ToString();
			}
			return text;
		}

		// Token: 0x0600F3BF RID: 62399 RVA: 0x005D8FF4 File Offset: 0x005D71F4
		public static bool uf(string string_0)
		{
			return Eyf.hK(EEJ.FH(), string_0);
		}

		// Token: 0x0600F3C0 RID: 62400 RVA: 0x005D900C File Offset: 0x005D720C
		public static bool ua(string string_0)
		{
			bool flag;
			if (!Eyf.lx(string_0) && !".".Equals(string_0) && !"..".Equals(string_0))
			{
				char[] array = lZh.uN();
				foreach (char c in array)
				{
					if (string_0.IndexOf(c) >= 0)
					{
						return false;
					}
				}
				flag = true;
			}
			else
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x0600F3C1 RID: 62401 RVA: 0x005D9080 File Offset: 0x005D7280
		public static char[] uN()
		{
			return Path.GetInvalidFileNameChars();
		}

		// Token: 0x0600F3C2 RID: 62402 RVA: 0x005D9098 File Offset: 0x005D7298
		public static string uv(string string_0)
		{
			return lZh.uJ(string_0, lZh.uN());
		}

		// Token: 0x0600F3C3 RID: 62403 RVA: 0x005D90B4 File Offset: 0x005D72B4
		public static string uJ(string string_0, char[] char_0)
		{
			foreach (char c in char_0)
			{
				string_0 = string_0.Replace(c, '_');
			}
			return string_0;
		}

		// Token: 0x0600F3C4 RID: 62404 RVA: 0x0006E195 File Offset: 0x0006C395
		public static void ui(RSBContext rsbcontext_0, string string_0, string string_1)
		{
			lZh.uh(rsbcontext_0, null, null, string_0, string_1, null);
		}

		// Token: 0x0600F3C5 RID: 62405 RVA: 0x005D90E8 File Offset: 0x005D72E8
		public static void uh(RSBContext rsbcontext_0, string string_0, string string_1, string string_2, string string_3, lmD<string, string> lmD_0)
		{
			try
			{
				if (!lZh.e)
				{
					if (Eyf.CZ(string_0, true))
					{
						RSBItem rsbitem = rsbcontext_0.CreateItem();
						rsbitem.SetAttr("notifyemail", string_0);
						rsbitem.SetAttr("to", string_1);
						rsbitem.SetAttr("subject", string_2);
						rsbitem.SetAttr("message", string_3);
						if (lmD_0 != null && lmD_0.A() > 0)
						{
							lyh lyh = Eyf.AS<string, string>(lmD_0);
							while (lyh.MPP())
							{
								string text = (string)lyh.MPX();
								rsbitem.SetAttr(text, lmD_0.m(text));
							}
						}
						rsbcontext_0.Call("appNotify", rsbitem);
					}
				}
				else
				{
					lZh.v.Add(new string[]
					{
						string_3,
						string_0,
						string_1,
						string_2,
						Eyf.KB(lmD_0, ';', '=')
					});
				}
			}
			catch (RSBException ex)
			{
				rga.Fu("application", "rssbus.core").kQ("An attempt was made to notify the administrator via email that has failed:", ex, "Notify");
			}
		}

		// Token: 0x0600F3C6 RID: 62406 RVA: 0x005D920C File Offset: 0x005D740C
		public static string us()
		{
			return rii.sP();
		}

		// Token: 0x0600F3C7 RID: 62407 RVA: 0x005D9220 File Offset: 0x005D7420
		public static string[] uQ(string string_0)
		{
			string[] array = new string[] { "01", "00" };
			if (!Eyf.lx(string_0))
			{
				int num = string_0.IndexOf(':');
				if (num > -1 && string_0.Length > num + 1)
				{
					int num2 = Eyf.CF(lcP.IZ(string_0, 0, num), 1);
					int num3 = Eyf.CF(lcP.IG(string_0, num + 1), 0);
					if (num2 >= 0 && num2 <= 23)
					{
						array[0] = string.Concat(num2);
					}
					if (num3 >= 0 && num3 <= 59)
					{
						array[1] = string.Concat(num3);
					}
				}
			}
			return array;
		}

		// Token: 0x0600F3C8 RID: 62408 RVA: 0x005D92D4 File Offset: 0x005D74D4
		public static bool uo(int int_0)
		{
			return int_0 > 0 && EEJ.FW() == int_0;
		}

		// Token: 0x0600F3C9 RID: 62409 RVA: 0x005D92F8 File Offset: 0x005D74F8
		public static bool uB(int int_0)
		{
			return int_0 > 0 && EEJ.FW() != int_0;
		}

		// Token: 0x0600F3CA RID: 62410 RVA: 0x005D931C File Offset: 0x005D751C
		public static bool uw(int int_0)
		{
			return int_0 > 0 && EEJ.FW() < int_0;
		}

		// Token: 0x0600F3CB RID: 62411 RVA: 0x005D9340 File Offset: 0x005D7540
		public static bool ut(int int_0)
		{
			return int_0 > 0 && EEJ.FW() <= int_0;
		}

		// Token: 0x0600F3CC RID: 62412 RVA: 0x005D9364 File Offset: 0x005D7564
		public static bool uk(int int_0)
		{
			return int_0 > 0 && EEJ.FW() > int_0;
		}

		// Token: 0x0600F3CD RID: 62413 RVA: 0x005D9388 File Offset: 0x005D7588
		public static bool uZ(int int_0)
		{
			return int_0 > 0 && EEJ.FW() >= int_0;
		}

		// Token: 0x0600F3CE RID: 62414 RVA: 0x005D93AC File Offset: 0x005D75AC
		public static RSBContext PD(RSBContext rsbcontext_0)
		{
			return lZh.Pu(rsbcontext_0, null);
		}

		// Token: 0x0600F3CF RID: 62415 RVA: 0x005D93C4 File Offset: 0x005D75C4
		public static RSBContext Pu(RSBContext rsbcontext_0, string string_0)
		{
			return lZh.Pr(rsbcontext_0, string_0, null);
		}

		// Token: 0x0600F3D0 RID: 62416 RVA: 0x005D93DC File Offset: 0x005D75DC
		public static RSBContext Pr(RSBContext rsbcontext_0, string string_0, RSBItem rsbitem_0)
		{
			return lZh.PE(rsbcontext_0, string_0, rsbitem_0, rsbcontext_0.GetMetaItem());
		}

		// Token: 0x0600F3D1 RID: 62417 RVA: 0x005D93FC File Offset: 0x005D75FC
		public static RSBContext PE(RSBContext rsbcontext_0, string string_0, RSBItem rsbitem_0, RSBItem rsbitem_1)
		{
			return lZh.Py(rsbcontext_0, string_0, rsbitem_0, rsbcontext_0.GetMetaItem(), null);
		}

		// Token: 0x0600F3D2 RID: 62418 RVA: 0x005D941C File Offset: 0x005D761C
		public static RSBContext Py(RSBContext rsbcontext_0, string string_0, RSBItem rsbitem_0, RSBItem rsbitem_1, RSBKnownOperations rsbknownOperations_0)
		{
			RSBContext rsbcontext;
			if (rsbcontext_0 == null)
			{
				rsbcontext = null;
			}
			else
			{
				try
				{
					lJN lJN = ((lNE)rsbcontext_0).j();
					lJN lJN2;
					if (rsbknownOperations_0 != null)
					{
						lJN2 = lJN.WY(new liZ(null), null, null, ((lJo)rsbitem_1).H(), rsbknownOperations_0);
					}
					else
					{
						lJN2 = lJN.WC(new liZ(null), null, null, ((lJo)rsbitem_1).H());
					}
					lJN2.H.QN = lJN.H.QN;
					lJN2.H.Qa = lJN.H.Qa;
					lJN2.H.L = ((string_0 != null) ? string_0 : lJN.H.L);
					for (int i = 0; i < lJN.H.p.W(); i++)
					{
						string text = (string)lJN.H.p.K(i);
						lvE lvE = (lvE)lJN.tv().G(text);
						if (null != lvE)
						{
							lJN2.Eb(text, lvE);
						}
					}
					if (rsbitem_0 != null)
					{
						lJN2.Wx(((lJo)rsbitem_0).H());
					}
					rsbcontext = new lNE(lJN2);
				}
				catch (Exception ex)
				{
					throw new lwZ("NewCleanContext", Eyf.eD(ex), ex, new object[0]);
				}
			}
			return rsbcontext;
		}

		// Token: 0x0600F3D3 RID: 62419 RVA: 0x005D958C File Offset: 0x005D778C
		public static void Pm(RSBContext rsbcontext_0, string string_0)
		{
			if (rsbcontext_0 != null)
			{
				lJN lJN = ((lNE)rsbcontext_0).j();
				lJN.H.L = string_0;
			}
		}

		// Token: 0x0600F3D4 RID: 62420 RVA: 0x005D95B8 File Offset: 0x005D77B8
		public static void Pc(RSBEngine rsbengine_0, string string_0)
		{
			if (!Eyf.lx(string_0) && null != rsbengine_0)
			{
				int num = 0;
				RSBBasicItem[] array;
				if (!Eyf.hK(string_0, "as2") && !Eyf.hK(string_0, "as4") && !Eyf.hK(string_0, "rnif") && !Eyf.hK(string_0, "webhook"))
				{
					array = new RSBBasicItem[10];
					array[num++] = new lZh.ky("_httpheaders");
				}
				else
				{
					array = new RSBBasicItem[9];
				}
				array[num++] = new lZh.ky("_request");
				array[num++] = new lZh.ky("_response");
				array[num++] = new lZh.ky("_cookies");
				array[num++] = new lZh.ky("_session");
				array[num++] = new lZh.ky("_about");
				array[num++] = new lZh.ky("_context");
				array[num++] = new lZh.ky("_profile");
				array[num++] = new lZh.ky("_rsb");
				array[num++] = new lZh.ky("_settings");
				rsbengine_0.SetSpecialItems(array);
			}
		}

		// Token: 0x0600F3D5 RID: 62421 RVA: 0x005D96F8 File Offset: 0x005D78F8
		public static string Pf()
		{
			return lZs.t();
		}

		// Token: 0x0600F3D6 RID: 62422 RVA: 0x005D970C File Offset: 0x005D790C
		public static void Pi(string string_0, lcX lcX_0)
		{
			lvZ lvZ = lhh.MTg();
			lJu lJu = null;
			if (!lZh.e)
			{
				goto IL_00DD;
			}
			try
			{
				IL_0012:
				if (lcX_0 == null)
				{
					lJu.Mev(404);
					lJu.MeX("Not Found.");
				}
				else
				{
					lJu.MeF("Pragma", "no-cache");
					lJu.MeF("Connection", "close");
					lJu.MeF("Content-Type", "application/force-download; charset=utf-8");
					lJu.MeF("Content-Disposition", "attachment; filename=\"" + Eyf.xx(string_0, "\"") + "\"; filename*=UTF-8''" + Eyf.OC(Eyf.lO(string_0), "+", "%20"));
					byte[] array = new byte[8192];
					int num;
					while ((num = lcX_0.i(array, 0, array.Length)) > 0)
					{
						lJu.Meq(array, 0, num);
					}
				}
				return;
			}
			catch (IOException ex)
			{
				throw new RSBException("DownloadLogs", Eyf.eD(ex), ex);
			}
			IL_00DD:
			if (lvZ == null)
			{
				throw new RSBException("DownloadFile", "Cannot get HTTP Context.");
			}
			lJu = lvZ.MNe();
			if (lJu == null)
			{
				throw new RSBException("DownloadFile", "Cannot get HTTP Response.");
			}
			goto IL_0012;
		}

		// Token: 0x0600F3D7 RID: 62423 RVA: 0x005D9844 File Offset: 0x005D7A44
		public static void Ps(string string_0, byte[] byte_0)
		{
			lvZ lvZ = lhh.MTg();
			lJu lJu = null;
			if (!lZh.e)
			{
				goto IL_00BA;
			}
			try
			{
				IL_0012:
				if (byte_0 == null)
				{
					lJu.Mev(404);
					lJu.MeX("Not Found.");
				}
				else
				{
					lJu.MeF("Pragma", "no-cache");
					lJu.MeF("Connection", "close");
					lJu.MeF("Content-Type", "application/force-download; charset=utf-8");
					lJu.MeF("Content-Disposition", "attachment; filename=\"" + Eyf.xx(string_0, "\"") + "\"; filename*=UTF-8''" + Eyf.OC(Eyf.lO(string_0), "+", "%20"));
					lJu.Meq(byte_0, 0, byte_0.Length);
				}
				return;
			}
			catch (IOException ex)
			{
				throw new RSBException("DownloadLogs", Eyf.eD(ex), ex);
			}
			IL_00BA:
			if (lvZ == null)
			{
				throw new RSBException("DownloadFile", "Cannot get HTTP Context.");
			}
			lJu = lvZ.MNe();
			if (lJu == null)
			{
				throw new RSBException("DownloadFile", "Cannot get HTTP Response.");
			}
			goto IL_0012;
		}

		// Token: 0x0600F3D8 RID: 62424 RVA: 0x005D9958 File Offset: 0x005D7B58
		internal static string PQ(string string_0, params object[] object_0)
		{
			return Eyf.IB(string_0, true, object_0);
		}

		// Token: 0x040065DD RID: 26077
		public const int s = 0;

		// Token: 0x040065DE RID: 26078
		public const int w = 1;

		// Token: 0x040065DF RID: 26079
		public const int u = 2;

		// Token: 0x040065E0 RID: 26080
		public const int t = 3;

		// Token: 0x040065E1 RID: 26081
		public const int O = 4;

		// Token: 0x040065E2 RID: 26082
		public const string A = "#DAILY_TASK";

		// Token: 0x040065E3 RID: 26083
		public const string P = "#SU.";

		// Token: 0x040065E4 RID: 26084
		public const string n = "#HC.";

		// Token: 0x040065E5 RID: 26085
		public const string C = "#VCS_GIT";

		// Token: 0x040065E6 RID: 26086
		public const string y = "#VCS_GIT_CONFIG";

		// Token: 0x040065E7 RID: 26087
		public const string G = "#ARCHIVE_TASK_";

		// Token: 0x040065E8 RID: 26088
		public const string d = "#MODIFY_AUDITS_LOG";

		// Token: 0x040065E9 RID: 26089
		private static object m = new object();

		// Token: 0x040065EA RID: 26090
		private static int J = 0;

		// Token: 0x040065EB RID: 26091
		public static bool e = false;

		// Token: 0x040065EC RID: 26092
		public static lmr<string[]> v = new lmr<string[]>();

		// Token: 0x02000D92 RID: 3474
		private sealed class ky : RSBBasicItem
		{
			// Token: 0x0600F3DB RID: 62427 RVA: 0x0006E1C4 File Offset: 0x0006C3C4
			public ky(string string_0)
			{
				this.J = string_0;
			}

			// Token: 0x0600F3DC RID: 62428 RVA: 0x005D9970 File Offset: 0x005D7B70
			public string GetName()
			{
				return this.J;
			}

			// Token: 0x0600F3DD RID: 62429 RVA: 0x005D9988 File Offset: 0x005D7B88
			public ArrayList GetAttr(string name)
			{
				throw new lwZ("InternalItem", "Item {0} is inaccessible.", new object[] { name });
			}

			// Token: 0x0600F3DE RID: 62430 RVA: 0x005D9988 File Offset: 0x005D7B88
			public string SetAttr(string name, string value)
			{
				throw new lwZ("InternalItem", "Item {0} is inaccessible.", new object[] { name });
			}

			// Token: 0x0600F3DF RID: 62431 RVA: 0x0006E1DA File Offset: 0x0006C3DA
			public string[] ListAttrs()
			{
				throw new Exception(Eyf.OS("Item {0} is inaccessible.", this.J));
			}

			// Token: 0x040065ED RID: 26093
			private string J = null;
		}
	}
}
