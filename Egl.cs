using System;
using System.IO;

namespace Arc264y
{
	// Token: 0x0200117C RID: 4476
	internal class Egl
	{
		// Token: 0x060112AF RID: 70319 RVA: 0x0007536A File Offset: 0x0007356A
		public Egl()
		{
		}

		// Token: 0x060112B0 RID: 70320 RVA: 0x000753A0 File Offset: 0x000735A0
		public Egl(lcX lcX_0)
		{
			this.W = lcX_0;
		}

		// Token: 0x060112B1 RID: 70321 RVA: 0x000753DD File Offset: 0x000735DD
		public Egl(bool bool_0)
		{
			this.u = bool_0;
		}

		// Token: 0x060112B2 RID: 70322 RVA: 0x0068BE94 File Offset: 0x0068A094
		public Egl(lcX lcX_0, bool bool_0)
		{
			this.W = lcX_0;
			this.u = bool_0;
		}

		// Token: 0x060112B3 RID: 70323 RVA: 0x0068BEE4 File Offset: 0x0068A0E4
		public Egl Q()
		{
			this.m();
			this.PE("{");
			this.J++;
			this.X = false;
			return this;
		}

		// Token: 0x060112B4 RID: 70324 RVA: 0x0068BF1C File Offset: 0x0068A11C
		public Egl f()
		{
			this.J--;
			if (this.u && this.X)
			{
				this.PA();
			}
			this.PE("}");
			this.X = true;
			return this;
		}

		// Token: 0x060112B5 RID: 70325 RVA: 0x0068BF6C File Offset: 0x0068A16C
		public Egl i()
		{
			this.m();
			this.PE("[");
			this.J++;
			this.X = false;
			return this;
		}

		// Token: 0x060112B6 RID: 70326 RVA: 0x0068BFA4 File Offset: 0x0068A1A4
		public Egl A()
		{
			this.J--;
			if (this.u && this.X)
			{
				this.PA();
			}
			this.PE("]");
			this.X = true;
			return this;
		}

		// Token: 0x060112B7 RID: 70327 RVA: 0x0068BFF4 File Offset: 0x0068A1F4
		public Egl E(string string_0)
		{
			return this.c(string_0, true);
		}

		// Token: 0x060112B8 RID: 70328 RVA: 0x0068C00C File Offset: 0x0068A20C
		public Egl c(string string_0, bool bool_0)
		{
			this.m();
			return this.D(string_0, bool_0);
		}

		// Token: 0x060112B9 RID: 70329 RVA: 0x0068C02C File Offset: 0x0068A22C
		public Egl t(string string_0, string string_1)
		{
			return this.H(string_0, string_1, true);
		}

		// Token: 0x060112BA RID: 70330 RVA: 0x0068C044 File Offset: 0x0068A244
		public Egl H(string string_0, string string_1, bool bool_0)
		{
			return this.G(string_0).D(string_1, bool_0);
		}

		// Token: 0x060112BB RID: 70331 RVA: 0x0068C064 File Offset: 0x0068A264
		public Egl G(string string_0)
		{
			this.m();
			this.PE(Eyf.mO(string_0));
			this.PE((!this.u) ? ":" : ": ");
			this.a = true;
			return this;
		}

		// Token: 0x060112BC RID: 70332 RVA: 0x0068C0A8 File Offset: 0x0068A2A8
		public Egl D(string string_0, bool bool_0)
		{
			if (string_0 != null)
			{
				this.PE((!bool_0) ? string_0 : Egl.Pc(string_0));
			}
			else
			{
				this.PE("null");
			}
			this.X = true;
			this.a = false;
			return this;
		}

		// Token: 0x060112BD RID: 70333 RVA: 0x0068C0F0 File Offset: 0x0068A2F0
		public Egl K(string string_0)
		{
			return this.x(string_0, true);
		}

		// Token: 0x060112BE RID: 70334 RVA: 0x0068C108 File Offset: 0x0068A308
		public Egl x(string string_0, bool bool_0)
		{
			if (bool_0)
			{
				this.m();
			}
			this.PE(string_0);
			if (bool_0)
			{
				this.X = true;
				this.a = false;
			}
			return this;
		}

		// Token: 0x060112BF RID: 70335 RVA: 0x0068C144 File Offset: 0x0068A344
		public Egl m()
		{
			if (this.X)
			{
				this.PE(",");
			}
			if (this.u && !this.a && this.J > 0)
			{
				this.PA();
			}
			this.X = false;
			this.a = false;
			return this;
		}

		// Token: 0x060112C0 RID: 70336 RVA: 0x0068C1A4 File Offset: 0x0068A3A4
		public bool PQ()
		{
			return this.u;
		}

		// Token: 0x060112C1 RID: 70337 RVA: 0x0068C1B8 File Offset: 0x0068A3B8
		public Egl Pf(bool bool_0)
		{
			this.u = bool_0;
			return this;
		}

		// Token: 0x060112C2 RID: 70338 RVA: 0x0068C1D0 File Offset: 0x0068A3D0
		public Egl Pi()
		{
			this.X = false;
			this.a = false;
			this.J = 0;
			this.M.j(0);
			this.W = null;
			return this;
		}

		// Token: 0x060112C3 RID: 70339 RVA: 0x0068C208 File Offset: 0x0068A408
		public override string ToString()
		{
			return this.M.ToString();
		}

		// Token: 0x060112C4 RID: 70340 RVA: 0x0068C224 File Offset: 0x0068A424
		private void PA()
		{
			this.PE("\n");
			for (int i = 0; i < this.J; i++)
			{
				this.PE("  ");
			}
		}

		// Token: 0x060112C5 RID: 70341 RVA: 0x0068C25C File Offset: 0x0068A45C
		private void PE(string string_0)
		{
			if (this.W != null)
			{
				try
				{
					this.W.MPw(Eyf.IV(string_0));
					return;
				}
				catch (IOException ex)
				{
					throw new Egs(ex);
				}
			}
			this.M.MPI(string_0);
		}

		// Token: 0x060112C6 RID: 70342 RVA: 0x0068C2B0 File Offset: 0x0068A4B0
		private static string Pc(string string_0)
		{
			string text;
			if (string_0 != null)
			{
				if (string_0.Length > 0)
				{
					text = Eyf.mO(string_0);
				}
				else
				{
					text = "\"\"";
				}
			}
			else
			{
				text = "null";
			}
			return text;
		}

		// Token: 0x04007908 RID: 30984
		private const string p = "  ";

		// Token: 0x04007909 RID: 30985
		private bool X = false;

		// Token: 0x0400790A RID: 30986
		private bool a = false;

		// Token: 0x0400790B RID: 30987
		private bool u = false;

		// Token: 0x0400790C RID: 30988
		private int J = 0;

		// Token: 0x0400790D RID: 30989
		private lcc M = new lcc();

		// Token: 0x0400790E RID: 30990
		private lcX W = null;
	}
}
