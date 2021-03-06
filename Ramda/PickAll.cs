﻿// <autogenerated>
//   This file was generated by T4 code generator PickAll.tt.
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
		/// Similar to `pick` except that this one includes a `key: undefined` pair forproperties that don't exist.
		/// <para />
		/// sig: [k] -> {k: v} -> {k: v}
		/// </summary>
		/// <param name="names">an array of String property names to copy onto a new object</param>
		/// <param name="obj">The object to copy from</param>
		/// <returns>A new object with only properties from `names` on it.</returns>
		/// <see cref="R.Pick"/>
		public static dynamic PickAll<TTarget>(IList names, TTarget obj) {
			return Currying.PickAll(names, obj);
		}

		/// <summary>
		/// Similar to `pick` except that this one includes a `key: undefined` pair forproperties that don't exist.
		/// <para />
		/// sig: [k] -> {k: v} -> {k: v}
		/// </summary>
		/// <param name="names">an array of String property names to copy onto a new object</param>
		/// <param name="obj">The object to copy from</param>
		/// <returns>A new object with only properties from `names` on it.</returns>
		/// <see cref="R.Pick"/>
		public static dynamic PickAll<TTarget>(RamdaPlaceholder names, TTarget obj) {
			return Currying.PickAll(names, obj);
		}

		/// <summary>
		/// Similar to `pick` except that this one includes a `key: undefined` pair forproperties that don't exist.
		/// <para />
		/// sig: [k] -> {k: v} -> {k: v}
		/// </summary>
		/// <param name="names">an array of String property names to copy onto a new object</param>
		/// <param name="obj">The object to copy from</param>
		/// <returns>A new object with only properties from `names` on it.</returns>
		/// <see cref="R.Pick"/>
		public static dynamic PickAll(IList names, RamdaPlaceholder obj = null) {
			return Currying.PickAll(names, obj);
		}

		/// <summary>
		/// Similar to `pick` except that this one includes a `key: undefined` pair forproperties that don't exist.
		/// <para />
		/// sig: [k] -> {k: v} -> {k: v}
		/// </summary>
		/// <param name="names">an array of String property names to copy onto a new object</param>
		/// <param name="obj">The object to copy from</param>
		/// <returns>A new object with only properties from `names` on it.</returns>
		/// <see cref="R.Pick"/>
		public static dynamic PickAll(RamdaPlaceholder names = null, RamdaPlaceholder obj = null) {
			return Currying.PickAll(names, obj);
		}
	}
}