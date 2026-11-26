using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Web;
using RSSBus;

namespace Arc264y
{
	// Token: 0x020014B0 RID: 5296
	internal sealed class guo : gui, guh
	{
		// Token: 0x06013419 RID: 78873 RVA: 0x0007C53F File Offset: 0x0007A73F
		public void ovl(RSBContext rsbcontext_0)
		{
			this.b = lZh.Pu(rsbcontext_0, "ArcCNLicenseHandler");
		}

		// Token: 0x0601341A RID: 78874 RVA: 0x0076A2F8 File Offset: 0x007684F8
		public void ovb(RSBContext rsbcontext_0, bool bool_0, bool bool_1)
		{
			lyv<guB> lyv = null;
			string input = rsbcontext_0.GetInput("case");
			if (!Eyf.lx(input))
			{
				lyv = guo.SL(input);
			}
			else
			{
				lyv = this.hi((!bool_0) ? "*" : null);
			}
			RSBException ex = null;
			for (int i = 0; i < lyv.W(); i++)
			{
				guB guB = lyv.j(i);
				rsbcontext_0.SetOutput("name", guB.D());
				rsbcontext_0.SetOutput("prod", guB.E());
				rsbcontext_0.SetOutput("displayname", guB.Z());
				rsbcontext_0.SetOutput("version", guB.nA());
				rsbcontext_0.SetOutput("serialnumber", guB.wV());
				rsbcontext_0.SetOutput("isbeta", Eyf.Dw(guB.r()));
				rsbcontext_0.SetOutput("issub", Eyf.Dw(guB.t()));
				rsbcontext_0.SetOutput("iscloud", Eyf.Dw(guB.s()));
				rsbcontext_0.SetOutput("istrial", Eyf.Dw(guB.m()));
				rsbcontext_0.SetOutput("expiredays", Eyf.Dt(guB.y()));
				rsbcontext_0.SetOutput("licensetype", Eyf.DF(guB.wr()));
				if (guB.nu() != null)
				{
					rsbcontext_0.SetOutput("error", Eyf.eD(guB.nu()));
				}
				if (!Eyf.lx(guB.nM()))
				{
					rsbcontext_0.SetOutput("warning", guB.nM());
				}
				if (Eyf.hK(guB.D(), "Arc"))
				{
					rsbcontext_0.SetOutput("isapp", "true");
					string text = "noLicenseInfo";
					if (!guB.p())
					{
						goto IL_047D;
					}
					bool flag = false;
					IL_0217:
					rsbcontext_0.SetOutput(text, Eyf.Dw(flag));
					rsbcontext_0.SetOutput("isfree", Eyf.Dw(guB.nn()));
					rsbcontext_0.SetOutput("isfixed", Eyf.Dw(giw.wr("license")));
					rsbcontext_0.SetOutput("ismftonly", Eyf.Dw(guB.iE()));
					rsbcontext_0.SetOutput("maxmftconnectors", Eyf.Dt(guB.np()));
					rsbcontext_0.SetOutput("maxediconnectors", Eyf.Dt(guB.nf()));
					rsbcontext_0.SetOutput("maxdatabaseconnectors", Eyf.Dt(guB.nw()));
					rsbcontext_0.SetOutput("maxotherconnectors", Eyf.Dt(guB.nD()));
					rsbcontext_0.SetOutput("limittype", Eyf.Dt(guB.nT()));
					rsbcontext_0.SetOutput("expiringtype", Eyf.Dt(guB.nX()));
					rsbcontext_0.SetOutput("allowtrialactivate", Eyf.Dw(gui.bE()));
					rsbcontext_0.SetOutput("mftconnectorscount", Eyf.Dt(guB.nK()));
					rsbcontext_0.SetOutput("ediconnectorscount", Eyf.Dt(guB.nS()));
					rsbcontext_0.SetOutput("databaseconnectorscount", Eyf.Dt(guB.nZ()));
					rsbcontext_0.SetOutput("otherconnectorscount", Eyf.Dt(guB.@in()));
					rsbcontext_0.SetOutput("createdconnectortypes", guB.ij());
					rsbcontext_0.SetOutput("isas2only", Eyf.Dw(guB.iq()));
					rsbcontext_0.SetOutput("licensefeatures", guQ.r(guB));
					if (guB.nu() != null)
					{
						ex = guB.nu();
					}
					lock (guo.g)
					{
						lyh lyh = Eyf.AS<string, lyv<guB>>(guo.q);
						bool flag3 = true;
						while (flag3 && lyh.MPP())
						{
							lyv<guB> lyv2 = guo.q.m((string)lyh.MPX());
							foreach (object obj2 in lyv2)
							{
								guB guB2 = (guB)obj2;
								if ((guB.nu() == null) ^ (guB2.nu() == null))
								{
									flag3 = false;
									break;
								}
							}
						}
						if (!flag3)
						{
							guo.q.Clear();
						}
						goto IL_018D;
					}
					IL_047D:
					flag = Eyf.lx(guB.iL()) || !Ecg.MG(guB.iL());
					goto IL_0217;
				}
				rsbcontext_0.SetOutput("isapp", "false");
				rsbcontext_0.SetOutput("allowtrialactivate", Eyf.Dw((Eyf.lx(guB.iL()) || !Ecg.MG(guB.iL())) && !guB.p()));
				IL_018D:
				rsbcontext_0.PushItem();
			}
			if (!bool_1 && ex != null)
			{
				throw ex;
			}
		}

		// Token: 0x0601341B RID: 78875 RVA: 0x0076A7FC File Offset: 0x007689FC
		public string ovM()
		{
			Egl egl = new Egl();
			egl.Q();
			lyv<guB> lyv = this.hi("*");
			guB guB = null;
			foreach (object obj in lyv)
			{
				guB guB2 = (guB)obj;
				if (Eyf.hK(guB2.D(), "Arc"))
				{
					guB = guB2;
					lock (guo.g)
					{
						lyh lyh = Eyf.AS<string, lyv<guB>>(guo.q);
						bool flag2 = true;
						while (flag2 && lyh.MPP())
						{
							lyv<guB> lyv2 = guo.q.m((string)lyh.MPX());
							foreach (object obj3 in lyv2)
							{
								guB guB3 = (guB)obj3;
								if ((guB2.nu() == null) ^ (guB3.nu() == null))
								{
									flag2 = false;
									break;
								}
							}
						}
						if (!flag2)
						{
							guo.q.Clear();
						}
					}
					break;
				}
			}
			if (guB != null && (guB.p() || (!Eyf.lx(guB.iL()) && Ecg.MG(guB.iL()))))
			{
				egl.H("noLicenseInfo", "false", false);
				guo.SE(egl, guB);
				egl.H("isfree", Eyf.Dx(Eyf.Dw(guB.nn())), false);
				egl.H("isfixed", Eyf.Dx(Eyf.Dw(giw.wr("license"))), false);
				egl.H("isas2only", Eyf.Dx(Eyf.Dw(guB.iq())), false);
				egl.H("ismftonly", Eyf.Dx(Eyf.Dw(guB.iE())), false);
				egl.H("allowtrialactivate", Eyf.Dx(Eyf.Dw(gui.bE())), false);
				egl.t("limittype", Eyf.Dt(guB.nT()));
				egl.t("expiringtype", Eyf.Dt(guB.nX()));
				egl.t("nodeId", lXu.mz());
				if (guB.iY())
				{
					egl.H("sftpEnabled", "true", false);
				}
				egl.G("enterpriseFeatures").i();
				bool flag3 = true;
				bool flag4 = rrc.K() || (rrc.V() && rrc.sh("IS_LEGACY_LICENSE", false));
				bool flag5 = rrc.G();
				egl.Q().t("name", "Certificate Management Console").H("enabled", Eyf.Dx(Eyf.Dw(flag3)), false)
					.f();
				egl.Q().t("name", "Admin API / Flow API").H("enabled", Eyf.Dx(Eyf.Dw(flag4)), false)
					.f();
				egl.Q().t("name", "Parallel Processing").H("enabled", Eyf.Dx(Eyf.Dw(flag4)), false)
					.f();
				egl.Q().t("name", "Enterprise Reporting Features").H("enabled", Eyf.Dx(Eyf.Dw(flag5)), false)
					.f();
				egl.Q().t("name", "Multi-User / Role-Based Access Controls").H("enabled", Eyf.Dx(Eyf.Dw(flag5)), false)
					.f();
				egl.Q().t("name", "Active Directory / Single Sign-on Integration").H("enabled", Eyf.Dx(Eyf.Dw(flag5)), false)
					.f();
				egl.Q().t("name", "External Vault Providers").H("enabled", Eyf.Dx(Eyf.Dw(rrc.sO(guQ.Q))), false)
					.f();
				egl.A();
				egl.G("connectors").i();
				egl.Q().t("name", "Core").t("displayName", "Core Connector Instances")
					.H("count", Eyf.DO(guB.ip()), false)
					.H("total", "999", false)
					.f();
				egl.Q().t("name", "MFT").t("displayName", "MFT Partners")
					.H("count", Eyf.DO(guB.nK()), false)
					.H("total", Eyf.DO(guB.np()), false)
					.f();
				egl.Q().t("name", "EDI").t("displayName", "EDI Partners")
					.H("count", Eyf.DO(guB.nS()), false)
					.H("total", Eyf.DO(guB.nf()), false)
					.f();
				egl.Q().t("name", "Database").t("displayName", "Database Connectors")
					.H("count", Eyf.DO(guB.nZ()), false)
					.H("total", Eyf.DO(guB.nw()), false)
					.f();
				lmr<string> lmr = new lmr<string>();
				if (!Eyf.lx(rrc.sf("CREATED_BETA_CONNECTOR_TYPES")))
				{
					lmr = Eyf.Ox(Eyf.xl(Eyf.Dx(rrc.sf("CREATED_BETA_CONNECTOR_TYPES")), true, new char[] { ',', '|' }, true, true));
				}
				if (lmr.G() > 0)
				{
					egl.Q().t("name", "Beta").t("displayName", "Beta Connectors")
						.G("licenses")
						.i();
					foreach (object obj4 in lyv)
					{
						guB guB2 = (guB)obj4;
						if (guB2 != guB && lmr.Contains(Eyf.Dx(guB2.D())))
						{
							egl.Q();
							guo.SE(egl, guB2);
							egl.f();
						}
					}
					egl.A().f();
				}
				lmr<string> lmr2 = new lmr<string>();
				if (!Eyf.lx(rrc.sf("INCLUDED_CONNECTORS")))
				{
					lmr2 = Eyf.Ox(Eyf.xl(Eyf.Dx(rrc.sf("INCLUDED_CONNECTORS")), true, new char[] { ',', '|' }, true, true));
				}
				if (lmr2.G() > 0)
				{
					egl.Q().t("name", "IncludedSingle").t("displayName", "Included Add-on Connectors")
						.G("licenses")
						.i();
					foreach (object obj5 in lyv)
					{
						guB guB2 = (guB)obj5;
						if (guB2 != guB && lmr2.Contains(Eyf.Dx(guB2.D())))
						{
							egl.Q();
							guo.SE(egl, guB2);
							egl.f();
						}
					}
					egl.A().f();
				}
				egl.Q().t("name", "LicensedSingle").t("displayName", "Licensed Add-on Connectors")
					.G("licenses")
					.i();
				foreach (object obj6 in lyv)
				{
					guB guB2 = (guB)obj6;
					if (guB2 != guB && !lmr.Contains(Eyf.Dx(guB2.D())) && !lmr2.Contains(Eyf.Dx(guB2.D())))
					{
						egl.Q();
						guo.SE(egl, guB2);
						egl.f();
					}
				}
				egl.A().f();
				egl.A();
			}
			else
			{
				egl.H("noLicenseInfo", "true", false);
			}
			egl.f();
			return egl.ToString();
		}

		// Token: 0x0601341C RID: 78876 RVA: 0x0076B170 File Offset: 0x00769370
		public void ovJ(string string_0)
		{
			RSBException ex = null;
			lyv<guB> lyv = null;
			string text = guo.SA(string_0);
			int i;
			lock (guo.g)
			{
				lyv<guB> lyv2 = guo.q.m(text);
				bool flag2 = lyv2 != null;
				i = 0;
				while (flag2 && i < lyv2.W())
				{
					flag2 = lyv2.j(i).pA();
					i++;
				}
				if (flag2)
				{
					lyv = lyv2;
					for (i = 0; i < lyv.W(); i++)
					{
						guB guB = lyv.j(i);
						if (guB.t() && guB.y() <= 0 && this.C <= lyc.G())
						{
							this.C = lyc.G() + 60000L;
							rga.Fu("application", "arc.core.lic").kQ(Eyf.OS("The subscription license has expired for this product.  The product will not continue functioning as expected.  To avoid any disruptions in service please contact {0} immediately.", "arcsales@cdata.com"), null, "CheckAppKey");
							if (this.b != null)
							{
								RSBItem rsbitem = this.b.CreateItem();
								rsbitem.SetAttr("subject", "The subscription license has expired");
								rsbitem.SetAttr("message", Eyf.OS("The subscription license has expired for this product.  The product will not continue functioning as expected.  To avoid any disruptions in service please contact {0} immediately.", "arcsales@cdata.com"));
								this.b.Call("appSendEmail", rsbitem);
							}
						}
					}
				}
			}
			if (lyv == null)
			{
				lyv = this.hi(string_0);
			}
			i = 0;
			while (i < lyv.W())
			{
				guB guB = lyv.j(i);
				if (guB.nu() == null)
				{
					i++;
				}
				else
				{
					ex = guB.nu();
					IL_01AA:
					lock (guo.g)
					{
						guo.q.H(text, lyv);
					}
					if (ex != null)
					{
						throw ex;
					}
					return;
				}
			}
			goto IL_01AA;
		}

		// Token: 0x0601341D RID: 78877 RVA: 0x0076B394 File Offset: 0x00769594
		public void ovF(string string_0, int int_0)
		{
			this.ovJ(null);
			if (!guo.by(string_0))
			{
				if (int_0 > 0)
				{
					bool flag = rrc.sh("AS2_ONLY", false);
					string text = rrc.sf("LICENSED_DEPRECATED_SINGLE_CONNECTOR_TYPES");
					gPX gPX = this.hu(true);
					gPX.m(string_0, int_0);
					lyv<string> lyv = gPX.K();
					int[] array = guo.ht(gPX, flag, text);
					guo.hA(array, true);
					this.L.x();
					if (guo.bu(string_0, flag) == 999)
					{
						int num = Eyf.CF(rrc.sf("MAX_OTHER_CONNECTORS"), -1);
						if (num < 999)
						{
							lmr<string> lmr = new lmr<string>();
							lmr<string> lmr2 = new lmr<string>();
							foreach (object obj in lyv)
							{
								string text2 = (string)obj;
								if (!lmr2.Contains(text2) && !lmr.Contains(text2))
								{
									lmr.Add(text2);
									if (guo.bu(text2, flag) == 999)
									{
										guB guB = this.hV(text2, EQB.OH().obJ(text2), true);
										if (guB.nu() != null)
										{
											lmr2.Add(text2);
										}
									}
								}
							}
							if (lmr2.G() > num && lmr2.Contains(string_0))
							{
								throw new RSBException("License", Eyf.IB("The installed license does not allow the creation of this type of connector [{0}]. Please contact {1} to acquire a license that enables the [{0}] connector.", true, new object[] { string_0, "arcsales@cdata.com" }));
							}
						}
					}
				}
			}
			else
			{
				guB guB = this.hV(string_0, EQB.OH().obJ(string_0), true);
				if (guB.nu() != null)
				{
					throw new RSBException("License", Eyf.IB("The beta period for the {0} Connector has expired. Please check for a new build at {1} or contact {2} for assistance.", true, new object[] { string_0, "arc.cdata.com", "arcsales@cdata.com" }));
				}
			}
		}

		// Token: 0x0601341E RID: 78878 RVA: 0x0076B5A0 File Offset: 0x007697A0
		public void ovo(string string_0, int int_0)
		{
			this.ovJ(null);
			if (int_0 > 0 && "|as4v2|".Contains("|" + Eyf.Dx(string_0) + "|"))
			{
				bool flag = rrc.sh("AS2_ONLY", false);
				string text = rrc.sf("LICENSED_DEPRECATED_SINGLE_CONNECTOR_TYPES");
				gPX gPX = this.hu(true);
				gPX.H(string_0, int_0);
				int[] array = guo.ht(gPX, flag, text);
				guo.hA(array, false);
			}
		}

		// Token: 0x0601341F RID: 78879 RVA: 0x0076B614 File Offset: 0x00769814
		public gPc ovh(gPy gPy_0)
		{
			Eyf.Fn<gPy>(gPy_0, "LicenseUsageChanges", new object[0]);
			this.ovJ(null);
			bool flag = rrc.sh("AS2_ONLY", false);
			string text = rrc.sf("LICENSED_DEPRECATED_SINGLE_CONNECTOR_TYPES");
			gPX gPX = this.hu(true);
			gPX gPX2 = gPX.E(gPy_0);
			int[] array = guo.ht(gPX, flag, text);
			int[] array2 = guo.ht(gPX2, flag, text);
			gPc gPc = new gPc();
			gPc.u(guo.A("MFT", array[0], array2[0], "MAX_MFT_CONNECTORS"));
			gPc.u(guo.A("EDI", array[1], array2[1], "MAX_EDI_CONNECTORS"));
			gPc.u(guo.A("Database", array[2], array2[2], "MAX_DATABASE_CONNECTORS"));
			int num = Eyf.CF(rrc.sf("MAX_OTHER_CONNECTORS"), -1);
			if (num < 999)
			{
				lmr<string> lmr = this.W(gPX.K(), flag);
				lmr<string> lmr2 = this.W(gPX2.K(), flag);
				bool flag2 = false;
				if (lmr2.G() > num)
				{
					using (lmg<gPr> lmg = gPy_0.E().O())
					{
						while (lmg.MoveNext())
						{
							gPr gPr = lmg.Current;
							if (lmr2.Contains(gPr.t()))
							{
								flag2 = true;
								IL_017F:
								goto IL_0102;
							}
						}
						goto IL_017F;
					}
					return gPc;
				}
				IL_0102:
				gPc.u(new gPg("Other", lmr.G(), lmr2.G(), num, flag2));
			}
			else
			{
				gPc.u(new gPg("Other", array[3], array2[3], num, false));
			}
			return gPc;
		}

		// Token: 0x06013420 RID: 78880 RVA: 0x0076B7C8 File Offset: 0x007699C8
		private static gPg A(string string_0, int int_0, int int_1, string string_1)
		{
			int num = Eyf.CF(rrc.sf(string_1), -1);
			return new gPg(string_0, int_0, int_1, num, num < 999 && int_1 > num);
		}

		// Token: 0x06013421 RID: 78881 RVA: 0x0076B7FC File Offset: 0x007699FC
		private lmr<string> W(lyv<string> lyv_0, bool bool_0)
		{
			lmr<string> lmr = new lmr<string>();
			lmr<string> lmr2 = new lmr<string>();
			lmr<string> lmr3;
			if (lyv_0 != null)
			{
				foreach (object obj in lyv_0)
				{
					string text = (string)obj;
					if (text != null && !lmr.Contains(text))
					{
						lmr.Add(text);
						if (!guo.by(text) && guo.bu(text, bool_0) == 999)
						{
							guB guB = this.hV(text, EQB.OH().obJ(text), true);
							if (guB.nu() != null)
							{
								lmr2.Add(text);
							}
						}
					}
				}
				lmr3 = lmr2;
			}
			else
			{
				lmr3 = lmr2;
			}
			return lmr3;
		}

		// Token: 0x06013422 RID: 78882 RVA: 0x0076B8D4 File Offset: 0x00769AD4
		public void ovg(string string_0, string string_1)
		{
			if (gPm.E(string_0))
			{
				this.hy(true);
			}
		}

		// Token: 0x06013423 RID: 78883 RVA: 0x0076B8F4 File Offset: 0x00769AF4
		protected internal lmr<gPr> hy(bool bool_0)
		{
			return this.L.u(bool_0);
		}

		// Token: 0x06013424 RID: 78884 RVA: 0x0076B910 File Offset: 0x00769B10
		private gPX hu(bool bool_0)
		{
			lmr<gPr> lmr = this.hy(bool_0);
			return new gPX(lmr, this.L.y(bool_0), gPm.f());
		}

		// Token: 0x06013425 RID: 78885 RVA: 0x0076B940 File Offset: 0x00769B40
		private static void hA(int[] int_0, bool bool_0)
		{
			int num = Eyf.CF(rrc.sf("MAX_MFT_CONNECTORS"), -1);
			if (num < 999 && int_0[0] > num)
			{
				throw new RSBException("License", "The current license for this application has reached the maximum amount of allowed connector configurations. You must upgrade your license to add additional connector configurations.");
			}
			int num2 = Eyf.CF(rrc.sf("MAX_EDI_CONNECTORS"), -1);
			if (num2 >= 999 || int_0[1] <= num2)
			{
				if (bool_0)
				{
					int num3 = Eyf.CF(rrc.sf("MAX_DATABASE_CONNECTORS"), -1);
					if (num3 < 999 && int_0[2] > num3)
					{
						throw new RSBException("License", "The current license for this application has reached the maximum amount of allowed connector configurations. You must upgrade your license to add additional connector configurations.");
					}
				}
				return;
			}
			throw new RSBException("License", "The current license for this application has reached the maximum amount of allowed connector configurations. You must upgrade your license to add additional connector configurations.");
		}

		// Token: 0x06013426 RID: 78886 RVA: 0x0076B9F8 File Offset: 0x00769BF8
		public void ovU(RSBContext rsbcontext_0)
		{
			string input = rsbcontext_0.GetInput("prodName");
			if (Eyf.lx(input))
			{
				throw new RSBException("InstallLicense", "The name of product must be set.");
			}
			string input2 = rsbcontext_0.GetInput("prod");
			if (!Eyf.lx(input2))
			{
				bool flag = Eyf.hK(input2, "AZYNA");
				RSBLanguageService rsblanguageService = (RSBLanguageService)rsbcontext_0.GetService("language.service");
				RSBItem item = rsblanguageService.GetItem("_about");
				string text = Eyf.mh(rsbcontext_0.GetInput("key"));
				bool flag2 = Eyf.CZ(rsbcontext_0.GetInput("trial"), false);
				string text2 = string.Concat(new object[]
				{
					"?prod=",
					input2,
					"&nodeid=",
					item.GetAttr("nodeid"),
					"&canemail=1&c=",
					gPf.u(),
					"&name=",
					Eyf.lO(rsbcontext_0.GetInput("name")),
					"&email=",
					Eyf.lO(rsbcontext_0.GetInput("email")),
					"&setup=true"
				});
				if (!flag2)
				{
					text2 = text2 + "&a=vset&sno=" + text;
				}
				else
				{
					if (flag && !gui.bE())
					{
						throw new RSBException("InstallLicense", Eyf.OS("The trial license has already been installed for this application.  You can order a free license at http://{0}/order.", "arc.cdata.com"));
					}
					text2 += "&a=itrial";
				}
				bool flag3 = false;
				if (Eyf.UK(text, "x", true))
				{
					byte[] array = Eyf.IV(gPf.f(text).Substring(1));
					flag3 = !this.ovC(array) && this.oUk(array) && this.oUz(array);
				}
				string text3 = gPf.G(input, (!flag3) ? 2 : 1);
				if (!Eyf.UB(rsbcontext_0.GetInput("urlonly"), false))
				{
					string text4 = null;
					try
					{
						string text5 = "https://arc-lic.cdata.com/lic/";
						PZh pzh = new PZh();
						this.hL(pzh);
						pzh.JXe(1);
						pzh.HN(0L);
						pzh.om(text5 + text2);
						text4 = Eyf.Im(pzh.Hy());
					}
					catch (Exception ex)
					{
						throw new RSBException("InstallLicense", "Unable to install license. Please check your product key." + Eyf.eD(ex), ex);
					}
					this.hr(text4, text3, flag);
				}
				else
				{
					string text6 = "https://arc.cdata.com/lic/";
					rsbcontext_0.SetOutput("url", string.Concat(new string[] { text6, text2, "&f=", text3, "&origin=arc" }));
					rsbcontext_0.PushItem();
				}
				return;
			}
			throw new RSBException("InstallLicense", "The prod of product must be set.");
		}

		// Token: 0x06013427 RID: 78887 RVA: 0x0076BCF0 File Offset: 0x00769EF0
		public void hr(string string_0, string string_1, bool bool_0)
		{
			if (Eyf.lx(string_0) || string_0.IndexOf("REGEDIT") < 0)
			{
				throw new RSBException("InstallLicense", "Unable to install license. Please check your product key.");
			}
			lock (guo.g)
			{
				guo.q.Clear();
			}
			string text = gPf.j(string_1);
			Eyf.VJ(string_0, text, false);
		}

		// Token: 0x06013428 RID: 78888 RVA: 0x0076BD70 File Offset: 0x00769F70
		public void hE(string string_0, bool bool_0)
		{
			lock (guo.g)
			{
				guo.q.Clear();
			}
			try
			{
				Eyf.pI(gPf.j(string_0));
			}
			finally
			{
			}
		}

		// Token: 0x06013429 RID: 78889 RVA: 0x0076BDD0 File Offset: 0x00769FD0
		public void ovv(string string_0, bool bool_0)
		{
			string productKey = guB.ih(string_0);
			bool useCloudLicenseFile = false;
			if (Eyf.UK(productKey, "x", true))
			{
				byte[] keyBytes = Eyf.IV(gPf.f(productKey).Substring(1));
				useCloudLicenseFile = !this.ovC(keyBytes) && this.oUk(keyBytes) && this.oUz(keyBytes);
			}
			guB product = guB.iM(productKey);
			string licenseFileName = gPf.G(product.D(), useCloudLicenseFile ? 1 : 2);
			bool isAppLicense = Eyf.hK(product.E(), "AZYNA");
			if (bool_0 && !isAppLicense)
			{
				throw new RSBException("InstallLicense", Eyf.OS("License is not for {0}.", "CData Arc"));
			}

			this.hr(string_0, licenseFileName, isAppLicense);
			if (!bool_0)
			{
				return;
			}

			lyv<guB> licenses = this.hi(null);
			if (licenses != null && licenses.W() >= 1 && licenses.j(0).nu() == null)
			{
				return;
			}

			try
			{
				this.hE(licenseFileName, isAppLicense);
			}
			catch (Exception)
			{
				// Preserve the validation error if removing the rejected upload fails.
			}
			if (licenses != null && licenses.W() >= 1)
			{
				throw licenses.j(0).nu();
			}
			throw new RSBException("InstallLicense", "Internal error: Cannot get license info.");
		}

		// Token: 0x0601342A RID: 78890 RVA: 0x00769440 File Offset: 0x00767640
		private void hL(PZh pzh_0)
		{
			EvD evD = EvE.m();
			if (null != evD)
			{
				EJv ejv = evD.FRa("Application").s();
				if (null != ejv)
				{
					string text = ejv.V("ProxyHost");
					if (!Eyf.lx(text))
					{
						string text2 = ejv.V("ProxyPort");
						string text3 = ejv.V("ProxyUser");
						string text4 = ejv.V("ProxyPassword");
						string text5 = ejv.V("ProxyType");
						pzh_0.AF();
						pzh_0.Ay(text);
						pzh_0.AD(Eyf.CF(text2, 0));
						if (!Eyf.lx(text3))
						{
							pzh_0.Ar(text3);
							pzh_0.AN(text4);
						}
						if (!lcP.nt(text5, "none"))
						{
							if (!lcP.nt(text5, "tunnel"))
							{
								if (!lcP.nt(text5, "socks4"))
								{
									if (lcP.nt(text5, "socks5"))
									{
										pzh_0.JXw(3);
										pzh_0.AD(Eyf.CF(text2, 1080));
									}
								}
								else
								{
									pzh_0.JXw(2);
									pzh_0.AD(Eyf.CF(text2, 1080));
								}
							}
							else
							{
								pzh_0.JXw(1);
								pzh_0.AD(Eyf.CF(text2, 80));
							}
						}
						else
						{
							pzh_0.JXw(0);
						}
					}
				}
			}
		}

		// Token: 0x0601342B RID: 78891 RVA: 0x0076BF10 File Offset: 0x0076A110
		public void ovS(string string_0, guB guB_0)
		{
			if (!Eyf.lx(string_0))
			{
				byte[] array = Eyf.IV(string_0);
				bool flag;
				if (flag = this.oUk(array))
				{
					guB_0.Im(this.oUz(array));
				}
				else
				{
					array = Eyf.IV(string_0);
				}
				guB_0.Iu(true);
				guB_0.IV(flag);
				bool flag2 = this.br(array);
				if (!rrh.K(array) && !this.ovC(array))
				{
					int[] array2 = this.bE(array, flag2);
					guB_0.Iy(array2[0]);
					guB_0.iT(flag2);
					guB_0.nO(guo.bK(this.bt(array, "MFT"), guB_0.wE(), array2[1], flag2));
					guB_0.nq(guo.bW(this.bt(array, "EDI"), guB_0.wE(), array2[1], flag2));
					guB_0.nY(guo.Sy(this.bt(array, "DBS"), guB_0.wE(), this.bA(array), flag2));
					guB_0.nC(guo.Su(this.bt(array, "OTH"), guB_0.wE(), flag2));
					guB_0.ni(false);
					guB_0.nL(this.ova(array));
				}
				else
				{
					guB_0.Iy(999);
					guB_0.Ir(true);
					guB_0.iT(flag2);
					guB_0.nO(999);
					guB_0.nq(999);
					guB_0.nY(999);
					guB_0.nC(999);
					guB_0.Im(false);
					guB_0.nL(this.ova(array));
				}
			}
		}

		// Token: 0x0601342C RID: 78892 RVA: 0x007696FC File Offset: 0x007678FC
		protected internal override string oUI()
		{
			return "AZYNA";
		}

		// Token: 0x0601342D RID: 78893 RVA: 0x00769710 File Offset: 0x00767910
		protected internal override char oUq()
		{
			return 'N';
		}

		// Token: 0x0601342E RID: 78894 RVA: 0x0076C09C File Offset: 0x0076A29C
		protected internal override string oUN()
		{
			return "Arc 2026";
		}

		// Token: 0x0601342F RID: 78895 RVA: 0x00769740 File Offset: 0x00767940
		protected internal override string oUw()
		{
			string text = gPf.c(giw.p(), "Arc");
			string text2;
			if (!File.Exists(text))
			{
				text = Assembly.GetExecutingAssembly().CodeBase;
				if (text.StartsWith("file:///", StringComparison.InvariantCultureIgnoreCase))
				{
					text = text.Substring(8);
				}
				text = Path.Combine(Path.GetDirectoryName(text), "..\\app_data\\");
				text = gPf.c(text, "Arc");
				if (!File.Exists(text))
				{
					text2 = null;
				}
				else
				{
					text2 = text;
				}
			}
			else
			{
				text2 = text;
			}
			return text2;
		}

		// Token: 0x06013430 RID: 78896 RVA: 0x0007C509 File Offset: 0x0007A709
		protected internal override void oUe(byte[] byte_0)
		{
			mcy.c(byte_0);
		}

		// Token: 0x06013431 RID: 78897 RVA: 0x000FBD30 File Offset: 0x000F9F30
		protected internal override bool oUT()
		{
			return true;
		}

		// Token: 0x06013432 RID: 78898 RVA: 0x0076C0B0 File Offset: 0x0076A2B0
		protected internal override bool oUk(byte[] byte_0)
		{
			return rrh.G(byte_0);
		}

		// Token: 0x06013433 RID: 78899 RVA: 0x0009ABDC File Offset: 0x00098DDC
		protected internal override bool oUY(int int_0, byte[] byte_0, string string_0)
		{
			return false;
		}

		// Token: 0x06013434 RID: 78900 RVA: 0x0009ABDC File Offset: 0x00098DDC
		protected internal override bool oUd(byte[] byte_0)
		{
			return false;
		}

		// Token: 0x06013435 RID: 78901 RVA: 0x0076C0C4 File Offset: 0x0076A2C4
		protected internal override int oUR(byte[] byte_0)
		{
			return rrh.f(byte_0);
		}

		// Token: 0x06013436 RID: 78902 RVA: 0x0076C0DC File Offset: 0x0076A2DC
		protected internal override bool oUz(byte[] byte_0)
		{
			return rrh.t(byte_0);
		}

		// Token: 0x06013437 RID: 78903 RVA: 0x0076C0F0 File Offset: 0x0076A2F0
		protected internal override bool ovC(byte[] byte_0)
		{
			bool flag;
			if (byte_0 != null && byte_0.Length >= 10 && byte_0[6] == 89)
			{
				if (byte_0[7] == 84 && byte_0[8] == 82)
				{
					if (byte_0[9] == 76 || byte_0[9] == 49)
					{
						return true;
					}
				}
				flag = byte_0[7] == 77 && byte_0[8] == 84 && (byte_0[9] == 76 || byte_0[9] == 49);
			}
			else
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x06013438 RID: 78904 RVA: 0x0076C160 File Offset: 0x0076A360
		private lyv<guB> hi(string string_0)
		{
			lyv<guB> lyv = new lyv<guB>();
			EoE eoE = null;
			RSBException ex = null;
			lmr<gPr> lmr = null;
			try
			{
				eoE = EQB.OH();
				lmr = this.hy(false);
			}
			catch (RSBException ex2)
			{
				ex = ex2;
			}
			string text = "";
			lmr<string> lmr2 = Eyf.Ox(Eyf.xD("|database|mysql|postgresql|sqlite|derby|sqlserver|oracle|db2|", true, '|', false, true));
			if (lmr2.G() > 0 && eoE != null)
			{
				lyh lyh = eoE.obb();
				while (lyh.MPP())
				{
					string text2 = lyh.MPX().ToString();
					string text3 = gPf.i(text2);
					if (lmr2.Contains(text3))
					{
						string text4 = "|" + Eyf.Dx(text3) + "|";
						try
						{
							guB guB = this.hV(text3, eoE.obJ(text2), true);
							if (guB.nu() == null && !guB.r())
							{
								text += text4;
								lyv.Add(guB);
							}
						}
						catch (Exception)
						{
						}
					}
				}
			}
			rrc.sK("LICENSED_DEPRECATED_SINGLE_CONNECTOR_TYPES", text);
			guB guB2 = this.hn();
			if (guB2.nu() == null && ex != null)
			{
				guB2.nE(ex);
			}
			lyv.MPh(guB2, 0);
			bool flag = false;
			try
			{
				flag = gui.bE();
			}
			catch (RSBException ex2)
			{
			}
			if (!lZh.e)
			{
				rrc.sm(guB2.wr());
			}
			rrc.sl(guB2.x());
			rrc.sj(guB2.Is());
			rrc.sK("MAX_MFT_CONNECTORS", Eyf.Dt(guB2.np()));
			rrc.sK("MAX_EDI_CONNECTORS", Eyf.Dt(guB2.nf()));
			rrc.sK("MAX_DATABASE_CONNECTORS", Eyf.Dt(guB2.nw()));
			rrc.sK("MAX_OTHER_CONNECTORS", Eyf.Dt(guB2.nD()));
			rrc.sK("SUB_EXPIRING_TYPE", Eyf.Dt(guB2.nX()));
			rrc.sK("RAW_MASKED_SERIAL_NUMBER", guB2.wm());
			rrc.sK("AS2_ONLY", Eyf.Dw(guB2.iq()));
			rrc.sK("SPECIAL_COUNT", Eyf.Dw(guB2.iY()));
			rrc.sK("IS_LEGACY_LICENSE", Eyf.Dw(guB2.iC()));
			rrc.sK("APP_PROD", Eyf.DF(guB2.E()));
			rrc.sK("ALLOW_TRIAL_ACTIVATE", Eyf.Dw(flag));
			rrc.sV(guB2.wV());
			rrc.sE(guB2.r());
			rrc.sQ(guB2.t());
			rrc.sY(guB2.s());
			rrc.sp(guB2.m());
			rrc.sa(guB2.y());
			rrc.sK("BETA_CONNECTOR_EXPIRE_DAYS", Eyf.DO(rrh.H(1802304000L)));
			rrc.sK("IS_MFTONLY_LICENSE", Eyf.Dw(guB2.iE()));
			gPX gPX = new gPX(lmr, this.L.y(false), gPm.f());
			lyv<string> lyv2 = gPX.K();
			int[] array = guo.ht(gPX, guB2.iq(), text);
			if (array != null && array.Length > 3)
			{
				guB2.nh(array[0]);
				guB2.nV(array[1]);
				guB2.iA(array[2]);
				guB2.ii(array[3]);
				guB2.iO(array[4]);
				guB2.iu(Eyf.xn(",", Eyf.On(lyv2)));
			}
			if (guB2.nu() == null && guB2.np() < 999 && array[0] > guB2.np())
			{
				guB2.nE(new RSBException("License", Eyf.Oq("Only {0} {1} {2}(s) are supported by this license. Please contact {3} to enable support for more {4} configurations.", new string[]
				{
					Eyf.Dt(guB2.np()),
					"MFT",
					guo.bV(guB2.nT()),
					"arcsales@cdata.com",
					guo.bV(guB2.nT())
				})));
			}
			if (guB2.nu() == null && guB2.nf() < 999 && array[1] > guB2.nf())
			{
				guB2.nE(new RSBException("License", Eyf.Oq("Only {0} {1} {2}(s) are supported by this license. Please contact {3} to enable support for more {4} configurations.", new string[]
				{
					Eyf.Dt(guB2.nf()),
					"EDI",
					guo.bV(guB2.nT()),
					"arcsales@cdata.com",
					guo.bV(guB2.nT())
				})));
			}
			if (guB2.nu() == null && guB2.nw() < 999 && array[2] > guB2.nw())
			{
				guB2.nE(new RSBException("License", Eyf.Oq("Only {0} connector type(s) from the Database category of connectors are supported by this license. Please contact {1} to enable support for more {2} configurations.", new string[]
				{
					Eyf.Dt(guB2.nw()),
					"arcsales@cdata.com",
					guo.bV(guB2.nT())
				})));
			}
			try
			{
				lmr<string> lmr3 = new lmr<string>();
				if ("*".Equals(string_0))
				{
					goto IL_0320;
				}
				if (!Eyf.lx(string_0))
				{
					goto IL_037E;
				}
				IL_02B0:
				lmr<string> lmr4 = new lmr<string>();
				using (lmg<string> lmg = lmr3.O())
				{
					while (lmg.MoveNext())
					{
						string text5 = lmg.Current;
						if (guo.by(text5))
						{
							lmr4.Add(text5);
							guB guB = this.hV(text5, eoE.obJ(text5), true);
							guB.pi(guB2);
							lyv.Add(guB);
						}
					}
					goto IL_038B;
				}
				goto IL_0320;
				IL_038B:
				rrc.sK("CREATED_BETA_CONNECTOR_TYPES", Eyf.xn(",", Eyf.Ow(lmr4)));
				goto IL_03DF;
				IL_0320:
				if (lyv2 == null)
				{
					goto IL_02B0;
				}
				using (IEnumerator enumerator = lyv2.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						string text6 = (string)obj;
						if (!lmr3.Contains(text6))
						{
							lmr3.Add(text6);
						}
					}
					goto IL_02B0;
				}
				IL_037E:
				lmr3.Add(string_0);
				goto IL_02B0;
			}
			catch (Exception ex3)
			{
				if (guB2.nu() == null)
				{
					guB2.nE(new RSBException("License", "Internal error: " + Eyf.eD(ex3), ex3));
				}
			}
			IL_03DF:
			lyv<guB> lyv3;
			if (!Eyf.lx(string_0) && ("*".Equals(string_0) || guB2.nD() < 999))
			{
				if ("*".Equals(string_0) || guo.bu(string_0, guB2.iq()) == 999)
				{
					lcc lcc = new lcc();
					lcc lcc2 = new lcc();
					try
					{
						lyh lyh = eoE.obb();
						lmD<string, EQB> lmD = new lmD<string, EQB>();
						while (lyh.MPP())
						{
							string text2 = lyh.MPX().ToString();
							if (!guo.by(text2))
							{
								EQB eqb = eoE.obJ(text2);
								if (guo.bu(eqb.B(), guB2.iq()) == 999)
								{
									lmD.H(eqb.B(), eqb);
								}
							}
						}
						lmr<string> lmr5 = new lmr<string>();
						lmr<guB> lmr6 = new lmr<guB>();
						for (int i = 0; i < lyv2.W(); i++)
						{
							string text6 = lyv2.j(i);
							if (text6 != null && !guo.by(text6) && !lmr5.Contains(text6) && lmD.ContainsKey(text6))
							{
								guB guB = this.hV(text6, lmD.m(text6), true);
								if (guB.nu() != null)
								{
									guB.pi(guB2);
									lmr5.Add(text6);
									lmr6.Add(guB);
								}
								else
								{
									lyv.Add(guB);
									lcc.MPI('|').MPI(Eyf.Dx(text6)).MPI('|');
								}
								lmD.E(text6);
							}
						}
						guB2.ii(lmr5.G());
						if (lmr5.G() > guB2.nD())
						{
							if (!"*".Equals(string_0))
							{
								goto IL_06AB;
							}
							bool flag2 = false;
							IL_065F:
							if (flag2)
							{
								goto IL_05F2;
							}
							if (guB2.nu() == null)
							{
								guB2.nE(new RSBException("License", Eyf.Oq("Only {0} connector type(s) from the Other category of connectors are supported by this license, however instances were detected for the following connectors: {1}. Please contact {2} to enable support for more {3} configurations.", new string[]
								{
									Eyf.Dt(guB2.nD()),
									Eyf.xn(", ", Eyf.Ow(lmr5)),
									"arcsales@cdata.com",
									guo.bV(guB2.nT())
								})));
							}
							using (lmg<guB> lmg2 = lmr6.O())
							{
								while (lmg2.MoveNext())
								{
									guB guB = lmg2.Current;
									lyv.Add(guB);
								}
								goto IL_05F2;
							}
							IL_06AB:
							flag2 = !lmr5.Contains(string_0);
							goto IL_065F;
						}
						using (lmg<guB> lmg2 = lmr6.O())
						{
							while (lmg2.MoveNext())
							{
								guB guB = lmg2.Current;
								guB.ng(null);
								guB.nE(null);
								guB.IE("[ENTERPRISE-LICENSE]");
								lyv.Add(guB);
								lcc2.MPI('|').MPI(Eyf.Dx(guB.D())).MPI('|');
							}
						}
						IL_05F2:
						lyh lyh2 = Eyf.AS<string, EQB>(lmD);
						while (lyh2.MPP())
						{
							string text7 = (string)lyh2.MPX();
							guB guB = this.hV(text7, lmD.m(text7), false);
							if (guB.nu() == null && Eyf.lx(guB.nM()))
							{
								lcc.MPI('|').MPI(Eyf.Dx(text7)).MPI('|');
							}
							guB.pi(guB2);
							lyv.Add(guB);
						}
					}
					catch (Exception ex3)
					{
						if (guB2.nu() == null)
						{
							guB2.nE(new RSBException("License", "Internal error: " + Eyf.eD(ex3), ex3));
						}
					}
					finally
					{
						rrc.sK("LICENSED_CONNECTORS", lcc.ToString());
						rrc.sK("INCLUDED_CONNECTORS", lcc2.ToString());
					}
					if (guB2.p() && (guB2.t() || guB2.m()))
					{
						using (IEnumerator enumerator = lyv.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								guB guB = (guB)enumerator.Current;
								if (guB.p() && !guB.m() && !guB.r() && !guB.t() && !guB2.m())
								{
									guB.IV(guB2.t());
									guB.Ir(guB2.m());
									guB.In(guB2.y());
								}
							}
							goto IL_07C6;
						}
						return lyv3;
					}
					IL_07C6:
					lyv3 = lyv;
				}
				else
				{
					lyv3 = lyv;
				}
			}
			else
			{
				lyv3 = lyv;
			}
			return lyv3;
		}

		// Token: 0x06013439 RID: 78905 RVA: 0x0076CE24 File Offset: 0x0076B024
		protected internal guB hn()
		{
			guB guB = new guB("Arc", "AZYNA", "Arc 2026", "26.4.9813.0");
			int num = -1;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			bool flag6 = false;
			bool flag7 = false;
			bool flag8 = false;
			bool flag9 = false;
			bool flag10 = false;
			string[] array = new string[0];
			string[] array2 = new string[] { "[NO-VALID-LICENSE]" };
			string text = array2[0];
			int num7 = 1;
			int num8 = 0;
			string text2 = null;
			try
			{
				try
				{
					byte[][] array3 = new byte[1][];
					bool flag11 = true;
					text2 = this.oUw();
					flag10 = !Eyf.lx(text2) && Ecg.MG(text2);
					bool flag12 = Eyf.CZ(Environment.GetEnvironmentVariable("arcazuremarketplace"), false);
					bool flag13 = false;
					if (flag12)
					{
						if (Eyf.lx(text2) || !Ecg.MG(text2))
						{
							flag11 = false;
						}
						if (!rrv.w)
						{
							flag11 = true;
						}
					}
					if (flag11)
					{
						try
						{
							base.A(array2, array3);
							flag13 = true;
							guB.pn(text2, guB.Y);
							goto IL_00BE;
						}
						catch (RSBException ex)
						{
							if (!flag12 || !rrv.w)
							{
								throw;
							}
							goto IL_00BE;
						}
						goto IL_0259;
					}
					IL_00BE:
					byte[] array4 = array3[0];
					text = array2[0];
					if (rrh.K(array4))
					{
						goto IL_0259;
					}
					if (!this.ovC(array4))
					{
						if (flag13 || !rrv.w)
						{
							flag8 = this.bA(array4);
							flag9 = this.br(array4);
							int[] array5 = this.bE(array4, flag9);
							num = array5[0];
							flag = false;
							num7 = this.ova(array4);
							num8 = base.i(array4);
							num2 = guo.bK(this.bt(array4, "MFT"), num, array5[1], flag9);
							num3 = guo.bW(this.bt(array4, "EDI"), num, array5[1], flag9);
							num4 = guo.Sy(this.bt(array4, "DBS"), num, flag8, flag9);
							num5 = guo.Su(this.bt(array4, "OTH"), num, flag9);
							if (this.bi(array4))
							{
								num = 999;
							}
							flag7 = flag8 || this.bL(array4);
							array = this.bn(array4);
							if (this.oUk(array4))
							{
								flag2 = true;
								flag3 = this.oUz(array4);
								num6 = base.Q(array4);
								if (num6 <= 0)
								{
									throw new RSBException("License", Eyf.OS("The subscription license has expired for this product.  The product will not continue functioning as expected.  To avoid any disruptions in service please contact {0} immediately.", "arcsales@cdata.com"));
								}
							}
						}
						else
						{
							flag10 = true;
							num = rrv.L();
							if (flag = num == 0)
							{
								flag6 = true;
							}
							guB.@if(array2[0] = "Arc");
							num2 = guo.bK(rrv.u(), num, 1, flag9);
							num3 = guo.bW(rrv.m(), num, 1, flag9);
							num4 = guo.Sy(rrv.G(), num, false, flag9);
							num5 = guo.Su(rrv.W(), num, flag9);
							text = rrv.f;
							num8 = ((!flag) ? 1 : 0);
							guB.pn(null, guB.Y);
						}
					}
					else
					{
						flag5 = true;
						flag = false;
						flag9 = this.br(array4);
						num6 = base.Q(array4);
						num2 = 999;
						num3 = 999;
						num4 = 999;
						num5 = 999;
						num = 999;
						if (num6 <= 0)
						{
							throw new RSBException("License", Eyf.IB("This system contains a license for {0} that has expired.  Please visit {1} or email {2} for information on purchasing a license or extending your license", false, new object[]
							{
								this.oUN(),
								"arc.cdata.com",
								"arcsales@cdata.com"
							}));
						}
					}
					IL_01CA:
					if (!flag8 && num < 100 && giw.jb() > 1)
					{
						throw new RSBException("License", Eyf.IB("The installed license does not allow the current advanced login mode. Please contact {0} to acquire a license that enables this feature.", true, new object[] { "arcsales@cdata.com" }));
					}
					if (flag && !rrv.w && !guo.Sr(true))
					{
						throw new RSBException("License", "This version of the Arc only works with the embedded server. To host the Arc in another environment, please upgrade your license.");
					}
					goto IL_049C;
					IL_0259:
					flag5 = true;
					flag = false;
					flag9 = this.br(array4);
					text += lXu.mz();
					num6 = base.Q(array4);
					array2[0] = Eyf.OS("[30 DAY TRIAL VERSION - {0} DAYS LEFT]", Eyf.Dt(num6));
					num2 = 999;
					num3 = 999;
					num4 = 999;
					num5 = 999;
					num = 999;
					goto IL_01CA;
				}
				catch (RSBException ex)
				{
					guB.nE(ex);
				}
				IL_049C:;
			}
			finally
			{
				guB.Iu(flag10);
				guB.Iy(num);
				guB.tw(array);
				guB.ni(flag);
				guB.iT(flag9);
				guB.nL(num7);
				guB.nO(num2);
				guB.nq(num3);
				guB.nY(num4);
				guB.nC(num5);
				guB.nb(num8);
				guB.IE(array2[0]);
				guB.IG(text);
				guB.Ix(flag4);
				guB.IV(flag2);
				guB.Im(flag3);
				guB.Ir(flag5);
				guB.In(num6);
				guB.iw(flag6);
				guB.iD(flag7);
				guB.iR(flag8);
				guB.iX(text2);
			}
			return guB;
		}

		// Token: 0x0601343A RID: 78906 RVA: 0x0076D3D4 File Offset: 0x0076B5D4
		protected internal guB hV(string string_0, EQB eqb_0, bool bool_0)
		{
			guB guB;
			if (eqb_0 != null)
			{
				guB = eqb_0.CO(bool_0);
			}
			else
			{
				guB = new guB(string_0, "XXXXX", string_0, "");
				guB.nE(new RSBException("License", Eyf.IB("This connector [{0}] has not been installed.  You can download connectors from here: https://{1}/apps/.", true, new object[] { string_0, "arc.cdata.com" })));
			}
			return guB;
		}

		// Token: 0x0601343B RID: 78907 RVA: 0x0076D43C File Offset: 0x0076B63C
		private static int[] ht(gPX gPX_0, bool bool_0, string string_0)
		{
			int[] array = guo.hK(gPX_0.K(), bool_0, string_0);
			int[] array2 = guo.hW(gPX_0.x());
			for (int i = 0; i < array2.Length; i++)
			{
				array[i] += array2[i];
			}
			array[1] += gPX_0.D();
			return array;
		}

		// Token: 0x0601343C RID: 78908 RVA: 0x0076D4A8 File Offset: 0x0076B6A8
		private static int[] hK(lyv<string> lyv_0, bool bool_0, string string_0)
		{
			int[] array = new int[5];
			int[] array2 = array;
			int[] array3;
			if (lyv_0 != null && lyv_0.W() > 0)
			{
				bool flag = rrc.sh("SPECIAL_COUNT", false);
				lmr<string> lmr = new lmr<string>();
				lmr<string> lmr2 = new lmr<string>();
				for (int i = 0; i < lyv_0.W(); i++)
				{
					string text = lyv_0.j(i);
					if (!guo.by(text) && !"|as4v2|".Contains("|" + Eyf.Dx(text) + "|"))
					{
						int num = guo.bu(text, bool_0);
						if (flag && "|ftp|sftp|".Contains("|" + Eyf.Dx(text) + "|"))
						{
							num = 0;
						}
						if (!Eyf.lx(string_0) && string_0.Contains("|" + Eyf.Dx(gPf.i(text)) + "|"))
						{
							num = 999;
						}
						if (num != -1)
						{
							if (num != 0)
							{
								if (num != 10)
								{
									if (num != 20)
									{
										if (num != 30)
										{
											if (num != 999)
											{
												array2[0]++;
											}
											else if (!lmr2.Contains(text))
											{
												lmr2.Add(text);
												array2[3]++;
											}
										}
										else if (!lmr.Contains(text))
										{
											lmr.Add(text);
											array2[2]++;
										}
									}
									else
									{
										array2[1]++;
									}
								}
								else
								{
									array2[0]++;
								}
							}
							else
							{
								array2[4]++;
							}
						}
					}
				}
				array3 = array2;
			}
			else
			{
				array3 = array2;
			}
			return array3;
		}

		// Token: 0x0601343D RID: 78909 RVA: 0x0076D6F8 File Offset: 0x0076B8F8
		private static int[] hW(lmD<string, int> lmD_0)
		{
			int[] array = new int[5];
			int[] array2 = array;
			lyh lyh = Eyf.AS<string, int>(lmD_0);
			while (lyh.MPP())
			{
				string text = (string)lyh.MPX();
				int num = lmD_0.m(text);
				if (num > 0)
				{
					int num2 = guo.bu(text, false);
					if (num2 != 10)
					{
						if (num2 != 20)
						{
							if (num2 != 0)
							{
								array2[0] += num;
							}
							else
							{
								array2[4] += num;
							}
						}
						else
						{
							array2[1] += num;
						}
					}
					else
					{
						array2[0] += num;
					}
				}
			}
			return array2;
		}

		// Token: 0x0601343E RID: 78910 RVA: 0x00769964 File Offset: 0x00767B64
		public int ovX(string string_0, bool bool_0)
		{
			return guo.bu(string_0, bool_0);
		}

		// Token: 0x0601343F RID: 78911 RVA: 0x0076D7C4 File Offset: 0x0076B9C4
		internal static bool by(string string_0)
		{
			if (!Eyf.lx(string_0))
			{
				string_0 = Eyf.Dx(string_0);
				if (!guo.y.ContainsKey(string_0))
				{
					lock (guo.g)
					{
						if (!guo.y.ContainsKey(string_0))
						{
							try
							{
								EoE eoE = EQB.OH();
								lyh lyh = eoE.obb();
								while (lyh.MPP())
								{
									EQB eqb = eoE.obJ(lyh.MPX().ToString());
									guo.y.H(Eyf.Dx(eqb.B()), Eyf.hK(eqb.CX(), "Beta"));
								}
							}
							catch (ENP enp)
							{
								rga.Fu("application", "arc.core.lic").kQ(Eyf.OS("License internal error: {0}", Eyf.eD(enp)), enp, "IsBetaConnector");
							}
							goto IL_0102;
						}
						return guo.y.m(string_0);
					}
					goto IL_00EE;
					IL_0102:
					return guo.y.ContainsKey(string_0) && guo.y.m(string_0);
				}
				return guo.y.m(string_0);
			}
			IL_00EE:
			return false;
		}

		// Token: 0x06013440 RID: 78912 RVA: 0x0076D914 File Offset: 0x0076BB14
		internal static int bu(string string_0, bool bool_0)
		{
			int num2;
			if (!Eyf.lx(string_0))
			{
				string_0 = Eyf.Dx(string_0);
				int num = -1;
				if (!guo.R.ContainsKey(string_0))
				{
					lock (guo.g)
					{
						if (!guo.R.ContainsKey(string_0))
						{
							try
							{
								EoE eoE = EQB.OH();
								lyh lyh = eoE.obb();
								while (lyh.MPP())
								{
									EQB eqb = eoE.obJ(lyh.MPX().ToString());
									guo.R.H(Eyf.Dx(eqb.B()), eqb.Ck());
								}
							}
							catch (ENP enp)
							{
								rga.Fu("application", "arc.core.lic").kQ(Eyf.OS("License internal error: {0}", Eyf.eD(enp)), enp, "GetConnectorTierImpl");
							}
							if (guo.R.ContainsKey(string_0))
							{
								num = guo.R.m(string_0);
							}
						}
						else
						{
							num = guo.R.m(string_0);
						}
					}
				}
				else
				{
					num = guo.R.m(string_0);
				}
				if (!bool_0)
				{
					num2 = num;
				}
				else if (!string_0.Equals("as2"))
				{
					if (0 != num)
					{
						num2 = 999;
					}
					else
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 10;
				}
			}
			else
			{
				num2 = -1;
			}
			return num2;
		}

		// Token: 0x06013441 RID: 78913 RVA: 0x0076DA90 File Offset: 0x0076BC90
		private bool bA(byte[] byte_0)
		{
			bool flag2;
			if (byte_0 != null && byte_0.Length > 8)
			{
				bool flag;
				if (byte_0[7] != 76)
				{
					if (byte_0[7] != 49)
					{
						flag = false;
						goto IL_0016;
					}
				}
				flag = byte_0[8] == 83;
				IL_0016:
				flag2 = flag;
			}
			else
			{
				flag2 = false;
			}
			return flag2;
		}

		// Token: 0x06013442 RID: 78914 RVA: 0x0076DAD0 File Offset: 0x0076BCD0
		private bool br(byte[] byte_0)
		{
			return byte_0 != null && byte_0.Length > 7 && byte_0[7] == 77;
		}

		// Token: 0x06013443 RID: 78915 RVA: 0x0076DAF8 File Offset: 0x0076BCF8
		private int[] bE(byte[] byte_0, bool bool_0)
		{
			int[] array2;
			if (byte_0 != null && byte_0.Length > 9)
			{
				bool flag;
				if (byte_0[7] == 83 && byte_0[8] == 84)
				{
					if (byte_0[9] == 82)
					{
						flag = false;
						goto IL_0031;
					}
				}
				if (byte_0[7] != 76)
				{
					if (byte_0[7] != 49)
					{
						goto IL_0030;
					}
				}
				if (byte_0[8] == 83)
				{
					flag = byte_0[9] != 82;
					goto IL_0031;
				}
				IL_0030:
				flag = true;
				IL_0031:
				if (flag)
				{
					bool flag2;
					if (byte_0[7] == 83 && byte_0[8] == 84)
					{
						if (byte_0[9] == 68 || byte_0[9] == 65)
						{
							flag2 = false;
							goto IL_005B;
						}
					}
					if (byte_0[7] != 76)
					{
						if (byte_0[7] != 49)
						{
							goto IL_005A;
						}
					}
					if (byte_0[8] == 83)
					{
						flag2 = byte_0[9] != 68;
						goto IL_005B;
					}
					IL_005A:
					flag2 = true;
					IL_005B:
					if (flag2)
					{
						if (byte_0[7] != 80 || byte_0[8] != 82 || (byte_0[9] != 79 && byte_0[9] != 48 && byte_0[9] != 70))
						{
							if (byte_0[7] != 80 || byte_0[8] != 70 || (byte_0[9] != 76 && byte_0[9] != 49))
							{
								if (byte_0[7] != 69 || byte_0[8] != 78 || byte_0[9] != 84)
								{
									if (byte_0[7] != 69 || byte_0[8] != 78 || byte_0[9] != 80)
									{
										if (bool_0)
										{
											if (byte_0[8] == 83 && byte_0[9] == 68)
											{
												return new int[] { 10, 1 };
											}
											if (byte_0[8] == 80 && byte_0[9] == 70)
											{
												return new int[] { 25, 1 };
											}
											if (byte_0[8] == 69 && byte_0[9] == 84)
											{
												return new int[] { 100, 1 };
											}
											if (byte_0[8] == 85 && (byte_0[9] == 76 || byte_0[9] == 49))
											{
												return new int[] { 999, 1 };
											}
										}
										int[] array = new int[2];
										array[0] = -1;
										array2 = array;
									}
									else
									{
										array2 = new int[] { 100, 1 };
									}
								}
								else
								{
									int[] array = new int[2];
									array[0] = 100;
									array2 = array;
								}
							}
							else
							{
								array2 = new int[] { 25, 1 };
							}
						}
						else
						{
							int[] array = new int[2];
							array[0] = 25;
							array2 = array;
						}
					}
					else
					{
						int[] array = new int[2];
						array[0] = 10;
						array2 = array;
					}
				}
				else
				{
					int[] array = new int[2];
					array[0] = 1;
					array2 = array;
				}
			}
			else
			{
				int[] array = new int[2];
				array[0] = -1;
				array2 = array;
			}
			return array2;
		}

		// Token: 0x06013444 RID: 78916 RVA: 0x0076DE48 File Offset: 0x0076C048
		private bool bL(byte[] byte_0)
		{
			bool flag3;
			if (byte_0 != null && byte_0.Length > 0)
			{
				if (!this.oUk(byte_0))
				{
					bool flag;
					if (byte_0.Length > 13 && byte_0[10] == 67)
					{
						if (byte_0[11] != 79)
						{
							if (byte_0[11] != 48)
							{
								goto IL_0019;
							}
						}
						if (byte_0[12] == 82)
						{
							flag = byte_0[13] != 69;
							goto IL_001A;
						}
					}
					IL_0019:
					flag = true;
					IL_001A:
					if (!flag)
					{
						return true;
					}
				}
				else
				{
					bool flag2;
					if (byte_0.Length > 20 && byte_0[17] == 67)
					{
						if (byte_0[18] != 79)
						{
							if (byte_0[18] != 48)
							{
								goto IL_0039;
							}
						}
						if (byte_0[19] == 82)
						{
							flag2 = byte_0[20] != 69;
							goto IL_003A;
						}
					}
					IL_0039:
					flag2 = true;
					IL_003A:
					if (!flag2)
					{
						return true;
					}
				}
				flag3 = false;
			}
			else
			{
				flag3 = false;
			}
			return flag3;
		}

		// Token: 0x06013445 RID: 78917 RVA: 0x0076DF00 File Offset: 0x0076C100
		private bool bi(byte[] byte_0)
		{
			bool flag3;
			if (byte_0 != null && byte_0.Length > 0)
			{
				if (!this.oUk(byte_0))
				{
					bool flag;
					if (byte_0.Length > 13 && byte_0[10] == 85)
					{
						if (byte_0[11] != 76)
						{
							if (byte_0[11] != 49)
							{
								goto IL_0019;
							}
						}
						if (byte_0[12] == 84)
						{
							flag = byte_0[13] != 68;
							goto IL_001A;
						}
					}
					IL_0019:
					flag = true;
					IL_001A:
					if (!flag)
					{
						return true;
					}
				}
				else
				{
					bool flag2;
					if (byte_0.Length > 20 && byte_0[17] == 85)
					{
						if (byte_0[18] != 76)
						{
							if (byte_0[18] != 49)
							{
								goto IL_0039;
							}
						}
						if (byte_0[19] == 84)
						{
							flag2 = byte_0[20] != 68;
							goto IL_003A;
						}
					}
					IL_0039:
					flag2 = true;
					IL_003A:
					if (!flag2)
					{
						return true;
					}
				}
				flag3 = false;
			}
			else
			{
				flag3 = false;
			}
			return flag3;
		}

		// Token: 0x06013446 RID: 78918 RVA: 0x0076DFB8 File Offset: 0x0076C1B8
		private string[] bn(byte[] byte_0)
		{
			string[] array;
			if (byte_0 != null)
			{
				int num = ((!this.oUk(byte_0)) ? 10 : 17);
				if (byte_0.Length > num)
				{
					array = guQ.c(Eyf.Ix(byte_0, num, byte_0.Length - num));
				}
				else
				{
					array = new string[0];
				}
			}
			else
			{
				array = new string[0];
			}
			return array;
		}

		// Token: 0x06013447 RID: 78919 RVA: 0x0076A0B8 File Offset: 0x007682B8
		private static string bV(int int_0)
		{
			return (int_0 == 1) ? "connection" : "port";
		}

		// Token: 0x06013448 RID: 78920 RVA: 0x0076E00C File Offset: 0x0076C20C
		private int bt(byte[] byte_0, string string_0)
		{
			int num2;
			if (byte_0 != null && string_0 != null && string_0.Length > 0)
			{
				string_0 = gPf.f(string_0);
				int num = ((!this.oUk(byte_0)) ? 10 : 17);
				if (byte_0.Length >= num + string_0.Length + 3)
				{
					string text = Eyf.Ix(byte_0, num, byte_0.Length - num);
					byte[] array = new byte[byte_0.Length - num];
					lyc.E(byte_0, num, array, 0, 0);
					num = text.IndexOf(string_0);
					if (num >= 0 && array.Length >= num + string_0.Length + 3)
					{
						num += 3;
						if (!char.IsDigit((char)array[num]) || !char.IsDigit((char)array[num + 1]) || !char.IsDigit((char)array[num + 2]))
						{
							num2 = -1;
						}
						else
						{
							num2 = (int)(100 * (array[num] - 48) + 10 * (array[num + 1] - 48) + (array[num + 2] - 48));
						}
					}
					else
					{
						num2 = -1;
					}
				}
				else
				{
					num2 = -1;
				}
			}
			else
			{
				num2 = -1;
			}
			return num2;
		}

		// Token: 0x06013449 RID: 78921 RVA: 0x0076E104 File Offset: 0x0076C304
		private static int bK(int int_0, int int_1, int int_2, bool bool_0)
		{
			int num;
			if (int_0 <= -1)
			{
				if (int_1 != 0)
				{
					if (int_1 != 1)
					{
						if (int_1 != 10)
						{
							if (int_1 != 25)
							{
								if (int_1 != 100)
								{
									if (int_1 < 999)
									{
										num = 0;
									}
									else
									{
										num = 999;
									}
								}
								else
								{
									num = ((!bool_0) ? ((int_2 != 0) ? 100 : 999) : 150);
								}
							}
							else
							{
								num = ((bool_0 || int_2 != 0) ? 100 : 999);
							}
						}
						else
						{
							num = 10;
						}
					}
					else
					{
						num = 2;
					}
				}
				else
				{
					num = 1;
				}
			}
			else
			{
				num = int_0;
			}
			return num;
		}

		// Token: 0x0601344A RID: 78922 RVA: 0x0076E19C File Offset: 0x0076C39C
		private static int bW(int int_0, int int_1, int int_2, bool bool_0)
		{
			int num;
			if (int_0 <= -1)
			{
				if (!bool_0)
				{
					if (int_1 != 1)
					{
						if (int_1 != 10)
						{
							if (int_1 != 25)
							{
								if (int_1 != 100)
								{
									if (int_1 < 999)
									{
										num = 0;
									}
									else
									{
										num = 999;
									}
								}
								else
								{
									num = ((int_2 != 0) ? 20 : 999);
								}
							}
							else
							{
								num = 20;
							}
						}
						else
						{
							num = 4;
						}
					}
					else
					{
						num = 0;
					}
				}
				else
				{
					num = 0;
				}
			}
			else
			{
				num = int_0;
			}
			return num;
		}

		// Token: 0x0601344B RID: 78923 RVA: 0x0076E218 File Offset: 0x0076C418
		private static int Sy(int int_0, int int_1, bool bool_0, bool bool_1)
		{
			int num;
			if (int_0 <= -1)
			{
				if (int_1 != 0)
				{
					if (int_1 != 1)
					{
						if (int_1 != 10)
						{
							if (int_1 < 25)
							{
								num = 0;
							}
							else
							{
								num = 999;
							}
						}
						else
						{
							num = ((bool_1 || !bool_0) ? 0 : 999);
						}
					}
					else
					{
						num = ((bool_1 || !bool_0) ? 0 : 999);
					}
				}
				else
				{
					num = 0;
				}
			}
			else
			{
				num = int_0;
			}
			return num;
		}

		// Token: 0x0601344C RID: 78924 RVA: 0x0076E288 File Offset: 0x0076C488
		private static int Su(int int_0, int int_1, bool bool_0)
		{
			int num;
			if (int_0 <= -1)
			{
				if (int_1 != 25)
				{
					if (int_1 != 100)
					{
						if (int_1 < 999)
						{
							num = 0;
						}
						else
						{
							num = 999;
						}
					}
					else
					{
						num = 2;
					}
				}
				else
				{
					num = 0;
				}
			}
			else
			{
				num = int_0;
			}
			return num;
		}

		// Token: 0x0601344D RID: 78925 RVA: 0x0076E2D4 File Offset: 0x0076C4D4
		private static string SA(string string_0)
		{
			string text;
			if (!Eyf.lx(string_0))
			{
				text = Eyf.Dx(string_0);
			}
			else
			{
				text = "_app_";
			}
			return text;
		}

		// Token: 0x0601344E RID: 78926 RVA: 0x0076A0DC File Offset: 0x007682DC
		private static bool Sr(bool bool_0)
		{
			try
			{
				if (HttpContext.Current != null)
				{
					return HttpContext.Current.Request.ServerVariables.Get("SERVER_SOFTWARE").StartsWith("CData Arc Web Server");
				}
			}
			catch
			{
			}
			return bool_0;
		}

		// Token: 0x0601344F RID: 78927 RVA: 0x0076E2FC File Offset: 0x0076C4FC
		internal static void SE(Egl egl_0, guB guB_0)
		{
			egl_0.t("prod", guB_0.E());
			egl_0.t("prodName", guB_0.D());
			egl_0.t("displayName", guB_0.Z());
			egl_0.t("version", guB_0.nA());
			egl_0.t("productKey", guB_0.wV());
			egl_0.H("isLicenseOK", Eyf.Dx(Eyf.Dw(guB_0.p())), false);
			egl_0.H("isbeta", Eyf.Dx(Eyf.Dw(guB_0.r())), false);
			egl_0.H("issub", Eyf.Dx(Eyf.Dw(guB_0.t())), false);
			egl_0.H("iscloud", Eyf.Dx(Eyf.Dw(guB_0.s())), false);
			egl_0.H("istrial", Eyf.Dx(Eyf.Dw(guB_0.m())), false);
			egl_0.t("licenseType", guB_0.wr());
			egl_0.H("expireDays", Eyf.DO(guB_0.y()), false);
			egl_0.t("licenseName", guB.iK(guB_0));
			if (guB_0.nu() != null)
			{
				egl_0.t("licenseError", Eyf.eD(guB_0.nu()));
			}
			if (!Eyf.lx(guB_0.nM()))
			{
				egl_0.t("licenseWarning", guB_0.nM());
			}
		}

		// Token: 0x06013450 RID: 78928 RVA: 0x0076E478 File Offset: 0x0076C678
		private static lyv<guB> SL(string string_0)
		{
			lyv<guB> lyv;
			if (!Eyf.hK(string_0, "1"))
			{
				lyv = null;
			}
			else
			{
				lyv = guo.Si();
			}
			return lyv;
		}

		// Token: 0x06013451 RID: 78929 RVA: 0x0076E4A0 File Offset: 0x0076C6A0
		private static lyv<guB> Si()
		{
			return new lyv<guB>();
		}

		// Token: 0x04008DE4 RID: 36324
		private new const string E = "|ftp|sftp|";

		// Token: 0x04008DE5 RID: 36325
		private const string U = "|database|mysql|postgresql|sqlite|derby|sqlserver|oracle|db2|";

		// Token: 0x04008DE6 RID: 36326
		private new const string i = "|as4v2|";

		// Token: 0x04008DE7 RID: 36327
		private const string v = "SUB_EXPIRING_TYPE";

		// Token: 0x04008DE8 RID: 36328
		private const string M = "RAW_MASKED_SERIAL_NUMBER";

		// Token: 0x04008DE9 RID: 36329
		private new const string S = "AS2_ONLY";

		// Token: 0x04008DEA RID: 36330
		private new const string f = "SPECIAL_COUNT";

		// Token: 0x04008DEB RID: 36331
		private const string o = "APP_PROD";

		// Token: 0x04008DEC RID: 36332
		private new const string D = "ALLOW_TRIAL_ACTIVATE";

		// Token: 0x04008DED RID: 36333
		private const string h = "LICENSED_DEPRECATED_SINGLE_CONNECTOR_TYPES";

		// Token: 0x04008DEE RID: 36334
		private new const int w = -1;

		// Token: 0x04008DEF RID: 36335
		private new const int x = 999;

		// Token: 0x04008DF0 RID: 36336
		private new const string K = "INVALID_CONNECTOR_TYPE";

		// Token: 0x04008DF1 RID: 36337
		private new const string t = "*";

		// Token: 0x04008DF2 RID: 36338
		private static lmD<string, int> R = new lmD<string, int>();

		// Token: 0x04008DF3 RID: 36339
		private new static lmD<string, bool> y = new lmD<string, bool>();

		// Token: 0x04008DF4 RID: 36340
		private new RSBContext b = null;

		// Token: 0x04008DF5 RID: 36341
		private new static lmD<string, lyv<guB>> q = new lmD<string, lyv<guB>>();

		// Token: 0x04008DF6 RID: 36342
		private new readonly gPm L = new gPm("|as4v2|", false);

		// Token: 0x04008DF7 RID: 36343
		private new long C = 0L;

		// Token: 0x04008DF8 RID: 36344
		private static object g = new object();
	}
}
