using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Text;

namespace Arc264y
{
	// Token: 0x02000B22 RID: 2850
	internal class lyN : ArrayList
	{
		// Token: 0x0600DE8E RID: 56974 RVA: 0x0004C41A File Offset: 0x0004A61A
		public lyN()
		{
		}

		// Token: 0x0600DE8F RID: 56975 RVA: 0x0004C422 File Offset: 0x0004A622
		public lyN(ICollection icollection_0)
			: base(icollection_0)
		{
		}

		// Token: 0x0600DE90 RID: 56976 RVA: 0x0004C42B File Offset: 0x0004A62B
		public lyN(int int_0)
			: base(int_0)
		{
		}

		// Token: 0x0600DE91 RID: 56977 RVA: 0x00163368 File Offset: 0x00161568
		public int W()
		{
			return this.Count;
		}

		// Token: 0x0600DE92 RID: 56978 RVA: 0x00163380 File Offset: 0x00161580
		[MethodImpl(MethodImplOptions.Synchronized)]
		public void c(int int_0)
		{
			if (int_0 < this.Count)
			{
				this.RemoveRange(int_0, this.Count - int_0);
			}
			else
			{
				while (int_0 > this.Count)
				{
					this.Add(null);
				}
			}
		}

		// Token: 0x0600DE93 RID: 56979 RVA: 0x0004C434 File Offset: 0x0004A634
		public virtual void MPh(object object_0, int int_0)
		{
			this.Insert(int_0, object_0);
		}

		// Token: 0x0600DE94 RID: 56980 RVA: 0x0004C43E File Offset: 0x0004A63E
		public virtual void MPg(object object_0)
		{
			this.Add(object_0);
		}

		// Token: 0x0600DE95 RID: 56981 RVA: 0x0004C448 File Offset: 0x0004A648
		public virtual void u(ICollection icollection_0)
		{
			this.AddRange(icollection_0);
		}

		// Token: 0x0600DE96 RID: 56982 RVA: 0x00069474 File Offset: 0x00067674
		public virtual void MPU(int int_0, object object_0)
		{
			this.MPh(object_0, int_0);
		}

		// Token: 0x0600DE97 RID: 56983 RVA: 0x0006947E File Offset: 0x0006767E
		public virtual void y(int int_0, object object_0)
		{
			this.MPv(object_0, int_0);
		}

		// Token: 0x0600DE98 RID: 56984 RVA: 0x0004C45B File Offset: 0x0004A65B
		public virtual void MPv(object object_0, int int_0)
		{
			this[int_0] = object_0;
		}

		// Token: 0x0600DE99 RID: 56985 RVA: 0x001633C4 File Offset: 0x001615C4
		public object i()
		{
			if (this.Count == 0)
			{
				throw new Exception();
			}
			return this[this.Count - 1];
		}

		// Token: 0x0600DE9A RID: 56986 RVA: 0x001633F8 File Offset: 0x001615F8
		public bool O()
		{
			return this.Count == 0;
		}

		// Token: 0x0600DE9B RID: 56987 RVA: 0x00163410 File Offset: 0x00161610
		public object D(int int_0)
		{
			return this[int_0];
		}

		// Token: 0x0600DE9C RID: 56988 RVA: 0x00163410 File Offset: 0x00161610
		public object K(int int_0)
		{
			return this[int_0];
		}

		// Token: 0x0600DE9D RID: 56989 RVA: 0x00163428 File Offset: 0x00161628
		[MethodImpl(MethodImplOptions.Synchronized)]
		public virtual bool MPS(object object_0)
		{
			int num = this.IndexOf(object_0);
			bool flag;
			if (flag = num != -1)
			{
				this.RemoveAt(this.IndexOf(object_0));
			}
			return flag;
		}

		// Token: 0x0600DE9E RID: 56990 RVA: 0x0004C465 File Offset: 0x0004A665
		internal virtual void j(int int_0)
		{
			this.RemoveAt(int_0);
		}

		// Token: 0x0600DE9F RID: 56991 RVA: 0x0054A424 File Offset: 0x00548624
		public lyh f()
		{
			return new lyQ(this);
		}

		// Token: 0x0600DEA0 RID: 56992 RVA: 0x0016345C File Offset: 0x0016165C
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append('[');
			for (int i = 0; i < this.Count; i++)
			{
				if (i > 0)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append(this[i].ToString());
			}
			stringBuilder.Append(']');
			return stringBuilder.ToString();
		}

		// Token: 0x0600DEA1 RID: 56993 RVA: 0x0054A43C File Offset: 0x0054863C
		public override object Clone()
		{
			return new lyN(this);
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600DEA2 RID: 56994 RVA: 0x000FBD30 File Offset: 0x000F9F30
		public override bool IsSynchronized
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600DEA3 RID: 56995 RVA: 0x0054A454 File Offset: 0x00548654
		[MethodImpl(MethodImplOptions.Synchronized)]
		public override int Add(object value)
		{
			return base.Add(value);
		}

		// Token: 0x0600DEA4 RID: 56996 RVA: 0x00069488 File Offset: 0x00067688
		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void AddRange(ICollection c)
		{
			base.AddRange(c);
		}

		// Token: 0x0600DEA5 RID: 56997 RVA: 0x0054A46C File Offset: 0x0054866C
		[MethodImpl(MethodImplOptions.Synchronized)]
		public override int BinarySearch(int index, int count, object value, IComparer comparer)
		{
			return base.BinarySearch(index, count, value, comparer);
		}

		// Token: 0x0600DEA6 RID: 56998 RVA: 0x0054A488 File Offset: 0x00548688
		[MethodImpl(MethodImplOptions.Synchronized)]
		public override int BinarySearch(object value)
		{
			return base.BinarySearch(value);
		}

		// Token: 0x0600DEA7 RID: 56999 RVA: 0x0054A4A0 File Offset: 0x005486A0
		[MethodImpl(MethodImplOptions.Synchronized)]
		public override int BinarySearch(object value, IComparer comparer)
		{
			return base.BinarySearch(value, comparer);
		}

		// Token: 0x0600DEA8 RID: 57000 RVA: 0x00069491 File Offset: 0x00067691
		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void Clear()
		{
			base.Clear();
		}

		// Token: 0x0600DEA9 RID: 57001 RVA: 0x0054A4B8 File Offset: 0x005486B8
		[MethodImpl(MethodImplOptions.Synchronized)]
		public override bool Contains(object item)
		{
			return base.Contains(item);
		}

		// Token: 0x0600DEAA RID: 57002 RVA: 0x00069499 File Offset: 0x00067699
		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void CopyTo(Array array)
		{
			base.CopyTo(array);
		}

		// Token: 0x0600DEAB RID: 57003 RVA: 0x000694A2 File Offset: 0x000676A2
		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void CopyTo(Array array, int arrayIndex)
		{
			base.CopyTo(array, arrayIndex);
		}

		// Token: 0x0600DEAC RID: 57004 RVA: 0x000694AC File Offset: 0x000676AC
		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void CopyTo(int index, Array array, int arrayIndex, int count)
		{
			base.CopyTo(index, array, arrayIndex, count);
		}

		// Token: 0x0600DEAD RID: 57005 RVA: 0x0054A4CC File Offset: 0x005486CC
		[MethodImpl(MethodImplOptions.Synchronized)]
		public override IEnumerator GetEnumerator()
		{
			return base.GetEnumerator();
		}

		// Token: 0x0600DEAE RID: 57006 RVA: 0x0054A4E4 File Offset: 0x005486E4
		[MethodImpl(MethodImplOptions.Synchronized)]
		public override IEnumerator GetEnumerator(int index, int count)
		{
			return base.GetEnumerator(index, count);
		}

		// Token: 0x0600DEAF RID: 57007 RVA: 0x0054A4FC File Offset: 0x005486FC
		[MethodImpl(MethodImplOptions.Synchronized)]
		public override int IndexOf(object value)
		{
			return base.IndexOf(value);
		}

		// Token: 0x0600DEB0 RID: 57008 RVA: 0x0054A514 File Offset: 0x00548714
		[MethodImpl(MethodImplOptions.Synchronized)]
		public override int IndexOf(object value, int startIndex)
		{
			return base.IndexOf(value, startIndex);
		}

		// Token: 0x0600DEB1 RID: 57009 RVA: 0x0054A52C File Offset: 0x0054872C
		[MethodImpl(MethodImplOptions.Synchronized)]
		public override int IndexOf(object value, int startIndex, int count)
		{
			return base.IndexOf(value, startIndex, count);
		}

		// Token: 0x0600DEB2 RID: 57010 RVA: 0x000694B9 File Offset: 0x000676B9
		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void Insert(int index, object value)
		{
			base.Insert(index, value);
		}

		// Token: 0x0600DEB3 RID: 57011 RVA: 0x000694C3 File Offset: 0x000676C3
		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void InsertRange(int index, ICollection c)
		{
			base.InsertRange(index, c);
		}

		// Token: 0x0600DEB4 RID: 57012 RVA: 0x0054A544 File Offset: 0x00548744
		[MethodImpl(MethodImplOptions.Synchronized)]
		public override int LastIndexOf(object value)
		{
			return base.LastIndexOf(value);
		}

		// Token: 0x0600DEB5 RID: 57013 RVA: 0x0054A55C File Offset: 0x0054875C
		[MethodImpl(MethodImplOptions.Synchronized)]
		public override int LastIndexOf(object value, int startIndex)
		{
			return base.LastIndexOf(value, startIndex);
		}

		// Token: 0x0600DEB6 RID: 57014 RVA: 0x0054A574 File Offset: 0x00548774
		[MethodImpl(MethodImplOptions.Synchronized)]
		public override int LastIndexOf(object value, int startIndex, int count)
		{
			return base.LastIndexOf(value, startIndex, count);
		}

		// Token: 0x0600DEB7 RID: 57015 RVA: 0x000694CD File Offset: 0x000676CD
		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void Remove(object obj)
		{
			base.Remove(obj);
		}

		// Token: 0x0600DEB8 RID: 57016 RVA: 0x000694D6 File Offset: 0x000676D6
		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void RemoveAt(int index)
		{
			base.RemoveAt(index);
		}

		// Token: 0x0600DEB9 RID: 57017 RVA: 0x000694DF File Offset: 0x000676DF
		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void RemoveRange(int index, int count)
		{
			base.RemoveRange(index, count);
		}

		// Token: 0x0600DEBA RID: 57018 RVA: 0x000694E9 File Offset: 0x000676E9
		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void Reverse()
		{
			base.Reverse();
		}

		// Token: 0x0600DEBB RID: 57019 RVA: 0x000694F1 File Offset: 0x000676F1
		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void Reverse(int index, int count)
		{
			base.Reverse(index, count);
		}

		// Token: 0x0600DEBC RID: 57020 RVA: 0x000694FB File Offset: 0x000676FB
		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void SetRange(int index, ICollection c)
		{
			base.SetRange(index, c);
		}

		// Token: 0x0600DEBD RID: 57021 RVA: 0x0054A58C File Offset: 0x0054878C
		[MethodImpl(MethodImplOptions.Synchronized)]
		public override ArrayList GetRange(int index, int count)
		{
			return base.GetRange(index, count);
		}

		// Token: 0x0600DEBE RID: 57022 RVA: 0x00069505 File Offset: 0x00067705
		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void Sort()
		{
			base.Sort();
		}

		// Token: 0x0600DEBF RID: 57023 RVA: 0x0006950D File Offset: 0x0006770D
		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void Sort(IComparer comparer)
		{
			base.Sort(comparer);
		}

		// Token: 0x0600DEC0 RID: 57024 RVA: 0x00069516 File Offset: 0x00067716
		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void Sort(int index, int count, IComparer comparer)
		{
			base.Sort(index, count, comparer);
		}

		// Token: 0x0600DEC1 RID: 57025 RVA: 0x0054A5A4 File Offset: 0x005487A4
		[MethodImpl(MethodImplOptions.Synchronized)]
		public override object[] ToArray()
		{
			return base.ToArray();
		}

		// Token: 0x0600DEC2 RID: 57026 RVA: 0x0054A5BC File Offset: 0x005487BC
		[MethodImpl(MethodImplOptions.Synchronized)]
		public override Array ToArray(Type type)
		{
			return base.ToArray(type);
		}

		// Token: 0x0600DEC3 RID: 57027 RVA: 0x00069521 File Offset: 0x00067721
		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void TrimToSize()
		{
			base.TrimToSize();
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600DEC4 RID: 57028 RVA: 0x0054A5D4 File Offset: 0x005487D4
		// (set) Token: 0x0600DEC5 RID: 57029 RVA: 0x00069529 File Offset: 0x00067729
		public override int Capacity
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			get
			{
				return base.Capacity;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				base.Capacity = value;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600DEC6 RID: 57030 RVA: 0x0054A5EC File Offset: 0x005487EC
		public override int Count
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			get
			{
				return base.Count;
			}
		}

		// Token: 0x170000A4 RID: 164
		public override object this[int index]
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			get
			{
				return base[index];
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				base[index] = value;
			}
		}
	}
}
