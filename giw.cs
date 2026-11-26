using System;
using System.Configuration;
using System.Data.Common;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Web.Configuration;
using System.Web.Hosting;
using System.Xml;
using Microsoft.VisualBasic.Devices;
using RSSBus;

namespace Arc264y
{
	// Token: 0x0200193C RID: 6460
	public class giw
	{
		// Token: 0x06015311 RID: 86801 RVA: 0x00863B10 File Offset: 0x00861D10
		public static string j()
		{
			return giw.z;
		}

		// Token: 0x06015312 RID: 86802 RVA: 0x00863B24 File Offset: 0x00861D24
		public static string Q()
		{
			return giw.ho;
		}

		// Token: 0x06015313 RID: 86803 RVA: 0x00863B38 File Offset: 0x00861D38
		public static string H()
		{
			return giw.hL;
		}

		// Token: 0x06015314 RID: 86804 RVA: 0x00863B4C File Offset: 0x00861D4C
		public static string D()
		{
			return giw.hX;
		}

		// Token: 0x06015315 RID: 86805 RVA: 0x00863B60 File Offset: 0x00861D60
		public static string p()
		{
			if (giw.hi != null)
			{
				throw giw.hi;
			}
			return giw.hh;
		}

		// Token: 0x06015316 RID: 86806 RVA: 0x00863B84 File Offset: 0x00861D84
		public static string c()
		{
			if (giw.hd == null)
			{
				string text;
				if (!Eyf.lx(giw.hb))
				{
					text = giw.hb;
				}
				else
				{
					text = giw.p();
				}
				return text;
			}
			throw giw.hd;
		}

		// Token: 0x06015317 RID: 86807 RVA: 0x00863BC0 File Offset: 0x00861DC0
		public static bool m()
		{
			return null != giw.hy && Ecg.Mt(giw.hy) && Ecg.Mi(giw.hy);
		}

		// Token: 0x06015318 RID: 86808 RVA: 0x00863BF8 File Offset: 0x00861DF8
		public static string bj()
		{
			return giw.hy;
		}

		// Token: 0x06015319 RID: 86809 RVA: 0x00863C0C File Offset: 0x00861E0C
		public static string bQ(string string_0)
		{
			if (giw.hS == null && null != giw.hy && giw.m())
			{
				giw.hS = giw.bi(giw.hy, giw.hu, string_0);
			}
			return giw.hS;
		}

		// Token: 0x0601531A RID: 86810 RVA: 0x00863C58 File Offset: 0x00861E58
		public static void bH(string string_0)
		{
			if (!Eyf.lx(string_0))
			{
				if (!giw.m())
				{
					throw new lwZ("MasterEncryptionKey", "Master key file is not configured.", new object[0]);
				}
				lock (giw.W)
				{
					giw.hS = giw.bD(giw.hy, giw.hu, giw.p(), string_0);
					giw.hV = null;
					return;
				}
			}
			throw new lwZ("MasterEncryptionKey", "Master encryption key cannot be null.", new object[0]);
		}

		// Token: 0x0601531B RID: 86811 RVA: 0x00863CF4 File Offset: 0x00861EF4
		private static string bi(string string_0, string string_1, string string_2)
		{
			return giw.bD(string_0, string_1, string_2, null);
		}

		// Token: 0x0601531C RID: 86812 RVA: 0x00863D0C File Offset: 0x00861F0C
		private static string bD(string string_0, string string_1, string string_2, string string_3)
		{
			if (Ecg.MW(string_2))
			{
				rDr rDr = null;
				lPf lPf = null;
				if (!Eyf.hB(string_0, ".pfx", true))
				{
					string text = null;
					try
					{
						text = Ecg.Gi(string_0);
					}
					catch (IOException ex)
					{
						throw new lwZ("MasterEncryptionKey", "Cannot load user master key: " + Eyf.eD(ex), new object[0]);
					}
					if (Eyf.lx(text))
					{
						throw new lwZ("MasterEncryptionKey", "User master key file is empty.", new object[0]);
					}
					try
					{
						rDr = rDl.j("aes256masterkey", Eyf.ID(text), new object[0]);
					}
					catch (Exception ex2)
					{
						throw new lwZ("MasterEncryptionKey", "Cannot create master key wrapper: " + Eyf.eD(ex2), new object[0]);
					}
				}
				else
				{
					try
					{
						lPf = new lPf();
						lPf.nU(true);
						lPf.boa(2, string_0, string_1, "*");
						lPf.boq(2, string_0, string_1, "*");
					}
					catch (Exception ex2)
					{
						throw new lwZ("MasterEncryptionKey", "Cannot create master key wrapper: " + Eyf.eD(ex2), new object[0]);
					}
					if (!Eyf.UK(lPf.Dx(), "RSA", true))
					{
						throw new lwZ("MasterEncryptionKey", Eyf.OS("The certificate's private key must use the RSA algorithm. The loaded PFX contains a private key of type {0}, which is not supported by this application.", lPf.Dx()), new object[0]);
					}
				}
				if (rDr == null && lPf == null)
				{
					throw new lwZ("MasterEncryptionKey", "Cannot create master key wrapper.", new object[0]);
				}
				string text2 = null;
				string text3 = Ecg.MO(new string[] { string_2, ".arc_secure_key" });
				try
				{
					if (!Eyf.lx(string_3) || !Ecg.Mi(text3))
					{
						text2 = ((!Eyf.lx(string_3)) ? string_3 : Eyf.wV(EyN.ku(64)));
						if (rDr == null)
						{
							if (lPf != null)
							{
								lPf.fi(Eyf.ID(text2));
								lPf.nW();
								Ecg.GU(text3, Eyf.wV(lPf.bt()), false);
							}
						}
						else
						{
							Ecg.GU(text3, rDr.Fag(text2 + text2), false);
						}
						string text4 = Ecg.MO(new string[]
						{
							string_2,
							"~backup",
							"masterkey",
							EgJ.ci().cK("yyyy-MM-dd")
						});
						Ecg.jl(text4);
						string text5 = Ecg.MO(new string[] { text4, ".arc_secure_key" });
						if (Ecg.Mi(text5))
						{
							text5 = Eyf.VS(".arc_secure_key", text4, false);
						}
						Ecg.jB(text3, text5, true);
					}
					else
					{
						if (rDr == null)
						{
							if (lPf == null)
							{
								goto IL_02E5;
							}
							try
							{
								lPf.fi(Eyf.wK(Ecg.GX(text3)));
								lPf.nj();
								text2 = Eyf.xr(lPf.bt());
								goto IL_02E5;
							}
							catch (Exception ex2)
							{
								throw new lwZ("MasterEncryptionKey", "Incorrect user master key or key file is damaged. Error: " + Eyf.eD(ex2), new object[0]);
							}
						}
						try
						{
							text2 = rDr.FaU(Ecg.Gi(text3));
						}
						catch (Exception ex2)
						{
							throw new lwZ("MasterEncryptionKey", "Incorrect user master key or key file is damaged. Error: " + Eyf.eD(ex2), new object[0]);
						}
						if (Eyf.lx(text2) || !Eyf.hr(lcP.IZ(text2, 0, text2.Length / 2), lcP.IG(text2, text2.Length / 2)))
						{
							throw new lwZ("MasterEncryptionKey", "Incorrect user master key or key file is damaged.", new object[0]);
						}
						text2 = lcP.IZ(text2, 0, text2.Length / 2);
					}
					IL_02E5:
					return text2;
				}
				catch (Exception ex2)
				{
					if (!(ex2 is lwZ))
					{
						throw new lwZ("MasterEncryptionKey", "Cannot unwrap master key: " + Eyf.eD(ex2), new object[0]);
					}
					throw;
				}
			}
			throw new lwZ("MasterEncryptionKey", "Cannot load wrapped master key.", new object[0]);
		}

		// Token: 0x0601531D RID: 86813 RVA: 0x008641A4 File Offset: 0x008623A4
		public static string bp()
		{
			return giw.hA;
		}

		// Token: 0x0601531E RID: 86814 RVA: 0x008641B8 File Offset: 0x008623B8
		public static string bc()
		{
			return giw.hP;
		}

		// Token: 0x0601531F RID: 86815 RVA: 0x008641CC File Offset: 0x008623CC
		public static string bm()
		{
			return giw.hE;
		}

		// Token: 0x06015320 RID: 86816 RVA: 0x008641E0 File Offset: 0x008623E0
		public static string Ak()
		{
			return Ecg.MO(new string[]
			{
				giw.p(),
				"data"
			});
		}

		// Token: 0x06015321 RID: 86817 RVA: 0x0086420C File Offset: 0x0086240C
		public static string Ab()
		{
			return Ecg.MO(new string[]
			{
				giw.p(),
				"data",
				"~Connections"
			});
		}

		// Token: 0x06015322 RID: 86818 RVA: 0x00864240 File Offset: 0x00862440
		public static string AA()
		{
			return Ecg.MO(new string[]
			{
				giw.p(),
				"data",
				"~Deleted"
			});
		}

		// Token: 0x06015323 RID: 86819 RVA: 0x00864274 File Offset: 0x00862474
		public static string AT()
		{
			return Ecg.MO(new string[]
			{
				giw.p(),
				"data",
				"~Archiving"
			});
		}

		// Token: 0x06015324 RID: 86820 RVA: 0x008642A8 File Offset: 0x008624A8
		public static string Aw()
		{
			return Ecg.MO(new string[]
			{
				giw.p(),
				"cdata-drivers"
			});
		}

		// Token: 0x06015325 RID: 86821 RVA: 0x000FBD30 File Offset: 0x000F9F30
		public static bool Aj()
		{
			return true;
		}

		// Token: 0x06015326 RID: 86822 RVA: 0x008642D4 File Offset: 0x008624D4
		public static string Ag()
		{
			if (giw.hJ[0] != null)
			{
				throw giw.hJ[0];
			}
			return giw.bS[0];
		}

		// Token: 0x06015327 RID: 86823 RVA: 0x00864300 File Offset: 0x00862500
		public static string Au()
		{
			if (giw.hJ[0] != null)
			{
				throw giw.hJ[0];
			}
			return giw.by[0];
		}

		// Token: 0x06015328 RID: 86824 RVA: 0x0086432C File Offset: 0x0086252C
		public static string AF()
		{
			if (giw.hJ[1] != null)
			{
				throw giw.hJ[1];
			}
			return giw.bS[1];
		}

		// Token: 0x06015329 RID: 86825 RVA: 0x00864358 File Offset: 0x00862558
		public static string AQ()
		{
			if (giw.hJ[1] != null)
			{
				throw giw.hJ[1];
			}
			return giw.by[1];
		}

		// Token: 0x0601532A RID: 86826 RVA: 0x00864384 File Offset: 0x00862584
		public static string AS()
		{
			if (giw.hJ[2] != null)
			{
				throw giw.hJ[2];
			}
			return giw.bS[2];
		}

		// Token: 0x0601532B RID: 86827 RVA: 0x008643B0 File Offset: 0x008625B0
		public static string AH()
		{
			if (giw.hJ[2] != null)
			{
				throw giw.hJ[2];
			}
			return giw.by[2];
		}

		// Token: 0x0601532C RID: 86828 RVA: 0x008643DC File Offset: 0x008625DC
		public static string Ao()
		{
			if (giw.hJ[3] != null)
			{
				throw giw.hJ[3];
			}
			return giw.bS[3];
		}

		// Token: 0x0601532D RID: 86829 RVA: 0x00864408 File Offset: 0x00862608
		public static string Al()
		{
			if (giw.hJ[3] != null)
			{
				throw giw.hJ[3];
			}
			return giw.by[3];
		}

		// Token: 0x0601532E RID: 86830 RVA: 0x00864434 File Offset: 0x00862634
		public static string AX()
		{
			if (giw.hJ[4] != null)
			{
				throw giw.hJ[4];
			}
			return giw.bS[4];
		}

		// Token: 0x0601532F RID: 86831 RVA: 0x00864460 File Offset: 0x00862660
		public static string Ay()
		{
			if (giw.hJ[4] != null)
			{
				throw giw.hJ[4];
			}
			return giw.by[4];
		}

		// Token: 0x06015330 RID: 86832 RVA: 0x0086448C File Offset: 0x0086268C
		public static string Ai()
		{
			if (giw.hJ[5] != null)
			{
				throw giw.hJ[5];
			}
			return giw.by[5];
		}

		// Token: 0x06015331 RID: 86833 RVA: 0x0071178C File Offset: 0x0070F98C
		public static string AN()
		{
			return "System.Data.SQLite";
		}

		// Token: 0x06015332 RID: 86834 RVA: 0x008644B8 File Offset: 0x008626B8
		public static string AE(string string_0)
		{
			string text = Eyf.VU(giw.Ac(), string_0);
			return "Data Source=" + text + ";synchronous=normal;journal mode=WAL;";
		}

		// Token: 0x06015333 RID: 86835 RVA: 0x008644E4 File Offset: 0x008626E4
		public static string AD()
		{
			return giw.Ap(true);
		}

		// Token: 0x06015334 RID: 86836 RVA: 0x008644FC File Offset: 0x008626FC
		public static string Ap(bool bool_0)
		{
			string text = Ecg.MO(new string[]
			{
				Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
				"CData",
				"Arc"
			});
			string text2 = Ecg.MO(new string[]
			{
				Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
				"ArcESB"
			});
			if (!Eyf.Vx(text) && Eyf.Vx(text2))
			{
				text = text2;
			}
			string text3 = giw.z;
			if (text3.EndsWith("\\") || text3.EndsWith("/"))
			{
				text3 = text3.Substring(0, text3.Length - 1);
			}
			text2 = Eyf.VU(Directory.GetParent(text3).FullName, "data");
			if (!Eyf.Vx(text) && Eyf.Vx(text2))
			{
				text = Directory.GetParent(text3).FullName;
			}
			if (!Eyf.Vx(text) && bool_0)
			{
				Eyf.VV(text);
			}
			return text;
		}

		// Token: 0x06015335 RID: 86837 RVA: 0x00864608 File Offset: 0x00862808
		public static void Ar(rga rga_0)
		{
			for (int i = 0; i < giw.bb.Length; i++)
			{
				try
				{
					if (!Eyf.lx(giw.bS[i]))
					{
						string text = "";
						Assembly assembly = DbProviderFactories.GetFactory(giw.bS[i]).GetType().Assembly;
						foreach (object obj in assembly.GetCustomAttributes(false))
						{
							if (obj is AssemblyFileVersionAttribute)
							{
								text = ((AssemblyFileVersionAttribute)obj).Version;
								IL_0084:
								if (Eyf.lx(text))
								{
									text = assembly.FullName;
								}
								rga_0.kZ(rgw.b, string.Concat(new string[]
								{
									giw.bb[i],
									": ",
									giw.bS[i],
									", Version=",
									text
								}));
								goto IL_00FC;
							}
						}
						goto IL_0084;
					}
				}
				catch (Exception ex)
				{
					rga_0.kt(Eyf.OS("Unable to determine the driver version: {0}", giw.bS[i]), ex);
				}
				IL_00FC:;
			}
		}

		// Token: 0x06015336 RID: 86838 RVA: 0x0086472C File Offset: 0x0086292C
		public static string Ac()
		{
			if (giw.hi != null)
			{
				throw giw.hi;
			}
			if (giw.hF != null)
			{
				throw giw.hF;
			}
			return giw.hr;
		}

		// Token: 0x06015337 RID: 86839 RVA: 0x00864764 File Offset: 0x00862964
		public static bool Am(string string_0)
		{
			bool flag;
			if (!Eyf.lx(string_0))
			{
				string text = giw.Tj(string_0);
				if (!Eyf.lx(text) && !text.StartsWith("\\\\?\\") && !text.StartsWith("\\\\.\\"))
				{
					string[] array = giw.Az();
					string[] array2 = giw.TA();
					string text2 = ((!Ecg.MW(text)) ? giw.Tj(Ecg.Mp(text)) : null);
					foreach (string text3 in array)
					{
						if (!Eyf.lx(text3) && giw.Tu(text, text3))
						{
							return true;
						}
					}
					if (!Eyf.lx(text2))
					{
						foreach (string text3 in array2)
						{
							if (!Eyf.lx(text3) && giw.TQ(text2, text3))
							{
								return true;
							}
						}
					}
					if (Ecg.Z(text))
					{
						string text4 = text;
						while (!Eyf.lx(text4))
						{
							foreach (string text3 in array)
							{
								if (Ecg.Mj(text4, text3))
								{
									return true;
								}
							}
							string text5 = Ecg.Mp(text4);
							if (Eyf.lx(text5) || giw.TQ(text5, text4))
							{
								break;
							}
							text4 = text5;
						}
						if (!Eyf.lx(text2))
						{
							foreach (string text3 in array2)
							{
								if (Ecg.Mj(text2, text3))
								{
									return true;
								}
							}
						}
						flag = false;
					}
					else
					{
						flag = false;
					}
				}
				else
				{
					flag = true;
				}
			}
			else
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x06015338 RID: 86840 RVA: 0x00081AD7 File Offset: 0x0007FCD7
		private static void Av()
		{
			giw.br = null;
			giw.bP = null;
		}

		// Token: 0x06015339 RID: 86841 RVA: 0x0086492C File Offset: 0x00862B2C
		private static string[] Az()
		{
			if (giw.br == null)
			{
				lmr<string> lmr = new lmr<string>();
				try
				{
					string text = giw.Ac();
					if (!Eyf.lx(text))
					{
						lmr.Add(giw.Tj(text));
					}
				}
				catch (Exception)
				{
				}
				try
				{
					string text = Ecg.MO(new string[]
					{
						giw.p(),
						"~backup"
					});
					if (!Eyf.lx(text))
					{
						lmr.Add(giw.Tj(text));
					}
				}
				catch (Exception)
				{
				}
				try
				{
					string text = giw.Ab();
					if (!Eyf.lx(text))
					{
						lmr.Add(giw.Tj(text));
					}
				}
				catch (Exception)
				{
				}
				try
				{
					string text = giw.bj();
					if (!Eyf.lx(text))
					{
						lmr.Add(giw.Tj(text));
					}
				}
				catch (Exception)
				{
				}
				giw.br = Eyf.Ow(lmr);
			}
			return giw.br;
		}

		// Token: 0x0601533A RID: 86842 RVA: 0x00864A34 File Offset: 0x00862C34
		private static string[] TA()
		{
			if (giw.bP == null)
			{
				lmr<string> lmr = new lmr<string>();
				try
				{
					string text = giw.p();
					if (!Eyf.lx(text))
					{
						lmr.Add(giw.Tj(text));
					}
				}
				catch (Exception)
				{
				}
				try
				{
					string text = Ecg.MO(new string[]
					{
						giw.p(),
						"data"
					});
					if (!Eyf.lx(text))
					{
						lmr.Add(giw.Tj(text));
					}
				}
				catch (Exception)
				{
				}
				giw.bP = Eyf.Ow(lmr);
			}
			return giw.bP;
		}

		// Token: 0x0601533B RID: 86843 RVA: 0x00864AE4 File Offset: 0x00862CE4
		private static string Tj(string string_0)
		{
			string text2;
			if (!Eyf.lx(string_0))
			{
				string text;
				try
				{
					text = new lya(string_0).bO();
				}
				catch (Exception)
				{
					return null;
				}
				while (text.Length > 1 && (text.EndsWith("/") || text.EndsWith("\\")))
				{
					text = lcP.IZ(text, 0, text.Length - 1);
				}
				text2 = text;
			}
			else
			{
				text2 = null;
			}
			return text2;
		}

		// Token: 0x0601533C RID: 86844 RVA: 0x00864B68 File Offset: 0x00862D68
		private static bool Tu(string string_0, string string_1)
		{
			return giw.TQ(string_0, string_1) || Ecg.Mc(string_1, string_0) != null;
		}

		// Token: 0x0601533D RID: 86845 RVA: 0x00864B90 File Offset: 0x00862D90
		private static bool TQ(string string_0, string string_1)
		{
			return (!Ecg.G()) ? Eyf.hK(string_0, string_1) : Eyf.hr(string_0, string_1);
		}

		// Token: 0x0601533E RID: 86846 RVA: 0x00864BB4 File Offset: 0x00862DB4
		public static string TH()
		{
			if (giw.hi != null)
			{
				throw giw.hi;
			}
			return giw.hn;
		}

		// Token: 0x0601533F RID: 86847 RVA: 0x00864BD8 File Offset: 0x00862DD8
		public static void Ty()
		{
			if (giw.hi == null)
			{
				foreach (string text in giw.hC)
				{
					if (Eyf.hK(giw.hn, text))
					{
						return;
					}
				}
				throw new lwZ("Unknown encrypt algorithm {0}.", giw.hn, new object[0]);
			}
			throw giw.hi;
		}

		// Token: 0x06015340 RID: 86848 RVA: 0x00864C3C File Offset: 0x00862E3C
		public static rDr Ti()
		{
			if (giw.hV == null)
			{
				lock (giw.W)
				{
					if (giw.hV == null)
					{
						giw.hV = giw.TE(EEJ.ub());
						goto IL_0052;
					}
					return giw.hV;
				}
				goto IL_004A;
				IL_0052:
				return giw.hV;
			}
			IL_004A:
			return giw.hV;
		}

		// Token: 0x06015341 RID: 86849 RVA: 0x00864CB4 File Offset: 0x00862EB4
		public static rDr TE(byte[] byte_0)
		{
			lmr<rDr> lmr = new lmr<rDr>();
			string text = Eyf.UO(giw.wc(ghD.j("profile", "application"), "encryptpasswordalgorithm"), giw.hn);
			if (Eyf.hK(text, "aes256masterkey"))
			{
				byte[] array = byte_0;
				if (!Eyf.lx(giw.bQ(giw.p())))
				{
					array = Eyf.IV(giw.bQ(giw.p()));
				}
				lmr.Add(rDl.j("aes256masterkey", array, new object[0]));
			}
			if (Eyf.hK(text, "aes256masterkey") || Eyf.hK(text, "aes"))
			{
				lmr.Add(rDl.j("aes", byte_0, new object[0]));
				lmr.Add(rDl.j("dpapi", byte_0, new object[] { DataProtectionScope.CurrentUser }));
			}
			if (Eyf.hK(text, "dpapi"))
			{
				lmr.Add(rDl.j("dpapi", byte_0, new object[] { DataProtectionScope.CurrentUser }));
				lmr.Add(rDl.j("aes", byte_0, new object[0]));
			}
			lmr.Add(rDl.t());
			return rDl.i(lmr);
		}

		// Token: 0x06015342 RID: 86850 RVA: 0x00864E04 File Offset: 0x00863004
		public static EcD TD(int int_0)
		{
			return (int_0 > -1) ? new giw.FXC(int_0) : giw.bE;
		}

		// Token: 0x06015343 RID: 86851 RVA: 0x00864E24 File Offset: 0x00863024
		public static bool Tp()
		{
			return !lZh.e && giw.hM && !lZh.uf("CN");
		}

		// Token: 0x06015344 RID: 86852 RVA: 0x00864E50 File Offset: 0x00863050
		public static int Tr()
		{
			return giw.ht;
		}

		// Token: 0x06015345 RID: 86853 RVA: 0x00864E64 File Offset: 0x00863064
		public static int Tc()
		{
			return giw.hK;
		}

		// Token: 0x06015346 RID: 86854 RVA: 0x00864E78 File Offset: 0x00863078
		public static int Tm()
		{
			string text = giw.wc(ghD.j("profile", "application"), "lastmodifiedtimecacheexpiretime");
			int num;
			if (Eyf.lx(text))
			{
				num = giw.hq;
			}
			else
			{
				num = int.Parse(text);
			}
			return num;
		}

		// Token: 0x06015347 RID: 86855 RVA: 0x00864EB8 File Offset: 0x008630B8
		public static string[] wA()
		{
			if (giw.bA == null)
			{
				lock (giw.W)
				{
					if (giw.bA == null)
					{
						giw.bA = new string[]
						{
							"Arc Version: 26.4.9813.0",
							"System Version: " + giw.wQ(),
							"VM Version: " + Environment.Version
						};
					}
				}
			}
			return giw.bA;
		}

		// Token: 0x06015348 RID: 86856 RVA: 0x00864F54 File Offset: 0x00863154
		public static bool wj()
		{
			return giw.bo;
		}

		// Token: 0x06015349 RID: 86857 RVA: 0x00081AE9 File Offset: 0x0007FCE9
		public static void wu(bool bool_0)
		{
			giw.bo = bool_0;
		}

		// Token: 0x0601534A RID: 86858 RVA: 0x00864F68 File Offset: 0x00863168
		private static string wQ()
		{
			string text;
			try
			{
				text = new ComputerInfo().OSFullName;
			}
			catch
			{
				try
				{
					text = Environment.OSVersion.VersionString;
				}
				catch
				{
					text = "N/A";
				}
			}
			return text;
		}

		// Token: 0x0601534B RID: 86859 RVA: 0x00864FB8 File Offset: 0x008631B8
		public static bool wH()
		{
			return giw.bh;
		}

		// Token: 0x0601534C RID: 86860 RVA: 0x00864FCC File Offset: 0x008631CC
		public static bool wy()
		{
			return giw.wp(ghD.j("profile", "application"), "cloudui") && Eyf.CZ(giw.wc(ghD.j("profile", "application"), "cloudui"), false);
		}

		// Token: 0x0601534D RID: 86861 RVA: 0x0086501C File Offset: 0x0086321C
		public static string wi()
		{
			if (giw.bL == null)
			{
				lock (giw.W)
				{
					if (giw.bL == null)
					{
						lcc lcc = new lcc();
						lcc.MPI("https://").MPI("docs.arc.cdata.com/26.4").MPI("/");
						lcc.MPI((!giw.wy()) ? "self-hosted" : "cloud").MPI("/");
						if (!Eyf.hK("jp", "en"))
						{
							if (!Eyf.hK("cn", "en"))
							{
								lcc.MPI("en").MPI("/");
							}
							else
							{
								lcc.MPI("zh").MPI("/");
							}
						}
						else
						{
							lcc.MPI("ja").MPI("/");
						}
						giw.bL = lcc.ToString();
						goto IL_010E;
					}
					return giw.bL;
				}
				goto IL_0106;
				IL_010E:
				return giw.bL;
			}
			IL_0106:
			return giw.bL;
		}

		// Token: 0x0601534E RID: 86862 RVA: 0x005C77D4 File Offset: 0x005C59D4
		private static string wE()
		{
			string text = null;
			try
			{
				text = Eyf.KJ();
			}
			catch (Exception)
			{
				text = lXu.mz();
			}
			if (text.Length > 250)
			{
				try
				{
					text = rEJ.c(text, 250);
				}
				catch (Exception)
				{
					text = lcP.IZ(text, 0, 250);
				}
			}
			return text;
		}

		// Token: 0x0601534F RID: 86863 RVA: 0x00865150 File Offset: 0x00863350
		private static string wD()
		{
			string text = Process.GetCurrentProcess().Id.ToString();
			string text2 = Eyf.DO(AppDomain.CurrentDomain.Id ^ ((int)((lyc.G() * 31L) ^ ((lyc.G() >> 32) * 37L)) & int.MaxValue));
			return Eyf.IB("{0}.{1}.{2}.{3}", false, new object[]
			{
				giw.hX,
				lXu.mz(),
				text,
				text2
			});
		}

		// Token: 0x06015350 RID: 86864 RVA: 0x008651E0 File Offset: 0x008633E0
		public static bool wp(string string_0, string string_1)
		{
			lZQ lZQ = giw.jk();
			return null != lZQ && lZQ.j(string_0, string_1);
		}

		// Token: 0x06015351 RID: 86865 RVA: 0x0086520C File Offset: 0x0086340C
		public static bool wr(string string_0)
		{
			lZQ lZQ = giw.jk();
			return null != lZQ && lZQ.C(string_0);
		}

		// Token: 0x06015352 RID: 86866 RVA: 0x00865238 File Offset: 0x00863438
		public static string wc(string string_0, string string_1)
		{
			lZQ lZQ = giw.jk();
			string text;
			if (null != lZQ)
			{
				text = lZQ.r(string_0, string_1);
			}
			else
			{
				text = null;
			}
			return text;
		}

		// Token: 0x06015353 RID: 86867 RVA: 0x00865264 File Offset: 0x00863464
		public static lmr<string> wm(string string_0)
		{
			lZQ lZQ = giw.jk();
			lmr<string> lmr;
			if (null != lZQ)
			{
				lmr = lZQ.o(string_0);
			}
			else
			{
				lmr = null;
			}
			return lmr;
		}

		// Token: 0x06015354 RID: 86868 RVA: 0x00865290 File Offset: 0x00863490
		public static lZQ jk()
		{
			if (giw.hW == null)
			{
				goto IL_007B;
			}
			bool flag = false;
			IL_0008:
			lZQ lZQ;
			if (flag)
			{
				try
				{
					try
					{
						if (!Eyf.lx(""))
						{
							lock (giw.W)
							{
								if (giw.hW == null)
								{
									giw.hW = (lZQ)new ryc("").GetObject("globalsettings");
									return giw.hW;
								}
								return giw.hW;
							}
						}
					}
					catch (Exception)
					{
					}
					goto IL_008D;
				}
				finally
				{
					giw.hz = true;
				}
				goto IL_007B;
				IL_008D:
				lZQ = null;
			}
			else
			{
				lZQ = giw.hW;
			}
			return lZQ;
			IL_007B:
			flag = !giw.hz;
			goto IL_0008;
		}

		// Token: 0x06015355 RID: 86869 RVA: 0x00865358 File Offset: 0x00863558
		public static int jb()
		{
			return giw.hg;
		}

		// Token: 0x06015356 RID: 86870 RVA: 0x0086536C File Offset: 0x0086356C
		public static void jA(int int_0)
		{
			if (int_0 > giw.hg)
			{
				lock (giw.W)
				{
					if (int_0 > giw.hg)
					{
						giw.hg = int_0;
					}
				}
			}
		}

		// Token: 0x06015357 RID: 86871 RVA: 0x008653C8 File Offset: 0x008635C8
		public static void jT(RSBContext rsbcontext_0)
		{
			lock (giw.W)
			{
				giw.gA(rsbcontext_0);
				giw.jm(rsbcontext_0);
				giw.jX(rsbcontext_0);
			}
		}

		// Token: 0x06015358 RID: 86872 RVA: 0x00865418 File Offset: 0x00863618
		public static lyv<string> jw(RSBContext rsbcontext_0)
		{
			return giw.jj(rsbcontext_0, false);
		}

		// Token: 0x06015359 RID: 86873 RVA: 0x00865430 File Offset: 0x00863630
		public static lyv<string> jj(RSBContext rsbcontext_0, bool bool_0)
		{
			lyv<string> lyv = new lyv<string>();
			lock (giw.W)
			{
				giw.jF(rsbcontext_0, bool_0, lyv);
				giw.jp(rsbcontext_0, bool_0, lyv);
				giw.jr(lyv);
				giw.jg(rsbcontext_0, 1, bool_0, lyv);
				giw.jg(rsbcontext_0, 0, bool_0, lyv);
				giw.jg(rsbcontext_0, 2, bool_0, lyv);
				giw.jg(rsbcontext_0, 3, bool_0, lyv);
				giw.jg(rsbcontext_0, 4, bool_0, lyv);
				giw.jg(rsbcontext_0, 5, bool_0, lyv);
				giw.jQ(rsbcontext_0, bool_0, lyv);
				giw.jH(rsbcontext_0, bool_0, lyv);
				giw.ji(bool_0, lyv);
				giw.jN(bool_0, lyv);
				giw.jE(bool_0, lyv);
				giw.jD(bool_0, lyv);
				giw.jc(lyv);
				giw.jz(rsbcontext_0, lyv);
				giw.Av();
				try
				{
					Configuration configuration = WebConfigurationManager.OpenWebConfiguration(HostingEnvironment.ApplicationVirtualPath);
					if (configuration != null)
					{
						AuthenticationSection authenticationSection = configuration.GetSection("system.web/authentication") as AuthenticationSection;
						if (authenticationSection == null || (authenticationSection.Mode != AuthenticationMode.None && authenticationSection.Mode != AuthenticationMode.Forms))
						{
							giw.jA(2);
						}
						else
						{
							giw.jA(1);
						}
					}
				}
				catch
				{
				}
			}
			return lyv;
		}

		// Token: 0x0601535A RID: 86874 RVA: 0x00865564 File Offset: 0x00863764
		private static void jg(RSBContext rsbcontext_0, int int_0, bool bool_0, lyv<string> lyv_0)
		{
			if (int_0 >= 0)
			{
				goto IL_013E;
			}
			bool flag = false;
			IL_0008:
			if (flag && !(!bool_0 & (giw.bS[int_0] != null) & (giw.by[int_0] != null)))
			{
				giw.by[int_0] = (giw.bS[int_0] = null);
				try
				{
					ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings[giw.bb[int_0]];
					if (connectionStringSettings != null)
					{
						giw.by[int_0] = giw.jv(connectionStringSettings.ConnectionString);
						giw.bS[int_0] = connectionStringSettings.ProviderName;
					}
					if (giw.by[int_0] != null)
					{
						giw.bu[int_0] = giw.by[int_0];
						giw.by[int_0] = giB.K(giw.bS[int_0], giw.by[int_0]);
					}
					if (giw.bS[int_0] != null && !giw.ju(giw.bS[int_0]))
					{
						throw new RSBException("TryInitDB", Eyf.OS("Unsupported DB type: {0}.", giw.bS[int_0]));
					}
					return;
				}
				catch (Exception ex)
				{
					giw.hJ[int_0] = new lwZ("InitDB", "Error initializing database: " + Eyf.eD(ex), new object[0]);
					lyv_0.Add("Error initializing database: " + Eyf.eD(ex));
					lyv_0.Add(lZh.uX(ex));
					return;
				}
				goto IL_013E;
			}
			return;
			IL_013E:
			flag = int_0 <= 6;
			goto IL_0008;
		}

		// Token: 0x0601535B RID: 86875 RVA: 0x008656CC File Offset: 0x008638CC
		private static bool ju(string string_0)
		{
			return Eyf.hK(string_0, "MySql.Data.MySqlClient") || Eyf.hK(string_0, "System.Data.CData.MySQL") || Eyf.hK(string_0, "System.Data.SqlClient") || Eyf.hK(string_0, "System.Data.CData.SQL") || Eyf.hK(string_0, "System.Data.CData.PostgreSQL") || Eyf.hK(string_0, "Npgsql") || Eyf.hK(string_0, "System.Data.CData.Redis") || Eyf.hK(string_0, "System.Data.SQLite");
		}

		// Token: 0x0601535C RID: 86876 RVA: 0x00865744 File Offset: 0x00863944
		private static void jF(RSBContext rsbcontext_0, bool bool_0, lyv<string> lyv_0)
		{
			if (bool_0 || giw.ho == null)
			{
				try
				{
					RSBLanguageService rsblanguageService = (RSBLanguageService)rsbcontext_0.GetService("language.service");
					RSBItem item = rsblanguageService.GetItem("_about");
					giw.ho = item.GetAttr("appbin");
				}
				catch (Exception ex)
				{
					lyv_0.Add("Error initializing app directory: " + Eyf.eD(ex));
					lyv_0.Add(lZh.uX(ex));
				}
				giw.z = rsbcontext_0.MapPath("~");
			}
		}

		// Token: 0x0601535D RID: 86877 RVA: 0x008657DC File Offset: 0x008639DC
		private static void jQ(RSBContext rsbcontext_0, bool bool_0, lyv<string> lyv_0)
		{
			if (!bool_0)
			{
				goto IL_001D;
			}
			bool flag = true;
			IL_0004:
			if (flag)
			{
				try
				{
					giw.hh = giw.jS(rsbcontext_0, lyv_0);
					return;
				}
				catch (lwZ lwZ)
				{
					giw.hi = lwZ;
					return;
				}
				goto IL_001D;
			}
			return;
			IL_001D:
			flag = giw.hh == null;
			goto IL_0004;
		}

		// Token: 0x0601535E RID: 86878 RVA: 0x00865820 File Offset: 0x00863A20
		public static string jS(RSBContext rsbcontext_0, lyv<string> lyv_0)
		{
			string text = null;
			try
			{
				text = ConfigurationManager.AppSettings["AppDirectory"];
				if (Eyf.lx(text))
				{
					text = giw.AD();
				}
				else
				{
					if (!Eyf.Vx(text))
					{
						Eyf.VV(text);
					}
					text = new lya(text).bO();
				}
			}
			catch (Exception ex)
			{
				try
				{
					text = giw.AD();
				}
				catch (Exception ex2)
				{
					lyv_0.Add("Error initializing default data directory: " + Eyf.eD(ex2));
					lyv_0.Add(lZh.uX(ex2));
					throw new lwZ("InitAppDataDirectory", "Error initializing default data directory: " + Eyf.eD(ex2), ex2, new object[0]);
				}
				lyv_0.Add("Error initializing data directory (Using default DataDirectory): " + Eyf.eD(ex));
				lyv_0.Add(lZh.uX(ex));
			}
			if (!Eyf.Vp(text))
			{
				throw new lwZ("InitAppDataDirectory", "Error initializing default data directory: access denied!", new object[0]);
			}
			return text;
		}

		// Token: 0x0601535F RID: 86879 RVA: 0x00865924 File Offset: 0x00863B24
		private static void jH(RSBContext rsbcontext_0, bool bool_0, lyv<string> lyv_0)
		{
			if (!bool_0)
			{
				goto IL_0029;
			}
			bool flag = true;
			IL_0004:
			if (flag)
			{
				giw.hd = null;
				try
				{
					giw.hb = giw.jo(rsbcontext_0, lyv_0);
					return;
				}
				catch (lwZ lwZ)
				{
					giw.hb = null;
					giw.hd = lwZ;
					return;
				}
				goto IL_0029;
			}
			return;
			IL_0029:
			flag = giw.hb == null;
			goto IL_0004;
		}

		// Token: 0x06015360 RID: 86880 RVA: 0x00865974 File Offset: 0x00863B74
		public static string jo(RSBContext rsbcontext_0, lyv<string> lyv_0)
		{
			string text = ConfigurationManager.AppSettings["MessageDirectory"];
			string text2;
			if (!Eyf.lx(text))
			{
				text2 = giw.jl(text, lyv_0);
			}
			else
			{
				text2 = null;
			}
			return text2;
		}

		// Token: 0x06015361 RID: 86881 RVA: 0x008659AC File Offset: 0x00863BAC
		private static string jl(string string_0, lyv<string> lyv_0)
		{
			string text = string_0;
			try
			{
				if (!Eyf.Vx(text))
				{
					Eyf.VV(text);
				}
				text = new lya(text).bO();
			}
			catch (Exception ex)
			{
				lyv_0.Add("Error initializing message directory: " + string_0 + " " + Eyf.eD(ex));
				lyv_0.Add(lZh.uX(ex));
				throw new lwZ("InitAppMessageDirectory", "Error initializing message directory: " + string_0 + " " + Eyf.eD(ex), ex, new object[0]);
			}
			if (!Eyf.Vp(text))
			{
				throw new lwZ("InitAppMessageDirectory", "Error initializing message directory: " + text + " Access is denied", new object[0]);
			}
			return text;
		}

		// Token: 0x06015362 RID: 86882 RVA: 0x00865A68 File Offset: 0x00863C68
		private static void jX(RSBContext rsbcontext_0)
		{
			if (null == giw.hS)
			{
				string text = "";
				string text2 = "";
				text = Environment.GetEnvironmentVariable("APP_KEY");
				text2 = Environment.GetEnvironmentVariable("APP_KEY_PASSWORD");
				if (Eyf.lx(text))
				{
					text = ConfigurationManager.AppSettings["AppKey"];
					text2 = ConfigurationManager.AppSettings["AppKeyPassword"];
				}
				if (!Eyf.lx(text))
				{
					string text3 = null;
					string text4 = text;
					try
					{
						text3 = giw.p();
						if (Eyf.lx(text3))
						{
							text3 = giw.jS(rsbcontext_0, new lyv<string>());
						}
						text = Ecg.MO(new string[] { text3, text });
					}
					catch (Exception)
					{
					}
					if (!Eyf.lx(text3) && Eyf.hK(text4, "default.master_key") && !Ecg.MG(text))
					{
						giw.jy(text, text3);
					}
					giw.hy = text;
					giw.hu = text2;
					giw.Av();
					if (!giw.wp(ghD.j("profile", "application"), "encryptpasswordalgorithm"))
					{
						if (giw.m())
						{
							giw.hn = "aes256masterkey";
						}
					}
					else
					{
						giw.hn = giw.wc(ghD.j("profile", "application"), "encryptpasswordalgorithm");
					}
				}
			}
		}

		// Token: 0x06015363 RID: 86883 RVA: 0x00865BC4 File Offset: 0x00863DC4
		private static void jy(string string_0, string string_1)
		{
			try
			{
				if (!Ecg.MG(Ecg.MO(new string[] { string_1, ".arc_secure_key" })))
				{
					Ecg.Gl(string_0, Eyf.wV(EyN.ku(64)));
				}
			}
			catch (Exception ex)
			{
				string text = Eyf.Oq("Unable to create the default master encryption key file [{0}] in the application directory [{1}]. Verify that the service account has read and write access to the application directory. Error: {2}.", new string[]
				{
					string_0,
					string_1,
					Eyf.eD(ex)
				});
				throw new RSBException("InitMasterEncryptionKey", text, ex);
			}
		}

		// Token: 0x06015364 RID: 86884 RVA: 0x00865C48 File Offset: 0x00863E48
		private static void ji(bool bool_0, lyv<string> lyv_0)
		{
			if (!bool_0)
			{
				goto IL_004D;
			}
			bool flag = true;
			IL_0004:
			if (flag)
			{
				try
				{
					giw.hA = new lya(Eyf.VU(giw.z, "api")).bn();
					return;
				}
				catch (Exception ex)
				{
					lyv_0.Add("Error initializing api directory: " + Eyf.eD(ex));
					lyv_0.Add(lZh.uX(ex));
					return;
				}
				goto IL_004D;
			}
			return;
			IL_004D:
			flag = giw.hA == null;
			goto IL_0004;
		}

		// Token: 0x06015365 RID: 86885 RVA: 0x00865CBC File Offset: 0x00863EBC
		private static void jN(bool bool_0, lyv<string> lyv_0)
		{
			if (!bool_0)
			{
				goto IL_00D7;
			}
			bool flag = true;
			IL_0007:
			if (flag)
			{
				try
				{
					string text = Eyf.VU(giw.z, "app_data");
					if (!Eyf.Vx(text) || Eyf.pp(text, "*.db").Length <= 0)
					{
						string text2 = ((!Eyf.lx(giw.hh)) ? Eyf.VU(giw.hh, "db") : null);
						if (!Eyf.lx(text2))
						{
							if (!Eyf.Vx(text2))
							{
								Eyf.VV(text2);
							}
							giw.hr = text2;
						}
						goto IL_00E4;
					}
					giw.hr = text;
					if (!Eyf.Vp(giw.hr))
					{
						giw.hF = new lwZ("InitAppAPPDBDirectory", "Error initializing default app database directory: access denied!", new object[0]);
					}
					return;
				}
				catch (Exception ex)
				{
					lyv_0.Add("Error initializing db directory: " + Eyf.eD(ex));
					lyv_0.Add(lZh.uX(ex));
					goto IL_00E4;
				}
				goto IL_00D7;
				IL_00E4:
				if (!Eyf.Vp(giw.hr))
				{
					giw.hF = new lwZ("InitAppAPPDBDirectory", "Error initializing default app database directory: access denied!", new object[0]);
				}
			}
			return;
			IL_00D7:
			flag = giw.hr == null;
			goto IL_0007;
		}

		// Token: 0x06015366 RID: 86886 RVA: 0x00865DE4 File Offset: 0x00863FE4
		private static void jE(bool bool_0, lyv<string> lyv_0)
		{
			if (!bool_0)
			{
				goto IL_00AD;
			}
			bool flag = true;
			IL_0007:
			if (flag)
			{
				try
				{
					string text = ((!Eyf.lx(giw.hh)) ? Eyf.VU(giw.hh, "connectors") : null);
					string text2 = Eyf.VU(giw.z, "connectors");
					if (Ecg.MW(text2))
					{
						string[] array = Ecg.jt(text2);
						if (array != null && array.Length > 0)
						{
							text = text2;
						}
					}
					if (!Eyf.lx(text))
					{
						if (!Eyf.Vx(text))
						{
							Eyf.VV(text);
						}
						giw.hP = text;
					}
					return;
				}
				catch (Exception ex)
				{
					lyv_0.Add("Error initializing connector directory: " + Eyf.eD(ex));
					lyv_0.Add(lZh.uX(ex));
					return;
				}
				goto IL_00AD;
			}
			return;
			IL_00AD:
			flag = giw.hP == null;
			goto IL_0007;
		}

		// Token: 0x06015367 RID: 86887 RVA: 0x00865EBC File Offset: 0x008640BC
		private static void jD(bool bool_0, lyv<string> lyv_0)
		{
			if (!bool_0)
			{
				goto IL_0070;
			}
			bool flag = true;
			IL_0004:
			if (flag)
			{
				try
				{
					string text = ((!Eyf.lx(giw.hh)) ? Eyf.VU(giw.hh, "locks") : null);
					if (!Eyf.lx(text))
					{
						if (!Eyf.Vx(text))
						{
							Eyf.VV(text);
						}
						giw.hE = text;
					}
					return;
				}
				catch (Exception ex)
				{
					lyv_0.Add("Error initializing lock directory: " + Eyf.eD(ex));
					lyv_0.Add(lZh.uX(ex));
					return;
				}
				goto IL_0070;
			}
			return;
			IL_0070:
			flag = giw.hE == null;
			goto IL_0004;
		}

		// Token: 0x06015368 RID: 86888 RVA: 0x00865F54 File Offset: 0x00864154
		private static void jp(RSBContext rsbcontext_0, bool bool_0, lyv<string> lyv_0)
		{
			if (!bool_0)
			{
				goto IL_00C5;
			}
			IL_0006:
			bool flag = true;
			IL_0007:
			if (flag)
			{
				try
				{
					string text = ConfigurationManager.AppSettings["ArcId"];
					if (Eyf.lx(text))
					{
						giw.hX = giw.wE();
						giw.hL = giw.wD();
					}
					else
					{
						giw.hX = text;
						giw.hL = text;
					}
					return;
				}
				catch (Exception ex)
				{
					try
					{
						giw.hX = giw.wE();
						giw.hL = giw.wD();
					}
					catch (Exception ex2)
					{
						giw.hX = "Arc";
						giw.hL = "Arc";
						lyv_0.Add("Error initializing default app id (Using 0 as app id): " + Eyf.eD(ex2));
						lyv_0.Add(lZh.uX(ex2));
						return;
					}
					lyv_0.Add("Error initializing app id (Using default app id): " + Eyf.eD(ex));
					lyv_0.Add(lZh.uX(ex));
					return;
				}
				goto IL_00C5;
			}
			return;
			IL_00C5:
			if (!Eyf.lx(giw.hL))
			{
				flag = "Arc".Equals(giw.hL);
				goto IL_0007;
			}
			goto IL_0006;
		}

		// Token: 0x06015369 RID: 86889 RVA: 0x00866068 File Offset: 0x00864268
		private static void jr(lyv<string> lyv_0)
		{
			try
			{
				byte[] array = EyN.u(Eyf.Ip(giw.H(), "utf-8"));
				int num = (int)Eyf.At(array, 0, 4) % 1024;
				if (num < 0)
				{
					num = -num;
				}
				Eyf.FD(num / 32 % 32, num % 32);
			}
			catch (Exception ex)
			{
				try
				{
					Eyf.FD(0, 0);
				}
				catch (Exception ex2)
				{
					lyv_0.Add("Error initializing default snowflake: " + Eyf.eD(ex2));
					lyv_0.Add(lZh.uX(ex2));
					return;
				}
				lyv_0.Add("Unable to initial the snowflake (Using default data center id and worker id): " + Eyf.eD(ex));
				lyv_0.Add(lZh.uX(ex));
			}
		}

		// Token: 0x0601536A RID: 86890 RVA: 0x0086612C File Offset: 0x0086432C
		private static void jc(lyv<string> lyv_0)
		{
			try
			{
				string text = Ecg.MO(new string[]
				{
					giw.p(),
					"data",
					"profile.cfg"
				});
				if (Ecg.Mt(text))
				{
					Emo emo = Emo.dc(text);
					if (emo.E("Application", "EncryptPasswordAlgorithm"))
					{
						giw.hn = emo.n("Application", "EncryptPasswordAlgorithm");
					}
					if (emo.E("Application", "CollectUserData"))
					{
						giw.hM = Eyf.CZ(emo.n("Application", "CollectUserData"), true);
						if (giw.Tp())
						{
							for (int i = 0; i < giw.bu.Length; i++)
							{
								if (giw.bu[i] != null)
								{
									giw.by[i] = giB.K(giw.bS[i], giw.bu[i]);
								}
							}
						}
					}
					if (emo.E("Application", "LongMessageIdThreshold"))
					{
						giw.ht = int.Parse(emo.n("Application", "LongMessageIdThreshold"));
					}
					if (emo.E("Application", "LastModifiedTimeCacheExpireTime"))
					{
						giw.hq = int.Parse(emo.n("Application", "LastModifiedTimeCacheExpireTime"));
					}
					if (emo.E("Application", "MaxConnectorIdLength"))
					{
						giw.hK = int.Parse(emo.n("Application", "MaxConnectorIdLength"));
					}
				}
			}
			catch (Exception ex)
			{
				lyv_0.Add("Initial App Settings Error: " + Eyf.Ft(ex));
			}
		}

		// Token: 0x0601536B RID: 86891 RVA: 0x00866308 File Offset: 0x00864508
		private static void jm(RSBContext rsbcontext_0)
		{
			lZQ lZQ = giw.jk();
			if (null != lZQ)
			{
				lZQ.A(rsbcontext_0);
			}
		}

		// Token: 0x0601536C RID: 86892 RVA: 0x0086632C File Offset: 0x0086452C
		private static string jv(string string_0)
		{
			string text;
			if (!Eyf.lx(string_0))
			{
				text = giw.TE(Eyf.IV(EEJ.ua())).FaU(string_0);
			}
			else
			{
				text = string_0;
			}
			return text;
		}

		// Token: 0x0601536D RID: 86893 RVA: 0x00081AF3 File Offset: 0x0007FCF3
		private static void jz(RSBContext rsbcontext_0, lyv<string> lyv_0)
		{
			giw.bo = Eyf.CZ(ConfigurationManager.AppSettings["SafeMode"], false);
		}

		// Token: 0x0601536E RID: 86894 RVA: 0x00866360 File Offset: 0x00864560
		private static void gA(RSBContext rsbcontext_0)
		{
			string text = "EnableFIPSMode";
			bool flag = false;
			try
			{
				flag = Eyf.CZ(ConfigurationManager.AppSettings[text], false);
			}
			catch (Exception)
			{
			}
			if (flag)
			{
				giw.bh = true;
				PZt pzt = new PZt();
				pzt.AK("UseFIPSCompliantAPI=true");
				pzt.AK("UseInternalSecurityAPI=false");
			}
		}

		// Token: 0x0601536F RID: 86895 RVA: 0x008663C8 File Offset: 0x008645C8
		public static void gj(RSBContext rsbcontext_0, rga rga_0)
		{
			lyv<string> lyv = new lyv<string>();
			bool flag = false;
			try
			{
				lock (giw.W)
				{
					giw.jF(rsbcontext_0, flag, lyv);
					giw.jp(rsbcontext_0, flag, lyv);
					giw.jr(lyv);
					string text = Ecg.MO(new string[]
					{
						Eyf.pr(Assembly.GetExecutingAssembly().Location),
						"..",
						"Web.Config"
					});
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.Load(text);
					if (xmlDocument.DocumentElement != null)
					{
						string text2 = "";
						XmlNode xmlNode = xmlDocument.DocumentElement.SelectSingleNode("/configuration/appSettings/add[@key='AppDirectory']");
						if (xmlNode != null && null != xmlNode.Attributes)
						{
							text2 = xmlNode.Attributes["value"].Value;
						}
						if (!Eyf.lx(text2))
						{
							giw.hh = text2;
							giw.Av();
							giw.jD(flag, lyv);
						}
						else
						{
							lyv.Add(Eyf.OS("Unable to find application data directory from the webConfig {0}.", text));
						}
					}
					else
					{
						lyv.Add(Eyf.OS("Unable to parse the webConfig file {0}", text));
					}
				}
			}
			finally
			{
				if (rga_0 != null && lyv.Count > 0)
				{
					foreach (object obj in lyv)
					{
						string text3 = (string)obj;
						rga_0.kZ(rgw.a, text3);
					}
				}
			}
		}

		// Token: 0x06015371 RID: 86897 RVA: 0x008665A4 File Offset: 0x008647A4
		// Note: this type is marked as 'beforefieldinit'.
		static giw()
		{
			lwZ[] array = new lwZ[6];
			giw.hJ = array;
			giw.hC = new string[] { "AES", "AES256MasterKey", "DPAPI" };
			giw.hn = "AES";
			giw.hV = null;
			giw.hM = false;
			giw.ht = 55;
			giw.hq = 100;
			giw.hK = 70;
			giw.hg = 0;
			giw.hW = null;
			giw.hz = false;
			giw.bo = false;
			giw.bh = false;
			giw.bb = new string[] { "AppDb", "AppLogs", "AppUsers", "AppLocks", "AppState", "AppRedis" };
			string[] array2 = new string[6];
			giw.bS = array2;
			array2 = new string[6];
			giw.by = array2;
			array2 = new string[6];
			giw.bu = array2;
			giw.bA = null;
			giw.br = null;
			giw.bP = null;
			giw.bE = new Ecu();
			giw.bL = null;
		}

		// Token: 0x0400A4B4 RID: 42164
		public const int o = 0;

		// Token: 0x0400A4B5 RID: 42165
		public const int h = 1;

		// Token: 0x0400A4B6 RID: 42166
		public const int b = 2;

		// Token: 0x0400A4B7 RID: 42167
		private const int S = 0;

		// Token: 0x0400A4B8 RID: 42168
		private const int y = 1;

		// Token: 0x0400A4B9 RID: 42169
		private const int u = 2;

		// Token: 0x0400A4BA RID: 42170
		private const int A = 3;

		// Token: 0x0400A4BB RID: 42171
		private const int r = 4;

		// Token: 0x0400A4BC RID: 42172
		private const int P = 5;

		// Token: 0x0400A4BD RID: 42173
		private const int E = 6;

		// Token: 0x0400A4BE RID: 42174
		public const string L = "app_transactions.db";

		// Token: 0x0400A4BF RID: 42175
		public const string X = "app_automations.db";

		// Token: 0x0400A4C0 RID: 42176
		public const int i = 768;

		// Token: 0x0400A4C1 RID: 42177
		private const string d = "Application";

		// Token: 0x0400A4C2 RID: 42178
		private const string F = "EncryptPasswordAlgorithm";

		// Token: 0x0400A4C3 RID: 42179
		private const string J = "CollectUserData";

		// Token: 0x0400A4C4 RID: 42180
		private const string C = "LongMessageIdThreshold";

		// Token: 0x0400A4C5 RID: 42181
		private const string n = "LastModifiedTimeCacheExpireTime";

		// Token: 0x0400A4C6 RID: 42182
		private const string V = "MaxConnectorIdLength";

		// Token: 0x0400A4C7 RID: 42183
		private const string M = "ENCRYPTEDA:";

		// Token: 0x0400A4C8 RID: 42184
		private const string t = "Unable to determine the driver version: {0}";

		// Token: 0x0400A4C9 RID: 42185
		public const string q = "Arc Version: ";

		// Token: 0x0400A4CA RID: 42186
		public const string K = "System Version: ";

		// Token: 0x0400A4CB RID: 42187
		public const string g = "VM Version: ";

		// Token: 0x0400A4CC RID: 42188
		private static object W = new object();

		// Token: 0x0400A4CD RID: 42189
		private static string z = null;

		// Token: 0x0400A4CE RID: 42190
		private static string ho = null;

		// Token: 0x0400A4CF RID: 42191
		private static string hh = null;

		// Token: 0x0400A4D0 RID: 42192
		private static string hb = null;

		// Token: 0x0400A4D1 RID: 42193
		private static string hS = null;

		// Token: 0x0400A4D2 RID: 42194
		private static string hy = null;

		// Token: 0x0400A4D3 RID: 42195
		private static string hu = null;

		// Token: 0x0400A4D4 RID: 42196
		private static string hA = null;

		// Token: 0x0400A4D5 RID: 42197
		private static string hr = null;

		// Token: 0x0400A4D6 RID: 42198
		private static string hP = null;

		// Token: 0x0400A4D7 RID: 42199
		private static string hE = null;

		// Token: 0x0400A4D8 RID: 42200
		private static string hL = "Arc";

		// Token: 0x0400A4D9 RID: 42201
		private static string hX = "Arc";

		// Token: 0x0400A4DA RID: 42202
		private static lwZ hi = null;

		// Token: 0x0400A4DB RID: 42203
		private static lwZ hd = null;

		// Token: 0x0400A4DC RID: 42204
		private static lwZ hF = null;

		// Token: 0x0400A4DD RID: 42205
		private static lwZ[] hJ;

		// Token: 0x0400A4DE RID: 42206
		private static string[] hC;

		// Token: 0x0400A4DF RID: 42207
		private static string hn;

		// Token: 0x0400A4E0 RID: 42208
		private static rDr hV;

		// Token: 0x0400A4E1 RID: 42209
		private static bool hM;

		// Token: 0x0400A4E2 RID: 42210
		private static int ht;

		// Token: 0x0400A4E3 RID: 42211
		private static int hq;

		// Token: 0x0400A4E4 RID: 42212
		private static int hK;

		// Token: 0x0400A4E5 RID: 42213
		private static int hg;

		// Token: 0x0400A4E6 RID: 42214
		private static lZQ hW;

		// Token: 0x0400A4E7 RID: 42215
		private static bool hz;

		// Token: 0x0400A4E8 RID: 42216
		private static volatile bool bo;

		// Token: 0x0400A4E9 RID: 42217
		private static bool bh;

		// Token: 0x0400A4EA RID: 42218
		private static string[] bb;

		// Token: 0x0400A4EB RID: 42219
		private static string[] bS;

		// Token: 0x0400A4EC RID: 42220
		private static string[] by;

		// Token: 0x0400A4ED RID: 42221
		private static string[] bu;

		// Token: 0x0400A4EE RID: 42222
		private static string[] bA;

		// Token: 0x0400A4EF RID: 42223
		private static volatile string[] br;

		// Token: 0x0400A4F0 RID: 42224
		private static volatile string[] bP;

		// Token: 0x0400A4F1 RID: 42225
		private static EcD bE;

		// Token: 0x0400A4F2 RID: 42226
		private static string bL;

		// Token: 0x0200193D RID: 6461
		private sealed class FXC : EcD
		{
			// Token: 0x06015372 RID: 86898 RVA: 0x0086672C File Offset: 0x0086492C
			public FXC(int int_0)
			{
				if (giw.FXC.k == null)
				{
					lock (giw.W)
					{
						if (giw.FXC.k == null)
						{
							giw.FXC.k = new giw.FXo();
						}
					}
				}
				this.b = new rDf(int_0, giw.FXC.k);
			}

			// Token: 0x06015373 RID: 86899 RVA: 0x008667A4 File Offset: 0x008649A4
			public lcX FTI(string string_0)
			{
				return rDh.D(giw.bE.FTI(string_0), this.b);
			}

			// Token: 0x06015374 RID: 86900 RVA: 0x008667D4 File Offset: 0x008649D4
			public lcX FTq(string string_0)
			{
				return rDh.i(giw.bE.FTq(string_0), this.b);
			}

			// Token: 0x06015375 RID: 86901 RVA: 0x00866804 File Offset: 0x00864A04
			public lcX FTN(string string_0, bool bool_0)
			{
				return rDh.i(giw.bE.FTN(string_0, bool_0), this.b);
			}

			// Token: 0x06015376 RID: 86902 RVA: 0x00866834 File Offset: 0x00864A34
			public long FTw(string string_0)
			{
				if (this.b.A() > -1)
				{
					long num = giw.bE.FTw(string_0);
					lcX lcX = giw.bE.FTI(string_0);
					try
					{
						return rDh.f(lcX, num, this.b);
					}
					finally
					{
						lcX.MPe();
					}
				}
				return giw.bE.FTw(string_0);
			}

			// Token: 0x0400A4F3 RID: 42227
			private static giw.FXo k = null;

			// Token: 0x0400A4F4 RID: 42228
			private readonly rDf b;
		}

		// Token: 0x0200193E RID: 6462
		private sealed class FXo : ruu
		{
			// Token: 0x06015378 RID: 86904 RVA: 0x008668A4 File Offset: 0x00864AA4
			public rDQ Fak(byte[] byte_0)
			{
				Eyf.Fn<byte[]>(byte_0, "Fek", new object[0]);
				rDQ rDQ;
				try
				{
					rDQ = new rDQ(Eyf.IV(giw.Ti().Fag(Eyf.nx(byte_0, true))), "default");
				}
				catch (Egs egs)
				{
					throw new rDP("ArcEFKeyProtector", "Unable to wrap file key: " + Eyf.eD(egs), egs, new object[0]);
				}
				return rDQ;
			}

			// Token: 0x06015379 RID: 86905 RVA: 0x0086691C File Offset: 0x00864B1C
			public byte[] FaY(rDQ rDQ_0)
			{
				Eyf.Fn<rDQ>(rDQ_0, "wrappedFileKey", new object[0]);
				if (Eyf.hK(rDQ_0.s(), "default"))
				{
					try
					{
						return Eyf.nO(giw.Ti().FaU(Eyf.Im(rDQ_0.m())));
					}
					catch (Egs egs)
					{
						throw new rDP("ArcEFKeyProtector", "Unable to unwrap file key: " + Eyf.eD(egs), egs, new object[0]);
					}
				}
				throw new rDP("ArcEFKeyProtector", "Unknown DEK ID: " + rDQ_0.s() + ".", new object[0]);
			}
		}
	}
}
