using System;
using System.Collections;
using System.Collections.Generic;

namespace Arc264y
{
	// Token: 0x02000B31 RID: 2865
	internal class lmg<lmy> : IEnumerator<lmy>, IDisposable, IEnumerator
	{
		// Token: 0x0600DF4C RID: 57164 RVA: 0x000697F4 File Offset: 0x000679F4
		public lmg(lmr<lmy> lmr_0)
		{
			this.i = lmr_0;
			this.T = -1;
			this.d = default(lmy);
		}

		// Token: 0x0600DF4D RID: 57165 RVA: 0x0054B658 File Offset: 0x00549858
		public bool MoveNext()
		{
			bool flag;
			if (++this.T < this.i.G())
			{
				this.d = this.i[this.T];
				flag = true;
			}
			else
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x0600DF4E RID: 57166 RVA: 0x00069816 File Offset: 0x00067A16
		public void Reset()
		{
			this.T = -1;
		}

		// Token: 0x0600DF4F RID: 57167 RVA: 0x000440D5 File Offset: 0x000422D5
		void IDisposable.MPI()
		{
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600DF50 RID: 57168 RVA: 0x0054B6A4 File Offset: 0x005498A4
		public lmy Current
		{
			get
			{
				return this.d;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600DF51 RID: 57169 RVA: 0x0054B6BC File Offset: 0x005498BC
		object IEnumerator.Current
		{
			get
			{
				return this.Current;
			}
		}

		// Token: 0x04005A33 RID: 23091
		private lmr<lmy> i;

		// Token: 0x04005A34 RID: 23092
		private int T;

		// Token: 0x04005A35 RID: 23093
		private lmy d;
	}
}
