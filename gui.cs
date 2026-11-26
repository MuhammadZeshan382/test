using System;
using System.Diagnostics;
using System.Security;
using Microsoft.Win32;
using RSSBus;

namespace Arc264y
{
	// Token: 0x020014AC RID: 5292
	internal abstract class gui : lXu
	{
		// Token: 0x060133C0 RID: 78784
		protected internal abstract string oUI();

		// Token: 0x060133C1 RID: 78785
		protected internal abstract char oUq();

		// Token: 0x060133C2 RID: 78786
		protected internal abstract string oUN();

		// Token: 0x060133C3 RID: 78787
		protected internal abstract string oUw();

		// Token: 0x060133C4 RID: 78788
		protected internal abstract void oUe(byte[] byte_0);

		// Token: 0x060133C5 RID: 78789
		protected internal abstract bool oUT();

		// Token: 0x060133C6 RID: 78790
		protected internal abstract bool oUk(byte[] byte_0);

		// Token: 0x060133C7 RID: 78791
		protected internal abstract bool oUY(int int_0, byte[] byte_0, string string_0);

		// Token: 0x060133C8 RID: 78792
		protected internal abstract bool oUd(byte[] byte_0);

		// Token: 0x060133C9 RID: 78793
		protected internal abstract int oUR(byte[] byte_0);

		// Token: 0x060133CA RID: 78794
		protected internal abstract bool oUz(byte[] byte_0);

		// Token: 0x060133CB RID: 78795
		protected internal abstract bool ovC(byte[] byte_0);

		// Token: 0x060133CC RID: 78796 RVA: 0x00767C1C File Offset: 0x00765E1C
		protected internal void A(string[] string_0, byte[][] byte_0)
		{
			int[] array = new int[1];
			try
			{
				this.bA(array, string_0, byte_0, lXu.mz());
			}
			catch (Exception ex)
			{
				throw new RSBException(string.Concat(array[0]), Eyf.eD(ex));
			}
		}

		// Token: 0x060133CD RID: 78797 RVA: 0x00767C6C File Offset: 0x00765E6C
		protected internal int Q(byte[] byte_0)
		{
			return this.bH(byte_0);
		}

		// Token: 0x060133CE RID: 78798 RVA: 0x001E9D30 File Offset: 0x001E7F30
		protected internal virtual int ova(byte[] byte_0)
		{
			return 1;
		}

		// Token: 0x060133CF RID: 78799 RVA: 0x00767C84 File Offset: 0x00765E84
		protected internal int i(byte[] byte_0)
		{
			int num;
			if (byte_0 != null)
			{
				if (!this.oUd(byte_0))
				{
					num = this.ova(byte_0);
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
			return num;
		}

		// Token: 0x060133D0 RID: 78800 RVA: 0x00767CB8 File Offset: 0x00765EB8
		protected internal int E(byte[] byte_0)
		{
			int num = 0;
			int num3;
			if (byte_0 != null)
			{
				int num2 = ((!this.oUk(byte_0)) ? 5 : 17);
				if (byte_0.Length > num2 + 2 && lXu.mx(byte_0[num2]) && byte_0[num2 + 2] <= 56 && byte_0[num2 + 2] >= 48)
				{
					num3 = (int)(byte_0[num2 + 2] - 48);
				}
				else
				{
					num3 = num;
				}
			}
			else
			{
				num3 = num;
			}
			return num3;
		}

		// Token: 0x060133D1 RID: 78801 RVA: 0x00767D20 File Offset: 0x00765F20
		protected internal static void c(int int_0)
		{
			if (int_0 > 0 && int_0 <= 8)
			{
				try
				{
					Process.GetCurrentProcess().ProcessorAffinity = new IntPtr((1 << int_0) - 1);
				}
				catch
				{
				}
			}
		}

		// Token: 0x060133D2 RID: 78802 RVA: 0x00767D68 File Offset: 0x00765F68
		private string bA(int[] int_0, string[] string_0, byte[][] byte_0, string string_1)
		{
			string text = this.oUN() + ". ";
			byte[] array = new byte[16];
			this.oUe(array);
			string[] array2 = new string[1];
			int_0[0] = this.bj(array, string_1, string_0, byte_0, array2);
			if (this.oUT() && this.oUY(int_0[0], byte_0[0], array2[0]) && gui.bQ(gui.j))
			{
				lock (gui.t)
				{
					int_0[0] = this.bj(array, string_1, string_0, byte_0, array2);
					if (this.oUY(int_0[0], byte_0[0], array2[0]) && gui.bQ(gui.j))
					{
						rga rga = rga.Fu("application", "arc.core.lic");
						rga.V("The subscription license is activated by previous version.  Try to re-activate the license.");
						bool flag2 = false;
						try
						{
							this.bi(string_1, array2[0], true);
							flag2 = true;
							rga.V("The license is re-activated successfully.");
						}
						catch (Exception ex)
						{
							rga.kt(Eyf.eD(ex), ex);
						}
						finally
						{
							gui.j = Eyf.th();
						}
						if (flag2)
						{
							int_0[0] = this.bj(array, string_1, string_0, byte_0, array2);
						}
					}
				}
			}
			string_0[0] = rrh.W(int_0[0], array2[0], string_0[0], text, this.oUN(), string_1);
			return string_0[0];
		}

		// Token: 0x060133D3 RID: 78803 RVA: 0x00767EF0 File Offset: 0x007660F0
		private int bj(byte[] byte_0, string string_0, string[] string_1, byte[][] byte_1, string[] string_2)
		{
			byte[] array = new byte[20];
			array[0] = 42;
			array[1] = 0;
			string text = "SOFTWARE\\CData\\RT\\" + this.oUI();
			lmD<string, string> lmD = null;
			string text2 = this.oUw();
			if (text2 != null)
			{
				goto IL_00C4;
			}
			bool flag = true;
			IL_0036:
			if (flag)
			{
				try
				{
					object obj = null;
					RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(text);
					if (registryKey != null)
					{
						obj = registryKey.GetValue("");
					}
					if (obj != null)
					{
						string_1[0] = (string)obj;
						byte_1[0] = lcm.Q((string)obj + "\0");
						goto IL_0129;
					}
					return 6;
				}
				catch (SecurityException ex)
				{
					throw new RSBException("rsb:license", "Error reading registry: " + ex.Message);
				}
				catch (Exception)
				{
					return 6;
				}
				goto IL_00C4;
			}
			lmD = new lmD<string, string>();
			try
			{
				string_2[0] = gui.bu(Eyf.YO(text2), lmD);
			}
			catch (Exception)
			{
				return 6;
			}
			if (!lmD.ContainsKey("@"))
			{
				return 6;
			}
			string_1[0] = lmD.m("@");
			byte_1[0] = lXu.f(string_1[0] + "\0");
			IL_0129:
			int normalizedLength = lXu.ma(byte_1[0], 0);
			if (normalizedLength > 0 && normalizedLength <= 5)
			{
				return 10;
			}
			int num2;
			if (byte_1[0][0] != 0)
			{
				if (lXu.i(byte_1[0][5]))
				{
					if (!lXu.mH(byte_1[0][5]))
					{
						if (this.oUk(byte_1[0]))
						{
							if (this.oUz(byte_1[0]))
							{
								goto IL_0185;
							}
						}
						bool flag2;
						if (!rrh.K(byte_1[0]))
						{
							flag2 = !this.ovC(byte_1[0]);
							goto IL_0186;
						}
						IL_0185:
						flag2 = false;
						IL_0186:
						if (flag2)
						{
							array = lXu.f(string_0);
						}
						else
						{
							array = lXu.f(string_0);
							lyh lyh = Eyf.AS<string, string>(lmD);
							while (lyh.MPP())
							{
								string text3 = (string)lyh.MPX();
								if (text3.Length == 8)
								{
									array = lXu.f(text3);
								}
							}
						}
					}
					else
					{
						array[0] = 42;
						array[1] = 0;
					}
					byte[] array2 = null;
					try
					{
						string text4 = lXu.K(array, 0, 8);
						if (text4[0] == '*')
						{
							text4 = "*";
						}
						string text5 = null;
						if (lmD == null)
						{
							RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey(text);
							if (registryKey2 != null)
							{
								text5 = (string)registryKey2.GetValue(text4);
							}
						}
						else
						{
							text5 = lmD.m(text4);
						}
						if (text5 == null)
						{
							return 8;
						}
						array2 = lXu.f(text5 + "\0");
					}
					catch (Exception)
					{
						return 8;
					}
					int num;
					if (array[0] != 42)
					{
						num = lXu.mC(byte_1[0], array, array2, byte_0);
					}
					else
					{
						num = lXu.mC(byte_1[0], null, array2, byte_0);
					}
					if (num == 0)
					{
						num = lXu.ef(byte_1[0], this.oUq());
					}
					if (num == 0)
					{
						num2 = this.by(byte_1[0]);
					}
					else
					{
						num2 = 8;
					}
				}
				else
				{
					num2 = 10;
				}
			}
			else
			{
				num2 = 7;
			}
			return num2;
			IL_00C4:
			flag = !Eyf.Vx(text2);
			goto IL_0036;
		}

		// Token: 0x060133D4 RID: 78804 RVA: 0x00768258 File Offset: 0x00766458
		public static string bu(string string_0, lmD<string, string> lmD_0)
		{
			if (Eyf.lx(string_0))
			{
				throw new RSBException("ParseLicense", "Parse license failed: empty data.");
			}
			string[] array = Eyf.xD(string_0, true, '\n', false, true);
			if (array == null || array.Length < 3 || !Eyf.ht(array[0], "REGEDIT4"))
			{
				throw new RSBException("ParseLicense", "Parse license failed: no license data.");
			}
			string text = null;
			string text2 = null;
			string text3 = null;
			bool flag = false;
			foreach (string text4 in array)
			{
				if (!Eyf.lx(text4) && !text4.StartsWith("[HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\"))
				{
					if (!text4.StartsWith("[HKEY_LOCAL_MACHINE\\SOFTWARE\\"))
					{
						int num = text4.IndexOf("=");
						if (num >= 0)
						{
							string text5 = Eyf.OD(lcP.IZ(text4, 0, num), "\"");
							string text6 = Eyf.OD(lcP.IG(text4, num + 1), "\"");
							if (flag && Eyf.hr(text5, "@"))
							{
								text = text6;
								flag = false;
							}
							lmD_0.H(text5, text6);
						}
					}
					else
					{
						string[] array2 = Eyf.xD(Eyf.OD(text4, "]"), true, '\\', false, true);
						if (array2 != null)
						{
							if (Eyf.lx(text2) && array2.Length >= 3)
							{
								text2 = array2[2];
							}
							if (array2.Length >= 5)
							{
								if (!array2[4].StartsWith("SUB") && !array2[4].StartsWith("SUC"))
								{
									if (Eyf.lx(text3))
									{
										text3 = array2[4];
									}
								}
								else
								{
									flag = true;
								}
							}
						}
					}
				}
			}
			if (!Eyf.lx(text2) && !Eyf.lx(text3) && lmD_0.ContainsKey("@"))
			{
				lmD_0.H("_regkey", text2);
				lmD_0.H("_prod", text3);
				if (!lmD_0.ContainsKey(text3))
				{
					if (!Eyf.lx(text))
					{
						lmD_0.H(text3, text);
					}
					else
					{
						lmD_0.H(text3, "X" + lmD_0.m("@"));
					}
				}
				return lmD_0.m(text3);
			}
			throw new RSBException("ParseLicense", "Parse license failed: invalid license data.");
		}

		// Token: 0x060133D5 RID: 78805 RVA: 0x007684BC File Offset: 0x007666BC
		private static bool bQ(DateTime dateTime_0)
		{
			return (DateTime.Now - dateTime_0).TotalHours > 24.0;
		}

		// Token: 0x060133D6 RID: 78806 RVA: 0x007684E8 File Offset: 0x007666E8
		private int bH(byte[] byte_0)
		{
			if (byte_0 == null || byte_0.Length == 0)
			{
				return -1;
			}
			if (rrh.K(byte_0))
			{
				return lXu.eD(byte_0);
			}
			if (!this.oUk(byte_0))
			{
				return -1;
			}

			byte_0[byte_0.Length - 1] = 0;
			lXu.ma(byte_0, 0);
			int today = rrh.j();
			int dayAfterExpiration = this.oUR(byte_0) + 1;
			if (dayAfterExpiration < 0)
			{
				dayAfterExpiration = today + 1;
			}
			return dayAfterExpiration - today;
		}

		// Token: 0x060133D7 RID: 78807 RVA: 0x00768560 File Offset: 0x00766760
		private int by(byte[] byte_0)
		{
			int status = lXu.eW(byte_0);
			if (status == 0 && this.oUk(byte_0) && this.i(byte_0) != 1 && this.Q(byte_0) <= 0)
			{
				return 9;
			}
			return status;
		}

		// Token: 0x060133D8 RID: 78808 RVA: 0x007685AC File Offset: 0x007667AC
		private void bi(string string_0, string string_1, bool bool_0)
		{
			string text = string.Concat(new string[]
			{
				"https://arc-lic.cdata.com/lic/?prod=",
				this.oUI(),
				"&nodeid=",
				string_0,
				"&canemail=1&c=2&setup=true&a=vset&sno=",
				string_1
			});
			if (bool_0)
			{
				text += "&reactivate=true";
			}
			string text2 = "";
			try
			{
				text2 = rrh.m("arc-lic.cdata.com", text);
			}
			catch (Exception)
			{
				throw new RSBException("InvalidLicense", "Unable to " + ((!bool_0) ? "activate" : "re-activate subscription") + " license.  Make sure the application can connect to arc-lic.cdata.com.");
			}
			if (text2 == null || text2.IndexOf("REGEDIT") < 0)
			{
				throw new RSBException("InstallLicense", (!bool_0) ? "Unable to install license. Please check your product key." : "Unable to re-activate subscription license. Please contact arcsales@cdata.com to re-activate this license.");
			}
			Eyf.VJ(text2, this.oUw(), false);
		}

		// Token: 0x060133D9 RID: 78809 RVA: 0x0009ABDC File Offset: 0x00098DDC
		public static bool bE()
		{
			return false;
		}

		// Token: 0x04008DD6 RID: 36310
		private new static DateTime j = new DateTime(0L);

		// Token: 0x04008DD7 RID: 36311
		private new static object t = new object();
	}
}
