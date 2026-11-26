using System;
using System.Globalization;
using System.Text;

namespace Arc264y
{
	// Token: 0x02000B3F RID: 2879
	internal class lcP : lcu
	{
		// Token: 0x0600DFCB RID: 57291 RVA: 0x0054C5B8 File Offset: 0x0054A7B8
		public static long n()
		{
			return (lyc.G() / 1000L) & 4294967295L;
		}

		// Token: 0x0600DFCC RID: 57292 RVA: 0x0054C5E0 File Offset: 0x0054A7E0
		public static string V(string string_0)
		{
			return (string_0 != null) ? string_0 : lcu.W;
		}

		// Token: 0x0600DFCD RID: 57293 RVA: 0x0054C5FC File Offset: 0x0054A7FC
		public static byte[] K(byte[] byte_0)
		{
			return (byte_0 != null) ? byte_0 : lcu.l;
		}

		// Token: 0x0600DFCE RID: 57294 RVA: 0x0054C5E0 File Offset: 0x0054A7E0
		public static string r(string string_0)
		{
			return (string_0 != null) ? string_0 : lcu.W;
		}

		// Token: 0x0600DFCF RID: 57295 RVA: 0x0054C618 File Offset: 0x0054A818
		public static byte[] st(byte[] byte_0)
		{
			return (byte_0 != null) ? lcP.sI(byte_0, 0, byte_0.Length) : lcu.l;
		}

		// Token: 0x0600DFD0 RID: 57296 RVA: 0x0054C63C File Offset: 0x0054A83C
		public static byte[] ss(byte[] byte_0, int int_0, int int_1)
		{
			byte[] array;
			if (byte_0 != null)
			{
				if (int_0 >= 0)
				{
					if (int_0 > byte_0.Length)
					{
						int_0 = byte_0.Length;
					}
				}
				else
				{
					int_0 = 0;
				}
				if (int_1 < 0)
				{
					int_1 = 0;
				}
				if (int_0 + int_1 > byte_0.Length)
				{
					int_1 = byte_0.Length - int_0;
				}
				array = lcP.sI(byte_0, int_0, int_1);
			}
			else
			{
				array = lcu.l;
			}
			return array;
		}

		// Token: 0x0600DFD1 RID: 57297 RVA: 0x00130CCC File Offset: 0x0012EECC
		private static byte[] sI(byte[] byte_0, int int_0, int int_1)
		{
			byte[] array = new byte[int_1];
			Array.Copy(byte_0, int_0, array, 0, int_1);
			return array;
		}

		// Token: 0x0600DFD2 RID: 57298 RVA: 0x0054C6B4 File Offset: 0x0054A8B4
		internal static byte[] sn(string string_0)
		{
			return (string_0 != null) ? lcP.nr(string_0) : lcu.l;
		}

		// Token: 0x0600DFD3 RID: 57299 RVA: 0x0054C6D4 File Offset: 0x0054A8D4
		internal static string sy(string string_0)
		{
			string text;
			if (string_0 != null && string_0.Length != 0)
			{
				for (int i = string_0.Length - 1; i >= 0; i--)
				{
					if (string_0[i] != '\r' && string_0[i] != '\n')
					{
						return lcP.IZ(string_0, 0, i + 1) + lcu.v;
					}
				}
				text = lcu.W;
			}
			else
			{
				text = lcu.W;
			}
			return text;
		}

		// Token: 0x0600DFD4 RID: 57300 RVA: 0x0054C754 File Offset: 0x0054A954
		internal static string sb(string string_0, string string_1)
		{
			string text = string_0.ToLower();
			string_1 += ": ";
			int num = ((!text.StartsWith(string_1)) ? (text.IndexOf(lcu.v + string_1) + 2) : 0);
			string text2;
			if (num != -1 && num != 1)
			{
				num += string_1.Length;
				lcc lcc = new lcc();
				int num2;
				do
				{
					num2 = text.IndexOf(lcu.v, num);
					lcc.MPI((num2 == -1) ? lcP.IG(string_0, num) : lcP.IZ(string_0, num, num2));
					num = num2 + 2;
				}
				while (num2 != -1 && num2 + 2 < string_0.Length && (string_0[num2 + 2] == ' ' || string_0[num2 + 2] == '\t'));
				text2 = lcc.ToString();
			}
			else
			{
				text2 = lcu.W;
			}
			return text2;
		}

		// Token: 0x0600DFD5 RID: 57301 RVA: 0x001C11D8 File Offset: 0x001BF3D8
		internal static int sa(string string_0)
		{
			int num;
			try
			{
				num = int.Parse(string_0);
			}
			catch (Exception)
			{
				num = 0;
			}
			return num;
		}

		// Token: 0x0600DFD6 RID: 57302 RVA: 0x003B3964 File Offset: 0x003B1B64
		internal static int se(byte[] byte_0, int int_0, int int_1, bool bool_0)
		{
			int num = 0;
			if (bool_0)
			{
				for (int i = 0; i < int_1; i++)
				{
					num |= (int)(byte_0[int_0++] & byte.MaxValue) << 8 * i;
				}
			}
			else
			{
				while (int_1-- > 0)
				{
					num = (num << 8) | (int)(byte_0[int_0++] & byte.MaxValue);
				}
			}
			return num;
		}

		// Token: 0x0600DFD7 RID: 57303 RVA: 0x0054C834 File Offset: 0x0054AA34
		internal static int sm(byte[] byte_0, int int_0, int int_1)
		{
			return lcP.se(byte_0, int_0, int_1, false);
		}

		// Token: 0x0600DFD8 RID: 57304 RVA: 0x003B39E4 File Offset: 0x003B1BE4
		internal static long sV(byte[] byte_0, int int_0, int int_1)
		{
			long num = 0L;
			while (int_1-- > 0)
			{
				num = (num << 8) | (long)(byte_0[int_0++] & byte.MaxValue);
			}
			return num;
		}

		// Token: 0x0600DFD9 RID: 57305 RVA: 0x0054C84C File Offset: 0x0054AA4C
		internal static int sK(string string_0)
		{
			string text = "Invalid argument: could parse a positive integer value from \"" + string_0 + "\".";
			try
			{
				int num = int.Parse(string_0);
				if (num >= 0)
				{
					return num;
				}
			}
			catch (Exception ex)
			{
				text = "Error parsing positive integer: " + ex.Message;
			}
			throw new Exception(text);
		}

		// Token: 0x0600DFDA RID: 57306 RVA: 0x0054C8AC File Offset: 0x0054AAAC
		internal static int sQ(string string_0)
		{
			return int.Parse(string_0.Trim());
		}

		// Token: 0x0600DFDB RID: 57307 RVA: 0x003B3AD4 File Offset: 0x003B1CD4
		internal static byte[] sU(int int_0)
		{
			int num = 4;
			uint num2 = 4278190080U;
			while (num > 1 && ((ulong)num2 & (ulong)((long)int_0)) == 0UL)
			{
				num--;
				num2 >>= 8;
			}
			byte[] array = new byte[num];
			int i = 0;
			while (i < num)
			{
				array[i] = (byte)int_0;
				i++;
				int_0 >>= 8;
			}
			return array;
		}

		// Token: 0x0600DFDC RID: 57308 RVA: 0x003B3B34 File Offset: 0x003B1D34
		internal static byte[] sr(int int_0, int int_1)
		{
			int_1 = Math.Min(int_1, 4);
			byte[] array = new byte[int_1];
			int i = 0;
			while (i < int_1)
			{
				array[int_1 - i++ - 1] = (byte)(int_0 & 255);
				int_0 >>= 8;
			}
			return array;
		}

		// Token: 0x0600DFDD RID: 57309 RVA: 0x003B3B7C File Offset: 0x003B1D7C
		internal static int sd(byte[] byte_0, int int_0, int int_1)
		{
			int_1 = Math.Min(int_1, 4);
			int_1 = Math.Min(int_1, byte_0.Length - int_0);
			int num = 0;
			for (int i = int_0; i < int_0 + int_1; i++)
			{
				num = (num << 8) | (int)(byte_0[i] & byte.MaxValue);
			}
			return num;
		}

		// Token: 0x0600DFDE RID: 57310 RVA: 0x0054C8C8 File Offset: 0x0054AAC8
		internal static string sF(int int_0)
		{
			string text2;
			try
			{
				string text = lcP.nX(int_0).ToUpper();
				if (text.Length <= 2)
				{
					if (text.Length >= 2)
					{
						text2 = text;
					}
					else
					{
						text2 = "0" + text;
					}
				}
				else
				{
					text2 = lcP.IZ(text, 0, 2);
				}
			}
			catch (Exception)
			{
				throw new Exception("Invalid argument.");
			}
			return text2;
		}

		// Token: 0x0600DFDF RID: 57311 RVA: 0x0054C938 File Offset: 0x0054AB38
		internal static string sX(byte[] byte_0)
		{
			return lcP.sP(byte_0, " ");
		}

		// Token: 0x0600DFE0 RID: 57312 RVA: 0x0054C954 File Offset: 0x0054AB54
		internal static string sP(byte[] byte_0, string string_0)
		{
			string text;
			if (byte_0 != null)
			{
				lcc lcc = new lcc();
				for (int i = 0; i < byte_0.Length; i++)
				{
					lcc.MPI(lcP.sF((int)byte_0[i]));
					if (i < byte_0.Length - 1)
					{
						lcc.MPI(string_0);
					}
				}
				text = lcc.ToString();
			}
			else
			{
				text = lcu.W;
			}
			return text;
		}

		// Token: 0x0600DFE1 RID: 57313 RVA: 0x003B41AC File Offset: 0x003B23AC
		internal static bool sJ(byte[] byte_0, byte[] byte_1)
		{
			bool flag;
			if (byte_0 != null || byte_1 != null)
			{
				if (byte_0 != null && byte_1 != null && byte_0.Length == byte_1.Length)
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
				flag = true;
			}
			return flag;
		}

		// Token: 0x0600DFE2 RID: 57314 RVA: 0x0054C9B8 File Offset: 0x0054ABB8
		internal static string sw(string string_0)
		{
			lcc lcc = new lcc();
			char c = '\0';
			int i = 0;
			while (i < string_0.Length)
			{
				char c2 = string_0[i];
				char c3 = c2;
				switch (c3)
				{
				case '\t':
					goto IL_0069;
				case '\n':
					if (c != '\r')
					{
						lcc.MPI("\r\n");
						goto IL_0059;
					}
					c = '\0';
					break;
				case '\v':
				case '\f':
					goto IL_00AD;
				case '\r':
					if (c != '\n')
					{
						lcc.MPI("\r\n");
						goto IL_0059;
					}
					c = '\0';
					break;
				default:
					if (c3 != ' ')
					{
						goto IL_00AD;
					}
					goto IL_0069;
				}
				IL_005B:
				i++;
				continue;
				IL_0059:
				c = c2;
				goto IL_005B;
				IL_0069:
				if (c != '\n' && c != '\r' && c != '\0')
				{
					lcc.MPI(' ');
				}
				c = '\0';
				goto IL_005B;
				IL_00AD:
				lcc.MPI(c2);
				goto IL_0059;
			}
			return lcc.ToString();
		}

		// Token: 0x0600DFE3 RID: 57315 RVA: 0x0054CA88 File Offset: 0x0054AC88
		public static int sh(int int_0, int int_1)
		{
			return int_0 + (int_1 - int_0 % int_1);
		}

		// Token: 0x0600DFE4 RID: 57316 RVA: 0x0054CAA0 File Offset: 0x0054ACA0
		public static string so(string string_0, string[] string_1)
		{
			return lcP.sG(string_0, string_1, 0, (string_1 == null) ? 0 : string_1.Length);
		}

		// Token: 0x0600DFE5 RID: 57317 RVA: 0x0054CAC0 File Offset: 0x0054ACC0
		public static string sG(string string_0, string[] string_1, int int_0, int int_1)
		{
			string text;
			if (string_1 != null)
			{
				int_1 = Math.Min(int_1, string_1.Length - int_0);
				lcc lcc = new lcc();
				while (int_0 < int_1)
				{
					if (int_0 != 0)
					{
						lcc.MPI(string_0);
					}
					lcc.MPI(string_1[int_0]);
					int_0++;
				}
				text = lcc.ToString();
			}
			else
			{
				text = lcu.W;
			}
			return text;
		}

		// Token: 0x0600DFE6 RID: 57318 RVA: 0x0054CB28 File Offset: 0x0054AD28
		public static string[] sC(string string_0, string string_1, bool bool_0, bool bool_1)
		{
			string[] array3;
			if (string_0 != null && string_0.Length != 0)
			{
				char[] array = string_0.ToCharArray();
				char[] array2 = string_1.ToCharArray();
				lyN lyN = new lyN();
				int num = 0;
				int i = 0;
				IL_001F:
				while (i < array.Length)
				{
					for (int j = 0; j < array2.Length; j++)
					{
						if (array[i] == array2[j])
						{
							int num2 = num;
							int num3 = i;
							if (bool_0)
							{
								while (num2 < num3 && char.IsWhiteSpace(array[num2]))
								{
									num2++;
								}
								while (num2 < num3 && char.IsWhiteSpace(array[num3 - 1]))
								{
									num3--;
								}
							}
							if (num2 != num3 || bool_1)
							{
								lyN.Add(lcP.IZ(string_0, num2, num3));
							}
							num = i + 1;
							IL_0088:
							i++;
							goto IL_001F;
						}
					}
					goto IL_0088;
				}
				if (num < string_0.Length)
				{
					lyN.Add(lcP.IG(string_0, num));
				}
				array3 = (string[])lyN.ToArray(typeof(string));
			}
			else
			{
				array3 = new string[0];
			}
			return array3;
		}

		// Token: 0x0600DFE7 RID: 57319 RVA: 0x0054CC58 File Offset: 0x0054AE58
		public static string[] sl(string string_0, string string_1, bool bool_0)
		{
			return lcP.sC(string_0, string_1, bool_0, false);
		}

		// Token: 0x0600DFE8 RID: 57320 RVA: 0x0054CC70 File Offset: 0x0054AE70
		public static string[] sZ(string string_0, string string_1)
		{
			return lcP.sl(string_0, string_1, false);
		}

		// Token: 0x0600DFE9 RID: 57321 RVA: 0x003B475C File Offset: 0x003B295C
		public static int It(object[] object_0, object object_1)
		{
			for (int i = 0; i < object_0.Length; i++)
			{
				if (object_1.Equals(object_0[i]))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600DFEA RID: 57322 RVA: 0x0054CC88 File Offset: 0x0054AE88
		public static bool Is(object[] object_0, object object_1)
		{
			return lcP.It(object_0, object_1) >= 0;
		}

		// Token: 0x0600DFEB RID: 57323 RVA: 0x0054CCA4 File Offset: 0x0054AEA4
		public static bool In(object[] object_0, object[] object_1, object object_2)
		{
			return lcP.Is(object_0, object_2) && lcP.Is(object_1, object_2);
		}

		// Token: 0x0600DFEC RID: 57324 RVA: 0x0054CCC4 File Offset: 0x0054AEC4
		public static string Iy(string string_0)
		{
			string text = lcP.IZ(string_0, 0, 1);
			return text.ToUpper() + lcP.IG(string_0, 1);
		}

		// Token: 0x0600DFED RID: 57325 RVA: 0x0054CCF0 File Offset: 0x0054AEF0
		public static long Im(string string_0)
		{
			return lcP.IV(string_0, 10);
		}

		// Token: 0x0600DFEE RID: 57326 RVA: 0x003B492C File Offset: 0x003B2B2C
		public static long IV(string string_0, int int_0)
		{
			return long.Parse(string_0, (int_0 == 16) ? NumberStyles.HexNumber : NumberStyles.Integer);
		}

		// Token: 0x0600DFEF RID: 57327 RVA: 0x0054CD08 File Offset: 0x0054AF08
		public static char IK(lcc lcc_0, int int_0)
		{
			return lcc_0.n(int_0);
		}

		// Token: 0x0600DFF0 RID: 57328 RVA: 0x0054CD20 File Offset: 0x0054AF20
		public static string IQ(lcc lcc_0, int int_0, int int_1)
		{
			return lcc_0.Q(int_0, int_1 - int_0);
		}

		// Token: 0x0600DFF1 RID: 57329 RVA: 0x0054CD3C File Offset: 0x0054AF3C
		public static string Ir(lcc lcc_0, int int_0)
		{
			return lcP.IQ(lcc_0, int_0, lcc_0.D);
		}

		// Token: 0x0600DFF2 RID: 57330 RVA: 0x003B4B2C File Offset: 0x003B2D2C
		public static string IG(string string_0, int int_0)
		{
			return string_0.Substring(int_0);
		}

		// Token: 0x0600DFF3 RID: 57331 RVA: 0x003B4B44 File Offset: 0x003B2D44
		public static string IZ(string string_0, int int_0, int int_1)
		{
			return string_0.Substring(int_0, int_1 - int_0);
		}

		// Token: 0x0600DFF4 RID: 57332 RVA: 0x0054CD58 File Offset: 0x0054AF58
		public static bool nt(string string_0, string string_1)
		{
			return lcP.nI(string_0, string_1) == 0;
		}

		// Token: 0x0600DFF5 RID: 57333 RVA: 0x003B4B78 File Offset: 0x003B2D78
		public static int ns(string string_0, string string_1)
		{
			return string.CompareOrdinal(string_0, string_1);
		}

		// Token: 0x0600DFF6 RID: 57334 RVA: 0x003B4B90 File Offset: 0x003B2D90
		public static int nI(string string_0, string string_1)
		{
			return string.Compare(string_0, string_1, StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x0600DFF7 RID: 57335 RVA: 0x0054CD70 File Offset: 0x0054AF70
		internal static string nn(byte[] byte_0, int int_0, int int_1, string string_0)
		{
			if (string_0 == null || string_0.Length == 0)
			{
				string_0 = lcP.s;
			}
			Encoding encoding = Encoding.GetEncoding(string_0);
			return encoding.GetString(byte_0, int_0, int_1);
		}

		// Token: 0x0600DFF8 RID: 57336 RVA: 0x0054CDB0 File Offset: 0x0054AFB0
		internal static string ny(byte[] byte_0, string string_0)
		{
			return lcP.nn(byte_0, 0, byte_0.Length, string_0);
		}

		// Token: 0x0600DFF9 RID: 57337 RVA: 0x0054CDCC File Offset: 0x0054AFCC
		internal static string nb(byte[] byte_0)
		{
			return lcP.ne(byte_0, 0, byte_0.Length);
		}

		// Token: 0x0600DFFA RID: 57338 RVA: 0x0054CDE8 File Offset: 0x0054AFE8
		internal static Encoding na()
		{
			return Encoding.GetEncoding(0);
		}

		// Token: 0x0600DFFB RID: 57339 RVA: 0x0054CE00 File Offset: 0x0054B000
		internal static string ne(byte[] byte_0, int int_0, int int_1)
		{
			return lcP.na().GetString(byte_0, int_0, int_1);
		}

		// Token: 0x0600DFFC RID: 57340 RVA: 0x0054CE1C File Offset: 0x0054B01C
		internal static string nm(byte[] byte_0)
		{
			return lcP.nV(byte_0, 0, byte_0.Length);
		}

		// Token: 0x0600DFFD RID: 57341 RVA: 0x0054CE38 File Offset: 0x0054B038
		internal static string nV(byte[] byte_0, int int_0, int int_1)
		{
			string text;
			if (Environment.OSVersion.Platform != PlatformID.WinCE)
			{
				text = lcP.nn(byte_0, int_0, int_1, lcP.Q);
			}
			else
			{
				text = lcP.nn(byte_0, int_0, int_1, lcP.m);
			}
			return text;
		}

		// Token: 0x0600DFFE RID: 57342 RVA: 0x0054CE78 File Offset: 0x0054B078
		internal static string nK(byte[] byte_0)
		{
			string text;
			if (byte_0 == null || byte_0.Length <= 0 || byte_0[byte_0.Length - 1] != 0)
			{
				text = lcP.nQ(byte_0, 0, byte_0.Length);
			}
			else
			{
				text = lcP.nQ(byte_0, 0, byte_0.Length - 1);
			}
			return text;
		}

		// Token: 0x0600DFFF RID: 57343 RVA: 0x003B50D0 File Offset: 0x003B32D0
		internal static string nQ(byte[] byte_0, int int_0, int int_1)
		{
			return Encoding.UTF8.GetString(byte_0, int_0, int_1);
		}

		// Token: 0x0600E000 RID: 57344 RVA: 0x0054CEBC File Offset: 0x0054B0BC
		internal static byte[] nU(string string_0, string string_1)
		{
			byte[] array;
			if (string_1 != null && string_1.Length != 0)
			{
				array = Encoding.GetEncoding(string_1).GetBytes(string_0);
			}
			else
			{
				array = lcP.nr(string_0);
			}
			return array;
		}

		// Token: 0x0600E001 RID: 57345 RVA: 0x0054CEF4 File Offset: 0x0054B0F4
		internal static byte[] nr(string string_0)
		{
			return lcP.na().GetBytes(string_0);
		}

		// Token: 0x0600E002 RID: 57346 RVA: 0x0054CF10 File Offset: 0x0054B110
		internal static byte[] nd(string string_0)
		{
			byte[] array;
			if (Environment.OSVersion.Platform != PlatformID.WinCE)
			{
				array = lcP.nU(string_0, lcP.Q);
			}
			else
			{
				array = lcP.nU(string_0, lcP.m);
			}
			return array;
		}

		// Token: 0x0600E003 RID: 57347 RVA: 0x003B51BC File Offset: 0x003B33BC
		internal static byte[] nF(string string_0)
		{
			return Encoding.UTF8.GetBytes(string_0);
		}

		// Token: 0x0600E004 RID: 57348 RVA: 0x003B51D8 File Offset: 0x003B33D8
		internal static string nX(int int_0)
		{
			return int_0.ToString("X");
		}

		// Token: 0x0600E005 RID: 57349 RVA: 0x003B51F4 File Offset: 0x003B33F4
		internal static long nP(string string_0)
		{
			return (long)int.Parse(string_0, NumberStyles.HexNumber);
		}

		// Token: 0x0600E006 RID: 57350 RVA: 0x003B5210 File Offset: 0x003B3410
		internal static long nJ(string string_0)
		{
			return long.Parse(string_0, NumberStyles.HexNumber);
		}

		// Token: 0x0600E007 RID: 57351 RVA: 0x003B522C File Offset: 0x003B342C
		internal static char[] nw(string string_0)
		{
			return (string_0 + "\0").ToCharArray();
		}

		// Token: 0x0600E008 RID: 57352 RVA: 0x0054CF4C File Offset: 0x0054B14C
		public static short nh(byte[] byte_0, int int_0)
		{
			return (short)lcP.yt(byte_0, int_0, 2);
		}

		// Token: 0x0600E009 RID: 57353 RVA: 0x0054CF64 File Offset: 0x0054B164
		public static short no(byte[] byte_0)
		{
			return lcP.nh(byte_0, 0);
		}

		// Token: 0x0600E00A RID: 57354 RVA: 0x0054CF7C File Offset: 0x0054B17C
		public static int nG(byte[] byte_0, int int_0)
		{
			return (int)lcP.yt(byte_0, int_0, 4);
		}

		// Token: 0x0600E00B RID: 57355 RVA: 0x0054CF94 File Offset: 0x0054B194
		public static int nC(byte[] byte_0)
		{
			return lcP.nG(byte_0, 0);
		}

		// Token: 0x0600E00C RID: 57356 RVA: 0x0054CFAC File Offset: 0x0054B1AC
		public static long nl(byte[] byte_0, int int_0)
		{
			return lcP.yt(byte_0, int_0, 8);
		}

		// Token: 0x0600E00D RID: 57357 RVA: 0x0054CFC4 File Offset: 0x0054B1C4
		public static long nZ(byte[] byte_0)
		{
			return lcP.nl(byte_0, 0);
		}

		// Token: 0x0600E00E RID: 57358 RVA: 0x003B5328 File Offset: 0x003B3528
		public static long yt(byte[] byte_0, int int_0, int int_1)
		{
			long num = 0L;
			while (int_1 > 0 && int_0 < byte_0.Length)
			{
				num = (num << 8) | (long)(byte_0[int_0++] & byte.MaxValue);
				int_1--;
			}
			return num;
		}

		// Token: 0x0600E00F RID: 57359 RVA: 0x0054CFDC File Offset: 0x0054B1DC
		public static long ys(byte[] byte_0, int int_0, int int_1)
		{
			long num = 0L;
			while (int_1 > 0 && int_0 + int_1 < byte_0.Length)
			{
				num = (num << 8) | (long)(byte_0[int_0 + int_1 - 1] & byte.MaxValue);
				int_1--;
			}
			return num;
		}

		// Token: 0x0600E010 RID: 57360 RVA: 0x0054D024 File Offset: 0x0054B224
		public static byte[] yI(short short_0)
		{
			return lcP.yb((long)short_0, 2);
		}

		// Token: 0x0600E011 RID: 57361 RVA: 0x0054D03C File Offset: 0x0054B23C
		public static byte[] yn(int int_0)
		{
			return lcP.yb((long)int_0, 4);
		}

		// Token: 0x0600E012 RID: 57362 RVA: 0x0054D054 File Offset: 0x0054B254
		public static byte[] yy(long long_0)
		{
			return lcP.yb(long_0, 8);
		}

		// Token: 0x0600E013 RID: 57363 RVA: 0x0054D06C File Offset: 0x0054B26C
		public static byte[] yb(long long_0, int int_0)
		{
			byte[] array = new byte[int_0];
			lcP.yK(long_0, array, 0, int_0);
			return array;
		}

		// Token: 0x0600E014 RID: 57364 RVA: 0x0054D08C File Offset: 0x0054B28C
		public static byte[] ya(long long_0, int int_0)
		{
			byte[] array = new byte[int_0];
			lcP.yQ(long_0, array, 0, int_0);
			return array;
		}

		// Token: 0x0600E015 RID: 57365 RVA: 0x00069A46 File Offset: 0x00067C46
		public static void ye(short short_0, byte[] byte_0, int int_0)
		{
			lcP.yK((long)short_0, byte_0, int_0, 2);
		}

		// Token: 0x0600E016 RID: 57366 RVA: 0x00069A52 File Offset: 0x00067C52
		public static void ym(int int_0, byte[] byte_0, int int_1)
		{
			lcP.yK((long)int_0, byte_0, int_1, 4);
		}

		// Token: 0x0600E017 RID: 57367 RVA: 0x00069A5E File Offset: 0x00067C5E
		public static void yV(long long_0, byte[] byte_0, int int_0)
		{
			lcP.yK(long_0, byte_0, int_0, 8);
		}

		// Token: 0x0600E018 RID: 57368 RVA: 0x0028432C File Offset: 0x0028252C
		public static void yK(long long_0, byte[] byte_0, int int_0, int int_1)
		{
			int i = int_0 + int_1 - 1;
			while (i >= int_0)
			{
				byte_0[i] = (byte)(long_0 & 255L);
				i--;
				long_0 >>= 8;
			}
		}

		// Token: 0x0600E019 RID: 57369 RVA: 0x0054D0AC File Offset: 0x0054B2AC
		public static void yQ(long long_0, byte[] byte_0, int int_0, int int_1)
		{
			int i = int_0;
			int num = int_0 + int_1 - 1;
			while (i < num)
			{
				byte_0[i] = (byte)(long_0 & 255L);
				i++;
				long_0 >>= 8;
			}
		}

		// Token: 0x0600E01A RID: 57370 RVA: 0x0054D0E4 File Offset: 0x0054B2E4
		public static string yU(string[] string_0, string string_1)
		{
			lcc lcc = new lcc();
			for (int i = 0; i < string_0.Length; i++)
			{
				lcc.MPI(string_0[i] + ((i >= string_0.Length - 1) ? "" : string_1));
			}
			return lcc.ToString();
		}

		// Token: 0x04005A5E RID: 23134
		internal const int Y = 0;

		// Token: 0x04005A5F RID: 23135
		internal new const int R = 1;

		// Token: 0x04005A60 RID: 23136
		internal new const int f = 2;

		// Token: 0x04005A61 RID: 23137
		internal new static string l = "UTF-8";

		// Token: 0x04005A62 RID: 23138
		internal static string U = lcu.W;

		// Token: 0x04005A63 RID: 23139
		internal new static string m = "US-ASCII";

		// Token: 0x04005A64 RID: 23140
		internal new static string Q = "ISO-8859-1";

		// Token: 0x04005A65 RID: 23141
		internal new static string k = "ISO-2022-JP";

		// Token: 0x04005A66 RID: 23142
		internal static string w = "SJIS";

		// Token: 0x04005A67 RID: 23143
		internal new static string D = lcP.U;

		// Token: 0x04005A68 RID: 23144
		internal static string s = lcP.m;

		// Token: 0x04005A69 RID: 23145
		internal new static byte[] A = lcP.nd("-----BEGIN CERTIFICATE-----");

		// Token: 0x04005A6A RID: 23146
		internal new static byte[] E = lcP.nd("-----END CERTIFICATE-----");
	}
}
