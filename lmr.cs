using System;
using System.Collections;
using System.Collections.Generic;

namespace Arc264y
{
	// Token: 0x02000B30 RID: 2864
	internal class lmr<lmE> : IList<lmE>, ICollection<lmE>, IEnumerable<lmE>, IList, ICollection, IEnumerable
	{
		// Token: 0x0600DF1C RID: 57116 RVA: 0x000696D0 File Offset: 0x000678D0
		public lmr()
		{
			this.v = new List<lmE>();
		}

		// Token: 0x0600DF1D RID: 57117 RVA: 0x000696E3 File Offset: 0x000678E3
		public lmr(ICollection<lmE> icollection_0)
		{
			this.v = new List<lmE>(icollection_0);
		}

		// Token: 0x0600DF1E RID: 57118 RVA: 0x000696F7 File Offset: 0x000678F7
		public lmr(int int_0)
		{
			this.v = new List<lmE>(int_0);
		}

		// Token: 0x0600DF1F RID: 57119 RVA: 0x0054B370 File Offset: 0x00549570
		public static implicit operator lmr<lmE>(List<lmE> list_0)
		{
			lmr<lmE> lmr2;
			if (list_0 != null)
			{
				lmr<lmE> lmr = new lmr<lmE>();
				lmr.m(list_0);
				lmr2 = lmr;
			}
			else
			{
				lmr2 = null;
			}
			return lmr2;
		}

		// Token: 0x0600DF20 RID: 57120 RVA: 0x0054B39C File Offset: 0x0054959C
		public static implicit operator List<lmE>(lmr<lmE> lmr_0)
		{
			return lmr_0.s();
		}

		// Token: 0x0600DF21 RID: 57121 RVA: 0x0006970B File Offset: 0x0006790B
		public void x(int int_0)
		{
			this.v.Capacity = int_0;
		}

		// Token: 0x0600DF22 RID: 57122 RVA: 0x00069719 File Offset: 0x00067919
		public void Add(lmE value)
		{
			this.v.Add(value);
		}

		// Token: 0x0600DF23 RID: 57123 RVA: 0x00069727 File Offset: 0x00067927
		public void u(int int_0, lmE gparam_0)
		{
			this.v.Insert(int_0, gparam_0);
		}

		// Token: 0x0600DF24 RID: 57124 RVA: 0x00069736 File Offset: 0x00067936
		public void r(ICollection<lmE> icollection_0)
		{
			this.v.AddRange(icollection_0);
		}

		// Token: 0x0600DF25 RID: 57125 RVA: 0x0054B3B4 File Offset: 0x005495B4
		public lmE y(int int_0)
		{
			return this[int_0];
		}

		// Token: 0x0600DF26 RID: 57126 RVA: 0x00069744 File Offset: 0x00067944
		public void i(int int_0, lmE gparam_0)
		{
			this[int_0] = gparam_0;
		}

		// Token: 0x0600DF27 RID: 57127 RVA: 0x0054B3CC File Offset: 0x005495CC
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.O();
		}

		// Token: 0x0600DF28 RID: 57128 RVA: 0x0054B3E4 File Offset: 0x005495E4
		IEnumerator<lmE> IEnumerable<lmE>.H()
		{
			return this.O();
		}

		// Token: 0x0600DF29 RID: 57129 RVA: 0x0054B3FC File Offset: 0x005495FC
		public lmg<lmE> O()
		{
			return new lmg<lmE>(this);
		}

		// Token: 0x0600DF2A RID: 57130 RVA: 0x0006974E File Offset: 0x0006794E
		public void m(List<lmE> list_0)
		{
			this.v = list_0;
		}

		// Token: 0x0600DF2B RID: 57131 RVA: 0x0054B414 File Offset: 0x00549614
		public List<lmE> s()
		{
			return this.v;
		}

		// Token: 0x170000A5 RID: 165
		public lmE this[int index]
		{
			get
			{
				return this.v[index];
			}
			set
			{
				this.v[index] = value;
			}
		}

		// Token: 0x0600DF2E RID: 57134 RVA: 0x0054B448 File Offset: 0x00549648
		public int G()
		{
			return this.v.Count;
		}

		// Token: 0x0600DF2F RID: 57135 RVA: 0x0054B464 File Offset: 0x00549664
		public lmE[] p()
		{
			return this.c(typeof(lmE));
		}

		// Token: 0x0600DF30 RID: 57136 RVA: 0x0054B484 File Offset: 0x00549684
		public lmE[] c(Type type_0)
		{
			lmE[] array = new lmE[this.G()];
			for (int i = 0; i < this.G(); i++)
			{
				array[i] = this.y(i);
			}
			return array;
		}

		// Token: 0x0600DF31 RID: 57137 RVA: 0x0054B4C4 File Offset: 0x005496C4
		public bool Contains(lmE item)
		{
			return this.v.Contains(item);
		}

		// Token: 0x0600DF32 RID: 57138 RVA: 0x00069766 File Offset: 0x00067966
		public virtual void Clear()
		{
			this.v.Clear();
		}

		// Token: 0x0600DF33 RID: 57139 RVA: 0x0054B4E0 File Offset: 0x005496E0
		public int IndexOf(lmE item)
		{
			return this.v.IndexOf(item);
		}

		// Token: 0x0600DF34 RID: 57140 RVA: 0x0054B4FC File Offset: 0x005496FC
		public int Z(lmE gparam_0)
		{
			return this.v.LastIndexOf(gparam_0);
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600DF35 RID: 57141 RVA: 0x0054B518 File Offset: 0x00549718
		public int Count
		{
			get
			{
				return this.G();
			}
		}

		// Token: 0x0600DF36 RID: 57142 RVA: 0x00069773 File Offset: 0x00067973
		public void RemoveAt(int index)
		{
			this.v.RemoveAt(index);
		}

		// Token: 0x0600DF37 RID: 57143 RVA: 0x00069781 File Offset: 0x00067981
		public void CopyTo(lmE[] array, int index)
		{
			this.v.CopyTo(array, index);
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600DF38 RID: 57144 RVA: 0x0054B530 File Offset: 0x00549730
		bool IList.IsReadOnly
		{
			get
			{
				return ((IList)this.v).IsReadOnly;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600DF39 RID: 57145 RVA: 0x0054B548 File Offset: 0x00549748
		bool IList.IsFixedSize
		{
			get
			{
				return ((IList)this.v).IsFixedSize;
			}
		}

		// Token: 0x170000A9 RID: 169
		object IList.this[int index]
		{
			get
			{
				return ((IList)this.v)[index];
			}
			set
			{
				((IList)this.v)[index] = value;
			}
		}

		// Token: 0x0600DF3C RID: 57148 RVA: 0x0006979F File Offset: 0x0006799F
		void IList.xa(object value)
		{
			((IList)this.v).Remove(value);
		}

		// Token: 0x0600DF3D RID: 57149 RVA: 0x000697AD File Offset: 0x000679AD
		void IList.xl(int index, object value)
		{
			((IList)this.v).Insert(index, value);
		}

		// Token: 0x0600DF3E RID: 57150 RVA: 0x0054B57C File Offset: 0x0054977C
		int IList.xF(object value)
		{
			return ((IList)this.v).IndexOf(value);
		}

		// Token: 0x0600DF3F RID: 57151 RVA: 0x0054B598 File Offset: 0x00549798
		bool IList.xr(object value)
		{
			return ((IList)this.v).Contains(value);
		}

		// Token: 0x0600DF40 RID: 57152 RVA: 0x0054B5B4 File Offset: 0x005497B4
		int IList.xy(object value)
		{
			return ((IList)this.v).Add(value);
		}

		// Token: 0x0600DF41 RID: 57153 RVA: 0x000697BC File Offset: 0x000679BC
		void ICollection.xi(Array array, int index)
		{
			((ICollection)this.v).CopyTo(array, index);
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600DF42 RID: 57154 RVA: 0x0054B5D0 File Offset: 0x005497D0
		bool ICollection.IsSynchronized
		{
			get
			{
				return ((ICollection)this.v).IsSynchronized;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600DF43 RID: 57155 RVA: 0x0054B5E8 File Offset: 0x005497E8
		object ICollection.SyncRoot
		{
			get
			{
				return ((ICollection)this.v).SyncRoot;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600DF44 RID: 57156 RVA: 0x0054B604 File Offset: 0x00549804
		bool ICollection<lmE>.IsReadOnly
		{
			get
			{
				return ((ICollection<lmE>)this.v).IsReadOnly;
			}
		}

		// Token: 0x0600DF45 RID: 57157 RVA: 0x00069727 File Offset: 0x00067927
		public void Insert(int index, lmE item)
		{
			this.v.Insert(index, item);
		}

		// Token: 0x0600DF46 RID: 57158 RVA: 0x0054B61C File Offset: 0x0054981C
		public bool Remove(lmE item)
		{
			return this.v.Remove(item);
		}

		// Token: 0x0600DF47 RID: 57159 RVA: 0x00069773 File Offset: 0x00067973
		public void xk(int int_0)
		{
			this.v.RemoveAt(int_0);
		}

		// Token: 0x0600DF48 RID: 57160 RVA: 0x000697CB File Offset: 0x000679CB
		public void xm(Comparison<lmE> comparison_0)
		{
			this.v.Sort(comparison_0);
		}

		// Token: 0x0600DF49 RID: 57161 RVA: 0x000697D9 File Offset: 0x000679D9
		public void xb(IComparer<lmE> icomparer_0)
		{
			this.v.Sort(icomparer_0);
		}

		// Token: 0x0600DF4A RID: 57162 RVA: 0x000697E7 File Offset: 0x000679E7
		public void xs()
		{
			this.v.Sort();
		}

		// Token: 0x0600DF4B RID: 57163 RVA: 0x0054B638 File Offset: 0x00549838
		public ICollection<lmE> xG(int int_0, int int_1)
		{
			return this.v.GetRange(int_0, int_1 - int_0);
		}

		// Token: 0x04005A32 RID: 23090
		private List<lmE> v;
	}
}
