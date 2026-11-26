using System;
using System.Text;
using Microsoft.Win32;

namespace Arc264y
{
	// Token: 0x02000B58 RID: 2904
	internal class lXu
	{
		// Token: 0x0600E115 RID: 57621 RVA: 0x0054ECAC File Offset: 0x0054CEAC
		public static string x(string string_0)
		{
			string text = "";
			string text2;
			if (string_0 != null && string_0.Length != 0)
			{
				byte[] array = lXu.f(string_0);
				byte[] array2 = lXu.ep(array, array.Length);
				text2 = lXu.K(array2, 0, array2.Length);
			}
			else
			{
				text2 = text;
			}
			return text2;
		}

		// Token: 0x0600E116 RID: 57622 RVA: 0x0054ECF4 File Offset: 0x0054CEF4
		public static string K(byte[] byte_0, int int_0, int int_1)
		{
			return Encoding.Default.GetString(byte_0, int_0, int_1);
		}

		// Token: 0x0600E117 RID: 57623 RVA: 0x0054ED10 File Offset: 0x0054CF10
		public static byte[] f(string string_0)
		{
			return Encoding.Default.GetBytes(string_0);
		}

		// Token: 0x0600E118 RID: 57624 RVA: 0x0004819A File Offset: 0x0004639A
		public static void t(byte[] byte_0, int int_0, byte[] byte_1, int int_1, int int_2)
		{
			Array.Copy(byte_0, int_0, byte_1, int_1, int_2);
		}

		// Token: 0x0600E119 RID: 57625 RVA: 0x0054ED2C File Offset: 0x0054CF2C
		public static string W(string string_0)
		{
			byte[] array = lXu.f(string_0 + "\0");
			int num = lXu.ma(array, 0);
			return lXu.K(array, 0, num);
		}

		// Token: 0x0600E11A RID: 57626 RVA: 0x0054ED5C File Offset: 0x0054CF5C
		public static bool i(byte byte_0)
		{
			bool flag;
			switch (byte_0)
			{
			case 65:
				flag = true;
				break;
			case 66:
				flag = true;
				break;
			case 67:
				flag = true;
				break;
			case 68:
				flag = true;
				break;
			case 69:
				flag = true;
				break;
			default:
				if (byte_0 != 77)
				{
					switch (byte_0)
					{
					case 80:
						return true;
					case 83:
						return true;
					case 84:
						return true;
					case 86:
						return true;
					case 88:
						return true;
					case 90:
						return true;
					}
					flag = false;
				}
				else
				{
					flag = true;
				}
				break;
			}
			return flag;
		}

		// Token: 0x0600E11B RID: 57627 RVA: 0x0054EDFC File Offset: 0x0054CFFC
		public static bool s(byte byte_0)
		{
			return byte_0 == 88 || byte_0 == 90;
		}

		// Token: 0x0600E11C RID: 57628 RVA: 0x0054EE18 File Offset: 0x0054D018
		public static bool mx(byte byte_0)
		{
			return byte_0 == 80;
		}

		// Token: 0x0600E11D RID: 57629 RVA: 0x0054EE2C File Offset: 0x0054D02C
		public static bool mm(byte byte_0)
		{
			return byte_0 == 68 || byte_0 == 69;
		}

		// Token: 0x0600E11E RID: 57630 RVA: 0x0054EE48 File Offset: 0x0054D048
		public static bool me(byte byte_0)
		{
			bool flag;
			switch (byte_0)
			{
			case 65:
				flag = true;
				break;
			case 66:
				flag = true;
				break;
			case 67:
				flag = true;
				break;
			case 68:
				flag = true;
				break;
			default:
				flag = byte_0 == 86 || byte_0 == 90;
				break;
			}
			return flag;
		}

		// Token: 0x0600E11F RID: 57631 RVA: 0x0054EE9C File Offset: 0x0054D09C
		public static bool mp(byte byte_0)
		{
			return byte_0 == 67 || byte_0 == 84;
		}

		// Token: 0x0600E120 RID: 57632 RVA: 0x0054EEB8 File Offset: 0x0054D0B8
		public static bool mH(byte byte_0)
		{
			return byte_0 == 66 || byte_0 == 90;
		}

		// Token: 0x0600E121 RID: 57633 RVA: 0x0054EED4 File Offset: 0x0054D0D4
		internal static void mN(uint[] uint_0, uint[] uint_1)
		{
			uint num = uint_0[0];
			uint num2 = uint_0[1];
			uint num3 = 0U;
			uint num4 = 2654435769U;
			uint num5 = 32U;
			while (num5-- > 0U)
			{
				num3 += num4;
				num += ((num2 << 4) + uint_1[0]) ^ (num2 + num3) ^ ((num2 >> 5) + uint_1[1]);
				num2 += ((num << 4) + uint_1[2]) ^ (num + num3) ^ ((num >> 5) + uint_1[3]);
			}
			uint_0[0] = num;
			uint_0[1] = num2;
		}

		// Token: 0x0600E122 RID: 57634 RVA: 0x0054EF3C File Offset: 0x0054D13C
		internal static void mb(uint[] uint_0, uint[] uint_1)
		{
			uint num = uint_0[0];
			uint num2 = uint_0[1];
			uint num3 = 2654435769U;
			uint num4 = 32U;
			uint num5 = 3337565984U;
			while (num4-- > 0U)
			{
				num2 -= ((num << 4) + uint_1[2]) ^ (num + num5) ^ ((num >> 5) + uint_1[3]);
				num -= ((num2 << 4) + uint_1[0]) ^ (num2 + num5) ^ ((num2 >> 5) + uint_1[1]);
				num5 -= num3;
			}
			uint_0[0] = num;
			uint_0[1] = num2;
		}

		// Token: 0x0600E123 RID: 57635 RVA: 0x0054EFAC File Offset: 0x0054D1AC
		internal static uint mr(byte[] byte_0, int int_0)
		{
			uint num = (uint)(byte_0[int_0 + 3] & byte.MaxValue);
			num = num * 256U + (uint)(byte_0[int_0 + 2] & byte.MaxValue);
			num = num * 256U + (uint)(byte_0[int_0 + 1] & byte.MaxValue);
			return num * 256U + (uint)(byte_0[int_0] & byte.MaxValue);
		}

		// Token: 0x0600E124 RID: 57636 RVA: 0x0054F004 File Offset: 0x0054D204
		internal static void mo(uint uint_0, byte[] byte_0, int int_0)
		{
			byte_0[int_0++] = (byte)uint_0;
			byte_0[int_0++] = (byte)((uint_0 >> 8) & 255U);
			byte_0[int_0++] = (byte)((uint_0 >> 16) & 255U);
			byte_0[int_0++] = (byte)((uint_0 >> 24) & 255U);
		}

		// Token: 0x0600E125 RID: 57637 RVA: 0x0054F05C File Offset: 0x0054D25C
		internal static void ml(byte[] byte_0, int int_0, byte[] byte_1)
		{
			uint[] array = new uint[2];
			uint[] array2 = new uint[4];
			for (int i = 0; i < 2; i++)
			{
				array[i] = lXu.mr(byte_0, int_0 + i * 4);
			}
			for (int j = 0; j < 4; j++)
			{
				array2[j] = lXu.mr(byte_1, j * 4);
			}
			lXu.mb(array, array2);
			for (int k = 0; k < 2; k++)
			{
				lXu.mo(array[k], byte_0, int_0 + k * 4);
			}
		}

		// Token: 0x0600E126 RID: 57638 RVA: 0x0054F0D8 File Offset: 0x0054D2D8
		internal static void mK(byte[] byte_0, int int_0, byte[] byte_1)
		{
			uint[] array = new uint[2];
			uint[] array2 = new uint[4];
			for (int i = 0; i < 2; i++)
			{
				array[i] = lXu.mr(byte_0, int_0 + i * 4);
			}
			for (int j = 0; j < 4; j++)
			{
				array2[j] = lXu.mr(byte_1, int_0 + j * 4);
			}
			lXu.mN(array, array2);
			for (int k = 0; k < 2; k++)
			{
				lXu.mo(array[k], byte_0, k * 4);
			}
		}

		// Token: 0x0600E127 RID: 57639 RVA: 0x0054F154 File Offset: 0x0054D354
		internal static void mj(byte[] byte_0, int int_0)
		{
			for (int i = int_0 - 1; i >= 0; i--)
			{
				if (((int)byte_0[i / 8] & (1 << i % 8)) == 0)
				{
					int num = i / 5;
					byte_0[num] &= (byte)(~(byte)(1 << i % 5));
				}
				else
				{
					int num2 = i / 5;
					byte_0[num2] |= (byte)(1 << i % 5);
				}
				if (i % 5 == 0)
				{
					int num3 = i / 5;
					byte_0[num3] &= 31;
				}
			}
		}

		// Token: 0x0600E128 RID: 57640 RVA: 0x0054F1F0 File Offset: 0x0054D3F0
		internal static void mU(byte[] byte_0, int int_0)
		{
			for (int i = 0; i < int_0; i++)
			{
				if (((int)byte_0[i / 5] & (1 << i % 5)) == 0)
				{
					int num = i / 8;
					byte_0[num] &= (byte)(~(byte)(1 << i % 8));
				}
				else
				{
					int num2 = i / 8;
					byte_0[num2] |= (byte)(1 << i % 8);
				}
			}
		}

		// Token: 0x0600E129 RID: 57641 RVA: 0x0054F264 File Offset: 0x0054D464
		static lXu()
		{
			lXu.FD[0] = 48;
			lXu.FD[1] = 49;
			lXu.FD[2] = 50;
			lXu.FD[3] = 51;
			lXu.FD[4] = 52;
			lXu.FD[5] = 53;
			lXu.FD[6] = 54;
			lXu.FD[7] = 55;
			lXu.FD[8] = 56;
			lXu.FD[9] = 57;
			lXu.FD[10] = 65;
			lXu.FD[11] = 66;
			lXu.FD[12] = 67;
			lXu.FD[13] = 68;
			lXu.FD[14] = 69;
			lXu.FD[15] = 70;
			lXu.FD[16] = 71;
			lXu.FD[17] = 72;
			lXu.FD[18] = 74;
			lXu.FD[19] = 75;
			lXu.FD[20] = 77;
			lXu.FD[21] = 78;
			lXu.FD[22] = 80;
			lXu.FD[23] = 82;
			lXu.FD[24] = 83;
			lXu.FD[25] = 84;
			lXu.FD[26] = 85;
			lXu.FD[27] = 86;
			lXu.FD[28] = 87;
			lXu.FD[29] = 88;
			lXu.FD[30] = 89;
			lXu.FD[31] = 90;
		}

		// Token: 0x0600E12A RID: 57642 RVA: 0x0054F3B4 File Offset: 0x0054D5B4
		internal static byte mf(byte byte_0)
		{
			return lXu.FD[(int)(byte_0 % 32)];
		}

		// Token: 0x0600E12B RID: 57643 RVA: 0x0054F3D0 File Offset: 0x0054D5D0
		public static sbyte mG(byte byte_0)
		{
			if (byte_0 >= 97 && byte_0 <= 122)
			{
				byte_0 -= 32;
			}
			if (byte_0 == 73)
			{
				byte_0 = 49;
			}
			if (byte_0 == 76)
			{
				byte_0 = 49;
			}
			if (byte_0 == 79)
			{
				byte_0 = 48;
			}
			if (byte_0 == 81)
			{
				byte_0 = 48;
			}
			for (sbyte b = 0; b < 32; b += 1)
			{
				if (byte_0 == lXu.FD[(int)b])
				{
					return b;
				}
			}
			return -1;
		}

		// Token: 0x0600E12C RID: 57644 RVA: 0x0054F468 File Offset: 0x0054D668
		internal static byte mq(byte byte_0)
		{
			if (byte_0 >= 97 && byte_0 <= 122)
			{
				byte_0 -= 32;
			}
			return byte_0;
		}

		// Token: 0x0600E12D RID: 57645 RVA: 0x0054F494 File Offset: 0x0054D694
		protected internal static int ma(byte[] byte_0, int int_0)
		{
			int num = int_0;
			int num2 = int_0;
			while (num2 < byte_0.Length && byte_0[num2] != 0)
			{
				sbyte b = lXu.mG(byte_0[num2]);
				if (-1 == b)
				{
					byte_0[num2] = 0;
				}
				else
				{
					byte_0[num++] = lXu.mf((byte)b);
				}
				num2++;
			}
			for (int i = num; i < num2; i++)
			{
				byte_0[i] = 0;
			}
			return num - int_0;
		}

		// Token: 0x0600E12E RID: 57646 RVA: 0x0054F4F4 File Offset: 0x0054D6F4
		internal static byte[] mt(byte[] byte_0, int int_0)
		{
			while (int_0 % 5 != 0)
			{
				byte_0[int_0++] = 0;
			}
			byte_0[int_0] = 0;
			int num = int_0 / 5 * 8;
			byte[] array = new byte[num + 1];
			for (int i = 0; i < int_0; i++)
			{
				array[i] = byte_0[i];
			}
			lXu.mj(array, int_0 * 8);
			for (int j = 0; j < num; j++)
			{
				array[j] = lXu.mf(array[j]);
			}
			array[num] = 0;
			return array;
		}

		// Token: 0x0600E12F RID: 57647 RVA: 0x0054F56C File Offset: 0x0054D76C
		internal static int mY(byte[] byte_0)
		{
			int num = lXu.ma(byte_0, 0);
			while (num % 8 != 0)
			{
				byte_0[num++] = 48;
			}
			for (int i = 0; i < num; i++)
			{
				byte_0[i] = (byte)lXu.mG(byte_0[i]);
			}
			int num2 = num / 8 * 5;
			lXu.mU(byte_0, num * 5);
			return num2;
		}

		// Token: 0x0600E130 RID: 57648 RVA: 0x0054F5C4 File Offset: 0x0054D7C4
		protected internal static void mW(byte[] byte_0, byte byte_1, byte byte_2)
		{
			for (int i = 0; i < 16; i++)
			{
				byte_0[i] = byte_0[i] + (byte_1 - 48) + (byte_2 - 48);
			}
		}

		// Token: 0x0600E131 RID: 57649 RVA: 0x0054F5F4 File Offset: 0x0054D7F4
		internal static byte[] mD(byte[] byte_0, byte[] byte_1, byte[] byte_2)
		{
			byte[] array = new byte[301];
			byte[] array2 = new byte[14];
			lXu.t(byte_0, 0, array, 0, byte_0.Length);
			int num = lXu.ma(array, 0);
			byte[] array4;
			if (num != 0)
			{
				if (byte_1 != null && byte_1.Length > 0)
				{
					array[num++] = 42;
					int i = num;
					while (i < array.Length - 1 && i - num < byte_1.Length && byte_1[i - num] != 0)
					{
						array[i] = byte_1[i - num];
						i++;
					}
					array[i] = 0;
					num += lXu.ma(array, num);
				}
				while (num % 8 != 0)
				{
					array[num++] = 0;
				}
				for (int i = 0; i < num / 8; i++)
				{
					for (int j = 0; j < 8; j++)
					{
						byte[] array3 = array2;
						int num2 = j;
						array3[num2] ^= array[8 * i + j];
					}
					lXu.mK(array2, 0, byte_2);
				}
				array4 = array2;
			}
			else
			{
				array4 = array2;
			}
			return array4;
		}

		// Token: 0x0600E132 RID: 57650 RVA: 0x0054F6F8 File Offset: 0x0054D8F8
		internal static byte[] mi(byte[] byte_0, byte[] byte_1, byte[] byte_2)
		{
			byte[] array = lXu.mD(byte_0, byte_1, byte_2);
			array = lXu.mt(array, 8);
			array[12] = 0;
			return array;
		}

		// Token: 0x0600E133 RID: 57651 RVA: 0x0054F720 File Offset: 0x0054D920
		internal static string ms(byte[] byte_0, byte[] byte_1, byte[] byte_2)
		{
			byte[] array = lXu.mi(byte_0, byte_1, byte_2);
			array[13] = array[11];
			array[12] = array[10];
			array[11] = array[9];
			array[10] = array[8];
			array[9] = 45;
			array[8] = array[7];
			array[7] = array[6];
			array[6] = array[5];
			array[5] = array[4];
			array[4] = 45;
			return lXu.K(array, 0, 14);
		}

		// Token: 0x0600E134 RID: 57652 RVA: 0x0054F784 File Offset: 0x0054D984
		public static int mC(byte[] byte_0, byte[] byte_1, byte[] byte_2, byte[] byte_3)
		{
			byte[] array = new byte[31];
			int i = 0;
			while (i < byte_2.Length && byte_2[i] != 0)
			{
				array[i] = byte_2[i];
				i++;
			}
			array[i] = 0;
			lXu.ma(array, 0);
			byte[] array2 = lXu.mi(byte_0, byte_1, byte_3);
			int num = 1;
			i = 0;
			while (i < ((array[6] != 0) ? 12 : 6))
			{
				if (array[i] != 0)
				{
					num = 0;
				}
				int num2;
				if (array[i] != 0)
				{
					if (array[i] == array2[i])
					{
						i++;
						continue;
					}
					num2 = 2;
				}
				else
				{
					num2 = 1;
				}
				return num2;
			}
			if (array[12] != 0)
			{
				return 3;
			}
			if (num == 0)
			{
				return 0;
			}
			return 4;
		}

		// Token: 0x0600E135 RID: 57653 RVA: 0x0054F834 File Offset: 0x0054DA34
		public static string mv()
		{
			string text = Environment.MachineName;
			string environmentVariable = Environment.GetEnvironmentVariable("_CLUSTER_NETWORK_NAME_");
			if (environmentVariable != null && environmentVariable.Length > 0)
			{
				text = (string)Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters").GetValue("NV Hostname");
			}
			return text;
		}

		// Token: 0x0600E136 RID: 57654 RVA: 0x0054F890 File Offset: 0x0054DA90
		public static string mz()
		{
			string text = "00000000";
			try
			{
				text = lXu.mv();
			}
			catch (Exception)
			{
			}
			return lXu.ex(text);
		}

		// Token: 0x0600E137 RID: 57655 RVA: 0x0054F8C8 File Offset: 0x0054DAC8
		public static string ex(string string_0)
		{
			byte[] array = new byte[100];
			byte[] array2 = lXu.f(string_0);
			lXu.t(array2, 0, array, 1, array2.Length);
			array[0] = 65;
			byte[] array3 = new byte[]
			{
				69, 110, 105, 107, 97, 109, 69, 114, 117, 104,
				100, 121, 114, 116, 104, 83
			};
			byte[] array4 = lXu.mi(array, new byte[0], array3);
			return lXu.K(array4, 0, 8);
		}

		// Token: 0x0600E138 RID: 57656 RVA: 0x0054F970 File Offset: 0x0054DB70
		public static byte[] em(byte[] byte_0, int int_0)
		{
			byte[] array = new byte[]
			{
				48, 49, 50, 51, 52, 53, 54, 55, 56, 57,
				65, 66, 67, 68, 69, 70
			};
			for (int i = int_0 - 1; i >= 0; i--)
			{
				byte b = byte_0[i];
				byte_0[2 * i + 1] = array[(int)(b & 15)];
				b = (byte)(b >> 4);
				byte_0[2 * i] = array[(int)b];
			}
			return byte_0;
		}

		// Token: 0x0600E139 RID: 57657 RVA: 0x0054FA14 File Offset: 0x0054DC14
		public static byte[] ep(byte[] byte_0, int int_0)
		{
			byte[] array = new byte[]
			{
				48, 49, 50, 51, 52, 53, 54, 55, 56, 57,
				65, 66, 67, 68, 69, 70
			};
			for (int i = 0; i < int_0 / 2; i++)
			{
				byte b = byte_0[2 * i];
				if (b < 48 || b > 57)
				{
					if (b < 65 || b > 70)
					{
						for (i = 0; i < int_0; i++)
						{
							byte_0[i] = 0;
						}
						return byte_0;
					}
					byte_0[i] = (byte)(b - 65 + 10 << 4);
				}
				else
				{
					byte_0[i] = (byte)(b - 48 << 4);
				}
				b = byte_0[2 * i + 1];
				if (b < 48 || b > 57)
				{
					if (b < 65 || b > 70)
					{
						for (i = 0; i < int_0; i++)
						{
							byte_0[i] = 0;
						}
						return byte_0;
					}
					int num = i;
					byte_0[num] += b - 65 + 10;
				}
				else
				{
					int num2 = i;
					byte_0[num2] += b - 48;
				}
			}
			return byte_0;
		}

		// Token: 0x0600E13A RID: 57658 RVA: 0x0054FB64 File Offset: 0x0054DD64
		public static byte[] eH(byte[] byte_0, byte[] byte_1, byte[] byte_2, byte[] byte_3)
		{
			if (byte_0 != null)
			{
				byte_0[0] = 0;
			}
			lXu.ma(byte_1, 0);
			byte[] array2;
			if (byte_1[0] != 0)
			{
				byte[] array = lXu.mi(byte_1, byte_2, byte_3);
				for (int i = 0; i < 40; i++)
				{
					byte_0[i] = byte_1[i];
				}
				for (int i = 40; i < 48; i++)
				{
					byte_0[i] = byte_2[i - 40];
				}
				for (int i = 50; i < 62; i++)
				{
					byte_0[i] = array[i - 50];
				}
				byte_0 = lXu.em(byte_0, 64);
				byte_0[128] = 0;
				array2 = byte_0;
			}
			else
			{
				array2 = byte_0;
			}
			return array2;
		}

		// Token: 0x0600E13B RID: 57659 RVA: 0x0054FC00 File Offset: 0x0054DE00
		public static byte[] er(byte[] byte_0, byte[] byte_1, byte[] byte_2)
		{
			byte[] array = lXu.f(lXu.mz());
			return lXu.eH(byte_0, byte_1, array, byte_2);
		}

		// Token: 0x0600E13C RID: 57660 RVA: 0x0054FC24 File Offset: 0x0054DE24
		public static int eK(byte[] byte_0, byte[] byte_1, int int_0)
		{
			int num3;
			if (byte_0 != null)
			{
				int num = byte_0.Length - 1;
				if (num >= 128)
				{
					byte_0 = lXu.ep(byte_0, 128);
					byte_0[64] = 0;
					if (byte_0[0] != 0)
					{
						byte[] array = new byte[40];
						byte[] array2 = new byte[9];
						byte[] array3 = new byte[16];
						for (int i = 0; i < 40; i++)
						{
							array[i] = byte_0[i];
						}
						for (int i = 40; i < 49; i++)
						{
							array2[i - 40] = byte_0[i];
						}
						for (int i = 50; i < 62; i++)
						{
							array3[i - 50] = byte_0[i];
						}
						int num2 = lXu.mC(array, array2, array3, byte_1);
						if (num2 == 0)
						{
							byte b = lXu.mq(byte_0[5]);
							char c = (char)b;
							switch (c)
							{
							case 'A':
							case 'B':
							case 'D':
								break;
							case 'C':
								if (int_0 == 0)
								{
									return num2;
								}
								if (int_0 == (int)(10 * (byte_0[6] - 48) + byte_0[7] - 48))
								{
									return 0;
								}
								return 11;
							default:
								switch (c)
								{
								case 'V':
									goto IL_0108;
								case 'X':
								{
									byte[] array4 = lXu.f(lXu.mz());
									for (int i = 0; i < 8; i++)
									{
										if (array4[i] != byte_0[40 + i])
										{
											return 20;
										}
									}
									return lXu.eW(byte_0);
								}
								case 'Z':
									return lXu.eW(byte_0);
								}
								return 10;
							}
							IL_0108:
							byte[] array5 = new byte[41];
							lXu.t(byte_0, 0, array5, 0, 40);
							array5[40] = 0;
							lXu.ma(array5, 0);
							if (!lXu.K(array5, 0, 40).Equals("N1RN1R"))
							{
								num3 = num2;
							}
							else
							{
								num3 = 24;
							}
						}
						else
						{
							num3 = num2;
						}
					}
					else
					{
						num3 = 18;
					}
				}
				else
				{
					num3 = 17;
				}
			}
			else
			{
				num3 = 17;
			}
			return num3;
		}

		// Token: 0x0600E13D RID: 57661 RVA: 0x0054FE30 File Offset: 0x0054E030
		public static int ej(byte[] byte_0, char char_0)
		{
			byte b = lXu.mq(byte_0[5]);
			int num;
			if (b != 86)
			{
				if ((char)lXu.mq(byte_0[3]) == char_0)
				{
					num = 0;
				}
				else
				{
					num = 21;
				}
			}
			else
			{
				num = 0;
			}
			return num;
		}

		// Token: 0x0600E13E RID: 57662 RVA: 0x0054FE30 File Offset: 0x0054E030
		public static int ef(byte[] byte_0, char char_0)
		{
			byte b = lXu.mq(byte_0[5]);
			int num;
			if (b != 86)
			{
				if ((char)lXu.mq(byte_0[3]) == char_0)
				{
					num = 0;
				}
				else
				{
					num = 21;
				}
			}
			else
			{
				num = 0;
			}
			return num;
		}

		// Token: 0x0600E13F RID: 57663 RVA: 0x0054FE6C File Offset: 0x0054E06C
		public static int eG(byte[] byte_0, int int_0)
		{
			byte b = lXu.mq(byte_0[5]);
			int num2;
			if (lXu.mm(b))
			{
				int num = lXu.es(byte_0);
				if (int_0 <= num)
				{
					num2 = 0;
				}
				else
				{
					num2 = 13;
				}
			}
			else
			{
				num2 = 0;
			}
			return num2;
		}

		// Token: 0x0600E140 RID: 57664 RVA: 0x0054FEA8 File Offset: 0x0054E0A8
		public static int et(byte[] byte_0, int int_0)
		{
			byte b = lXu.mq(byte_0[5]);
			int num2;
			if (lXu.mm(b))
			{
				int num = lXu.es(byte_0);
				if (int_0 <= num)
				{
					num2 = 0;
				}
				else
				{
					num2 = 14;
				}
			}
			else
			{
				num2 = 0;
			}
			return num2;
		}

		// Token: 0x0600E141 RID: 57665 RVA: 0x0054FEE4 File Offset: 0x0054E0E4
		public static int eW(byte[] byte_0)
		{
			byte_0[byte_0.Length - 1] = 0;
			lXu.ma(byte_0, 0);
			if (lXu.s(byte_0[5]))
			{
				int num = (int)(10 * (byte_0[12] - 48) + (byte_0[13] - 48));
				DateTime now = DateTime.Now;
				int num2 = lXu.pp(now.Year, now.Month, now.Day);
				int num3 = (int)(10 * (byte_0[10] - 48) + (byte_0[11] - 48)) + 2000;
				int num4 = (int)(10 * (byte_0[6] - 48) + (byte_0[7] - 48));
				int num5 = (int)(10 * (byte_0[8] - 48) + (byte_0[9] - 48));
				int num6 = lXu.pp(num3, num4, num5);
				if (num2 >= num6 + num)
				{
					return 9;
				}
				if (num2 < num6 - 1)
				{
					return 12;
				}
			}
			if (lXu.mx(byte_0[5]))
			{
				if (byte_0[6] <= 56)
				{
					byte b = byte_0[6] - 48;
				}
			}
			return 0;
		}

		// Token: 0x0600E142 RID: 57666 RVA: 0x0054FFE0 File Offset: 0x0054E1E0
		public static int eD(byte[] byte_0)
		{
			byte_0[byte_0.Length - 1] = 0;
			lXu.ma(byte_0, 0);
			int num;
			if (!lXu.s(byte_0[5]))
			{
				num = 0;
			}
			else
			{
				int num2 = (int)(10 * (byte_0[12] - 48) + (byte_0[13] - 48));
				DateTime now = DateTime.Now;
				int num3 = lXu.pp(now.Year, now.Month, now.Day);
				int num4 = (int)(10 * (byte_0[10] - 48) + (byte_0[11] - 48)) + 2000;
				int num5 = (int)(10 * (byte_0[6] - 48) + (byte_0[7] - 48));
				int num6 = (int)(10 * (byte_0[8] - 48) + (byte_0[9] - 48));
				int num7 = lXu.pp(num4, num5, num6);
				if (num3 < num7 + num2)
				{
					if (num3 >= num7 - 1)
					{
						num = num7 + num2 - num3;
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
			return num;
		}

		// Token: 0x0600E143 RID: 57667 RVA: 0x005500BC File Offset: 0x0054E2BC
		public static int ei(byte[] byte_0)
		{
			byte_0[byte_0.Length - 1] = 0;
			lXu.ma(byte_0, 0);
			int num;
			if (!lXu.s(byte_0[5]))
			{
				num = 0;
			}
			else
			{
				num = (int)(10 * (byte_0[12] - 48) + (byte_0[13] - 48));
			}
			return num;
		}

		// Token: 0x0600E144 RID: 57668 RVA: 0x00550100 File Offset: 0x0054E300
		public static int es(byte[] byte_0)
		{
			int num4;
			if (byte_0[0] != 0 && lXu.mm(lXu.mq(byte_0[5])))
			{
				int num = 1000 * (int)(byte_0[10] - 48) + (int)(100 * (byte_0[11] - 48)) + (int)(10 * (byte_0[12] - 48)) + (int)(byte_0[13] - 48);
				int num2 = (int)(10 * (byte_0[14] - 48) + (byte_0[15] - 48));
				int num3 = (int)(10 * (byte_0[16] - 48) + (byte_0[17] - 48));
				num4 = (new DateTime(num, num2, num3, 0, 0, 0, DateTimeKind.Utc) - new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Utc)).Days;
			}
			else
			{
				num4 = -1;
			}
			return num4;
		}

		// Token: 0x0600E145 RID: 57669 RVA: 0x005501B4 File Offset: 0x0054E3B4
		public static bool px(string string_0)
		{
			string text = lXu.pe(string_0);
			return text.Equals("SRRF") || text.Equals("1SRV");
		}

		// Token: 0x0600E146 RID: 57670 RVA: 0x005501E4 File Offset: 0x0054E3E4
		public static bool pm(string string_0)
		{
			string text = lXu.pe(string_0);
			return text.Equals("1DEV");
		}

		// Token: 0x0600E147 RID: 57671 RVA: 0x00550204 File Offset: 0x0054E404
		public static string pe(string string_0)
		{
			string text = "";
			int num = 6;
			int length = string_0.Length;
			bool flag;
			if (length <= 6)
			{
				flag = true;
			}
			else
			{
				if (string_0[6] != 'S')
				{
					if (string_0[6] != 'Z')
					{
						flag = true;
						goto IL_0014;
					}
				}
				flag = string_0[7] != 'U';
			}
			IL_0014:
			if (!flag)
			{
				num = 12;
			}
			if (length >= num + 4)
			{
				text = string_0.Substring(num, 4);
			}
			string text2;
			if (!text.Contains("ENT"))
			{
				if (!text.Contains("STD"))
				{
					if (!text.Contains("PRO") && !text.Contains("PR0"))
					{
						if (!text.Equals("S1TE"))
						{
							text2 = text;
						}
						else
						{
							text2 = "SITE";
						}
					}
					else
					{
						text2 = "PRO";
					}
				}
				else
				{
					text2 = "STD";
				}
			}
			else
			{
				text2 = "ENT";
			}
			return text2;
		}

		// Token: 0x0600E148 RID: 57672 RVA: 0x005502E4 File Offset: 0x0054E4E4
		public static int pp(int int_0, int int_1, int int_2)
		{
			bool flag = (int_0 % 4 == 0 && int_0 % 100 != 0) || int_0 % 400 == 0;
			int[] array = new int[]
			{
				31, 0, 31, 30, 31, 30, 31, 31, 30, 31,
				30, 31
			};
			array[1] = ((!flag) ? 28 : 29);
			int[] array2 = array;
			if (int_0 >= 2000 && int_1 > 0 && int_1 <= array2.Length && int_2 > 0 && int_2 <= array2[int_1 - 1])
			{
				int num = 0;
				for (int i = 0; i < int_1 - 1; i++)
				{
					num += array2[i];
				}
				return 365 * (int_0 - 2000) + num + int_2;
			}
			throw new Exception("Invlaid License: Subscription Key does not have an expiration date.");
		}

		// Token: 0x04005A8E RID: 23182
		public const int q = 0;

		// Token: 0x04005A8F RID: 23183
		public const int F = 1;

		// Token: 0x04005A90 RID: 23184
		public const int m = 2;

		// Token: 0x04005A91 RID: 23185
		public const int L = 3;

		// Token: 0x04005A92 RID: 23186
		public const int S = 4;

		// Token: 0x04005A93 RID: 23187
		public const int I = 5;

		// Token: 0x04005A94 RID: 23188
		public const int b = 6;

		// Token: 0x04005A95 RID: 23189
		public const int a = 7;

		// Token: 0x04005A96 RID: 23190
		public const int j = 8;

		// Token: 0x04005A97 RID: 23191
		public const int n = 9;

		// Token: 0x04005A98 RID: 23192
		public const int G = 12;

		// Token: 0x04005A99 RID: 23193
		public const int u = 13;

		// Token: 0x04005A9A RID: 23194
		public const int V = 14;

		// Token: 0x04005A9B RID: 23195
		public const int C = 10;

		// Token: 0x04005A9C RID: 23196
		public const int y = 11;

		// Token: 0x04005A9D RID: 23197
		public const int O = 17;

		// Token: 0x04005A9E RID: 23198
		public const int D = 18;

		// Token: 0x04005A9F RID: 23199
		public const int r = 19;

		// Token: 0x04005AA0 RID: 23200
		public const int e = 20;

		// Token: 0x04005AA1 RID: 23201
		public const int H = 21;

		// Token: 0x04005AA2 RID: 23202
		public const int X = 22;

		// Token: 0x04005AA3 RID: 23203
		public const int w = 24;

		// Token: 0x04005AA4 RID: 23204
		public const int k = 25;

		// Token: 0x04005AA5 RID: 23205
		public const string T = "This system contains a license for {0} that has been installed but not activated.  You must run setup in order to activate the license on this system [code: {3} nodeid: {4}].";

		// Token: 0x04005AA6 RID: 23206
		public const string p = "This system contains a trial license for {0} that has expired.  Please visit {1} or email {2} for information on purchasing a license or extending your trial [code: {3} nodeid: {4}].";

		// Token: 0x04005AA7 RID: 23207
		public const string z = "Could not find a valid license for using {0} on this system.  To obtain a trial license, please visit {1} or email {2} [code: {3} nodeid: {4}].";

		// Token: 0x04005AA8 RID: 23208
		public const string Fq = "The beta version of {0} used by this application has expired.\nPlease visit {1} for an updated version.";

		// Token: 0x04005AA9 RID: 23209
		public const string FF = "Error reading registry: {0}";

		// Token: 0x04005AAA RID: 23210
		public const string Fm = "Could not find a valid license for using {0} on this system.  To obtain a trial license, please visit {1} or email {2} [code: {3} nodeid: {4}].If you believe you already have a license, please check the following path(s):{5}, {6}.";

		// Token: 0x04005AAB RID: 23211
		public const string FL = "You must enter a valid Product Key in order to continue.";

		// Token: 0x04005AAC RID: 23212
		public const string FS = "Invalid product key [code: {0} nodeid: {1}].";

		// Token: 0x04005AAD RID: 23213
		public const string FI = "Error validating user input: {0}";

		// Token: 0x04005AAE RID: 23214
		public const string Fb = "Contact {0} for further help.";

		// Token: 0x04005AAF RID: 23215
		public const string Fa = "Error downloading license: {0}";

		// Token: 0x04005AB0 RID: 23216
		public const string Fj = "\r\nPlease try to activate manually by going to:";

		// Token: 0x04005AB1 RID: 23217
		public const string Fn = "License verification failed [code: {0}]. Please try again.";

		// Token: 0x04005AB2 RID: 23218
		public const string FG = "Could not find {0}.jdbc.{1}.jar.";

		// Token: 0x04005AB3 RID: 23219
		public const string Fu = "The license check failed for the following reason: {0}, code: {1}";

		// Token: 0x04005AB4 RID: 23220
		public const string FV = "Failed to get system version information. [code: {0} nodeid: {1}]";

		// Token: 0x04005AB5 RID: 23221
		public const string FC = "This application uses an evaluation version of the {0}. You may test it for a period of 30 days as specified in the Licensing Agreement. Further use requires a license. For more information, please visit {2}.";

		// Token: 0x04005AB6 RID: 23222
		public const string Fy = "This license can not be used in a Server Operating System [code: {1} nodeid: {2}]";

		// Token: 0x04005AB7 RID: 23223
		public const string FO = "License installation succeeded.";

		// Token: 0x04005AB8 RID: 23224
		internal static byte[] FD = new byte[32];

		// Token: 0x02000B59 RID: 2905
		public sealed class Gs
		{
			// Token: 0x0600E14A RID: 57674 RVA: 0x00550390 File Offset: 0x0054E590
			public lmD<string, string> r(string string_0)
			{
				byte[] array = Eyf.wO(string_0);
				byte[] array2 = CdataSchemaCodec.CopyEncryptedPayload(array);
				byte[] array3 = new lXu.Gs.GN(this.i).r(array2);
				lmD<string, string> lmD = this.B(array3);
				lmD.H("VER", string.Concat(array[0]));
				return lmD;
			}

			// Token: 0x0600E14B RID: 57675 RVA: 0x005503F4 File Offset: 0x0054E5F4
			private lmD<string, string> B(byte[] byte_0)
			{
				lmD<string, string> fields = new lmD<string, string>();
				int offset = 0;
				while (offset < byte_0.Length)
				{
					int field = CdataSchemaCodec.ReadField(byte_0, ref offset, this.D.Length, out string value);
					fields.H(this.D[field], value);
				}
				return fields;
			}

			// Token: 0x04005AB9 RID: 23225
			private readonly string i = "CDATA#1";

			// Token: 0x04005ABA RID: 23226
			private readonly string[] D = new string[] { "TIME", "NID", "SKEY", "RTK", "OKEY", "QCNT", "CCNT", "SKU", "BETA", "VERCODE" };

			// Token: 0x02000B5A RID: 2906
			private sealed class GN
			{
				// Token: 0x0600E14E RID: 57678 RVA: 0x00550624 File Offset: 0x0054E824
				public GN(string string_0)
				{
					byte[] array = new byte[16];
					try
					{
						byte[] array2 = Eyf.Ip(string_0, "utf-8");
						lyc.E(array2, 0, array, 0, (array2.Length >= 16) ? 16 : array2.Length);
					}
					catch (Exception)
					{
					}
					this.m = new uint[4];
					int num = 0;
					for (int i = 0; i < 4; i++)
					{
						this.m[i] = (uint)((int)(array[num++] & byte.MaxValue) | ((int)(array[num++] & byte.MaxValue) << 8) | ((int)(array[num++] & byte.MaxValue) << 16) | ((int)(array[num++] & byte.MaxValue) << 24));
					}
				}

				// Token: 0x0600E14F RID: 57679 RVA: 0x005506E0 File Offset: 0x0054E8E0
				public byte[] r(byte[] byte_0)
				{
					byte[] array3;
					if (byte_0 != null && byte_0.Length >= 1)
					{
						uint[] array = new uint[byte_0.Length / 4];
						this.n(byte_0, 0, array, 0);
						int payloadLength = CdataSchemaCodec.ReadPayloadLength(array[0], byte_0.Length - 4);
						this.c(array, 1, this.m);
						byte[] array2 = new byte[payloadLength];
						this.t(array, 1, array2, 0);
						array3 = array2;
					}
					else
					{
						array3 = new byte[0];
					}
					return array3;
				}

				// Token: 0x0600E150 RID: 57680 RVA: 0x00550764 File Offset: 0x0054E964
				private void c(uint[] uint_0, int int_0, uint[] uint_1)
				{
					uint num = 2654435769U;
					uint num2 = 3337565984U;
					int i = int_0;
					int num3 = uint_0.Length;
					while (i < num3)
					{
						uint num4 = uint_0[i];
						uint num5 = uint_0[i + 1];
						uint num6 = num2;
						int num7 = 32;
						while (num7-- > 0)
						{
							num5 -= (((num4 << 4) + uint_1[2]) ^ num4) + (num6 ^ (num4 >> 5)) + uint_1[3];
							num4 -= (((num5 << 4) + uint_1[0]) ^ num5) + (num6 ^ (num5 >> 5)) + uint_1[1];
							num6 -= num;
						}
						uint_0[i] = num4;
						uint_0[i + 1] = num5;
						i += 2;
					}
				}

				// Token: 0x0600E151 RID: 57681 RVA: 0x005507F4 File Offset: 0x0054E9F4
				private void n(byte[] byte_0, int int_0, uint[] uint_0, int int_1)
				{
					int num = 24;
					uint_0[int_1] = 0U;
					int i = int_0;
					int num2 = int_1;
					while (i < byte_0.Length)
					{
						uint_0[num2] |= (uint)((uint)(byte_0[i] & byte.MaxValue) << num);
						if (num != 0)
						{
							num -= 8;
						}
						else
						{
							num2++;
							num = 24;
							if (num2 < uint_0.Length)
							{
								uint_0[num2] = 0U;
							}
						}
						i++;
					}
				}

				// Token: 0x0600E152 RID: 57682 RVA: 0x00550864 File Offset: 0x0054EA64
				private void t(uint[] uint_0, int int_0, byte[] byte_0, int int_1)
				{
					int num = 0;
					int num2 = byte_0.Length;
					int num3 = int_0;
					for (int i = int_1; i < num2; i++)
					{
						byte_0[i] = (byte)((uint_0[num3] >> 24 - 8 * num) & 255U);
						num++;
						if (num == 4)
						{
							num = 0;
							num3++;
						}
					}
				}

				// Token: 0x04005ABB RID: 23227
				private uint[] m;
			}
		}
	}
}
