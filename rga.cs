using System;
using System.Threading;
using RSSBus;

namespace Arc264y
{
	// Token: 0x02000E61 RID: 3681
	public class rga
	{
		// Token: 0x0600F906 RID: 63750 RVA: 0x0006F2F1 File Offset: 0x0006D4F1
		protected internal rga(string string_0)
		{
			this.N = string_0;
			this.E = new lmr<lBo>();
			this.A = null;
		}

		// Token: 0x0600F907 RID: 63751 RVA: 0x005F51E0 File Offset: 0x005F33E0
		public string r()
		{
			return this.N;
		}

		// Token: 0x0600F908 RID: 63752 RVA: 0x005F51F8 File Offset: 0x005F33F8
		public rgw n()
		{
			return this.c;
		}

		// Token: 0x0600F909 RID: 63753 RVA: 0x0006F323 File Offset: 0x0006D523
		public void t(rgw rgw_0)
		{
			this.c = rgw_0;
		}

		// Token: 0x0600F90A RID: 63754 RVA: 0x005F5210 File Offset: 0x005F3410
		public bool Q(rgw rgw_0)
		{
			return this.c.j(rgw_0);
		}

		// Token: 0x0600F90B RID: 63755 RVA: 0x0006F32E File Offset: 0x0006D52E
		public void V(string string_0)
		{
			this.u(string_0, null);
		}

		// Token: 0x0600F90C RID: 63756 RVA: 0x005F522C File Offset: 0x005F342C
		public void u(string string_0, object object_0)
		{
			if (this.bc(rgw.J) || this.Q(rgw.J))
			{
				rgh rgh = new rgh(rgw.J, string_0);
				rgh.G(object_0);
				if (this.bc(rgw.J))
				{
					this.bn(rgh);
				}
				if (this.Q(rgw.J))
				{
					this.br(rgh);
				}
			}
		}

		// Token: 0x0600F90D RID: 63757 RVA: 0x0006F338 File Offset: 0x0006D538
		public void Z(string string_0)
		{
			this.kr(string_0, null);
		}

		// Token: 0x0600F90E RID: 63758 RVA: 0x005F529C File Offset: 0x005F349C
		public void kr(string string_0, object object_0)
		{
			if (this.bc(rgw.b) || this.Q(rgw.b))
			{
				rgh rgh = new rgh(rgw.b, string_0);
				rgh.G(object_0);
				if (this.bc(rgw.b))
				{
					this.bn(rgh);
				}
				this.br(rgh);
			}
		}

		// Token: 0x0600F90F RID: 63759 RVA: 0x0006F342 File Offset: 0x0006D542
		public void kc(string string_0)
		{
			this.kn(string_0, null);
		}

		// Token: 0x0600F910 RID: 63760 RVA: 0x005F52FC File Offset: 0x005F34FC
		public void kn(string string_0, object object_0)
		{
			if (this.bc(rgw.M) || this.Q(rgw.M))
			{
				rgh rgh = new rgh(rgw.M, string_0);
				rgh.G(object_0);
				if (this.bc(rgw.M))
				{
					this.bn(rgh);
				}
				this.br(rgh);
			}
		}

		// Token: 0x0600F911 RID: 63761 RVA: 0x0006F34C File Offset: 0x0006D54C
		public void kt(string string_0, Exception exception_0)
		{
			this.kQ(string_0, exception_0, null);
		}

		// Token: 0x0600F912 RID: 63762 RVA: 0x005F535C File Offset: 0x005F355C
		public void kQ(string string_0, Exception exception_0, object object_0)
		{
			if (this.bc(rgw.a) || this.Q(rgw.a))
			{
				if (!Eyf.lx(string_0) || exception_0 != null)
				{
					lcc lcc = new lcc();
					if (!Eyf.lx(string_0))
					{
						lcc.MPI(string_0);
					}
					if (exception_0 != null)
					{
						if (lcc.D > 0)
						{
							lcc.MPI(": ");
						}
						lcc.MPI(exception_0.GetType().Name).MPI(": ");
						if (exception_0 is RSBException)
						{
							lcc.MPI("[").MPI(((RSBException)exception_0).GetCode()).MPI("] ");
						}
						if (!Eyf.lx(exception_0.Message))
						{
							lcc.MPI(exception_0.Message);
						}
						lcc.MPI(Environment.NewLine).MPI(rgJ.H(exception_0));
					}
					rgh rgh = new rgh(rgw.a, lcc.ToString());
					rgh.B(exception_0);
					rgh.G(object_0);
					if (this.bc(rgw.a))
					{
						this.bn(rgh);
					}
					if (this.Q(rgw.a))
					{
						this.br(rgh);
					}
				}
				else
				{
					rgh rgh2 = new rgh(rgw.a, null);
					rgh2.G(object_0);
					this.br(rgh2);
				}
			}
		}

		// Token: 0x0600F913 RID: 63763 RVA: 0x0006F357 File Offset: 0x0006D557
		public void kV(string string_0)
		{
			this.ku(string_0, null);
		}

		// Token: 0x0600F914 RID: 63764 RVA: 0x005F54F0 File Offset: 0x005F36F0
		public void ku(string string_0, object object_0)
		{
			if (this.bc(rgw.l) || this.Q(rgw.l))
			{
				rgh rgh = new rgh(rgw.l, string_0);
				rgh.G(object_0);
				if (this.bc(rgw.l))
				{
					this.bn(rgh);
				}
				if (this.Q(rgw.l))
				{
					this.br(rgh);
				}
			}
		}

		// Token: 0x0600F915 RID: 63765 RVA: 0x0006F361 File Offset: 0x0006D561
		public void kZ(rgw rgw_0, string string_0)
		{
			this.Fr(rgw_0, string_0, null);
		}

		// Token: 0x0600F916 RID: 63766 RVA: 0x005F5560 File Offset: 0x005F3760
		public void Fr(rgw rgw_0, string string_0, object object_0)
		{
			if (rgw_0 == null)
			{
				rgw_0 = rgw.J;
			}
			if (this.bc(rgw_0) || this.Q(rgw_0))
			{
				rgh rgh = new rgh(rgw_0, string_0);
				rgh.G(object_0);
				if (this.bc(rgw_0))
				{
					this.bn(rgh);
				}
				if (this.Q(rgw_0))
				{
					this.br(rgh);
				}
			}
		}

		// Token: 0x0600F917 RID: 63767 RVA: 0x005F55D0 File Offset: 0x005F37D0
		public void Fc(rgh rgh_0)
		{
			if (null != rgh_0 && (this.bc(rgh_0.s()) || this.Q(rgh_0.s())))
			{
				if (this.bc(rgh_0.s()))
				{
					this.bn(rgh_0);
				}
				if (this.Q(rgh_0.s()))
				{
					this.br(rgh_0);
				}
			}
		}

		// Token: 0x0600F918 RID: 63768 RVA: 0x005F563C File Offset: 0x005F383C
		public lBo[] Fn()
		{
			return this.E.c(rga.D);
		}

		// Token: 0x0600F919 RID: 63769 RVA: 0x005F5660 File Offset: 0x005F3860
		public virtual void FMN(lBo lBo_0)
		{
			lBo_0.GetType();
			lock (this)
			{
				this.E = new lmr<lBo>(this.E) { lBo_0 };
			}
		}

		// Token: 0x0600F91A RID: 63770 RVA: 0x005F56C0 File Offset: 0x005F38C0
		public virtual void FMw(lBo lBo_0)
		{
			lBo_0.GetType();
			lock (this)
			{
				int num = this.E.IndexOf(lBo_0);
				if (num >= 0)
				{
					lmr<lBo> lmr = new lmr<lBo>(this.E);
					lmr.Remove(lBo_0);
					this.E = lmr;
				}
			}
			lBo_0.MkR();
		}

		// Token: 0x0600F91B RID: 63771 RVA: 0x0006F36C File Offset: 0x0006D56C
		public void Ft(lBo lBo_0)
		{
			this.A = lBo_0;
		}

		// Token: 0x0600F91C RID: 63772 RVA: 0x005F573C File Offset: 0x005F393C
		public static rga FQ(string string_0)
		{
			return rgi.t(string_0);
		}

		// Token: 0x0600F91D RID: 63773 RVA: 0x005F5754 File Offset: 0x005F3954
		public static rga FV(string string_0, string string_1)
		{
			return rgi.W(string_0, string_1);
		}

		// Token: 0x0600F91E RID: 63774 RVA: 0x005F576C File Offset: 0x005F396C
		public static rga Fu(string string_0, string string_1)
		{
			if (string_1 != null)
			{
				lfv.f("currentModule", string_1);
			}
			else
			{
				lfv.D("currentModule");
			}
			return rgi.t(string_0);
		}

		// Token: 0x0600F91F RID: 63775 RVA: 0x005F57A4 File Offset: 0x005F39A4
		public void FZ()
		{
			lBo[] array = this.Fn();
			foreach (lBo lBo in array)
			{
				lBo.MkR();
			}
			if (this.A != null)
			{
				goto IL_0068;
			}
			IL_0035:
			lock (this)
			{
				this.E = new lmr<lBo>();
				this.A = null;
				return;
			}
			IL_0068:
			this.A.MkR();
			goto IL_0035;
		}

		// Token: 0x0600F920 RID: 63776 RVA: 0x005F5838 File Offset: 0x005F3A38
		private void br(rgh rgh_0)
		{
			if (this.c.j(rgh_0.s()))
			{
				this.bt(rgh_0);
				lBo[] array = this.Fn();
				foreach (lBo lBo in array)
				{
					lBo.Mkd(rgh_0);
				}
			}
		}

		// Token: 0x0600F921 RID: 63777 RVA: 0x005F588C File Offset: 0x005F3A8C
		private bool bc(rgw rgw_0)
		{
			return this.A != null && rgw.J.j(rgw_0);
		}

		// Token: 0x0600F922 RID: 63778 RVA: 0x005F58B4 File Offset: 0x005F3AB4
		private void bn(rgh rgh_0)
		{
			if (this.A != null)
			{
				this.bt(rgh_0);
				this.A.Mkd(rgh_0);
			}
		}

		// Token: 0x0600F923 RID: 63779 RVA: 0x005F58E8 File Offset: 0x005F3AE8
		private void bt(rgh rgh_0)
		{
			rgh_0.ws((long)Thread.CurrentThread.ManagedThreadId);
			if (rgh_0.wO() == null)
			{
				object obj = lfv.m("currentCorrelationId");
				if (obj is string)
				{
					rgh_0.wA((string)obj);
				}
			}
			if (Eyf.lx(rgh_0.wu()))
			{
				object obj2 = lfv.m("currentModule");
				if (obj2 is string)
				{
					rgh_0.wt((string)obj2);
				}
			}
		}

		// Token: 0x040069B3 RID: 27059
		public const string v = "application";

		// Token: 0x040069B4 RID: 27060
		public const string M = "request";

		// Token: 0x040069B5 RID: 27061
		public const string k = "audit";

		// Token: 0x040069B6 RID: 27062
		private readonly string N;

		// Token: 0x040069B7 RID: 27063
		private volatile lmr<lBo> E;

		// Token: 0x040069B8 RID: 27064
		private volatile lBo A;

		// Token: 0x040069B9 RID: 27065
		private volatile rgw c = rgw.J;

		// Token: 0x040069BA RID: 27066
		private static Type D = typeof(lBo);
	}
}
