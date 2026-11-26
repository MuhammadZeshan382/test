using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading;
using Microsoft.Win32.SafeHandles;

namespace Arc264y
{
	// Token: 0x020011E0 RID: 4576
	internal sealed class Ecg
	{
		// Token: 0x06011AC7 RID: 72391 RVA: 0x006C0904 File Offset: 0x006BEB04
		static Ecg()
		{
			string text = Eyf.Dx(Eyf.UO(EEJ.vH(), "CData"));
			string text2 = Eyf.Dx(Eyf.UO(EEJ.vW(), Eyf.rB()));
			string text3 = Ecg.MO(new string[]
			{
				Path.GetTempPath(),
				text,
				text2,
				"cs",
				"app"
			});
			if (!Ecg.U)
			{
				text3 = Ecg.c(text3);
			}
			Ecg.E = text3;
		}

		// Token: 0x06011AC8 RID: 72392 RVA: 0x000438BC File Offset: 0x00041ABC
		private Ecg()
		{
		}

		// Token: 0x06011AC9 RID: 72393 RVA: 0x006C09DC File Offset: 0x006BEBDC
		private static bool j()
		{
			return !Ecg.k;
		}

		// Token: 0x06011ACA RID: 72394 RVA: 0x006C09F4 File Offset: 0x006BEBF4
		public static bool G()
		{
			return Ecg.U;
		}

		// Token: 0x06011ACB RID: 72395 RVA: 0x006C0A08 File Offset: 0x006BEC08
		[Obsolete]
		public static string W(string string_0)
		{
			if (string_0.Length > 0)
			{
				try
				{
					return Path.GetFullPath(string_0);
				}
				catch (Exception)
				{
					bool flag = false;
					char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
					int i = 0;
					while (i < invalidFileNameChars.Length)
					{
						char c = invalidFileNameChars[i];
						if (!string_0.Contains(string.Concat(c)))
						{
							i++;
						}
						else
						{
							flag = true;
							IL_005A:
							if (!flag)
							{
								throw;
							}
							int length = string_0.Length;
							if (length >= 2 && string_0[1] == Path.VolumeSeparatorChar)
							{
								return string_0;
							}
							if (length < 1 || (string_0[0] != Path.DirectorySeparatorChar && string_0[0] != Path.AltDirectorySeparatorChar))
							{
								return Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + string_0;
							}
							return Path.GetFullPath(string.Concat(Path.DirectorySeparatorChar)).Substring(0, 2) + string_0;
						}
					}
					goto IL_005A;
				}
			}
			return Directory.GetCurrentDirectory();
		}

		// Token: 0x06011ACC RID: 72396 RVA: 0x006C0B24 File Offset: 0x006BED24
		public static string t(string string_0)
		{
			string text;
			if (string_0.Length > 0)
			{
				text = Path.GetFullPath(string_0);
			}
			else
			{
				text = Directory.GetCurrentDirectory();
			}
			return text;
		}

		// Token: 0x06011ACD RID: 72397 RVA: 0x006C0B4C File Offset: 0x006BED4C
		[Obsolete]
		public static string c(string string_0)
		{
			EmZ.i(string_0, "path", new object[0]);
			try
			{
				string_0 = Path.GetFullPath(string_0);
				if (File.Exists(string_0) || Directory.Exists(string_0))
				{
					StringBuilder stringBuilder = new StringBuilder(260);
					uint num = Ecg.GetLongPathName(string_0, stringBuilder, stringBuilder.Capacity);
					if (num > 0U)
					{
						string_0 = Path.Combine(new string[] { stringBuilder.ToString() });
					}
				}
				else
				{
					List<string> list = new List<string>();
					string text = Path.GetDirectoryName(string_0);
					list.Add(Path.GetFileName(string_0));
					while (!Directory.Exists(text))
					{
						list.Insert(0, Path.GetFileName(text));
						text = Path.GetDirectoryName(text);
					}
					StringBuilder stringBuilder = new StringBuilder(260);
					uint num = Ecg.GetLongPathName(text, stringBuilder, stringBuilder.Capacity);
					if (num > 0U)
					{
						text = stringBuilder.ToString();
						list.Insert(0, text);
						string_0 = Path.Combine(list.ToArray());
					}
				}
				if (string_0.Length > 1 && char.IsLower(string_0[0]) && string_0[1] == ':')
				{
					string_0 = char.ToUpper(string_0[0]) + string_0.Substring(1);
				}
			}
			catch (Exception)
			{
				string_0 = Ecg.W(string_0);
			}
			return string_0;
		}

		// Token: 0x06011ACE RID: 72398 RVA: 0x006C0CDC File Offset: 0x006BEEDC
		public static string O(string string_0)
		{
			EmZ.i(string_0, "path", new object[0]);
			string fullPath = Path.GetFullPath(string_0);
			if (!File.Exists(fullPath) && !Directory.Exists(fullPath))
			{
				throw EmZ.j("{0} does not exist.", new object[] { fullPath });
			}
			return fullPath;
		}

		// Token: 0x06011ACF RID: 72399 RVA: 0x006C0D30 File Offset: 0x006BEF30
		public static bool n(string string_0, string string_1)
		{
			bool flag;
			if (!Eyf.lx(string_0) && !Eyf.lx(string_1))
			{
				if (!string_0.Equals(string_1))
				{
					if (Ecg.U || !Eyf.hK(string_0, string_1))
					{
						try
						{
							string_0 = Ecg.c(string_0);
						}
						catch (Exception)
						{
						}
						try
						{
							string_1 = Ecg.c(string_1);
						}
						catch (Exception)
						{
						}
						flag = string_0.Equals(string_1) || (!Ecg.U && Eyf.hK(string_0, string_1));
					}
					else
					{
						flag = true;
					}
				}
				else
				{
					flag = true;
				}
			}
			else
			{
				flag = Eyf.ht(string_0, string_1);
			}
			return flag;
		}

		// Token: 0x06011AD0 RID: 72400 RVA: 0x006C0DE8 File Offset: 0x006BEFE8
		public static bool Z(string string_0)
		{
			return string_0 != null && (string_0.StartsWith("\\\\") || string_0.StartsWith("//"));
		}

		// Token: 0x06011AD1 RID: 72401 RVA: 0x006C0E18 File Offset: 0x006BF018
		public static bool Mj(string string_0, string string_1)
		{
			if (!Eyf.lx(string_0))
			{
				goto IL_0094;
			}
			bool flag = false;
			IL_000C:
			if (flag)
			{
				try
				{
					if (string_0.Equals(string_1) || (!Ecg.U && Eyf.hK(string_0, string_1)))
					{
						return Ecg.MG(string_0);
					}
					Ecg.pV pV;
					Ecg.pV pV2;
					if (Ecg.Gh(string_0, out pV) && Ecg.Gh(string_1, out pV2))
					{
						return pV.Q == pV2.Q && pV.F == pV2.F && pV.L == pV2.L;
					}
					return false;
				}
				catch (Exception)
				{
					return false;
				}
				goto IL_0094;
			}
			return false;
			IL_0094:
			flag = !Eyf.lx(string_1);
			goto IL_000C;
		}

		// Token: 0x06011AD2 RID: 72402 RVA: 0x006C0EDC File Offset: 0x006BF0DC
		public static bool MG(string string_0)
		{
			Eyf.FO(string_0, "file", new object[0]);
			return File.Exists(string_0) || Directory.Exists(string_0);
		}

		// Token: 0x06011AD3 RID: 72403 RVA: 0x006C0F0C File Offset: 0x006BF10C
		public static bool Mi(string string_0)
		{
			if (!Ecg.MW(string_0))
			{
				try
				{
					lcX lcX = new lci(string_0);
					try
					{
						lcX.x();
					}
					finally
					{
						lcX.MPe();
					}
					return true;
				}
				catch (Exception)
				{
					goto IL_002D;
				}
				goto IL_0029;
				IL_002D:
				return false;
			}
			IL_0029:
			return true;
		}

		// Token: 0x06011AD4 RID: 72404 RVA: 0x006C0F68 File Offset: 0x006BF168
		public static bool MW(string string_0)
		{
			return Directory.Exists(string_0);
		}

		// Token: 0x06011AD5 RID: 72405 RVA: 0x006C0F7C File Offset: 0x006BF17C
		public static bool Mt(string string_0)
		{
			return File.Exists(string_0);
		}

		// Token: 0x06011AD6 RID: 72406 RVA: 0x006C0F90 File Offset: 0x006BF190
		public static string Mc(string string_0, string string_1)
		{
			EmZ.i(string_0, "ParentPath", new object[0]);
			EmZ.i(string_1, "ChildPath", new object[0]);
			string_0 = Ecg.W(string_0);
			string_1 = Ecg.W(string_1);
			if (Ecg.MV(string_0) || Ecg.MV(string_1))
			{
				string_0 = Ecg.c(string_0);
				string_1 = Ecg.c(string_1);
			}
			if (!string_0.EndsWith(lya.Q))
			{
				string_0 += lya.Q;
			}
			if (string_1.EndsWith(lya.Q))
			{
				string_1 = lcP.IZ(string_1, 0, string_1.Length - 1);
			}
			string text;
			if (!Eyf.UK(string_1, string_0, !Ecg.U))
			{
				text = null;
			}
			else
			{
				text = lcP.IG(string_1, string_0.Length);
			}
			return text;
		}

		// Token: 0x06011AD7 RID: 72407 RVA: 0x006C1068 File Offset: 0x006BF268
		private static bool MV(string string_0)
		{
			return string_0.Equals("..") || string_0.StartsWith(Ecg.q) || string_0.EndsWith(lya.Q + "..") || string_0.Contains(lya.Q + Ecg.q);
		}

		// Token: 0x06011AD8 RID: 72408 RVA: 0x006C10C0 File Offset: 0x006BF2C0
		public static string MO(params string[] string_0)
		{
			EmZ.i(string_0, "paths", new object[0]);
			lcc lcc = new lcc();
			if (string_0.Length > 0)
			{
				for (int i = 0; i < string_0.Length; i++)
				{
					EmZ.i(string_0[i], "paths[{0}]", new object[] { i });
					if (Path.IsPathRooted(string_0[i]))
					{
						lcc.j(0);
					}
					lcc.MPI(string_0[i]);
					if (!string_0[i].EndsWith(lya.Q))
					{
						lcc.MPI(lya.Q);
					}
				}
				if (!lcc.ToString().Equals(lya.Q))
				{
					lcc.j(lcc.D - 1);
				}
			}
			return lcc.ToString();
		}

		// Token: 0x06011AD9 RID: 72409 RVA: 0x006C118C File Offset: 0x006BF38C
		public static string MB(string string_0, params string[] string_1)
		{
			EmZ.i(string_0, "parent", new object[0]);
			EmZ.i(string_1, "children", new object[0]);
			lmr<string> lmr = Eyf.Ox(string_1);
			lmr.u(0, string_0);
			string text = Ecg.MO(lmr.c(typeof(string)));
			if (Eyf.lx(Ecg.Mc(string_0, text)))
			{
				throw EmZ.j("Invalid child path: {0}", new object[] { text });
			}
			return text;
		}

		// Token: 0x06011ADA RID: 72410 RVA: 0x006C120C File Offset: 0x006BF40C
		public static string Mp(string string_0)
		{
			EmZ.i(string_0, "Path", new object[0]);
			string text;
			if (string_0.Length >= 256)
			{
				int num = string_0.LastIndexOf(lya.u);
				if (num <= -1)
				{
					text = string_0;
				}
				else
				{
					text = lcP.IZ(string_0, 0, num);
				}
			}
			else
			{
				text = Path.GetDirectoryName(string_0);
			}
			return text;
		}

		// Token: 0x06011ADB RID: 72411 RVA: 0x006C1268 File Offset: 0x006BF468
		public static string Mn(string string_0)
		{
			return Path.GetFileName(string_0);
		}

		// Token: 0x06011ADC RID: 72412 RVA: 0x006995D4 File Offset: 0x006977D4
		public static string MZ(string string_0)
		{
			return Path.GetFileNameWithoutExtension(string_0);
		}

		// Token: 0x06011ADD RID: 72413 RVA: 0x00698E54 File Offset: 0x00697054
		public static string je(string string_0)
		{
			string text;
			if (!Path.HasExtension(string_0))
			{
				text = "";
			}
			else
			{
				text = Path.GetExtension(string_0);
			}
			return text;
		}

		// Token: 0x06011ADE RID: 72414 RVA: 0x006C1280 File Offset: 0x006BF480
		public static string jM(string string_0)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(string_0);
			if (directoryInfo.Parent != null && directoryInfo.Parent.Exists)
			{
				FileSystemInfo[] fileSystemInfos = directoryInfo.Parent.GetFileSystemInfos(directoryInfo.Name);
				if (fileSystemInfos != null && fileSystemInfos.Length > 0)
				{
					return fileSystemInfos[0].Name;
				}
			}
			return directoryInfo.Name;
		}

		// Token: 0x06011ADF RID: 72415 RVA: 0x006C12E8 File Offset: 0x006BF4E8
		public static string jj()
		{
			string text2;
			if (!Eyf.lx(Ecg.E))
			{
				try
				{
					string text = Ecg.MO(new string[]
					{
						Ecg.E,
						EgJ.ci().cK("yyyyMMddHH")
					});
					if (!Ecg.MG(text))
					{
						Ecg.jl(text);
					}
					text2 = text;
				}
				catch (IOException)
				{
					goto IL_000C;
				}
				return text2;
			}
			IL_000C:
			text2 = Path.GetTempPath();
			return text2;
		}

		// Token: 0x06011AE0 RID: 72416 RVA: 0x006C135C File Offset: 0x006BF55C
		public static string jG()
		{
			return Ecg.E;
		}

		// Token: 0x06011AE1 RID: 72417 RVA: 0x006C1370 File Offset: 0x006BF570
		public static bool ja(string string_0)
		{
			return !Eyf.lx(string_0) && Path.IsPathRooted(string_0);
		}

		// Token: 0x06011AE2 RID: 72418 RVA: 0x00076DA1 File Offset: 0x00074FA1
		public static void jF(string string_0, int int_0, EcX ecX_0)
		{
			Ecg.ji(string_0, int.MaxValue, int_0, ecX_0);
		}

		// Token: 0x06011AE3 RID: 72419 RVA: 0x006C1394 File Offset: 0x006BF594
		public static void ji(string string_0, int int_0, int int_1, EcX ecX_0)
		{
			if (ecX_0 != null)
			{
				EmZ.i(string_0, "Path", new object[0]);
				if (Ecg.MW(string_0))
				{
					if (int_0 < 0)
					{
						throw EmZ.j("Invalid max depth.", new object[0]);
					}
					try
					{
						Ecg.GV(string_0, int_0, int_1, ecX_0);
						return;
					}
					catch (Exception ex)
					{
						throw EmZ.G(Eyf.eD(ex), ex, new object[0]);
					}
				}
				throw EmZ.j("{0} is not directory.", new object[] { string_0 });
			}
		}

		// Token: 0x06011AE4 RID: 72420 RVA: 0x00076DB0 File Offset: 0x00074FB0
		public static void jW(string string_0, int int_0, Ecf ecf_0)
		{
			Ecg.jX(string_0, int.MaxValue, int_0, ecf_0);
		}

		// Token: 0x06011AE5 RID: 72421 RVA: 0x006C1424 File Offset: 0x006BF624
		public static void jX(string string_0, int int_0, int int_1, Ecf ecf_0)
		{
			if (ecf_0 != null)
			{
				EmZ.i(string_0, "Path", new object[0]);
				if (Ecg.MW(string_0))
				{
					if (int_0 < 0)
					{
						throw EmZ.j("Invalid max depth.", new object[0]);
					}
					try
					{
						Ecg.GO(string_0, int_0, int_1, ecf_0, 0);
						return;
					}
					catch (Exception ex)
					{
						throw EmZ.G(Eyf.eD(ex), ex, new object[0]);
					}
				}
				throw EmZ.j("{0} is not directory.", new object[] { string_0 });
			}
		}

		// Token: 0x06011AE6 RID: 72422 RVA: 0x00076DBF File Offset: 0x00074FBF
		public static void jl(string string_0)
		{
			EmZ.i(string_0, "Path", new object[0]);
			Ecg.Gk(new DirectoryInfo(string_0));
		}

		// Token: 0x06011AE7 RID: 72423 RVA: 0x006C14B8 File Offset: 0x006BF6B8
		public static string[] jU(string string_0)
		{
			return Ecg.jd(string_0, null);
		}

		// Token: 0x06011AE8 RID: 72424 RVA: 0x006C14D0 File Offset: 0x006BF6D0
		public static string[] jd(string string_0, string string_1)
		{
			return Directory.GetFiles(string_0, (!Eyf.lx(string_1)) ? string_1 : "*");
		}

		// Token: 0x06011AE9 RID: 72425 RVA: 0x006C14F8 File Offset: 0x006BF6F8
		public static string[] jt(string string_0)
		{
			return Ecg.jc(string_0, null);
		}

		// Token: 0x06011AEA RID: 72426 RVA: 0x006C1510 File Offset: 0x006BF710
		public static string[] jc(string string_0, string string_1)
		{
			return Directory.GetDirectories(string_0, (!Eyf.lx(string_1)) ? string_1 : "*");
		}

		// Token: 0x06011AEB RID: 72427 RVA: 0x00076DDD File Offset: 0x00074FDD
		public static void jq(string string_0, string string_1)
		{
			Ecg.jR(string_0, string_1, "*");
		}

		// Token: 0x06011AEC RID: 72428 RVA: 0x00076DEB File Offset: 0x00074FEB
		public static void jR(string string_0, string string_1, string string_2)
		{
			Ecg.jY(string_0, string_1, string_2, true);
		}

		// Token: 0x06011AED RID: 72429 RVA: 0x00076DF6 File Offset: 0x00074FF6
		public static void jY(string string_0, string string_1, string string_2, bool bool_0)
		{
			Ecg.GB(new DirectoryInfo(string_0), new DirectoryInfo(string_1), string_2, bool_0);
		}

		// Token: 0x06011AEE RID: 72430 RVA: 0x006C1538 File Offset: 0x006BF738
		public static void jh(string string_0, string string_1)
		{
			if (!Ecg.MW(string_0))
			{
				throw EmZ.j("{0} is not directory.", new object[] { string_0 });
			}
			if (Ecg.MG(string_1))
			{
				throw EmZ.j("{0} already exists.", new object[] { string_1 });
			}
			if (Eyf.lx(Ecg.Mc(string_0, string_1)))
			{
				bool flag = false;
				Exception ex = null;
				try
				{
					Directory.Move(string_0, string_1);
					flag = true;
				}
				catch (Exception ex2)
				{
					flag = false;
				}
				if (!flag)
				{
					lya lya = new lya(Ecg.Mp(string_0), "." + Ecg.Mn(string_0) + ".moving" + EgJ.ci().cK("ssffff"));
					try
					{
						Directory.Move(string_0, lya.bn());
						flag = true;
					}
					catch (Exception ex2)
					{
						flag = false;
						ex = ex2;
					}
					if (flag)
					{
						bool flag2 = false;
						try
						{
							Ecg.jq(lya.bn(), string_1);
							flag2 = true;
							Ecg.jV(lya.bn());
							goto IL_0038;
						}
						catch (Exception ex2)
						{
							flag = false;
							lya.bE(new lya(string_0));
							if (!flag2)
							{
								try
								{
									Ecg.jV(string_1);
								}
								catch (Exception)
								{
								}
							}
							ex = ex2;
							goto IL_0038;
						}
						goto IL_0130;
					}
				}
				IL_0038:
				if (flag)
				{
					return;
				}
				IL_0130:
				throw EmZ.G("Unable to move the directory {0} to {1}", ex, new object[] { string_0, string_1 });
			}
			throw EmZ.j("Cannot move directory: {0} to a subdirectory of itself: {1}", new object[] { string_0, string_1 });
		}

		// Token: 0x06011AEF RID: 72431 RVA: 0x006C16CC File Offset: 0x006BF8CC
		public static int jV(string string_0)
		{
			return Ecg.jO(string_0, -1);
		}

		// Token: 0x06011AF0 RID: 72432 RVA: 0x006C16E4 File Offset: 0x006BF8E4
		public static int jO(string string_0, int int_0)
		{
			EcX ecX = null;
			Ecg.pk pk = new Ecg.pk();
			pk.b = int_0;
			int num3;
			if (Ecg.MW(string_0))
			{
				Ecg.pk pk2 = pk;
				int[] array = new int[1];
				pk2.k = array;
				string[] array2 = Ecg.jt(string_0);
				int num = 0;
				while ((pk.b < 0 || pk.k[0] < pk.b) && num < array2.Length)
				{
					string text = array2[num];
					int num2 = 0;
					if (ecX == null)
					{
						ecX = new EcX(pk.L);
					}
					Ecg.jF(text, num2, ecX);
					num++;
				}
				if (pk.b < 0 || pk.k[0] < pk.b)
				{
					string[] array3 = Ecg.jU(string_0);
					num = 0;
					while ((pk.b < 0 || pk.k[0] < pk.b) && num < array3.Length)
					{
						File.Delete(array3[num]);
						num++;
						pk.k[0]++;
					}
				}
				Directory.Delete(string_0);
				pk.k[0]++;
				num3 = pk.k[0];
			}
			else
			{
				if (Ecg.Mt(string_0))
				{
					throw EmZ.j("{0} is not directory.", new object[] { string_0 });
				}
				num3 = 0;
			}
			return num3;
		}

		// Token: 0x06011AF1 RID: 72433 RVA: 0x006C1848 File Offset: 0x006BFA48
		public static void jk(string string_0)
		{
			if (Ecg.MW(string_0))
			{
				string[] fileSystemEntries = Directory.GetFileSystemEntries(string_0);
				if (fileSystemEntries == null || fileSystemEntries.Length <= 0)
				{
					Directory.Delete(string_0, true);
				}
			}
		}

		// Token: 0x06011AF2 RID: 72434 RVA: 0x006C1880 File Offset: 0x006BFA80
		public static void jB(string string_0, string string_1, bool bool_0)
		{
			EmZ.i(string_0, "src", new object[0]);
			EmZ.i(string_1, "dest", new object[0]);
			if (!Ecg.Mt(string_0))
			{
				throw EmZ.j("{0} is not file.", new object[] { string_0 });
			}
			if (!Ecg.MW(string_1))
			{
				if (Ecg.MG(string_1))
				{
					if (!bool_0)
					{
						throw EmZ.j("{0} already exists.", new object[] { string_1 });
					}
					Ecg.jS(string_1);
				}
				File.Copy(string_0, string_1, bool_0);
				return;
			}
			throw EmZ.j("{0} is a directory", new object[] { string_1 });
		}

		// Token: 0x06011AF3 RID: 72435 RVA: 0x006C1928 File Offset: 0x006BFB28
		public static void jp(string string_0, string string_1)
		{
			EmZ.i(string_0, "src", new object[0]);
			EmZ.i(string_1, "dest", new object[0]);
			if (!Ecg.Mt(string_0))
			{
				throw EmZ.j("{0} is not file.", new object[] { string_0 });
			}
			if (Ecg.MW(string_1))
			{
				throw EmZ.j("{0} is a directory", new object[] { string_1 });
			}
			if (Ecg.MG(string_1))
			{
				throw EmZ.j("{0} already exists.", new object[] { string_1 });
			}
			File.Move(string_0, string_1);
		}

		// Token: 0x06011AF4 RID: 72436 RVA: 0x006C19C4 File Offset: 0x006BFBC4
		public static void jS(string string_0)
		{
			if (!File.Exists(string_0))
			{
				if (Directory.Exists(string_0))
				{
					throw EmZ.j("{0} is not file.", new object[] { string_0 });
				}
			}
			else
			{
				File.Delete(string_0);
			}
		}

		// Token: 0x06011AF5 RID: 72437 RVA: 0x006C1A08 File Offset: 0x006BFC08
		[Obsolete]
		public static long jn(string string_0)
		{
			FileInfo fileInfo = new FileInfo(string_0);
			long num;
			if (!fileInfo.Exists && !Directory.Exists(string_0))
			{
				num = 0L;
			}
			else
			{
				num = lyX.Q(fileInfo.LastWriteTime.Ticks);
			}
			return num;
		}

		// Token: 0x06011AF6 RID: 72438 RVA: 0x006C1A54 File Offset: 0x006BFC54
		public static long jZ(string string_0)
		{
			FileInfo fileInfo = new FileInfo(string_0);
			if (!fileInfo.Exists && !Directory.Exists(string_0))
			{
				throw EmZ.j("{0} does not exist.", new object[] { string_0 });
			}
			return lyX.Q(fileInfo.LastWriteTime.Ticks);
		}

		// Token: 0x06011AF7 RID: 72439 RVA: 0x00076E0B File Offset: 0x0007500B
		[Obsolete]
		public static void Ge(string string_0, long long_0)
		{
			new lya(string_0).x(long_0);
		}

		// Token: 0x06011AF8 RID: 72440 RVA: 0x006C1AAC File Offset: 0x006BFCAC
		public static void GM(string string_0, long long_0)
		{
			if (!File.Exists(string_0) && !Directory.Exists(string_0))
			{
				throw EmZ.j("{0} does not exist.", new object[] { string_0 });
			}
			new lya(string_0).x(long_0);
		}

		// Token: 0x06011AF9 RID: 72441 RVA: 0x006C1AF4 File Offset: 0x006BFCF4
		[Obsolete]
		public static long Gj(string string_0)
		{
			long num2;
			try
			{
				long num = 0L;
				FileInfo fileInfo = new FileInfo(string_0);
				if (fileInfo.Exists || Directory.Exists(string_0))
				{
					num = lyX.Q(fileInfo.CreationTime.Ticks);
				}
				num2 = ((num >= Ecg.V) ? num : 0L);
			}
			catch (Exception)
			{
				num2 = 0L;
			}
			return num2;
		}

		// Token: 0x06011AFA RID: 72442 RVA: 0x006C1B74 File Offset: 0x006BFD74
		public static long GG(string string_0)
		{
			FileInfo fileInfo = new FileInfo(string_0);
			if (!fileInfo.Exists && !Directory.Exists(string_0))
			{
				throw EmZ.j("{0} does not exist.", new object[] { string_0 });
			}
			long num = lyX.Q(fileInfo.CreationTime.Ticks);
			return (num >= Ecg.V) ? num : 0L;
		}

		// Token: 0x06011AFB RID: 72443 RVA: 0x006C1BF0 File Offset: 0x006BFDF0
		[Obsolete]
		public static long Ga(string string_0)
		{
			return new lya(string_0).K;
		}

		// Token: 0x06011AFC RID: 72444 RVA: 0x006C1C0C File Offset: 0x006BFE0C
		public static long GF(string string_0)
		{
			if (!File.Exists(string_0) && !Directory.Exists(string_0))
			{
				throw EmZ.j("{0} does not exist.", new object[] { string_0 });
			}
			return new lya(string_0).K;
		}

		// Token: 0x06011AFD RID: 72445 RVA: 0x006C1C54 File Offset: 0x006BFE54
		public static string Gi(string string_0)
		{
			return Ecg.GW(string_0, "utf-8");
		}

		// Token: 0x06011AFE RID: 72446 RVA: 0x006C1C70 File Offset: 0x006BFE70
		public static string GW(string string_0, string string_1)
		{
			string text;
			try
			{
				text = Eyf.In(Ecg.GX(string_0), string_1);
			}
			catch (Exception ex)
			{
				throw EmZ.G(Eyf.eD(ex), ex, new object[0]);
			}
			return text;
		}

		// Token: 0x06011AFF RID: 72447 RVA: 0x006C1CB4 File Offset: 0x006BFEB4
		public static byte[] GX(string string_0)
		{
			EmZ.i(string_0, "Path", new object[0]);
			lcX lcX = new lcl(new lci(string_0));
			byte[] array;
			try
			{
				array = Ecv.u(lcX);
			}
			finally
			{
				lcX.MPe();
			}
			return array;
		}

		// Token: 0x06011B00 RID: 72448 RVA: 0x00076E1A File Offset: 0x0007501A
		public static void Gl(string string_0, string string_1)
		{
			Ecg.GU(string_0, string_1, true);
		}

		// Token: 0x06011B01 RID: 72449 RVA: 0x00076E24 File Offset: 0x00075024
		public static void GU(string string_0, string string_1, bool bool_0)
		{
			Ecg.Gd(string_0, string_1, "utf-8", bool_0);
		}

		// Token: 0x06011B02 RID: 72450 RVA: 0x006C1D0C File Offset: 0x006BFF0C
		public static void Gd(string string_0, string string_1, string string_2, bool bool_0)
		{
			try
			{
				Ecg.Gc(string_0, Eyf.Ip(string_1, string_2), bool_0);
			}
			catch (Exception ex)
			{
				throw EmZ.G(Eyf.eD(ex), ex, new object[0]);
			}
		}

		// Token: 0x06011B03 RID: 72451 RVA: 0x00076E33 File Offset: 0x00075033
		public static void Gt(string string_0, byte[] byte_0)
		{
			Ecg.Gc(string_0, byte_0, true);
		}

		// Token: 0x06011B04 RID: 72452 RVA: 0x006C1D50 File Offset: 0x006BFF50
		public static void Gc(string string_0, byte[] byte_0, bool bool_0)
		{
			EmZ.i(string_0, "Path", new object[0]);
			EmZ.i(byte_0, "Data", new object[0]);
			Ecg.jl(Ecg.Mp(string_0));
			lcX lcX = new lcr(new lch(string_0, bool_0));
			try
			{
				Ecv.j(lcX, byte_0, 0, byte_0.Length);
			}
			finally
			{
				lcX.MPe();
			}
		}

		// Token: 0x06011B05 RID: 72453
		[DllImport("kernel32.dll", BestFitMapping = false, CharSet = CharSet.Auto, SetLastError = true)]
		private static extern uint GetLongPathName(string string_0, [Out] StringBuilder stringBuilder_0, int int_0);

		// Token: 0x06011B06 RID: 72454
		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		private static extern SafeFileHandle CreateFileW(string string_0, uint uint_0, uint uint_1, IntPtr intptr_0, uint uint_2, uint uint_3, IntPtr intptr_1);

		// Token: 0x06011B07 RID: 72455
		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool GetFileInformationByHandle(SafeFileHandle safeFileHandle_0, out Ecg.pV pV_0);

		// Token: 0x06011B08 RID: 72456 RVA: 0x006C1DC8 File Offset: 0x006BFFC8
		private static bool Gh(string string_0, out Ecg.pV pV_0)
		{
			pV_0 = default(Ecg.pV);
			bool flag;
			using (SafeFileHandle safeFileHandle = Ecg.CreateFileW(string_0, 0U, 7U, IntPtr.Zero, 3U, 33554432U, IntPtr.Zero))
			{
				if (!safeFileHandle.IsInvalid)
				{
					flag = Ecg.GetFileInformationByHandle(safeFileHandle, out pV_0);
				}
				else
				{
					flag = false;
				}
			}
			return flag;
		}

		// Token: 0x06011B09 RID: 72457 RVA: 0x006C1E2C File Offset: 0x006C002C
		private static bool GV(string string_0, int int_0, int int_1, EcX ecX_0)
		{
			bool flag;
			if (int_0 >= 0)
			{
				if (!File.Exists(string_0))
				{
					if (int_0 != 0)
					{
						if (int_1 == 1 && !ecX_0(string_0, true))
						{
							flag = false;
						}
						else
						{
							foreach (string text in Directory.EnumerateFileSystemEntries(string_0))
							{
								if (!Eyf.lx(text))
								{
									bool flag2;
									if (!File.Exists(text))
									{
										flag2 = Ecg.GV(text, int_0 - 1, int_1, ecX_0);
									}
									else
									{
										flag2 = ecX_0(text, false);
									}
									if (!flag2)
									{
										return false;
									}
								}
							}
							flag = int_1 != 0 || ecX_0(string_0, true);
						}
					}
					else
					{
						flag = ecX_0(string_0, true);
					}
				}
				else
				{
					flag = ecX_0(string_0, false);
				}
			}
			else
			{
				flag = true;
			}
			return flag;
		}

		// Token: 0x06011B0A RID: 72458 RVA: 0x006C1EF8 File Offset: 0x006C00F8
		private static bool GO(string string_0, int int_0, int int_1, Ecf ecf_0, int int_2)
		{
			bool flag2;
			if (int_0 >= 0)
			{
				bool flag;
				EcE ecE;
				if (!(flag = Directory.Exists(string_0)))
				{
					if (!File.Exists(string_0))
					{
						return true;
					}
					FileInfo fileInfo = new FileInfo(string_0);
					ecE = new EcE(lyX.Q(fileInfo.LastWriteTime.Ticks), lyX.Q(fileInfo.CreationTime.Ticks), fileInfo.Length);
				}
				else
				{
					DirectoryInfo directoryInfo = new DirectoryInfo(string_0);
					ecE = new EcE(lyX.Q(directoryInfo.LastWriteTime.Ticks), lyX.Q(directoryInfo.CreationTime.Ticks), 0L);
				}
				if (flag)
				{
					if (int_0 != 0)
					{
						if (int_1 == 1 && !ecf_0(string_0, true, ecE, int_2))
						{
							flag2 = false;
						}
						else
						{
							foreach (string text in Directory.EnumerateFileSystemEntries(string_0))
							{
								if (!Eyf.lx(text))
								{
									bool flag3;
									if (!File.Exists(text))
									{
										flag3 = Ecg.GO(text, int_0 - 1, int_1, ecf_0, int_2 + 1);
									}
									else
									{
										FileInfo fileInfo = new FileInfo(text);
										EcE ecE2 = new EcE(lyX.Q(fileInfo.LastWriteTime.Ticks), lyX.Q(fileInfo.CreationTime.Ticks), fileInfo.Length);
										flag3 = ecf_0(text, false, ecE2, int_2 + 1);
									}
									if (!flag3)
									{
										return false;
									}
								}
							}
							flag2 = int_1 != 0 || ecf_0(string_0, true, ecE, int_2);
						}
					}
					else
					{
						flag2 = ecf_0(string_0, true, ecE, int_2);
					}
				}
				else
				{
					flag2 = ecf_0(string_0, false, ecE, int_2);
				}
			}
			else
			{
				flag2 = true;
			}
			return flag2;
		}

		// Token: 0x06011B0B RID: 72459 RVA: 0x00076E3D File Offset: 0x0007503D
		private static void Gk(DirectoryInfo directoryInfo_0)
		{
			directoryInfo_0.Create();
		}

		// Token: 0x06011B0C RID: 72460 RVA: 0x006C20E4 File Offset: 0x006C02E4
		private static void GB(DirectoryInfo directoryInfo_0, DirectoryInfo directoryInfo_1, string string_0, bool bool_0)
		{
			if (directoryInfo_0.Exists)
			{
				if (!directoryInfo_1.Exists)
				{
					Ecg.Gk(directoryInfo_1);
				}
				if (!bool_0)
				{
					FileSystemInfo[] array = directoryInfo_0.GetFileSystemInfos(string_0);
					foreach (FileSystemInfo fileSystemInfo in array)
					{
						string text = Path.Combine(directoryInfo_1.FullName, fileSystemInfo.Name);
						if ((fileSystemInfo.Attributes & FileAttributes.Directory) != FileAttributes.Directory)
						{
							Ecg.jB(fileSystemInfo.FullName, text, false);
						}
						else
						{
							Ecg.GB((DirectoryInfo)fileSystemInfo, new DirectoryInfo(text), "*", true);
						}
					}
				}
				else
				{
					FileSystemInfo[] array = directoryInfo_0.GetFileSystemInfos();
					if (array != null && array.Length > 0)
					{
						foreach (FileSystemInfo fileSystemInfo in array)
						{
							bool flag = ((!Ecg.U) ? Eyr.B(fileSystemInfo.Name, string_0) : Eyr.V(fileSystemInfo.Name, string_0));
							string text = Ecg.MO(new string[] { directoryInfo_1.FullName, fileSystemInfo.Name });
							if ((fileSystemInfo.Attributes & FileAttributes.Directory) != FileAttributes.Directory)
							{
								if (flag)
								{
									Ecg.jB(fileSystemInfo.FullName, text, false);
								}
							}
							else
							{
								Ecg.GB((DirectoryInfo)fileSystemInfo, new DirectoryInfo(text), (!flag) ? string_0 : "*", true);
							}
						}
					}
				}
			}
		}

		// Token: 0x06011B0D RID: 72461 RVA: 0x006C225C File Offset: 0x006C045C
		public static m Gp<m>(Ecy<m> ecy_0)
		{
			return Ecg.GS<m>(ecy_0, 200);
		}

		// Token: 0x06011B0E RID: 72462 RVA: 0x006C2278 File Offset: 0x006C0478
		public static Y GS<Y>(Ecy<Y> ecy_0, int int_0)
		{
			EmZ.i(ecy_0, "Task", new object[0]);
			Ecg.aj(int_0);
			int num = int_0;
			int num2 = 1;
			Y y;
			for (;;)
			{
				try
				{
					y = ecy_0();
					break;
				}
				catch (Exception ex)
				{
					if (num2 >= 5 || !Ecg.aG(ex))
					{
						throw;
					}
				}
				Thread.Sleep(num);
				num *= 2;
				num2++;
			}
			return y;
		}

		// Token: 0x06011B0F RID: 72463 RVA: 0x00076E45 File Offset: 0x00075045
		public static void Gn(Ecc ecc_0)
		{
			Ecg.GZ(ecc_0, 200);
		}

		// Token: 0x06011B10 RID: 72464 RVA: 0x006C22E4 File Offset: 0x006C04E4
		public static void GZ(Ecc ecc_0, int int_0)
		{
			EmZ.i(ecc_0, "Action", new object[0]);
			Ecg.aj(int_0);
			int num = int_0;
			int num2 = 1;
			for (;;)
			{
				try
				{
					ecc_0();
					break;
				}
				catch (Exception ex)
				{
					if (num2 >= 5 || !Ecg.aG(ex))
					{
						throw;
					}
				}
				Thread.Sleep(num);
				num *= 2;
				num2++;
			}
		}

		// Token: 0x06011B11 RID: 72465 RVA: 0x006C234C File Offset: 0x006C054C
		private static void aj(int int_0)
		{
			if (int_0 < 0)
			{
				throw EmZ.j("Invalid initial retry delay: {0}.", new object[] { int_0 });
			}
		}

		// Token: 0x06011B12 RID: 72466 RVA: 0x006C2380 File Offset: 0x006C0580
		private static bool aG(Exception exception_0)
		{
			for (Exception ex = exception_0; ex != null; ex = ex.InnerException)
			{
				if (Ecg.ai(ex))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06011B13 RID: 72467 RVA: 0x006C23B8 File Offset: 0x006C05B8
		private static bool ai(Exception exception_0)
		{
			bool flag;
			if (!(exception_0 is UnauthorizedAccessException) && !(exception_0 is SecurityException) && !(exception_0 is ArgumentException) && !(exception_0 is NullReferenceException) && !(exception_0 is NotSupportedException) && !(exception_0 is ThreadInterruptedException) && !(exception_0 is OperationCanceledException))
			{
				if (exception_0 is IOException)
				{
					int hrforException = Marshal.GetHRForException(exception_0);
					if ((hrforException & -65536) == -2147024896)
					{
						int num = hrforException & 65535;
						if (num == 5 || num == 39 || num == 80 || num == 112 || num == 145 || num == 183)
						{
							return true;
						}
					}
				}
				string message = exception_0.Message;
				foreach (string text in Ecg.S)
				{
					if (Eyf.hD(message, text, true))
					{
						return true;
					}
				}
				flag = false;
			}
			else
			{
				flag = true;
			}
			return flag;
		}

		// Token: 0x04007C3A RID: 31802
		public const int D = 0;

		// Token: 0x04007C3B RID: 31803
		public const int p = 1;

		// Token: 0x04007C3C RID: 31804
		private const int x = 5;

		// Token: 0x04007C3D RID: 31805
		private const int w = 200;

		// Token: 0x04007C3E RID: 31806
		private const int R = 5;

		// Token: 0x04007C3F RID: 31807
		private const int A = 39;

		// Token: 0x04007C40 RID: 31808
		private const int B = 80;

		// Token: 0x04007C41 RID: 31809
		private const int l = 112;

		// Token: 0x04007C42 RID: 31810
		private const int i = 145;

		// Token: 0x04007C43 RID: 31811
		private const int C = 183;

		// Token: 0x04007C44 RID: 31812
		private static string[] S = new string[] { "permission denied", "access is denied", "no space left on device", "not enough space on the disk" };

		// Token: 0x04007C45 RID: 31813
		private static bool k = true;

		// Token: 0x04007C46 RID: 31814
		private static long V = 378691200000L;

		// Token: 0x04007C47 RID: 31815
		private static readonly string E;

		// Token: 0x04007C48 RID: 31816
		private static readonly bool U = Ecg.j();

		// Token: 0x04007C49 RID: 31817
		private static readonly string q = ".." + lya.Q;

		// Token: 0x020011E1 RID: 4577
		private struct pV
		{
			// Token: 0x04007C4A RID: 31818
			public uint C;

			// Token: 0x04007C4B RID: 31819
			public uint k;

			// Token: 0x04007C4C RID: 31820
			public uint H;

			// Token: 0x04007C4D RID: 31821
			public uint M;

			// Token: 0x04007C4E RID: 31822
			public uint d;

			// Token: 0x04007C4F RID: 31823
			public uint U;

			// Token: 0x04007C50 RID: 31824
			public uint s;

			// Token: 0x04007C51 RID: 31825
			public uint Q;

			// Token: 0x04007C52 RID: 31826
			public uint V;

			// Token: 0x04007C53 RID: 31827
			public uint n;

			// Token: 0x04007C54 RID: 31828
			public uint T;

			// Token: 0x04007C55 RID: 31829
			public uint F;

			// Token: 0x04007C56 RID: 31830
			public uint L;
		}

		// Token: 0x020011E2 RID: 4578
		[CompilerGenerated]
		private sealed class pk
		{
			// Token: 0x06011B15 RID: 72469 RVA: 0x006C24C4 File Offset: 0x006C06C4
			public bool L(string string_0, bool bool_0)
			{
				if (!bool_0)
				{
					File.Delete(string_0);
				}
				else
				{
					Directory.Delete(string_0);
				}
				this.k[0]++;
				return this.b < 0 || this.k[0] < this.b;
			}

			// Token: 0x04007C57 RID: 31831
			public int[] k;

			// Token: 0x04007C58 RID: 31832
			public int b;
		}
	}
}
