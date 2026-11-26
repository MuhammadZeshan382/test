using System;
using System.Collections;
using System.Collections.Generic;

namespace Arc264y
{
	// Token: 0x02000B2E RID: 2862
	internal class lmD<lmu, lmP> : Hashtable
	{
		// Token: 0x0600DF08 RID: 57096 RVA: 0x00069691 File Offset: 0x00067891
		public lmD()
		{
			this.P = Hashtable.Synchronized(this);
		}

		// Token: 0x0600DF09 RID: 57097 RVA: 0x000696A5 File Offset: 0x000678A5
		public lmD(IEqualityComparer iequalityComparer_0)
			: base(iequalityComparer_0)
		{
			this.P = Hashtable.Synchronized(this);
		}

		// Token: 0x0600DF0A RID: 57098 RVA: 0x000696BA File Offset: 0x000678BA
		public lmD(Hashtable hashtable_0, IEqualityComparer iequalityComparer_0)
			: base(hashtable_0, iequalityComparer_0)
		{
			this.P = Hashtable.Synchronized(this);
		}

		// Token: 0x0600DF0B RID: 57099 RVA: 0x0054B010 File Offset: 0x00549210
		public lmP m(lmu gparam_0)
		{
			return (lmP)((object)base[gparam_0]);
		}

		// Token: 0x0600DF0C RID: 57100 RVA: 0x0054B030 File Offset: 0x00549230
		public lmP H(lmu gparam_0, lmP gparam_1)
		{
			object obj = base[gparam_0];
			this.P[gparam_0] = gparam_1;
			return (obj != null) ? ((lmP)((object)obj)) : default(lmP);
		}

		// Token: 0x0600DF0D RID: 57101 RVA: 0x0054B078 File Offset: 0x00549278
		public lmP E(lmu gparam_0)
		{
			lmP lmP = (lmP)((object)base[gparam_0]);
			this.P.Remove(gparam_0);
			return lmP;
		}

		// Token: 0x0600DF0E RID: 57102 RVA: 0x0054AEB4 File Offset: 0x005490B4
		public int A()
		{
			return base.Count;
		}

		// Token: 0x0600DF0F RID: 57103 RVA: 0x0054B0AC File Offset: 0x005492AC
		public ICollection i()
		{
			return this.P.Keys;
		}

		// Token: 0x0600DF10 RID: 57104 RVA: 0x0054B0C8 File Offset: 0x005492C8
		public lyh n()
		{
			lyh lyh2;
			lock (this.P.SyncRoot)
			{
				lyh lyh = new lyQ(new ArrayList(this.P.Keys));
				lyh2 = lyh;
			}
			return lyh2;
		}

		// Token: 0x0600DF11 RID: 57105 RVA: 0x0054B124 File Offset: 0x00549324
		public ICollection<lmu> y()
		{
			List<lmu> list = new List<lmu>();
			lock (this.P.SyncRoot)
			{
				foreach (object obj in this.P.Keys)
				{
					list.Add((lmu)((object)obj));
				}
			}
			return list;
		}

		// Token: 0x0600DF12 RID: 57106 RVA: 0x0054B1CC File Offset: 0x005493CC
		public ICollection<lmP> t()
		{
			List<lmP> list = new List<lmP>();
			lock (this.P.SyncRoot)
			{
				foreach (object obj in this.P.Values)
				{
					list.Add((lmP)((object)obj));
				}
			}
			return list;
		}

		// Token: 0x0600DF13 RID: 57107 RVA: 0x0054B274 File Offset: 0x00549474
		public override object Clone()
		{
			lmD<lmu, lmP> lmD = new lmD<lmu, lmP>();
			lock (this.P.SyncRoot)
			{
				IDictionaryEnumerator enumerator = this.GetEnumerator();
				while (enumerator.MoveNext())
				{
					lmD.Add(enumerator.Key, enumerator.Value);
				}
			}
			return lmD;
		}

		// Token: 0x04005A31 RID: 23089
		private readonly Hashtable P;
	}
}
