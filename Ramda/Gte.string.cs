﻿// <autogenerated>
//   This file was generated by T4 code generator Gte.string.tt.
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
		/// Returns `true` if the first argument is greater than or equal to the second;`false` otherwise.
		/// <para />
		/// sig: Ord a => a -> a -> Boolean
		/// </summary>
		/// <param name="a">first</param>
		/// <param name="b">second</param>
		/// <returns>Boolean</returns>
		/// <see cref="R.Lte"/>
		public static dynamic Gte(string a, string b) {
			return Currying.Gte(a, b);
		}

		/// <summary>
		/// Returns `true` if the first argument is greater than or equal to the second;`false` otherwise.
		/// <para />
		/// sig: Ord a => a -> a -> Boolean
		/// </summary>
		/// <param name="a">first</param>
		/// <param name="b">second</param>
		/// <returns>Boolean</returns>
		/// <see cref="R.Lte"/>
		public static dynamic Gte(RamdaPlaceholder a, string b) {
			return Currying.Gte(a, b);
		}

		/// <summary>
		/// Returns `true` if the first argument is greater than or equal to the second;`false` otherwise.
		/// <para />
		/// sig: Ord a => a -> a -> Boolean
		/// </summary>
		/// <param name="a">first</param>
		/// <param name="b">second</param>
		/// <returns>Boolean</returns>
		/// <see cref="R.Lte"/>
		public static dynamic Gte(string a, RamdaPlaceholder b = null) {
			return Currying.Gte(a, b);
		}
	}
}