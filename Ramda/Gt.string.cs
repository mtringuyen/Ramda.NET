﻿// <autogenerated>
//   This file was generated by T4 code generator Gt.string.tt.
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
		/// Returns `true` if the first argument is greater than the second; `false`otherwise.
		/// <para />
		/// sig: Ord a => a -> a -> Boolean
		/// </summary>
		/// <param name="a">first</param>
		/// <param name="b">second</param>
		/// <returns>Boolean</returns>
		/// <see cref="R.Lt"/>
		public static dynamic Gt(string a, string b) {
			return Currying.Gt(a, b);
		}

		/// <summary>
		/// Returns `true` if the first argument is greater than the second; `false`otherwise.
		/// <para />
		/// sig: Ord a => a -> a -> Boolean
		/// </summary>
		/// <param name="a">first</param>
		/// <param name="b">second</param>
		/// <returns>Boolean</returns>
		/// <see cref="R.Lt"/>
		public static dynamic Gt(RamdaPlaceholder a, string b) {
			return Currying.Gt(a, b);
		}

		/// <summary>
		/// Returns `true` if the first argument is greater than the second; `false`otherwise.
		/// <para />
		/// sig: Ord a => a -> a -> Boolean
		/// </summary>
		/// <param name="a">first</param>
		/// <param name="b">second</param>
		/// <returns>Boolean</returns>
		/// <see cref="R.Lt"/>
		public static dynamic Gt(string a, RamdaPlaceholder b = null) {
			return Currying.Gt(a, b);
		}
	}
}