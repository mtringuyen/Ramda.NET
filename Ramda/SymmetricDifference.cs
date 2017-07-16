﻿// <autogenerated>
//   This file was generated by T4 code generator SymmetricDifference.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Dynamic;
using System.Collections;
using System.Threading.Tasks;
using static Ramda.NET.Currying;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ramda.NET
{
	public static partial class R
	{	
		/// <summary>
		/// Finds the set (i.e. no duplicates) of all elements contained in the first orsecond list, but not both.
		/// <para />
		/// sig: [*] -> [*] -> [*]
		/// </summary>
		/// <param name="list1">The first list.</param>
		/// <param name="list2">The second list.</param>
		/// <returns>The elements in `list1` or `list2`, but not both.</returns>
		/// <see cref="R.SymmetricDifferenceWith"/>
		/// <see cref="R.Difference"/>
		/// <see cref="R.DifferenceWith"/>
		public static dynamic SymmetricDifference<TSource1, TSource2>(IList<TSource1> list1, IList<TSource2> list2) {
			return Currying.SymmetricDifference(list1, list2);
		}

		/// <summary>
		/// Finds the set (i.e. no duplicates) of all elements contained in the first orsecond list, but not both.
		/// <para />
		/// sig: [*] -> [*] -> [*]
		/// </summary>
		/// <param name="list1">The first list.</param>
		/// <param name="list2">The second list.</param>
		/// <returns>The elements in `list1` or `list2`, but not both.</returns>
		/// <see cref="R.SymmetricDifferenceWith"/>
		/// <see cref="R.Difference"/>
		/// <see cref="R.DifferenceWith"/>
		public static dynamic SymmetricDifference<TSource2>(RamdaPlaceholder list1, IList<TSource2> list2) {
			return Currying.SymmetricDifference(list1, list2);
		}

		/// <summary>
		/// Finds the set (i.e. no duplicates) of all elements contained in the first orsecond list, but not both.
		/// <para />
		/// sig: [*] -> [*] -> [*]
		/// </summary>
		/// <param name="list1">The first list.</param>
		/// <param name="list2">The second list.</param>
		/// <returns>The elements in `list1` or `list2`, but not both.</returns>
		/// <see cref="R.SymmetricDifferenceWith"/>
		/// <see cref="R.Difference"/>
		/// <see cref="R.DifferenceWith"/>
		public static dynamic SymmetricDifference<TSource1>(IList<TSource1> list1, RamdaPlaceholder list2 = null) {
			return Currying.SymmetricDifference(list1, list2);
		}

		/// <summary>
		/// Finds the set (i.e. no duplicates) of all elements contained in the first orsecond list, but not both.
		/// <para />
		/// sig: [*] -> [*] -> [*]
		/// </summary>
		/// <param name="list1">The first list.</param>
		/// <param name="list2">The second list.</param>
		/// <returns>The elements in `list1` or `list2`, but not both.</returns>
		/// <see cref="R.SymmetricDifferenceWith"/>
		/// <see cref="R.Difference"/>
		/// <see cref="R.DifferenceWith"/>
		public static dynamic SymmetricDifference(RamdaPlaceholder list1 = null, RamdaPlaceholder list2 = null) {
			return Currying.SymmetricDifference(list1, list2);
		}
	}
}