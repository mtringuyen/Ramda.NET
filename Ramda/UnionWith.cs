﻿// <autogenerated>
//   This file was generated by T4 code generator UnionWith.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ramda.NET
{
	public static partial class R
	{	
		public static dynamic UnionWith<TSource1, TSource2>(Func<TSource1, TSource2, bool> pred, IList<TSource1> list1, IList<TSource2> list2) {
			return Currying.UnionWith(pred, list1, list2);
		}

		public static dynamic UnionWith<TSource1, TSource2>(RamdaPlaceholder pred, IList<TSource1> list1, IList<TSource2> list2) {
			return Currying.UnionWith(pred, list1, list2);
		}

		public static dynamic UnionWith<TSource1, TSource2>(Func<TSource1, TSource2, bool> pred, RamdaPlaceholder list1, IList<TSource2> list2) {
			return Currying.UnionWith(pred, list1, list2);
		}

		public static dynamic UnionWith<TSource1, TSource2>(Func<TSource1, TSource2, bool> pred, IList<TSource1> list1, RamdaPlaceholder list2 = null) {
			return Currying.UnionWith(pred, list1, list2);
		}

		public static dynamic UnionWith<TSource1, TSource2>(Func<TSource1, TSource2, bool> pred, RamdaPlaceholder list1 = null, RamdaPlaceholder list2 = null) {
			return Currying.UnionWith(pred, list1, list2);
		}

		public static dynamic UnionWith<TSource2>(dynamic pred, RamdaPlaceholder list1, IList<TSource2> list2) {
			return Currying.UnionWith(pred, list1, list2);
		}

		public static dynamic UnionWith<TSource1>(dynamic pred, IList<TSource1> list1, RamdaPlaceholder list2 = null) {
			return Currying.UnionWith(pred, list1, list2);
		}

		public static dynamic UnionWith(dynamic pred, RamdaPlaceholder list1 = null, RamdaPlaceholder list2 = null) {
			return Currying.UnionWith(pred, list1, list2);
		}

		public static dynamic UnionWith<TSource1, TSource2>(dynamic pred, IList<TSource1> list1, IList<TSource2> list2) {
			return Currying.UnionWith(pred, list1, list2);
		}

		public static dynamic UnionWith(RamdaPlaceholder pred = null, RamdaPlaceholder list1 = null, RamdaPlaceholder list2 = null) {
			return Currying.UnionWith(pred, list1, list2);
		}
	}
}