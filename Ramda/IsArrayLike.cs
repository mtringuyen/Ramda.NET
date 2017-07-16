﻿// <autogenerated>
//   This file was generated by T4 code generator IsArrayLike.tt.
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
		/// Tests whether or not an object is similar to an array.
		/// <para />
		/// sig: * -> Boolean
		/// </summary>
		/// <param name="x">The object to test.</param>
		/// <returns>`true` if `x` has a numeric length property and extreme indices defined; `false` otherwise.</returns>
		public static dynamic IsArrayLike<TTarget>(TTarget x) {
			return Currying.IsArrayLike(x);
		}

		/// <summary>
		/// Tests whether or not an object is similar to an array.
		/// <para />
		/// sig: * -> Boolean
		/// </summary>
		/// <param name="x">The object to test.</param>
		/// <returns>`true` if `x` has a numeric length property and extreme indices defined; `false` otherwise.</returns>
		public static dynamic IsArrayLike(RamdaPlaceholder x = null) {
			return Currying.IsArrayLike(x);
		}
	}
}