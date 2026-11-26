using System;
using RSSBus;

namespace Arc264y
{
	// Token: 0x020014B3 RID: 5299
	internal abstract class gut : gui, guw
	{
		// Token: 0x06013495 RID: 78997
		protected internal abstract string ovI();

		// Token: 0x06013496 RID: 78998
		protected internal abstract string ovq();

		// Token: 0x06013497 RID: 78999
		protected internal abstract bool ovN();

		// Token: 0x06013498 RID: 79000 RVA: 0x0076F4E8 File Offset: 0x0076D6E8
		public void s(string string_0, guB guB_0)
		{
			if (Eyf.lx(string_0))
			{
				return;
			}

			byte[] keyBytes = Eyf.IV(string_0);
			if (this.oUk(keyBytes))
			{
				guB_0.IV(true);
				guB_0.Im(this.oUz(keyBytes));
			}
			guB_0.Ir(rrh.K(keyBytes));
			guB_0.nL(this.ova(keyBytes));
		}

		// Token: 0x06013499 RID: 79001 RVA: 0x0076F544 File Offset: 0x0076D744
		public guB ovP(bool bool_0)
		{
			guB guB = new guB(this.ovI(), this.oUI(), this.oUN(), this.ovq());
			try
			{
				if (!this.ovN())
				{
					string[] array = new string[] { "[NO-VALID-LICENSE]" };
					byte[][] array2 = new byte[1][];
					string text = this.oUw();
					guB.iX(text);
					base.A(array, array2);
					guB.pn(text, guB.Y);
					byte[] array3 = array2[0];
					if (!rrh.K(array3))
					{
						guB.IE(array[0]);
						if (this.oUk(array3))
						{
							guB.IV(true);
							guB.Im(this.oUz(array3));
							guB.In(base.Q(array3));
							if (guB.y() <= 0 && base.i(array3) == 1)
							{
								string text2 = Eyf.OS("The subscription license has expired for this product.  The product will not continue functioning as expected.  To avoid any disruptions in service please contact {0} immediately.", "arcsales@cdata.com");
								rga.Fu("application", "arc.core.lic").ku(text2, "CheckKey");
								guB.ng(text2);
							}
						}
					}
					else
					{
						guB.Ir(true);
						guB.In(base.Q(array3));
						array[0] = Eyf.OS("[30 DAY TRIAL VERSION - {0} DAYS LEFT]", Eyf.Dt(guB.y()));
						guB.IE(array[0]);
					}
				}
				else
				{
					guB.Ix(true);
					guB.In(rrh.H(1802304000L));
					guB.IE(Eyf.OS("[TIME LIMITED BETA - {0} DAYS LEFT]", Eyf.Dt(rrh.H(1802304000L))));
					if (!rrh.r(1802304000L))
					{
						throw new RSBException("rsb:license", Eyf.IB("The beta period for the {0} Connector has expired. Please check for a new build at {1} or contact {2} for assistance.", false, new object[]
						{
							this.ovI(),
							"arc.cdata.com",
							"arcsupport@cdata.com"
						}));
					}
				}
			}
			catch (RSBException ex)
			{
				if (!bool_0)
				{
					guB.ng(Eyf.eD(ex));
				}
				else
				{
					guB.nE(ex);
				}
			}
			return guB;
		}

		// Token: 0x0601349A RID: 79002 RVA: 0x0076F768 File Offset: 0x0076D968
		protected internal override string oUw()
		{
			try
			{
				return gPf.V(this.ovI());
			}
			catch (RSBException)
			{
				return null;
			}
		}

		// Token: 0x0601349B RID: 79003 RVA: 0x0076C0B0 File Offset: 0x0076A2B0
		protected internal override bool oUk(byte[] byte_0)
		{
			return rrh.G(byte_0);
		}

		// Token: 0x0601349C RID: 79004 RVA: 0x0076C0C4 File Offset: 0x0076A2C4
		protected internal override int oUR(byte[] byte_0)
		{
			return rrh.f(byte_0);
		}

		// Token: 0x0601349D RID: 79005 RVA: 0x0009ABDC File Offset: 0x00098DDC
		protected internal override bool oUT()
		{
			return false;
		}

		// Token: 0x0601349E RID: 79006 RVA: 0x0076C0DC File Offset: 0x0076A2DC
		protected internal override bool oUz(byte[] byte_0)
		{
			return rrh.t(byte_0);
		}

		// Token: 0x0601349F RID: 79007 RVA: 0x0009ABDC File Offset: 0x00098DDC
		protected internal override bool oUY(int int_0, byte[] byte_0, string string_0)
		{
			return false;
		}

		// Token: 0x060134A0 RID: 79008 RVA: 0x0009ABDC File Offset: 0x00098DDC
		protected internal override bool oUd(byte[] byte_0)
		{
			return false;
		}

		// Token: 0x060134A1 RID: 79009 RVA: 0x0009ABDC File Offset: 0x00098DDC
		protected internal override bool ovC(byte[] byte_0)
		{
			return false;
		}
	}
}
