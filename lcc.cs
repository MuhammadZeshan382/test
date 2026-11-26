using System;
using System.Reflection;
using System.Text;

namespace Arc264y
{
	// Token: 0x02000B46 RID: 2886
	[DefaultMember("Item")]
	internal class lcc
	{
		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600E05F RID: 57439 RVA: 0x0054D6F8 File Offset: 0x0054B8F8
		// (set) Token: 0x0600E060 RID: 57440 RVA: 0x00069B67 File Offset: 0x00067D67
		public int D
		{
			get
			{
				return this.Y.Length;
			}
			set
			{
				this.Y.Length = value;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600E061 RID: 57441 RVA: 0x0054D714 File Offset: 0x0054B914
		public char p
		{
			get
			{
				return this.Y[int_0];
			}
		}

		// Token: 0x0600E062 RID: 57442 RVA: 0x00069B75 File Offset: 0x00067D75
		public lcc(byte[] byte_0)
			: this()
		{
			this.MPI(byte_0);
		}

		// Token: 0x0600E063 RID: 57443 RVA: 0x00069B85 File Offset: 0x00067D85
		public lcc(string string_0)
			: this()
		{
			this.MPI(string_0);
		}

		// Token: 0x0600E064 RID: 57444 RVA: 0x00069B95 File Offset: 0x00067D95
		public lcc()
		{
			this.Y = new StringBuilder();
		}

		// Token: 0x0600E065 RID: 57445 RVA: 0x00069BA8 File Offset: 0x00067DA8
		public lcc(int int_0)
		{
			this.Y = new StringBuilder(int_0);
		}

		// Token: 0x0600E066 RID: 57446 RVA: 0x00069BBC File Offset: 0x00067DBC
		public void j(int int_0)
		{
			this.D = int_0;
		}

		// Token: 0x0600E067 RID: 57447 RVA: 0x0054D730 File Offset: 0x0054B930
		public virtual lcc MPI(byte byte_0)
		{
			this.Y.Append(byte_0);
			return this;
		}

		// Token: 0x0600E068 RID: 57448 RVA: 0x0054D750 File Offset: 0x0054B950
		public virtual lcc MPI(object object_0)
		{
			return this.MPI(object_0.ToString());
		}

		// Token: 0x0600E069 RID: 57449 RVA: 0x0054D750 File Offset: 0x0054B950
		public virtual lcc MPI(lcc lcc_0)
		{
			return this.MPI(lcc_0.ToString());
		}

		// Token: 0x0600E06A RID: 57450 RVA: 0x0054D76C File Offset: 0x0054B96C
		public virtual lcc MPI(byte[] byte_0)
		{
			return this.MPq(byte_0, 0, byte_0.Length);
		}

		// Token: 0x0600E06B RID: 57451 RVA: 0x0054D788 File Offset: 0x0054B988
		public virtual lcc MPq(byte[] byte_0, int int_0, int int_1)
		{
			this.Y.Append(lcP.na().GetChars(byte_0, int_0, int_1));
			return this;
		}

		// Token: 0x0600E06C RID: 57452 RVA: 0x0054D7B4 File Offset: 0x0054B9B4
		public virtual lcc MPq(string string_0, int int_0, int int_1)
		{
			this.Y.Append(string_0, int_0, int_1 - int_0);
			return this;
		}

		// Token: 0x0600E06D RID: 57453 RVA: 0x0054D7D8 File Offset: 0x0054B9D8
		public virtual lcc MPI(string string_0)
		{
			this.Y.Append(string_0);
			return this;
		}

		// Token: 0x0600E06E RID: 57454 RVA: 0x0054D7F8 File Offset: 0x0054B9F8
		public virtual lcc MPI(char char_0)
		{
			this.Y.Append(char_0);
			return this;
		}

		// Token: 0x0600E06F RID: 57455 RVA: 0x0054D818 File Offset: 0x0054BA18
		public virtual lcc MPN(int int_0, string string_0)
		{
			this.Y.Insert(int_0, string_0);
			return this;
		}

		// Token: 0x0600E070 RID: 57456 RVA: 0x0054D838 File Offset: 0x0054BA38
		public virtual lcc MPN(int int_0, char char_0)
		{
			this.Y.Insert(int_0, char_0);
			return this;
		}

		// Token: 0x0600E071 RID: 57457 RVA: 0x0054D858 File Offset: 0x0054BA58
		public virtual lcc W(int int_0, int int_1)
		{
			this.Y.Remove(int_0, int_1 - int_0);
			return this;
		}

		// Token: 0x0600E072 RID: 57458 RVA: 0x0054D878 File Offset: 0x0054BA78
		public virtual lcc MPq(char[] char_0, int int_0, int int_1)
		{
			this.Y.Append(char_0, int_0, int_1);
			return this;
		}

		// Token: 0x0600E073 RID: 57459 RVA: 0x0054D714 File Offset: 0x0054B914
		public char n(int int_0)
		{
			return this.Y[int_0];
		}

		// Token: 0x0600E074 RID: 57460 RVA: 0x00069BC5 File Offset: 0x00067DC5
		public void H(int int_0, char char_0)
		{
			this.Y[int_0] = char_0;
		}

		// Token: 0x0600E075 RID: 57461 RVA: 0x0054D898 File Offset: 0x0054BA98
		public virtual byte[] c()
		{
			return lcP.nr(this.ToString());
		}

		// Token: 0x0600E076 RID: 57462 RVA: 0x0054D8B4 File Offset: 0x0054BAB4
		public override string ToString()
		{
			return this.Y.ToString();
		}

		// Token: 0x0600E077 RID: 57463 RVA: 0x0054D8D0 File Offset: 0x0054BAD0
		public lcc y()
		{
			char[] array = this.Y.ToString().ToCharArray();
			Array.Reverse(array);
			return new lcc(new string(array));
		}

		// Token: 0x0600E078 RID: 57464 RVA: 0x0054D904 File Offset: 0x0054BB04
		public string Q(int int_0, int int_1)
		{
			return this.Y.ToString(int_0, int_1);
		}

		// Token: 0x0600E079 RID: 57465 RVA: 0x0054D920 File Offset: 0x0054BB20
		public int FL(string string_0)
		{
			return this.Y.ToString().IndexOf(string_0);
		}

		// Token: 0x0600E07A RID: 57466 RVA: 0x0054D940 File Offset: 0x0054BB40
		public int Fu(string string_0)
		{
			return this.Y.ToString().LastIndexOf(string_0);
		}

		// Token: 0x0600E07B RID: 57467 RVA: 0x0054D960 File Offset: 0x0054BB60
		public int FG(string string_0, int int_0)
		{
			return this.Y.ToString().IndexOf(string_0, int_0);
		}

		// Token: 0x0600E07C RID: 57468 RVA: 0x0054D984 File Offset: 0x0054BB84
		public int Fj(string string_0, int int_0)
		{
			return this.Y.ToString().LastIndexOf(string_0, int_0);
		}

		// Token: 0x0600E07D RID: 57469 RVA: 0x0054D9A8 File Offset: 0x0054BBA8
		public lcc FW(int int_0, int int_1, string string_0)
		{
			if (int_0 >= 0 && int_0 < int_1 && int_1 <= this.Y.Length)
			{
				this.Y.Remove(int_0, int_1 - int_0);
				this.Y.Insert(int_0, string_0);
			}
			return this;
		}

		// Token: 0x0600E07E RID: 57470 RVA: 0x0054D9F4 File Offset: 0x0054BBF4
		public int Fn()
		{
			return this.Y.Capacity;
		}

		// Token: 0x04005A72 RID: 23154
		private StringBuilder Y;
	}
}
