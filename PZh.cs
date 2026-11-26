using System;
using System.Collections.Generic;
using System.IO;

namespace Arc264y
{
	// Token: 0x02000847 RID: 2119
	internal class PZh : uXv, Pi, IDisposable
	{
		// Token: 0x0600A181 RID: 41345 RVA: 0x00066581 File Offset: 0x00064781
		public PZh()
			: this(null)
		{
		}

		// Token: 0x0600A182 RID: 41346 RVA: 0x0006658A File Offset: 0x0006478A
		public PZh(PZJ pzj_0)
			: this(pzj_0, null)
		{
		}

		// Token: 0x0600A183 RID: 41347 RVA: 0x00442C1C File Offset: 0x00440E1C
		public PZh(PZJ pzj_0, object object_0)
		{
			this.m = pzj_0;
			try
			{
				this.k = new PQ(this, (object_0 != null) ? object_0 : this);
				this.k.rp("");
				this.k.rB(true);
				this.k.Ml("");
				this.k.rv(0);
				this.k.lp(0);
				this.k.bF("");
				this.k.MI("");
				this.k.bv("");
				this.k.QT(0);
				this.k.aN(60);
				this.k.lx(0L);
				this.k.QM("");
				this.k.Mo("");
			}
			catch (uJw)
			{
			}
		}

		// Token: 0x0600A184 RID: 41348 RVA: 0x00442D30 File Offset: 0x00440F30
		public void Dispose()
		{
			if (this.k != null)
			{
				this.k.Dispose();
				this.k = null;
			}
		}

		// Token: 0x0600A185 RID: 41349 RVA: 0x00066594 File Offset: 0x00064794
		public void A(PZJ pzj_0)
		{
			this.m = pzj_0;
		}

		// Token: 0x0600A186 RID: 41350 RVA: 0x00442D5C File Offset: 0x00440F5C
		public virtual string j()
		{
			return this.k.rM();
		}

		// Token: 0x0600A187 RID: 41351 RVA: 0x00442D78 File Offset: 0x00440F78
		public virtual void Q(string string_0)
		{
			try
			{
				this.k.rp(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A188 RID: 41352 RVA: 0x00442DAC File Offset: 0x00440FAC
		public virtual bool E()
		{
			return this.k.rT();
		}

		// Token: 0x0600A189 RID: 41353 RVA: 0x00442DC4 File Offset: 0x00440FC4
		public virtual void D(bool bool_0)
		{
			try
			{
				this.k.rB(bool_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A18A RID: 41354 RVA: 0x00442DF8 File Offset: 0x00440FF8
		public virtual string p()
		{
			return this.k.Tf();
		}

		// Token: 0x0600A18B RID: 41355 RVA: 0x00442E14 File Offset: 0x00441014
		public virtual void c(string string_0)
		{
			try
			{
				this.k.TC(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A18C RID: 41356 RVA: 0x00442E48 File Offset: 0x00441048
		public virtual string bA()
		{
			return this.k.Ma();
		}

		// Token: 0x0600A18D RID: 41357 RVA: 0x00442E64 File Offset: 0x00441064
		public virtual void bj(string string_0)
		{
			try
			{
				this.k.Ml(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A18E RID: 41358 RVA: 0x00442E98 File Offset: 0x00441098
		public virtual int bu()
		{
			return this.k.rI();
		}

		// Token: 0x0600A18F RID: 41359 RVA: 0x00442EB4 File Offset: 0x004410B4
		public virtual string bQ()
		{
			string text;
			try
			{
				int num = this.bu();
				switch (num)
				{
				case 0:
					text = "BASIC";
					break;
				case 1:
					text = "DIGEST";
					break;
				case 2:
					text = "PROPRIETARY";
					break;
				case 3:
					text = "NONE";
					break;
				case 4:
					text = "NTLM";
					break;
				case 5:
					text = "NEGOTIATE";
					break;
				case 6:
					text = "OAUTH";
					break;
				default:
					throw new uJw("The Enum value '" + num + "' is invalid.");
				}
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
			return text;
		}

		// Token: 0x0600A190 RID: 41360 RVA: 0x00442F5C File Offset: 0x0044115C
		public virtual void JXN(int int_0)
		{
			try
			{
				this.k.rv(int_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A191 RID: 41361 RVA: 0x00442F90 File Offset: 0x00441190
		public virtual void JXN(string string_0)
		{
			try
			{
				if (string_0 != null)
				{
					string text = string_0.ToUpper();
					if (text != null)
					{
						if (mcX.wB == null)
						{
							mcX.wB = new Dictionary<string, int>(7)
							{
								{ "BASIC", 0 },
								{ "DIGEST", 1 },
								{ "PROPRIETARY", 2 },
								{ "NONE", 3 },
								{ "NTLM", 4 },
								{ "NEGOTIATE", 5 },
								{ "OAUTH", 6 }
							};
						}
						int num;
						if (mcX.wB.TryGetValue(text, out num))
						{
							switch (num)
							{
							case 0:
								this.JXN(0);
								break;
							case 1:
								this.JXN(1);
								break;
							case 2:
								this.JXN(2);
								break;
							case 3:
								this.JXN(3);
								break;
							case 4:
								this.JXN(4);
								break;
							case 5:
								this.JXN(5);
								break;
							case 6:
								this.JXN(6);
								break;
							default:
								goto IL_0013;
							}
							return;
						}
					}
					IL_0013:
					throw new uJw("The Enum string value '" + string_0 + "' is invalid.");
				}
				throw new uJw("The Enum string value can't be null.");
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A192 RID: 41362 RVA: 0x004430DC File Offset: 0x004412DC
		public virtual bool bH()
		{
			return this.k.Ja();
		}

		// Token: 0x0600A193 RID: 41363 RVA: 0x004430F4 File Offset: 0x004412F4
		public virtual string by()
		{
			return this.k.bz();
		}

		// Token: 0x0600A194 RID: 41364 RVA: 0x00443110 File Offset: 0x00441310
		public virtual void bi(string string_0)
		{
			try
			{
				this.k.MC(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A195 RID: 41365 RVA: 0x0006659D File Offset: 0x0006479D
		public void bE(int int_0)
		{
			this.k.HT().RemoveAt(int_0);
		}

		// Token: 0x0600A196 RID: 41366 RVA: 0x000665B0 File Offset: 0x000647B0
		public void bD()
		{
			this.k.HT().Clear();
		}

		// Token: 0x0600A197 RID: 41367 RVA: 0x000665C2 File Offset: 0x000647C2
		public void bp()
		{
			this.k.HT().Add(new uDi());
		}

		// Token: 0x0600A198 RID: 41368 RVA: 0x000665DA File Offset: 0x000647DA
		public void br(string string_0, string string_1)
		{
			this.k.HT().Add(new uDi(string_0, string_1));
		}

		// Token: 0x0600A199 RID: 41369 RVA: 0x00443144 File Offset: 0x00441344
		public int bc()
		{
			return this.k.HT().Count;
		}

		// Token: 0x0600A19A RID: 41370 RVA: 0x00443164 File Offset: 0x00441364
		public virtual string bm(int int_0)
		{
			return ((uDi)this.k.HT()[int_0]).E();
		}

		// Token: 0x0600A19B RID: 41371 RVA: 0x00443190 File Offset: 0x00441390
		public virtual string Ak(int int_0)
		{
			return ((uDi)this.k.HT()[int_0]).u();
		}

		// Token: 0x0600A19C RID: 41372 RVA: 0x004431BC File Offset: 0x004413BC
		public virtual string Ab(int int_0)
		{
			return ((uDi)this.k.HT()[int_0]).s();
		}

		// Token: 0x0600A19D RID: 41373 RVA: 0x004431E8 File Offset: 0x004413E8
		public virtual void AA(int int_0, string string_0)
		{
			try
			{
				((uDi)this.k.HT()[int_0]).GK(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A19E RID: 41374 RVA: 0x0044322C File Offset: 0x0044142C
		public virtual string AT(int int_0)
		{
			return ((uDi)this.k.HT()[int_0]).Gy();
		}

		// Token: 0x0600A19F RID: 41375 RVA: 0x00443258 File Offset: 0x00441458
		public virtual bool Aw(int int_0)
		{
			return ((uDi)this.k.HT()[int_0]).GG();
		}

		// Token: 0x0600A1A0 RID: 41376 RVA: 0x00443280 File Offset: 0x00441480
		public virtual string Aj(int int_0)
		{
			return ((uDi)this.k.HT()[int_0]).f();
		}

		// Token: 0x0600A1A1 RID: 41377 RVA: 0x004432AC File Offset: 0x004414AC
		public virtual void Ag(int int_0, string string_0)
		{
			try
			{
				((uDi)this.k.HT()[int_0]).Gc(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1A2 RID: 41378 RVA: 0x004432F0 File Offset: 0x004414F0
		public void Au()
		{
			try
			{
				this.k.Th(null);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1A3 RID: 41379 RVA: 0x00443324 File Offset: 0x00441524
		public virtual void AF()
		{
			try
			{
				this.k.Th(new kv());
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1A4 RID: 41380 RVA: 0x0044335C File Offset: 0x0044155C
		public virtual bool AQ()
		{
			bool flag;
			try
			{
				flag = this.k.Tm() == null;
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
			return flag;
		}

		// Token: 0x0600A1A5 RID: 41381 RVA: 0x00443394 File Offset: 0x00441594
		public virtual bool AS()
		{
			return this.k.Tm().Wp();
		}

		// Token: 0x0600A1A6 RID: 41382 RVA: 0x004433B4 File Offset: 0x004415B4
		public virtual void AH(bool bool_0)
		{
			try
			{
				this.k.Tm().WU(bool_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1A7 RID: 41383 RVA: 0x004433EC File Offset: 0x004415EC
		public virtual int Ao()
		{
			return this.k.Tm().WW();
		}

		// Token: 0x0600A1A8 RID: 41384 RVA: 0x0044340C File Offset: 0x0044160C
		public virtual string Al()
		{
			string text;
			try
			{
				int num = this.Ao();
				int num2 = num;
				switch (num2)
				{
				case 0:
					text = "NONE";
					break;
				case 1:
					text = "TUNNEL";
					break;
				case 2:
					text = "SOCKS4";
					break;
				case 3:
					text = "SOCKS5";
					break;
				default:
					if (num2 != 10)
					{
						throw new uJw("The Enum value '" + num + "' is invalid.");
					}
					text = "SOCKS4A";
					break;
				}
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
			return text;
		}

		// Token: 0x0600A1A9 RID: 41385 RVA: 0x004434A0 File Offset: 0x004416A0
		public virtual void JXw(int int_0)
		{
			try
			{
				this.k.Tm().Wf(int_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1AA RID: 41386 RVA: 0x004434D8 File Offset: 0x004416D8
		public virtual void JXw(string string_0)
		{
			try
			{
				if (string_0 != null)
				{
					string text = string_0.ToUpper();
					if (text != null)
					{
						if (text == "NONE")
						{
							this.JXw(0);
						}
						else if (text == "TUNNEL")
						{
							this.JXw(1);
						}
						else if (text == "SOCKS4")
						{
							this.JXw(2);
						}
						else if (text == "SOCKS5")
						{
							this.JXw(3);
						}
						else
						{
							if (!(text == "SOCKS4A"))
							{
								goto IL_0013;
							}
							this.JXw(10);
						}
						return;
					}
					IL_0013:
					throw new uJw("The Enum string value '" + string_0 + "' is invalid.");
				}
				throw new uJw("The Enum string value can't be null.");
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1AB RID: 41387 RVA: 0x004435A4 File Offset: 0x004417A4
		public virtual string AX()
		{
			return this.k.Tm().m();
		}

		// Token: 0x0600A1AC RID: 41388 RVA: 0x004435C4 File Offset: 0x004417C4
		public virtual void Ay(string string_0)
		{
			try
			{
				this.k.Tm().WA(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1AD RID: 41389 RVA: 0x004435FC File Offset: 0x004417FC
		public virtual string Ai()
		{
			return this.k.Tm().K();
		}

		// Token: 0x0600A1AE RID: 41390 RVA: 0x0044361C File Offset: 0x0044181C
		public virtual void AN(string string_0)
		{
			try
			{
				this.k.Tm().Wd(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1AF RID: 41391 RVA: 0x00443654 File Offset: 0x00441854
		public virtual int AE()
		{
			return this.k.Tm().WI();
		}

		// Token: 0x0600A1B0 RID: 41392 RVA: 0x00443674 File Offset: 0x00441874
		public virtual void AD(int int_0)
		{
			try
			{
				this.k.Tm().WB(int_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1B1 RID: 41393 RVA: 0x004436AC File Offset: 0x004418AC
		public virtual string Ap()
		{
			return this.k.Tm().Wy();
		}

		// Token: 0x0600A1B2 RID: 41394 RVA: 0x004436CC File Offset: 0x004418CC
		public virtual void Ar(string string_0)
		{
			try
			{
				this.k.Tm().WN(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1B3 RID: 41395 RVA: 0x00443704 File Offset: 0x00441904
		public virtual int Ac()
		{
			return this.k.lH();
		}

		// Token: 0x0600A1B4 RID: 41396 RVA: 0x00443720 File Offset: 0x00441920
		public virtual string Am()
		{
			string text;
			try
			{
				int num = this.Ac();
				switch (num)
				{
				case 0:
					text = "NEVER";
					break;
				case 1:
					text = "ALWAYS";
					break;
				case 2:
					text = "SAME_SCHEME";
					break;
				default:
					throw new uJw("The Enum value '" + num + "' is invalid.");
				}
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
			return text;
		}

		// Token: 0x0600A1B5 RID: 41397 RVA: 0x00443798 File Offset: 0x00441998
		public virtual void JXe(int int_0)
		{
			try
			{
				this.k.lp(int_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1B6 RID: 41398 RVA: 0x004437CC File Offset: 0x004419CC
		public virtual void JXe(string string_0)
		{
			try
			{
				if (string_0 != null)
				{
					string text = string_0.ToUpper();
					if (text != null)
					{
						if (text == "NEVER")
						{
							this.JXe(0);
						}
						else if (text == "ALWAYS")
						{
							this.JXe(1);
						}
						else
						{
							if (!(text == "SAME_SCHEME"))
							{
								goto IL_0013;
							}
							this.JXe(2);
						}
						return;
					}
					IL_0013:
					throw new uJw("The Enum string value '" + string_0 + "' is invalid.");
				}
				throw new uJw("The Enum string value can't be null.");
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1B7 RID: 41399 RVA: 0x00443868 File Offset: 0x00441A68
		public virtual string Av()
		{
			return this.k.re();
		}

		// Token: 0x0600A1B8 RID: 41400 RVA: 0x00443884 File Offset: 0x00441A84
		public virtual void Az(string string_0)
		{
			try
			{
				this.k.rF(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1B9 RID: 41401 RVA: 0x004438B8 File Offset: 0x00441AB8
		public virtual string TA()
		{
			return this.k.HH();
		}

		// Token: 0x0600A1BA RID: 41402 RVA: 0x004438D4 File Offset: 0x00441AD4
		public virtual void Tj(string string_0)
		{
			try
			{
				this.k.HU(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1BB RID: 41403 RVA: 0x00443908 File Offset: 0x00441B08
		public virtual string Tu()
		{
			return this.k.lD();
		}

		// Token: 0x0600A1BC RID: 41404 RVA: 0x00443924 File Offset: 0x00441B24
		public virtual void TQ(string string_0)
		{
			try
			{
				this.k.lr(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1BD RID: 41405 RVA: 0x00443958 File Offset: 0x00441B58
		public virtual bool TH()
		{
			return this.k.Ql();
		}

		// Token: 0x0600A1BE RID: 41406 RVA: 0x00443970 File Offset: 0x00441B70
		public virtual string Ty()
		{
			return this.k.rW();
		}

		// Token: 0x0600A1BF RID: 41407 RVA: 0x0044398C File Offset: 0x00441B8C
		public virtual void Ti(string string_0)
		{
			try
			{
				this.k.rN(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1C0 RID: 41408 RVA: 0x004439C0 File Offset: 0x00441BC0
		public virtual string TE()
		{
			return this.k.bM();
		}

		// Token: 0x0600A1C1 RID: 41409 RVA: 0x004439DC File Offset: 0x00441BDC
		public virtual void TD(string string_0)
		{
			try
			{
				this.k.bF(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1C2 RID: 41410 RVA: 0x00443A10 File Offset: 0x00441C10
		public virtual string Tp()
		{
			return this.k.lk();
		}

		// Token: 0x0600A1C3 RID: 41411 RVA: 0x00443A2C File Offset: 0x00441C2C
		public virtual void Tr(string string_0)
		{
			try
			{
				this.k.lT(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1C4 RID: 41412 RVA: 0x00443A60 File Offset: 0x00441C60
		public virtual string Tc()
		{
			return this.k.Mw();
		}

		// Token: 0x0600A1C5 RID: 41413 RVA: 0x00443A7C File Offset: 0x00441C7C
		public virtual void Tm(string string_0)
		{
			try
			{
				this.k.MT(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1C6 RID: 41414 RVA: 0x00443AB0 File Offset: 0x00441CB0
		public int wA()
		{
			return this.k.Hr().Count;
		}

		// Token: 0x0600A1C7 RID: 41415 RVA: 0x00443AD0 File Offset: 0x00441CD0
		public virtual string wj(int int_0)
		{
			return ((ZP)this.k.Hr()[int_0]).f();
		}

		// Token: 0x0600A1C8 RID: 41416 RVA: 0x00443AFC File Offset: 0x00441CFC
		public virtual void wu(int int_0, string string_0)
		{
			try
			{
				((ZP)this.k.Hr()[int_0]).D(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1C9 RID: 41417 RVA: 0x00443B40 File Offset: 0x00441D40
		public virtual string wQ(int int_0)
		{
			return ((ZP)this.k.Hr()[int_0]).H();
		}

		// Token: 0x0600A1CA RID: 41418 RVA: 0x00443B6C File Offset: 0x00441D6C
		public virtual void wH(int int_0, string string_0)
		{
			try
			{
				((ZP)this.k.Hr()[int_0]).x(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1CB RID: 41419 RVA: 0x00443BB0 File Offset: 0x00441DB0
		public virtual string wy()
		{
			return this.k.MP();
		}

		// Token: 0x0600A1CC RID: 41420 RVA: 0x00443BCC File Offset: 0x00441DCC
		public virtual void wi(string string_0)
		{
			try
			{
				this.k.MI(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1CD RID: 41421 RVA: 0x00443C00 File Offset: 0x00441E00
		public virtual byte[] wE()
		{
			return this.k.aD();
		}

		// Token: 0x0600A1CE RID: 41422 RVA: 0x00443C1C File Offset: 0x00441E1C
		public virtual void wD(byte[] byte_0)
		{
			try
			{
				this.k.aQ(byte_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1CF RID: 41423 RVA: 0x00443C50 File Offset: 0x00441E50
		public virtual void wp(byte[] byte_0, int int_0, int int_1)
		{
			try
			{
				this.k.aQ(PQc.WW(byte_0, int_0, int_1));
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1D0 RID: 41424 RVA: 0x00443C8C File Offset: 0x00441E8C
		public virtual void wr(string string_0)
		{
			try
			{
				this.k.aQ(PoB.n(string_0, this.k.aF()));
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1D1 RID: 41425 RVA: 0x00443CD0 File Offset: 0x00441ED0
		public virtual string wc()
		{
			return this.k.rk();
		}

		// Token: 0x0600A1D2 RID: 41426 RVA: 0x00443CEC File Offset: 0x00441EEC
		public virtual void wm(string string_0)
		{
			try
			{
				this.k.rJ(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1D3 RID: 41427 RVA: 0x00443D20 File Offset: 0x00441F20
		public void jk()
		{
			try
			{
				this.k.ac(null);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1D4 RID: 41428 RVA: 0x00443D54 File Offset: 0x00441F54
		public virtual void jb()
		{
			try
			{
				this.k.ac(new urm());
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1D5 RID: 41429 RVA: 0x00443D8C File Offset: 0x00441F8C
		public virtual void jA(string string_0, int int_0)
		{
			try
			{
				this.k.ac(new urm(string_0, int_0));
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1D6 RID: 41430 RVA: 0x00443DC8 File Offset: 0x00441FC8
		public virtual void jT(string string_0, int int_0, string string_1, string string_2)
		{
			try
			{
				this.k.ac(new urm(string_0, int_0, string_1, string_2));
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1D7 RID: 41431 RVA: 0x00443E04 File Offset: 0x00442004
		public virtual bool jw()
		{
			bool flag;
			try
			{
				flag = this.k.aB() == null;
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
			return flag;
		}

		// Token: 0x0600A1D8 RID: 41432 RVA: 0x00443E3C File Offset: 0x0044203C
		public virtual int jj()
		{
			return this.k.aB().y();
		}

		// Token: 0x0600A1D9 RID: 41433 RVA: 0x00443E5C File Offset: 0x0044205C
		public virtual string jg()
		{
			string text;
			try
			{
				int num = this.jj();
				switch (num)
				{
				case 0:
					text = "BASIC";
					break;
				case 1:
					text = "DIGEST";
					break;
				case 2:
					text = "PROPRIETARY";
					break;
				case 3:
					text = "NONE";
					break;
				case 4:
					text = "NTLM";
					break;
				case 5:
					text = "NEGOTIATE";
					break;
				default:
					throw new uJw("The Enum value '" + num + "' is invalid.");
				}
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
			return text;
		}

		// Token: 0x0600A1DA RID: 41434 RVA: 0x00443EF8 File Offset: 0x004420F8
		public virtual void JXT(int int_0)
		{
			try
			{
				this.k.aB().Pr(int_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1DB RID: 41435 RVA: 0x00443F30 File Offset: 0x00442130
		public virtual void JXT(string string_0)
		{
			try
			{
				if (string_0 != null)
				{
					string text = string_0.ToUpper();
					if (text != null)
					{
						if (mcX.wf == null)
						{
							mcX.wf = new Dictionary<string, int>(6)
							{
								{ "BASIC", 0 },
								{ "DIGEST", 1 },
								{ "PROPRIETARY", 2 },
								{ "NONE", 3 },
								{ "NTLM", 4 },
								{ "NEGOTIATE", 5 }
							};
						}
						int num;
						if (mcX.wf.TryGetValue(text, out num))
						{
							switch (num)
							{
							case 0:
								this.JXT(0);
								break;
							case 1:
								this.JXT(1);
								break;
							case 2:
								this.JXT(2);
								break;
							case 3:
								this.JXT(3);
								break;
							case 4:
								this.JXT(4);
								break;
							case 5:
								this.JXT(5);
								break;
							default:
								goto IL_0013;
							}
							return;
						}
					}
					IL_0013:
					throw new uJw("The Enum string value '" + string_0 + "' is invalid.");
				}
				throw new uJw("The Enum string value can't be null.");
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1DC RID: 41436 RVA: 0x00444064 File Offset: 0x00442264
		public virtual bool ju()
		{
			return this.k.aB().PV();
		}

		// Token: 0x0600A1DD RID: 41437 RVA: 0x00444084 File Offset: 0x00442284
		public virtual void jF(bool bool_0)
		{
			try
			{
				this.k.aB().cW(bool_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1DE RID: 41438 RVA: 0x004440BC File Offset: 0x004422BC
		public virtual string jQ()
		{
			return this.k.aB().PL();
		}

		// Token: 0x0600A1DF RID: 41439 RVA: 0x004440DC File Offset: 0x004422DC
		public virtual void jS(string string_0)
		{
			try
			{
				this.k.aB().PD(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1E0 RID: 41440 RVA: 0x00444114 File Offset: 0x00442314
		public virtual int jH()
		{
			return this.k.aB().Py();
		}

		// Token: 0x0600A1E1 RID: 41441 RVA: 0x00444134 File Offset: 0x00442334
		public virtual void jo(int int_0)
		{
			try
			{
				this.k.aB().PZ(int_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1E2 RID: 41442 RVA: 0x0044416C File Offset: 0x0044236C
		public virtual string jl()
		{
			return this.k.aB().PG();
		}

		// Token: 0x0600A1E3 RID: 41443 RVA: 0x0044418C File Offset: 0x0044238C
		public virtual void jX(string string_0)
		{
			try
			{
				this.k.aB().ck(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1E4 RID: 41444 RVA: 0x004441C4 File Offset: 0x004423C4
		public virtual int jy()
		{
			return this.k.aB().PW();
		}

		// Token: 0x0600A1E5 RID: 41445 RVA: 0x004441E4 File Offset: 0x004423E4
		public virtual string ji()
		{
			string text;
			try
			{
				int num = this.jy();
				switch (num)
				{
				case 0:
					text = "AUTOMATIC";
					break;
				case 1:
					text = "ALWAYS";
					break;
				case 2:
					text = "NEVER";
					break;
				case 3:
					text = "TUNNEL";
					break;
				default:
					throw new uJw("The Enum value '" + num + "' is invalid.");
				}
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
			return text;
		}

		// Token: 0x0600A1E6 RID: 41446 RVA: 0x00444268 File Offset: 0x00442468
		public virtual void JXk(int int_0)
		{
			try
			{
				this.k.aB().cP(int_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1E7 RID: 41447 RVA: 0x004442A0 File Offset: 0x004424A0
		public virtual void JXk(string string_0)
		{
			try
			{
				if (string_0 != null)
				{
					string text = string_0.ToUpper();
					if (text != null)
					{
						if (text == "AUTOMATIC")
						{
							this.JXk(0);
						}
						else if (text == "ALWAYS")
						{
							this.JXk(1);
						}
						else if (text == "NEVER")
						{
							this.JXk(2);
						}
						else
						{
							if (!(text == "TUNNEL"))
							{
								goto IL_0013;
							}
							this.JXk(3);
						}
						return;
					}
					IL_0013:
					throw new uJw("The Enum string value '" + string_0 + "' is invalid.");
				}
				throw new uJw("The Enum string value can't be null.");
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1E8 RID: 41448 RVA: 0x00444354 File Offset: 0x00442554
		public virtual string jN()
		{
			return this.k.aB().Pn();
		}

		// Token: 0x0600A1E9 RID: 41449 RVA: 0x00444374 File Offset: 0x00442574
		public virtual void jE(string string_0)
		{
			try
			{
				this.k.aB().cc(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1EA RID: 41450 RVA: 0x004443AC File Offset: 0x004425AC
		public virtual string jD()
		{
			return this.k.bI();
		}

		// Token: 0x0600A1EB RID: 41451 RVA: 0x004443C8 File Offset: 0x004425C8
		public virtual void jp(string string_0)
		{
			try
			{
				this.k.bv(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1EC RID: 41452 RVA: 0x004443FC File Offset: 0x004425FC
		public virtual string jr()
		{
			return this.k.rg();
		}

		// Token: 0x0600A1ED RID: 41453 RVA: 0x00444418 File Offset: 0x00442618
		public virtual void jc(string string_0)
		{
			try
			{
				this.k.rx(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1EE RID: 41454 RVA: 0x0044444C File Offset: 0x0044264C
		public void jm()
		{
			try
			{
				this.k.lg(null);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1EF RID: 41455 RVA: 0x00444480 File Offset: 0x00442680
		public virtual void jv()
		{
			try
			{
				this.k.lg(new wE());
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1F0 RID: 41456 RVA: 0x004444B8 File Offset: 0x004426B8
		public virtual void JXY(string string_0)
		{
			try
			{
				this.k.lg(new wE(string_0));
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1F1 RID: 41457 RVA: 0x004444F0 File Offset: 0x004426F0
		public virtual void JXY(byte[] byte_0)
		{
			try
			{
				this.k.lg(new wE((byte_0 == null) ? null : ((byte[])byte_0.Clone())));
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1F2 RID: 41458 RVA: 0x00444538 File Offset: 0x00442738
		public virtual void JXd(int int_0, string string_0, string string_1, string string_2)
		{
			try
			{
				this.k.lg(new wE(int_0, string_0, string_1, string_2));
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1F3 RID: 41459 RVA: 0x00444574 File Offset: 0x00442774
		public virtual void JXR(int int_0, string string_0, string string_1, string string_2, string string_3)
		{
			try
			{
				this.k.lg(new wE(int_0, string_0, string_1, string_2, string_3));
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1F4 RID: 41460 RVA: 0x004445B4 File Offset: 0x004427B4
		public virtual void JXd(int int_0, string string_0, string string_1, byte[] byte_0)
		{
			try
			{
				this.k.lg(new wE(int_0, string_0, string_1, (byte_0 == null) ? null : ((byte[])byte_0.Clone())));
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1F5 RID: 41461 RVA: 0x00444604 File Offset: 0x00442804
		public virtual void JXd(int int_0, byte[] byte_0, string string_0, string string_1)
		{
			try
			{
				this.k.lg(new wE(int_0, (byte_0 == null) ? null : ((byte[])byte_0.Clone()), string_0, string_1));
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1F6 RID: 41462 RVA: 0x00444650 File Offset: 0x00442850
		public virtual void JXR(int int_0, byte[] byte_0, string string_0, string string_1, string string_2)
		{
			try
			{
				this.k.lg(new wE(int_0, (byte_0 == null) ? null : ((byte[])byte_0.Clone()), string_0, string_1, string_2));
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1F7 RID: 41463 RVA: 0x004446A0 File Offset: 0x004428A0
		public virtual void JXd(int int_0, byte[] byte_0, string string_0, byte[] byte_1)
		{
			try
			{
				this.k.lg(new wE(int_0, (byte_0 == null) ? null : ((byte[])byte_0.Clone()), string_0, (byte_1 == null) ? null : ((byte[])byte_1.Clone())));
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A1F8 RID: 41464 RVA: 0x00444700 File Offset: 0x00442900
		public virtual bool jz()
		{
			bool flag;
			try
			{
				flag = this.k.lU() == null;
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
			return flag;
		}

		// Token: 0x0600A1F9 RID: 41465 RVA: 0x00444738 File Offset: 0x00442938
		public virtual string gA()
		{
			return this.k.lU().Gz();
		}

		// Token: 0x0600A1FA RID: 41466 RVA: 0x00444758 File Offset: 0x00442958
		public virtual string gj()
		{
			return this.k.lU().hK();
		}

		// Token: 0x0600A1FB RID: 41467 RVA: 0x00444778 File Offset: 0x00442978
		public virtual string gu()
		{
			return this.k.lU().GF();
		}

		// Token: 0x0600A1FC RID: 41468 RVA: 0x00444798 File Offset: 0x00442998
		public virtual string gQ()
		{
			return this.k.lU().Xl();
		}

		// Token: 0x0600A1FD RID: 41469 RVA: 0x004447B8 File Offset: 0x004429B8
		public virtual string gH()
		{
			return this.k.lU().Xz();
		}

		// Token: 0x0600A1FE RID: 41470 RVA: 0x004447D8 File Offset: 0x004429D8
		public virtual string gy()
		{
			return this.k.lU().mK();
		}

		// Token: 0x0600A1FF RID: 41471 RVA: 0x004447F8 File Offset: 0x004429F8
		public virtual string gi()
		{
			return this.k.lU().hp();
		}

		// Token: 0x0600A200 RID: 41472 RVA: 0x00444818 File Offset: 0x00442A18
		public virtual string gE()
		{
			return this.k.lU().hj();
		}

		// Token: 0x0600A201 RID: 41473 RVA: 0x00444838 File Offset: 0x00442A38
		public virtual bool gD()
		{
			return this.k.lU().hB();
		}

		// Token: 0x0600A202 RID: 41474 RVA: 0x00444858 File Offset: 0x00442A58
		public virtual string gp()
		{
			return this.k.lU().hA();
		}

		// Token: 0x0600A203 RID: 41475 RVA: 0x00444878 File Offset: 0x00442A78
		public virtual string gr()
		{
			return this.k.lU().hW();
		}

		// Token: 0x0600A204 RID: 41476 RVA: 0x00444898 File Offset: 0x00442A98
		public virtual string gc()
		{
			return this.k.lU().Xh();
		}

		// Token: 0x0600A205 RID: 41477 RVA: 0x004448B8 File Offset: 0x00442AB8
		public virtual int gm()
		{
			return this.k.lU().Xm();
		}

		// Token: 0x0600A206 RID: 41478 RVA: 0x004448D8 File Offset: 0x00442AD8
		public virtual string uk()
		{
			return this.k.lU().XV();
		}

		// Token: 0x0600A207 RID: 41479 RVA: 0x004448F8 File Offset: 0x00442AF8
		public virtual string ub()
		{
			return this.k.lU().Xp();
		}

		// Token: 0x0600A208 RID: 41480 RVA: 0x00444918 File Offset: 0x00442B18
		public virtual byte[] uA()
		{
			return this.k.lU().tA();
		}

		// Token: 0x0600A209 RID: 41481 RVA: 0x00444938 File Offset: 0x00442B38
		public virtual void JXz(byte[] byte_0)
		{
			try
			{
				this.k.lU().tj((byte_0 == null) ? null : ((byte[])byte_0.Clone()));
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A20A RID: 41482 RVA: 0x00444980 File Offset: 0x00442B80
		public virtual void uT(byte[] byte_0, int int_0, int int_1)
		{
			try
			{
				this.k.lU().tj(PQc.WW(byte_0, int_0, int_1));
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A20B RID: 41483 RVA: 0x004449C0 File Offset: 0x00442BC0
		public virtual void JXz(string string_0)
		{
			try
			{
				this.k.lU().tj(PQc.Gk(string_0));
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A20C RID: 41484 RVA: 0x00444A00 File Offset: 0x00442C00
		public virtual string uw()
		{
			return this.k.lU().tU();
		}

		// Token: 0x0600A20D RID: 41485 RVA: 0x00444A20 File Offset: 0x00442C20
		public virtual void uj(string string_0)
		{
			try
			{
				this.k.lU().tC(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A20E RID: 41486 RVA: 0x00444A58 File Offset: 0x00442C58
		public virtual int ug()
		{
			return this.k.lU().tq();
		}

		// Token: 0x0600A20F RID: 41487 RVA: 0x00444A78 File Offset: 0x00442C78
		public virtual string uu()
		{
			string text;
			try
			{
				int num = this.ug();
				int num2 = num;
				switch (num2)
				{
				case 0:
					text = "USER";
					break;
				case 1:
					text = "MACHINE";
					break;
				case 2:
					text = "PFXFILE";
					break;
				case 3:
					text = "PFXBLOB";
					break;
				case 4:
					text = "JKSFILE";
					break;
				case 5:
					text = "JKSBLOB";
					break;
				case 6:
					text = "PEMKEY_FILE";
					break;
				case 7:
					text = "PEMKEY_BLOB";
					break;
				case 8:
					text = "PUBLIC_KEY_FILE";
					break;
				case 9:
					text = "PUBLIC_KEY_BLOB";
					break;
				case 10:
					text = "SSHPUBLIC_KEY_BLOB";
					break;
				case 11:
					text = "P7BFILE";
					break;
				case 12:
					text = "P7BBLOB";
					break;
				case 13:
					text = "SSHPUBLIC_KEY_FILE";
					break;
				case 14:
					text = "PPKFILE";
					break;
				case 15:
					text = "PPKBLOB";
					break;
				case 16:
					text = "XMLFILE";
					break;
				case 17:
					text = "XMLBLOB";
					break;
				case 18:
					text = "JWKFILE";
					break;
				case 19:
					text = "JWKBLOB";
					break;
				case 20:
					text = "SECURITY_KEY";
					break;
				case 21:
					text = "BCFKSFILE";
					break;
				case 22:
					text = "BCFKSBLOB";
					break;
				case 23:
					text = "PKCS11";
					break;
				default:
					if (num2 != 99)
					{
						throw new uJw("The Enum value '" + num + "' is invalid.");
					}
					text = "AUTO";
					break;
				}
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
			return text;
		}

		// Token: 0x0600A210 RID: 41488 RVA: 0x00444C24 File Offset: 0x00442E24
		public virtual void JPC(int int_0)
		{
			try
			{
				this.k.lU().tB(int_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A211 RID: 41489 RVA: 0x00444C5C File Offset: 0x00442E5C
		public virtual void JPC(string string_0)
		{
			try
			{
				if (string_0 != null)
				{
					string text = string_0.ToUpper();
					if (text != null)
					{
						if (mcX.wh == null)
						{
							mcX.wh = new Dictionary<string, int>(25)
							{
								{ "USER", 0 },
								{ "MACHINE", 1 },
								{ "PFXFILE", 2 },
								{ "PFXBLOB", 3 },
								{ "JKSFILE", 4 },
								{ "JKSBLOB", 5 },
								{ "PEMKEY_FILE", 6 },
								{ "PEMKEY_BLOB", 7 },
								{ "PUBLIC_KEY_FILE", 8 },
								{ "PUBLIC_KEY_BLOB", 9 },
								{ "SSHPUBLIC_KEY_BLOB", 10 },
								{ "P7BFILE", 11 },
								{ "P7BBLOB", 12 },
								{ "SSHPUBLIC_KEY_FILE", 13 },
								{ "PPKFILE", 14 },
								{ "PPKBLOB", 15 },
								{ "XMLFILE", 16 },
								{ "XMLBLOB", 17 },
								{ "JWKFILE", 18 },
								{ "JWKBLOB", 19 },
								{ "SECURITY_KEY", 20 },
								{ "BCFKSFILE", 21 },
								{ "BCFKSBLOB", 22 },
								{ "PKCS11", 23 },
								{ "AUTO", 24 }
							};
						}
						int num;
						if (mcX.wh.TryGetValue(text, out num))
						{
							switch (num)
							{
							case 0:
								this.JPC(0);
								break;
							case 1:
								this.JPC(1);
								break;
							case 2:
								this.JPC(2);
								break;
							case 3:
								this.JPC(3);
								break;
							case 4:
								this.JPC(4);
								break;
							case 5:
								this.JPC(5);
								break;
							case 6:
								this.JPC(6);
								break;
							case 7:
								this.JPC(7);
								break;
							case 8:
								this.JPC(8);
								break;
							case 9:
								this.JPC(9);
								break;
							case 10:
								this.JPC(10);
								break;
							case 11:
								this.JPC(11);
								break;
							case 12:
								this.JPC(12);
								break;
							case 13:
								this.JPC(13);
								break;
							case 14:
								this.JPC(14);
								break;
							case 15:
								this.JPC(15);
								break;
							case 16:
								this.JPC(16);
								break;
							case 17:
								this.JPC(17);
								break;
							case 18:
								this.JPC(18);
								break;
							case 19:
								this.JPC(19);
								break;
							case 20:
								this.JPC(20);
								break;
							case 21:
								this.JPC(21);
								break;
							case 22:
								this.JPC(22);
								break;
							case 23:
								this.JPC(23);
								break;
							case 24:
								this.JPC(99);
								break;
							default:
								goto IL_0013;
							}
							return;
						}
					}
					IL_0013:
					throw new uJw("The Enum string value '" + string_0 + "' is invalid.");
				}
				throw new uJw("The Enum string value can't be null.");
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A212 RID: 41490 RVA: 0x00444FB4 File Offset: 0x004431B4
		public virtual string uF()
		{
			return this.k.lU().Gs();
		}

		// Token: 0x0600A213 RID: 41491 RVA: 0x00444FD4 File Offset: 0x004431D4
		public virtual string uQ()
		{
			return this.k.lU().Xs();
		}

		// Token: 0x0600A214 RID: 41492 RVA: 0x00444FF4 File Offset: 0x004431F4
		public virtual string uS()
		{
			return this.k.lU().XA();
		}

		// Token: 0x0600A215 RID: 41493 RVA: 0x00445014 File Offset: 0x00443214
		public virtual string uH()
		{
			return this.k.lU().XU();
		}

		// Token: 0x0600A216 RID: 41494 RVA: 0x00445034 File Offset: 0x00443234
		public virtual string uo()
		{
			return this.k.lU().Xq();
		}

		// Token: 0x0600A217 RID: 41495 RVA: 0x00445054 File Offset: 0x00443254
		public virtual int ul()
		{
			return this.k.lU().XB();
		}

		// Token: 0x0600A218 RID: 41496 RVA: 0x00445074 File Offset: 0x00443274
		public virtual string uX()
		{
			return this.k.lU().XN();
		}

		// Token: 0x0600A219 RID: 41497 RVA: 0x00445094 File Offset: 0x00443294
		public virtual string uy()
		{
			return this.k.lU().hm();
		}

		// Token: 0x0600A21A RID: 41498 RVA: 0x004450B4 File Offset: 0x004432B4
		public virtual void ui(string string_0)
		{
			try
			{
				this.k.lU().tW(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A21B RID: 41499 RVA: 0x004450EC File Offset: 0x004432EC
		public virtual byte[] uN()
		{
			return this.k.lU().GK();
		}

		// Token: 0x0600A21C RID: 41500 RVA: 0x0044510C File Offset: 0x0044330C
		public virtual void JPa(byte[] byte_0)
		{
			try
			{
				this.k.lU().tr((byte_0 == null) ? null : ((byte[])byte_0.Clone()));
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A21D RID: 41501 RVA: 0x00445154 File Offset: 0x00443354
		public virtual void uE(byte[] byte_0, int int_0, int int_1)
		{
			try
			{
				this.k.lU().tr(PQc.WW(byte_0, int_0, int_1));
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A21E RID: 41502 RVA: 0x00445194 File Offset: 0x00443394
		public virtual void JPa(string string_0)
		{
			try
			{
				this.k.lU().tr(PQc.Gk(string_0));
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A21F RID: 41503 RVA: 0x004451D4 File Offset: 0x004433D4
		public void uD()
		{
			try
			{
				this.k.QL(null);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A220 RID: 41504 RVA: 0x00445208 File Offset: 0x00443408
		public virtual void up()
		{
			try
			{
				this.k.QL(new wE());
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A221 RID: 41505 RVA: 0x00445240 File Offset: 0x00443440
		public virtual void JPl(string string_0)
		{
			try
			{
				this.k.QL(new wE(string_0));
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A222 RID: 41506 RVA: 0x00445278 File Offset: 0x00443478
		public virtual void JPl(byte[] byte_0)
		{
			try
			{
				this.k.QL(new wE((byte_0 == null) ? null : ((byte[])byte_0.Clone())));
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A223 RID: 41507 RVA: 0x004452C0 File Offset: 0x004434C0
		public virtual void JPJ(int int_0, string string_0, string string_1, string string_2)
		{
			try
			{
				this.k.QL(new wE(int_0, string_0, string_1, string_2));
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A224 RID: 41508 RVA: 0x004452FC File Offset: 0x004434FC
		public virtual void JPb(int int_0, string string_0, string string_1, string string_2, string string_3)
		{
			try
			{
				this.k.QL(new wE(int_0, string_0, string_1, string_2, string_3));
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A225 RID: 41509 RVA: 0x0044533C File Offset: 0x0044353C
		public virtual void JPJ(int int_0, string string_0, string string_1, byte[] byte_0)
		{
			try
			{
				this.k.QL(new wE(int_0, string_0, string_1, (byte_0 == null) ? null : ((byte[])byte_0.Clone())));
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A226 RID: 41510 RVA: 0x0044538C File Offset: 0x0044358C
		public virtual void JPJ(int int_0, byte[] byte_0, string string_0, string string_1)
		{
			try
			{
				this.k.QL(new wE(int_0, (byte_0 == null) ? null : ((byte[])byte_0.Clone()), string_0, string_1));
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A227 RID: 41511 RVA: 0x004453D8 File Offset: 0x004435D8
		public virtual void JPb(int int_0, byte[] byte_0, string string_0, string string_1, string string_2)
		{
			try
			{
				this.k.QL(new wE(int_0, (byte_0 == null) ? null : ((byte[])byte_0.Clone()), string_0, string_1, string_2));
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A228 RID: 41512 RVA: 0x00445428 File Offset: 0x00443628
		public virtual void JPJ(int int_0, byte[] byte_0, string string_0, byte[] byte_1)
		{
			try
			{
				this.k.QL(new wE(int_0, (byte_0 == null) ? null : ((byte[])byte_0.Clone()), string_0, (byte_1 == null) ? null : ((byte[])byte_1.Clone())));
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A229 RID: 41513 RVA: 0x00445488 File Offset: 0x00443688
		public virtual bool ur()
		{
			bool flag;
			try
			{
				flag = this.k.QR() == null;
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
			return flag;
		}

		// Token: 0x0600A22A RID: 41514 RVA: 0x004454C0 File Offset: 0x004436C0
		public virtual string uc()
		{
			return this.k.QR().Gz();
		}

		// Token: 0x0600A22B RID: 41515 RVA: 0x004454E0 File Offset: 0x004436E0
		public virtual string um()
		{
			return this.k.QR().hK();
		}

		// Token: 0x0600A22C RID: 41516 RVA: 0x00445500 File Offset: 0x00443700
		public virtual string uv()
		{
			return this.k.QR().GF();
		}

		// Token: 0x0600A22D RID: 41517 RVA: 0x00445520 File Offset: 0x00443720
		public virtual string uz()
		{
			return this.k.QR().Xl();
		}

		// Token: 0x0600A22E RID: 41518 RVA: 0x00445540 File Offset: 0x00443740
		public virtual string FA()
		{
			return this.k.QR().Xz();
		}

		// Token: 0x0600A22F RID: 41519 RVA: 0x00445560 File Offset: 0x00443760
		public virtual string Fj()
		{
			return this.k.QR().mK();
		}

		// Token: 0x0600A230 RID: 41520 RVA: 0x00445580 File Offset: 0x00443780
		public virtual string Fu()
		{
			return this.k.QR().hp();
		}

		// Token: 0x0600A231 RID: 41521 RVA: 0x004455A0 File Offset: 0x004437A0
		public virtual string FQ()
		{
			return this.k.QR().hj();
		}

		// Token: 0x0600A232 RID: 41522 RVA: 0x004455C0 File Offset: 0x004437C0
		public virtual bool FH()
		{
			return this.k.QR().hB();
		}

		// Token: 0x0600A233 RID: 41523 RVA: 0x004455E0 File Offset: 0x004437E0
		public virtual string Fy()
		{
			return this.k.QR().hA();
		}

		// Token: 0x0600A234 RID: 41524 RVA: 0x00445600 File Offset: 0x00443800
		public virtual string Fi()
		{
			return this.k.QR().hW();
		}

		// Token: 0x0600A235 RID: 41525 RVA: 0x00445620 File Offset: 0x00443820
		public virtual string FE()
		{
			return this.k.QR().Xh();
		}

		// Token: 0x0600A236 RID: 41526 RVA: 0x00445640 File Offset: 0x00443840
		public virtual int FD()
		{
			return this.k.QR().Xm();
		}

		// Token: 0x0600A237 RID: 41527 RVA: 0x00445660 File Offset: 0x00443860
		public virtual string Fp()
		{
			return this.k.QR().XV();
		}

		// Token: 0x0600A238 RID: 41528 RVA: 0x00445680 File Offset: 0x00443880
		public virtual string Fr()
		{
			return this.k.QR().Xp();
		}

		// Token: 0x0600A239 RID: 41529 RVA: 0x004456A0 File Offset: 0x004438A0
		public virtual byte[] Fc()
		{
			return this.k.QR().tA();
		}

		// Token: 0x0600A23A RID: 41530 RVA: 0x004456C0 File Offset: 0x004438C0
		public virtual void JPM(byte[] byte_0)
		{
			try
			{
				this.k.QR().tj((byte_0 == null) ? null : ((byte[])byte_0.Clone()));
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A23B RID: 41531 RVA: 0x00445708 File Offset: 0x00443908
		public virtual void Fm(byte[] byte_0, int int_0, int int_1)
		{
			try
			{
				this.k.QR().tj(PQc.WW(byte_0, int_0, int_1));
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A23C RID: 41532 RVA: 0x00445748 File Offset: 0x00443948
		public virtual void JPM(string string_0)
		{
			try
			{
				this.k.QR().tj(PQc.Gk(string_0));
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A23D RID: 41533 RVA: 0x00445788 File Offset: 0x00443988
		public virtual string Qk()
		{
			return this.k.QR().tU();
		}

		// Token: 0x0600A23E RID: 41534 RVA: 0x004457A8 File Offset: 0x004439A8
		public virtual void Qb(string string_0)
		{
			try
			{
				this.k.QR().tC(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A23F RID: 41535 RVA: 0x004457E0 File Offset: 0x004439E0
		public virtual int QA()
		{
			return this.k.QR().tq();
		}

		// Token: 0x0600A240 RID: 41536 RVA: 0x00445800 File Offset: 0x00443A00
		public virtual string QT()
		{
			string text;
			try
			{
				int num = this.QA();
				int num2 = num;
				switch (num2)
				{
				case 0:
					text = "USER";
					break;
				case 1:
					text = "MACHINE";
					break;
				case 2:
					text = "PFXFILE";
					break;
				case 3:
					text = "PFXBLOB";
					break;
				case 4:
					text = "JKSFILE";
					break;
				case 5:
					text = "JKSBLOB";
					break;
				case 6:
					text = "PEMKEY_FILE";
					break;
				case 7:
					text = "PEMKEY_BLOB";
					break;
				case 8:
					text = "PUBLIC_KEY_FILE";
					break;
				case 9:
					text = "PUBLIC_KEY_BLOB";
					break;
				case 10:
					text = "SSHPUBLIC_KEY_BLOB";
					break;
				case 11:
					text = "P7BFILE";
					break;
				case 12:
					text = "P7BBLOB";
					break;
				case 13:
					text = "SSHPUBLIC_KEY_FILE";
					break;
				case 14:
					text = "PPKFILE";
					break;
				case 15:
					text = "PPKBLOB";
					break;
				case 16:
					text = "XMLFILE";
					break;
				case 17:
					text = "XMLBLOB";
					break;
				case 18:
					text = "JWKFILE";
					break;
				case 19:
					text = "JWKBLOB";
					break;
				case 20:
					text = "SECURITY_KEY";
					break;
				case 21:
					text = "BCFKSFILE";
					break;
				case 22:
					text = "BCFKSBLOB";
					break;
				case 23:
					text = "PKCS11";
					break;
				default:
					if (num2 != 99)
					{
						throw new uJw("The Enum value '" + num + "' is invalid.");
					}
					text = "AUTO";
					break;
				}
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
			return text;
		}

		// Token: 0x0600A241 RID: 41537 RVA: 0x004459AC File Offset: 0x00443BAC
		public virtual void JPF(int int_0)
		{
			try
			{
				this.k.QR().tB(int_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A242 RID: 41538 RVA: 0x004459E4 File Offset: 0x00443BE4
		public virtual void JPF(string string_0)
		{
			try
			{
				if (string_0 != null)
				{
					string text = string_0.ToUpper();
					if (text != null)
					{
						if (mcX.wi == null)
						{
							mcX.wi = new Dictionary<string, int>(25)
							{
								{ "USER", 0 },
								{ "MACHINE", 1 },
								{ "PFXFILE", 2 },
								{ "PFXBLOB", 3 },
								{ "JKSFILE", 4 },
								{ "JKSBLOB", 5 },
								{ "PEMKEY_FILE", 6 },
								{ "PEMKEY_BLOB", 7 },
								{ "PUBLIC_KEY_FILE", 8 },
								{ "PUBLIC_KEY_BLOB", 9 },
								{ "SSHPUBLIC_KEY_BLOB", 10 },
								{ "P7BFILE", 11 },
								{ "P7BBLOB", 12 },
								{ "SSHPUBLIC_KEY_FILE", 13 },
								{ "PPKFILE", 14 },
								{ "PPKBLOB", 15 },
								{ "XMLFILE", 16 },
								{ "XMLBLOB", 17 },
								{ "JWKFILE", 18 },
								{ "JWKBLOB", 19 },
								{ "SECURITY_KEY", 20 },
								{ "BCFKSFILE", 21 },
								{ "BCFKSBLOB", 22 },
								{ "PKCS11", 23 },
								{ "AUTO", 24 }
							};
						}
						int num;
						if (mcX.wi.TryGetValue(text, out num))
						{
							switch (num)
							{
							case 0:
								this.JPF(0);
								break;
							case 1:
								this.JPF(1);
								break;
							case 2:
								this.JPF(2);
								break;
							case 3:
								this.JPF(3);
								break;
							case 4:
								this.JPF(4);
								break;
							case 5:
								this.JPF(5);
								break;
							case 6:
								this.JPF(6);
								break;
							case 7:
								this.JPF(7);
								break;
							case 8:
								this.JPF(8);
								break;
							case 9:
								this.JPF(9);
								break;
							case 10:
								this.JPF(10);
								break;
							case 11:
								this.JPF(11);
								break;
							case 12:
								this.JPF(12);
								break;
							case 13:
								this.JPF(13);
								break;
							case 14:
								this.JPF(14);
								break;
							case 15:
								this.JPF(15);
								break;
							case 16:
								this.JPF(16);
								break;
							case 17:
								this.JPF(17);
								break;
							case 18:
								this.JPF(18);
								break;
							case 19:
								this.JPF(19);
								break;
							case 20:
								this.JPF(20);
								break;
							case 21:
								this.JPF(21);
								break;
							case 22:
								this.JPF(22);
								break;
							case 23:
								this.JPF(23);
								break;
							case 24:
								this.JPF(99);
								break;
							default:
								goto IL_0013;
							}
							return;
						}
					}
					IL_0013:
					throw new uJw("The Enum string value '" + string_0 + "' is invalid.");
				}
				throw new uJw("The Enum string value can't be null.");
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A243 RID: 41539 RVA: 0x00445D3C File Offset: 0x00443F3C
		public virtual string Qw()
		{
			return this.k.QR().Gs();
		}

		// Token: 0x0600A244 RID: 41540 RVA: 0x00445D5C File Offset: 0x00443F5C
		public virtual string Qj()
		{
			return this.k.QR().Xs();
		}

		// Token: 0x0600A245 RID: 41541 RVA: 0x00445D7C File Offset: 0x00443F7C
		public virtual string Qg()
		{
			return this.k.QR().XA();
		}

		// Token: 0x0600A246 RID: 41542 RVA: 0x00445D9C File Offset: 0x00443F9C
		public virtual string Qu()
		{
			return this.k.QR().XU();
		}

		// Token: 0x0600A247 RID: 41543 RVA: 0x00445DBC File Offset: 0x00443FBC
		public virtual string QF()
		{
			return this.k.QR().Xq();
		}

		// Token: 0x0600A248 RID: 41544 RVA: 0x00445DDC File Offset: 0x00443FDC
		public virtual int QQ()
		{
			return this.k.QR().XB();
		}

		// Token: 0x0600A249 RID: 41545 RVA: 0x00445DFC File Offset: 0x00443FFC
		public virtual string QS()
		{
			return this.k.QR().XN();
		}

		// Token: 0x0600A24A RID: 41546 RVA: 0x00445E1C File Offset: 0x0044401C
		public virtual string QH()
		{
			return this.k.QR().hm();
		}

		// Token: 0x0600A24B RID: 41547 RVA: 0x00445E3C File Offset: 0x0044403C
		public virtual void Qo(string string_0)
		{
			try
			{
				this.k.QR().tW(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A24C RID: 41548 RVA: 0x00445E74 File Offset: 0x00444074
		public virtual byte[] Ql()
		{
			return this.k.QR().GK();
		}

		// Token: 0x0600A24D RID: 41549 RVA: 0x00445E94 File Offset: 0x00444094
		public virtual void JPo(byte[] byte_0)
		{
			try
			{
				this.k.QR().tr((byte_0 == null) ? null : ((byte[])byte_0.Clone()));
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A24E RID: 41550 RVA: 0x00445EDC File Offset: 0x004440DC
		public virtual void QX(byte[] byte_0, int int_0, int int_1)
		{
			try
			{
				this.k.QR().tr(PQc.WW(byte_0, int_0, int_1));
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A24F RID: 41551 RVA: 0x00445F1C File Offset: 0x0044411C
		public virtual void JPo(string string_0)
		{
			try
			{
				this.k.QR().tr(PQc.Gk(string_0));
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A250 RID: 41552 RVA: 0x00445F5C File Offset: 0x0044415C
		public virtual int Qy()
		{
			return this.k.QQ();
		}

		// Token: 0x0600A251 RID: 41553 RVA: 0x00445F78 File Offset: 0x00444178
		public virtual string Qi()
		{
			string text;
			try
			{
				int num = this.Qy();
				switch (num)
				{
				case 0:
					text = "AUTOMATIC";
					break;
				case 1:
					text = "PLATFORM";
					break;
				case 2:
					text = "INTERNAL";
					break;
				default:
					throw new uJw("The Enum value '" + num + "' is invalid.");
				}
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
			return text;
		}

		// Token: 0x0600A252 RID: 41554 RVA: 0x00445FF0 File Offset: 0x004441F0
		public virtual void JPh(int int_0)
		{
			try
			{
				this.k.QT(int_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A253 RID: 41555 RVA: 0x00446024 File Offset: 0x00444224
		public virtual void JPh(string string_0)
		{
			try
			{
				if (string_0 != null)
				{
					string text = string_0.ToUpper();
					if (text != null)
					{
						if (text == "AUTOMATIC")
						{
							this.JPh(0);
						}
						else if (text == "PLATFORM")
						{
							this.JPh(1);
						}
						else
						{
							if (!(text == "INTERNAL"))
							{
								goto IL_0013;
							}
							this.JPh(2);
						}
						return;
					}
					IL_0013:
					throw new uJw("The Enum string value '" + string_0 + "' is invalid.");
				}
				throw new uJw("The Enum string value can't be null.");
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A254 RID: 41556 RVA: 0x004460C0 File Offset: 0x004442C0
		public virtual bool QN()
		{
			bool flag;
			try
			{
				flag = this.k.QW() == null;
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
			return flag;
		}

		// Token: 0x0600A255 RID: 41557 RVA: 0x004460F8 File Offset: 0x004442F8
		public virtual string QE()
		{
			return this.k.QW().Gz();
		}

		// Token: 0x0600A256 RID: 41558 RVA: 0x00446118 File Offset: 0x00444318
		public virtual string QD()
		{
			return this.k.QW().hK();
		}

		// Token: 0x0600A257 RID: 41559 RVA: 0x00446138 File Offset: 0x00444338
		public virtual string Qp()
		{
			return this.k.QW().GF();
		}

		// Token: 0x0600A258 RID: 41560 RVA: 0x00446158 File Offset: 0x00444358
		public virtual string Qr()
		{
			return this.k.QW().Xl();
		}

		// Token: 0x0600A259 RID: 41561 RVA: 0x00446178 File Offset: 0x00444378
		public virtual string Qc()
		{
			return this.k.QW().Xz();
		}

		// Token: 0x0600A25A RID: 41562 RVA: 0x00446198 File Offset: 0x00444398
		public virtual string Qm()
		{
			return this.k.QW().mK();
		}

		// Token: 0x0600A25B RID: 41563 RVA: 0x004461B8 File Offset: 0x004443B8
		public virtual string Qv()
		{
			return this.k.QW().hp();
		}

		// Token: 0x0600A25C RID: 41564 RVA: 0x004461D8 File Offset: 0x004443D8
		public virtual string Qz()
		{
			return this.k.QW().hj();
		}

		// Token: 0x0600A25D RID: 41565 RVA: 0x004461F8 File Offset: 0x004443F8
		public virtual bool SA()
		{
			return this.k.QW().hB();
		}

		// Token: 0x0600A25E RID: 41566 RVA: 0x00446218 File Offset: 0x00444418
		public virtual string Sj()
		{
			return this.k.QW().hA();
		}

		// Token: 0x0600A25F RID: 41567 RVA: 0x00446238 File Offset: 0x00444438
		public virtual string Su()
		{
			return this.k.QW().hW();
		}

		// Token: 0x0600A260 RID: 41568 RVA: 0x00446258 File Offset: 0x00444458
		public virtual string SQ()
		{
			return this.k.QW().Xh();
		}

		// Token: 0x0600A261 RID: 41569 RVA: 0x00446278 File Offset: 0x00444478
		public virtual int SH()
		{
			return this.k.QW().Xm();
		}

		// Token: 0x0600A262 RID: 41570 RVA: 0x00446298 File Offset: 0x00444498
		public virtual string Sy()
		{
			return this.k.QW().XV();
		}

		// Token: 0x0600A263 RID: 41571 RVA: 0x004462B8 File Offset: 0x004444B8
		public virtual string Si()
		{
			return this.k.QW().Xp();
		}

		// Token: 0x0600A264 RID: 41572 RVA: 0x004462D8 File Offset: 0x004444D8
		public virtual byte[] SE()
		{
			return this.k.QW().tA();
		}

		// Token: 0x0600A265 RID: 41573 RVA: 0x004462F8 File Offset: 0x004444F8
		public virtual void JPg(byte[] byte_0)
		{
			try
			{
				this.k.QW().tj((byte_0 == null) ? null : ((byte[])byte_0.Clone()));
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A266 RID: 41574 RVA: 0x00446340 File Offset: 0x00444540
		public virtual void SD(byte[] byte_0, int int_0, int int_1)
		{
			try
			{
				this.k.QW().tj(PQc.WW(byte_0, int_0, int_1));
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A267 RID: 41575 RVA: 0x00446380 File Offset: 0x00444580
		public virtual void JPg(string string_0)
		{
			try
			{
				this.k.QW().tj(PQc.Gk(string_0));
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A268 RID: 41576 RVA: 0x004463C0 File Offset: 0x004445C0
		public virtual string Sp()
		{
			return this.k.QW().tU();
		}

		// Token: 0x0600A269 RID: 41577 RVA: 0x004463E0 File Offset: 0x004445E0
		public virtual void Sr(string string_0)
		{
			try
			{
				this.k.QW().tC(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A26A RID: 41578 RVA: 0x00446418 File Offset: 0x00444618
		public virtual int Sc()
		{
			return this.k.QW().tq();
		}

		// Token: 0x0600A26B RID: 41579 RVA: 0x00446438 File Offset: 0x00444638
		public virtual string Sm()
		{
			string text;
			try
			{
				int num = this.Sc();
				int num2 = num;
				switch (num2)
				{
				case 0:
					text = "USER";
					break;
				case 1:
					text = "MACHINE";
					break;
				case 2:
					text = "PFXFILE";
					break;
				case 3:
					text = "PFXBLOB";
					break;
				case 4:
					text = "JKSFILE";
					break;
				case 5:
					text = "JKSBLOB";
					break;
				case 6:
					text = "PEMKEY_FILE";
					break;
				case 7:
					text = "PEMKEY_BLOB";
					break;
				case 8:
					text = "PUBLIC_KEY_FILE";
					break;
				case 9:
					text = "PUBLIC_KEY_BLOB";
					break;
				case 10:
					text = "SSHPUBLIC_KEY_BLOB";
					break;
				case 11:
					text = "P7BFILE";
					break;
				case 12:
					text = "P7BBLOB";
					break;
				case 13:
					text = "SSHPUBLIC_KEY_FILE";
					break;
				case 14:
					text = "PPKFILE";
					break;
				case 15:
					text = "PPKBLOB";
					break;
				case 16:
					text = "XMLFILE";
					break;
				case 17:
					text = "XMLBLOB";
					break;
				case 18:
					text = "JWKFILE";
					break;
				case 19:
					text = "JWKBLOB";
					break;
				case 20:
					text = "SECURITY_KEY";
					break;
				case 21:
					text = "BCFKSFILE";
					break;
				case 22:
					text = "BCFKSBLOB";
					break;
				case 23:
					text = "PKCS11";
					break;
				default:
					if (num2 != 99)
					{
						throw new uJw("The Enum value '" + num + "' is invalid.");
					}
					text = "AUTO";
					break;
				}
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
			return text;
		}

		// Token: 0x0600A26C RID: 41580 RVA: 0x004465E4 File Offset: 0x004447E4
		public virtual void JPU(int int_0)
		{
			try
			{
				this.k.QW().tB(int_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A26D RID: 41581 RVA: 0x0044661C File Offset: 0x0044481C
		public virtual void JPU(string string_0)
		{
			try
			{
				if (string_0 != null)
				{
					string text = string_0.ToUpper();
					if (text != null)
					{
						if (mcX.wq == null)
						{
							mcX.wq = new Dictionary<string, int>(25)
							{
								{ "USER", 0 },
								{ "MACHINE", 1 },
								{ "PFXFILE", 2 },
								{ "PFXBLOB", 3 },
								{ "JKSFILE", 4 },
								{ "JKSBLOB", 5 },
								{ "PEMKEY_FILE", 6 },
								{ "PEMKEY_BLOB", 7 },
								{ "PUBLIC_KEY_FILE", 8 },
								{ "PUBLIC_KEY_BLOB", 9 },
								{ "SSHPUBLIC_KEY_BLOB", 10 },
								{ "P7BFILE", 11 },
								{ "P7BBLOB", 12 },
								{ "SSHPUBLIC_KEY_FILE", 13 },
								{ "PPKFILE", 14 },
								{ "PPKBLOB", 15 },
								{ "XMLFILE", 16 },
								{ "XMLBLOB", 17 },
								{ "JWKFILE", 18 },
								{ "JWKBLOB", 19 },
								{ "SECURITY_KEY", 20 },
								{ "BCFKSFILE", 21 },
								{ "BCFKSBLOB", 22 },
								{ "PKCS11", 23 },
								{ "AUTO", 24 }
							};
						}
						int num;
						if (mcX.wq.TryGetValue(text, out num))
						{
							switch (num)
							{
							case 0:
								this.JPU(0);
								break;
							case 1:
								this.JPU(1);
								break;
							case 2:
								this.JPU(2);
								break;
							case 3:
								this.JPU(3);
								break;
							case 4:
								this.JPU(4);
								break;
							case 5:
								this.JPU(5);
								break;
							case 6:
								this.JPU(6);
								break;
							case 7:
								this.JPU(7);
								break;
							case 8:
								this.JPU(8);
								break;
							case 9:
								this.JPU(9);
								break;
							case 10:
								this.JPU(10);
								break;
							case 11:
								this.JPU(11);
								break;
							case 12:
								this.JPU(12);
								break;
							case 13:
								this.JPU(13);
								break;
							case 14:
								this.JPU(14);
								break;
							case 15:
								this.JPU(15);
								break;
							case 16:
								this.JPU(16);
								break;
							case 17:
								this.JPU(17);
								break;
							case 18:
								this.JPU(18);
								break;
							case 19:
								this.JPU(19);
								break;
							case 20:
								this.JPU(20);
								break;
							case 21:
								this.JPU(21);
								break;
							case 22:
								this.JPU(22);
								break;
							case 23:
								this.JPU(23);
								break;
							case 24:
								this.JPU(99);
								break;
							default:
								goto IL_0013;
							}
							return;
						}
					}
					IL_0013:
					throw new uJw("The Enum string value '" + string_0 + "' is invalid.");
				}
				throw new uJw("The Enum string value can't be null.");
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A26E RID: 41582 RVA: 0x00446974 File Offset: 0x00444B74
		public virtual string Hk()
		{
			return this.k.QW().Gs();
		}

		// Token: 0x0600A26F RID: 41583 RVA: 0x00446994 File Offset: 0x00444B94
		public virtual string Hb()
		{
			return this.k.QW().Xs();
		}

		// Token: 0x0600A270 RID: 41584 RVA: 0x004469B4 File Offset: 0x00444BB4
		public virtual string HA()
		{
			return this.k.QW().XA();
		}

		// Token: 0x0600A271 RID: 41585 RVA: 0x004469D4 File Offset: 0x00444BD4
		public virtual string HT()
		{
			return this.k.QW().XU();
		}

		// Token: 0x0600A272 RID: 41586 RVA: 0x004469F4 File Offset: 0x00444BF4
		public virtual string Hw()
		{
			return this.k.QW().Xq();
		}

		// Token: 0x0600A273 RID: 41587 RVA: 0x00446A14 File Offset: 0x00444C14
		public virtual int Hj()
		{
			return this.k.QW().XB();
		}

		// Token: 0x0600A274 RID: 41588 RVA: 0x00446A34 File Offset: 0x00444C34
		public virtual string Hg()
		{
			return this.k.QW().XN();
		}

		// Token: 0x0600A275 RID: 41589 RVA: 0x00446A54 File Offset: 0x00444C54
		public virtual string Hu()
		{
			return this.k.QW().hm();
		}

		// Token: 0x0600A276 RID: 41590 RVA: 0x00446A74 File Offset: 0x00444C74
		public virtual void HF(string string_0)
		{
			try
			{
				this.k.QW().tW(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A277 RID: 41591 RVA: 0x00446AAC File Offset: 0x00444CAC
		public virtual byte[] HQ()
		{
			return this.k.QW().GK();
		}

		// Token: 0x0600A278 RID: 41592 RVA: 0x00446ACC File Offset: 0x00444CCC
		public virtual void JPv(byte[] byte_0)
		{
			try
			{
				this.k.QW().tr((byte_0 == null) ? null : ((byte[])byte_0.Clone()));
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A279 RID: 41593 RVA: 0x00446B14 File Offset: 0x00444D14
		public virtual void HS(byte[] byte_0, int int_0, int int_1)
		{
			try
			{
				this.k.QW().tr(PQc.WW(byte_0, int_0, int_1));
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A27A RID: 41594 RVA: 0x00446B54 File Offset: 0x00444D54
		public virtual void JPv(string string_0)
		{
			try
			{
				this.k.QW().tr(PQc.Gk(string_0));
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A27B RID: 41595 RVA: 0x00446B94 File Offset: 0x00444D94
		public virtual string HH()
		{
			return this.k.rz();
		}

		// Token: 0x0600A27C RID: 41596 RVA: 0x00446BB0 File Offset: 0x00444DB0
		public virtual int Ho()
		{
			return this.k.aU();
		}

		// Token: 0x0600A27D RID: 41597 RVA: 0x00446BCC File Offset: 0x00444DCC
		public virtual void Hl(int int_0)
		{
			try
			{
				this.k.aN(int_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A27E RID: 41598 RVA: 0x00446C00 File Offset: 0x00444E00
		public virtual int HX()
		{
			return this.k.ce();
		}

		// Token: 0x0600A27F RID: 41599 RVA: 0x00446C1C File Offset: 0x00444E1C
		public virtual byte[] Hy()
		{
			return this.k.HI();
		}

		// Token: 0x0600A280 RID: 41600 RVA: 0x00446C38 File Offset: 0x00444E38
		public virtual long Hi()
		{
			return this.k.lW();
		}

		// Token: 0x0600A281 RID: 41601 RVA: 0x00446C54 File Offset: 0x00444E54
		public virtual void HN(long long_0)
		{
			try
			{
				this.k.lx(long_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A282 RID: 41602 RVA: 0x00446C88 File Offset: 0x00444E88
		public virtual string HE()
		{
			return this.k.HM();
		}

		// Token: 0x0600A283 RID: 41603 RVA: 0x00446CA4 File Offset: 0x00444EA4
		public virtual string HD()
		{
			return this.k.Qv();
		}

		// Token: 0x0600A284 RID: 41604 RVA: 0x00446CC0 File Offset: 0x00444EC0
		public virtual void Hp(string string_0)
		{
			try
			{
				this.k.QM(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A285 RID: 41605 RVA: 0x00446CF4 File Offset: 0x00444EF4
		public virtual string Hr()
		{
			return this.k.QJ();
		}

		// Token: 0x0600A286 RID: 41606 RVA: 0x00446D10 File Offset: 0x00444F10
		public virtual void Hc(string string_0)
		{
			try
			{
				this.k.Qz(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A287 RID: 41607 RVA: 0x00446D44 File Offset: 0x00444F44
		public virtual int Hm()
		{
			return this.k.Qx();
		}

		// Token: 0x0600A288 RID: 41608 RVA: 0x00446D60 File Offset: 0x00444F60
		public virtual void Hv(int int_0)
		{
			try
			{
				this.k.Qk(int_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A289 RID: 41609 RVA: 0x00446D94 File Offset: 0x00444F94
		public virtual string Hz()
		{
			return this.k.QS();
		}

		// Token: 0x0600A28A RID: 41610 RVA: 0x00446DB0 File Offset: 0x00444FB0
		public virtual void oA(string string_0)
		{
			try
			{
				this.k.QY(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A28B RID: 41611 RVA: 0x00446DE4 File Offset: 0x00444FE4
		public virtual string oj()
		{
			return this.k.QW();
		}

		// Token: 0x0600A28C RID: 41612 RVA: 0x00446E00 File Offset: 0x00445000
		public virtual void ou(string string_0)
		{
			try
			{
				this.k.QN(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A28D RID: 41613 RVA: 0x00446E34 File Offset: 0x00445034
		public virtual string oQ()
		{
			return this.k.MJ();
		}

		// Token: 0x0600A28E RID: 41614 RVA: 0x00446E50 File Offset: 0x00445050
		public virtual void oH(string string_0)
		{
			try
			{
				this.k.Mo(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A28F RID: 41615 RVA: 0x00446E84 File Offset: 0x00445084
		public virtual void oy(string string_0, string string_1)
		{
			try
			{
				this.k.Bx(string_0, string_1);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A290 RID: 41616 RVA: 0x00446EB8 File Offset: 0x004450B8
		public virtual void oi()
		{
			try
			{
				this.k.Bp();
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A291 RID: 41617 RVA: 0x00446EEC File Offset: 0x004450EC
		public virtual string oE(string string_0)
		{
			string text;
			try
			{
				text = this.k.ag(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
			return text;
		}

		// Token: 0x0600A292 RID: 41618 RVA: 0x00446F24 File Offset: 0x00445124
		public virtual void oD()
		{
			try
			{
				this.k.lX();
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A293 RID: 41619 RVA: 0x00446F58 File Offset: 0x00445158
		public virtual void op(string string_0)
		{
			try
			{
				this.k.Be(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A294 RID: 41620 RVA: 0x00446F8C File Offset: 0x0044518C
		public virtual void or()
		{
			try
			{
				this.k.lN();
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A295 RID: 41621 RVA: 0x00446FC0 File Offset: 0x004451C0
		public virtual void oc()
		{
			try
			{
				this.k.lC();
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A296 RID: 41622 RVA: 0x00446FF4 File Offset: 0x004451F4
		public virtual void om(string string_0)
		{
			try
			{
				this.k.BF(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A297 RID: 41623 RVA: 0x00447028 File Offset: 0x00445228
		public virtual void lA(string string_0)
		{
			try
			{
				this.k.BS(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A298 RID: 41624 RVA: 0x0044705C File Offset: 0x0044525C
		public virtual void lj()
		{
			try
			{
				this.k.aw();
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A299 RID: 41625 RVA: 0x00447090 File Offset: 0x00445290
		public virtual void lu(string string_0)
		{
			try
			{
				this.k.BW(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A29A RID: 41626 RVA: 0x004470C4 File Offset: 0x004452C4
		public virtual void lQ(string string_0)
		{
			try
			{
				this.k.BY(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A29B RID: 41627 RVA: 0x004470F8 File Offset: 0x004452F8
		public virtual void lH(string string_0)
		{
			try
			{
				this.k.bX(string_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A29C RID: 41628 RVA: 0x0044712C File Offset: 0x0044532C
		public virtual void ly()
		{
			try
			{
				this.k.lh();
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A29D RID: 41629 RVA: 0x00447160 File Offset: 0x00445360
		public virtual void li()
		{
			try
			{
				this.k.bN();
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A29E RID: 41630 RVA: 0x00447194 File Offset: 0x00445394
		public virtual void lE(Stream stream_0)
		{
			try
			{
				this.k.be(stream_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A29F RID: 41631 RVA: 0x004471CC File Offset: 0x004453CC
		public virtual void lD(Stream stream_0)
		{
			try
			{
				this.k.bw(stream_0);
			}
			catch (uJw uJw)
			{
				throw new PBr(uJw);
			}
		}

		// Token: 0x0600A2A0 RID: 41632 RVA: 0x00447204 File Offset: 0x00445404
		public virtual void Yg(int int_0, string string_0)
		{
			if (this.m != null)
			{
				this.m.JXJ(int_0, string_0);
			}
		}

		// Token: 0x0600A2A1 RID: 41633 RVA: 0x0044722C File Offset: 0x0044542C
		public virtual void kF(string string_0, int int_0, string string_1)
		{
			if (this.m != null)
			{
				this.m.JXb(string_0, int_0, string_1);
			}
		}

		// Token: 0x0600A2A2 RID: 41634 RVA: 0x00447254 File Offset: 0x00445454
		public virtual void YU(int int_0, string string_0)
		{
			if (this.m != null)
			{
				this.m.JXM(int_0, string_0);
			}
		}

		// Token: 0x0600A2A3 RID: 41635 RVA: 0x0044727C File Offset: 0x0044547C
		public virtual void bq(int int_0)
		{
			if (this.m != null)
			{
				this.m.JXF(int_0);
			}
		}

		// Token: 0x0600A2A4 RID: 41636 RVA: 0x004472A0 File Offset: 0x004454A0
		public virtual void aP(int int_0, string string_0)
		{
			if (this.m != null)
			{
				this.m.JXo(int_0, string_0);
			}
		}

		// Token: 0x0600A2A5 RID: 41637 RVA: 0x004472C8 File Offset: 0x004454C8
		public virtual void Yv(string string_0, string string_1)
		{
			if (this.m != null)
			{
				this.m.JXh(string_0, string_1);
			}
		}

		// Token: 0x0600A2A6 RID: 41638 RVA: 0x004472F0 File Offset: 0x004454F0
		public virtual void YS(int int_0, string string_0, string string_1)
		{
			if (this.m != null)
			{
				this.m.JXg(int_0, string_0, string_1);
			}
		}

		// Token: 0x0600A2A7 RID: 41639 RVA: 0x00447318 File Offset: 0x00445518
		public virtual void YX(string string_0, bool[] bool_0)
		{
			if (this.m != null)
			{
				this.m.JXU(string_0, bool_0);
			}
		}

		// Token: 0x0600A2A8 RID: 41640 RVA: 0x00447340 File Offset: 0x00445540
		public virtual void YP(string string_0, string string_1, string string_2, string string_3, string string_4, bool bool_0)
		{
			if (this.m != null)
			{
				this.m.JXv(string_0, string_1, string_2, string_3, string_4, bool_0);
			}
		}

		// Token: 0x0600A2A9 RID: 41641 RVA: 0x0044736C File Offset: 0x0044556C
		public virtual void ad(byte[] byte_0, string string_0, string string_1, string string_2, bool[] bool_0)
		{
			if (this.m != null)
			{
				this.m.JXS(byte_0, string_0, string_1, string_2, bool_0);
			}
		}

		// Token: 0x0600A2AA RID: 41642 RVA: 0x00447398 File Offset: 0x00445598
		public virtual void ll(string string_0)
		{
			if (this.m != null)
			{
				this.m.JXX(string_0);
			}
		}

		// Token: 0x0600A2AB RID: 41643 RVA: 0x004473BC File Offset: 0x004455BC
		public virtual void bP(int int_0)
		{
			if (this.m != null)
			{
				this.m.JXP(int_0);
			}
		}

		// Token: 0x0600A2AC RID: 41644 RVA: 0x004473E0 File Offset: 0x004455E0
		public virtual void YI(string string_0, int int_0, string string_1)
		{
			if (this.m != null)
			{
				this.m.JXI(string_0, int_0, string_1);
			}
		}

		// Token: 0x0600A2AD RID: 41645 RVA: 0x00447408 File Offset: 0x00445608
		public virtual void MS(int int_0, long long_0, int int_1, byte[] byte_0)
		{
			if (this.m != null)
			{
				this.m.JXq(int_0, long_0, int_1, byte_0);
			}
		}

		// Token: 0x04005659 RID: 22105
		public const int q = 0;

		// Token: 0x0400565A RID: 22106
		public const int x = 1;

		// Token: 0x0400565B RID: 22107
		public const int J = 2;

		// Token: 0x0400565C RID: 22108
		public const int u = 3;

		// Token: 0x0400565D RID: 22109
		public const int a = 4;

		// Token: 0x0400565E RID: 22110
		public const int l = 5;

		// Token: 0x0400565F RID: 22111
		public const int F = 6;

		// Token: 0x04005660 RID: 22112
		public const int r = 0;

		// Token: 0x04005661 RID: 22113
		public const int y = 1;

		// Token: 0x04005662 RID: 22114
		public const int i = 2;

		// Token: 0x04005663 RID: 22115
		public const int e = 0;

		// Token: 0x04005664 RID: 22116
		public const int H = 1;

		// Token: 0x04005665 RID: 22117
		public const int O = 2;

		// Token: 0x04005666 RID: 22118
		private PQ k = null;

		// Token: 0x04005667 RID: 22119
		private PZJ m = null;
	}
}
