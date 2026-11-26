using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace Arc264y
{
	// Token: 0x02000B23 RID: 2851
	internal class lyv<lyJ> : lyN
	{
		// Token: 0x0600DEC9 RID: 57033 RVA: 0x0006953C File Offset: 0x0006773C
		public lyv()
		{
		}

		// Token: 0x0600DECA RID: 57034 RVA: 0x00069544 File Offset: 0x00067744
		public lyv(ICollection icollection_0)
			: base(icollection_0)
		{
		}

		// Token: 0x0600DECB RID: 57035 RVA: 0x0006954D File Offset: 0x0006774D
		public lyv(int int_0)
			: base(int_0)
		{
		}

		// Token: 0x0600DECC RID: 57036 RVA: 0x00069556 File Offset: 0x00067756
		public virtual void MPh(lyJ gparam_0, int int_0)
		{
			this.Insert(int_0, gparam_0);
		}

		// Token: 0x0600DECD RID: 57037 RVA: 0x00069565 File Offset: 0x00067765
		public virtual void MPg(lyJ gparam_0)
		{
			this.Add(gparam_0);
		}

		// Token: 0x0600DECE RID: 57038 RVA: 0x00069574 File Offset: 0x00067774
		public virtual void MPU(int int_0, lyJ gparam_0)
		{
			this.MPh(gparam_0, int_0);
		}

		// Token: 0x0600DECF RID: 57039 RVA: 0x0006957E File Offset: 0x0006777E
		public virtual void MPv(lyJ gparam_0, int int_0)
		{
			this[int_0] = gparam_0;
		}

		// Token: 0x0600DED0 RID: 57040 RVA: 0x0054A61C File Offset: 0x0054881C
		public lyJ A()
		{
			if (this.Count == 0)
			{
				throw new Exception();
			}
			return (lyJ)((object)this[this.Count - 1]);
		}

		// Token: 0x0600DED1 RID: 57041 RVA: 0x0054A654 File Offset: 0x00548854
		public lyJ n(int int_0)
		{
			return (lyJ)((object)this[int_0]);
		}

		// Token: 0x0600DED2 RID: 57042 RVA: 0x0054A654 File Offset: 0x00548854
		public new lyJ j(int int_0)
		{
			return (lyJ)((object)this[int_0]);
		}

		// Token: 0x0600DED3 RID: 57043 RVA: 0x0054A670 File Offset: 0x00548870
		[MethodImpl(MethodImplOptions.Synchronized)]
		public virtual bool MPS(lyJ gparam_0)
		{
			int num = this.IndexOf(gparam_0);
			bool flag;
			if (flag = num != -1)
			{
				this.RemoveAt(this.IndexOf(gparam_0));
			}
			return flag;
		}

		// Token: 0x0600DED4 RID: 57044 RVA: 0x0054A6AC File Offset: 0x005488AC
		public override object Clone()
		{
			return new lyv<lyJ>(this);
		}

		// Token: 0x0600DED5 RID: 57045 RVA: 0x0054A6C4 File Offset: 0x005488C4
		[MethodImpl(MethodImplOptions.Synchronized)]
		public lyJ x(int int_0)
		{
			lyJ lyJ = this.j(int_0);
			this.j(int_0);
			return lyJ;
		}
	}
}
