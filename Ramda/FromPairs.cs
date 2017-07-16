﻿// <autogenerated>
//   This file was generated by T4 code generator FromPairs.tt.
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
		/// Creates a new object from a list key-value pairs. If a key appears inmultiple pairs, the rightmost pair is included in the object.
		/// <para />
		/// sig: [[k,v]] -> {k: v}
		/// </summary>
		/// <param name="pairs">An array of two-element arrays that will be the keys and values of the output object.</param>
		/// <returns>The object made by pairing up `keys` and `values`.</returns>
		/// <see cref="R.ToPairs"/>
		/// <see cref="R.Pair"/>
		public static dynamic FromPairs(object[][] pairs) {
			return Currying.FromPairs(pairs);
		}

		/// <summary>
		/// Creates a new object from a list key-value pairs. If a key appears inmultiple pairs, the rightmost pair is included in the object.
		/// <para />
		/// sig: [[k,v]] -> {k: v}
		/// </summary>
		/// <param name="pairs">An array of two-element arrays that will be the keys and values of the output object.</param>
		/// <returns>The object made by pairing up `keys` and `values`.</returns>
		/// <see cref="R.ToPairs"/>
		/// <see cref="R.Pair"/>
		public static dynamic FromPairs(RamdaPlaceholder pairs = null) {
			return Currying.FromPairs(pairs);
		}
	}
}