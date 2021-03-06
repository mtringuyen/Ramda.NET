﻿// <autogenerated>
//   This file was generated by T4 code generator Length.generic.list.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
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
		/// Returns the number of elements in the array by returning `list.length`.
		/// <para />
		/// sig: [a] -> Number
		/// </summary>
		/// <param name="list">The array to inspect.</param>
		/// <returns>The length of the array.</returns>
		public static dynamic Length<TSource>(IList<TSource> list) {
			return Currying.Length(list);
		}

		/// <summary>
		/// Returns the number of elements in the array by returning `list.length`.
		/// <para />
		/// sig: [a] -> Number
		/// </summary>
		/// <param name="list">The array to inspect.</param>
		/// <returns>The length of the array.</returns>
		public static dynamic Length(RamdaPlaceholder list = null) {
			return Currying.Length(list);
		}
	}
}