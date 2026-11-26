using System;
using System.Runtime.CompilerServices;

namespace Arc264y
{
	// Token: 0x02001296 RID: 4758
	public abstract class Evi
	{
		// Token: 0x06012313 RID: 74515 RVA: 0x00078BF4 File Offset: 0x00076DF4
		protected internal Evi()
		{
		}

		// Token: 0x06012314 RID: 74516 RVA: 0x006FB124 File Offset: 0x006F9324
		public lmr<string> i(string string_0)
		{
			return (this.e.G() <= 0) ? new lmr<string>() : this.e.y(0).FRS(string_0, this.M, new Evi.yE(this.e));
		}

		// Token: 0x06012315 RID: 74517 RVA: 0x006FB16C File Offset: 0x006F936C
		public bool G(string string_0)
		{
			return this.e.G() > 0 && this.e.y(0).FRX(string_0, this.M, new Evi.yE(this.e));
		}

		// Token: 0x06012316 RID: 74518 RVA: 0x006FB1B0 File Offset: 0x006F93B0
		public string V(string string_0)
		{
			return (this.e.G() <= 0) ? null : this.e.y(0).FRP(string_0, this.M, new Evi.yE(this.e));
		}

		// Token: 0x06012317 RID: 74519 RVA: 0x006FB1F4 File Offset: 0x006F93F4
		public lcX E(string string_0)
		{
			return (this.e.G() <= 0) ? null : this.e.y(0).FRI(string_0, this.M, new Evi.yE(this.e));
		}

		// Token: 0x06012318 RID: 74520 RVA: 0x006FB238 File Offset: 0x006F9438
		public void p(string string_0, string string_1)
		{
			if (this.e.G() > 0)
			{
				this.e.y(0).FRq(string_0, string_1, this.M, new Evi.yE(this.e));
			}
		}

		// Token: 0x06012319 RID: 74521 RVA: 0x006FB27C File Offset: 0x006F947C
		public void H(string string_0, lcX lcX_0, bool bool_0)
		{
			if (this.e.G() > 0)
			{
				this.e.y(0).FRN(string_0, lcX_0, bool_0, this.M, new Evi.yE(this.e));
			}
		}

		// Token: 0x0601231A RID: 74522 RVA: 0x006FB2C4 File Offset: 0x006F94C4
		public void y(string string_0)
		{
			if (this.e.G() > 0)
			{
				this.e.y(0).FRw(string_0, this.M, new Evi.yE(this.e));
			}
		}

		// Token: 0x0601231B RID: 74523 RVA: 0x006FB308 File Offset: 0x006F9508
		public EJi t(string string_0)
		{
			return (this.e.G() <= 0) ? null : this.e.y(0).FRe(string_0, this.M, new Evi.yE(this.e));
		}

		// Token: 0x0601231C RID: 74524 RVA: 0x006FB34C File Offset: 0x006F954C
		public void r(string string_0, EJi eji_0)
		{
			if (this.e.G() > 0)
			{
				this.e.y(0).FRT(string_0, eji_0, this.M, new Evi.yE(this.e));
			}
		}

		// Token: 0x0601231D RID: 74525 RVA: 0x006FB390 File Offset: 0x006F9590
		public long m()
		{
			return (this.e.G() <= 0) ? 0L : this.e.y(0).FRk(new Evi.yE(this.e));
		}

		// Token: 0x0601231E RID: 74526 RVA: 0x00078C21 File Offset: 0x00076E21
		public void u(long long_0)
		{
			this.j = long_0;
		}

		// Token: 0x0601231F RID: 74527 RVA: 0x006FB3D4 File Offset: 0x006F95D4
		public long B()
		{
			if (this.j <= 0L)
			{
				this.j = ((this.e.G() <= 0) ? 0L : this.e.y(0).FRY(new Evi.yE(this.e)));
			}
			return this.j;
		}

		// Token: 0x06012320 RID: 74528 RVA: 0x006FB43C File Offset: 0x006F963C
		public bool s(string string_0)
		{
			return Eyf.CZ(this.V(string_0), false);
		}

		// Token: 0x06012321 RID: 74529 RVA: 0x006FB458 File Offset: 0x006F9658
		public int Z(string string_0)
		{
			return int.Parse(this.V(string_0));
		}

		// Token: 0x06012322 RID: 74530 RVA: 0x006FB474 File Offset: 0x006F9674
		public long Fi(string string_0)
		{
			return long.Parse(this.V(string_0));
		}

		// Token: 0x06012323 RID: 74531 RVA: 0x006FB490 File Offset: 0x006F9690
		public ENN FG()
		{
			return this.M;
		}

		// Token: 0x06012324 RID: 74532 RVA: 0x00078C2A File Offset: 0x00076E2A
		public void FV(ENN enn_0)
		{
			this.M.V(enn_0);
		}

		// Token: 0x06012325 RID: 74533 RVA: 0x00078C38 File Offset: 0x00076E38
		public void Fj(Evh evh_0)
		{
			lZh.Q(evh_0, "Settings", new object[0]);
			this.e.u(0, evh_0);
		}

		// Token: 0x06012326 RID: 74534 RVA: 0x006FB4A8 File Offset: 0x006F96A8
		public lmr<Evh> FE()
		{
			lmr<Evh> lmr = new lmr<Evh>(this.e.G());
			lmr.r(this.e);
			lmr.s().Reverse();
			return lmr;
		}

		// Token: 0x06012327 RID: 74535 RVA: 0x00078C58 File Offset: 0x00076E58
		public void Fp(Evh evh_0)
		{
			lZh.Q(evh_0, "Settings", new object[0]);
			this.e.Remove(evh_0);
		}

		// Token: 0x04008377 RID: 33655
		private readonly lmr<Evh> e = new lmr<Evh>();

		// Token: 0x04008378 RID: 33656
		private readonly Evi.Hs M = new Evi.Hs();

		// Token: 0x04008379 RID: 33657
		private long j = -1L;

		// Token: 0x02001297 RID: 4759
		private sealed class Hs : ENN
		{
			// Token: 0x06012328 RID: 74536 RVA: 0x006FB4E0 File Offset: 0x006F96E0
			public lmr<string> FdC()
			{
				lmr<string> lmr;
				if (this.j == null)
				{
					lmr = new lmr<string>();
				}
				else
				{
					lmr = this.j.FdC();
				}
				return lmr;
			}

			// Token: 0x06012329 RID: 74537 RVA: 0x006FB510 File Offset: 0x006F9710
			public EoX Fda(string string_0)
			{
				EoX eoX;
				if (this.t == null || !Eyf.hK(string_0, this.t.W()))
				{
					this.t = null;
					if (this.j != null)
					{
						this.t = this.j.Fda(string_0);
					}
					eoX = this.t;
				}
				else
				{
					eoX = this.t;
				}
				return eoX;
			}

			// Token: 0x0601232A RID: 74538 RVA: 0x006FB578 File Offset: 0x006F9778
			public lcX Fdl(string string_0)
			{
				lcX lcX;
				if (this.j == null)
				{
					lcX = null;
				}
				else
				{
					lcX = this.j.Fdl(string_0);
				}
				return lcX;
			}

			// Token: 0x0601232B RID: 74539 RVA: 0x006FB5A4 File Offset: 0x006F97A4
			public ENN B()
			{
				return this.j;
			}

			// Token: 0x0601232C RID: 74540 RVA: 0x00078C78 File Offset: 0x00076E78
			public void V(ENN enn_0)
			{
				this.j = enn_0;
			}

			// Token: 0x0400837A RID: 33658
			private ENN j = null;

			// Token: 0x0400837B RID: 33659
			private EoX t = null;
		}

		// Token: 0x02001298 RID: 4760
		private sealed class yE : Evs, Evh
		{
			// Token: 0x0601232E RID: 74542 RVA: 0x00078C97 File Offset: 0x00076E97
			public yE(lmr<Evh> lmr_0)
			{
				this.N = lmr_0;
			}

			// Token: 0x0601232F RID: 74543 RVA: 0x006FB5BC File Offset: 0x006F97BC
			public lmr<string> FRS(string string_0, ENN enn_0, Evs evs_0)
			{
				Evi.yX<lmr<string>> yX = null;
				Evi.yE.HZ hz = new Evi.yE.HZ();
				hz.v = string_0;
				hz.E = enn_0;
				hz.X = evs_0;
				lmr<string> lmr;
				if (!this.n())
				{
					lmr = null;
				}
				else
				{
					if (yX == null)
					{
						yX = new Evi.yX<lmr<string>>(hz.H);
					}
					lmr = this.i<lmr<string>>(yX);
				}
				return lmr;
			}

			// Token: 0x06012330 RID: 74544 RVA: 0x006FB614 File Offset: 0x006F9814
			public bool FRX(string string_0, ENN enn_0, Evs evs_0)
			{
				Evi.yX<bool> yX = null;
				Evi.yE.ya ya = new Evi.yE.ya();
				ya.m = string_0;
				ya.s = enn_0;
				ya.I = evs_0;
				bool flag;
				if (!this.n())
				{
					flag = false;
				}
				else
				{
					if (yX == null)
					{
						yX = new Evi.yX<bool>(ya.H);
					}
					flag = this.i<bool>(yX);
				}
				return flag;
			}

			// Token: 0x06012331 RID: 74545 RVA: 0x006FB66C File Offset: 0x006F986C
			public string FRP(string string_0, ENN enn_0, Evs evs_0)
			{
				Evi.yX<string> yX = null;
				Evi.yE.yF yF = new Evi.yE.yF();
				yF.C = string_0;
				yF.k = enn_0;
				yF.H = evs_0;
				string text;
				if (!this.n())
				{
					text = null;
				}
				else
				{
					if (yX == null)
					{
						yX = new Evi.yX<string>(yF.s);
					}
					text = this.i<string>(yX);
				}
				return text;
			}

			// Token: 0x06012332 RID: 74546 RVA: 0x006FB6C4 File Offset: 0x006F98C4
			public lcX FRI(string string_0, ENN enn_0, Evs evs_0)
			{
				Evi.yX<lcX> yX = null;
				Evi.yE.yi yi = new Evi.yE.yi();
				yi.K = string_0;
				yi.Q = enn_0;
				yi.u = evs_0;
				lcX lcX;
				if (!this.n())
				{
					lcX = null;
				}
				else
				{
					if (yX == null)
					{
						yX = new Evi.yX<lcX>(yi.r);
					}
					lcX = this.i<lcX>(yX);
				}
				return lcX;
			}

			// Token: 0x06012333 RID: 74547 RVA: 0x006FB71C File Offset: 0x006F991C
			public void FRq(string string_0, string string_1, ENN enn_0, Evs evs_0)
			{
				Evi.yX<string> yX = null;
				Evi.yE.yC yC = new Evi.yE.yC();
				yC.j = string_0;
				yC.t = string_1;
				yC.W = enn_0;
				yC.E = evs_0;
				if (this.n())
				{
					if (yX == null)
					{
						yX = new Evi.yX<string>(yC.r);
					}
					this.i<string>(yX);
				}
			}

			// Token: 0x06012334 RID: 74548 RVA: 0x006FB778 File Offset: 0x006F9978
			public void FRN(string string_0, lcX lcX_0, bool bool_0, ENN enn_0, Evs evs_0)
			{
				Evi.yX<string> yX = null;
				Evi.yE.yo yo = new Evi.yE.yo();
				yo.C = string_0;
				yo.k = lcX_0;
				yo.H = bool_0;
				yo.M = enn_0;
				yo.d = evs_0;
				if (this.n())
				{
					if (yX == null)
					{
						yX = new Evi.yX<string>(yo.t);
					}
					this.i<string>(yX);
				}
			}

			// Token: 0x06012335 RID: 74549 RVA: 0x006FB7DC File Offset: 0x006F99DC
			public void FRw(string string_0, ENN enn_0, Evs evs_0)
			{
				Evi.yX<string> yX = null;
				Evi.yE.yG yG = new Evi.yE.yG();
				yG.C = string_0;
				yG.k = enn_0;
				yG.H = evs_0;
				if (this.n())
				{
					if (yX == null)
					{
						yX = new Evi.yX<string>(yG.K);
					}
					this.i<string>(yX);
				}
			}

			// Token: 0x06012336 RID: 74550 RVA: 0x006FB830 File Offset: 0x006F9A30
			public EJi FRe(string string_0, ENN enn_0, Evs evs_0)
			{
				Evi.yX<EJi> yX = null;
				Evi.yE.yV yV = new Evi.yE.yV();
				yV.j = string_0;
				yV.t = enn_0;
				yV.W = evs_0;
				EJi eji;
				if (!this.n())
				{
					eji = null;
				}
				else
				{
					if (yX == null)
					{
						yX = new Evi.yX<EJi>(yV.i);
					}
					eji = this.i<EJi>(yX);
				}
				return eji;
			}

			// Token: 0x06012337 RID: 74551 RVA: 0x006FB888 File Offset: 0x006F9A88
			public void FRT(string string_0, EJi eji_0, ENN enn_0, Evs evs_0)
			{
				Evi.yX<string> yX = null;
				Evi.yE.yk yk = new Evi.yE.yk();
				yk.j = string_0;
				yk.t = eji_0;
				yk.W = enn_0;
				yk.E = evs_0;
				if (this.n())
				{
					if (yX == null)
					{
						yX = new Evi.yX<string>(yk.H);
					}
					this.i<string>(yX);
				}
			}

			// Token: 0x06012338 RID: 74552 RVA: 0x006FB8E4 File Offset: 0x006F9AE4
			public long FRk(Evs evs_0)
			{
				Evi.yX<long> yX = null;
				Evi.yE.yl yl = new Evi.yE.yl();
				yl.Q = evs_0;
				long num;
				if (!this.n())
				{
					num = -1L;
				}
				else
				{
					if (yX == null)
					{
						yX = new Evi.yX<long>(yl.H);
					}
					num = this.i<long>(yX);
				}
				return num;
			}

			// Token: 0x06012339 RID: 74553 RVA: 0x006FB934 File Offset: 0x006F9B34
			public long FRY(Evs evs_0)
			{
				Evi.yX<long> yX = null;
				Evi.yE.yj yj = new Evi.yE.yj();
				yj.e = evs_0;
				long num;
				if (!this.n())
				{
					num = -1L;
				}
				else
				{
					if (yX == null)
					{
						yX = new Evi.yX<long>(yj.s);
					}
					num = this.i<long>(yX);
				}
				return num;
			}

			// Token: 0x0601233A RID: 74554 RVA: 0x006FB984 File Offset: 0x006F9B84
			private bool n()
			{
				return this.K + 1 < this.N.G();
			}

			// Token: 0x0601233B RID: 74555 RVA: 0x006FB9A8 File Offset: 0x006F9BA8
			private C i<C>(Evi.yX<C> yX_0)
			{
				this.K++;
				C c;
				try
				{
					c = yX_0(this.N.y(this.K));
				}
				finally
				{
					this.K--;
				}
				return c;
			}

			// Token: 0x0400837C RID: 33660
			private readonly lmr<Evh> N;

			// Token: 0x0400837D RID: 33661
			private int K = 0;

			// Token: 0x02001299 RID: 4761
			[CompilerGenerated]
			private sealed class HZ
			{
				// Token: 0x0601233D RID: 74557 RVA: 0x006FBA00 File Offset: 0x006F9C00
				public lmr<string> H(Evh evh_0)
				{
					return evh_0.FRS(this.v, this.E, this.X);
				}

				// Token: 0x0400837E RID: 33662
				public string v;

				// Token: 0x0400837F RID: 33663
				public ENN E;

				// Token: 0x04008380 RID: 33664
				public Evs X;
			}

			// Token: 0x0200129A RID: 4762
			[CompilerGenerated]
			private sealed class ya
			{
				// Token: 0x0601233F RID: 74559 RVA: 0x006FBA28 File Offset: 0x006F9C28
				public bool H(Evh evh_0)
				{
					return evh_0.FRX(this.m, this.s, this.I);
				}

				// Token: 0x04008381 RID: 33665
				public string m;

				// Token: 0x04008382 RID: 33666
				public ENN s;

				// Token: 0x04008383 RID: 33667
				public Evs I;
			}

			// Token: 0x0200129B RID: 4763
			[CompilerGenerated]
			private sealed class yF
			{
				// Token: 0x06012341 RID: 74561 RVA: 0x006FBA50 File Offset: 0x006F9C50
				public string s(Evh evh_0)
				{
					return evh_0.FRP(this.C, this.k, this.H);
				}

				// Token: 0x04008384 RID: 33668
				public string C;

				// Token: 0x04008385 RID: 33669
				public ENN k;

				// Token: 0x04008386 RID: 33670
				public Evs H;
			}

			// Token: 0x0200129C RID: 4764
			[CompilerGenerated]
			private sealed class yi
			{
				// Token: 0x06012343 RID: 74563 RVA: 0x006FBA78 File Offset: 0x006F9C78
				public lcX r(Evh evh_0)
				{
					return evh_0.FRI(this.K, this.Q, this.u);
				}

				// Token: 0x04008387 RID: 33671
				public string K;

				// Token: 0x04008388 RID: 33672
				public ENN Q;

				// Token: 0x04008389 RID: 33673
				public Evs u;
			}

			// Token: 0x0200129D RID: 4765
			[CompilerGenerated]
			private sealed class yC
			{
				// Token: 0x06012345 RID: 74565 RVA: 0x006FBAA0 File Offset: 0x006F9CA0
				public string r(Evh evh_0)
				{
					evh_0.FRq(this.j, this.t, this.W, this.E);
					return null;
				}

				// Token: 0x0400838A RID: 33674
				public string j;

				// Token: 0x0400838B RID: 33675
				public string t;

				// Token: 0x0400838C RID: 33676
				public ENN W;

				// Token: 0x0400838D RID: 33677
				public Evs E;
			}

			// Token: 0x0200129E RID: 4766
			[CompilerGenerated]
			private sealed class yo
			{
				// Token: 0x06012347 RID: 74567 RVA: 0x006FBAD0 File Offset: 0x006F9CD0
				public string t(Evh evh_0)
				{
					evh_0.FRN(this.C, this.k, this.H, this.M, this.d);
					return null;
				}

				// Token: 0x0400838E RID: 33678
				public string C;

				// Token: 0x0400838F RID: 33679
				public lcX k;

				// Token: 0x04008390 RID: 33680
				public bool H;

				// Token: 0x04008391 RID: 33681
				public ENN M;

				// Token: 0x04008392 RID: 33682
				public Evs d;
			}

			// Token: 0x0200129F RID: 4767
			[CompilerGenerated]
			private sealed class yG
			{
				// Token: 0x06012349 RID: 74569 RVA: 0x006FBB04 File Offset: 0x006F9D04
				public string K(Evh evh_0)
				{
					evh_0.FRw(this.C, this.k, this.H);
					return null;
				}

				// Token: 0x04008393 RID: 33683
				public string C;

				// Token: 0x04008394 RID: 33684
				public ENN k;

				// Token: 0x04008395 RID: 33685
				public Evs H;
			}

			// Token: 0x020012A0 RID: 4768
			[CompilerGenerated]
			private sealed class yV
			{
				// Token: 0x0601234B RID: 74571 RVA: 0x006FBB2C File Offset: 0x006F9D2C
				public EJi i(Evh evh_0)
				{
					return evh_0.FRe(this.j, this.t, this.W);
				}

				// Token: 0x04008396 RID: 33686
				public string j;

				// Token: 0x04008397 RID: 33687
				public ENN t;

				// Token: 0x04008398 RID: 33688
				public Evs W;
			}

			// Token: 0x020012A1 RID: 4769
			[CompilerGenerated]
			private sealed class yk
			{
				// Token: 0x0601234D RID: 74573 RVA: 0x006FBB54 File Offset: 0x006F9D54
				public string H(Evh evh_0)
				{
					evh_0.FRT(this.j, this.t, this.W, this.E);
					return null;
				}

				// Token: 0x04008399 RID: 33689
				public string j;

				// Token: 0x0400839A RID: 33690
				public EJi t;

				// Token: 0x0400839B RID: 33691
				public ENN W;

				// Token: 0x0400839C RID: 33692
				public Evs E;
			}

			// Token: 0x020012A2 RID: 4770
			[CompilerGenerated]
			private sealed class yl
			{
				// Token: 0x0601234F RID: 74575 RVA: 0x006FBB84 File Offset: 0x006F9D84
				public long H(Evh evh_0)
				{
					return evh_0.FRk(this.Q);
				}

				// Token: 0x0400839D RID: 33693
				public Evs Q;
			}

			// Token: 0x020012A3 RID: 4771
			[CompilerGenerated]
			private sealed class yj
			{
				// Token: 0x06012351 RID: 74577 RVA: 0x006FBBA0 File Offset: 0x006F9DA0
				public long s(Evh evh_0)
				{
					return evh_0.FRY(this.e);
				}

				// Token: 0x0400839E RID: 33694
				public Evs e;
			}
		}

		// Token: 0x020012A4 RID: 4772
		// (Invoke) Token: 0x06012353 RID: 74579
		private delegate yp yX<out yp>(Evh evh_0);
	}
}
