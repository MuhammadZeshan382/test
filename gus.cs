using System;
using System.IO;
using System.Reflection;
using System.Web;
using RSSBus;

namespace Arc264y
{
	// Token: 0x020014AE RID: 5294
	internal sealed class gus : gui, guh
	{
		// Token: 0x060133E8 RID: 78824 RVA: 0x0007C4F6 File Offset: 0x0007A6F6
		public void ovl(RSBContext rsbcontext_0)
		{
			this.i = lZh.Pu(rsbcontext_0, "ArcCNLicenseHandler");
		}

		// Token: 0x060133E9 RID: 78825 RVA: 0x00768690 File Offset: 0x00766890
		public void ovb(RSBContext rsbcontext_0, bool bool_0, bool bool_1)
		{
			guB guB = this.KK();
			guB.iS(Eyf.UB(rsbcontext_0.GetInput("langinvariant"), false));
			RSBException ex = null;
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
				rsbcontext_0.SetOutput("noLicenseInfo", Eyf.Dw(Eyf.lx(guB.iL()) || !Ecg.MG(guB.iL())));
				rsbcontext_0.SetOutput("isfree", Eyf.Dw(guB.nn()));
				rsbcontext_0.SetOutput("isfixed", Eyf.Dw(giw.wr("license")));
				rsbcontext_0.SetOutput("maxports", Eyf.Dt(guB.nR()));
				rsbcontext_0.SetOutput("limittype", Eyf.Dt(guB.nT()));
				rsbcontext_0.SetOutput("expiringtype", Eyf.Dt(guB.nX()));
				rsbcontext_0.SetOutput("allowtrialactivate", Eyf.Dw(gui.bE()));
				rsbcontext_0.SetOutput("mftconnectorscount", Eyf.Dt(guB.nK()));
				rsbcontext_0.SetOutput("createdconnectortypes", guB.ij());
				rsbcontext_0.SetOutput("isas2only", Eyf.Dw(guB.iq()));
				rsbcontext_0.SetOutput("licensefeatures", guQ.r(guB));
				if (guB.nu() != null)
				{
					ex = guB.nu();
				}
				lock (gus.l)
				{
					gus.W = guB;
				}
				rsbcontext_0.PushItem();
			}
			if (!bool_1 && ex != null)
			{
				throw ex;
			}
		}

		// Token: 0x060133EA RID: 78826 RVA: 0x0076897C File Offset: 0x00766B7C
		public string ovM()
		{
			Egl egl = new Egl();
			egl.Q();
			guB guB = this.KK();
			if (guB != null && Eyf.hK(guB.D(), "Arc"))
			{
				lock (gus.l)
				{
					gus.W = guB;
					goto IL_0020;
				}
				goto IL_0390;
			}
			IL_0020:
			if (guB != null)
			{
				goto IL_0390;
			}
			bool flag2 = false;
			IL_0027:
			if (flag2)
			{
				egl.H("noLicenseInfo", "false", false);
				guo.SE(egl, guB);
				egl.H("isfree", Eyf.Dx(Eyf.Dw(guB.nn())), false);
				egl.H("isfixed", Eyf.Dx(Eyf.Dw(giw.wr("license"))), false);
				egl.H("isas2only", Eyf.Dx(Eyf.Dw(guB.iq())), false);
				egl.H("allowtrialactivate", Eyf.Dx(Eyf.Dw(gui.bE())), false);
				egl.t("limittype", Eyf.Dt(guB.nT()));
				egl.t("expiringtype", Eyf.Dt(guB.nX()));
				egl.t("nodeId", lXu.mz());
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
				egl.Q().t("name", "FreePorts").t("displayName", "Free Connectors")
					.H("count", Eyf.DO(guB.ip()), false)
					.H("total", "999", false)
					.f();
				egl.Q().t("name", "Ports").t("displayName", "Connectors")
					.H("count", Eyf.DO(guB.nK()), false)
					.H("total", Eyf.DO(guB.nR()), false)
					.f();
				egl.A();
			}
			else
			{
				egl.H("noLicenseInfo", "true", false);
			}
			egl.f();
			return egl.ToString();
			IL_0390:
			flag2 = guB.x();
			goto IL_0027;
		}

		// Token: 0x060133EB RID: 78827 RVA: 0x00768D78 File Offset: 0x00766F78
		public void ovJ(string string_0)
		{
			RSBException ex = null;
			guB guB = null;
			if (!lZh.e)
			{
				lock (gus.l)
				{
					if (gus.W != null && gus.W.pA())
					{
						guB = gus.W;
					}
					goto IL_000B;
				}
				goto IL_0079;
			}
			IL_000B:
			if (guB == null)
			{
				goto IL_0079;
			}
			IL_0014:
			if (guB.nu() != null)
			{
				ex = guB.nu();
			}
			if (gus.W != guB)
			{
				lock (gus.l)
				{
					if (gus.W != guB)
					{
						gus.W = guB;
					}
					goto IL_0029;
				}
				goto IL_00BF;
			}
			IL_0029:
			if (ex == null)
			{
				return;
			}
			IL_00BF:
			throw ex;
			IL_0079:
			guB = this.KK();
			goto IL_0014;
		}

		// Token: 0x060133EC RID: 78828 RVA: 0x00768E64 File Offset: 0x00767064
		public void ovF(string string_0, int int_0)
		{
			this.ovJ(null);
			if (int_0 > 0)
			{
				int num = Eyf.CF(rrc.sf("MAX_PORTS"), -1);
				if (num < 999)
				{
					gPX gPX = this.B(true);
					gPX.m(string_0, int_0);
					if (gus.KT(gus.KB(gPX), num))
					{
						throw new RSBException("License", "The current license for this application has reached the maximum amount of allowed connector configurations. You must upgrade your license to add additional connector configurations.");
					}
					this.X.x();
				}
			}
		}

		// Token: 0x060133ED RID: 78829 RVA: 0x000440D5 File Offset: 0x000422D5
		public void ovo(string string_0, int int_0)
		{
		}

		// Token: 0x060133EE RID: 78830 RVA: 0x00768EDC File Offset: 0x007670DC
		public gPc ovh(gPy gPy_0)
		{
			Eyf.Fn<gPy>(gPy_0, "LicenseUsageChanges", new object[0]);
			this.ovJ(null);
			int num = Eyf.CF(rrc.sf("MAX_PORTS"), -1);
			gPX gPX = this.B(true);
			gPc gPc = new gPc();
			gPc.u(gus.K(gPX, gPX.E(gPy_0), num));
			return gPc;
		}

		// Token: 0x060133EF RID: 78831 RVA: 0x00768F38 File Offset: 0x00767138
		internal static gPg K(gPX gPX_0, gPX gPX_1, int int_0)
		{
			int num = gus.KB(gPX_1);
			return new gPg("Ports", gus.KB(gPX_0), num, int_0, int_0 < 999 && gus.KT(num, int_0));
		}

		// Token: 0x060133F0 RID: 78832 RVA: 0x00768F74 File Offset: 0x00767174
		public void ovg(string string_0, string string_1)
		{
			if (gPm.E(string_0))
			{
				this.Q(true);
			}
		}

		// Token: 0x060133F1 RID: 78833 RVA: 0x00768F94 File Offset: 0x00767194
		protected internal lmr<gPr> Q(bool bool_0)
		{
			return this.X.u(bool_0);
		}

		// Token: 0x060133F2 RID: 78834 RVA: 0x00768FB0 File Offset: 0x007671B0
		private gPX B(bool bool_0)
		{
			lmr<gPr> lmr = this.Q(bool_0);
			return new gPX(lmr, this.X.y(bool_0), gPm.f());
		}

		// Token: 0x060133F3 RID: 78835 RVA: 0x00768FE0 File Offset: 0x007671E0
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
						this.x(pzh);
						pzh.JXe(1);
						pzh.HN(0L);
						pzh.om(text5 + text2);
						text4 = Eyf.Im(pzh.Hy());
					}
					catch (Exception ex)
					{
						throw new RSBException("InstallLicense", "Unable to install license. Please check your product key." + Eyf.eD(ex), ex);
					}
					this.E(text4, text3, flag);
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

		// Token: 0x060133F4 RID: 78836 RVA: 0x007692D8 File Offset: 0x007674D8
		public void E(string string_0, string string_1, bool bool_0)
		{
			if (Eyf.lx(string_0) || string_0.IndexOf("REGEDIT") < 0)
			{
				throw new RSBException("InstallLicense", "Unable to install license. Please check your product key.");
			}
			string text = gPf.j(string_1);
			Eyf.VJ(string_0, text, false);
		}

		// Token: 0x060133F5 RID: 78837 RVA: 0x00769320 File Offset: 0x00767520
		public void f(string string_0, bool bool_0)
		{
			try
			{
				Eyf.pI(gPf.j(string_0));
			}
			finally
			{
			}
		}

		// Token: 0x060133F6 RID: 78838 RVA: 0x0076934C File Offset: 0x0076754C
		public void ovv(string string_0, bool bool_0)
		{
			string productKey = guB.ih(string_0);
			bool useCloudLicenseFile = false;
			if (Eyf.UK(productKey, "x", true))
			{
				byte[] keyBytes = Eyf.IV(gPf.f(productKey).Substring(1));
				useCloudLicenseFile = this.oUk(keyBytes) && this.oUz(keyBytes);
			}
			guB product = guB.iM(productKey);
			string licenseFileName = gPf.G(product.D(), useCloudLicenseFile ? 1 : 2);
			bool isAppLicense = Eyf.hK(product.E(), "AZYNA");
			if (bool_0 && !isAppLicense)
			{
				throw new RSBException("InstallLicense", Eyf.OS("License is not for {0}.", "CData Arc"));
			}

			this.E(string_0, licenseFileName, isAppLicense);
			if (!bool_0)
			{
				return;
			}

			guB installedLicense = this.KK();
			if (installedLicense.nu() == null)
			{
				return;
			}

			try
			{
				this.f(licenseFileName, isAppLicense);
			}
			catch (Exception)
			{
				// Preserve the validation error if removing the rejected upload fails.
			}
			throw installedLicense.nu();
		}

		// Token: 0x060133F7 RID: 78839 RVA: 0x00769440 File Offset: 0x00767640
		private void x(PZh pzh_0)
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

		// Token: 0x060133F8 RID: 78840 RVA: 0x00769598 File Offset: 0x00767798
		public void ovS(string string_0, guB guB_0)
		{
			if (!Eyf.lx(string_0))
			{
				byte[] array = Eyf.IV("AIYGAS070320" + string_0);
				bool flag;
				if (!(flag = this.oUk(array)))
				{
					array = Eyf.IV(string_0);
				}
				guB_0.IV(flag);
				guB_0.Iu(true);
				if (!rrh.K(array) && !this.ovC(array))
				{
					if (!this.oUd(array))
					{
						guB_0.Iy(999);
						guB_0.nj(this.Kh(array));
						guB_0.ni(false);
						guB_0.nL(this.ova(array));
					}
					else
					{
						guB_0.Iy(0);
						guB_0.nj(1);
						guB_0.ni(true);
						guB_0.nL(this.ova(array));
					}
				}
				else
				{
					guB_0.Iy(999);
					guB_0.Ir(true);
					guB_0.nj(999);
				}
			}
		}

		// Token: 0x060133F9 RID: 78841 RVA: 0x00769678 File Offset: 0x00767878
		public bool c()
		{
			try
			{
				string text = this.oUw();
				if (text != null && Eyf.Vx(text))
				{
					string text2 = Eyf.YO(text);
					return !Eyf.lx(text2) && text2.IndexOf("@=\"XSUC") > 0;
				}
				return false;
			}
			catch (Exception)
			{
			}
			return false;
		}

		// Token: 0x060133FA RID: 78842 RVA: 0x007696D8 File Offset: 0x007678D8
		public static bool KN(string string_0)
		{
			return !Eyf.lx(string_0) && Eyf.UK(string_0, "XSUC", true);
		}

		// Token: 0x060133FB RID: 78843 RVA: 0x007696FC File Offset: 0x007678FC
		protected internal override string oUI()
		{
			return "AZYNA";
		}

		// Token: 0x060133FC RID: 78844 RVA: 0x00769710 File Offset: 0x00767910
		protected internal override char oUq()
		{
			return 'N';
		}

		// Token: 0x060133FD RID: 78845 RVA: 0x00769720 File Offset: 0x00767920
		protected internal override string oUN()
		{
			return "知行之桥 20" + Eyf.DO(26);
		}

		// Token: 0x060133FE RID: 78846 RVA: 0x00769740 File Offset: 0x00767940
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

		// Token: 0x060133FF RID: 78847 RVA: 0x0007C509 File Offset: 0x0007A709
		protected internal override void oUe(byte[] byte_0)
		{
			mcy.c(byte_0);
		}

		// Token: 0x06013400 RID: 78848 RVA: 0x000FBD30 File Offset: 0x000F9F30
		protected internal override bool oUT()
		{
			return true;
		}

		// Token: 0x06013401 RID: 78849 RVA: 0x007697C4 File Offset: 0x007679C4
		protected internal override bool oUk(byte[] byte_0)
		{
			return byte_0 != null && (byte_0.Length > 14 && byte_0[12] == 83 && byte_0[13] == 85) && byte_0[14] == 67;
		}

		// Token: 0x06013402 RID: 78850 RVA: 0x007697FC File Offset: 0x007679FC
		protected internal override bool oUY(int int_0, byte[] byte_0, string string_0)
		{
			return int_0 == 6 && byte_0 == null && string_0 != null && string_0.Length >= 5 && (string_0[0] == 'X' && string_0[1] == 'S' && string_0[2] == 'U') && string_0[3] == 'C';
		}

		// Token: 0x06013403 RID: 78851 RVA: 0x00769860 File Offset: 0x00767A60
		protected internal override bool oUd(byte[] byte_0)
		{
			bool flag;
			if (byte_0 != null)
			{
				int num = ((!this.oUk(byte_0)) ? 7 : 19);
				flag = byte_0.Length > num + 2 && (byte_0[num] == 65 && byte_0[num + 1] == 80) && byte_0[num + 2] == 84;
			}
			else
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x06013404 RID: 78852 RVA: 0x007698B8 File Offset: 0x00767AB8
		protected internal override int oUR(byte[] byte_0)
		{
			int num;
			if (byte_0 == null || byte_0.Length <= 11)
			{
				num = -1;
			}
			else
			{
				num = lXu.pp(2000 + (int)(10 * (byte_0[10] - 48)) + (int)(byte_0[11] - 48), (int)(10 * (byte_0[6] - 48) + (byte_0[7] - 48)), (int)(10 * (byte_0[8] - 48) + (byte_0[9] - 48)));
			}
			return num;
		}

		// Token: 0x06013405 RID: 78853 RVA: 0x0009ABDC File Offset: 0x00098DDC
		protected internal override bool oUz(byte[] byte_0)
		{
			return false;
		}

		// Token: 0x06013406 RID: 78854 RVA: 0x001861EC File Offset: 0x001843EC
		protected internal override int ova(byte[] byte_0)
		{
			return 0;
		}

		// Token: 0x06013407 RID: 78855 RVA: 0x0076991C File Offset: 0x00767B1C
		protected internal override bool ovC(byte[] byte_0)
		{
			return byte_0 != null && byte_0.Length >= 22 && byte_0[18] == 89 && byte_0[19] == 84 && byte_0[20] == 82 && (byte_0[21] == 76 || byte_0[21] == 49);
		}

		// Token: 0x06013408 RID: 78856 RVA: 0x00769964 File Offset: 0x00767B64
		public int ovX(string string_0, bool bool_0)
		{
			return guo.bu(string_0, bool_0);
		}

		// Token: 0x06013409 RID: 78857 RVA: 0x0076997C File Offset: 0x00767B7C
		private guB KK()
		{
			guB guB = this.KQ();
			bool flag = false;
			try
			{
				flag = gui.bE();
			}
			catch (RSBException)
			{
			}
			if (!lZh.e)
			{
				rrc.sm(guB.wr());
			}
			rrc.sl(guB.x());
			rrc.sK("MAX_PORTS", Eyf.Dt(guB.nR()));
			rrc.sK("SUB_EXPIRING_TYPE", Eyf.Dt(guB.nX()));
			rrc.sK("RAW_MASKED_SERIAL_NUMBER", guB.wm());
			rrc.sK("APP_PROD", Eyf.DF(guB.E()));
			rrc.sK("ALLOW_TRIAL_ACTIVATE", Eyf.Dw(flag));
			rrc.sK("BETA_CONNECTOR_EXPIRE_DAYS", Eyf.DO(rrh.H(1802304000L)));
			rrc.sV(guB.wV());
			rrc.sE(guB.r());
			rrc.sQ(guB.t());
			rrc.sY(guB.s());
			rrc.sp(guB.m());
			rrc.sm(guB.wr());
			rrc.sa(guB.y());
			rrc.sK("NO_COUNT_CONNECTORS", "|branch|copy|file|filematch|headermatch|merge|schedule|split|xmlmatch|workspacesend|workspacereceive|validate|notify|batchcreate|batchsplit|batchmerge|encoding|");
			return guB;
		}

		// Token: 0x0601340A RID: 78858 RVA: 0x00769AA8 File Offset: 0x00767CA8
		private guB KQ()
		{
			guB guB = new guB("Arc", "AZYNA", "知行之桥 20" + Eyf.DO(26), "26.4.9813.0");
			int num = -1;
			int num2 = 0;
			int num3 = 0;
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			string[] array = new string[] { "[NO-VALID-LICENSE]" };
			string text = array[0];
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			string text2 = null;
			string text3 = null;
			try
			{
				byte[][] array2 = new byte[1][];
				text3 = this.oUw();
				base.A(array, array2);
				guB.pn(text3, guB.Y);
				byte[] array3 = array2[0];
				text = array[0];
				if (!rrh.K(array3))
				{
					if (!this.ovC(array3))
					{
						num4 = this.ova(array3);
						num5 = base.i(array3);
						if (!this.oUd(array3))
						{
							num2 = this.Kh(array3);
							num = 999;
							flag = false;
						}
						else
						{
							num2 = 1;
							num = 0;
							flag = true;
						}
						if (this.oUk(array3))
						{
							flag2 = true;
							num3 = base.Q(array3);
							if (num3 <= 0)
							{
								throw new RSBException("License", Eyf.OS("The subscription license has expired for this product.  The product will not continue functioning as expected.  To avoid any disruptions in service please contact {0} immediately.", "arcsales@cdata.com"));
							}
						}
					}
					else
					{
						flag4 = true;
						flag = false;
						num3 = base.Q(array3);
						num2 = 999;
						num = 999;
						if (num3 <= 0)
						{
							throw new RSBException("License", Eyf.IB("This system contains a license for {0} that has expired.  Please visit {1} or email {2} for information on purchasing a license or extending your license", false, new object[]
							{
								this.oUN(),
								"arc.cdata.com",
								"arcsales@cdata.com"
							}));
						}
					}
				}
				else
				{
					flag4 = true;
					flag = false;
					text += lXu.mz();
					num3 = base.Q(array3);
					array[0] = Eyf.OS("[30 DAY TRIAL VERSION - {0} DAYS LEFT]", Eyf.Dt(num3));
					num2 = 999;
					num = 999;
				}
				if (num < 100 && giw.jb() > 1)
				{
					throw new RSBException("License", Eyf.IB("The installed license does not allow the current advanced login mode. Please contact {0} to acquire a license that enables this feature.", true, new object[] { "arcsales@cdata.com" }));
				}
				if (flag && !rrv.w && !gus.KE(true))
				{
					throw new RSBException("License", "This version of the Arc only works with the embedded server. To host the Arc in another environment, please upgrade your license.");
				}
				lmr<gPr> lmr = null;
				try
				{
					lmr = this.Q(false);
				}
				catch (Exception ex)
				{
					throw new RSBException("License", Eyf.eD(ex), ex);
				}
				gPX gPX = new gPX(lmr, null, gPm.f());
				lyv<string> lyv = gPX.K();
				text2 = Eyf.xn(",", Eyf.On(lyv));
				num6 = gus.KB(gPX);
				num7 = gus.KI(gPX);
				if (num2 < 999 && gus.KT(num6, num2))
				{
					throw new RSBException("License", Eyf.Oq("Only {0} {1} {2}(s) are supported by this license. Please contact {3} to enable support for more {4} configurations.", new string[]
					{
						Eyf.Dt(num2),
						gus.Km(num4),
						"",
						"arcsales@cdata.com",
						gus.Km(num4)
					}));
				}
			}
			catch (RSBException ex2)
			{
				guB.nE(ex2);
			}
			finally
			{
				guB.Iu(!Eyf.lx(text3) && Ecg.MG(text3));
				guB.ni(flag);
				guB.nL(num4);
				guB.nj(num2);
				guB.nb(num5);
				guB.IE(array[0]);
				guB.IG(text);
				guB.Ix(flag3);
				guB.IV(flag2);
				guB.Ir(flag4);
				guB.Iy(num);
				guB.In(num3);
				guB.nh(num6);
				guB.iO(num7);
				guB.iu(text2);
				guB.iX(text3);
			}
			return guB;
		}

		// Token: 0x0601340B RID: 78859 RVA: 0x00769ED8 File Offset: 0x007680D8
		private static bool KT(int int_0, int int_1)
		{
			return int_0 > int_1;
		}

		// Token: 0x0601340C RID: 78860 RVA: 0x00769EEC File Offset: 0x007680EC
		private static int KB(gPX gPX_0)
		{
			int num = 0;
			lyv<string> lyv = gPX_0.K();
			int num2 = 0;
			while (lyv != null && num2 < lyv.W())
			{
				if (!gus.KS(lyv.j(num2)))
				{
					num++;
				}
				num2++;
			}
			return num + gPX_0.D();
		}

		// Token: 0x0601340D RID: 78861 RVA: 0x00769F3C File Offset: 0x0076813C
		private static int KI(gPX gPX_0)
		{
			int num = 0;
			lyv<string> lyv = gPX_0.K();
			int num2 = 0;
			while (lyv != null && num2 < lyv.W())
			{
				if (gus.KS(lyv.j(num2)))
				{
					num++;
				}
				num2++;
			}
			return num;
		}

		// Token: 0x0601340E RID: 78862 RVA: 0x00769F88 File Offset: 0x00768188
		public static bool KS(string string_0)
		{
			bool flag;
			if (!Eyf.lx(string_0))
			{
				string_0 = "|" + Eyf.Dx(string_0) + "|";
				flag = "|branch|copy|file|filematch|headermatch|merge|schedule|split|xmlmatch|workspacesend|workspacereceive|validate|notify|batchcreate|batchsplit|batchmerge|encoding|".Contains(string_0);
			}
			else
			{
				flag = true;
			}
			return flag;
		}

		// Token: 0x0601340F RID: 78863 RVA: 0x00769FD4 File Offset: 0x007681D4
		private int Kh(byte[] byte_0)
		{
			int num2;
			if (byte_0 != null)
			{
				if (!this.oUd(byte_0))
				{
					int num = 0;
					if (!this.oUk(byte_0) || byte_0.Length <= 21 || !char.IsDigit((char)byte_0[19]) || !char.IsDigit((char)byte_0[20]) || !char.IsDigit((char)byte_0[21]))
					{
						if (byte_0.Length > 9 && char.IsDigit((char)byte_0[7]) && char.IsDigit((char)byte_0[8]) && char.IsDigit((char)byte_0[9]))
						{
							num = (int)(100 * (byte_0[7] - 48) + 10 * (byte_0[8] - 48) + (byte_0[9] - 48));
						}
					}
					else
					{
						num = (int)(100 * (byte_0[19] - 48) + 10 * (byte_0[20] - 48) + (byte_0[21] - 48));
					}
					num2 = num;
				}
				else
				{
					num2 = 1;
				}
			}
			else
			{
				num2 = 0;
			}
			return num2;
		}

		// Token: 0x06013410 RID: 78864 RVA: 0x0076A0B8 File Offset: 0x007682B8
		private static string Km(int int_0)
		{
			return (int_0 == 1) ? "connection" : "port";
		}

		// Token: 0x06013411 RID: 78865 RVA: 0x0076A0DC File Offset: 0x007682DC
		private static bool KE(bool bool_0)
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

		// Token: 0x04008DD8 RID: 36312
		private new const string e = "|branch|copy|file|filematch|headermatch|merge|schedule|split|xmlmatch|workspacesend|workspacereceive|validate|notify|batchcreate|batchsplit|batchmerge|encoding|";

		// Token: 0x04008DD9 RID: 36313
		private const string M = "SUB_EXPIRING_TYPE";

		// Token: 0x04008DDA RID: 36314
		private new const string j = "RAW_MASKED_SERIAL_NUMBER";

		// Token: 0x04008DDB RID: 36315
		private new const string G = "APP_PROD";

		// Token: 0x04008DDC RID: 36316
		private new const string a = "ALLOW_TRIAL_ACTIVATE";

		// Token: 0x04008DDD RID: 36317
		private new const int F = 999;

		// Token: 0x04008DDE RID: 36318
		private new RSBContext i = null;

		// Token: 0x04008DDF RID: 36319
		private new static guB W = null;

		// Token: 0x04008DE0 RID: 36320
		private new readonly gPm X = new gPm(null, true);

		// Token: 0x04008DE1 RID: 36321
		private static object l = new object();
	}
}
