using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using RSSBus;

namespace Arc264y
{
	// Token: 0x020011A1 RID: 4513
	internal class Eyf
	{
		// Token: 0x0601147D RID: 70781 RVA: 0x006981B4 File Offset: 0x006963B4
		public static Stream V(RSBContext rsbcontext_0, string string_0)
		{
			Stream stream;
			try
			{
				RSBFileService rsbfileService = Eyf.tV(rsbcontext_0);
				stream = rsbfileService.Open(string_0, "r", false);
			}
			catch (Exception ex)
			{
				throw new Egs(ex.Message);
			}
			return stream;
		}

		// Token: 0x0601147E RID: 70782 RVA: 0x006981F8 File Offset: 0x006963F8
		public static Stream p(RSBContext rsbcontext_0, string string_0)
		{
			return Eyf.D(rsbcontext_0, string_0, false);
		}

		// Token: 0x0601147F RID: 70783 RVA: 0x00698210 File Offset: 0x00696410
		public static Stream D(RSBContext rsbcontext_0, string string_0, bool bool_0)
		{
			Stream stream;
			try
			{
				RSBFileService rsbfileService = Eyf.tV(rsbcontext_0);
				stream = rsbfileService.OpenWrite(string_0, "frw", bool_0);
			}
			catch (Exception ex)
			{
				throw new Egs(ex.Message);
			}
			return stream;
		}

		// Token: 0x06011480 RID: 70784 RVA: 0x00698254 File Offset: 0x00696454
		public static string m(RSBContext rsbcontext_0, string string_0)
		{
			string text;
			try
			{
				RSBFileService rsbfileService = Eyf.tV(rsbcontext_0);
				text = rsbfileService.GetFileName(string_0);
			}
			catch (Exception)
			{
				int length = string_0.Length;
				int num = length;
				while (--num >= 0)
				{
					char c = string_0[num];
					if (c == '\\' || c == '/' || c == ':')
					{
						return string_0.Substring(num + 1, length - num - 1);
					}
				}
				text = string_0;
			}
			return text;
		}

		// Token: 0x06011481 RID: 70785 RVA: 0x006982DC File Offset: 0x006964DC
		public static void x(lyZ lyZ_0)
		{
			if (lyZ_0 != null)
			{
				lyZ lyZ = new lyZ();
				lyh lyh = Eyf.AK(lyZ_0);
				while (lyh.MPP())
				{
					object obj = lyh.MPX();
					object obj2 = lyZ_0.G(obj);
					if (!(obj is string))
					{
						lyZ.E(obj, obj2);
					}
					else
					{
						lyZ.E(((string)obj).ToLower(), obj2);
					}
				}
				lyZ_0.Clear();
				lyh = Eyf.AK(lyZ);
				while (lyh.MPP())
				{
					object obj = lyh.MPX();
					object obj2 = lyZ.G(obj);
					lyZ_0.E(obj, obj2);
				}
			}
		}

		// Token: 0x06011482 RID: 70786 RVA: 0x00698378 File Offset: 0x00696578
		public static void n<a>(lmD<string, a> lmD_0)
		{
			if (lmD_0 != null)
			{
				lmD<string, a> lmD = new lmD<string, a>();
				lyh lyh = Eyf.AS<string, a>(lmD_0);
				while (lyh.MPP())
				{
					string text = (string)lyh.MPX();
					a a = lmD_0.m(text);
					lmD.H(text.ToLower(), a);
				}
				lmD_0.Clear();
				lyh = Eyf.AS<string, a>(lmD);
				while (lyh.MPP())
				{
					string text = (string)lyh.MPX();
					a a = lmD.m(text);
					lmD_0.H(text, a);
				}
			}
		}

		// Token: 0x06011483 RID: 70787 RVA: 0x006983FC File Offset: 0x006965FC
		public static void O(lyZ lyZ_0)
		{
			if (lyZ_0 != null)
			{
				lyZ lyZ = (lyZ)lyZ_0.Clone();
				lyh lyh = Eyf.AK(lyZ);
				while (lyh.MPP())
				{
					object obj = lyh.MPX();
					object obj2 = lyZ.G(obj);
					lyZ_0.E(((string)obj).ToLower(), obj2);
				}
			}
		}

		// Token: 0x06011484 RID: 70788 RVA: 0x00698454 File Offset: 0x00696654
		public static string A(string string_0)
		{
			lya lya = new lya(Eyf.JB(string_0));
			return lya.E();
		}

		// Token: 0x06011485 RID: 70789 RVA: 0x00698478 File Offset: 0x00696678
		public static long r(string string_0)
		{
			lya lya = new lya(Eyf.JB(string_0));
			return lya.A();
		}

		// Token: 0x06011486 RID: 70790 RVA: 0x0069849C File Offset: 0x0069669C
		public static string JB(string string_0)
		{
			string text = string_0;
			Uri uri = null;
			if (Uri.TryCreate(string_0, UriKind.Absolute, out uri))
			{
				try
				{
					EyX eyX = new EyX(string_0);
					text = eyX.x();
				}
				catch (Exception)
				{
				}
			}
			return text;
		}

		// Token: 0x06011487 RID: 70791 RVA: 0x006984E4 File Offset: 0x006966E4
		public static void JV(object object_0, int int_0)
		{
			long num = lyc.G() + (long)int_0;
			while (lyc.G() < num)
			{
				Eyf.Jp(object_0, 50, true);
			}
		}

		// Token: 0x06011488 RID: 70792 RVA: 0x00698510 File Offset: 0x00696710
		public static void Jp(object object_0, int int_0, bool bool_0)
		{
			lock (object_0)
			{
				if (int_0 < 0)
				{
					throw new RSBException("UtilitiesDoEvents", "Timeout.");
				}
				if (bool_0)
				{
					Application.DoEvents();
				}
				if (int_0 > 0)
				{
					Monitor.Wait(object_0, (int_0 <= 20) ? int_0 : 20);
				}
			}
		}

		// Token: 0x06011489 RID: 70793 RVA: 0x0069858C File Offset: 0x0069678C
		public static string JD(string string_0, string string_1)
		{
			if (string_0 == null)
			{
				string_0 = Eyf.Vw(string_1);
			}
			string text = Eyf.VU(string_0, Eyf.A(string_1) + ".lock");
			string text2;
			if (!Eyf.Vx(text))
			{
				Eyf.Ve(string_0);
				bool flag = false;
				try
				{
					flag = new lya(text).bm();
				}
				catch (Exception ex)
				{
					if (!(ex is IOException))
					{
						throw new RSBException("CoreException", Eyf.eD(ex), ex);
					}
				}
				text2 = ((!flag) ? "" : text);
			}
			else
			{
				text2 = "";
			}
			return text2;
		}

		// Token: 0x0601148A RID: 70794 RVA: 0x00698630 File Offset: 0x00696830
		public static void Jm(string string_0)
		{
			if (Eyf.Vx(string_0))
			{
				new lya(string_0).p();
			}
		}

		// Token: 0x0601148B RID: 70795 RVA: 0x00698654 File Offset: 0x00696854
		public static string Jx(byte[] byte_0)
		{
			string text;
			if (byte_0 != null)
			{
				lcc lcc = new lcc();
				Eyf.Jn(byte_0, lcc);
				text = lcc.ToString();
			}
			else
			{
				text = "";
			}
			return text;
		}

		// Token: 0x0601148C RID: 70796 RVA: 0x00698688 File Offset: 0x00696888
		public static void Jn(byte[] byte_0, lcc lcc_0)
		{
			if (byte_0 != null)
			{
				for (int i = 0; i < byte_0.Length; i++)
				{
					lcc_0.MPI(Eyf.GG[(byte_0[i] & 240) >> 4]);
					lcc_0.MPI(Eyf.GG[(int)(byte_0[i] & 15)]);
				}
			}
		}

		// Token: 0x0601148D RID: 70797 RVA: 0x006986DC File Offset: 0x006968DC
		public static string JO()
		{
			return Path.GetTempPath();
		}

		// Token: 0x0601148E RID: 70798 RVA: 0x006986F0 File Offset: 0x006968F0
		public static byte[] Jt(RSBContext rsbcontext_0, string string_0)
		{
			byte[] array;
			try
			{
				RSBFileService rsbfileService = Eyf.tV(rsbcontext_0);
				array = Eyf.JA(rsbfileService.Open(string_0, "r", false));
			}
			catch (Exception ex)
			{
				throw new Egs(ex);
			}
			return array;
		}

		// Token: 0x0601148F RID: 70799 RVA: 0x00698738 File Offset: 0x00696938
		internal static byte[] JA(lcX lcX_0)
		{
			Ega ega = new Ega();
			try
			{
				byte[] array = new byte[10240];
				int num;
				while ((num = lcX_0.i(array, 0, 10240)) > 0)
				{
					ega.TV(array, 0, num);
				}
			}
			catch (Exception ex)
			{
				throw new Egs(ex);
			}
			finally
			{
				try
				{
					if (lcX_0 != null)
					{
						lcX_0.MPe();
					}
				}
				catch (Exception)
				{
				}
			}
			return ega.ri();
		}

		// Token: 0x06011490 RID: 70800 RVA: 0x00075B2E File Offset: 0x00073D2E
		public static void Jr(RSBContext rsbcontext_0, byte[] byte_0, string string_0)
		{
			Eyf.JK(rsbcontext_0, byte_0, string_0, true);
		}

		// Token: 0x06011491 RID: 70801 RVA: 0x00075B39 File Offset: 0x00073D39
		public static void JK(RSBContext rsbcontext_0, byte[] byte_0, string string_0, bool bool_0)
		{
			Eyf.JZ(rsbcontext_0, byte_0, string_0, bool_0, false);
		}

		// Token: 0x06011492 RID: 70802 RVA: 0x00075B45 File Offset: 0x00073D45
		public static void JZ(RSBContext rsbcontext_0, byte[] byte_0, string string_0, bool bool_0, bool bool_1)
		{
			Eyf.YB(rsbcontext_0, byte_0, string_0, bool_0, bool_1, 0, byte_0.Length);
		}

		// Token: 0x06011493 RID: 70803 RVA: 0x006987C8 File Offset: 0x006969C8
		private static void YB(RSBContext rsbcontext_0, byte[] byte_0, string string_0, bool bool_0, bool bool_1, int int_0, int int_1)
		{
			Stream stream = null;
			try
			{
				RSBFileService rsbfileService = Eyf.tV(rsbcontext_0);
				string text = "fw";
				if (bool_1)
				{
					text += "+";
				}
				stream = rsbfileService.OpenWrite(string_0, text, bool_0);
				stream.Write(byte_0, int_0, int_1);
			}
			catch (IOException ex)
			{
				throw new Egs(ex);
			}
			finally
			{
				try
				{
					if (stream != null)
					{
						stream.Close();
					}
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06011494 RID: 70804 RVA: 0x00698854 File Offset: 0x00696A54
		public static void YV(RSBContext rsbcontext_0, byte[] byte_0, string string_0, bool bool_0, bool bool_1)
		{
			long num = Eyf.Yx(rsbcontext_0.GetInput("maxlogfilesize"));
			int i = byte_0.Length;
			if (num > 0L)
			{
				int num2 = 0;
				while (i > 0)
				{
					long num3 = Eyf.VD(string_0);
					int num4 = (int)Math.Min(num - num3, (long)i);
					if (num4 > 0)
					{
						Eyf.YB(rsbcontext_0, byte_0, string_0, bool_0, bool_1, num2, num4);
						num2 += num4;
						i -= num4;
					}
					Eyf.YD(string_0, num);
				}
			}
			else
			{
				Eyf.JZ(rsbcontext_0, byte_0, string_0, bool_0, bool_1);
			}
		}

		// Token: 0x06011495 RID: 70805 RVA: 0x00075B56 File Offset: 0x00073D56
		public static void Yp(string string_0, string string_1)
		{
			Eyf.YD(string_0, Eyf.Yx(string_1));
		}

		// Token: 0x06011496 RID: 70806 RVA: 0x006988DC File Offset: 0x00696ADC
		public static void YD(string string_0, long long_0)
		{
			if (long_0 > 0L)
			{
				lya lya = new lya(string_0);
				if (lya.K >= long_0)
				{
					Eyf.Ym(string_0);
				}
			}
		}

		// Token: 0x06011497 RID: 70807 RVA: 0x00698910 File Offset: 0x00696B10
		public static void Ym(string string_0)
		{
			lya lya = new lya(string_0);
			lya lya2;
			do
			{
				string text = DateTime.Now.ToString("yyyyMMddHH-mmss");
				string text2 = lya.E();
				string text3 = "";
				int num = text2.IndexOf(".");
				if (num > -1)
				{
					text3 = lcP.IG(text2, num + 1);
					text2 = lcP.IZ(text2, 0, num);
				}
				string text4 = text2 + "-" + text;
				if (text3.Length > 0)
				{
					text4 = text4 + "." + text3;
				}
				lya2 = new lya(lya.m(), text4);
			}
			while (lya2.n());
			lya.bE(lya2);
		}

		// Token: 0x06011498 RID: 70808 RVA: 0x006989C8 File Offset: 0x00696BC8
		public static long Yx(string string_0)
		{
			long num2;
			if (string_0 != null && string_0.Length > 0)
			{
				string_0 = string_0.ToLower();
				int num = 1;
				string text = string_0;
				for (int i = 0; i < Eyf.a.Length; i++)
				{
					if (string_0.EndsWith(Eyf.a[i]))
					{
						text = lcP.IZ(text, 0, text.Length - Eyf.a[i].Length);
						num = Eyf.v[i];
						try
						{
							IL_0077:
							num2 = Math.Max(102400L, (long)num * long.Parse(text));
						}
						catch (Exception)
						{
							num2 = -1L;
						}
						return num2;
					}
				}
				goto IL_0077;
			}
			num2 = -1L;
			return num2;
		}

		// Token: 0x06011499 RID: 70809 RVA: 0x00698A88 File Offset: 0x00696C88
		public static string Yn(string string_0)
		{
			return Eyf.Yt(string_0, "utf-8");
		}

		// Token: 0x0601149A RID: 70810 RVA: 0x00698AA4 File Offset: 0x00696CA4
		public static string YO(string string_0)
		{
			return Eyf.Yt(string_0, null);
		}

		// Token: 0x0601149B RID: 70811 RVA: 0x00698ABC File Offset: 0x00696CBC
		public static string Yt(string string_0, string string_1)
		{
			string text = null;
			TextReader textReader = null;
			try
			{
				if (string.IsNullOrEmpty(string_1))
				{
					textReader = new StreamReader(string_0);
				}
				else
				{
					textReader = new StreamReader(string_0, Encoding.GetEncoding(string_1));
				}
				text = textReader.ReadToEnd();
			}
			catch (Exception ex)
			{
				throw new Egs(ex.Message);
			}
			finally
			{
				if (textReader != null)
				{
					textReader.Close();
				}
			}
			return text;
		}

		// Token: 0x0601149C RID: 70812 RVA: 0x00075B64 File Offset: 0x00073D64
		public static void YA(RSBContext rsbcontext_0, string string_0, string string_1)
		{
			Eyf.Yr(rsbcontext_0, string_0, string_1, true);
		}

		// Token: 0x0601149D RID: 70813 RVA: 0x00698B30 File Offset: 0x00696D30
		public static void Yr(RSBContext rsbcontext_0, string string_0, string string_1, bool bool_0)
		{
			byte[] array = Eyf.Ip(string_0, "utf-8");
			Stream stream = null;
			try
			{
				RSBFileService rsbfileService = Eyf.tV(rsbcontext_0);
				string text = "fw";
				if (bool_0)
				{
					text += "+";
				}
				stream = rsbfileService.OpenWrite(string_1, text, !bool_0);
				stream.Write(array, 0, array.Length);
			}
			catch (IOException ex)
			{
				throw new Egs(ex);
			}
			finally
			{
				try
				{
					if (stream != null)
					{
						stream.Close();
					}
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x0601149E RID: 70814 RVA: 0x00075B6F File Offset: 0x00073D6F
		public static void YK(string string_0, string string_1)
		{
			Eyf.YZ(string_0, string_1, true);
		}

		// Token: 0x0601149F RID: 70815 RVA: 0x00075B79 File Offset: 0x00073D79
		public static void YZ(string string_0, string string_1, bool bool_0)
		{
			Eyf.VY(string_0, string_1, bool_0, "utf-8");
		}

		// Token: 0x060114A0 RID: 70816 RVA: 0x00075B88 File Offset: 0x00073D88
		public static void VB(string string_0, string string_1)
		{
			Eyf.VJ(string_0, string_1, true);
		}

		// Token: 0x060114A1 RID: 70817 RVA: 0x00075B92 File Offset: 0x00073D92
		public static void VJ(string string_0, string string_1, bool bool_0)
		{
			Eyf.VY(string_0, string_1, bool_0, null);
		}

		// Token: 0x060114A2 RID: 70818 RVA: 0x00698BCC File Offset: 0x00696DCC
		public static void VY(string string_0, string string_1, bool bool_0, string string_2)
		{
			TextWriter textWriter = null;
			try
			{
				if (string.IsNullOrEmpty(string_2))
				{
					textWriter = new StreamWriter(string_1, bool_0);
				}
				else
				{
					Encoding encoding = Encoding.GetEncoding(string_2);
					if (encoding is UTF8Encoding)
					{
						encoding = new UTF8Encoding(false);
					}
					textWriter = new StreamWriter(string_1, bool_0, encoding);
				}
				if (!bool_0)
				{
					textWriter.Write(string_0);
				}
				else
				{
					textWriter.WriteLine(string_0);
				}
			}
			catch (Exception ex)
			{
				throw new Egs(ex.Message);
			}
			finally
			{
				if (textWriter != null)
				{
					textWriter.Close();
				}
			}
		}

		// Token: 0x060114A3 RID: 70819 RVA: 0x00698C64 File Offset: 0x00696E64
		public static void VV(string string_0)
		{
			"The specified directory \"" + string_0 + "\" could not be created.";
			try
			{
				Directory.CreateDirectory(string_0);
			}
			catch (Exception ex)
			{
				throw new Egs(ex.Message);
			}
		}

		// Token: 0x060114A4 RID: 70820 RVA: 0x00698CA8 File Offset: 0x00696EA8
		public static bool Vp(string string_0)
		{
			string text = Path.Combine(string_0, Eyf.rB() + ".tmp");
			bool flag;
			try
			{
				using (StreamWriter streamWriter = new StreamWriter(new FileStream(text, FileMode.CreateNew, FileAccess.Write, FileShare.None), Encoding.UTF8))
				{
					streamWriter.WriteLine(text);
				}
				try
				{
					File.Delete(text);
				}
				catch
				{
					Thread.Sleep(text.GetHashCode() % 100 + 100);
					File.Delete(text);
				}
				flag = true;
			}
			catch (Exception)
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x060114A5 RID: 70821 RVA: 0x00698D4C File Offset: 0x00696F4C
		public static bool VC(string string_0)
		{
			if (File.Exists(string_0))
			{
				try
				{
					using (new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
					{
						return true;
					}
				}
				catch (Exception)
				{
					return false;
				}
			}
			return false;
		}

		// Token: 0x060114A6 RID: 70822 RVA: 0x00698DA0 File Offset: 0x00696FA0
		public static string VU(string string_0, string string_1)
		{
			return Eyf.Vh(string_0, string_1, true);
		}

		// Token: 0x060114A7 RID: 70823 RVA: 0x00698DB8 File Offset: 0x00696FB8
		public static string Vh(string string_0, string string_1, bool bool_0)
		{
			string text2;
			if (string_1 != null)
			{
				if (!Eyf.lx(string_0))
				{
					string text = string_1;
					if (!Path.IsPathRooted(string_1) && string_0 != null)
					{
						text = Path.Combine(string_0, string_1);
					}
					text2 = text;
				}
				else
				{
					text2 = string_1;
				}
			}
			else
			{
				text2 = null;
			}
			return text2;
		}

		// Token: 0x060114A8 RID: 70824 RVA: 0x00698E04 File Offset: 0x00697004
		public static long VD(string string_0)
		{
			long num;
			try
			{
				FileInfo fileInfo = new FileInfo(string_0);
				if (fileInfo.Exists)
				{
					num = fileInfo.Length;
				}
				else
				{
					num = 0L;
				}
			}
			catch (Exception)
			{
				num = 0L;
			}
			return num;
		}

		// Token: 0x060114A9 RID: 70825 RVA: 0x00698E54 File Offset: 0x00697054
		public static string Vl(string string_0)
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

		// Token: 0x060114AA RID: 70826 RVA: 0x00698E7C File Offset: 0x0069707C
		public static bool Vm(lya lya_0)
		{
			return !Eyf.lx(lya_0.O()) && lya_0.n();
		}

		// Token: 0x060114AB RID: 70827 RVA: 0x005ACA50 File Offset: 0x005AAC50
		public static bool Vx(string string_0)
		{
			bool flag;
			try
			{
				flag = new lya(string_0).n();
			}
			catch (Exception)
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x060114AC RID: 70828 RVA: 0x00698EA8 File Offset: 0x006970A8
		public static bool Vn(string string_0)
		{
			string text = string_0.ToUpper();
			string[] array = Eyf.xY(text, false, " ");
			return array.Length > 0 && (array[0].Equals("EXEC") || array[0].Equals("EXECUTE"));
		}

		// Token: 0x060114AD RID: 70829 RVA: 0x00698F00 File Offset: 0x00697100
		public static string Vw(string string_0)
		{
			string directoryName = Path.GetDirectoryName(string_0);
			return Path.GetFullPath(directoryName);
		}

		// Token: 0x060114AE RID: 70830 RVA: 0x00698F1C File Offset: 0x0069711C
		public static void VO(RSBContext rsbcontext_0, string string_0)
		{
			RSBFileService rsbfileService = Eyf.tV(rsbcontext_0);
			if (!Directory.Exists(string_0))
			{
				rsbfileService.CreateDir(string_0);
			}
		}

		// Token: 0x060114AF RID: 70831 RVA: 0x00698F40 File Offset: 0x00697140
		public static string VI(string string_0, string string_1)
		{
			bool flag = false;
			string_0 = Eyf.OU(string_0);
			if (string_0[string_0.Length - 1] == '\\' || string_0[string_0.Length - 1] == '/')
			{
				flag = true;
			}
			lya lya = new lya(string_0);
			string text;
			if (flag || lya.E().IndexOf('.') <= -1)
			{
				text = string_0;
				string_0 = Eyf.VU(string_0, string_1);
			}
			else
			{
				text = lya.m();
			}
			if (!Eyf.Vx(text))
			{
				Eyf.VV(text);
			}
			return string_0;
		}

		// Token: 0x060114B0 RID: 70832 RVA: 0x00698FD8 File Offset: 0x006971D8
		public static void Ve(string string_0)
		{
			if (!Directory.Exists(string_0))
			{
				Directory.CreateDirectory(string_0);
			}
		}

		// Token: 0x060114B1 RID: 70833 RVA: 0x00698FF4 File Offset: 0x006971F4
		public static void Vt(string string_0, string string_1)
		{
			bool flag = false;
			Exception ex = null;
			lya lya = new lya(string_0);
			lya lya2 = new lya(string_1);
			try
			{
				Directory.Move(string_0, string_1);
				flag = true;
			}
			catch (Exception ex2)
			{
				flag = false;
				ex = ex2;
			}
			if (!flag)
			{
				lya lya3 = new lya(lya.m(), "." + lya.E() + ".moving" + EgJ.ci().cK("ssffff"));
				try
				{
					Directory.Move(string_0, lya3.bn());
					flag = true;
				}
				catch (Exception ex2)
				{
					flag = false;
				}
				if (flag)
				{
					bool flag2 = false;
					try
					{
						try
						{
							Eyf.Vg(lya3.bn(), lya2.bn());
							flag2 = true;
							flag = Eyf.pe(lya3.bn());
						}
						catch (Exception ex2)
						{
							flag = false;
							throw new RSBException("MoveDirectory", Eyf.eD(ex2), ex2);
						}
						goto IL_0029;
					}
					finally
					{
						if (!flag)
						{
							lya3.bE(lya);
							if (!flag2)
							{
								try
								{
									Eyf.pe(lya2.bn());
								}
								catch (Exception)
								{
								}
							}
						}
					}
					goto IL_0100;
				}
				if (ex != null)
				{
					throw new RSBException("MoveDirectory", Eyf.eD(ex), ex);
				}
			}
			IL_0029:
			if (flag)
			{
				return;
			}
			IL_0100:
			throw new RSBException("MoveDirectory", "Unable to move the directory " + string_0 + " to " + string_1);
		}

		// Token: 0x060114B2 RID: 70834 RVA: 0x00699160 File Offset: 0x00697360
		public static void Vg(string string_0, string string_1)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(string_0);
			if (directoryInfo.Exists)
			{
				DirectoryInfo directoryInfo2 = new DirectoryInfo(string_1);
				try
				{
					if (!directoryInfo2.Exists)
					{
						directoryInfo2.Create();
					}
					FileSystemInfo[] fileSystemInfos = directoryInfo.GetFileSystemInfos();
					if (fileSystemInfos != null && fileSystemInfos.Length > 0)
					{
						foreach (FileSystemInfo fileSystemInfo in fileSystemInfos)
						{
							string text = Path.Combine(string_1, fileSystemInfo.Name);
							if ((fileSystemInfo.Attributes & FileAttributes.Directory) != FileAttributes.Directory)
							{
								Eyf.Vr(fileSystemInfo.FullName, text, false);
							}
							else
							{
								Eyf.Vg(fileSystemInfo.FullName, text);
							}
						}
					}
				}
				catch (Exception ex)
				{
					if (!(ex is RSBException) || !((RSBException)ex).GetCode().Equals("CopyDirectory"))
					{
						throw new RSBException("CopyDirectory", Eyf.eD(ex), ex);
					}
					throw;
				}
			}
		}

		// Token: 0x060114B3 RID: 70835 RVA: 0x00699264 File Offset: 0x00697464
		public static bool VA(string string_0, string string_1)
		{
			lya lya = new lya(string_1);
			lya lya2 = new lya(string_0);
			if (!lya2.bp())
			{
				if (!lya.bp())
				{
					File.Move(string_0, string_1);
				}
				else
				{
					File.Move(string_0, Eyf.VU(string_1, lya2.E()));
				}
			}
			else
			{
				Directory.Move(string_0, Eyf.VU(string_1, lya2.E()));
			}
			return true;
		}

		// Token: 0x060114B4 RID: 70836 RVA: 0x006992C8 File Offset: 0x006974C8
		public static void Vr(string string_0, string string_1, bool bool_0)
		{
			lya lya = new lya(string_0);
			if (!lya.n())
			{
				throw new Egs("The source file does not exist.");
			}
			if (lya.bp())
			{
				throw new Egs("The source file is not a file.");
			}
			lya lya2 = new lya(string_1);
			if (lya2.bp())
			{
				lya2 = new lya(Eyf.VU(string_1, lya.E()));
			}
			if (!bool_0 && lya2.n())
			{
				throw new Egs("The dest. file exists and overwrite is set to false");
			}
			File.Copy(lya.O(), lya2.O(), bool_0);
		}

		// Token: 0x060114B5 RID: 70837 RVA: 0x0069935C File Offset: 0x0069755C
		public static void VF(Stream stream_0, Stream stream_1, bool bool_0)
		{
			if (stream_0 != null && stream_1 != null)
			{
				try
				{
					byte[] array = new byte[8192];
					int num;
					while ((num = stream_0.Read(array, 0, array.Length)) > 0)
					{
						stream_1.Write(array, 0, num);
					}
				}
				catch (IOException ex)
				{
					throw new Egs("Copy Stream error: " + Eyf.eD(ex));
				}
				finally
				{
					if (bool_0)
					{
						try
						{
							stream_0.Close();
						}
						catch (IOException)
						{
						}
						try
						{
							stream_1.Close();
						}
						catch (IOException)
						{
						}
					}
				}
			}
		}

		// Token: 0x060114B6 RID: 70838 RVA: 0x0069940C File Offset: 0x0069760C
		public static string VK(RSBContext rsbcontext_0, string string_0, string string_1)
		{
			return Eyf.Vq(string_0, string_1);
		}

		// Token: 0x060114B7 RID: 70839 RVA: 0x00699424 File Offset: 0x00697624
		public static string Vq(string string_0, string string_1)
		{
			return Eyf.VS(string_0, string_1, false);
		}

		// Token: 0x060114B8 RID: 70840 RVA: 0x0069943C File Offset: 0x0069763C
		public static string VS(string string_0, string string_1, bool bool_0)
		{
			return Eyf.VZ(string_0, string_1, bool_0, null);
		}

		// Token: 0x060114B9 RID: 70841 RVA: 0x00699454 File Offset: 0x00697654
		public static string VZ(string string_0, string string_1, bool bool_0, lcX[] lcX_0)
		{
			string text = Eyf.pV(string_0);
			string text2 = Eyf.Vl(string_0);
			string text3 = text + text2;
			int num = 0;
			string text4 = Eyf.VU(string_1, text3);
			while (Eyf.Vx(text4))
			{
				text3 = text + ++num + text2;
				text4 = Eyf.VU(string_1, text3);
			}
			if (bool_0)
			{
				int num2 = num;
				while (num - num2 < 256)
				{
					if (lcX_0 != null && lcX_0.Length > 0)
					{
						try
						{
							lcX_0[0] = new lch(new FileStream(text4, FileMode.CreateNew, FileAccess.Write, FileShare.None));
							if (lcX_0[0] == null)
							{
								goto IL_0074;
							}
						}
						catch (Exception)
						{
							goto IL_0074;
						}
						break;
					}
					if (new lya(text4).bm())
					{
						break;
					}
					IL_0074:
					text3 = text + ++num + text2;
					text4 = Eyf.VU(string_1, text3);
				}
			}
			return text4;
		}

		// Token: 0x060114BA RID: 70842 RVA: 0x0069953C File Offset: 0x0069773C
		public static string pB(IList<string> ilist_0, string string_0)
		{
			return Eyf.pJ(ilist_0, string_0, false);
		}

		// Token: 0x060114BB RID: 70843 RVA: 0x00699554 File Offset: 0x00697754
		public static string pJ(IList<string> ilist_0, string string_0, bool bool_0)
		{
			string text = string_0;
			if (ilist_0.Contains(string_0.ToLower()))
			{
				int num = 2;
				while (ilist_0.Contains(string_0.ToLower() + num))
				{
					num++;
				}
				text = string_0 + num;
			}
			if (bool_0)
			{
				ilist_0.Add(text.ToLower());
			}
			return text;
		}

		// Token: 0x060114BC RID: 70844 RVA: 0x006995BC File Offset: 0x006977BC
		public static string pY(RSBContext rsbcontext_0, string string_0)
		{
			return Eyf.pV(string_0);
		}

		// Token: 0x060114BD RID: 70845 RVA: 0x006995D4 File Offset: 0x006977D4
		public static string pV(string string_0)
		{
			return Path.GetFileNameWithoutExtension(string_0);
		}

		// Token: 0x060114BE RID: 70846 RVA: 0x006995EC File Offset: 0x006977EC
		public static string[] pp(string string_0, string string_1)
		{
			return Eyf.pC(string_0, string_1, true);
		}

		// Token: 0x060114BF RID: 70847 RVA: 0x00699604 File Offset: 0x00697804
		public static string[] pC(string string_0, string string_1, bool bool_0)
		{
			if (Directory.Exists(string_0))
			{
				try
				{
					return Directory.GetFiles(string_0, string_1);
				}
				catch
				{
					return new string[0];
				}
			}
			return new string[0];
		}

		// Token: 0x060114C0 RID: 70848 RVA: 0x00699648 File Offset: 0x00697848
		public static string[] pU(string string_0, string string_1)
		{
			return Eyf.ph(string_0, string_1, true);
		}

		// Token: 0x060114C1 RID: 70849 RVA: 0x00699660 File Offset: 0x00697860
		public static string[] ph(string string_0, string string_1, bool bool_0)
		{
			if (Directory.Exists(string_0))
			{
				try
				{
					return Directory.GetDirectories(string_0, string_1);
				}
				catch
				{
					return new string[0];
				}
			}
			return new string[0];
		}

		// Token: 0x060114C2 RID: 70850 RVA: 0x006996A4 File Offset: 0x006978A4
		public static string[] pD(lyZ lyZ_0)
		{
			return Eyf.pl(lyZ_0, false);
		}

		// Token: 0x060114C3 RID: 70851 RVA: 0x006996BC File Offset: 0x006978BC
		public static string[] pl(lyZ lyZ_0, bool bool_0)
		{
			string[] array = new string[lyZ_0.K()];
			lyh lyh = lyZ_0.u();
			int num = 0;
			while (lyh.MPP())
			{
				string text = (string)lyh.MPX();
				array[num++] = text;
			}
			return Eyf.Oe(array, bool_0);
		}

		// Token: 0x060114C4 RID: 70852 RVA: 0x00699708 File Offset: 0x00697908
		public static string[] pm(lyZ lyZ_0)
		{
			return Eyf.px(lyZ_0, false);
		}

		// Token: 0x060114C5 RID: 70853 RVA: 0x00699720 File Offset: 0x00697920
		public static string[] px(lyZ lyZ_0, bool bool_0)
		{
			string[] array = new string[lyZ_0.K()];
			lyh lyh = Eyf.AK(lyZ_0);
			int num = 0;
			while (lyh.MPP())
			{
				string text = (string)lyh.MPX();
				array[num++] = text;
			}
			return Eyf.Oe(array, bool_0);
		}

		// Token: 0x060114C6 RID: 70854 RVA: 0x0069976C File Offset: 0x0069796C
		public static string pn(string string_0)
		{
			Uri uri = new Uri(string_0);
			return uri.Host;
		}

		// Token: 0x060114C7 RID: 70855 RVA: 0x00699788 File Offset: 0x00697988
		public static void pw(string string_0)
		{
			try
			{
				Uri uri = new Uri(string_0);
				string host = uri.Host;
			}
			catch (Exception ex)
			{
				string text = string_0.ToLower();
				if (text.StartsWith("http://") || text.StartsWith("https://"))
				{
					throw new RSBException("getXMLData", Eyf.eD(ex));
				}
			}
		}

		// Token: 0x060114C8 RID: 70856 RVA: 0x006997F4 File Offset: 0x006979F4
		public static lyN pO(lyN lyN_0, lyN lyN_1)
		{
			if (lyN_0 == null)
			{
				throw new Egs("The target list cannot be null.");
			}
			if (lyN_1 == null)
			{
				throw new Egs("The sort-by list cannot be null.");
			}
			if (lyN_0.W() == lyN_1.W())
			{
				lyN lyN = new lyN();
				lyN lyN2 = new lyN();
				for (int i = 0; i < lyN_1.W(); i++)
				{
					object obj = lyN_1.K(i);
					if (!(obj is IComparable))
					{
						throw new Egs("A non-numeric value cannot be used to sort the list.");
					}
					IComparable comparable = (IComparable)obj;
					int j;
					for (j = 0; j < lyN2.W(); j++)
					{
						IComparable comparable2 = (IComparable)lyN2.K(j);
						if (comparable2.CompareTo(comparable) > 0)
						{
							break;
						}
					}
					if (j < lyN2.W())
					{
						lyN.MPh(lyN_0.K(i), j);
						lyN2.MPh(comparable, j);
					}
					else
					{
						lyN.Add(lyN_0.K(i));
						lyN2.Add(comparable);
					}
				}
				return lyN;
			}
			throw new Egs("The target list and sort-by list must have the same length.");
		}

		// Token: 0x060114C9 RID: 70857 RVA: 0x00075B9D File Offset: 0x00073D9D
		public static void pI(string string_0)
		{
			File.Delete(string_0);
		}

		// Token: 0x060114CA RID: 70858 RVA: 0x00699910 File Offset: 0x00697B10
		public static bool pe(string string_0)
		{
			bool flag;
			if (Directory.Exists(string_0))
			{
				Directory.Delete(string_0, true);
				flag = true;
			}
			else
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x060114CB RID: 70859 RVA: 0x00699934 File Offset: 0x00697B34
		public static bool pt(string string_0)
		{
			return new lya(string_0).bp();
		}

		// Token: 0x060114CC RID: 70860 RVA: 0x0069994C File Offset: 0x00697B4C
		public static string pg(string string_0)
		{
			string text;
			if (string_0 != null && string_0.Length > 0)
			{
				try
				{
					string_0 = Path.GetFullPath(string_0);
				}
				catch (Exception)
				{
				}
				text = string_0;
			}
			else
			{
				text = string_0;
			}
			return text;
		}

		// Token: 0x060114CD RID: 70861 RVA: 0x00552FC8 File Offset: 0x005511C8
		public static string pA(string string_0)
		{
			string_0 = Path.GetPathRoot(string_0);
			return string_0;
		}

		// Token: 0x060114CE RID: 70862 RVA: 0x00699990 File Offset: 0x00697B90
		public static string pr(string string_0)
		{
			return Path.GetDirectoryName(string_0);
		}

		// Token: 0x060114CF RID: 70863 RVA: 0x006999A8 File Offset: 0x00697BA8
		public static string pF(string string_0)
		{
			return new EyX(string_0).f();
		}

		// Token: 0x060114D0 RID: 70864 RVA: 0x006999C4 File Offset: 0x00697BC4
		public static string pK(string string_0, bool bool_0)
		{
			return new EyX(string_0).j(bool_0);
		}

		// Token: 0x060114D1 RID: 70865 RVA: 0x006999E0 File Offset: 0x00697BE0
		public static string pq(string string_0, string string_1)
		{
			return new EyX(string_0).n(string_1);
		}

		// Token: 0x060114D2 RID: 70866 RVA: 0x006999FC File Offset: 0x00697BFC
		public static string pS(string string_0, string string_1, bool bool_0)
		{
			return new EyX(string_0).s(string_1, bool_0);
		}

		// Token: 0x060114D3 RID: 70867 RVA: 0x00699A18 File Offset: 0x00697C18
		public static bool pZ(string string_0)
		{
			return Path.IsPathRooted(string_0);
		}

		// Token: 0x060114D4 RID: 70868 RVA: 0x00699A2C File Offset: 0x00697C2C
		public static string CB(string string_0)
		{
			return Eyf.CJ(string_0, true);
		}

		// Token: 0x060114D5 RID: 70869 RVA: 0x00699A44 File Offset: 0x00697C44
		public static string CJ(string string_0, bool bool_0)
		{
			string text = "";
			if (!Eyf.Vx(string_0))
			{
				if (!Eyf.lx(string_0))
				{
					text = string_0.Trim();
				}
			}
			else
			{
				text = Eyf.YO(string_0).Trim();
			}
			string text2;
			if (!bool_0)
			{
				int num = text.IndexOf("-----BEGIN CERTIFICATE-----");
				if (num != 0)
				{
					if (num <= 0)
					{
						text2 = "";
					}
					else
					{
						text2 = lcP.IG(text, num);
					}
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

		// Token: 0x060114D6 RID: 70870 RVA: 0x00699AC0 File Offset: 0x00697CC0
		public static bool CY(string string_0)
		{
			double num = 0.0;
			return double.TryParse(string_0, out num);
		}

		// Token: 0x060114D7 RID: 70871 RVA: 0x00699AE0 File Offset: 0x00697CE0
		public static bool CV(string string_0)
		{
			int num = 0;
			return int.TryParse(string_0, out num);
		}

		// Token: 0x060114D8 RID: 70872 RVA: 0x00699AF8 File Offset: 0x00697CF8
		public static bool Cp(char char_0)
		{
			bool flag;
			try
			{
				if ((char_0 < 'A' || char_0 > 'Z') && (char_0 < 'a' || char_0 > 'z'))
				{
					flag = false;
				}
				else
				{
					flag = true;
				}
			}
			catch (Exception)
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x060114D9 RID: 70873 RVA: 0x00699B40 File Offset: 0x00697D40
		public static int CC(RSBContext rsbcontext_0, string string_0, string string_1)
		{
			int num;
			try
			{
				num = (int)RSBUtils.GetAsLong(rsbcontext_0.GetInput(string_0).Trim());
			}
			catch (Exception)
			{
				throw new Egs("You must provide an integer value for " + string_0);
			}
			return num;
		}

		// Token: 0x060114DA RID: 70874 RVA: 0x00699B88 File Offset: 0x00697D88
		public static int CU(RSBContext rsbcontext_0, string string_0, int int_0, string string_1)
		{
			int num;
			try
			{
				num = (int)RSBUtils.GetAsLong(rsbcontext_0.GetInput(string_0, int_0).Trim());
			}
			catch (Exception)
			{
				throw new Egs(string.Concat(new object[] { "You must provide an integer value for ", string_0, "#", int_0 }));
			}
			return num;
		}

		// Token: 0x060114DB RID: 70875 RVA: 0x00699BF0 File Offset: 0x00697DF0
		public static int Ch(string string_0)
		{
			int num;
			try
			{
				num = int.Parse(string_0);
			}
			catch (Exception)
			{
				throw new Egs("The value " + string_0 + " is not a valid integer.");
			}
			return num;
		}

		// Token: 0x060114DC RID: 70876 RVA: 0x00699C30 File Offset: 0x00697E30
		public static long CD(string string_0, int int_0, int int_1)
		{
			return Eyf.Cl(string_0, int_0, int_1, ',');
		}

		// Token: 0x060114DD RID: 70877 RVA: 0x00699C4C File Offset: 0x00697E4C
		public static long Cl(string string_0, int int_0, int int_1, char char_0)
		{
			long num = 0L;
			int i = int_0;
			int num2 = int_0 + int_1;
			char c = string_0[i];
			if (c == '-' || c == '+')
			{
				i++;
			}
			while (i < num2)
			{
				char c2 = string_0[i];
				if (c2 != char_0)
				{
					if (c2 < '0' || c2 > '9')
					{
						throw new FormatException("Number Format Error");
					}
					int num3 = (int)(c2 - '0');
					num = (num + 1L) * 10L;
					num -= (long)(10 - num3);
					if (num < 0L)
					{
						throw new FormatException("Number Format Error");
					}
				}
				i++;
			}
			return (c == '-') ? (-num) : num;
		}

		// Token: 0x060114DE RID: 70878 RVA: 0x00699D20 File Offset: 0x00697F20
		public static double Cm(string string_0, double double_0)
		{
			return Eyf.Cn(string_0, double_0, null);
		}

		// Token: 0x060114DF RID: 70879 RVA: 0x00699D38 File Offset: 0x00697F38
		public static double Cx(string string_0, double double_0, CultureInfo cultureInfo_0)
		{
			return Eyf.Cn(string_0, double_0, cultureInfo_0);
		}

		// Token: 0x060114E0 RID: 70880 RVA: 0x00699D50 File Offset: 0x00697F50
		public static double Cn(string string_0, double double_0, CultureInfo cultureInfo_0)
		{
			double num = double_0;
			double num2;
			if (!Eyf.lx(string_0))
			{
				if ((cultureInfo_0 == null && !double.TryParse(string_0, out num)) || (cultureInfo_0 != null && !double.TryParse(string_0, NumberStyles.Any, cultureInfo_0, out num)))
				{
					throw new Egs("Error parsing double value [" + string_0 + "].");
				}
				num2 = num;
			}
			else
			{
				num2 = double_0;
			}
			return num2;
		}

		// Token: 0x060114E1 RID: 70881 RVA: 0x00699DB0 File Offset: 0x00697FB0
		public static double Cw(string string_0, double double_0)
		{
			return Eyf.Cx(string_0, double_0, Eyf.l);
		}

		// Token: 0x060114E2 RID: 70882 RVA: 0x00699DCC File Offset: 0x00697FCC
		public static float CO(string string_0, float float_0)
		{
			return Eyf.CI(string_0, float_0, null);
		}

		// Token: 0x060114E3 RID: 70883 RVA: 0x00699DE4 File Offset: 0x00697FE4
		public static float CI(string string_0, float float_0, CultureInfo cultureInfo_0)
		{
			float num = float_0;
			float num2;
			if (!Eyf.lx(string_0))
			{
				if ((cultureInfo_0 == null && !float.TryParse(string_0, out num)) || (cultureInfo_0 != null && !float.TryParse(string_0, NumberStyles.Any, cultureInfo_0, out num)))
				{
					throw new Egs("Error parsing float value [" + string_0 + "].");
				}
				num2 = num;
			}
			else
			{
				num2 = num;
			}
			return num2;
		}

		// Token: 0x060114E4 RID: 70884 RVA: 0x00699E44 File Offset: 0x00698044
		public static short Ce(string string_0, short short_0)
		{
			return Eyf.Ct(string_0, short_0, null);
		}

		// Token: 0x060114E5 RID: 70885 RVA: 0x00699E5C File Offset: 0x0069805C
		public static short Ct(string string_0, short short_0, CultureInfo cultureInfo_0)
		{
			short num = short_0;
			short num2;
			if (!Eyf.lx(string_0))
			{
				if ((cultureInfo_0 == null && !short.TryParse(string_0, out num)) || (cultureInfo_0 != null && !short.TryParse(string_0, NumberStyles.Any, cultureInfo_0, out num)))
				{
					throw new Egs("Error parsing short value [" + string_0 + "].");
				}
				num2 = num;
			}
			else
			{
				num2 = num;
			}
			return num2;
		}

		// Token: 0x060114E6 RID: 70886 RVA: 0x00699EBC File Offset: 0x006980BC
		public static byte Cg(string string_0, byte byte_0)
		{
			return Eyf.CA(string_0, byte_0, null);
		}

		// Token: 0x060114E7 RID: 70887 RVA: 0x00699ED4 File Offset: 0x006980D4
		public static byte CA(string string_0, byte byte_0, CultureInfo cultureInfo_0)
		{
			byte b = byte_0;
			byte b2;
			if (!Eyf.lx(string_0))
			{
				if ((cultureInfo_0 == null && !byte.TryParse(string_0, out b)) || (cultureInfo_0 != null && !byte.TryParse(string_0, NumberStyles.Any, cultureInfo_0, out b)))
				{
					throw new Egs("Error parsing byte value [" + string_0 + "].");
				}
				b2 = b;
			}
			else
			{
				b2 = b;
			}
			return b2;
		}

		// Token: 0x060114E8 RID: 70888 RVA: 0x00699F34 File Offset: 0x00698134
		public static int Cr(string string_0, int int_0)
		{
			int num;
			try
			{
				num = Eyf.CF(string_0, int_0);
			}
			catch (Exception)
			{
				num = int_0;
			}
			return num;
		}

		// Token: 0x060114E9 RID: 70889 RVA: 0x00699F64 File Offset: 0x00698164
		public static int CF(string string_0, int int_0)
		{
			return Eyf.CK(string_0, int_0, null);
		}

		// Token: 0x060114EA RID: 70890 RVA: 0x00699F7C File Offset: 0x0069817C
		public static int CK(string string_0, int int_0, CultureInfo cultureInfo_0)
		{
			int num = int_0;
			int num2;
			if (!Eyf.lx(string_0))
			{
				if ((cultureInfo_0 == null && !int.TryParse(string_0, out num)) || (cultureInfo_0 != null && !int.TryParse(string_0, NumberStyles.Any, cultureInfo_0, out num)))
				{
					throw new Egs("Error parsing int value [" + string_0 + "].");
				}
				num2 = num;
			}
			else
			{
				num2 = num;
			}
			return num2;
		}

		// Token: 0x060114EB RID: 70891 RVA: 0x00699FDC File Offset: 0x006981DC
		public static long Cq(string string_0, long long_0)
		{
			return Eyf.CS(string_0, long_0, null);
		}

		// Token: 0x060114EC RID: 70892 RVA: 0x00699FF4 File Offset: 0x006981F4
		public static long CS(string string_0, long long_0, CultureInfo cultureInfo_0)
		{
			long num = long_0;
			long num2;
			if (!Eyf.lx(string_0))
			{
				if ((cultureInfo_0 == null && !long.TryParse(string_0, out num)) || (cultureInfo_0 != null && !long.TryParse(string_0, NumberStyles.Any, cultureInfo_0, out num)))
				{
					throw new Egs("Error parsing long value [" + string_0 + "].");
				}
				num2 = num;
			}
			else
			{
				num2 = num;
			}
			return num2;
		}

		// Token: 0x060114ED RID: 70893 RVA: 0x0069A054 File Offset: 0x00698254
		public static bool CZ(string string_0, bool bool_0)
		{
			bool flag;
			try
			{
				flag = Eyf.UB(string_0, bool_0);
			}
			catch (Exception)
			{
				flag = bool_0;
			}
			return flag;
		}

		// Token: 0x060114EE RID: 70894 RVA: 0x0069A084 File Offset: 0x00698284
		public static bool UB(string string_0, bool bool_0)
		{
			bool flag;
			if (!Eyf.lx(string_0))
			{
				string_0 = string_0.Trim();
				if (!string_0.Equals("1") && !Eyf.ht(string_0, "true") && !Eyf.ht(string_0, "y") && !Eyf.ht(string_0, "yes") && !Eyf.ht(string_0, "t") && !Eyf.ht(string_0, "on") && !string_0.Equals("-1"))
				{
					if (!string_0.Equals("0") && !Eyf.ht(string_0, "false") && !Eyf.ht(string_0, "n") && !Eyf.ht(string_0, "no") && !Eyf.ht(string_0, "f") && !Eyf.ht(string_0, "off"))
					{
						throw new Egs("Error parsing boolean value [" + string_0 + "].");
					}
					flag = false;
				}
				else
				{
					flag = true;
				}
			}
			else
			{
				flag = bool_0;
			}
			return flag;
		}

		// Token: 0x060114EF RID: 70895 RVA: 0x0069A198 File Offset: 0x00698398
		public static DateTime UV(string string_0, DateTime dateTime_0)
		{
			return Eyf.Up(string_0, dateTime_0, null);
		}

		// Token: 0x060114F0 RID: 70896 RVA: 0x0069A1B0 File Offset: 0x006983B0
		public static DateTime Up(string string_0, DateTime dateTime_0, string string_1)
		{
			return Eyf.UD(string_0, dateTime_0, string_1, false);
		}

		// Token: 0x060114F1 RID: 70897 RVA: 0x0069A1C8 File Offset: 0x006983C8
		public static DateTime UD(string string_0, DateTime dateTime_0, string string_1, bool bool_0)
		{
			DateTime dateTime2;
			if (!Eyf.lx(string_0))
			{
				DateTime dateTime;
				try
				{
					if (!Eyf.lx(string_1))
					{
						dateTime = Eyf.te(string_0, string_1, bool_0);
					}
					else
					{
						dateTime = Eyf.tm(string_0, bool_0);
					}
				}
				catch (Exception)
				{
					throw new Egs("Error parsing Date value [" + string_0 + "].");
				}
				dateTime2 = dateTime;
			}
			else
			{
				dateTime2 = dateTime_0;
			}
			return dateTime2;
		}

		// Token: 0x060114F2 RID: 70898 RVA: 0x0069A230 File Offset: 0x00698430
		public static EgJ Um(string string_0, EgJ egJ_0)
		{
			return Eyf.Ux(string_0, egJ_0, null);
		}

		// Token: 0x060114F3 RID: 70899 RVA: 0x0069A248 File Offset: 0x00698448
		public static EgJ Ux(string string_0, EgJ egJ_0, string string_1)
		{
			return Eyf.Un(string_0, egJ_0, string_1, false);
		}

		// Token: 0x060114F4 RID: 70900 RVA: 0x0069A260 File Offset: 0x00698460
		public static EgJ Un(string string_0, EgJ egJ_0, string string_1, bool bool_0)
		{
			EgJ egJ;
			if (!Eyf.lx(string_0))
			{
				egJ = EgJ.ic(string_0, string_1, bool_0);
			}
			else
			{
				egJ = egJ_0;
			}
			return egJ;
		}

		// Token: 0x060114F5 RID: 70901 RVA: 0x0069A288 File Offset: 0x00698488
		public static string UO(string string_0, string string_1)
		{
			return (!Eyf.lx(string_0)) ? string_0 : string_1;
		}

		// Token: 0x060114F6 RID: 70902 RVA: 0x0069A2A4 File Offset: 0x006984A4
		public static long Ut(string string_0)
		{
			long num;
			if (!Eyf.lx(string_0))
			{
				if (Eyf.hB(string_0, "B", true))
				{
					string_0 = lcP.IZ(string_0, 0, string_0.Length - 1);
				}
				if (!Eyf.hB(string_0, "M", true))
				{
					if (!Eyf.hB(string_0, "K", true))
					{
						num = long.Parse(string_0);
					}
					else
					{
						string_0 = lcP.IZ(string_0, 0, string_0.Length - 1);
						num = long.Parse(string_0) * 1024L;
					}
				}
				else
				{
					string_0 = lcP.IZ(string_0, 0, string_0.Length - 1);
					num = long.Parse(string_0) * 1024L * 1024L;
				}
			}
			else
			{
				num = 0L;
			}
			return num;
		}

		// Token: 0x060114F7 RID: 70903 RVA: 0x0069A370 File Offset: 0x00698570
		public static string UA(object object_0)
		{
			return Eyf.Ur(object_0, CultureInfo.InvariantCulture);
		}

		// Token: 0x060114F8 RID: 70904 RVA: 0x0069A38C File Offset: 0x0069858C
		public static string Ur(object object_0, CultureInfo cultureInfo_0)
		{
			string text;
			if (object_0 != null)
			{
				if (!(object_0 is DateTime))
				{
					if (!(object_0 is IFormattable))
					{
						text = object_0.ToString();
					}
					else
					{
						text = ((IFormattable)object_0).ToString(null, cultureInfo_0);
					}
				}
				else
				{
					text = ((DateTime)object_0).ToString("yyyy-MM-dd HH:mm:ss", cultureInfo_0);
				}
			}
			else
			{
				text = "";
			}
			return text;
		}

		// Token: 0x060114F9 RID: 70905 RVA: 0x0069A3F8 File Offset: 0x006985F8
		public static bool UK(string string_0, string string_1, bool bool_0)
		{
			bool flag;
			if (string_0 != null)
			{
				if (!bool_0)
				{
					flag = string_0.StartsWith(string_1);
				}
				else
				{
					flag = Eyf.hO(string_0, 0, string_1, 0, string_1.Length);
				}
			}
			else
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x060114FA RID: 70906 RVA: 0x0069A434 File Offset: 0x00698634
		public static bool UZ(string string_0, string string_1)
		{
			return string_0.StartsWith(string_1, true, Eyf.l);
		}

		// Token: 0x060114FB RID: 70907 RVA: 0x0069A450 File Offset: 0x00698650
		public static bool hB(string string_0, string string_1, bool bool_0)
		{
			bool flag;
			if (string_0 != null)
			{
				if (!bool_0)
				{
					flag = string_0.EndsWith(string_1);
				}
				else
				{
					int length = string_1.Length;
					int num = string_0.Length - length;
					flag = num >= 0 && Eyf.hO(string_0, num, string_1, 0, length);
				}
			}
			else
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x060114FC RID: 70908 RVA: 0x0069A4A4 File Offset: 0x006986A4
		public static bool hV(string string_0, string string_1)
		{
			return string_0.EndsWith(string_1, true, Eyf.l);
		}

		// Token: 0x060114FD RID: 70909 RVA: 0x0069A4C0 File Offset: 0x006986C0
		public static bool hp(string string_0, string string_1, bool bool_0)
		{
			return string_0 != null && Eyf.UK(string_0, string_1, bool_0) && Eyf.hB(string_0, string_1, bool_0);
		}

		// Token: 0x060114FE RID: 70910 RVA: 0x0069A4F4 File Offset: 0x006986F4
		public static bool hD(string string_0, string string_1, bool bool_0)
		{
			bool flag;
			if (string_0 != null)
			{
				if (!bool_0)
				{
					flag = string_0.Contains(string_1);
				}
				else
				{
					flag = string_0.IndexOf(string_1, StringComparison.InvariantCultureIgnoreCase) > -1;
				}
			}
			else
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x060114FF RID: 70911 RVA: 0x0069A52C File Offset: 0x0069872C
		public static bool hm(string[] string_0, string string_1, bool bool_0)
		{
			bool flag;
			if (!bool_0)
			{
				if (string_0 != null && string_1 != null)
				{
					foreach (string text in string_0)
					{
						if (text != null && text.Equals(string_1))
						{
							return true;
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
				flag = Eyf.hx(string_0, string_1);
			}
			return flag;
		}

		// Token: 0x06011500 RID: 70912 RVA: 0x0069A594 File Offset: 0x00698794
		public static bool hx(string[] string_0, string string_1)
		{
			bool flag;
			if (string_0 != null && string_1 != null)
			{
				foreach (string text in string_0)
				{
					if (Eyf.ht(text, string_1))
					{
						return true;
					}
				}
				flag = false;
			}
			else
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x06011501 RID: 70913 RVA: 0x0069A5E4 File Offset: 0x006987E4
		public static bool hn(string string_0, int int_0, string string_1, int int_1)
		{
			int num = 0;
			if (string_0 != null)
			{
				num = string_0.Length - int_0;
			}
			if (string_1 != null && string_1.Length - int_1 > num)
			{
				num = string_1.Length - int_1;
			}
			return Eyf.hO(string_0, int_0, string_1, int_1, num);
		}

		// Token: 0x06011502 RID: 70914 RVA: 0x0069A630 File Offset: 0x00698830
		public static bool hO(string string_0, int int_0, string string_1, int int_1, int int_2)
		{
			bool flag;
			if (string_0 != null && string_1 != null)
			{
				flag = string.Compare(string_0, int_0, string_1, int_1, int_2, true) == 0;
			}
			else
			{
				flag = string_0 == string_1;
			}
			return flag;
		}

		// Token: 0x06011503 RID: 70915 RVA: 0x0069A668 File Offset: 0x00698868
		public static bool ht(string string_0, string string_1)
		{
			return Eyf.hA(string_0, string_1, null);
		}

		// Token: 0x06011504 RID: 70916 RVA: 0x0069A680 File Offset: 0x00698880
		public static bool hA(string string_0, string string_1, CultureInfo cultureInfo_0)
		{
			bool flag;
			if (string_0 != null && string_1 != null)
			{
				if (cultureInfo_0 != null)
				{
					flag = cultureInfo_0.CompareInfo.Compare(string_0, string_1, CompareOptions.IgnoreCase) == 0;
				}
				else
				{
					flag = lcP.nt(string_0, string_1);
				}
			}
			else
			{
				flag = string_0 == string_1;
			}
			return flag;
		}

		// Token: 0x06011505 RID: 70917 RVA: 0x0069A6CC File Offset: 0x006988CC
		public static bool hr(string string_0, string string_1)
		{
			return (string_0 != null) ? string_0.Equals(string_1) : (string_0 == string_1);
		}

		// Token: 0x06011506 RID: 70918 RVA: 0x0069A6EC File Offset: 0x006988EC
		public static bool hK(string string_0, string string_1)
		{
			return Eyf.hA(string_0, string_1, Eyf.l);
		}

		// Token: 0x06011507 RID: 70919 RVA: 0x0069A708 File Offset: 0x00698908
		public static int hZ(string[] string_0, string string_1)
		{
			return Eyf.DV(string_0, string_1, false, null);
		}

		// Token: 0x06011508 RID: 70920 RVA: 0x0069A720 File Offset: 0x00698920
		public static int DB(string[] string_0, string string_1)
		{
			return Eyf.DV(string_0, string_1, true, null);
		}

		// Token: 0x06011509 RID: 70921 RVA: 0x0069A738 File Offset: 0x00698938
		public static int DJ(string[] string_0, string string_1, CultureInfo cultureInfo_0)
		{
			return Eyf.DV(string_0, string_1, true, cultureInfo_0);
		}

		// Token: 0x0601150A RID: 70922 RVA: 0x0069A750 File Offset: 0x00698950
		public static int DY(string[] string_0, string string_1)
		{
			return Eyf.DV(string_0, string_1, true, Eyf.l);
		}

		// Token: 0x0601150B RID: 70923 RVA: 0x0069A76C File Offset: 0x0069896C
		private static int DV(string[] string_0, string string_1, bool bool_0, CultureInfo cultureInfo_0)
		{
			int num;
			if (string_0 != null && string_0.Length != 0)
			{
				if (!Eyf.lx(string_1))
				{
					for (int i = 0; i < string_0.Length; i++)
					{
						if (!bool_0)
						{
							if (string_1.Equals(string_0[i]))
							{
								return i;
							}
						}
						else if (Eyf.hA(string_1, string_0[i], cultureInfo_0))
						{
							return i;
						}
					}
					num = -1;
				}
				else
				{
					num = -1;
				}
			}
			else
			{
				num = -1;
			}
			return num;
		}

		// Token: 0x0601150C RID: 70924 RVA: 0x0069A7E0 File Offset: 0x006989E0
		public static int[] Dp(string string_0, string string_1, bool bool_0)
		{
			return Eyf.DC(string_0, string_1, bool_0, null);
		}

		// Token: 0x0601150D RID: 70925 RVA: 0x0069A7F8 File Offset: 0x006989F8
		public static int[] DC(string string_0, string string_1, bool bool_0, IComparer icomparer_0)
		{
			int[] array3;
			if (!Eyf.lx(string_0) && !Eyf.lx(string_1))
			{
				if (string_0.Length < string_1.Length)
				{
					string text = string_0;
					string_0 = string_1;
					string_1 = text;
				}
				if (bool_0)
				{
					string_0 = Eyf.Dx(string_0);
					string_1 = Eyf.Dx(string_1);
				}
				int num = string_0.IndexOf(string_1);
				if (num < 0)
				{
					int[] array = new int[2];
					array[0] = -1;
					int[] array2 = array;
					int num2 = 0;
					int num3 = 0;
					while (num3 < string_0.Length && num2 < string_1.Length)
					{
						if ((icomparer_0 != null && icomparer_0.Compare(string_0[num3], string_1[num2]) != 0) || (icomparer_0 == null && string_0[num3] != string_1[num2]))
						{
							if (num2 > array2[1])
							{
								array2[0] = num;
								array2[1] = num2;
							}
							num = -1;
							num2 = 0;
						}
						if ((icomparer_0 != null && icomparer_0.Compare(string_0[num3], string_1[num2]) == 0) || (icomparer_0 == null && string_0[num3] == string_1[num2]))
						{
							if (num == -1)
							{
								num = num3;
							}
							num2++;
						}
						num3++;
					}
					if (num2 > array2[1])
					{
						array2[0] = num;
						array2[1] = num2;
					}
					array3 = array2;
				}
				else
				{
					array3 = new int[] { num, string_1.Length };
				}
			}
			else
			{
				int[] array = new int[2];
				array[0] = -1;
				array3 = array;
			}
			return array3;
		}

		// Token: 0x0601150E RID: 70926 RVA: 0x0069A9F0 File Offset: 0x00698BF0
		public static string DU(string string_0)
		{
			char c = '\\';
			bool flag = false;
			lcc lcc = new lcc();
			foreach (char c2 in string_0)
			{
				bool flag2 = flag;
				flag = !flag && c2 == c;
				if (!flag)
				{
					if (flag2 || c2 != '%')
					{
						if (flag2 || c2 != '_')
						{
							lcc.MPI(c2);
						}
						else
						{
							lcc.MPI("?");
						}
					}
					else
					{
						lcc.MPI("*");
					}
				}
			}
			return lcc.ToString();
		}

		// Token: 0x0601150F RID: 70927 RVA: 0x0069AA98 File Offset: 0x00698C98
		public static string Dh(string string_0)
		{
			return Eyf.DD(string_0, null);
		}

		// Token: 0x06011510 RID: 70928 RVA: 0x0069AAB0 File Offset: 0x00698CB0
		public static string DD(string string_0, CultureInfo cultureInfo_0)
		{
			string text;
			if (string_0 == null)
			{
				text = null;
			}
			else if (cultureInfo_0 != null)
			{
				text = string_0.ToLower(cultureInfo_0);
			}
			else
			{
				text = string_0.ToLower();
			}
			return text;
		}

		// Token: 0x06011511 RID: 70929 RVA: 0x0069AAE4 File Offset: 0x00698CE4
		public static string Dl(string string_0)
		{
			return Eyf.Dm(string_0, null);
		}

		// Token: 0x06011512 RID: 70930 RVA: 0x0069AAFC File Offset: 0x00698CFC
		public static string Dm(string string_0, CultureInfo cultureInfo_0)
		{
			string text;
			if (string_0 == null)
			{
				text = null;
			}
			else if (cultureInfo_0 != null)
			{
				text = string_0.ToUpper(cultureInfo_0);
			}
			else
			{
				text = string_0.ToUpper();
			}
			return text;
		}

		// Token: 0x06011513 RID: 70931 RVA: 0x0069AB30 File Offset: 0x00698D30
		public static string Dx(string string_0)
		{
			return Eyf.DD(string_0, Eyf.l);
		}

		// Token: 0x06011514 RID: 70932 RVA: 0x0069AB4C File Offset: 0x00698D4C
		public static string Dn(string string_0)
		{
			return Eyf.Dm(string_0, Eyf.l);
		}

		// Token: 0x06011515 RID: 70933 RVA: 0x005AC984 File Offset: 0x005AAB84
		public static string Dw(bool bool_0)
		{
			return (!bool_0) ? "False" : "True";
		}

		// Token: 0x06011516 RID: 70934 RVA: 0x0029F518 File Offset: 0x0029D718
		public static string DO(int int_0)
		{
			return int_0.ToString();
		}

		// Token: 0x06011517 RID: 70935 RVA: 0x0069AB68 File Offset: 0x00698D68
		public static string DI(long long_0)
		{
			return long_0.ToString();
		}

		// Token: 0x06011518 RID: 70936 RVA: 0x0069AB80 File Offset: 0x00698D80
		public static string De(double double_0)
		{
			return double_0.ToString();
		}

		// Token: 0x06011519 RID: 70937 RVA: 0x0069AB98 File Offset: 0x00698D98
		public static string Dt(int int_0)
		{
			return int_0.ToString(Eyf.l);
		}

		// Token: 0x0601151A RID: 70938 RVA: 0x0069ABB4 File Offset: 0x00698DB4
		public static string Dg(long long_0)
		{
			return long_0.ToString(Eyf.l);
		}

		// Token: 0x0601151B RID: 70939 RVA: 0x0069ABD0 File Offset: 0x00698DD0
		public static string DA(double double_0)
		{
			return double_0.ToString(Eyf.l);
		}

		// Token: 0x0601151C RID: 70940 RVA: 0x0069ABEC File Offset: 0x00698DEC
		public static string Dr(string string_0, string[] string_1)
		{
			string text2;
			if (string_0 != null && string_1 != null && string_1.Length != 0)
			{
				string[] array = new string[string_1.Length];
				for (int i = 0; i < string_1.Length; i++)
				{
					array[i] = Eyf.Ol(string_1[i]);
				}
				string text = "(\"(?:" + Eyf.xn("|", array) + ")\"\\s*:\\s*)";
				string_0 = EgB.f(string_0, text + "−(?=\\d)", "$1-");
				text2 = EgB.f(string_0, text + "(-?\\d+),(?=\\d)(\\d+)", "$1$2.$3");
			}
			else
			{
				text2 = string_0;
			}
			return text2;
		}

		// Token: 0x0601151D RID: 70941 RVA: 0x0009B494 File Offset: 0x00099694
		public static string DF(string string_0)
		{
			return string_0;
		}

		// Token: 0x0601151E RID: 70942 RVA: 0x0069AC84 File Offset: 0x00698E84
		public static string DK(RSBItem rsbitem_0)
		{
			return Eyf.Dq(rsbitem_0, null);
		}

		// Token: 0x0601151F RID: 70943 RVA: 0x0069AC9C File Offset: 0x00698E9C
		public static string Dq(RSBItem rsbitem_0, string string_0)
		{
			return Eyf.DS(rsbitem_0, (!Eyf.lx(string_0)) ? (string_0 + Eyf.u + "\t") : "\t", Eyf.u + "\t");
		}

		// Token: 0x06011520 RID: 70944 RVA: 0x0069ACE0 File Offset: 0x00698EE0
		public static string DS(RSBItem rsbitem_0, string string_0, string string_1)
		{
			if (string_0 != null)
			{
				goto IL_00F0;
			}
			string text = "";
			IL_000B:
			lcc lcc = new lcc(text);
			string text2 = "";
			try
			{
				foreach (string text3 in rsbitem_0.ListAttrs())
				{
					int attrCount = rsbitem_0.GetAttrCount(text3);
					if (attrCount != 1)
					{
						for (int j = 0; j < attrCount; j++)
						{
							lcc.MPI(string.Concat(new object[]
							{
								text2,
								text3,
								"#",
								j + 1,
								": ",
								rsbitem_0.GetAttr(text3, j)
							}));
							text2 = string_1;
						}
					}
					else
					{
						lcc.MPI(text2 + text3 + ": " + rsbitem_0.GetAttr(text3));
						text2 = string_1;
					}
				}
				goto IL_00F6;
			}
			catch (Exception ex)
			{
				lcc.MPI(text2 + "Exception: " + Eyf.eD(ex));
				goto IL_00F6;
			}
			goto IL_00F0;
			IL_00F6:
			return lcc.ToString();
			IL_00F0:
			text = string_0;
			goto IL_000B;
		}

		// Token: 0x06011521 RID: 70945 RVA: 0x0069AE00 File Offset: 0x00699000
		public static bool DZ(string string_0, string[] string_1)
		{
			return Eyf.lB(string_0, string_1, true);
		}

		// Token: 0x06011522 RID: 70946 RVA: 0x0069AE18 File Offset: 0x00699018
		public static bool lB(string string_0, string[] string_1, bool bool_0)
		{
			bool flag3;
			if (!Eyf.lx(string_0) && string_1 != null && string_1.Length > 0)
			{
				bool flag = true;
				for (int i = string_1.Length * 2 - 1; i >= 0; i--)
				{
					bool flag2 = i >= string_1.Length;
					string text = string_1[(!flag2) ? i : (i - string_1.Length)];
					if (!Eyf.lx(text))
					{
						if (!text.StartsWith("-"))
						{
							if (text.StartsWith("+"))
							{
								text = lcP.IG(text, 1);
							}
							flag = false;
							if (Eyf.lD(flag2, bool_0, string_0, text))
							{
								return true;
							}
						}
						else
						{
							text = lcP.IG(text, 1);
							if (Eyf.lD(flag2, bool_0, string_0, text))
							{
								return false;
							}
						}
					}
				}
				flag3 = flag;
			}
			else
			{
				flag3 = false;
			}
			return flag3;
		}

		// Token: 0x06011523 RID: 70947 RVA: 0x0069AEE0 File Offset: 0x006990E0
		public static string lV(string string_0, string[] string_1)
		{
			return Eyf.lp(string_0, string_1, true);
		}

		// Token: 0x06011524 RID: 70948 RVA: 0x0069AEF8 File Offset: 0x006990F8
		public static string lp(string string_0, string[] string_1, bool bool_0)
		{
			string text2;
			if (!Eyf.lx(string_0) && string_1 != null && string_1.Length > 0)
			{
				bool flag = true;
				for (int i = string_1.Length * 2 - 1; i >= 0; i--)
				{
					bool flag2 = i >= string_1.Length;
					string text = string_1[(!flag2) ? i : (i - string_1.Length)];
					if (!Eyf.lx(text))
					{
						if (!text.StartsWith("-"))
						{
							if (text.StartsWith("+"))
							{
								text = lcP.IG(text, 1);
							}
							flag = false;
							if (Eyf.lD(flag2, bool_0, string_0, text))
							{
								return "+" + text;
							}
						}
						else
						{
							text = lcP.IG(text, 1);
							if (Eyf.lD(flag2, bool_0, string_0, text))
							{
								return "-" + text;
							}
						}
					}
				}
				text2 = ((!flag) ? null : "*");
			}
			else
			{
				text2 = null;
			}
			return text2;
		}

		// Token: 0x06011525 RID: 70949 RVA: 0x0069AFE0 File Offset: 0x006991E0
		private static bool lD(bool bool_0, bool bool_1, string string_0, string string_1)
		{
			if (!bool_0)
			{
				if (!bool_1)
				{
					if (Eyr.V(string_0, string_1))
					{
						return true;
					}
				}
				else if (Eyr.B(string_0, string_1))
				{
					return true;
				}
			}
			else if (!bool_1)
			{
				if (Eyf.hr(string_0, string_1))
				{
					return true;
				}
			}
			else if (Eyf.hK(string_0, string_1))
			{
				return true;
			}
			return false;
		}

		// Token: 0x06011526 RID: 70950 RVA: 0x0069B044 File Offset: 0x00699244
		public static string lm(string string_0)
		{
			return lcP.IZ(string_0, 0, 1).ToUpper() + lcP.IG(string_0, 1);
		}

		// Token: 0x06011527 RID: 70951 RVA: 0x000F0AAC File Offset: 0x000EECAC
		public static bool lx(string string_0)
		{
			return string_0 == null || string_0.Length <= 0;
		}

		// Token: 0x06011528 RID: 70952 RVA: 0x0069B06C File Offset: 0x0069926C
		public static string ln(string string_0)
		{
			return lmZ.Q(string_0).Replace("'", "%27");
		}

		// Token: 0x06011529 RID: 70953 RVA: 0x0069B090 File Offset: 0x00699290
		public static string lO(string string_0)
		{
			return lmZ.y(string_0).Replace("'", "%27");
		}

		// Token: 0x0601152A RID: 70954 RVA: 0x0069B0B4 File Offset: 0x006992B4
		public static string lt(string string_0)
		{
			return lmZ.c(string_0);
		}

		// Token: 0x0601152B RID: 70955 RVA: 0x0069B0CC File Offset: 0x006992CC
		public static string lA(string string_0, bool bool_0)
		{
			string text = Eyf.lO(string_0);
			string text2;
			if (!Eyf.lx(text) && bool_0)
			{
				char[] array = text.ToCharArray();
				for (int i = 0; i < array.Length - 2; i++)
				{
					if (array[i] == '%')
					{
						array[i + 1] = char.ToUpper(array[i + 1]);
						array[i + 2] = char.ToUpper(array[i + 2]);
					}
				}
				text2 = new string(array);
			}
			else
			{
				text2 = text;
			}
			return text2;
		}

		// Token: 0x0601152C RID: 70956 RVA: 0x0069B144 File Offset: 0x00699344
		public static string lr(string string_0)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(string_0);
			lcc lcc = new lcc();
			foreach (byte b in bytes)
			{
				char c = (char)b;
				if ("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_.~".IndexOf(c) < 0)
				{
					lcc.MPI("%" + Convert.ToString((b <= 0) ? ((int)b + 256) : ((int)b), 16).ToUpper());
				}
				else
				{
					lcc.MPI(c);
				}
			}
			return lcc.ToString();
		}

		// Token: 0x0601152D RID: 70957 RVA: 0x0069B1D0 File Offset: 0x006993D0
		public static string lK(string string_0, bool bool_0)
		{
			string_0 = string_0.ToLower();
			string text = "";
			string text2 = string_0;
			if (string_0.IndexOf("https://") != 0)
			{
				if (string_0.IndexOf("http://") == 0)
				{
					text = "https://";
					text2 = lcP.IG(string_0, 7);
				}
			}
			else
			{
				text = "https://";
				text2 = lcP.IG(string_0, 8);
			}
			if (text2.IndexOf('/') > 0)
			{
				text2 = lcP.IZ(text2, 0, text2.IndexOf('/'));
			}
			return ((!bool_0) ? "" : text) + text2;
		}

		// Token: 0x0601152E RID: 70958 RVA: 0x0069B26C File Offset: 0x0069946C
		public static string lZ(string string_0)
		{
			return Eyf.mB(string_0, false);
		}

		// Token: 0x0601152F RID: 70959 RVA: 0x0069B284 File Offset: 0x00699484
		public static string mB(string string_0, bool bool_0)
		{
			return Eyf.mJ(string_0, bool_0, false);
		}

		// Token: 0x06011530 RID: 70960 RVA: 0x0069B29C File Offset: 0x0069949C
		public static string mJ(string string_0, bool bool_0, bool bool_1)
		{
			lcc lcc = new lcc();
			string text;
			if (!string_0.Equals("rows@next"))
			{
				char[] array = string_0.ToCharArray();
				bool flag = false;
				bool flag2 = false;
				char c = '.';
				int i = 0;
				while (i < array.Length)
				{
					char c2 = array[i];
					if (c2 < 'a')
					{
						goto IL_0040;
					}
					if (c2 > 'z')
					{
						goto IL_0040;
					}
					goto IL_004E;
					IL_004F:
					bool flag3;
					if (flag3)
					{
						if (c2 < 'A' || c2 > 'Z')
						{
							if (c2 <= 'z' || bool_1)
							{
								if (!bool_1)
								{
									if (c != '_')
									{
										lcc.MPI('_');
										c = '_';
										flag2 = false;
									}
								}
								else
								{
									lcc.MPI(c2);
									c = c2;
								}
							}
							else
							{
								byte[] array2 = null;
								try
								{
									array2 = Eyf.Ip(string.Concat(c2), "utf-8");
								}
								catch (Exception)
								{
								}
								for (int j = 0; j < array2.Length; j++)
								{
									int num = (int)(array2[j] & 15);
									int num2 = array2[j] >> 4;
									lcc.MPI((char)(num + 97));
									lcc.MPI((char)(num2 + 97));
									c = (char)(num2 + 97);
								}
							}
						}
						else
						{
							c = c2;
							if (!bool_0)
							{
								lcc.MPI(c2);
							}
							else
							{
								lcc.MPI(c2 + 'a' - 'A');
							}
						}
					}
					else if (c2 != ':')
					{
						if (c2 != '_')
						{
							c = c2;
							lcc.MPI(c2);
						}
						else
						{
							if (c != '_' || flag2)
							{
								lcc.MPI(c2);
							}
							flag2 = true;
							c = '_';
						}
					}
					else if (!bool_1 && (flag || i >= string_0.Length - 1))
					{
						if (c != '_')
						{
							lcc.MPI('_');
							c = '_';
							flag2 = false;
						}
					}
					else
					{
						c = c2;
						lcc.MPI(c2);
						if (!bool_1)
						{
							flag = true;
						}
					}
					i++;
					continue;
					IL_004E:
					flag3 = false;
					goto IL_004F;
					IL_0040:
					if (c2 >= '0')
					{
						if (c2 <= '9')
						{
							goto IL_004E;
						}
					}
					if (c2 != '-' && c2 != '_')
					{
						flag3 = c2 != ':';
						goto IL_004F;
					}
					goto IL_004E;
				}
				text = lcc.ToString();
			}
			else
			{
				text = string_0;
			}
			return text;
		}

		// Token: 0x06011531 RID: 70961 RVA: 0x0069B4E8 File Offset: 0x006996E8
		public static string mY(string string_0)
		{
			lcc lcc = new lcc();
			char c = '.';
			int num = -1;
			int i = 0;
			while (i < string_0.Length)
			{
				char c2 = string_0[i];
				if (c2 >= 'a' && c2 <= 'z')
				{
					goto IL_0054;
				}
				if (c2 >= 'A')
				{
					if (c2 <= 'Z')
					{
						goto IL_0054;
					}
				}
				if (c2 >= '0')
				{
					if (c2 <= '9')
					{
						goto IL_0054;
					}
				}
				bool flag = c2 != '_';
				IL_003F:
				if (flag)
				{
					if (c != '_')
					{
						lcc.MPI('_');
						c = '_';
						if (i < 127)
						{
							num = lcc.D - 1;
						}
					}
				}
				else
				{
					if (c != '_' || c2 != '_')
					{
						lcc.MPI(c2);
					}
					c = c2;
				}
				i++;
				continue;
				IL_0054:
				flag = false;
				goto IL_003F;
			}
			if (lcc.D > 127)
			{
				if (num <= 0)
				{
					lcc.j(127);
				}
				else
				{
					lcc.j(num);
				}
			}
			return lcc.ToString();
		}

		// Token: 0x06011532 RID: 70962 RVA: 0x0069B5D4 File Offset: 0x006997D4
		public static string mV(string string_0)
		{
			lcc lcc = new lcc();
			char c = '.';
			foreach (char c2 in string_0)
			{
				if (c2 != '[' && c2 != ']' && c2 != '\'')
				{
					lcc.MPI(c2);
					c = c2;
				}
				else if (c != '_')
				{
					lcc.MPI('_');
					c = '_';
				}
			}
			return lcc.ToString();
		}

		// Token: 0x06011533 RID: 70963 RVA: 0x0069B648 File Offset: 0x00699848
		public static string mp(string string_0)
		{
			lcc lcc = new lcc();
			foreach (char c in string_0)
			{
				if (c != '.')
				{
					lcc.MPI(c);
				}
			}
			return lcc.ToString();
		}

		// Token: 0x06011534 RID: 70964 RVA: 0x0069B694 File Offset: 0x00699894
		public static string[] mC(string[] string_0)
		{
			return Eyf.mU(string_0, false);
		}

		// Token: 0x06011535 RID: 70965 RVA: 0x0069B6AC File Offset: 0x006998AC
		public static string[] mU(string[] string_0, bool bool_0)
		{
			string[] array;
			if (string_0 != null && string_0.Length > 0)
			{
				int num = 0;
				for (int i = 0; i < string_0.Length; i++)
				{
					string text = Eyf.mh(string_0[i]);
					if (!bool_0 || !Eyf.lx(text))
					{
						string_0[num++] = text;
					}
				}
				if (num >= string_0.Length)
				{
					array = string_0;
				}
				else
				{
					string[] array2 = new string[num];
					lyc.E(string_0, 0, array2, 0, 0);
					array = array2;
				}
			}
			else
			{
				array = string_0;
			}
			return array;
		}

		// Token: 0x06011536 RID: 70966 RVA: 0x0069B728 File Offset: 0x00699928
		public static string mh(string string_0)
		{
			string text;
			if (string_0 != null)
			{
				text = string_0.Trim();
			}
			else
			{
				text = "";
			}
			return text;
		}

		// Token: 0x06011537 RID: 70967 RVA: 0x0069B750 File Offset: 0x00699950
		public static string mD(string string_0)
		{
			return Eyf.ml(string_0, false);
		}

		// Token: 0x06011538 RID: 70968 RVA: 0x0069B768 File Offset: 0x00699968
		public static string ml(string string_0, bool bool_0)
		{
			return Eyf.mm(string_0, bool_0, false);
		}

		// Token: 0x06011539 RID: 70969 RVA: 0x0069B780 File Offset: 0x00699980
		public static string mm(string string_0, bool bool_0, bool bool_1)
		{
			string text;
			if (string_0 != null)
			{
				lcc lcc = new lcc();
				for (int i = 0; i < string_0.Length; i++)
				{
					char c = string_0[i];
					int num = (int)c;
					if (num != 34)
					{
						switch (num)
						{
						case 38:
							lcc.MPI("&amp;");
							break;
						case 39:
							lcc.MPI("&apos;");
							break;
						default:
						{
							switch (num)
							{
							case 60:
								lcc.MPI("&lt;");
								goto IL_003E;
							case 62:
								lcc.MPI("&gt;");
								goto IL_003E;
							}
							if (!bool_0)
							{
								goto IL_00B2;
							}
							if (i != 0)
							{
								if (i != string_0.Length - 1)
								{
									goto IL_00B2;
								}
							}
							bool flag = !char.IsWhiteSpace(c);
							IL_00B3:
							if (!flag)
							{
								lcc.MPI("&#").MPI(string.Concat((int)c)).MPI(";");
								break;
							}
							if (!bool_1 || c <= '\u007f')
							{
								lcc.MPI(c);
								break;
							}
							lcc.MPI("&#").MPI(string.Concat((int)c)).MPI(";");
							break;
							IL_00B2:
							flag = true;
							goto IL_00B3;
						}
						}
					}
					else
					{
						lcc.MPI("&quot;");
					}
					IL_003E:;
				}
				text = lcc.ToString();
			}
			else
			{
				text = null;
			}
			return text;
		}

		// Token: 0x0601153A RID: 70970 RVA: 0x0069B8D8 File Offset: 0x00699AD8
		public static string mx(string string_0)
		{
			string text2;
			if (string_0.IndexOf('&') != -1)
			{
				lcc lcc = new lcc();
				for (int i = 0; i < string_0.Length; i++)
				{
					if (string_0[i] != '&')
					{
						lcc.MPI(string_0[i]);
					}
					else if (string_0.Length < i + 4 || !lcP.IZ(string_0, i, i + 4).Equals("&lt;"))
					{
						if (string_0.Length < i + 4 || !lcP.IZ(string_0, i, i + 4).Equals("&gt;"))
						{
							if (string_0.Length < i + 5 || !lcP.IZ(string_0, i, i + 5).Equals("&amp;"))
							{
								if (string_0.Length < i + 6 || !lcP.IZ(string_0, i, i + 6).Equals("&apos;"))
								{
									if (string_0.Length < i + 6 || !lcP.IZ(string_0, i, i + 6).Equals("&quot;"))
									{
										if (string_0.Length < i + 3 || !lcP.IZ(string_0, i, i + 3).ToLower().Equals("&#x"))
										{
											if (string_0.Length < i + 2 || string_0[i + 1] != '#')
											{
												lcc.MPI('&');
											}
											else if (i + 2 < string_0.Length)
											{
												int num = string_0.IndexOf(';', i + 2);
												if (num != -1)
												{
													try
													{
														string text = lcP.IZ(string_0, i + 2, num);
														if (text.Length == 0)
														{
															goto IL_0044;
														}
														lcc.MPI((char)int.Parse(text));
													}
													catch (Exception)
													{
													}
													i = num;
												}
											}
										}
										else if (i + 3 < string_0.Length)
										{
											int num = string_0.IndexOf(';', i + 3);
											if (num != -1)
											{
												string text = lcP.IZ(string_0, i + 3, num);
												if (text.Length != 0)
												{
													long num2 = Eyf.nr(text);
													lcc.MPI((char)num2);
													i = num;
												}
											}
										}
									}
									else
									{
										lcc.MPI('"');
										i += 5;
									}
								}
								else
								{
									lcc.MPI('\'');
									i += 5;
								}
							}
							else
							{
								lcc.MPI('&');
								i += 4;
							}
						}
						else
						{
							lcc.MPI('>');
							i += 3;
						}
					}
					else
					{
						lcc.MPI('<');
						i += 3;
					}
					IL_0044:;
				}
				text2 = lcc.ToString();
			}
			else
			{
				text2 = string_0;
			}
			return text2;
		}

		// Token: 0x0601153B RID: 70971 RVA: 0x0069BBC4 File Offset: 0x00699DC4
		public static string mn(string string_0)
		{
			return Eyf.mw(string_0, true);
		}

		// Token: 0x0601153C RID: 70972 RVA: 0x0069BBDC File Offset: 0x00699DDC
		public static string mw(string string_0, bool bool_0)
		{
			string text;
			if (!Eyf.lx(string_0))
			{
				string_0 = Eyf.me(string_0, bool_0);
				lcc lcc = new lcc();
				foreach (char c in string_0)
				{
					char c2 = c;
					if (c2 != '\'')
					{
						lcc.MPI(c);
					}
					else
					{
						lcc.MPI('\\').MPI(c);
					}
				}
				text = lcc.ToString();
			}
			else
			{
				text = "";
			}
			return text;
		}

		// Token: 0x0601153D RID: 70973 RVA: 0x0069BC58 File Offset: 0x00699E58
		public static string mO(string string_0)
		{
			return Eyf.me(string_0, true);
		}

		// Token: 0x0601153E RID: 70974 RVA: 0x00075BA5 File Offset: 0x00073DA5
		public static void mI(string string_0, lcc lcc_0)
		{
			Eyf.mt(string_0, true, lcc_0);
		}

		// Token: 0x0601153F RID: 70975 RVA: 0x0069BC70 File Offset: 0x00699E70
		public static string me(string string_0, bool bool_0)
		{
			string text;
			if (!Eyf.lx(string_0))
			{
				lcc lcc = new lcc();
				Eyf.mt(string_0, bool_0, lcc);
				text = lcc.ToString();
			}
			else
			{
				text = "";
			}
			return text;
		}

		// Token: 0x06011540 RID: 70976 RVA: 0x0069BCA8 File Offset: 0x00699EA8
		public static void mt(string string_0, bool bool_0, lcc lcc_0)
		{
			char c = '\0';
			if (bool_0)
			{
				lcc_0.MPI('"');
			}
			int i = 0;
			while (i < string_0.Length)
			{
				char c2 = c;
				c = string_0[i];
				char c3 = c;
				if (c3 > '"')
				{
					if (c3 != '/')
					{
						if (c3 != '\\')
						{
							goto IL_00A6;
						}
						goto IL_008F;
					}
					else
					{
						if (c2 == '<')
						{
							lcc_0.MPI('\\');
						}
						lcc_0.MPI(c);
					}
				}
				else
				{
					switch (c3)
					{
					case '\b':
						lcc_0.MPI("\\b");
						break;
					case '\t':
						lcc_0.MPI("\\t");
						break;
					case '\n':
						lcc_0.MPI("\\n");
						break;
					case '\v':
						goto IL_00A6;
					case '\f':
						lcc_0.MPI("\\f");
						break;
					case '\r':
						lcc_0.MPI("\\r");
						break;
					default:
						if (c3 != '"')
						{
							goto IL_00A6;
						}
						goto IL_008F;
					}
				}
				IL_0045:
				i++;
				continue;
				IL_008F:
				lcc_0.MPI('\\').MPI(c);
				goto IL_0045;
				IL_00A6:
				if (c < ' ')
				{
					goto IL_00AB;
				}
				if (c >= '\u0080')
				{
					if (c < '\u00a0')
					{
						goto IL_00AB;
					}
				}
				bool flag = c < '\u2000' || c >= '℀';
				IL_00AC:
				if (flag)
				{
					lcc_0.MPI(c);
					goto IL_0045;
				}
				string text = "000" + Eyf.nm((long)((ulong)c), 4, false);
				lcc_0.MPI("\\u").MPI(lcP.IG(text, text.Length - 4));
				goto IL_0045;
				IL_00AB:
				flag = false;
				goto IL_00AC;
			}
			if (bool_0)
			{
				lcc_0.MPI('"');
			}
		}

		// Token: 0x06011541 RID: 70977 RVA: 0x0069BE38 File Offset: 0x0069A038
		public static string mg(string string_0)
		{
			return Eyf.mA(string_0, false);
		}

		// Token: 0x06011542 RID: 70978 RVA: 0x0069BE50 File Offset: 0x0069A050
		public static string mA(string string_0, bool bool_0)
		{
			string text;
			if (!Eyf.lx(string_0))
			{
				lcc lcc = new lcc(string_0.Length);
				Eyf.mr(string_0, bool_0, lcc);
				text = lcc.ToString();
			}
			else
			{
				text = "";
			}
			return text;
		}

		// Token: 0x06011543 RID: 70979 RVA: 0x0069BE8C File Offset: 0x0069A08C
		public static void mr(string string_0, bool bool_0, lcc lcc_0)
		{
			if (!Eyf.lx(string_0))
			{
				int num;
				if (bool_0)
				{
					if (string_0[0] == '"')
					{
						num = 1;
						goto IL_0012;
					}
				}
				num = 0;
				IL_0012:
				int num2 = num;
				int i = num2;
				while (i < string_0.Length)
				{
					char c = string_0[i];
					if (c != '\\' || i >= string_0.Length - 1)
					{
						goto IL_0035;
					}
					char c2 = string_0[i + 1];
					char c3 = c2;
					if (c3 > '\\')
					{
						if (c3 > 'f')
						{
							if (c3 == 'n')
							{
								lcc_0.MPI('\n');
								i++;
								goto IL_0053;
							}
							switch (c3)
							{
							case 'r':
								lcc_0.MPI('\r');
								i++;
								goto IL_0053;
							case 't':
								lcc_0.MPI('\t');
								i++;
								goto IL_0053;
							}
						}
						else
						{
							if (c3 == 'b')
							{
								lcc_0.MPI('\b');
								i++;
								goto IL_0053;
							}
							if (c3 == 'f')
							{
								lcc_0.MPI('\f');
								i++;
								goto IL_0053;
							}
						}
					}
					else
					{
						if (c3 == '"')
						{
							lcc_0.MPI('"');
							i++;
							goto IL_0053;
						}
						if (c3 == '/')
						{
							lcc_0.MPI('/');
							i++;
							goto IL_0053;
						}
						if (c3 == '\\')
						{
							lcc_0.MPI('\\');
							i++;
							goto IL_0053;
						}
					}
					if (c2 != 'u' || i >= string_0.Length - 5)
					{
						goto IL_0035;
					}
					char c4 = string_0[i + 2];
					char c5 = string_0[i + 3];
					char c6 = string_0[i + 4];
					char c7 = string_0[i + 5];
					if (!Eyf.mF(c4) || !Eyf.mF(c5) || !Eyf.mF(c6) || !Eyf.mF(c7))
					{
						goto IL_0035;
					}
					char c8 = (char)((Eyf.mK(c4) << 12) + (Eyf.mK(c5) << 8) + (Eyf.mK(c6) << 4) + Eyf.mK(c7));
					lcc_0.MPI(c8);
					i += 5;
					IL_0053:
					i++;
					continue;
					IL_0035:
					if (i < string_0.Length - 1 || num2 == 0)
					{
						lcc_0.MPI(c);
						goto IL_0053;
					}
					if (c == '"')
					{
						goto IL_0053;
					}
					lcc_0.MPI(c);
					goto IL_0053;
				}
			}
		}

		// Token: 0x06011544 RID: 70980 RVA: 0x0069C0DC File Offset: 0x0069A2DC
		private static bool mF(char char_0)
		{
			if (char_0 < '0' || char_0 > '9')
			{
				if (char_0 >= 'A')
				{
					if (char_0 <= 'F')
					{
						goto IL_0017;
					}
				}
				return char_0 >= 'a' && char_0 <= 'f';
			}
			IL_0017:
			return true;
		}

		// Token: 0x06011545 RID: 70981 RVA: 0x0069C114 File Offset: 0x0069A314
		private static int mK(char char_0)
		{
			int num = (int)(char_0 - '0');
			if (char_0 >= 'a' && char_0 <= 'f')
			{
				num -= 32;
			}
			if (num > 9)
			{
				num -= 7;
			}
			return num;
		}

		// Token: 0x06011546 RID: 70982 RVA: 0x0069C150 File Offset: 0x0069A350
		public static string mq(string string_0, string string_1, string string_2)
		{
			string text3;
			if (!Eyf.lx(string_0) && !Eyf.lx(string_1))
			{
				if (string_2 == null)
				{
					string_2 = "";
				}
				int num;
				while (-1 != (num = string_0.ToLower().IndexOf(string_1.ToLower())))
				{
					string text = lcP.IZ(string_0, 0, num);
					string text2 = lcP.IG(string_0, num + string_1.Length);
					string_0 = text + string_2 + text2;
				}
				text3 = string_0;
			}
			else
			{
				text3 = string_0;
			}
			return text3;
		}

		// Token: 0x06011547 RID: 70983 RVA: 0x0069C1D4 File Offset: 0x0069A3D4
		public static string mS(string string_0, string string_1, string string_2)
		{
			string text4;
			if (!Eyf.lx(string_0) && !Eyf.lx(string_1))
			{
				if (string_2 == null)
				{
					string_2 = "";
				}
				string text = Eyf.Dx(string_1);
				int num = 0;
				while (-1 != (num = Eyf.Dx(string_0).IndexOf(text, num)))
				{
					string text2 = lcP.IZ(string_0, 0, num);
					string text3 = lcP.IG(string_0, num + string_1.Length);
					string_0 = text2 + string_2 + text3;
					num += string_2.Length;
				}
				text4 = string_0;
			}
			else
			{
				text4 = string_0;
			}
			return text4;
		}

		// Token: 0x06011548 RID: 70984 RVA: 0x0069C268 File Offset: 0x0069A468
		public static string mZ(string string_0, string string_1, string string_2)
		{
			string text;
			if (string_0 != null && string_0.Length > 0)
			{
				text = Regex.Replace(string_0, string_1, string_2);
			}
			else
			{
				text = string_0;
			}
			return text;
		}

		// Token: 0x06011549 RID: 70985 RVA: 0x003B4B78 File Offset: 0x003B2D78
		public static int xB(string string_0, string string_1)
		{
			return string.CompareOrdinal(string_0, string_1);
		}

		// Token: 0x0601154A RID: 70986 RVA: 0x0069C294 File Offset: 0x0069A494
		public static string[] xJ(string string_0, string string_1)
		{
			return Eyf.xY(string_0, false, string_1);
		}

		// Token: 0x0601154B RID: 70987 RVA: 0x0069C2AC File Offset: 0x0069A4AC
		public static string[] xY(string string_0, bool bool_0, string string_1)
		{
			return Eyf.xV(string_0, bool_0, string_1, true);
		}

		// Token: 0x0601154C RID: 70988 RVA: 0x0069C2C4 File Offset: 0x0069A4C4
		public static string[] xV(string string_0, bool bool_0, string string_1, bool bool_1)
		{
			string[] array2;
			if (string_0 != null)
			{
				if (bool_1)
				{
					string_0 = Eyf.mh(string_0);
				}
				string[] array = string_0.Split(new string[] { string_1 }, (!bool_0) ? StringSplitOptions.None : StringSplitOptions.RemoveEmptyEntries);
				if (bool_1)
				{
					array = Eyf.mU(array, bool_0);
				}
				array2 = array;
			}
			else
			{
				array2 = null;
			}
			return array2;
		}

		// Token: 0x0601154D RID: 70989 RVA: 0x0069C320 File Offset: 0x0069A520
		public static string[] xp(string string_0, char char_0)
		{
			return Eyf.xh(string_0, false, char_0, false);
		}

		// Token: 0x0601154E RID: 70990 RVA: 0x0069C338 File Offset: 0x0069A538
		public static string[] xC(string string_0, bool bool_0)
		{
			return Eyf.xh(string_0, bool_0, ',', false);
		}

		// Token: 0x0601154F RID: 70991 RVA: 0x0069C354 File Offset: 0x0069A554
		public static string[] xU(string string_0, bool bool_0, char char_0)
		{
			return Eyf.xh(string_0, bool_0, char_0, false);
		}

		// Token: 0x06011550 RID: 70992 RVA: 0x0069C36C File Offset: 0x0069A56C
		public static string[] xh(string string_0, bool bool_0, char char_0, bool bool_1)
		{
			return Eyf.xD(string_0, bool_0, char_0, bool_1, true);
		}

		// Token: 0x06011551 RID: 70993 RVA: 0x0069C388 File Offset: 0x0069A588
		public static string[] xD(string string_0, bool bool_0, char char_0, bool bool_1, bool bool_2)
		{
			return Eyf.xl(string_0, bool_0, new char[] { char_0 }, bool_1, bool_2);
		}

		// Token: 0x06011552 RID: 70994 RVA: 0x0069C3B0 File Offset: 0x0069A5B0
		public static string[] xl(string string_0, bool bool_0, char[] char_0, bool bool_1, bool bool_2)
		{
			return Eyf.xm(string_0, bool_0, char_0, bool_1, bool_2, false);
		}

		// Token: 0x06011553 RID: 70995 RVA: 0x0069C3CC File Offset: 0x0069A5CC
		public static string[] xm(string string_0, bool bool_0, char[] char_0, bool bool_1, bool bool_2, bool bool_3)
		{
			string[] array2;
			if (string_0 != null)
			{
				if (bool_2)
				{
					string_0 = Eyf.mh(string_0);
				}
				if (char_0 != null && char_0.Length > 0)
				{
					if (bool_1 || char_0.Length != 1)
					{
						lyv<string> lyv = new lyv<string>();
						lcc lcc = new lcc();
						bool flag = false;
						foreach (char c in string_0)
						{
							bool flag2 = false;
							int num = 0;
							while (!flag2 && num < char_0.Length)
							{
								if (c == char_0[num])
								{
									flag2 = true;
								}
								num++;
							}
							if (bool_3 && !flag2 && flag)
							{
								lcc.MPI('\\');
							}
							if (bool_1 && c == '\\')
							{
								flag = !flag;
							}
							if (!flag2 || flag)
							{
								if (c != '\\' || !flag)
								{
									lcc.MPI(c);
									flag = false;
								}
							}
							else
							{
								string text = lcc.ToString();
								if (!bool_0 || !Eyf.lx(text))
								{
									lyv.Add(text);
								}
								lcc = new lcc();
							}
						}
						if (!bool_0 || !Eyf.lx(lcc.ToString()))
						{
							lyv.Add(lcc.ToString());
						}
						string[] array = Eyf.On(lyv);
						array2 = ((!bool_2) ? array : Eyf.mU(array, bool_0));
					}
					else
					{
						string[] array3 = string_0.Split(char_0, (!bool_0) ? StringSplitOptions.None : StringSplitOptions.RemoveEmptyEntries);
						array2 = ((!bool_2) ? array3 : Eyf.mU(array3, bool_0));
					}
				}
				else if (!bool_0 || !Eyf.lx(string_0))
				{
					array2 = new string[] { string_0 };
				}
				else
				{
					array2 = new string[0];
				}
			}
			else
			{
				array2 = null;
			}
			return array2;
		}

		// Token: 0x06011554 RID: 70996 RVA: 0x0069C5C4 File Offset: 0x0069A7C4
		public static string xx(string string_0, string string_1)
		{
			string text;
			if (string_0 != null)
			{
				lcc lcc = new lcc();
				foreach (char c in string_0)
				{
					if (c == '\\' || c == string_1[0])
					{
						lcc.MPI('\\');
					}
					lcc.MPI(c);
				}
				text = lcc.ToString();
			}
			else
			{
				text = null;
			}
			return text;
		}

		// Token: 0x06011555 RID: 70997 RVA: 0x0069C638 File Offset: 0x0069A838
		public static string xn(string string_0, string[] string_1)
		{
			return Eyf.xO(string_0, string_1, 0, (string_1 == null) ? 0 : string_1.Length, false);
		}

		// Token: 0x06011556 RID: 70998 RVA: 0x0069C65C File Offset: 0x0069A85C
		public static string xw(string string_0, string[] string_1, bool bool_0)
		{
			return Eyf.xO(string_0, string_1, 0, (string_1 == null) ? 0 : string_1.Length, bool_0);
		}

		// Token: 0x06011557 RID: 70999 RVA: 0x0069C680 File Offset: 0x0069A880
		public static string xO(string string_0, string[] string_1, int int_0, int int_1, bool bool_0)
		{
			string text2;
			if (string_1 != null)
			{
				int_1 = Math.Min(int_1, string_1.Length - int_0);
				lcc lcc = new lcc();
				for (int i = 0; i < int_1; i++)
				{
					string text = string_1[int_0 + i];
					if (bool_0)
					{
						text = Eyf.xx(text, string_0);
					}
					if (i > 0)
					{
						lcc.MPI(string_0);
					}
					lcc.MPI((text != null) ? text : "");
				}
				text2 = lcc.ToString();
			}
			else
			{
				text2 = "";
			}
			return text2;
		}

		// Token: 0x06011558 RID: 71000 RVA: 0x0069C708 File Offset: 0x0069A908
		public static string xI(string string_0, IList<string> ilist_0)
		{
			return Eyf.xe(string_0, ilist_0, 0, (ilist_0 == null) ? 0 : ilist_0.Count, false);
		}

		// Token: 0x06011559 RID: 71001 RVA: 0x0069C72C File Offset: 0x0069A92C
		public static string xe(string string_0, IList<string> ilist_0, int int_0, int int_1, bool bool_0)
		{
			string text2;
			if (ilist_0 != null)
			{
				int num = Math.Min(int_0 + int_1, ilist_0.Count);
				lcc lcc = new lcc();
				while (int_0 < num)
				{
					string text = ilist_0[int_0];
					if (bool_0)
					{
						text = Eyf.xx(text, string_0);
					}
					lcc.MPI(text);
					if (int_0 < num - 1)
					{
						lcc.MPI(string_0);
					}
					int_0++;
				}
				text2 = lcc.ToString();
			}
			else
			{
				text2 = "";
			}
			return text2;
		}

		// Token: 0x0601155A RID: 71002 RVA: 0x0069C7B0 File Offset: 0x0069A9B0
		public static string xt(string string_0, string[] string_1, int int_0, int int_1)
		{
			return Eyf.xO(string_0, string_1, int_0, int_1, false);
		}

		// Token: 0x0601155B RID: 71003 RVA: 0x0069C7CC File Offset: 0x0069A9CC
		public static string xg(byte[] byte_0)
		{
			return Eyf.xA(byte_0, 0, byte_0.Length);
		}

		// Token: 0x0601155C RID: 71004 RVA: 0x0054ECF4 File Offset: 0x0054CEF4
		public static string xA(byte[] byte_0, int int_0, int int_1)
		{
			return Encoding.Default.GetString(byte_0, int_0, int_1);
		}

		// Token: 0x0601155D RID: 71005 RVA: 0x0069C7E8 File Offset: 0x0069A9E8
		public static string xr(byte[] byte_0)
		{
			return Eyf.xF(byte_0, 0, byte_0.Length);
		}

		// Token: 0x0601155E RID: 71006 RVA: 0x0069C804 File Offset: 0x0069AA04
		public static string xF(byte[] byte_0, int int_0, int int_1)
		{
			string text;
			if (Environment.OSVersion.Platform != PlatformID.WinCE)
			{
				text = Eyf.IO(byte_0, int_0, int_1, "ISO-8859-1");
			}
			else
			{
				text = Eyf.IO(byte_0, int_0, int_1, "US-ASCII");
			}
			return text;
		}

		// Token: 0x0601155F RID: 71007 RVA: 0x0069C844 File Offset: 0x0069AA44
		public static void xK(string string_0, lyN lyN_0, lyN lyN_1)
		{
			Eyf.xS(string_0, lyN_0, lyN_1, 2, new string[] { ";", "=" }, false);
		}

		// Token: 0x06011560 RID: 71008 RVA: 0x0069C874 File Offset: 0x0069AA74
		public static void xq(string string_0, lyN lyN_0, lyN lyN_1)
		{
			Eyf.xS(string_0, lyN_0, lyN_1, 1, new string[] { "&", "=" }, true);
			for (int i = 0; i < lyN_1.W(); i++)
			{
				if (lyN_1.K(i) != null)
				{
					lyN_1.MPv(Eyf.lt((string)lyN_1.K(i)), i);
				}
			}
		}

		// Token: 0x06011561 RID: 71009 RVA: 0x0069C8E0 File Offset: 0x0069AAE0
		public static void xS(string string_0, lyN lyN_0, lyN lyN_1, int int_0, string[] string_1, bool bool_0)
		{
			if (lyN_0 == null || lyN_1 == null)
			{
				throw new Egs("The names or values cannot be null.");
			}
			if (string_1 != null && string_1.Length >= 2)
			{
				lyN_0.Clear();
				lyN_1.Clear();
				if (string_0 != null && string_0.Length > 0)
				{
					if (bool_0)
					{
						string_0 = Eyf.mh(string_0);
					}
					foreach (string text in lcP.sZ(string_0, string_1[0]))
					{
						string[] array2 = lcP.sZ(text, string_1[1]);
						string text2 = ((array2.Length < 1) ? null : array2[0]);
						string text3 = ((array2.Length < 2) ? null : array2[1]);
						if (!Eyf.lx(text2))
						{
							text2 = Eyf.mh(text2);
						}
						if (!Eyf.lx(text3))
						{
							text3 = Eyf.mh(text3);
						}
						if (int_0 != 1)
						{
							if (int_0 != 2)
							{
								lyN_0.Add(text2);
								lyN_1.Add(text3);
							}
							else if (!Eyf.lx(text2) && !Eyf.lx(text3))
							{
								lyN_0.Add(text2);
								lyN_1.Add(text3);
							}
						}
						else if (!Eyf.lx(text2))
						{
							lyN_0.Add(text2);
							lyN_1.Add(text3);
						}
					}
				}
				return;
			}
			throw new Egs("The seperators are missed.");
		}

		// Token: 0x06011562 RID: 71010 RVA: 0x0069CA7C File Offset: 0x0069AC7C
		public static object[] xZ(string string_0, char char_0)
		{
			return Eyf.nB(string_0, char_0, false);
		}

		// Token: 0x06011563 RID: 71011 RVA: 0x0069CA94 File Offset: 0x0069AC94
		public static object[] nB(string string_0, char char_0, bool bool_0)
		{
			object[] array4;
			if (string_0.IndexOf(char_0) >= 0 || string_0.IndexOf('\\') >= 0)
			{
				string[] array = Eyf.xh(string_0, false, char_0, bool_0);
				object[] array2 = new object[array.Length];
				int num = 0;
				foreach (string text in array)
				{
					if (!Eyf.tn(text))
					{
						array2[num] = text;
					}
					else
					{
						array2[num] = int.Parse(text);
					}
					num++;
				}
				array4 = array2;
			}
			else
			{
				object obj = ((!Eyf.tn(string_0)) ? string_0 : int.Parse(string_0));
				array4 = new object[] { obj };
			}
			return array4;
		}

		// Token: 0x06011564 RID: 71012 RVA: 0x0069CB4C File Offset: 0x0069AD4C
		public static object[] nJ(string string_0, char char_0)
		{
			return Eyf.nY(string_0, char_0, false);
		}

		// Token: 0x06011565 RID: 71013 RVA: 0x0069CB64 File Offset: 0x0069AD64
		public static object[] nY(string string_0, char char_0, bool bool_0)
		{
			string[] array = Eyf.xh(string_0, false, char_0, bool_0);
			lmr<object> lmr = new lmr<object>();
			foreach (string text in array)
			{
				bool flag = false;
				bool flag2 = false;
				lcc lcc = new lcc();
				lcc lcc2 = new lcc();
				foreach (char c in text)
				{
					if (c != '\\')
					{
						if (flag || c != '[')
						{
							if (!flag2 || c != ']')
							{
								if (!flag2)
								{
									if (flag)
									{
										flag = false;
										lcc.MPI('\\');
									}
									lcc.MPI(c);
								}
								else
								{
									lcc2.MPI(c);
								}
							}
							else
							{
								lmr.Add(Eyf.CF(lcc2.ToString(), 0));
								lcc2.j(0);
								flag2 = false;
							}
						}
						else
						{
							if (lcc.D > 0)
							{
								lmr.Add(lcc.ToString());
								lcc.j(0);
							}
							flag2 = true;
						}
					}
					else
					{
						flag = true;
					}
				}
				if (lcc.D > 0)
				{
					lmr.Add(lcc.ToString());
				}
			}
			return lmr.c(typeof(object));
		}

		// Token: 0x06011566 RID: 71014 RVA: 0x0069CCCC File Offset: 0x0069AECC
		public static string nV(string string_0, string string_1)
		{
			string[] array = Eyf.xJ(string_0, string_1);
			lcc lcc = new lcc();
			for (int i = 0; i < array.Length; i++)
			{
				if (lcc.D > 0)
				{
					lcc.MPI(",");
				}
				lcc.MPI("\"").MPI(array[i]).MPI("\"");
			}
			lcc.MPN(0, "[");
			lcc.MPI("]");
			return lcc.ToString();
		}

		// Token: 0x06011567 RID: 71015 RVA: 0x0069CD54 File Offset: 0x0069AF54
		public static void np(RSBItem rsbitem_0, string[] string_0, string[] string_1)
		{
			Eyf.nh(rsbitem_0, string_0, string_1, null, null, null, null, null, null);
		}

		// Token: 0x06011568 RID: 71016 RVA: 0x0069CD70 File Offset: 0x0069AF70
		public static void nC(RSBItem rsbitem_0, string[] string_0, string[] string_1, string[] string_2, string[] string_3, string string_4)
		{
			Eyf.nh(rsbitem_0, string_0, string_1, string_2, string_3, string_4, null, null, null);
		}

		// Token: 0x06011569 RID: 71017 RVA: 0x0069CD90 File Offset: 0x0069AF90
		public static void nU(RSBItem rsbitem_0, string[] string_0, string[] string_1, string[] string_2, string[] string_3, string string_4, string[] string_5, string[] string_6)
		{
			Eyf.nh(rsbitem_0, string_0, string_1, string_2, string_3, string_4, string_5, string_6, null);
		}

		// Token: 0x0601156A RID: 71018 RVA: 0x0069CDB0 File Offset: 0x0069AFB0
		public static void nh(RSBItem rsbitem_0, string[] string_0, string[] string_1, string[] string_2, string[] string_3, string string_4, string[] string_5, string[] string_6, string string_7)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				rsbitem_0.SetAttr("errormessagepath", string_0[i], i);
			}
			for (int i = 0; i < string_1.Length; i++)
			{
				rsbitem_0.SetAttr("errorcodepath", string_1[i], i);
			}
			if (string_3 != null && string_2 != null && string_3.Length == string_2.Length)
			{
				for (int i = 0; i < string_3.Length; i++)
				{
					rsbitem_0.SetAttr("errorretrypath", string_2[i], i);
					rsbitem_0.SetAttr("errorretryvalue", string_3[i], i);
				}
				if (string_4 == null || !string_4.Equals("CONTAINS"))
				{
					rsbitem_0.SetAttr("retrymatch", "EQUALS");
				}
				else
				{
					rsbitem_0.SetAttr("retrymatch", "CONTAINS");
				}
			}
			if (string_5 != null)
			{
				for (int i = 0; i < string_5.Length; i++)
				{
					rsbitem_0.SetAttr("errormaxreqretries", string_5[i], i);
				}
			}
			if (string_6 != null)
			{
				for (int i = 0; i < string_6.Length; i++)
				{
					rsbitem_0.SetAttr("errorretrywaittime", string_6[i], i);
				}
			}
			if (string_7 != null)
			{
				rsbitem_0.SetAttr("errormessageencoding", string_7);
			}
		}

		// Token: 0x0601156B RID: 71019 RVA: 0x0069CF00 File Offset: 0x0069B100
		public static byte[] nD(long long_0, int int_0)
		{
			byte[] array = new byte[int_0];
			Eyf.nl(long_0, array, 0, int_0);
			return array;
		}

		// Token: 0x0601156C RID: 71020 RVA: 0x0028432C File Offset: 0x0028252C
		public static void nl(long long_0, byte[] byte_0, int int_0, int int_1)
		{
			int i = int_0 + int_1 - 1;
			while (i >= int_0)
			{
				byte_0[i] = (byte)(long_0 & 255L);
				i--;
				long_0 >>= 8;
			}
		}

		// Token: 0x0601156D RID: 71021 RVA: 0x0069CF20 File Offset: 0x0069B120
		public static string nm(long long_0, int int_0, bool bool_0)
		{
			return Eyf.nx(Eyf.nD(long_0, int_0), bool_0);
		}

		// Token: 0x0601156E RID: 71022 RVA: 0x0069CF3C File Offset: 0x0069B13C
		public static string nx(byte[] byte_0, bool bool_0)
		{
			return Eyf.nn(byte_0, 0, byte_0.Length, bool_0);
		}

		// Token: 0x0601156F RID: 71023 RVA: 0x0069CF58 File Offset: 0x0069B158
		public static string nn(byte[] byte_0, int int_0, int int_1, bool bool_0)
		{
			if (int_0 + int_1 > byte_0.Length)
			{
				int_1 = byte_0.Length - int_0;
			}
			char[] array = new char[int_1 * 2];
			Eyf.nw(byte_0, int_0, array, 0, int_1, bool_0);
			return new string(array);
		}

		// Token: 0x06011570 RID: 71024 RVA: 0x0069CF98 File Offset: 0x0069B198
		public static int nw(byte[] byte_0, int int_0, char[] char_0, int int_1, int int_2, bool bool_0)
		{
			if (int_0 + int_2 > byte_0.Length)
			{
				int_2 = byte_0.Length - int_0;
			}
			if (int_1 + int_2 * 2 > char_0.Length)
			{
				int_2 = (char_0.Length - int_1) / 2;
			}
			char[] array = ((!bool_0) ? Eyf.GG : Eyf.GK);
			int num = int_0 + int_2;
			while (int_0 < num)
			{
				byte b = byte_0[int_0];
				char_0[int_1++] = array[(b >> 4) & 15];
				char_0[int_1++] = array[(int)(b & 15)];
				int_0++;
			}
			return int_2 * 2;
		}

		// Token: 0x06011571 RID: 71025 RVA: 0x0069D030 File Offset: 0x0069B230
		public static byte[] nO(string string_0)
		{
			return Eyf.nI(Eyf.ID(string_0));
		}

		// Token: 0x06011572 RID: 71026 RVA: 0x0069D04C File Offset: 0x0069B24C
		public static byte[] nI(byte[] byte_0)
		{
			return Eyf.ne(byte_0, 0, byte_0.Length);
		}

		// Token: 0x06011573 RID: 71027 RVA: 0x0069D068 File Offset: 0x0069B268
		public static byte[] ne(byte[] byte_0, int int_0, int int_1)
		{
			lcN lcN = new lcN();
			lcv lcv = new lcv(byte_0, int_0, int_1);
			byte[] array;
			try
			{
				Eyf.nt(lcv, lcN);
				array = lcN.p();
			}
			finally
			{
				try
				{
					lcN.MPe();
				}
				catch (IOException)
				{
				}
			}
			return array;
		}

		// Token: 0x06011574 RID: 71028 RVA: 0x0069D0C0 File Offset: 0x0069B2C0
		private static void nt(lcX lcX_0, lcX lcX_1)
		{
			try
			{
				byte[] array = new byte[4096];
				byte[] array2 = new byte[2048];
				int num;
				while ((num = lcX_0.V(array)) > 0)
				{
					if (num % 2 != 0)
					{
						throw new Egs("Invalid HEX-encoded data.");
					}
					int num2 = Eyf.ng(array, 0, array2, 0, num);
					lcX_1.O(array2, 0, num2);
				}
			}
			catch (Exception ex)
			{
				throw new Egs(ex);
			}
		}

		// Token: 0x06011575 RID: 71029 RVA: 0x001DAB48 File Offset: 0x001D8D48
		private static int ng(byte[] byte_0, int int_0, byte[] byte_1, int int_1, int int_2)
		{
			int num = 0;
			int i = 0;
			while (i < int_2)
			{
				int num2 = (int)byte_0[int_0 + i];
				byte_1[int_1 + num] = (byte)((num2 - ((num2 <= 96) ? ((num2 <= 64) ? 48 : 55) : 87) << 4) & 240);
				num2 = (int)byte_0[int_0 + i + 1];
				int num3 = int_1 + num;
				byte_1[num3] |= (byte)((num2 - ((num2 <= 96) ? ((num2 <= 64) ? 48 : 55) : 87)) & 15);
				i += 2;
				num++;
			}
			return num;
		}

		// Token: 0x06011576 RID: 71030 RVA: 0x0069D13C File Offset: 0x0069B33C
		public static byte nA(byte[] byte_0, int int_0)
		{
			byte[] array = new byte[1];
			Eyf.ng(byte_0, int_0, array, 0, 2);
			return array[0];
		}

		// Token: 0x06011577 RID: 71031 RVA: 0x003B5210 File Offset: 0x003B3410
		internal static long nr(string string_0)
		{
			return long.Parse(string_0, NumberStyles.HexNumber);
		}

		// Token: 0x06011578 RID: 71032 RVA: 0x0069D160 File Offset: 0x0069B360
		public static string nF(string string_0)
		{
			return Eyf.nK(string_0, false, false);
		}

		// Token: 0x06011579 RID: 71033 RVA: 0x0069D178 File Offset: 0x0069B378
		public static string nK(string string_0, bool bool_0, bool bool_1)
		{
			lcc lcc = new lcc(string_0.Length);
			bool flag = false;
			int length = string_0.Length;
			for (int i = 0; i < length; i++)
			{
				char c = string_0[i];
				if (c != ' ' || !bool_1)
				{
					flag = false;
					if (c != '"')
					{
						if (c != '&')
						{
							if (c != '<')
							{
								if (c != '>')
								{
									if (bool_0)
									{
										int num = (int)(char.MaxValue & c);
										if (num >= 160)
										{
											lcc.MPI("&#");
											lcc.MPI(Eyf.DO(num));
											lcc.MPI(';');
										}
										else
										{
											lcc.MPI(c);
										}
									}
									else
									{
										lcc.MPI(c);
									}
								}
								else
								{
									lcc.MPI("&gt;");
								}
							}
							else
							{
								lcc.MPI("&lt;");
							}
						}
						else
						{
							lcc.MPI("&amp;");
						}
					}
					else
					{
						lcc.MPI("&quot;");
					}
				}
				else if (!flag)
				{
					flag = true;
					lcc.MPI(' ');
				}
				else
				{
					flag = false;
					lcc.MPI("&nbsp;");
				}
			}
			return lcc.ToString();
		}

		// Token: 0x0601157A RID: 71034 RVA: 0x0069D2CC File Offset: 0x0069B4CC
		public static string nq(string string_0)
		{
			string text2;
			if (string_0.IndexOf('&') != -1)
			{
				lcc lcc = new lcc();
				lcc lcc2 = new lcc();
				bool flag = false;
				foreach (char c in string_0)
				{
					if (!flag)
					{
						if (c != '&')
						{
							lcc.MPI(c);
						}
						else
						{
							flag = true;
						}
					}
					else if (c != ';')
					{
						lcc2.MPI(c);
					}
					else
					{
						string text = lcc2.ToString();
						if (!text.StartsWith("#"))
						{
							if (!lcP.nt(text, "lt"))
							{
								if (!lcP.nt(text, "gt"))
								{
									if (!lcP.nt(text, "apos"))
									{
										if (!lcP.nt(text, "quot"))
										{
											if (!lcP.nt(text, "amp"))
											{
												if (lcP.nt(text, "gt"))
												{
													lcc.MPI('>');
												}
											}
											else
											{
												lcc.MPI('&');
											}
										}
										else
										{
											lcc.MPI('"');
										}
									}
									else
									{
										lcc.MPI('\'');
									}
								}
								else
								{
									lcc.MPI('>');
								}
							}
							else
							{
								lcc.MPI('<');
							}
						}
						else
						{
							text = lcP.IG(text, 1);
							if (!text.StartsWith("x"))
							{
								lcc.MPI((char)int.Parse(text));
							}
							else
							{
								text = lcP.IG(text, 1);
								lcc.MPI((char)Convert.ToUInt32(text, 16));
							}
						}
						flag = false;
						lcc2.j(0);
					}
				}
				if (lcc2.D > 0)
				{
					lcc.MPI(lcc2.ToString());
				}
				text2 = lcc.ToString();
			}
			else
			{
				text2 = string_0;
			}
			return text2;
		}

		// Token: 0x0601157B RID: 71035 RVA: 0x0069D4B8 File Offset: 0x0069B6B8
		public static string nS(string string_0)
		{
			return Eyf.nZ(Eyf.Ip(string_0, "utf-8"));
		}

		// Token: 0x0601157C RID: 71036 RVA: 0x0069D4D8 File Offset: 0x0069B6D8
		public static string nZ(byte[] byte_0)
		{
			string text;
			if (byte_0 == null || byte_0.Length <= 0)
			{
				text = "";
			}
			else
			{
				text = Eyf.Im(Eyf.wm(byte_0, 0, byte_0.Length, true));
			}
			return text;
		}

		// Token: 0x0601157D RID: 71037 RVA: 0x0069D510 File Offset: 0x0069B710
		public static string wB(string string_0)
		{
			return Eyf.wV(Eyf.Ip(string_0, "utf-8"));
		}

		// Token: 0x0601157E RID: 71038 RVA: 0x0069D530 File Offset: 0x0069B730
		public static string wV(byte[] byte_0)
		{
			string text;
			if (byte_0 == null || byte_0.Length <= 0)
			{
				text = "";
			}
			else
			{
				text = Eyf.Im(Eyf.wD(byte_0));
			}
			return text;
		}

		// Token: 0x0601157F RID: 71039 RVA: 0x0069D564 File Offset: 0x0069B764
		public static string wp(byte[] byte_0, int int_0, int int_1)
		{
			string text;
			if (byte_0 == null || byte_0.Length <= 0)
			{
				text = "";
			}
			else
			{
				text = Eyf.Im(Eyf.wm(byte_0, int_0, int_1, false));
			}
			return text;
		}

		// Token: 0x06011580 RID: 71040 RVA: 0x0069D59C File Offset: 0x0069B79C
		public static byte[] wD(byte[] byte_0)
		{
			return Eyf.wm(byte_0, 0, byte_0.Length, false);
		}

		// Token: 0x06011581 RID: 71041 RVA: 0x0069D5B8 File Offset: 0x0069B7B8
		public static byte[] wm(byte[] byte_0, int int_0, int int_1, bool bool_0)
		{
			int num = (int_1 / 3 + 1) * 4;
			Ega ega = new Ega(num);
			char[] array = new char[64];
			array[0] = 'A';
			array[1] = 'B';
			array[2] = 'C';
			array[3] = 'D';
			array[4] = 'E';
			array[5] = 'F';
			array[6] = 'G';
			array[7] = 'H';
			array[8] = 'I';
			array[9] = 'J';
			array[10] = 'K';
			array[11] = 'L';
			array[12] = 'M';
			array[13] = 'N';
			array[14] = 'O';
			array[15] = 'P';
			array[16] = 'Q';
			array[17] = 'R';
			array[18] = 'S';
			array[19] = 'T';
			array[20] = 'U';
			array[21] = 'V';
			array[22] = 'W';
			array[23] = 'X';
			array[24] = 'Y';
			array[25] = 'Z';
			array[26] = 'a';
			array[27] = 'b';
			array[28] = 'c';
			array[29] = 'd';
			array[30] = 'e';
			array[31] = 'f';
			array[32] = 'g';
			array[33] = 'h';
			array[34] = 'i';
			array[35] = 'j';
			array[36] = 'k';
			array[37] = 'l';
			array[38] = 'm';
			array[39] = 'n';
			array[40] = 'o';
			array[41] = 'p';
			array[42] = 'q';
			array[43] = 'r';
			array[44] = 's';
			array[45] = 't';
			array[46] = 'u';
			array[47] = 'v';
			array[48] = 'w';
			array[49] = 'x';
			array[50] = 'y';
			array[51] = 'z';
			array[52] = '0';
			array[53] = '1';
			array[54] = '2';
			array[55] = '3';
			array[56] = '4';
			array[57] = '5';
			array[58] = '6';
			array[59] = '7';
			array[60] = '8';
			char[] array2 = array;
			int num2 = 61;
			int num3 = 62;
			array2[num2] = 57;
			if (!bool_0)
			{
				array[num3++] = '+';
				array[num3++] = '/';
			}
			else
			{
				array[num3++] = '-';
				array[num3++] = '_';
			}
			int i = int_0;
			while (i < int_0 + int_1)
			{
				if (int_0 + int_1 - i != 1)
				{
					if (int_0 + int_1 - i != 2)
					{
						ega.Tc((byte)array[(byte_0[i] >> 2) & 63]);
						ega.Tc((byte)array[(((int)byte_0[i] << 4) & 48) + ((byte_0[i + 1] >> 4) & 15)]);
						ega.Tc((byte)array[(((int)byte_0[i + 1] << 2) & 60) + ((byte_0[i + 2] >> 6) & 3)]);
						ega.Tc((byte)array[(int)(byte_0[i + 2] & 63)]);
						i += 3;
						continue;
					}
					ega.Tc((byte)array[(byte_0[i] >> 2) & 63]);
					ega.Tc((byte)array[(((int)byte_0[i] << 4) & 48) + ((byte_0[i + 1] >> 4) & 15)]);
					ega.Tc((byte)array[((int)byte_0[i + 1] << 2) & 60]);
					if (!bool_0)
					{
						ega.Tc(61);
					}
				}
				else
				{
					ega.Tc((byte)array[(byte_0[i] >> 2) & 63]);
					ega.Tc((byte)array[((int)byte_0[i] << 4) & 48]);
					if (!bool_0)
					{
						ega.Tc(61);
						ega.Tc(61);
					}
				}
				IL_039E:
				return ega.ri();
			}
			goto IL_039E;
		}

		// Token: 0x06011582 RID: 71042 RVA: 0x0069D970 File Offset: 0x0069BB70
		public static string wx(byte[] byte_0)
		{
			return Eyf.In(Eyf.wZ(byte_0, true), "utf-8");
		}

		// Token: 0x06011583 RID: 71043 RVA: 0x0069D990 File Offset: 0x0069BB90
		public static string wn(string string_0)
		{
			string text;
			if (Eyf.lx(string_0))
			{
				text = "";
			}
			else
			{
				byte[] array = Eyf.wO(string_0);
				text = Eyf.In(array, "utf-8");
			}
			return text;
		}

		// Token: 0x06011584 RID: 71044 RVA: 0x0069D9C4 File Offset: 0x0069BBC4
		public static byte[] wO(string string_0)
		{
			if (Eyf.lx(string_0))
			{
				if (string_0 == null)
				{
					return null;
				}
			}
			else
			{
				try
				{
					return Eyf.wZ(Eyf.IV(string_0), true);
				}
				catch (Exception ex)
				{
					throw new Egs(ex);
				}
			}
			return new byte[0];
		}

		// Token: 0x06011585 RID: 71045 RVA: 0x0069DA14 File Offset: 0x0069BC14
		public static string wt(byte[] byte_0)
		{
			return Eyf.In(Eyf.wK(byte_0), "utf-8");
		}

		// Token: 0x06011586 RID: 71046 RVA: 0x0069DA34 File Offset: 0x0069BC34
		public static string wA(string string_0)
		{
			string text;
			if (Eyf.lx(string_0))
			{
				text = "";
			}
			else
			{
				byte[] array = Eyf.wr(string_0);
				text = Eyf.In(array, "utf-8");
			}
			return text;
		}

		// Token: 0x06011587 RID: 71047 RVA: 0x0069DA68 File Offset: 0x0069BC68
		public static byte[] wr(string string_0)
		{
			if (Eyf.lx(string_0))
			{
				if (string_0 == null)
				{
					return null;
				}
			}
			else
			{
				try
				{
					return Eyf.wK(Eyf.IV(string_0));
				}
				catch (Exception ex)
				{
					throw new Egs(ex);
				}
			}
			return new byte[0];
		}

		// Token: 0x06011588 RID: 71048 RVA: 0x0069DAB8 File Offset: 0x0069BCB8
		public static byte[] wK(byte[] byte_0)
		{
			return Eyf.wZ(byte_0, false);
		}

		// Token: 0x06011589 RID: 71049 RVA: 0x0069DAD0 File Offset: 0x0069BCD0
		public static byte[] wZ(byte[] byte_0, bool bool_0)
		{
			sbyte[] array = new sbyte[4];
			int num = (int)((double)byte_0.Length * 0.75);
			Ega ega = new Ega(num);
			sbyte[] array2 = new sbyte[128];
			array2[0] = -1;
			array2[1] = -1;
			array2[2] = -1;
			array2[3] = -1;
			array2[4] = -1;
			array2[5] = -1;
			array2[6] = -1;
			array2[7] = -1;
			array2[8] = -1;
			array2[9] = -1;
			array2[10] = -1;
			array2[11] = -1;
			array2[12] = -1;
			array2[13] = -1;
			array2[14] = -1;
			array2[15] = -1;
			array2[16] = -1;
			array2[17] = -1;
			array2[18] = -1;
			array2[19] = -1;
			array2[20] = -1;
			array2[21] = -1;
			array2[22] = -1;
			array2[23] = -1;
			array2[24] = -1;
			array2[25] = -1;
			array2[26] = -1;
			array2[27] = -1;
			array2[28] = -1;
			array2[29] = -1;
			array2[30] = -1;
			array2[31] = -1;
			array2[32] = -1;
			array2[33] = -1;
			array2[34] = -1;
			array2[35] = -1;
			array2[36] = -1;
			array2[37] = -1;
			array2[38] = -1;
			array2[39] = -1;
			array2[40] = -1;
			array2[41] = -1;
			array2[42] = -1;
			array2[43] = 62;
			array2[44] = -1;
			array2[45] = -1;
			array2[46] = -1;
			array2[47] = 63;
			array2[48] = 52;
			array2[49] = 53;
			array2[50] = 54;
			array2[51] = 55;
			array2[52] = 56;
			array2[53] = 57;
			array2[54] = 58;
			array2[55] = 59;
			array2[56] = 60;
			array2[57] = 61;
			array2[58] = -1;
			array2[59] = -1;
			array2[60] = -1;
			array2[61] = 99;
			array2[62] = -1;
			array2[63] = -1;
			array2[64] = -1;
			array2[65] = 0;
			array2[66] = 1;
			array2[67] = 2;
			array2[68] = 3;
			array2[69] = 4;
			array2[70] = 5;
			array2[71] = 6;
			array2[72] = 7;
			array2[73] = 8;
			array2[74] = 9;
			array2[75] = 10;
			array2[76] = 11;
			array2[77] = 12;
			array2[78] = 13;
			array2[79] = 14;
			array2[80] = 15;
			array2[81] = 16;
			array2[82] = 17;
			array2[83] = 18;
			array2[84] = 19;
			array2[85] = 20;
			array2[86] = 21;
			array2[87] = 22;
			array2[88] = 23;
			array2[89] = 24;
			array2[90] = 25;
			array2[91] = -1;
			array2[92] = -1;
			array2[93] = -1;
			array2[94] = -1;
			array2[95] = -1;
			array2[96] = -1;
			array2[97] = 26;
			array2[98] = 27;
			array2[99] = 28;
			array2[100] = 29;
			array2[101] = 30;
			array2[102] = 31;
			array2[103] = 32;
			array2[104] = 33;
			array2[105] = 34;
			array2[106] = 35;
			array2[107] = 36;
			array2[108] = 37;
			array2[109] = 38;
			array2[110] = 39;
			array2[111] = 40;
			array2[112] = 41;
			array2[113] = 42;
			array2[114] = 43;
			array2[115] = 44;
			array2[116] = 45;
			array2[117] = 46;
			array2[118] = 47;
			array2[119] = 48;
			array2[120] = 49;
			array2[121] = 50;
			array2[122] = 51;
			if (bool_0)
			{
				array2[43] = -1;
				array2[47] = -1;
				array2[45] = 62;
				array2[95] = 63;
			}
			int num2 = 0;
			bool flag = true;
			IL_02CB:
			while (flag && num2 < byte_0.Length)
			{
				int i = 0;
				while (i < 4)
				{
					if (num2 < byte_0.Length)
					{
						int num3 = (int)byte_0[num2++];
						if (num3 >= array2.Length || array2[num3] < 0)
						{
							if (num3 != 13 && num3 != 10 && num3 != 32 && num3 != 9)
							{
								throw new Egs("Invalid character in base64 data.");
							}
						}
						else
						{
							array[i++] = array2[num3];
						}
					}
					else
					{
						while (i < 4)
						{
							array[i++] = 99;
						}
						flag = false;
						IL_0350:
						if (array[3] != 99)
						{
							ega.Tc((byte)((((int)array[0] << 2) | (array[1] >> 4)) & 255));
							ega.Tc((byte)((((int)array[1] << 4) | (array[2] >> 2)) & 255));
							ega.Tc((byte)((((int)array[2] << 6) | (int)((byte)array[3])) & 255));
							goto IL_02CB;
						}
						if (array[2] != 99)
						{
							ega.Tc((byte)((((int)array[0] << 2) | (array[1] >> 4)) & 255));
							ega.Tc((byte)((((int)array[1] << 4) | (array[2] >> 2)) & 255));
							goto IL_02CB;
						}
						if (array[1] != 99)
						{
							ega.Tc((byte)((((int)array[0] << 2) | (array[1] >> 4)) & 255));
							goto IL_02CB;
						}
						if (array[0] != 99)
						{
							throw new Egs("base64 data is incorrect size.");
						}
						goto IL_02CB;
					}
				}
				goto IL_0350;
			}
			return ega.ri();
		}

		// Token: 0x0601158A RID: 71050 RVA: 0x0069DF5C File Offset: 0x0069C15C
		public static string OB(byte[] byte_0, char char_0)
		{
			string text2;
			if (byte_0 != null && byte_0.Length != 0)
			{
				string text = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
				lcc lcc = new lcc();
				char[] array = new char[4];
				foreach (byte b in byte_0)
				{
					short num = (short)(byte.MaxValue & b);
					int num2 = 0;
					do
					{
						array[num2] = text[(int)(num % 36)];
						num /= 36;
						num2++;
					}
					while (num != 0);
					if (lcc.D > 0)
					{
						lcc.MPI(char_0);
					}
					while (num2-- > 0)
					{
						lcc.MPI(array[num2]);
					}
				}
				text2 = lcc.ToString();
			}
			else
			{
				text2 = "";
			}
			return text2;
		}

		// Token: 0x0601158B RID: 71051 RVA: 0x0069E034 File Offset: 0x0069C234
		public static byte[] OJ(string string_0, char char_0)
		{
			byte[] array2;
			if (string_0 != null && string_0.Length != 0)
			{
				string text = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
				string text2 = "0123456789abcdefghijklmnopqrstuvwxyz";
				lmr<byte> lmr = new lmr<byte>();
				int num = 0;
				int i;
				int num4;
				char c;
				for (;;)
				{
					short num2 = 0;
					int num3 = string_0.IndexOf(char_0, num);
					num3 = ((num3 == -1) ? string_0.Length : num3);
					i = 0;
					num4 = num3 - num;
					while (i < num4)
					{
						c = string_0[num3 - i - 1];
						short num5 = (short)text.IndexOf(c);
						if (num5 < 0)
						{
							num5 = (short)text2.IndexOf(c);
						}
						if (num5 < 0)
						{
							goto IL_00D6;
						}
						num2 += num5 * (short)Math.Pow(36.0, (double)i);
						i++;
					}
					lmr.Add((byte)num2);
					num = num3 + 1;
					if (num >= string_0.Length)
					{
						goto Block_6;
					}
				}
				IL_00D6:
				throw new Egs("Illegal character '" + c + "' in base36 decoding.");
				Block_6:
				byte[] array = new byte[lmr.G()];
				i = 0;
				num4 = lmr.G();
				while (i < num4)
				{
					array[i] = lmr.y(i);
					i++;
				}
				array2 = array;
			}
			else
			{
				array2 = new byte[0];
			}
			return array2;
		}

		// Token: 0x0601158C RID: 71052 RVA: 0x0069E18C File Offset: 0x0069C38C
		public static byte[] OY(byte[] byte_0)
		{
			HashAlgorithm hashAlgorithm = new MD5CryptoServiceProvider();
			return hashAlgorithm.ComputeHash(byte_0);
		}

		// Token: 0x0601158D RID: 71053 RVA: 0x0069E1A8 File Offset: 0x0069C3A8
		public static byte[] OV(string string_0, byte[] byte_0)
		{
			return Eyf.Op(string_0).ComputeHash(byte_0);
		}

		// Token: 0x0601158E RID: 71054 RVA: 0x0069E1C4 File Offset: 0x0069C3C4
		public static HashAlgorithm Op(string string_0)
		{
			HashAlgorithm hashAlgorithm;
			if (!Eyf.ht("MD5", string_0))
			{
				if (!Eyf.ht("SHA-1", string_0))
				{
					if (!Eyf.ht("SHA-256", string_0))
					{
						if (!Eyf.ht("SHA-384", string_0))
						{
							if (!Eyf.ht("SHA-512", string_0))
							{
								throw new Egs("The algorithm [" + string_0 + "] is not supported.");
							}
							hashAlgorithm = new SHA512CryptoServiceProvider();
						}
						else
						{
							hashAlgorithm = new SHA384CryptoServiceProvider();
						}
					}
					else
					{
						hashAlgorithm = new SHA256CryptoServiceProvider();
					}
				}
				else
				{
					hashAlgorithm = new SHA1CryptoServiceProvider();
				}
			}
			else
			{
				hashAlgorithm = new MD5CryptoServiceProvider();
			}
			return hashAlgorithm;
		}

		// Token: 0x0601158F RID: 71055 RVA: 0x0069E260 File Offset: 0x0069C460
		public static string OC(string string_0, string string_1, string string_2)
		{
			string text;
			if (!Eyf.lx(string_0) && !Eyf.lx(string_1))
			{
				text = string_0.Replace(string_1, string_2);
			}
			else
			{
				text = string_0;
			}
			return text;
		}

		// Token: 0x06011590 RID: 71056 RVA: 0x0069E294 File Offset: 0x0069C494
		public static string OU(string string_0)
		{
			string text;
			if (!Eyf.lx(string_0))
			{
				text = string_0.TrimEnd(new char[0]);
			}
			else
			{
				text = string_0;
			}
			return text;
		}

		// Token: 0x06011591 RID: 71057 RVA: 0x0069E2C0 File Offset: 0x0069C4C0
		public static string Oh(string string_0)
		{
			string text;
			if (!Eyf.lx(string_0))
			{
				text = string_0.TrimStart(new char[0]);
			}
			else
			{
				text = string_0;
			}
			return text;
		}

		// Token: 0x06011592 RID: 71058 RVA: 0x0069E2EC File Offset: 0x0069C4EC
		public static string OD(string string_0, string string_1)
		{
			char[] array = string_0.ToCharArray();
			int num = array.Length;
			int num2 = 0;
			while (num2 < num && string_1.IndexOf(array[num2]) > -1)
			{
				num2++;
			}
			while (num2 < num && string_1.IndexOf(array[num - 1]) > -1)
			{
				num--;
			}
			return (num2 > 0 || num < array.Length) ? lcP.IZ(string_0, num2, num) : string_0;
		}

		// Token: 0x06011593 RID: 71059 RVA: 0x0069E35C File Offset: 0x0069C55C
		public static string Ol(string string_0)
		{
			string text;
			if (!Eyf.lx(string_0))
			{
				text = Regex.Escape(string_0);
			}
			else
			{
				text = string_0;
			}
			return text;
		}

		// Token: 0x06011594 RID: 71060 RVA: 0x0069E380 File Offset: 0x0069C580
		public static lyv<string> Om(string[] string_0)
		{
			lyv<string> lyv = new lyv<string>();
			foreach (string text in string_0)
			{
				lyv.Add(text);
			}
			return lyv;
		}

		// Token: 0x06011595 RID: 71061 RVA: 0x0069E3BC File Offset: 0x0069C5BC
		public static lmr<string> Ox(string[] string_0)
		{
			lmr<string> lmr = new lmr<string>();
			foreach (string text in string_0)
			{
				lmr.Add(text);
			}
			return lmr;
		}

		// Token: 0x06011596 RID: 71062 RVA: 0x0069E3F4 File Offset: 0x0069C5F4
		public static string[] On(lyv<string> lyv_0)
		{
			string[] array;
			if (lyv_0 != null)
			{
				if (lyv_0.W() > 0)
				{
					array = (string[])lyv_0.ToArray(typeof(string));
				}
				else
				{
					array = new string[0];
				}
			}
			else
			{
				array = null;
			}
			return array;
		}

		// Token: 0x06011597 RID: 71063 RVA: 0x0069E43C File Offset: 0x0069C63C
		public static string[] Ow(IList<string> ilist_0)
		{
			string[] array2;
			if (ilist_0 != null)
			{
				if (ilist_0.Count > 0)
				{
					string[] array = new string[ilist_0.Count];
					ilist_0.CopyTo(array, 0);
					array2 = array;
				}
				else
				{
					array2 = new string[0];
				}
			}
			else
			{
				array2 = null;
			}
			return array2;
		}

		// Token: 0x06011598 RID: 71064 RVA: 0x0069E484 File Offset: 0x0069C684
		public static lmr<X> OO<X>(lmr<X> lmr_0, int int_0, int int_1)
		{
			return new lmr<X>(lmr_0.xG(int_0, int_1));
		}

		// Token: 0x06011599 RID: 71065 RVA: 0x0069E4A0 File Offset: 0x0069C6A0
		public static string[] OI(string[] string_0)
		{
			return Eyf.Oe(string_0, false);
		}

		// Token: 0x0601159A RID: 71066 RVA: 0x0069E4B8 File Offset: 0x0069C6B8
		public static string[] Oe(string[] string_0, bool bool_0)
		{
			string[] array;
			if (string_0 != null && string_0.Length > 0)
			{
				if (!bool_0)
				{
					Array.Sort<string>(string_0);
				}
				else
				{
					Array.Sort<string>(string_0, StringComparer.Ordinal);
				}
				array = string_0;
			}
			else
			{
				array = string_0;
			}
			return array;
		}

		// Token: 0x0601159B RID: 71067 RVA: 0x0069E4F8 File Offset: 0x0069C6F8
		public static string[] Ot(string[] string_0)
		{
			string[] array;
			if (string_0 != null && string_0.Length > 0)
			{
				Array.Sort<string>(string_0, StringComparer.Ordinal);
				array = string_0;
			}
			else
			{
				array = string_0;
			}
			return array;
		}

		// Token: 0x0601159C RID: 71068 RVA: 0x0069E528 File Offset: 0x0069C728
		public static object[] Og(object[] object_0, IComparer icomparer_0)
		{
			object[] array;
			if (object_0 != null && object_0.Length > 0)
			{
				Array.Sort(object_0, icomparer_0);
				array = object_0;
			}
			else
			{
				array = object_0;
			}
			return array;
		}

		// Token: 0x0601159D RID: 71069 RVA: 0x0069E554 File Offset: 0x0069C754
		public static void OA(lml lml_0, IComparer icomparer_0)
		{
			if (lml_0 != null && lml_0.x() != 0)
			{
				lml_0.Sort(icomparer_0);
			}
		}

		// Token: 0x0601159E RID: 71070 RVA: 0x0069E580 File Offset: 0x0069C780
		public static void Or<b>(lmr<b> lmr_0, IComparer<b> icomparer_0)
		{
			if (lmr_0 != null && lmr_0.G() != 0)
			{
				lmr_0.xb(icomparer_0);
			}
		}

		// Token: 0x0601159F RID: 71071 RVA: 0x0069E5AC File Offset: 0x0069C7AC
		public static string OF(string string_0)
		{
			string text;
			if (!Eyf.lx(string_0))
			{
				lcc lcc = new lcc();
				foreach (char c in string_0)
				{
					if (c != '{')
					{
						if (c != '}')
						{
							lcc.MPI(c);
						}
						else
						{
							lcc.MPI("}}");
						}
					}
					else
					{
						lcc.MPI("{{");
					}
				}
				text = lcc.ToString();
			}
			else
			{
				text = "";
			}
			return text;
		}

		// Token: 0x060115A0 RID: 71072 RVA: 0x0069E630 File Offset: 0x0069C830
		public static string OK(string string_0, int int_0, bool bool_0)
		{
			if (bool_0 && string_0.Length > int_0)
			{
				string_0 = lcP.IZ(string_0, 0, int_0);
			}
			string text = "{0," + int_0 + "}";
			return string.Format(text, string_0);
		}

		// Token: 0x060115A1 RID: 71073 RVA: 0x0069E67C File Offset: 0x0069C87C
		public static string Oq(string string_0, string[] string_1)
		{
			return Eyf.OZ(string_0, string_1, true);
		}

		// Token: 0x060115A2 RID: 71074 RVA: 0x0069E694 File Offset: 0x0069C894
		public static string OS(string string_0, string string_1)
		{
			return Eyf.OZ(string_0, new string[] { string_1 }, true);
		}

		// Token: 0x060115A3 RID: 71075 RVA: 0x0069E6B8 File Offset: 0x0069C8B8
		public static string OZ(string string_0, string[] string_1, bool bool_0)
		{
			string text;
			if (!Eyf.lx(string_0))
			{
				if (string_1 != null && string_1.Length > 0)
				{
					text = string.Format(string_0, string_1);
				}
				else
				{
					text = string_0;
				}
			}
			else
			{
				text = "";
			}
			return text;
		}

		// Token: 0x060115A4 RID: 71076 RVA: 0x0069E6F4 File Offset: 0x0069C8F4
		public static string IB(string string_0, bool bool_0, params object[] object_0)
		{
			string text;
			if (!Eyf.lx(string_0))
			{
				if (object_0 != null && object_0.Length > 0)
				{
					text = string.Format(string_0, object_0);
				}
				else
				{
					text = string_0;
				}
			}
			else
			{
				text = "";
			}
			return text;
		}

		// Token: 0x060115A5 RID: 71077 RVA: 0x0069E730 File Offset: 0x0069C930
		public static byte[] IV(string string_0)
		{
			return Eyf.Ip(string_0, "utf-8");
		}

		// Token: 0x060115A6 RID: 71078 RVA: 0x0069E74C File Offset: 0x0069C94C
		public static byte[] Ip(string string_0, string string_1)
		{
			if (string_0 != null)
			{
				try
				{
					return Encoding.GetEncoding(string_1).GetBytes(string_0);
				}
				catch (Exception ex)
				{
					throw new Egs(Eyf.Oq("'{0}' is not a supported encoding name. Error: {1}", new string[]
					{
						string_1,
						Eyf.eD(ex)
					}));
				}
			}
			return null;
		}

		// Token: 0x060115A7 RID: 71079 RVA: 0x0069E7AC File Offset: 0x0069C9AC
		public static byte[] ID(string string_0)
		{
			byte[] array;
			if (Environment.OSVersion.Platform != PlatformID.WinCE)
			{
				array = Eyf.Ip(string_0, "ISO-8859-1");
			}
			else
			{
				array = Eyf.Ip(string_0, "US-ASCII");
			}
			return array;
		}

		// Token: 0x060115A8 RID: 71080 RVA: 0x0069E7E8 File Offset: 0x0069C9E8
		public static string Im(byte[] byte_0)
		{
			string text;
			if (byte_0 != null)
			{
				text = Eyf.Ix(byte_0, 0, byte_0.Length);
			}
			else
			{
				text = null;
			}
			return text;
		}

		// Token: 0x060115A9 RID: 71081 RVA: 0x0069E810 File Offset: 0x0069CA10
		public static string Ix(byte[] byte_0, int int_0, int int_1)
		{
			string text = "";
			try
			{
				text = Eyf.IO(byte_0, int_0, int_1, "utf-8");
			}
			catch (Egs)
			{
			}
			return text;
		}

		// Token: 0x060115AA RID: 71082 RVA: 0x0069E84C File Offset: 0x0069CA4C
		public static string In(byte[] byte_0, string string_0)
		{
			string text;
			if (byte_0 != null)
			{
				text = Eyf.IO(byte_0, 0, byte_0.Length, string_0);
			}
			else
			{
				text = null;
			}
			return text;
		}

		// Token: 0x060115AB RID: 71083 RVA: 0x0069E874 File Offset: 0x0069CA74
		public static string IO(byte[] byte_0, int int_0, int int_1, string string_0)
		{
			if (byte_0 != null)
			{
				try
				{
					return Encoding.GetEncoding(string_0).GetString(byte_0, int_0, int_1);
				}
				catch (Exception ex)
				{
					throw new Egs(Eyf.Oq("'{0}' is not a supported encoding name. Error: {1}", new string[]
					{
						string_0,
						Eyf.eD(ex)
					}));
				}
			}
			return null;
		}

		// Token: 0x060115AC RID: 71084 RVA: 0x0069E8D4 File Offset: 0x0069CAD4
		public static string It(string string_0)
		{
			string text = string_0.ToLower();
			string text2 = string_0;
			string[] array = new string[] { "rtk", "oemkey" };
			foreach (string text3 in array)
			{
				int num = text.IndexOf(text3);
				if (num != -1)
				{
					string text4 = lcP.IG(text, num);
					int num2 = text4.IndexOf(";");
					if (num2 != -1)
					{
						text2 = lcP.IZ(text2, 0, num) + lcP.IG(text2, num + num2 + 1);
					}
					else
					{
						text2 = lcP.IZ(text2, 0, num);
					}
				}
			}
			return text2;
		}

		// Token: 0x060115AD RID: 71085 RVA: 0x0069E988 File Offset: 0x0069CB88
		private static string IA(string string_0, bool bool_0, string[] string_1)
		{
			lcc lcc = new lcc();
			string[] array = Eyf.xJ(string_0, ";");
			foreach (string text in array)
			{
				int num = text.IndexOf('=');
				if (num > 0)
				{
					string text2 = lcP.IZ(text, 0, num);
					if (!text2.ToLower().Equals("rtk") && !text2.ToLower().Equals("oemkey") && text.Length > num + 1)
					{
						if (lcc.D > 0)
						{
							lcc.MPI(";");
						}
						lcc.MPI(text2).MPI("=");
						if (!bool_0 || !text2.ToLower().Contains("cacheconnection"))
						{
							lcc.MPI(Eyf.eV(text2, lcP.IG(text, num + 1), string_1));
						}
						else
						{
							lcc.MPI(Eyf.It(lcP.IG(text, num + 1)));
						}
					}
				}
			}
			return lcc.ToString();
		}

		// Token: 0x060115AE RID: 71086 RVA: 0x0069EAA8 File Offset: 0x0069CCA8
		public static string Ir(string string_0, bool bool_0, string[] string_1)
		{
			return Eyf.IA(string_0, bool_0, string_1);
		}

		// Token: 0x060115AF RID: 71087 RVA: 0x0069EAC0 File Offset: 0x0069CCC0
		public static string IK(string string_0, bool bool_0)
		{
			return Eyf.IA(string_0, bool_0, null);
		}

		// Token: 0x060115B0 RID: 71088 RVA: 0x0069EAD8 File Offset: 0x0069CCD8
		public static string IZ(string string_0)
		{
			return Eyf.IA(string_0, false, null);
		}

		// Token: 0x060115B1 RID: 71089 RVA: 0x0069EAF0 File Offset: 0x0069CCF0
		public static string eB(string string_0, string[] string_1)
		{
			return Eyf.IA(string_0, false, string_1);
		}

		// Token: 0x060115B2 RID: 71090 RVA: 0x0069EB08 File Offset: 0x0069CD08
		public static string eV(string string_0, string string_1, string[] string_2)
		{
			string text = string_0.ToLower();
			string text2;
			if (!text.Contains("rtk") && !text.Contains("oemkey"))
			{
				bool flag = false;
				int num = 0;
				while (string_2 != null && num < string_2.Length)
				{
					if (Eyf.ht(text, string_2[num]))
					{
						flag = true;
						break;
					}
					num++;
				}
				if (!flag && !text.Contains("pwd") && !text.Contains("password") && !text.Contains("accesstoken") && !text.Contains("companyid") && !text.Contains("secret") && !text.Contains("sslclientcert"))
				{
					text2 = string_1;
				}
				else if (Eyf.lx(string_1))
				{
					text2 = string_1;
				}
				else if (string_1[0] != '"')
				{
					text2 = "*****";
				}
				else
				{
					text2 = "\"*****\"";
				}
			}
			else
			{
				text2 = ((!Eyf.lx(string_1)) ? "*****" : "");
			}
			return text2;
		}

		// Token: 0x060115B3 RID: 71091 RVA: 0x0069EC0C File Offset: 0x0069CE0C
		public static string ep(string string_0)
		{
			Regex regex = new Regex("(<\\w*:?password>)(.*)(</\\w*:?password>)", RegexOptions.IgnoreCase);
			return regex.Replace(string_0, "$1******$3");
		}

		// Token: 0x060115B4 RID: 71092 RVA: 0x00241E88 File Offset: 0x00240088
		public static string eD(Exception exception_0)
		{
			return exception_0.Message;
		}

		// Token: 0x060115B5 RID: 71093 RVA: 0x00552FE4 File Offset: 0x005511E4
		public static string em(Exception exception_0)
		{
			return exception_0.StackTrace;
		}

		// Token: 0x060115B6 RID: 71094 RVA: 0x000440D5 File Offset: 0x000422D5
		public static void ex(Exception exception_0)
		{
		}

		// Token: 0x060115B7 RID: 71095 RVA: 0x00075BAF File Offset: 0x00073DAF
		public static void en(Exception exception_0)
		{
			Eyf.ex(exception_0);
			throw exception_0;
		}

		// Token: 0x060115B8 RID: 71096 RVA: 0x0069EC34 File Offset: 0x0069CE34
		public static void eO(RSBContext rsbcontext_0)
		{
			if (rsbcontext_0 != null)
			{
				try
				{
					Eyf.et(rsbcontext_0.MapPath("~"));
				}
				catch (Exception)
				{
				}
				try
				{
					Eyf.et(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData));
				}
				catch
				{
				}
			}
		}

		// Token: 0x060115B9 RID: 71097 RVA: 0x0069EC8C File Offset: 0x0069CE8C
		public static void et(string string_0)
		{
			if (!Eyf.lx(string_0))
			{
				lock (Eyf.Gc)
				{
					string_0 = Eyf.Dx(string_0);
					if (!Eyf.Gc.Contains(string_0))
					{
						int num = 0;
						while (num < Eyf.Gc.G() && Eyf.Gc.y(num).Length > string_0.Length)
						{
							num++;
						}
						Eyf.Gc.u(num, string_0);
						try
						{
							string text = Eyf.Dx(new lya(string_0).bO());
							if (!Eyf.hr(string_0, text))
							{
								num = 0;
								while (num < Eyf.Gc.G() && Eyf.Gc.y(num).Length > text.Length)
								{
									num++;
								}
								Eyf.Gc.u(num, text);
							}
						}
						catch (Exception)
						{
						}
					}
				}
			}
		}

		// Token: 0x060115BA RID: 71098 RVA: 0x0069ED9C File Offset: 0x0069CF9C
		public static string eA(string string_0)
		{
			string text2;
			if (!Eyf.lx(string_0) && Eyf.Gc.G() > 0)
			{
				using (lmg<string> lmg = Eyf.Gc.O())
				{
					while (lmg.MoveNext())
					{
						string text = lmg.Current;
						if (string_0.Length >= text.Length)
						{
							int[] array = new int[2];
							array[0] = -1;
							int[] array2;
							while ((double)(array2 = Eyf.DC(string_0, text, true, new Eyf.Xr()))[1] >= (double)text.Length * 0.6)
							{
								string_0 = lcP.IZ(string_0, 0, array2[0]) + "***" + lcP.IG(string_0, array2[0] + array2[1]);
							}
						}
					}
				}
				text2 = string_0;
			}
			else
			{
				text2 = string_0;
			}
			return text2;
		}

		// Token: 0x060115BB RID: 71099 RVA: 0x0069EE90 File Offset: 0x0069D090
		public static string er(Exception exception_0)
		{
			return Eyf.eA(Eyf.eD(exception_0));
		}

		// Token: 0x060115BC RID: 71100 RVA: 0x0006414A File Offset: 0x0006234A
		public static void eK(object object_0)
		{
			Monitor.PulseAll(object_0);
		}

		// Token: 0x060115BD RID: 71101 RVA: 0x00064152 File Offset: 0x00062352
		public static void eZ(object object_0, int int_0)
		{
			Monitor.Wait(object_0, int_0);
		}

		// Token: 0x060115BE RID: 71102 RVA: 0x00075BB8 File Offset: 0x00073DB8
		public static void tB(object object_0, long long_0)
		{
			Monitor.Wait(object_0, new TimeSpan(long_0 * 10000L));
		}

		// Token: 0x060115BF RID: 71103 RVA: 0x0006415C File Offset: 0x0006235C
		public static void tJ(object object_0)
		{
			Monitor.Wait(object_0);
		}

		// Token: 0x060115C0 RID: 71104 RVA: 0x0069EEAC File Offset: 0x0069D0AC
		public static RSBHttpService tY(RSBContext rsbcontext_0)
		{
			return (RSBHttpService)rsbcontext_0.GetService("http.service");
		}

		// Token: 0x060115C1 RID: 71105 RVA: 0x0069EECC File Offset: 0x0069D0CC
		public static RSBFileService tV(RSBContext rsbcontext_0)
		{
			RSBFileService rsbfileService = (RSBFileService)rsbcontext_0.GetService("file.service");
			if (rsbfileService == null)
			{
				throw new Egs("The Service 'file.service' can not be found.");
			}
			return rsbfileService;
		}

		// Token: 0x060115C2 RID: 71106 RVA: 0x0069EF04 File Offset: 0x0069D104
		public static bool tp(DateTime dateTime_0, DateTime dateTime_1)
		{
			return dateTime_0 > dateTime_1;
		}

		// Token: 0x060115C3 RID: 71107 RVA: 0x0069EF18 File Offset: 0x0069D118
		public static bool tC(DateTime dateTime_0, DateTime dateTime_1)
		{
			return dateTime_0 < dateTime_1;
		}

		// Token: 0x060115C4 RID: 71108 RVA: 0x0069EF2C File Offset: 0x0069D12C
		public static DateTime tU()
		{
			return DateTime.Today;
		}

		// Token: 0x060115C5 RID: 71109 RVA: 0x005ACB4C File Offset: 0x005AAD4C
		public static DateTime th()
		{
			return DateTime.Now;
		}

		// Token: 0x060115C6 RID: 71110 RVA: 0x0069EF40 File Offset: 0x0069D140
		public static DateTime tD()
		{
			return DateTime.UtcNow;
		}

		// Token: 0x060115C7 RID: 71111 RVA: 0x0069EF54 File Offset: 0x0069D154
		public static DateTime tl(string string_0)
		{
			return Eyf.tm(string_0, false);
		}

		// Token: 0x060115C8 RID: 71112 RVA: 0x0069EF6C File Offset: 0x0069D16C
		public static DateTime tm(string string_0, bool bool_0)
		{
			return Eyf.tx(string_0, bool_0, null, CultureInfo.InvariantCulture);
		}

		// Token: 0x060115C9 RID: 71113 RVA: 0x0069EF88 File Offset: 0x0069D188
		public static DateTime tx(string string_0, bool bool_0, string string_1, IFormatProvider iformatProvider_0)
		{
			if (!Eyf.lx(string_1))
			{
				goto IL_005B;
			}
			IL_0008:
			DateTime dateTime;
			DateTime dateTime2;
			if (!DateTime.TryParse(string_0, iformatProvider_0, DateTimeStyles.None, out dateTime))
			{
				try
				{
					if (Eyf.tn(string_0))
					{
						long num = Eyf.Cq(string_0, -1L);
						if (num > 0L)
						{
							return DateTime.FromFileTimeUtc(num).ToLocalTime();
						}
					}
					goto IL_0080;
				}
				catch (Exception)
				{
					goto IL_0080;
				}
				goto IL_005B;
				try
				{
					IL_0080:
					return Eya.O(string_0, iformatProvider_0);
				}
				catch (Exception)
				{
				}
				try
				{
					EgJ egJ = EgJ.ic(string_0, string_1, bool_0);
					dateTime2 = egJ.WR();
				}
				catch (RSBException)
				{
					throw;
				}
				return dateTime2;
			}
			return dateTime;
			IL_005B:
			if (!DateTime.TryParseExact(string_0, Eyf.xY(string_1, true, ";"), iformatProvider_0, DateTimeStyles.None, out dateTime))
			{
				goto IL_0008;
			}
			dateTime2 = dateTime;
			return dateTime2;
		}

		// Token: 0x060115CA RID: 71114 RVA: 0x0069F064 File Offset: 0x0069D264
		public static bool tn(string string_0)
		{
			bool flag;
			if (!Eyf.lx(string_0))
			{
				for (int i = 0; i < string_0.Length; i++)
				{
					if (!char.IsDigit(string_0[i]))
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

		// Token: 0x060115CB RID: 71115 RVA: 0x0069F0AC File Offset: 0x0069D2AC
		public static bool tw(string string_0, bool bool_0)
		{
			bool flag;
			if (!Eyf.lx(string_0))
			{
				if (bool_0)
				{
					flag = Eyf.tO(string_0);
				}
				else
				{
					flag = Eyf.tn(string_0);
				}
			}
			else
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x060115CC RID: 71116 RVA: 0x0069F0DC File Offset: 0x0069D2DC
		public static bool tO(string string_0)
		{
			bool flag;
			if (!Eyf.lx(string_0))
			{
				int num = 0;
				foreach (char c in string_0)
				{
					switch (num)
					{
					case 0:
						if (c != '+' && c != '-')
						{
							if (!char.IsDigit(c))
							{
								if (c != '.')
								{
									return false;
								}
								num = 3;
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
						break;
					case 1:
						if (!char.IsDigit(c))
						{
							if (c != '.')
							{
								return false;
							}
							num = 3;
						}
						else
						{
							num = 2;
						}
						break;
					case 2:
						if (!char.IsDigit(c))
						{
							if (c != '.')
							{
								if (c != 'E' && c != 'e')
								{
									return false;
								}
								num = 5;
							}
							else
							{
								num = 3;
							}
						}
						break;
					case 3:
						if (!char.IsDigit(c))
						{
							return false;
						}
						num = 4;
						break;
					case 4:
						if (!char.IsDigit(c))
						{
							if (c != 'E' && c != 'e')
							{
								return false;
							}
							num = 5;
						}
						break;
					case 5:
						if (c != '+' && c != '-')
						{
							if (!char.IsDigit(c))
							{
								return false;
							}
							num = 7;
						}
						else
						{
							num = 6;
						}
						break;
					case 6:
						if (!char.IsDigit(c))
						{
							return false;
						}
						num = 7;
						break;
					case 7:
						if (!char.IsDigit(c))
						{
							return false;
						}
						break;
					}
				}
				flag = num == 2 || num == 4 || num == 7;
			}
			else
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x060115CD RID: 71117 RVA: 0x0069F298 File Offset: 0x0069D498
		public static DateTime tI(string string_0, string string_1)
		{
			return Eyf.te(string_0, string_1, false);
		}

		// Token: 0x060115CE RID: 71118 RVA: 0x0069F2B0 File Offset: 0x0069D4B0
		public static DateTime te(string string_0, string string_1, bool bool_0)
		{
			return Eyf.tt(string_0, string_1, bool_0, CultureInfo.InvariantCulture);
		}

		// Token: 0x060115CF RID: 71119 RVA: 0x0069F2CC File Offset: 0x0069D4CC
		public static DateTime tt(string string_0, string string_1, bool bool_0, IFormatProvider iformatProvider_0)
		{
			DateTime dateTime;
			try
			{
				if (!bool_0)
				{
					dateTime = DateTime.ParseExact(string_0, string_1, iformatProvider_0);
				}
				else
				{
					dateTime = DateTime.ParseExact(string_0, string_1, iformatProvider_0, DateTimeStyles.AssumeUniversal);
				}
			}
			catch (Exception)
			{
				try
				{
					EgJ egJ = EgJ.ic(string_0, string_1, bool_0);
					dateTime = egJ.WR();
				}
				catch (RSBException)
				{
					throw;
				}
			}
			return dateTime;
		}

		// Token: 0x060115D0 RID: 71120 RVA: 0x0069F32C File Offset: 0x0069D52C
		public static string tg(DateTime dateTime_0)
		{
			return Eyf.gn(dateTime_0, "");
		}

		// Token: 0x060115D1 RID: 71121 RVA: 0x0069F348 File Offset: 0x0069D548
		public static string tA(DateTime dateTime_0, string string_0)
		{
			return Eyf.gn(dateTime_0, string_0);
		}

		// Token: 0x060115D2 RID: 71122 RVA: 0x0069F360 File Offset: 0x0069D560
		public static string tr(lmr<string> lmr_0)
		{
			string text;
			if (lmr_0 != null && lmr_0.G() > 0)
			{
				text = Eyf.xw(",", Eyf.Ow(lmr_0), true);
			}
			else
			{
				text = "";
			}
			return text;
		}

		// Token: 0x060115D3 RID: 71123 RVA: 0x0069F39C File Offset: 0x0069D59C
		public static string tF(DateTime dateTime_0)
		{
			return dateTime_0.ToUniversalTime().ToString("r");
		}

		// Token: 0x060115D4 RID: 71124 RVA: 0x0069F3C0 File Offset: 0x0069D5C0
		public static string tK(DateTime dateTime_0)
		{
			return dateTime_0.ToShortDateString();
		}

		// Token: 0x060115D5 RID: 71125 RVA: 0x0069F3D8 File Offset: 0x0069D5D8
		public static string tq(DateTime dateTime_0)
		{
			return dateTime_0.ToLongDateString();
		}

		// Token: 0x060115D6 RID: 71126 RVA: 0x0069F3F0 File Offset: 0x0069D5F0
		public static int tS(DateTime dateTime_0, DateTime dateTime_1)
		{
			return (int)Eyf.tZ(dateTime_0, dateTime_1, "day");
		}

		// Token: 0x060115D7 RID: 71127 RVA: 0x0069F40C File Offset: 0x0069D60C
		public static long tZ(DateTime dateTime_0, DateTime dateTime_1, string string_0)
		{
			string_0 = string_0.ToLower();
			TimeSpan timeSpan = dateTime_0.Subtract(dateTime_1);
			long num;
			if (!string_0.Equals("day"))
			{
				if (!string_0.Equals("hour"))
				{
					if (!string_0.Equals("minute"))
					{
						if (!string_0.Equals("second"))
						{
							if (!string_0.Equals("millisecond"))
							{
								throw new Egs("The type specified for the between value is not supported.");
							}
							num = (long)timeSpan.TotalMilliseconds;
						}
						else
						{
							num = (long)timeSpan.TotalSeconds;
						}
					}
					else
					{
						num = (long)timeSpan.TotalMinutes;
					}
				}
				else
				{
					num = (long)timeSpan.TotalHours;
				}
			}
			else
			{
				num = (long)timeSpan.TotalDays;
			}
			return num;
		}

		// Token: 0x060115D8 RID: 71128 RVA: 0x0069F4C0 File Offset: 0x0069D6C0
		public static DateTime gB(DateTime dateTime_0, int int_0)
		{
			return dateTime_0.AddDays((double)int_0);
		}

		// Token: 0x060115D9 RID: 71129 RVA: 0x0069F4D8 File Offset: 0x0069D6D8
		public static DateTime gV(DateTime dateTime_0, int int_0)
		{
			return dateTime_0.AddHours((double)int_0);
		}

		// Token: 0x060115DA RID: 71130 RVA: 0x0069F4F0 File Offset: 0x0069D6F0
		public static DateTime gp(DateTime dateTime_0, int int_0)
		{
			return dateTime_0.AddMinutes((double)int_0);
		}

		// Token: 0x060115DB RID: 71131 RVA: 0x0069F508 File Offset: 0x0069D708
		public static DateTime gD(DateTime dateTime_0, int int_0)
		{
			return dateTime_0.AddSeconds((double)int_0);
		}

		// Token: 0x060115DC RID: 71132 RVA: 0x0069F520 File Offset: 0x0069D720
		public static int gm(DateTime dateTime_0, DateTime dateTime_1)
		{
			return DateTime.Compare(dateTime_0, dateTime_1);
		}

		// Token: 0x060115DD RID: 71133 RVA: 0x0069F538 File Offset: 0x0069D738
		public static bool gx(int int_0)
		{
			if (int_0 < 1 || int_0 > 9999)
			{
				throw new Egs("The year is out of range. (The value must be 0 < year < 9999.)");
			}
			return DateTime.IsLeapYear(int_0);
		}

		// Token: 0x060115DE RID: 71134 RVA: 0x0069F56C File Offset: 0x0069D76C
		public static string gn(DateTime dateTime_0, string string_0)
		{
			string text;
			try
			{
				if (!string.IsNullOrEmpty(string_0))
				{
					if (!string_0.ToLower().Equals("file"))
					{
						if (!string_0.Equals("r") && !string_0.Equals("R"))
						{
							text = dateTime_0.ToString(string_0);
						}
						else
						{
							text = Eyf.tF(dateTime_0);
						}
					}
					else
					{
						text = Eyf.DI(dateTime_0.ToUniversalTime().ToFileTimeUtc());
					}
				}
				else
				{
					text = dateTime_0.ToString();
				}
			}
			catch (Exception)
			{
				EgJ egJ = new EgJ(dateTime_0);
				text = egJ.cK(string_0);
			}
			return text;
		}

		// Token: 0x060115DF RID: 71135 RVA: 0x0069F618 File Offset: 0x0069D818
		public static string gO(string string_0, string string_1)
		{
			return Eyf.gA(string_0, "", string_1);
		}

		// Token: 0x060115E0 RID: 71136 RVA: 0x0069F634 File Offset: 0x0069D834
		public static string gt(string string_0, string string_1, string string_2, bool bool_0)
		{
			if (!Eyf.lx(string_0))
			{
				try
				{
					return Eyf.gn(Eyf.UD(string_0, Eyf.th(), string_1, bool_0), string_2);
				}
				catch (Exception)
				{
					goto IL_0028;
				}
				goto IL_0024;
				IL_0028:
				return string_0;
			}
			IL_0024:
			return string_0;
		}

		// Token: 0x060115E1 RID: 71137 RVA: 0x0069F67C File Offset: 0x0069D87C
		public static string gA(string string_0, string string_1, string string_2)
		{
			return Eyf.gt(string_0, string_1, string_2, false);
		}

		// Token: 0x060115E2 RID: 71138 RVA: 0x0069F694 File Offset: 0x0069D894
		public static long gr(string string_0)
		{
			long num7;
			if (!Eyf.lx(string_0))
			{
				string[] array = lcP.sZ(string_0, ":");
				if (array.Length != 3)
				{
					throw new Egs("Invalid time span string.");
				}
				int num = 1;
				if (array[0].StartsWith("-"))
				{
					num = -1;
					array[0] = array[0].Substring(1);
				}
				if (array[0].StartsWith("+"))
				{
					array[0] = array[0].Substring(1);
				}
				int num2 = 0;
				int num3;
				if (array[0].IndexOf(".") < 0)
				{
					num3 = Eyf.CF(array[0], 0);
				}
				else
				{
					num2 = Eyf.CF(array[0].Substring(0, array[0].IndexOf(".")), 0);
					num3 = Eyf.CF(array[0].Substring(array[0].IndexOf(".") + 1), 0);
				}
				int num4 = Eyf.CF(array[1], 0);
				int num5 = 0;
				int num6;
				if (array[2].IndexOf(".") < 0)
				{
					num6 = Eyf.CF(array[2], 0);
				}
				else
				{
					num6 = Eyf.CF(array[2].Substring(0, array[2].IndexOf(".")), 0);
					num5 = Eyf.CF(array[2].Substring(array[2].IndexOf(".") + 1), 0) / 10000;
				}
				num7 = (((((long)num2 * 24L + (long)num3) * 60L + (long)num4) * 60L + (long)num6) * 1000L + (long)num5) * (long)num;
			}
			else
			{
				num7 = 0L;
			}
			return num7;
		}

		// Token: 0x060115E3 RID: 71139 RVA: 0x0069F854 File Offset: 0x0069DA54
		public static string gK(string string_0)
		{
			return Eyf.gZ(string_0, ",", true);
		}

		// Token: 0x060115E4 RID: 71140 RVA: 0x0069F870 File Offset: 0x0069DA70
		public static string gZ(string string_0, string string_1, bool bool_0)
		{
			string text = "\"";
			string text2;
			if (!Eyf.lx(string_0))
			{
				string_0 = string_0.Replace(text, text + text);
				if (!bool_0 && string_0.IndexOf(text) == -1 && string_0.IndexOf(string_1) == -1 && string_0.IndexOf(Eyf.u) == -1)
				{
					text2 = string_0;
				}
				else
				{
					text2 = text + string_0 + text;
				}
			}
			else
			{
				text2 = "";
			}
			return text2;
		}

		// Token: 0x060115E5 RID: 71141 RVA: 0x0069F8E0 File Offset: 0x0069DAE0
		public static string AB(lyN lyN_0, string string_0, bool bool_0)
		{
			return Eyf.AJ(lyN_0, string_0, Eyf.u, bool_0);
		}

		// Token: 0x060115E6 RID: 71142 RVA: 0x0069F8FC File Offset: 0x0069DAFC
		public static string AJ(lyN lyN_0, string string_0, string string_1, bool bool_0)
		{
			string text = "\"";
			string text2 = "\"\"";
			lcc lcc = new lcc();
			for (int i = 0; i < lyN_0.W(); i++)
			{
				lyN lyN = (lyN)lyN_0.K(i);
				bool flag = true;
				for (int j = 0; j < lyN.W(); j++)
				{
					object obj = lyN.K(j);
					if (!flag)
					{
						lcc.MPI(string_0);
					}
					flag = false;
					string text3 = "";
					if (obj != null)
					{
						text3 = obj.ToString();
						text3 = text3.Replace(text, text2);
					}
					if (!bool_0 && text3.IndexOf(text) == -1 && text3.IndexOf(string_0) == -1 && text3.IndexOf(string_1) == -1)
					{
						lcc.MPI(text3);
					}
					else
					{
						lcc.MPI(text + text3 + text);
					}
				}
				lcc.MPI(string_1);
			}
			return lcc.ToString();
		}

		// Token: 0x060115E7 RID: 71143 RVA: 0x0069F9FC File Offset: 0x0069DBFC
		public static string AY(string string_0)
		{
			return Eyf.gZ(string_0, "\t", true);
		}

		// Token: 0x060115E8 RID: 71144 RVA: 0x0069FA18 File Offset: 0x0069DC18
		public static string AV(string string_0)
		{
			string text;
			if (!Eyf.lx(string_0))
			{
				lcc lcc = new lcc();
				int i = 0;
				while (i < string_0.Length)
				{
					char c = string_0[i];
					char c2 = c;
					if (c2 > '\r')
					{
						if (c2 != '\\' && c2 != '|')
						{
							goto IL_0088;
						}
						lcc.MPI('\\').MPI(c);
					}
					else if (c2 != '\n')
					{
						if (c2 != '\r')
						{
							goto IL_0088;
						}
						lcc.MPI("\\r");
					}
					else
					{
						lcc.MPI("\\n");
					}
					IL_0048:
					i++;
					continue;
					IL_0088:
					lcc.MPI(c);
					goto IL_0048;
				}
				text = lcc.ToString();
			}
			else
			{
				text = "";
			}
			return text;
		}

		// Token: 0x060115E9 RID: 71145 RVA: 0x0069FAC0 File Offset: 0x0069DCC0
		public static string Ap(lyN lyN_0)
		{
			return Eyf.AC(lyN_0, Eyf.u);
		}

		// Token: 0x060115EA RID: 71146 RVA: 0x0069FADC File Offset: 0x0069DCDC
		public static string AC(lyN lyN_0, string string_0)
		{
			lcc lcc = new lcc();
			for (int i = 0; i < lyN_0.W(); i++)
			{
				if (i > 0)
				{
					lcc.MPI(string_0);
				}
				lyN lyN = (lyN)lyN_0.K(i);
				for (int j = 0; j < lyN.W(); j++)
				{
					if (j > 0)
					{
						lcc.MPI("|");
					}
					lcc.MPI((lyN.K(j) != null) ? Eyf.AV(lyN.K(j).ToString()) : "");
				}
			}
			return lcc.ToString();
		}

		// Token: 0x060115EB RID: 71147 RVA: 0x0069FB84 File Offset: 0x0069DD84
		public static string AU(long long_0)
		{
			lcc lcc = new lcc();
			int num = 0;
			if (long_0 < 0L)
			{
				lcc.MPI("-");
				long_0 = -long_0;
				num = 1;
			}
			if (long_0 % 1000L > 0L)
			{
				lcc.MPI(".").MPI(Eyf.DI(long_0 % 1000L)).MPI("0000");
				while (lcc.D < 8 + num)
				{
					lcc.MPN(num + 1, "0");
				}
			}
			long_0 /= 1000L;
			lcc.MPN(num, ":" + Eyf.DI(long_0 % 60L));
			long_0 /= 60L;
			lcc.MPN(num, ":" + Eyf.DI(long_0 % 60L));
			long_0 /= 60L;
			lcc.MPN(num, Eyf.DI(long_0 % 24L));
			long_0 /= 24L;
			if (long_0 > 0L)
			{
				lcc.MPN(num, Eyf.DI(long_0) + ".");
			}
			return lcc.ToString();
		}

		// Token: 0x060115EC RID: 71148 RVA: 0x00554CB8 File Offset: 0x00552EB8
		public static bool Ah()
		{
			return false;
		}

		// Token: 0x060115ED RID: 71149 RVA: 0x0068C69C File Offset: 0x0068A89C
		public static string AD()
		{
			PlatformID platform = Environment.OSVersion.Platform;
			string text;
			if (platform != PlatformID.Win32NT && platform != PlatformID.Win32S && platform != PlatformID.Win32Windows && platform != PlatformID.WinCE)
			{
				if (platform != PlatformID.Unix)
				{
					if (platform != PlatformID.MacOSX)
					{
						text = "";
					}
					else
					{
						text = "Mac";
					}
				}
				else
				{
					text = "Unix";
				}
			}
			else
			{
				text = "Windows";
			}
			return text;
		}

		// Token: 0x060115EE RID: 71150 RVA: 0x0069FD00 File Offset: 0x0069DF00
		public static void Al(RSBContext rsbcontext_0, string[] string_0)
		{
			string[] array = new string[] { "firewall_server", "firewall_port", "firewall_user", "firewall_password", "proxy_server", "proxy_port", "proxy_user", "proxy_password", "proxy_authtoken", "transfermode" };
			for (int i = 0; i < array.Length; i++)
			{
				string text = rsbcontext_0.GetInput(array[i]);
				if (text != null && !text.Equals(""))
				{
					throw new Egs(array[i] + " is not supported in the GAE platform.");
				}
			}
			if (string_0 != null)
			{
				for (int i = 0; i < string_0.Length; i++)
				{
					string text = rsbcontext_0.GetInput(string_0[i]);
					if (text != null && !text.Equals(""))
					{
						throw new Egs(string_0[i] + " is not supported in the GAE platform.");
					}
				}
			}
		}

		// Token: 0x060115EF RID: 71151 RVA: 0x0069FDF4 File Offset: 0x0069DFF4
		public static string Am(object object_0)
		{
			string text;
			if (object_0 != null)
			{
				text = object_0.GetType().ToString();
			}
			else
			{
				text = "";
			}
			return text;
		}

		// Token: 0x060115F0 RID: 71152 RVA: 0x0069FE20 File Offset: 0x0069E020
		public static lyZ Ax(RSBItem rsbitem_0, string string_0)
		{
			lyZ lyZ2;
			if (rsbitem_0 != null)
			{
				string[] array = rsbitem_0.ListAttrs(string_0);
				if (array != null && array.Length > 0)
				{
					lyZ lyZ = new lyZ();
					for (int i = 0; i < array.Length; i++)
					{
						lyZ.E(array[i].Substring(string_0.Length - 1), rsbitem_0.GetAttr(array[i]));
					}
					lyZ2 = lyZ;
				}
				else
				{
					lyZ2 = null;
				}
			}
			else
			{
				lyZ2 = null;
			}
			return lyZ2;
		}

		// Token: 0x060115F1 RID: 71153 RVA: 0x0069FE90 File Offset: 0x0069E090
		public static string An()
		{
			return Eyf.th() + "\t2\t[Request]\r\n";
		}

		// Token: 0x060115F2 RID: 71154 RVA: 0x0069FEB4 File Offset: 0x0069E0B4
		public static string Aw()
		{
			return Eyf.th() + "\t2\t[Response]\r\n";
		}

		// Token: 0x060115F3 RID: 71155 RVA: 0x0069FED8 File Offset: 0x0069E0D8
		public static void AO(RSBItem rsbitem_0, RSBItem rsbitem_1)
		{
			if (!Eyf.lx(rsbitem_1.GetAttr("HttpInBufferSize")))
			{
				rsbitem_0.SetAttr("HttpInBufferSize", rsbitem_1.GetAttr("HttpInBufferSize"));
			}
			if (!Eyf.lx(rsbitem_1.GetAttr("SSLCert")))
			{
				rsbitem_0.SetAttr("SSLCert", rsbitem_1.GetAttr("SSLCert"));
			}
			if (!Eyf.lx(rsbitem_1.GetAttr("SSLServerCert")))
			{
				rsbitem_0.SetAttr("SSLCert", rsbitem_1.GetAttr("SSLServerCert"));
			}
			if (!Eyf.lx(rsbitem_1.GetAttr("Logfile")))
			{
				rsbitem_0.SetAttr("logfile", rsbitem_1.GetAttr("Logfile"));
			}
			if (!Eyf.lx(rsbitem_1.GetAttr("Verbosity")))
			{
				rsbitem_0.SetAttr("verbosity", rsbitem_1.GetAttr("Verbosity"));
			}
			if (!Eyf.lx(rsbitem_1.GetAttr("FirewallServer")))
			{
				rsbitem_0.SetAttr("firewall_server", rsbitem_1.GetAttr("FirewallServer"));
			}
			string attr = rsbitem_1.GetAttr("FirewallType");
			if (!Eyf.lx(attr) && !attr.ToUpper().Equals("NONE"))
			{
				rsbitem_0.SetAttr("firewall_type", attr.ToUpper());
			}
			if (!Eyf.lx(rsbitem_1.GetAttr("FirewallUser")))
			{
				rsbitem_0.SetAttr("firewall_user", rsbitem_1.GetAttr("FirewallUser"));
			}
			if (!Eyf.lx(rsbitem_1.GetAttr("FirewallPassword")))
			{
				rsbitem_0.SetAttr("firewall_password", rsbitem_1.GetAttr("FirewallPassword"));
			}
			if (!Eyf.lx(rsbitem_1.GetAttr("FirewallPort")))
			{
				rsbitem_0.SetAttr("firewall_port", rsbitem_1.GetAttr("FirewallPort"));
			}
			if (!Eyf.lx(rsbitem_1.GetAttr("ProxyAutoDetect")))
			{
				rsbitem_0.SetAttr("proxy_auto", rsbitem_1.GetAttr("ProxyAutoDetect").ToUpper());
			}
			if (!Eyf.lx(rsbitem_1.GetAttr("ProxyAuthScheme")))
			{
				rsbitem_0.SetAttr("proxy_authscheme", rsbitem_1.GetAttr("ProxyAuthScheme").ToUpper());
			}
			if (!Eyf.lx(rsbitem_1.GetAttr("ProxySSLType")))
			{
				rsbitem_0.SetAttr("proxy_ssltype", rsbitem_1.GetAttr("ProxySSLType"));
			}
			if (!Eyf.lx(rsbitem_1.GetAttr("ProxyServer")))
			{
				rsbitem_0.SetAttr("proxy_server", rsbitem_1.GetAttr("ProxyServer"));
			}
			if (!Eyf.lx(rsbitem_1.GetAttr("ProxyUser")))
			{
				rsbitem_0.SetAttr("proxy_user", rsbitem_1.GetAttr("ProxyUser"));
			}
			if (!Eyf.lx(rsbitem_1.GetAttr("ProxyPassword")))
			{
				rsbitem_0.SetAttr("proxy_password", rsbitem_1.GetAttr("ProxyPassword"));
			}
			if (!Eyf.lx(rsbitem_1.GetAttr("ProxyPort")))
			{
				rsbitem_0.SetAttr("proxy_port", rsbitem_1.GetAttr("ProxyPort"));
			}
			if (!Eyf.lx(rsbitem_1.GetAttr("Timeout")))
			{
				rsbitem_0.SetAttr("timeout", rsbitem_1.GetAttr("Timeout"));
			}
			if (!Eyf.lx(rsbitem_1.GetAttr("HTTPTestFile")))
			{
				rsbitem_0.SetAttr("__httptestfile", rsbitem_1.GetAttr("HTTPTestFile"));
			}
			if (!Eyf.lx(rsbitem_1.GetAttr("GenerateHTTPTestFile")))
			{
				rsbitem_0.SetAttr("__genhttptestfile", rsbitem_1.GetAttr("GenerateHTTPTestFile"));
			}
			if (!Eyf.lx(rsbitem_1.GetAttr("GenerateHTTPTestFileParams")))
			{
				rsbitem_0.SetAttr("__genhttptestfileparams", rsbitem_1.GetAttr("GenerateHTTPTestFileParams"));
			}
			if (!Eyf.lx(rsbitem_1.GetAttr("UseHTTPLight")))
			{
				rsbitem_0.SetAttr("UsePlatformHTTP", rsbitem_1.GetAttr("UseHTTPLight"));
			}
			if (!Eyf.lx(rsbitem_1.GetAttr("Localhost")))
			{
				rsbitem_0.SetAttr("localhost", rsbitem_1.GetAttr("Localhost"));
			}
			if (!Eyf.lx(rsbitem_1.GetAttr("UseManagedSecurityAPI")))
			{
				rsbitem_0.SetAttr("usemanagedsecurityapi", rsbitem_1.GetAttr("UseManagedSecurityAPI"));
			}
			if (!Eyf.lx(rsbitem_1.GetAttr("UseInternalSecurityAPI")))
			{
				rsbitem_0.SetAttr("useinternalsecurityapi", rsbitem_1.GetAttr("UseInternalSecurityAPI"));
			}
			if (!Eyf.lx(rsbitem_1.GetAttr("UseHTTPKeepAlive")))
			{
				rsbitem_0.SetAttr("usehttpkeepalive", rsbitem_1.GetAttr("UseHTTPKeepAlive"));
			}
			if (!Eyf.lx(rsbitem_1.GetAttr("RecordToFile")))
			{
				rsbitem_0.SetAttr("recordtofile", rsbitem_1.GetAttr("RecordToFile"));
			}
			if (!Eyf.lx(rsbitem_1.GetAttr("OAuthTokenLeaseTime")))
			{
				rsbitem_0.SetAttr("OAuthTokenLeaseTime", rsbitem_1.GetAttr("OAuthTokenLeaseTime"));
			}
			if (!Eyf.lx(rsbitem_1.GetAttr("SSLClientCertType")))
			{
				rsbitem_0.SetAttr("SSLClientCertType", rsbitem_1.GetAttr("SSLClientCertType"));
			}
			if (!Eyf.lx(rsbitem_1.GetAttr("SSLClientCert")))
			{
				rsbitem_0.SetAttr("SSLClientCert", rsbitem_1.GetAttr("SSLClientCert"));
			}
			if (!Eyf.lx(rsbitem_1.GetAttr("SSLClientCertPassword")))
			{
				rsbitem_0.SetAttr("SSLClientCertPassword", rsbitem_1.GetAttr("SSLClientCertPassword"));
			}
			if (!Eyf.lx(rsbitem_1.GetAttr("SSLClientCertSubject")))
			{
				rsbitem_0.SetAttr("SSLClientCertSubject", rsbitem_1.GetAttr("SSLClientCertSubject"));
			}
			string[] array = rsbitem_1.ListAttrs("IntConfig*");
			foreach (string text in array)
			{
				string text2 = lcP.IG(text, "IntConfig".Length);
				string attr2 = rsbitem_1.GetAttr(text);
				if (Eyf.lx(text2) || Eyf.lx(attr2))
				{
					throw new RSBException("Connection Exception", "Internal config name and value cannot be empty.");
				}
				rsbitem_0.SetAttr("internalconfig#", text2 + "=" + attr2);
			}
		}

		// Token: 0x060115F4 RID: 71156 RVA: 0x006A0598 File Offset: 0x0069E798
		public static int AI(string string_0)
		{
			int num;
			if (string_0 != null)
			{
				if (!lcP.nt(string_0, "USER"))
				{
					if (!lcP.nt(string_0, "MACHINE"))
					{
						if (!lcP.nt(string_0, "PFXFILE"))
						{
							if (!lcP.nt(string_0, "PFXBLOB"))
							{
								if (!lcP.nt(string_0, "JKSFILE"))
								{
									if (!lcP.nt(string_0, "JKSBLOB"))
									{
										if (!lcP.nt(string_0, "PEMKEY_FILE"))
										{
											if (!lcP.nt(string_0, "PEMKEY_BLOB"))
											{
												if (!lcP.nt(string_0, "PUBLIC_KEY_FILE"))
												{
													if (!lcP.nt(string_0, "PUBLIC_KEY_BLOB"))
													{
														if (!lcP.nt(string_0, "SSHPUBLIC_KEY_BLOB"))
														{
															if (!lcP.nt(string_0, "P7BFILE"))
															{
																if (!lcP.nt(string_0, "P7BBLOB"))
																{
																	if (!lcP.nt(string_0, "SSHPUBLIC_KEY_FILE"))
																	{
																		if (!lcP.nt(string_0, "PPKFILE"))
																		{
																			if (!lcP.nt(string_0, "PPKBLOB"))
																			{
																				if (!lcP.nt(string_0, "XMLFILE"))
																				{
																					if (!lcP.nt(string_0, "XMLBLOB"))
																					{
																						num = -1;
																					}
																					else
																					{
																						num = 17;
																					}
																				}
																				else
																				{
																					num = 16;
																				}
																			}
																			else
																			{
																				num = 15;
																			}
																		}
																		else
																		{
																			num = 14;
																		}
																	}
																	else
																	{
																		num = 13;
																	}
																}
																else
																{
																	num = 12;
																}
															}
															else
															{
																num = 11;
															}
														}
														else
														{
															num = 10;
														}
													}
													else
													{
														num = 9;
													}
												}
												else
												{
													num = 8;
												}
											}
											else
											{
												num = 7;
											}
										}
										else
										{
											num = 6;
										}
									}
									else
									{
										num = 5;
									}
								}
								else
								{
									num = 4;
								}
							}
							else
							{
								num = 3;
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
					num = 0;
				}
			}
			else
			{
				num = -1;
			}
			return num;
		}

		// Token: 0x060115F5 RID: 71157 RVA: 0x006A0754 File Offset: 0x0069E954
		public static void Ae(RSBItem rsbitem_0, RSBItem rsbitem_1, bool bool_0)
		{
			if (!(rsbitem_0.IsVectorItem() ^ rsbitem_1.IsVectorItem()))
			{
				if (!rsbitem_0.IsVectorItem())
				{
					string[] array = rsbitem_0.ListAttrs("*");
					foreach (string text in array)
					{
						int attrCount = rsbitem_0.GetAttrCount(text);
						string text2 = text;
						if (bool_0)
						{
							int num = text.IndexOf(":");
							if (num != -1)
							{
								text2 = lcP.IG(text, num + 1);
							}
						}
						for (int j = 0; j < attrCount; j++)
						{
							rsbitem_1.SetAttr(text2, rsbitem_0.GetAttr(text, j), j);
						}
					}
				}
				else
				{
					lyZ lyZ = (lyZ)rsbitem_0.GetKeyIndex();
					lyN lyN = (lyN)rsbitem_0.GetValues();
					lyh lyh = Eyf.AK(lyZ);
					while (lyh.MPP())
					{
						string text3 = (string)lyh.MPX();
						int num2 = (int)lyZ.G(text3);
						object obj = null;
						if (lyN.W() > num2)
						{
							obj = lyN.K(num2);
						}
						if (obj != null && !(obj is string))
						{
							if (obj is lyN)
							{
								rsbitem_1.SetAttrValues(text3, (lyN)obj);
							}
						}
						else
						{
							rsbitem_1.SetAttr(text3, (string)obj);
						}
					}
				}
				return;
			}
			throw new RSBException("rsb:item", "You can only copy from similar items.");
		}

		// Token: 0x060115F6 RID: 71158 RVA: 0x003B5328 File Offset: 0x003B3528
		public static long At(byte[] byte_0, int int_0, int int_1)
		{
			long num = 0L;
			while (int_1 > 0 && int_0 < byte_0.Length)
			{
				num = (num << 8) | (long)(byte_0[int_0++] & byte.MaxValue);
				int_1--;
			}
			return num;
		}

		// Token: 0x060115F7 RID: 71159 RVA: 0x006A08D4 File Offset: 0x0069EAD4
		public static void Ag(RSBItem rsbitem_0, string string_0, string string_1)
		{
			if (Eyf.lx(rsbitem_0.GetAttr(string_0)))
			{
				rsbitem_0.SetAttr(string_0, string_1);
			}
		}

		// Token: 0x060115F8 RID: 71160 RVA: 0x006A08FC File Offset: 0x0069EAFC
		public static void AA(RSBItem rsbitem_0, string string_0, string string_1)
		{
			if (!Eyf.lx(string_1))
			{
				rsbitem_0.SetAttr(string_0, string_1);
			}
		}

		// Token: 0x060115F9 RID: 71161 RVA: 0x006A091C File Offset: 0x0069EB1C
		public static string[] Ar(string string_0)
		{
			string[] array;
			if (string_0.IndexOf('[') != -1)
			{
				lyv<string> lyv = new lyv<string>();
				int num = 0;
				lcc lcc = new lcc();
				foreach (char c in string_0)
				{
					if (c != '[' || num != 0)
					{
						if (c != ']')
						{
							if (num > 0)
							{
								lcc.MPI(c);
							}
						}
						else
						{
							num--;
							if (num > 1)
							{
								lcc.MPI(c);
							}
						}
					}
					else
					{
						num++;
						if (num > 1)
						{
							lcc.MPI(c);
						}
					}
					if (num == 0 && c == ',' && lcc.D > 0)
					{
						lyv.Add(lcc.ToString());
						lcc.j(0);
					}
				}
				if (num == 0 && lcc.D > 0)
				{
					lyv.Add(lcc.ToString());
					lcc.j(0);
				}
				array = new string[lyv.W()];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = lyv.n(i);
				}
			}
			else
			{
				array = Eyf.xp(string_0, ',');
			}
			return array;
		}

		// Token: 0x060115FA RID: 71162 RVA: 0x006A0A74 File Offset: 0x0069EC74
		public static lyh AF(ICollection icollection_0)
		{
			return new lys(icollection_0);
		}

		// Token: 0x060115FB RID: 71163 RVA: 0x00554E5C File Offset: 0x0055305C
		public static lyh AK(lyZ lyZ_0)
		{
			return lyZ_0.u();
		}

		// Token: 0x060115FC RID: 71164 RVA: 0x00554E74 File Offset: 0x00553074
		public static lyh Aq<P, H>(lmD<P, H> lmD_0)
		{
			return lmD_0.n();
		}

		// Token: 0x060115FD RID: 71165 RVA: 0x006A0A8C File Offset: 0x0069EC8C
		public static lyh AS<K, P>(lmD<K, P> lmD_0)
		{
			return new lys(lmD_0.i());
		}

		// Token: 0x060115FE RID: 71166 RVA: 0x006A0AA8 File Offset: 0x0069ECA8
		public static string AZ()
		{
			char[] array = new char[]
			{
				'0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
				'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
				'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
				'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D',
				'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N',
				'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X',
				'Y', 'Z'
			};
			string text = "";
			for (int i = 0; i < 10; i++)
			{
				int num = Eyf.rJ(array.Length);
				text += array[num];
			}
			return text;
		}

		// Token: 0x060115FF RID: 71167 RVA: 0x003B54C8 File Offset: 0x003B36C8
		public static string rB()
		{
			return Guid.NewGuid().ToString();
		}

		// Token: 0x06011600 RID: 71168 RVA: 0x006A0AFC File Offset: 0x0069ECFC
		public static int rJ(int int_0)
		{
			byte[] array = new byte[4];
			Eyf.W.GetBytes(array);
			int num = (int)(Eyf.At(array, 0, 4) & 2147483647L);
			return (num < 0 || num >= int_0) ? (num % int_0) : num;
		}

		// Token: 0x06011601 RID: 71169 RVA: 0x006A0B40 File Offset: 0x0069ED40
		public static lyN rY(string string_0)
		{
			lyN lyN = new lyN();
			string[] array = string_0.Split(new char[] { ',' });
			foreach (string text in array)
			{
				lyN.Add(new Egm(text));
			}
			return lyN;
		}

		// Token: 0x06011602 RID: 71170 RVA: 0x006A0B98 File Offset: 0x0069ED98
		public static bool rV(string string_0, string string_1)
		{
			bool flag;
			if (string_0 != null && !"%".Equals(string_0))
			{
				if (!"".Equals(string_1) || !"".Equals(string_0))
				{
					if (!Eyf.lx(string_0) && !Eyf.lx(string_1))
					{
						if (!Eyf.ht(string_0, string_1))
						{
							char[] array = string_0.ToCharArray();
							char[] array2 = string_1.ToCharArray();
							string text = string_1;
							string_0 = lcP.IG(string_0, 1);
							string_1 = lcP.IG(string_1, 1);
							if ('%' == array[0])
							{
								for (int i = 0; i < text.Length; i++)
								{
									if (Eyf.rV(string_0, lcP.IG(text, i)))
									{
										return true;
									}
								}
							}
							if ('_' != array[0])
							{
								if ('\\' != array[0])
								{
									flag = Eyf.rp(array[0]) == Eyf.rp(array2[0]) && Eyf.rV(string_0, string_1);
								}
								else
								{
									flag = array[1] == array2[0] && Eyf.rV(lcP.IG(string_0, 1), string_1);
								}
							}
							else
							{
								flag = Eyf.rV(string_0, string_1);
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
			return flag;
		}

		// Token: 0x06011603 RID: 71171 RVA: 0x006A0D0C File Offset: 0x0069EF0C
		public static char rp(char char_0)
		{
			char c;
			if (char_0 < 'a' || char_0 > 'z')
			{
				c = char_0;
			}
			else
			{
				c = char_0 - ' ';
			}
			return c;
		}

		// Token: 0x06011604 RID: 71172 RVA: 0x006A0D34 File Offset: 0x0069EF34
		public static bool rC(string string_0, string string_1)
		{
			bool flag;
			if (string_0 != null && !"%".Equals(string_0))
			{
				if (!"".Equals(string_0))
				{
					if (Eyf.lx(string_0) || !Eyf.lx(string_1))
					{
						if (!Eyf.UK(string_1, string_0, true))
						{
							char[] array = string_0.ToCharArray();
							char[] array2 = string_1.ToCharArray();
							string text = string_1;
							string_0 = lcP.IG(string_0, 1);
							string_1 = lcP.IG(string_1, 1);
							if ('%' == array[0])
							{
								for (int i = 0; i < text.Length; i++)
								{
									if (Eyf.rC(string_0, lcP.IG(text, i)))
									{
										return true;
									}
								}
							}
							if ('_' != array[0])
							{
								if ('\\' != array[0])
								{
									flag = array[0] == array2[0] && Eyf.rC(string_0, string_1);
								}
								else
								{
									flag = array[1] == array2[0] && Eyf.rC(lcP.IG(string_0, 1), string_1);
								}
							}
							else
							{
								flag = Eyf.rC(string_0, string_1);
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
			return flag;
		}

		// Token: 0x06011605 RID: 71173 RVA: 0x006A0E88 File Offset: 0x0069F088
		public static bool rU(string[] string_0, string string_1)
		{
			bool flag;
			if (string_0 != null)
			{
				foreach (string text in string_0)
				{
					if (Eyf.rh(text, string_1))
					{
						return true;
					}
				}
				flag = false;
			}
			else
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x06011606 RID: 71174 RVA: 0x006A0ED4 File Offset: 0x0069F0D4
		public static bool rh(string string_0, string string_1)
		{
			return !Eyf.lx(string_0) && !Eyf.lx(string_1) && Eyr.B(string_1, string_0);
		}

		// Token: 0x06011607 RID: 71175 RVA: 0x006A0F04 File Offset: 0x0069F104
		public static bool rD(string string_0, lcc lcc_0)
		{
			bool flag4;
			if (string_0 != null)
			{
				if (lcc_0 == null)
				{
					lcc_0 = new lcc();
				}
				lcc_0.j(0);
				bool flag = false;
				bool flag2 = false;
				int length = string_0.Length;
				int i = 0;
				while (i < length)
				{
					char c = string_0[i];
					bool flag3 = flag;
					if (flag || c != '\\')
					{
						flag = false;
						goto IL_0043;
					}
					flag = true;
					if (i == length - 1)
					{
						goto IL_0043;
					}
					IL_0053:
					i++;
					continue;
					IL_0043:
					if (!flag3 || c == '%')
					{
						if (!flag3 && c == '%')
						{
							flag2 = true;
						}
					}
					else
					{
						lcc_0.MPI("\\");
					}
					lcc_0.MPI(c);
					goto IL_0053;
				}
				flag4 = flag2;
			}
			else
			{
				flag4 = true;
			}
			return flag4;
		}

		// Token: 0x06011608 RID: 71176 RVA: 0x006A0FC8 File Offset: 0x0069F1C8
		public static string rl(string string_0)
		{
			string text;
			if (!Eyf.lx(string_0))
			{
				char c = '\\';
				lcc lcc = new lcc();
				foreach (char c2 in string_0)
				{
					if (c2 == '\\')
					{
						lcc.MPI(c);
					}
					lcc.MPI(c2);
				}
				text = lcc.ToString();
			}
			else
			{
				text = string_0;
			}
			return text;
		}

		// Token: 0x06011609 RID: 71177 RVA: 0x006A1034 File Offset: 0x0069F234
		public static bool rm(byte[] byte_0, byte[] byte_1)
		{
			bool flag;
			if (byte_0 != null && byte_1 != null)
			{
				if (byte_0.Length == byte_1.Length)
				{
					for (int i = 0; i < byte_0.Length; i++)
					{
						if (byte_0[i] != byte_1[i])
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
			}
			else
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x0601160A RID: 71178 RVA: 0x006A1088 File Offset: 0x0069F288
		private static void rx()
		{
			string text = Eyf.mx("abc&#13;def");
			string text2 = Eyf.mx("abc&#x0D;def");
			string text3 = Eyf.mx("abc&#xD;def");
			string text4 = Eyf.mx("abc&#82;def");
			if (!text.Equals("abc\rdef") || !text2.Equals("abc\rdef") || !text3.Equals("abc\rdef") || !text4.Equals("abc\rdef"))
			{
				throw new Exception("Failed to decode the XML");
			}
		}

		// Token: 0x0601160B RID: 71179 RVA: 0x006A1108 File Offset: 0x0069F308
		public static string rn(lmr<string> lmr_0, string string_0, string string_1, bool bool_0)
		{
			if (!bool_0)
			{
				goto IL_0111;
			}
			IL_0006:
			using (lmg<string> lmg = lmr_0.O())
			{
				while (lmg.MoveNext())
				{
					string text = lmg.Current;
					string text2 = text + ":******\r\n";
					string text3 = string.Concat(new string[] { "((", text, "=(\"){1})(.+?)(\"){1}(?=[,&])|(", text, "=(.+?)(?=[,&]))|(", text, "[:=]((.*(?:(\\r\\n)|(\\r)|(\\n)|$)))))" });
					if (bool_0)
					{
						if (!string_1.Contains("json"))
						{
							if (string_1.Contains("xml"))
							{
								text2 = "$1$3******$2$4";
								text3 = Eyf.Oq("(<{1}.+:{1}{0}.*>){1}.+(<{1}\\/{1}.+:{1}{0}>{1})|(<{1}{0}.*>{1}).+(<\\/{1}{0}>{1})", new string[] { text, "{1}" });
							}
						}
						else
						{
							text2 = "\"" + text + "\": \"******\"";
							text3 = "\"{1}" + text + "\"{1}\\s*:{1}\\s*\"{1}.+\"{1}(?=\\s*[,}])";
						}
					}
					Regex regex = new Regex(text3, RegexOptions.IgnoreCase);
					string_0 = regex.Replace(string_0, text2);
				}
				return string_0;
			}
			IL_0111:
			lmr_0.Add("oauth_token");
			lmr_0.Add("Authorization");
			goto IL_0006;
		}

		// Token: 0x0601160C RID: 71180 RVA: 0x006A1258 File Offset: 0x0069F458
		public static string rw(string string_0, string string_1)
		{
			if (Eyf.lx(string_0))
			{
				throw new RSBException("300", string_1);
			}
			return string_0;
		}

		// Token: 0x0601160D RID: 71181 RVA: 0x006A1280 File Offset: 0x0069F480
		public static string rO(byte[] byte_0, bool[] bool_0, int[] int_0)
		{
			byte[] array = new byte[] { 239, 187, 191 };
			byte[] array2 = new byte[] { byte.MaxValue, 254 };
			byte[] array3 = new byte[] { 254, byte.MaxValue };
			if (byte_0.Length >= 3)
			{
				if (byte_0[0] == array[0] && byte_0[1] == array[1] && byte_0[2] == array[2])
				{
					bool_0[0] = true;
					int_0[0] = 3;
					return "utf-8";
				}
				if (byte_0[0] == array2[0] && byte_0[1] == array2[1])
				{
					bool_0[0] = true;
					int_0[0] = 2;
					return "utf-16le";
				}
				if (byte_0[0] == array3[0] && byte_0[1] == array3[1])
				{
					int_0[0] = 2;
					bool_0[0] = true;
					return "utf-16be";
				}
			}
			return "utf-8";
		}

		// Token: 0x0601160E RID: 71182 RVA: 0x006A1374 File Offset: 0x0069F574
		public static string rI(string string_0)
		{
			if (!Eyf.Gy)
			{
				lock (Eyf.Z)
				{
					if (!Eyf.Gy)
					{
						Eyf.Z.H("CSBIG5", "Big5");
						Eyf.Z.H("BIG5-HKSCS", "Big5-HKSCS");
						Eyf.Z.H("BIG5HK", "Big5-HKSCS");
						Eyf.Z.H("BIG5_HKSCS", "Big5-HKSCS");
						Eyf.Z.H("BIG5HKSCS", "Big5-HKSCS");
						Eyf.Z.H("CESU8", "CESU-8");
						Eyf.Z.H("CSCESU-8", "CESU-8");
						Eyf.Z.H("CSEUCPKDFMTJAPANESE", "EUC-JP");
						Eyf.Z.H("X-EUC-JP", "EUC-JP");
						Eyf.Z.H("EUCJIS", "EUC-JP");
						Eyf.Z.H("EXTENDED_UNIX_CODE_PACKED_FORMAT_FOR_JAPANESE", "EUC-JP");
						Eyf.Z.H("EUC_JP", "EUC-JP");
						Eyf.Z.H("EUCJP", "EUC-JP");
						Eyf.Z.H("X-EUCJP", "EUC-JP");
						Eyf.Z.H("KSC5601-1987", "EUC-KR");
						Eyf.Z.H("CSEUCKR", "EUC-KR");
						Eyf.Z.H("KSC5601_1987", "EUC-KR");
						Eyf.Z.H("KSC5601", "EUC-KR");
						Eyf.Z.H("5601", "EUC-KR");
						Eyf.Z.H("EUC_KR", "EUC-KR");
						Eyf.Z.H("KSC_5601", "EUC-KR");
						Eyf.Z.H("KS_C_5601-1987", "EUC-KR");
						Eyf.Z.H("EUCKR", "EUC-KR");
						Eyf.Z.H("GB18030-2000", "GB18030");
						Eyf.Z.H("GB2312", "GB2312");
						Eyf.Z.H("EUC-CN", "GB2312");
						Eyf.Z.H("X-EUC-CN", "GB2312");
						Eyf.Z.H("EUCCN", "GB2312");
						Eyf.Z.H("EUC_CN", "GB2312");
						Eyf.Z.H("GB2312-80", "GB2312");
						Eyf.Z.H("GB2312-1980", "GB2312");
						Eyf.Z.H("CP936", "GBK");
						Eyf.Z.H("WINDOWS-936", "GBK");
						Eyf.Z.H("IBM-838", "IBM-Thai");
						Eyf.Z.H("IBM838", "IBM-Thai");
						Eyf.Z.H("838", "IBM-Thai");
						Eyf.Z.H("CP838", "IBM-Thai");
						Eyf.Z.H("CP858", "IBM00858");
						Eyf.Z.H("858", "IBM00858");
						Eyf.Z.H("PC-MULTILINGUAL-850+EURO", "IBM00858");
						Eyf.Z.H("CP00858", "IBM00858");
						Eyf.Z.H("CCSID00858", "IBM00858");
						Eyf.Z.H("CP1140", "IBM01140");
						Eyf.Z.H("1140", "IBM01140");
						Eyf.Z.H("CP01140", "IBM01140");
						Eyf.Z.H("EBCDIC-US-037+EURO", "IBM01140");
						Eyf.Z.H("CCSID01140", "IBM01140");
						Eyf.Z.H("1141", "IBM01141");
						Eyf.Z.H("CP1141", "IBM01141");
						Eyf.Z.H("CP01141", "IBM01141");
						Eyf.Z.H("CCSID01141", "IBM01141");
						Eyf.Z.H("EBCDIC-DE-273+EURO", "IBM01141");
						Eyf.Z.H("1142", "IBM01142");
						Eyf.Z.H("CP1142", "IBM01142");
						Eyf.Z.H("CP01142", "IBM01142");
						Eyf.Z.H("CCSID01142", "IBM01142");
						Eyf.Z.H("EBCDIC-NO-277+EURO", "IBM01142");
						Eyf.Z.H("EBCDIC-DK-277+EURO", "IBM01142");
						Eyf.Z.H("1143", "IBM01143");
						Eyf.Z.H("CP01143", "IBM01143");
						Eyf.Z.H("CCSID01143", "IBM01143");
						Eyf.Z.H("CP1143", "IBM01143");
						Eyf.Z.H("EBCDIC-FI-278+EURO", "IBM01143");
						Eyf.Z.H("EBCDIC-SE-278+EURO", "IBM01143");
						Eyf.Z.H("CP01144", "IBM01144");
						Eyf.Z.H("CCSID01144", "IBM01144");
						Eyf.Z.H("EBCDIC-IT-280+EURO", "IBM01144");
						Eyf.Z.H("CP1144", "IBM01144");
						Eyf.Z.H("1144", "IBM01144");
						Eyf.Z.H("CCSID01145", "IBM01145");
						Eyf.Z.H("EBCDIC-ES-284+EURO", "IBM01145");
						Eyf.Z.H("1145", "IBM01145");
						Eyf.Z.H("CP1145", "IBM01145");
						Eyf.Z.H("CP01145", "IBM01145");
						Eyf.Z.H("EBCDIC-GB-285+EURO", "IBM01146");
						Eyf.Z.H("1146", "IBM01146");
						Eyf.Z.H("CP1146", "IBM01146");
						Eyf.Z.H("CP01146", "IBM01146");
						Eyf.Z.H("CCSID01146", "IBM01146");
						Eyf.Z.H("CP1147", "IBM01147");
						Eyf.Z.H("1147", "IBM01147");
						Eyf.Z.H("CP01147", "IBM01147");
						Eyf.Z.H("CCSID01147", "IBM01147");
						Eyf.Z.H("EBCDIC-FR-277+EURO", "IBM01147");
						Eyf.Z.H("CP1148", "IBM01148");
						Eyf.Z.H("EBCDIC-INTERNATIONAL-500+EURO", "IBM01148");
						Eyf.Z.H("1148", "IBM01148");
						Eyf.Z.H("CP01148", "IBM01148");
						Eyf.Z.H("CCSID01148", "IBM01148");
						Eyf.Z.H("EBCDIC-S-871+EURO", "IBM01149");
						Eyf.Z.H("1149", "IBM01149");
						Eyf.Z.H("CP1149", "IBM01149");
						Eyf.Z.H("CP01149", "IBM01149");
						Eyf.Z.H("CCSID01149", "IBM01149");
						Eyf.Z.H("CP037", "IBM037");
						Eyf.Z.H("IBM037", "IBM037");
						Eyf.Z.H("IBM-037", "IBM037");
						Eyf.Z.H("CSIBM037", "IBM037");
						Eyf.Z.H("EBCDIC-CP-US", "IBM037");
						Eyf.Z.H("EBCDIC-CP-CA", "IBM037");
						Eyf.Z.H("EBCDIC-CP-NL", "IBM037");
						Eyf.Z.H("EBCDIC-CP-WT", "IBM037");
						Eyf.Z.H("037", "IBM037");
						Eyf.Z.H("CPIBM37", "IBM037");
						Eyf.Z.H("CS-EBCDIC-CP-WT", "IBM037");
						Eyf.Z.H("IBM-37", "IBM037");
						Eyf.Z.H("CS-EBCDIC-CP-US", "IBM037");
						Eyf.Z.H("CS-EBCDIC-CP-CA", "IBM037");
						Eyf.Z.H("CS-EBCDIC-CP-NL", "IBM037");
						Eyf.Z.H("CP1026", "IBM1026");
						Eyf.Z.H("IBM-1026", "IBM1026");
						Eyf.Z.H("1026", "IBM1026");
						Eyf.Z.H("IBM1026", "IBM1026");
						Eyf.Z.H("IBM-1047", "IBM01047");
						Eyf.Z.H("1047", "IBM01047");
						Eyf.Z.H("CP1047", "IBM01047");
						Eyf.Z.H("IBM-273", "IBM273");
						Eyf.Z.H("IBM273", "IBM273");
						Eyf.Z.H("273", "IBM273");
						Eyf.Z.H("CP273", "IBM273");
						Eyf.Z.H("IBM277", "IBM277");
						Eyf.Z.H("277", "IBM277");
						Eyf.Z.H("CP277", "IBM277");
						Eyf.Z.H("IBM-277", "IBM277");
						Eyf.Z.H("CP278", "IBM278");
						Eyf.Z.H("278", "IBM278");
						Eyf.Z.H("IBM-278", "IBM278");
						Eyf.Z.H("EBCDIC-CP-SE", "IBM278");
						Eyf.Z.H("CSIBM278", "IBM278");
						Eyf.Z.H("IBM278", "IBM278");
						Eyf.Z.H("EBCDIC-SV", "IBM278");
						Eyf.Z.H("IBM280", "IBM280");
						Eyf.Z.H("280", "IBM280");
						Eyf.Z.H("CP280", "IBM280");
						Eyf.Z.H("IBM-280", "IBM280");
						Eyf.Z.H("CSIBM284", "IBM284");
						Eyf.Z.H("IBM-284", "IBM284");
						Eyf.Z.H("CPIBM284", "IBM284");
						Eyf.Z.H("IBM284", "IBM284");
						Eyf.Z.H("284", "IBM284");
						Eyf.Z.H("CP284", "IBM284");
						Eyf.Z.H("CSIBM285", "IBM285");
						Eyf.Z.H("CP285", "IBM285");
						Eyf.Z.H("EBCDIC-GB", "IBM285");
						Eyf.Z.H("IBM-285", "IBM285");
						Eyf.Z.H("CPIBM285", "IBM285");
						Eyf.Z.H("IBM285", "IBM285");
						Eyf.Z.H("285", "IBM285");
						Eyf.Z.H("EBCDIC-CP-GB", "IBM285");
						Eyf.Z.H("IBM290", "IBM290");
						Eyf.Z.H("290", "IBM290");
						Eyf.Z.H("CP290", "IBM290");
						Eyf.Z.H("EBCDIC-JP-KANA", "IBM290");
						Eyf.Z.H("CSIBM290", "IBM290");
						Eyf.Z.H("IBM-290", "IBM290");
						Eyf.Z.H("297", "IBM297");
						Eyf.Z.H("CSIBM297", "IBM297");
						Eyf.Z.H("CP297", "IBM297");
						Eyf.Z.H("IBM297", "IBM297");
						Eyf.Z.H("IBM-297", "IBM297");
						Eyf.Z.H("CPIBM297", "IBM297");
						Eyf.Z.H("EBCDIC-CP-FR", "IBM297");
						Eyf.Z.H("IBM420", "IBM420");
						Eyf.Z.H("420", "IBM420");
						Eyf.Z.H("CP420", "IBM420");
						Eyf.Z.H("CSIBM420", "IBM420");
						Eyf.Z.H("IBM-420", "IBM420");
						Eyf.Z.H("EBCDIC-CP-AR1", "IBM420");
						Eyf.Z.H("EBCDIC-CP-HE", "IBM424");
						Eyf.Z.H("CSIBM424", "IBM424");
						Eyf.Z.H("IBM-424", "IBM424");
						Eyf.Z.H("IBM424", "IBM424");
						Eyf.Z.H("424", "IBM424");
						Eyf.Z.H("CP424", "IBM424");
						Eyf.Z.H("IBM437", "IBM437");
						Eyf.Z.H("437", "IBM437");
						Eyf.Z.H("IBM-437", "IBM437");
						Eyf.Z.H("CSPC8CODEPAGE437", "IBM437");
						Eyf.Z.H("CP437", "IBM437");
						Eyf.Z.H("WINDOWS-437", "IBM437");
						Eyf.Z.H("IBM-500", "IBM500");
						Eyf.Z.H("IBM500", "IBM500");
						Eyf.Z.H("500", "IBM500");
						Eyf.Z.H("EBCDIC-CP-BH", "IBM500");
						Eyf.Z.H("EBCDIC-CP-CH", "IBM500");
						Eyf.Z.H("CSIBM500", "IBM500");
						Eyf.Z.H("CP500", "IBM500");
						Eyf.Z.H("IBM-775", "IBM775");
						Eyf.Z.H("IBM775", "IBM775");
						Eyf.Z.H("775", "IBM775");
						Eyf.Z.H("CP775", "IBM775");
						Eyf.Z.H("CP850", "IBM850");
						Eyf.Z.H("CSPC850MULTILINGUAL", "IBM850");
						Eyf.Z.H("IBM850", "IBM850");
						Eyf.Z.H("850", "IBM850");
						Eyf.Z.H("IBM-850", "IBM850");
						Eyf.Z.H("CSPCP852", "IBM852");
						Eyf.Z.H("IBM-852", "IBM852");
						Eyf.Z.H("IBM852", "IBM852");
						Eyf.Z.H("852", "IBM852");
						Eyf.Z.H("CP852", "IBM852");
						Eyf.Z.H("IBM855", "IBM855");
						Eyf.Z.H("855", "IBM855");
						Eyf.Z.H("IBM-855", "IBM855");
						Eyf.Z.H("CP855", "IBM855");
						Eyf.Z.H("CSPCP855", "IBM855");
						Eyf.Z.H("IBM857", "IBM857");
						Eyf.Z.H("857", "IBM857");
						Eyf.Z.H("CP857", "IBM857");
						Eyf.Z.H("CSIBM857", "IBM857");
						Eyf.Z.H("IBM-857", "IBM857");
						Eyf.Z.H("IBM860", "IBM860");
						Eyf.Z.H("860", "IBM860");
						Eyf.Z.H("CP860", "IBM860");
						Eyf.Z.H("CSIBM860", "IBM860");
						Eyf.Z.H("IBM-860", "IBM860");
						Eyf.Z.H("CP861", "IBM861");
						Eyf.Z.H("IBM861", "IBM861");
						Eyf.Z.H("861", "IBM861");
						Eyf.Z.H("IBM-861", "IBM861");
						Eyf.Z.H("CP-IS", "IBM861");
						Eyf.Z.H("CSIBM861", "IBM861");
						Eyf.Z.H("CSIBM862", "IBM862");
						Eyf.Z.H("CP862", "IBM862");
						Eyf.Z.H("IBM862", "IBM862");
						Eyf.Z.H("862", "IBM862");
						Eyf.Z.H("CSPC862LATINHEBREW", "IBM862");
						Eyf.Z.H("IBM-862", "IBM862");
						Eyf.Z.H("CSIBM863", "IBM863");
						Eyf.Z.H("IBM-863", "IBM863");
						Eyf.Z.H("IBM863", "IBM863");
						Eyf.Z.H("863", "IBM863");
						Eyf.Z.H("CP863", "IBM863");
						Eyf.Z.H("CSIBM864", "IBM864");
						Eyf.Z.H("IBM-864", "IBM864");
						Eyf.Z.H("IBM864", "IBM864");
						Eyf.Z.H("864", "IBM864");
						Eyf.Z.H("CP864", "IBM864");
						Eyf.Z.H("IBM-865", "IBM865");
						Eyf.Z.H("CSIBM865", "IBM865");
						Eyf.Z.H("CP865", "IBM865");
						Eyf.Z.H("IBM865", "IBM865");
						Eyf.Z.H("865", "IBM865");
						Eyf.Z.H("IBM866", "IBM866");
						Eyf.Z.H("866", "IBM866");
						Eyf.Z.H("IBM-866", "IBM866");
						Eyf.Z.H("CSIBM866", "IBM866");
						Eyf.Z.H("CP866", "IBM866");
						Eyf.Z.H("IBM868", "IBM868");
						Eyf.Z.H("868", "IBM868");
						Eyf.Z.H("CP868", "IBM868");
						Eyf.Z.H("CSIBM868", "IBM868");
						Eyf.Z.H("IBM-868", "IBM868");
						Eyf.Z.H("CP-AR", "IBM868");
						Eyf.Z.H("CP869", "IBM869");
						Eyf.Z.H("IBM869", "IBM869");
						Eyf.Z.H("869", "IBM869");
						Eyf.Z.H("IBM-869", "IBM869");
						Eyf.Z.H("CP-GR", "IBM869");
						Eyf.Z.H("CSIBM869", "IBM869");
						Eyf.Z.H("870", "IBM870");
						Eyf.Z.H("CP870", "IBM870");
						Eyf.Z.H("CSIBM870", "IBM870");
						Eyf.Z.H("IBM-870", "IBM870");
						Eyf.Z.H("IBM870", "IBM870");
						Eyf.Z.H("EBCDIC-CP-ROECE", "IBM870");
						Eyf.Z.H("EBCDIC-CP-YU", "IBM870");
						Eyf.Z.H("IBM871", "IBM871");
						Eyf.Z.H("871", "IBM871");
						Eyf.Z.H("CP871", "IBM871");
						Eyf.Z.H("EBCDIC-CP-IS", "IBM871");
						Eyf.Z.H("CSIBM871", "IBM871");
						Eyf.Z.H("IBM-871", "IBM871");
						Eyf.Z.H("918", "IBM918");
						Eyf.Z.H("IBM-918", "IBM918");
						Eyf.Z.H("EBCDIC-CP-AR2", "IBM918");
						Eyf.Z.H("CP918", "IBM918");
						Eyf.Z.H("CSISO2022CN", "ISO-2022-CN");
						Eyf.Z.H("ISO2022CN", "ISO-2022-CN");
						Eyf.Z.H("CSJISENCODING", "ISO-2022-JP");
						Eyf.Z.H("ISO2022JP", "ISO-2022-JP");
						Eyf.Z.H("JIS_ENCODING", "ISO-2022-JP");
						Eyf.Z.H("JIS", "ISO-2022-JP");
						Eyf.Z.H("CSISO2022JP", "ISO-2022-JP");
						Eyf.Z.H("CSISO2022JP2", "ISO-2022-JP-2");
						Eyf.Z.H("ISO2022JP2", "ISO-2022-JP-2");
						Eyf.Z.H("CSISO2022KR", "ISO-2022-KR");
						Eyf.Z.H("ISO2022KR", "ISO-2022-KR");
						Eyf.Z.H("819", "ISO-8859-1");
						Eyf.Z.H("ISO8859-1", "ISO-8859-1");
						Eyf.Z.H("L1", "ISO-8859-1");
						Eyf.Z.H("ISO_8859-1:1987", "ISO-8859-1");
						Eyf.Z.H("ISO_8859-1", "ISO-8859-1");
						Eyf.Z.H("8859_1", "ISO-8859-1");
						Eyf.Z.H("ISO-IR-100", "ISO-8859-1");
						Eyf.Z.H("LATIN1", "ISO-8859-1");
						Eyf.Z.H("CP819", "ISO-8859-1");
						Eyf.Z.H("ISO8859_1", "ISO-8859-1");
						Eyf.Z.H("IBM819", "ISO-8859-1");
						Eyf.Z.H("ISO_8859_1", "ISO-8859-1");
						Eyf.Z.H("IBM-819", "ISO-8859-1");
						Eyf.Z.H("CSISOLATIN1", "ISO-8859-1");
						Eyf.Z.H("ISO_8859-13", "ISO-8859-13");
						Eyf.Z.H("ISO8859-13", "ISO-8859-13");
						Eyf.Z.H("ISO8859_13", "ISO-8859-13");
						Eyf.Z.H("8859_13", "ISO-8859-13");
						Eyf.Z.H("ISO8859-15", "ISO-8859-15");
						Eyf.Z.H("LATIN0", "ISO-8859-15");
						Eyf.Z.H("ISO8859_15_FDIS", "ISO-8859-15");
						Eyf.Z.H("ISO8859_15", "ISO-8859-15");
						Eyf.Z.H("CP923", "ISO-8859-15");
						Eyf.Z.H("8859_15", "ISO-8859-15");
						Eyf.Z.H("L9", "ISO-8859-15");
						Eyf.Z.H("ISO-8859-15", "ISO-8859-15");
						Eyf.Z.H("IBM923", "ISO-8859-15");
						Eyf.Z.H("CSISOLATIN9", "ISO-8859-15");
						Eyf.Z.H("ISO_8859-15", "ISO-8859-15");
						Eyf.Z.H("IBM-923", "ISO-8859-15");
						Eyf.Z.H("CSISOLATIN0", "ISO-8859-15");
						Eyf.Z.H("923", "ISO-8859-15");
						Eyf.Z.H("LATIN9", "ISO-8859-15");
						Eyf.Z.H("ISO8859-2", "ISO-8859-2");
						Eyf.Z.H("IBM912", "ISO-8859-2");
						Eyf.Z.H("L2", "ISO-8859-2");
						Eyf.Z.H("ISO_8859-2", "ISO-8859-2");
						Eyf.Z.H("8859_2", "ISO-8859-2");
						Eyf.Z.H("CP912", "ISO-8859-2");
						Eyf.Z.H("ISO_8859-2:1987", "ISO-8859-2");
						Eyf.Z.H("ISO8859_2", "ISO-8859-2");
						Eyf.Z.H("ISO-IR-101", "ISO-8859-2");
						Eyf.Z.H("LATIN2", "ISO-8859-2");
						Eyf.Z.H("912", "ISO-8859-2");
						Eyf.Z.H("CSISOLATIN2", "ISO-8859-2");
						Eyf.Z.H("IBM-912", "ISO-8859-2");
						Eyf.Z.H("ISO8859-3", "ISO-8859-3");
						Eyf.Z.H("IBM913", "ISO-8859-3");
						Eyf.Z.H("8859_3", "ISO-8859-3");
						Eyf.Z.H("L3", "ISO-8859-3");
						Eyf.Z.H("CP913", "ISO-8859-3");
						Eyf.Z.H("ISO_8859-3", "ISO-8859-3");
						Eyf.Z.H("ISO8859_3", "ISO-8859-3");
						Eyf.Z.H("LATIN3", "ISO-8859-3");
						Eyf.Z.H("CSISOLATIN3", "ISO-8859-3");
						Eyf.Z.H("913", "ISO-8859-3");
						Eyf.Z.H("ISO_8859-3:1988", "ISO-8859-3");
						Eyf.Z.H("IBM-913", "ISO-8859-3");
						Eyf.Z.H("ISO-IR-109", "ISO-8859-3");
						Eyf.Z.H("8859_4", "ISO-8859-4");
						Eyf.Z.H("LATIN4", "ISO-8859-4");
						Eyf.Z.H("L4", "ISO-8859-4");
						Eyf.Z.H("CP914", "ISO-8859-4");
						Eyf.Z.H("ISO_8859-4:1988", "ISO-8859-4");
						Eyf.Z.H("IBM914", "ISO-8859-4");
						Eyf.Z.H("ISO_8859-4", "ISO-8859-4");
						Eyf.Z.H("ISO-IR-110", "ISO-8859-4");
						Eyf.Z.H("ISO8859_4", "ISO-8859-4");
						Eyf.Z.H("CSISOLATIN4", "ISO-8859-4");
						Eyf.Z.H("ISO8859-4", "ISO-8859-4");
						Eyf.Z.H("914", "ISO-8859-4");
						Eyf.Z.H("IBM-914", "ISO-8859-4");
						Eyf.Z.H("ISO_8859-5:1988", "ISO-8859-5");
						Eyf.Z.H("CSISOLATINCYRILLIC", "ISO-8859-5");
						Eyf.Z.H("ISO-IR-144", "ISO-8859-5");
						Eyf.Z.H("ISO8859_5", "ISO-8859-5");
						Eyf.Z.H("CP915", "ISO-8859-5");
						Eyf.Z.H("8859_5", "ISO-8859-5");
						Eyf.Z.H("IBM-915", "ISO-8859-5");
						Eyf.Z.H("ISO_8859-5", "ISO-8859-5");
						Eyf.Z.H("IBM915", "ISO-8859-5");
						Eyf.Z.H("915", "ISO-8859-5");
						Eyf.Z.H("CYRILLIC", "ISO-8859-5");
						Eyf.Z.H("ISO8859-5", "ISO-8859-5");
						Eyf.Z.H("ASMO-708", "ISO-8859-6");
						Eyf.Z.H("8859_6", "ISO-8859-6");
						Eyf.Z.H("ISO8859_6", "ISO-8859-6");
						Eyf.Z.H("ISO_8859-6", "ISO-8859-6");
						Eyf.Z.H("CSISOLATINARABIC", "ISO-8859-6");
						Eyf.Z.H("IBM1089", "ISO-8859-6");
						Eyf.Z.H("ARABIC", "ISO-8859-6");
						Eyf.Z.H("IBM-1089", "ISO-8859-6");
						Eyf.Z.H("1089", "ISO-8859-6");
						Eyf.Z.H("ECMA-114", "ISO-8859-6");
						Eyf.Z.H("ISO-IR-127", "ISO-8859-6");
						Eyf.Z.H("ISO_8859-6:1987", "ISO-8859-6");
						Eyf.Z.H("ISO8859-6", "ISO-8859-6");
						Eyf.Z.H("CP1089", "ISO-8859-6");
						Eyf.Z.H("GREEK", "ISO-8859-7");
						Eyf.Z.H("8859_7", "ISO-8859-7");
						Eyf.Z.H("GREEK8", "ISO-8859-7");
						Eyf.Z.H("IBM813", "ISO-8859-7");
						Eyf.Z.H("ISO_8859-7", "ISO-8859-7");
						Eyf.Z.H("ISO8859_7", "ISO-8859-7");
						Eyf.Z.H("ELOT_928", "ISO-8859-7");
						Eyf.Z.H("CP813", "ISO-8859-7");
						Eyf.Z.H("ISO_8859-7:1987", "ISO-8859-7");
						Eyf.Z.H("SUN_EU_GREEK", "ISO-8859-7");
						Eyf.Z.H("CSISOLATINGREEK", "ISO-8859-7");
						Eyf.Z.H("ISO-IR-126", "ISO-8859-7");
						Eyf.Z.H("813", "ISO-8859-7");
						Eyf.Z.H("ISO8859-7", "ISO-8859-7");
						Eyf.Z.H("ECMA-118", "ISO-8859-7");
						Eyf.Z.H("IBM-813", "ISO-8859-7");
						Eyf.Z.H("8859_8", "ISO-8859-8");
						Eyf.Z.H("ISO_8859-8", "ISO-8859-8");
						Eyf.Z.H("ISO_8859-8:1988", "ISO-8859-8");
						Eyf.Z.H("CP916", "ISO-8859-8");
						Eyf.Z.H("ISO-IR-138", "ISO-8859-8");
						Eyf.Z.H("ISO8859-8", "ISO-8859-8");
						Eyf.Z.H("HEBREW", "ISO-8859-8");
						Eyf.Z.H("ISO8859_8", "ISO-8859-8");
						Eyf.Z.H("IBM-916", "ISO-8859-8");
						Eyf.Z.H("CSISOLATINHEBREW", "ISO-8859-8");
						Eyf.Z.H("916", "ISO-8859-8");
						Eyf.Z.H("IBM916", "ISO-8859-8");
						Eyf.Z.H("IBM-920", "ISO-8859-9");
						Eyf.Z.H("ISO_8859-9", "ISO-8859-9");
						Eyf.Z.H("8859_9", "ISO-8859-9");
						Eyf.Z.H("ISO_8859-9:1989", "ISO-8859-9");
						Eyf.Z.H("IBM920", "ISO-8859-9");
						Eyf.Z.H("LATIN5", "ISO-8859-9");
						Eyf.Z.H("L5", "ISO-8859-9");
						Eyf.Z.H("ISO8859_9", "ISO-8859-9");
						Eyf.Z.H("CP920", "ISO-8859-9");
						Eyf.Z.H("920", "ISO-8859-9");
						Eyf.Z.H("ISO-IR-148", "ISO-8859-9");
						Eyf.Z.H("ISO8859-9", "ISO-8859-9");
						Eyf.Z.H("CSISOLATIN5", "ISO-8859-9");
						Eyf.Z.H("JIS0201", "JIS_X0201");
						Eyf.Z.H("CSHALFWIDTHKATAKANA", "JIS_X0201");
						Eyf.Z.H("X0201", "JIS_X0201");
						Eyf.Z.H("JIS_X0201", "JIS_X0201");
						Eyf.Z.H("JIS0212", "EUC-JP");
						Eyf.Z.H("ISO-IR-159", "EUC-JP");
						Eyf.Z.H("X0212", "EUC-JP");
						Eyf.Z.H("JIS_X0212-1990", "EUC-JP");
						Eyf.Z.H("CSISO159JISX02121990", "EUC-JP");
						Eyf.Z.H("KOI8_R", "KOI8-R");
						Eyf.Z.H("KOI8", "KOI8-R");
						Eyf.Z.H("CSKOI8R", "KOI8-R");
						Eyf.Z.H("KOI8_U", "KOI8-U");
						Eyf.Z.H("SHIFT_JIS", "Shift_JIS");
						Eyf.Z.H("X-SJIS", "Shift_JIS");
						Eyf.Z.H("SJIS", "Shift_JIS");
						Eyf.Z.H("SHIFT-JIS", "Shift_JIS");
						Eyf.Z.H("MS_KANJI", "Shift_JIS");
						Eyf.Z.H("CSSHIFTJIS", "Shift_JIS");
						Eyf.Z.H("TIS620", "TIS-620");
						Eyf.Z.H("TIS620.2533", "TIS-620");
						Eyf.Z.H("ANSI_X3.4-1968", "US-ASCII");
						Eyf.Z.H("CP367", "US-ASCII");
						Eyf.Z.H("CSASCII", "US-ASCII");
						Eyf.Z.H("ISO-IR-6", "US-ASCII");
						Eyf.Z.H("ASCII", "US-ASCII");
						Eyf.Z.H("ISO_646.IRV:1983", "US-ASCII");
						Eyf.Z.H("ANSI_X3.4-1986", "US-ASCII");
						Eyf.Z.H("ASCII7", "US-ASCII");
						Eyf.Z.H("DEFAULT", "US-ASCII");
						Eyf.Z.H("ISO_646.IRV:1991", "US-ASCII");
						Eyf.Z.H("ISO646-US", "US-ASCII");
						Eyf.Z.H("IBM367", "US-ASCII");
						Eyf.Z.H("646", "US-ASCII");
						Eyf.Z.H("US", "US-ASCII");
						Eyf.Z.H("UTF_16", "UTF-16");
						Eyf.Z.H("UNICODE", "UTF-16");
						Eyf.Z.H("UTF16", "UTF-16");
						Eyf.Z.H("UNICODEBIG", "UTF-16");
						Eyf.Z.H("X-UTF-16BE", "UTF-16BE");
						Eyf.Z.H("UTF_16BE", "UTF-16BE");
						Eyf.Z.H("ISO-10646-UCS-2", "UTF-16BE");
						Eyf.Z.H("UNICODEBIGUNMARKED", "UTF-16BE");
						Eyf.Z.H("UNICODELITTLEUNMARKED", "UTF-16LE");
						Eyf.Z.H("UTF_16LE", "UTF-16LE");
						Eyf.Z.H("X-UTF-16LE", "UTF-16LE");
						Eyf.Z.H("UTF_32", "UTF-32");
						Eyf.Z.H("UTF32", "UTF-32");
						Eyf.Z.H("X-UTF-32BE", "UTF-32BE");
						Eyf.Z.H("UTF_32BE", "UTF-32BE");
						Eyf.Z.H("X-UTF-32LE", "UTF-32LE");
						Eyf.Z.H("UTF_32LE", "UTF-32LE");
						Eyf.Z.H("UNICODE-1-1-UTF-8", "UTF-8");
						Eyf.Z.H("UTF8", "UTF-8");
						Eyf.Z.H("CP1250", "windows-1250");
						Eyf.Z.H("CP5346", "windows-1250");
						Eyf.Z.H("CP5347", "windows-1251");
						Eyf.Z.H("ANSI-1251", "windows-1251");
						Eyf.Z.H("CP1251", "windows-1251");
						Eyf.Z.H("CP5348", "windows-1252");
						Eyf.Z.H("CP1252", "windows-1252");
						Eyf.Z.H("CP1253", "windows-1253");
						Eyf.Z.H("CP5349", "windows-1253");
						Eyf.Z.H("CP1254", "windows-1254");
						Eyf.Z.H("CP5350", "windows-1254");
						Eyf.Z.H("CP1255", "windows-1255");
						Eyf.Z.H("CP1256", "windows-1256");
						Eyf.Z.H("CP1257", "windows-1257");
						Eyf.Z.H("CP5353", "windows-1257");
						Eyf.Z.H("CP1258", "windows-1258");
						Eyf.Z.H("MS932", "windows-31j");
						Eyf.Z.H("WINDOWS-932", "windows-31j");
						Eyf.Z.H("CSWINDOWS31J", "windows-31j");
						Eyf.Z.H("BIG5_HKSCS_2001", "x-Big5-HKSCS-2001");
						Eyf.Z.H("BIG5-HKSCS-2001", "x-Big5-HKSCS-2001");
						Eyf.Z.H("BIG5HK-2001", "x-Big5-HKSCS-2001");
						Eyf.Z.H("BIG5-HKSCS:UNICODE3.0", "x-Big5-HKSCS-2001");
						Eyf.Z.H("BIG5HKSCS-2001", "x-Big5-HKSCS-2001");
						Eyf.Z.H("BIG5_SOLARIS", "x-Big5-Solaris");
						Eyf.Z.H("EUC_JP_LINUX", "x-euc-jp-linux");
						Eyf.Z.H("EUC-JP-LINUX", "x-euc-jp-linux");
						Eyf.Z.H("EUCTW", "x-EUC-TW");
						Eyf.Z.H("CNS11643", "x-EUC-TW");
						Eyf.Z.H("EUC-TW", "x-EUC-TW");
						Eyf.Z.H("EUC_TW", "x-EUC-TW");
						Eyf.Z.H("EUCJP-OPEN", "x-eucJP-Open");
						Eyf.Z.H("EUC_JP_SOLARIS", "x-eucJP-Open");
						Eyf.Z.H("IBM1006", "x-IBM1006");
						Eyf.Z.H("IBM-1006", "x-IBM1006");
						Eyf.Z.H("1006", "x-IBM1006");
						Eyf.Z.H("CP1006", "x-IBM1006");
						Eyf.Z.H("IBM-1025", "x-IBM1025");
						Eyf.Z.H("1025", "x-IBM1025");
						Eyf.Z.H("CP1025", "x-IBM1025");
						Eyf.Z.H("IBM1025", "x-IBM1025");
						Eyf.Z.H("IBM1046", "x-IBM1046");
						Eyf.Z.H("IBM-1046", "x-IBM1046");
						Eyf.Z.H("1046", "x-IBM1046");
						Eyf.Z.H("CP1046", "x-IBM1046");
						Eyf.Z.H("IBM1097", "x-IBM1097");
						Eyf.Z.H("IBM-1097", "x-IBM1097");
						Eyf.Z.H("1097", "x-IBM1097");
						Eyf.Z.H("CP1097", "x-IBM1097");
						Eyf.Z.H("IBM-1098", "x-IBM1098");
						Eyf.Z.H("1098", "x-IBM1098");
						Eyf.Z.H("CP1098", "x-IBM1098");
						Eyf.Z.H("IBM1098", "x-IBM1098");
						Eyf.Z.H("IBM1112", "x-IBM1112");
						Eyf.Z.H("IBM-1112", "x-IBM1112");
						Eyf.Z.H("1112", "x-IBM1112");
						Eyf.Z.H("CP1112", "x-IBM1112");
						Eyf.Z.H("CP1122", "x-IBM1122");
						Eyf.Z.H("IBM1122", "x-IBM1122");
						Eyf.Z.H("IBM-1122", "x-IBM1122");
						Eyf.Z.H("1122", "x-IBM1122");
						Eyf.Z.H("IBM1123", "x-IBM1123");
						Eyf.Z.H("IBM-1123", "x-IBM1123");
						Eyf.Z.H("1123", "x-IBM1123");
						Eyf.Z.H("CP1123", "x-IBM1123");
						Eyf.Z.H("IBM-1124", "x-IBM1124");
						Eyf.Z.H("1124", "x-IBM1124");
						Eyf.Z.H("CP1124", "x-IBM1124");
						Eyf.Z.H("IBM1124", "x-IBM1124");
						Eyf.Z.H("CP1166", "x-IBM1166");
						Eyf.Z.H("IBM1166", "x-IBM1166");
						Eyf.Z.H("IBM-1166", "x-IBM1166");
						Eyf.Z.H("1166", "x-IBM1166");
						Eyf.Z.H("CP1364", "x-IBM1364");
						Eyf.Z.H("IBM1364", "x-IBM1364");
						Eyf.Z.H("IBM-1364", "x-IBM1364");
						Eyf.Z.H("1364", "x-IBM1364");
						Eyf.Z.H("CP1381", "x-IBM1381");
						Eyf.Z.H("IBM-1381", "x-IBM1381");
						Eyf.Z.H("1381", "x-IBM1381");
						Eyf.Z.H("IBM1381", "x-IBM1381");
						Eyf.Z.H("IBM1383", "x-IBM1383");
						Eyf.Z.H("IBM-1383", "x-IBM1383");
						Eyf.Z.H("1383", "x-IBM1383");
						Eyf.Z.H("CP1383", "x-IBM1383");
						Eyf.Z.H("CP300", "x-IBM300");
						Eyf.Z.H("IBM300", "x-IBM300");
						Eyf.Z.H("300", "x-IBM300");
						Eyf.Z.H("IBM-300", "x-IBM300");
						Eyf.Z.H("33722", "x-IBM33722");
						Eyf.Z.H("IBM-33722", "x-IBM33722");
						Eyf.Z.H("CP33722", "x-IBM33722");
						Eyf.Z.H("IBM33722", "x-IBM33722");
						Eyf.Z.H("IBM-5050", "x-IBM33722");
						Eyf.Z.H("IBM-33722_VASCII_VPUA", "x-IBM33722");
						Eyf.Z.H("CP737", "ibm737");
						Eyf.Z.H("IBM737", "ibm737");
						Eyf.Z.H("737", "ibm737");
						Eyf.Z.H("IBM-737", "ibm737");
						Eyf.Z.H("IBM833", "x-IBM833");
						Eyf.Z.H("CP833", "x-IBM833");
						Eyf.Z.H("IBM-833", "x-IBM833");
						Eyf.Z.H("IBM834", "x-IBM834");
						Eyf.Z.H("834", "x-IBM834");
						Eyf.Z.H("CP834", "x-IBM834");
						Eyf.Z.H("IBM-834", "x-IBM834");
						Eyf.Z.H("IBM856", "x-IBM856");
						Eyf.Z.H("856", "x-IBM856");
						Eyf.Z.H("CP856", "x-IBM856");
						Eyf.Z.H("IBM-856", "x-IBM856");
						Eyf.Z.H("IBM-874", "x-IBM874");
						Eyf.Z.H("IBM874", "x-IBM874");
						Eyf.Z.H("874", "x-IBM874");
						Eyf.Z.H("CP874", "x-IBM874");
						Eyf.Z.H("IBM-875", "x-IBM875");
						Eyf.Z.H("IBM875", "x-IBM875");
						Eyf.Z.H("875", "x-IBM875");
						Eyf.Z.H("CP875", "x-IBM875");
						Eyf.Z.H("IBM921", "x-IBM921");
						Eyf.Z.H("921", "x-IBM921");
						Eyf.Z.H("IBM-921", "x-IBM921");
						Eyf.Z.H("CP921", "x-IBM921");
						Eyf.Z.H("IBM922", "x-IBM922");
						Eyf.Z.H("922", "x-IBM922");
						Eyf.Z.H("CP922", "x-IBM922");
						Eyf.Z.H("IBM-922", "x-IBM922");
						Eyf.Z.H("IBM-930", "x-IBM930");
						Eyf.Z.H("IBM930", "x-IBM930");
						Eyf.Z.H("930", "x-IBM930");
						Eyf.Z.H("CP930", "x-IBM930");
						Eyf.Z.H("IBM933", "x-IBM933");
						Eyf.Z.H("933", "x-IBM933");
						Eyf.Z.H("CP933", "x-IBM933");
						Eyf.Z.H("IBM-933", "x-IBM933");
						Eyf.Z.H("CP935", "x-IBM935");
						Eyf.Z.H("IBM935", "x-IBM935");
						Eyf.Z.H("935", "x-IBM935");
						Eyf.Z.H("IBM-935", "x-IBM935");
						Eyf.Z.H("IBM-937", "x-IBM937");
						Eyf.Z.H("IBM937", "x-IBM937");
						Eyf.Z.H("937", "x-IBM937");
						Eyf.Z.H("CP937", "x-IBM937");
						Eyf.Z.H("IBM-939", "x-IBM939");
						Eyf.Z.H("CP939", "x-IBM939");
						Eyf.Z.H("IBM939", "x-IBM939");
						Eyf.Z.H("939", "x-IBM939");
						Eyf.Z.H("IBM-942", "x-IBM942");
						Eyf.Z.H("CP942", "x-IBM942");
						Eyf.Z.H("IBM942", "x-IBM942");
						Eyf.Z.H("942", "x-IBM942");
						Eyf.Z.H("IBM942C", "x-IBM942C");
						Eyf.Z.H("CP942C", "x-IBM942C");
						Eyf.Z.H("IBM-942C", "x-IBM942C");
						Eyf.Z.H("942C", "x-IBM942C");
						Eyf.Z.H("IBM943", "x-IBM943");
						Eyf.Z.H("943", "x-IBM943");
						Eyf.Z.H("IBM-943", "x-IBM943");
						Eyf.Z.H("CP943", "x-IBM943");
						Eyf.Z.H("943C", "x-IBM943C");
						Eyf.Z.H("CP943C", "x-IBM943C");
						Eyf.Z.H("IBM943C", "x-IBM943C");
						Eyf.Z.H("IBM-943C", "x-IBM943C");
						Eyf.Z.H("IBM-948", "x-IBM948");
						Eyf.Z.H("IBM948", "x-IBM948");
						Eyf.Z.H("948", "x-IBM948");
						Eyf.Z.H("CP948", "x-IBM948");
						Eyf.Z.H("IBM-949", "x-IBM949");
						Eyf.Z.H("IBM949", "x-IBM949");
						Eyf.Z.H("949", "x-IBM949");
						Eyf.Z.H("CP949", "x-IBM949");
						Eyf.Z.H("IBM949C", "x-IBM949C");
						Eyf.Z.H("IBM-949C", "x-IBM949C");
						Eyf.Z.H("CP949C", "x-IBM949C");
						Eyf.Z.H("949C", "x-IBM949C");
						Eyf.Z.H("CP950", "x-IBM950");
						Eyf.Z.H("IBM950", "x-IBM950");
						Eyf.Z.H("950", "x-IBM950");
						Eyf.Z.H("IBM-950", "x-IBM950");
						Eyf.Z.H("IBM-964", "x-IBM964");
						Eyf.Z.H("CP964", "x-IBM964");
						Eyf.Z.H("IBM964", "x-IBM964");
						Eyf.Z.H("964", "x-IBM964");
						Eyf.Z.H("IBM970", "x-IBM970");
						Eyf.Z.H("IBM-EUCKR", "x-IBM970");
						Eyf.Z.H("970", "x-IBM970");
						Eyf.Z.H("CP970", "x-IBM970");
						Eyf.Z.H("IBM-970", "x-IBM970");
						Eyf.Z.H("ISCII91", "x-ISCII91");
						Eyf.Z.H("ISO-IR-153", "x-ISCII91");
						Eyf.Z.H("ISCII", "x-ISCII91");
						Eyf.Z.H("ST_SEV_358-88", "x-ISCII91");
						Eyf.Z.H("CSISO153GOST1976874", "x-ISCII91");
						Eyf.Z.H("ISO2022CN_CNS", "x-ISO-2022-CN-CNS");
						Eyf.Z.H("ISO-2022-CN-CNS", "x-ISO-2022-CN-CNS");
						Eyf.Z.H("ISO2022CN_GB", "x-ISO-2022-CN-GB");
						Eyf.Z.H("ISO-2022-CN-GB", "x-ISO-2022-CN-GB");
						Eyf.Z.H("ISO-8859-11", "x-iso-8859-11");
						Eyf.Z.H("ISO8859_11", "x-iso-8859-11");
						Eyf.Z.H("JIS0208", "EUC-JP");
						Eyf.Z.H("JIS_C6226-1983", "EUC-JP");
						Eyf.Z.H("ISO-IR-87", "EUC-JP");
						Eyf.Z.H("X0208", "EUC-JP");
						Eyf.Z.H("JIS_X0208-1983", "EUC-JP");
						Eyf.Z.H("CSISO87JISX0208", "EUC-JP");
						Eyf.Z.H("JISAUTODETECT", "x-JISAutoDetect");
						Eyf.Z.H("MS1361", "Johab");
						Eyf.Z.H("KSC5601_1992", "Johab");
						Eyf.Z.H("KSC5601-1992", "Johab");
						Eyf.Z.H("MACARABIC", "x-mac-arabic");
						Eyf.Z.H("MACCENTRALEUROPE", "x-mac-ce");
						Eyf.Z.H("MACCROATIAN", "x-mac-croatian");
						Eyf.Z.H("MACCYRILLIC", "x-mac-cyrillic");
						Eyf.Z.H("MACDINGBAT", "x-mac-dingbat");
						Eyf.Z.H("MACGREEK", "x-mac-greek");
						Eyf.Z.H("MACHEBREW", "x-mac-hebrew");
						Eyf.Z.H("MACICELAND", "x-mac-icelandic");
						Eyf.Z.H("MACROMAN", "x-mac-roman");
						Eyf.Z.H("MACROMANIA", "x-mac-romanian");
						Eyf.Z.H("MACSYMBOL", "x-mac-symbol");
						Eyf.Z.H("MACTHAI", "x-mac-thai");
						Eyf.Z.H("MACTURKISH", "x-mac-turkish");
						Eyf.Z.H("MACUKRAINE", "x-mac-ukrainian");
						Eyf.Z.H("MS950_HKSCS", "x-MS950-HKSCS");
						Eyf.Z.H("MS950_HKSCS_XP", "x-MS950-HKSCS-XP");
						Eyf.Z.H("MS936", "x-mswin-936");
						Eyf.Z.H("MS_936", "x-mswin-936");
						Eyf.Z.H("PCK", "x-PCK");
						Eyf.Z.H("UNICODELITTLE", "x-UTF-16LE-BOM");
						Eyf.Z.H("UTF_32BE_BOM", "X-UTF-32BE-BOM");
						Eyf.Z.H("UTF-32BE-BOM", "X-UTF-32BE-BOM");
						Eyf.Z.H("UTF_32LE_BOM", "X-UTF-32LE-BOM");
						Eyf.Z.H("UTF-32LE-BOM", "X-UTF-32LE-BOM");
						Eyf.Z.H("CP50220", "iso-2022-jp");
						Eyf.Z.H("MS50220", "iso-2022-jp");
						Eyf.Z.H("CP50221", "csISO2022JP");
						Eyf.Z.H("MS50221", "csISO2022JP");
						Eyf.Z.H("MS-874", "windows-874");
						Eyf.Z.H("MS874", "windows-874");
						Eyf.Z.H("WINDOWS949", "ks_c_5601-1987");
						Eyf.Z.H("MS949", "ks_c_5601-1987");
						Eyf.Z.H("WINDOWS-949", "ks_c_5601-1987");
						Eyf.Z.H("MS_949", "ks_c_5601-1987");
						Eyf.Z.H("MS950", "big5");
						Eyf.Z.H("WINDOWS-950", "big5");
						Eyf.Z.H("WINDOWS-ISO2022JP", "x-windows-iso2022jp");
						Eyf.Gy = true;
					}
					goto IL_0007;
				}
				goto IL_3BF0;
			}
			IL_0007:
			string text = Eyf.Dn(string_0);
			if (Eyf.Z.ContainsKey(text))
			{
				return Eyf.Z.m(text);
			}
			IL_3BF0:
			return string_0;
		}

		// Token: 0x0601160F RID: 71183 RVA: 0x006A4F90 File Offset: 0x006A3190
		public static string re(string string_0)
		{
			string_0 = Eyf.mZ(Eyf.UO(string_0, "_"), "[^-.0-9\\u00B7\\u0300-\\u036F\\u203F-\\u2040_a-zA-Z\\u00C0-\\u00D6\\u00D8-\\u00F6\\u00F8-\\u200FF\\u0370-\\u037D\\u037F-\\u1FFF\\u200C-\\u200D\\u2070-\\u218F\\u2C00-\\u2FEF\\u3001-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFFD]", "_");
			string_0 = ((!string_0.StartsWith(Eyf.mZ(lcP.IZ(string_0, 0, 1), "[^_a-zA-Z\\u00C0-\\u00D6\\u00D8-\\u00F6\\u00F8-\\u02FF\\u0370-\\u037D\\u037F-\\u1FFF\\u200C-\\u200D\\u2070-\\u218F\\u2C00-\\u2FEF\\u3001-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFFD]", "_"))) ? ("_" + string_0) : string_0);
			return (!string_0.EndsWith(":")) ? string_0 : (lcP.IZ(string_0, 0, string_0.Length - 1) + "_");
		}

		// Token: 0x06011610 RID: 71184 RVA: 0x006A5018 File Offset: 0x006A3218
		public static string rt(string string_0, lyZ lyZ_0)
		{
			string text2;
			if (!Eyf.lx(string_0))
			{
				int num = 0;
				bool flag = false;
				lcc lcc = new lcc();
				lcc lcc2 = new lcc();
				for (int i = 0; i < string_0.Length; i++)
				{
					char c = string_0[i];
					char c2 = c;
					if (c2 != ' ')
					{
						if (c2 != '$')
						{
							switch (c2)
							{
							case '{':
								if (num == 1)
								{
									flag = true;
									num = 3;
								}
								break;
							case '}':
								if (!flag)
								{
									throw new RSBException("Utilities.ReplaceVariables", "Parsing error, Index:" + i + ".");
								}
								if (num == 2)
								{
									flag = false;
									num = 4;
								}
								break;
							}
						}
						else
						{
							if (num != 0)
							{
								throw new RSBException("Utilities.ReplaceVariables", "Parsing error, Index:" + i + ".");
							}
							num = 1;
						}
					}
					else if (num == 2 && !flag)
					{
						num = 3;
					}
					if (num == 0)
					{
						lcc2.MPI(c);
					}
					else if (num != 2)
					{
						if (num != 3)
						{
							if (num == 4)
							{
								string text = Eyf.Dh(lcc.ToString());
								if (!lyZ_0.ContainsKey(text))
								{
									throw new RSBException("Utilities.ReplaceVariables", "Parsing error. The '" + text + "' variable is not found.");
								}
								lcc2.MPI(lyZ_0.G(text));
								lcc.j(0);
								num = 0;
							}
						}
						else
						{
							num = 2;
						}
					}
					else
					{
						lcc.MPI(c);
					}
				}
				if (num == 2 || num == 3)
				{
					throw new RSBException("Utilities.ReplaceVariables", "Parsing error.");
				}
				if (flag)
				{
					throw new RSBException("Utilities.ReplaceVariables", "Parsing error.");
				}
				text2 = lcc2.ToString();
			}
			else
			{
				text2 = "";
			}
			return text2;
		}

		// Token: 0x06011611 RID: 71185 RVA: 0x006A521C File Offset: 0x006A341C
		public static string rg(string string_0)
		{
			string text;
			try
			{
				text = new Uri(string_0).Scheme;
			}
			catch (Exception)
			{
				text = null;
			}
			return text;
		}

		// Token: 0x06011612 RID: 71186 RVA: 0x006A5250 File Offset: 0x006A3450
		public static string rA(string string_0, bool bool_0)
		{
			string text4;
			try
			{
				if (!Eyf.lx(string_0))
				{
					if (!Eyf.pZ(string_0))
					{
						string text = Eyf.rg(string_0);
						if (!Eyf.UK(text, "http", true))
						{
							string text2 = Eyf.rr(string_0);
							if (text2 == null)
							{
								string text3 = Eyf.VU(Directory.GetCurrentDirectory(), string_0);
								if (!bool_0 || !Eyf.Vx(text3))
								{
									if (!Eyf.pt(text3))
									{
										text4 = Path.Combine(Directory.GetParent(Assembly.GetExecutingAssembly().Location).ToString(), string_0);
									}
									else
									{
										text4 = text3;
									}
								}
								else
								{
									text4 = text3;
								}
							}
							else
							{
								text4 = text2;
							}
						}
						else
						{
							text4 = string_0;
						}
					}
					else
					{
						text4 = string_0;
					}
				}
				else
				{
					text4 = string_0;
				}
			}
			catch (Exception)
			{
				text4 = null;
			}
			return text4;
		}

		// Token: 0x06011613 RID: 71187 RVA: 0x000F8BB4 File Offset: 0x000F6DB4
		public static string rr(string string_0)
		{
			return null;
		}

		// Token: 0x06011614 RID: 71188 RVA: 0x006A5314 File Offset: 0x006A3514
		public static string rF(string string_0)
		{
			string text2;
			if (!Eyf.lx(string_0))
			{
				if (string_0.Contains("/") || string_0.Contains("\\"))
				{
					string text = null;
					int i = 0;
					int num = string_0.IndexOf("://");
					if (num > 0)
					{
						i = num + 3;
						text = lcP.IZ(string_0, 0, i);
						if (!Eyf.ht("file://", text))
						{
							return string_0;
						}
					}
					lcc lcc = new lcc(string_0.Length);
					if (text != null)
					{
						lcc.MPI(text);
					}
					char c;
					if (!lya.Q.Equals("\\"))
					{
						c = '/';
					}
					else
					{
						c = '\\';
					}
					while (i < string_0.Length)
					{
						char c2 = string_0[i];
						if (c2 == '/')
						{
							goto IL_0080;
						}
						if (c2 == '\\')
						{
							goto IL_0080;
						}
						bool flag = true;
						IL_0086:
						if (flag)
						{
							lcc.MPI(c2);
						}
						else
						{
							lcc.MPI(c);
						}
						i++;
						continue;
						IL_0080:
						flag = c2 == c;
						goto IL_0086;
					}
					text2 = lcc.ToString();
				}
				else
				{
					text2 = string_0;
				}
			}
			else
			{
				text2 = string_0;
			}
			return text2;
		}

		// Token: 0x06011615 RID: 71189 RVA: 0x006A5434 File Offset: 0x006A3634
		public static string rK(string string_0)
		{
			string text2;
			if (string_0 != null && string_0.Length > 0)
			{
				string_0 = EyP.s(string_0);
				if (string_0[0] == '~')
				{
					string text = Eyf.rr(string_0);
					if (text != null)
					{
						string_0 = text;
					}
				}
				text2 = string_0;
			}
			else
			{
				text2 = string_0;
			}
			return text2;
		}

		// Token: 0x06011616 RID: 71190 RVA: 0x006A548C File Offset: 0x006A368C
		public static string rq(string string_0, string string_1)
		{
			string_0 = string_0.Trim();
			string text = ((!string_0.StartsWith("//")) ? string_0 : lcP.IG(string_0, 2));
			string text2 = text;
			int num = text.IndexOf("=");
			int num2 = text.IndexOf(":");
			int num3 = text.IndexOf("/");
			int num4 = text.IndexOf("?");
			bool flag = num <= -1 || (num2 < num && num2 > -1) || (num3 < num && num3 > -1) || (num4 < num && num4 > -1);
			lcc lcc = null;
			if (flag)
			{
				num = text.IndexOf(";");
				if (num <= -1)
				{
					text2 = "";
					lcc = Eyf.rZ(text, string_1);
				}
				else
				{
					text2 = lcP.IZ(text, num + 1, text.Length);
					lcc = Eyf.rZ(lcP.IZ(text, 0, num), string_1);
				}
			}
			return (lcc == null) ? text2 : (lcc.ToString() + text2);
		}

		// Token: 0x06011617 RID: 71191 RVA: 0x001073D4 File Offset: 0x001055D4
		public static object rS(Type type_0)
		{
			return Activator.CreateInstance(type_0);
		}

		// Token: 0x06011618 RID: 71192 RVA: 0x006A5588 File Offset: 0x006A3788
		private static lcc rZ(string string_0, string string_1)
		{
			lcc lcc = new lcc();
			string text = null;
			int num = string_0.IndexOf("?");
			if (num > -1)
			{
				text = lcP.IG(string_0, num + 1);
				string_0 = lcP.IZ(string_0, 0, num);
			}
			lcc lcc2;
			if (!Eyf.lx(string_1))
			{
				string[] array = Eyf.FB(string_1);
				string[] array2 = Eyf.FB(string_0);
				for (int i = 0; i < array.Length; i++)
				{
					if (!Eyf.lx(array[i]) && !Eyf.lx(array2[i]))
					{
						string text2 = array[i];
						if (text2.StartsWith("${") && text2.EndsWith("}"))
						{
							lcc.MPI(lcP.IZ(text2, 2, text2.Length - 1) + "=" + array2[i] + ";");
						}
					}
				}
				if (!Eyf.lx(text))
				{
					string[] array3 = Eyf.xD(text, false, '&', true, true);
					string[] array4 = array3;
					int j = 0;
					IL_0102:
					while (j < array4.Length)
					{
						string text3 = array4[j];
						string[] array5 = Eyf.xD(text3, false, '=', true, true);
						string text4 = "{" + array5[0].ToLower() + "}";
						bool flag = false;
						for (int k = 0; k < array.Length; k++)
						{
							if (Eyf.ht(array[k], text4))
							{
								flag = true;
								IL_0167:
								if (!flag)
								{
									lcc.MPI(array5[0].ToLower() + "=" + array5[1] + ";");
								}
								j++;
								goto IL_0102;
							}
						}
						goto IL_0167;
					}
				}
				lcc2 = lcc;
			}
			else
			{
				lcc2 = lcc;
			}
			return lcc2;
		}

		// Token: 0x06011619 RID: 71193 RVA: 0x006A5730 File Offset: 0x006A3930
		private static string[] FB(string string_0)
		{
			string text = "";
			string text2 = "";
			string text3 = "";
			int num = string_0.IndexOf("/");
			if (num > -1)
			{
				text3 = lcP.IG(string_0, num + 1).Trim();
				string_0 = lcP.IZ(string_0, 0, num);
			}
			num = string_0.IndexOf(":");
			if (num > -1)
			{
				text2 = lcP.IG(string_0, num + 1).Trim();
				text = lcP.IZ(string_0, 0, num).Trim();
			}
			if (Eyf.lx(text))
			{
				text = string_0.Trim();
			}
			return new string[] { text, text2, text3 };
		}

		// Token: 0x0601161A RID: 71194 RVA: 0x003B5370 File Offset: 0x003B3570
		public static long FV(byte[] byte_0, int int_0, int int_1)
		{
			long num = 0L;
			while (int_1 > 0 && int_0 + int_1 <= byte_0.Length)
			{
				num = (num << 8) | (long)(byte_0[int_0 + int_1 - 1] & byte.MaxValue);
				int_1--;
			}
			return num;
		}

		// Token: 0x0601161B RID: 71195 RVA: 0x003B5444 File Offset: 0x003B3644
		public static void Fp(long long_0, byte[] byte_0, int int_0, int int_1)
		{
			int i = int_0;
			int num = int_0 + int_1;
			while (i < num)
			{
				byte_0[i] = (byte)(long_0 & 255L);
				i++;
				long_0 >>= 8;
			}
		}

		// Token: 0x0601161C RID: 71196 RVA: 0x006A57E8 File Offset: 0x006A39E8
		public static void FD(int int_0, int int_1)
		{
			if (int_0 < 0 || int_0 > 31)
			{
				throw new RSBException("snowflake", "The datacenter id must between 0 and 31.");
			}
			if (int_1 >= 0 && int_1 <= 31)
			{
				if (Eyf.Gs < 0 && Eyf.GM < 0)
				{
					lock (Eyf.Gd)
					{
						if (Eyf.Gs < 0 && Eyf.GM < 0)
						{
							Eyf.Gs = int_0;
							Eyf.GM = int_1;
						}
					}
				}
				return;
			}
			throw new RSBException("snowflake", "The worker id must between 0 and 31.");
		}

		// Token: 0x0601161D RID: 71197 RVA: 0x006A58AC File Offset: 0x006A3AAC
		public static long Fm()
		{
			if (Eyf.Gs < 0)
			{
				goto IL_002A;
			}
			bool flag = true;
			IL_0009:
			if (!flag)
			{
				lock (Eyf.Gd)
				{
					if (Eyf.Gs < 0 && Eyf.GM < 0)
					{
						throw new Exception("The Data Center Id and Worker Id must be set.");
					}
					goto IL_000B;
				}
				long num;
				return num;
			}
			try
			{
				IL_000B:
				return Eyf.Fx(Eyf.Gs, Eyf.GM);
			}
			catch (RSBException ex)
			{
				throw new Exception(Eyf.eD(ex));
			}
			IL_002A:
			flag = Eyf.GM >= 0;
			goto IL_0009;
		}

		// Token: 0x0601161E RID: 71198 RVA: 0x006A5954 File Offset: 0x006A3B54
		public static long Fx(int int_0, int int_1)
		{
			if (int_0 >= 0)
			{
				goto IL_00E2;
			}
			bool flag = false;
			IL_0008:
			if (!flag)
			{
				throw new RSBException("snowflake", "The datacenter id must between 0 and 31.");
			}
			if (int_1 < 0 || int_1 > 31)
			{
				throw new RSBException("snowflake", "The worker id must between 0 and 31.");
			}
			long num = lyc.G();
			lock (Eyf.Gd)
			{
				if (num < Eyf.Go)
				{
					num = Eyf.Go;
					if (Eyf.GX >= 4095)
					{
						num += 1L;
					}
				}
				if (num != Eyf.Go)
				{
					Eyf.GX = 0;
				}
				else
				{
					Eyf.GX++;
					if (Eyf.GX > 4095)
					{
						Eyf.GX = 0;
						while (num == Eyf.Go)
						{
							num = lyc.G();
						}
					}
				}
				Eyf.Go = num;
				return (num - 1546214400000L << 22) | (long)((long)int_0 << 17) | (long)((long)int_1 << 12) | (long)Eyf.GX;
			}
			IL_00E2:
			flag = int_0 <= 31;
			goto IL_0008;
		}

		// Token: 0x0601161F RID: 71199 RVA: 0x006A5A90 File Offset: 0x006A3C90
		public static void Fn<i>(i gparam_0, string string_0, params object[] object_0)
		{
			if (gparam_0 == null)
			{
				throw new NullReferenceException(Eyf.OS("{0} cannot be null.", Eyf.IB(string_0, false, object_0)));
			}
		}

		// Token: 0x06011620 RID: 71200 RVA: 0x006A5AC4 File Offset: 0x006A3CC4
		public static void FO(string string_0, string string_1, params object[] object_0)
		{
			Eyf.Fn<string>(string_0, string_1, object_0);
			if (string_0.Length <= 0)
			{
				throw new ArgumentException(Eyf.OS("{0} cannot be null.", Eyf.IB(string_1, false, object_0)));
			}
		}

		// Token: 0x06011621 RID: 71201 RVA: 0x006A5AFC File Offset: 0x006A3CFC
		public static string Ft(Exception exception_0)
		{
			return Eyf.eD(exception_0) + Eyf.u + Eyf.FA(exception_0);
		}

		// Token: 0x06011622 RID: 71202 RVA: 0x005D8F10 File Offset: 0x005D7110
		public static string FA(Exception exception_0)
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

		// Token: 0x06011623 RID: 71203 RVA: 0x006A5B24 File Offset: 0x006A3D24
		public static lmD<string, string> Fr(string string_0, char char_0, char char_1)
		{
			return Eyf.FK(string_0, char_0, char_1, false);
		}

		// Token: 0x06011624 RID: 71204 RVA: 0x006A5B3C File Offset: 0x006A3D3C
		public static lmD<string, string> FK(string string_0, char char_0, char char_1, bool bool_0)
		{
			return Eyf.FZ(string_0, char_0, char_1, bool_0, false);
		}

		// Token: 0x06011625 RID: 71205 RVA: 0x006A5B58 File Offset: 0x006A3D58
		public static lmD<string, string> FZ(string string_0, char char_0, char char_1, bool bool_0, bool bool_1)
		{
			lmD<string, string> lmD = new lmD<string, string>();
			if (!Eyf.lx(string_0))
			{
				lcc lcc = new lcc();
				string text = "";
				bool flag = false;
				bool flag2 = false;
				bool flag3 = false;
				for (int i = 0; i < string_0.Length; i++)
				{
					char c = string_0[i];
					if (!flag)
					{
						if (c != '\\')
						{
							if (c != '"')
							{
								if (!flag3)
								{
									if (c != char_1 || flag2)
									{
										if (c != char_0)
										{
											lcc.MPI(c);
										}
										else
										{
											string text2 = lcc.ToString().Trim();
											lcc.j(0);
											if (!Eyf.lx(text))
											{
												lmD.H((!bool_0) ? text : Eyf.Dx(text), text2);
											}
											text = "";
											flag2 = false;
										}
									}
									else
									{
										text = lcc.ToString().Trim();
										lcc.j(0);
										flag2 = true;
									}
								}
								else
								{
									lcc.MPI(c);
								}
							}
							else if (lcc.D != 0)
							{
								if (!flag3)
								{
									lcc.MPI(c);
								}
								else
								{
									flag3 = false;
								}
							}
							else
							{
								flag3 = true;
							}
						}
						else if (!flag3)
						{
							flag = true;
						}
						else if (string_0.Length <= i + 1 || string_0[i + 1] != '"')
						{
							lcc.MPI(c);
						}
						else
						{
							flag = true;
						}
					}
					else
					{
						if (bool_1 && c != char_0 && c != char_1 && c != '"')
						{
							lcc.MPI('\\');
						}
						lcc.MPI(c);
						flag = false;
					}
				}
				if (lcc.D > 0 || !Eyf.lx(text))
				{
					string text2;
					if (!Eyf.lx(text))
					{
						text2 = lcc.ToString().Trim();
					}
					else
					{
						text = lcc.ToString().Trim();
						text2 = "";
					}
					if (!Eyf.lx(text))
					{
						lmD.H((!bool_0) ? text : Eyf.Dx(text), text2);
					}
				}
			}
			return lmD;
		}

		// Token: 0x06011626 RID: 71206 RVA: 0x006A5D80 File Offset: 0x006A3F80
		public static string KB(lmD<string, string> lmD_0, char char_0, char char_1)
		{
			string text;
			if (lmD_0 == null)
			{
				text = null;
			}
			else
			{
				lcc lcc = new lcc();
				lyh lyh = Eyf.Aq<string, string>(lmD_0);
				while (lyh.MPP())
				{
					string text2 = lyh.MPX().ToString();
					string text3 = Eyf.UO(lmD_0.m(text2), "");
					if (!Eyf.lx(text2))
					{
						text2 = Eyf.OC(text2, "\\", "\\\\");
						text2 = Eyf.OC(text2, string.Concat(char_0), "\\" + char_0);
						text2 = Eyf.OC(text2, string.Concat(char_1), "\\" + char_1);
						text3 = Eyf.OC(text3, "\\", "\\\\");
						text3 = Eyf.OC(text3, string.Concat(char_0), "\\" + char_0);
						lcc.MPI(text2).MPI(char_1).MPI(text3)
							.MPI(char_0)
							.MPI(' ');
					}
				}
				if (lcc.D > 0)
				{
					lcc.j(lcc.D - 1);
				}
				text = lcc.ToString();
			}
			return text;
		}

		// Token: 0x06011627 RID: 71207 RVA: 0x006A5EB4 File Offset: 0x006A40B4
		public static string KJ()
		{
			return Environment.MachineName;
		}

		// Token: 0x040079AF RID: 31151
		private const string y = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_.~";

		// Token: 0x040079B0 RID: 31152
		public const string G = "US-ASCII";

		// Token: 0x040079B1 RID: 31153
		public const string K = "utf-8";

		// Token: 0x040079B2 RID: 31154
		public const string c = "ISO-8859-1";

		// Token: 0x040079B3 RID: 31155
		public const string d = "";

		// Token: 0x040079B4 RID: 31156
		public const string o = "yyyy-MM-dd HH:mm:ss";

		// Token: 0x040079B5 RID: 31157
		private const string X = "yyyyMMddHH-mmss";

		// Token: 0x040079B6 RID: 31158
		private const int s = 1024;

		// Token: 0x040079B7 RID: 31159
		private const int M = 1048576;

		// Token: 0x040079B8 RID: 31160
		private const int f = 1073741824;

		// Token: 0x040079B9 RID: 31161
		public const string q = "Windows";

		// Token: 0x040079BA RID: 31162
		public const string h = "Windows";

		// Token: 0x040079BB RID: 31163
		public const string j = "Unix";

		// Token: 0x040079BC RID: 31164
		public const string t = "Mac";

		// Token: 0x040079BD RID: 31165
		public const string N = "\r";

		// Token: 0x040079BE RID: 31166
		public const string P = "\n";

		// Token: 0x040079BF RID: 31167
		public const string i = "\r\n";

		// Token: 0x040079C0 RID: 31168
		private const string B = "http.service";

		// Token: 0x040079C1 RID: 31169
		private const string R = "file.service";

		// Token: 0x040079C2 RID: 31170
		public static string u = Environment.NewLine;

		// Token: 0x040079C3 RID: 31171
		public static string E = "yyyy-MM-dd'T'HH:mm:ss.fffzzzz";

		// Token: 0x040079C4 RID: 31172
		private static string[] a = new string[] { "k", "kb", "m", "mb", "g", "gb" };

		// Token: 0x040079C5 RID: 31173
		private static int[] v = new int[] { 1024, 1024, 1048576, 1048576, 1073741824, 1073741824 };

		// Token: 0x040079C6 RID: 31174
		public static CultureInfo l = CultureInfo.InvariantCulture;

		// Token: 0x040079C7 RID: 31175
		private static RNGCryptoServiceProvider W = new RNGCryptoServiceProvider();

		// Token: 0x040079C8 RID: 31176
		private static lmD<string, string> Z = new lmD<string, string>();

		// Token: 0x040079C9 RID: 31177
		private static bool Gy = false;

		// Token: 0x040079CA RID: 31178
		private static char[] GG = new char[]
		{
			'0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
			'a', 'b', 'c', 'd', 'e', 'f'
		};

		// Token: 0x040079CB RID: 31179
		private static char[] GK = new char[]
		{
			'0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
			'A', 'B', 'C', 'D', 'E', 'F'
		};

		// Token: 0x040079CC RID: 31180
		private static lmr<string> Gc = new lmr<string>();

		// Token: 0x040079CD RID: 31181
		private static object Gd = new object();

		// Token: 0x040079CE RID: 31182
		private static long Go = 0L;

		// Token: 0x040079CF RID: 31183
		private static int GX = 0;

		// Token: 0x040079D0 RID: 31184
		private static int Gs = -1;

		// Token: 0x040079D1 RID: 31185
		private static int GM = -1;

		// Token: 0x020011A2 RID: 4514
		private sealed class Xr : Comparer<char>
		{
			// Token: 0x0601162A RID: 71210 RVA: 0x006A5FC4 File Offset: 0x006A41C4
			public override int Compare(char x, char y)
			{
				if (x != y)
				{
					if (Eyf.hK(Eyf.AD(), "Windows") && x == '/')
					{
						if (y == '\\')
						{
							goto IL_0006;
						}
					}
					if (x == '\\')
					{
						if (y == '/')
						{
							goto IL_0006;
						}
					}
					return 1;
				}
				IL_0006:
				return 0;
			}
		}
	}
}
