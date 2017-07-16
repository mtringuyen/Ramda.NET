﻿// <autogenerated>
//   This file was generated by T4 code generator Update.tt.
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
		/// Returns a new copy of the array with the element at the provided indexreplaced with the given value.
		/// <para />
		/// sig: Number -> a -> [a] -> [a]
		/// </summary>
		/// <param name="idx">The index to update.</param>
		/// <param name="x">The value to exist at the given index of the returned array.</param>
		/// <param name="list">The source array-like object to be updated.</param>
		/// <returns>A copy of `list` with the value at index `idx` replaced with `x`.</returns>
		/// <see cref="R.Adjust"/>
		public static dynamic Update<TSource>(int idx, TSource x, IList<TSource> list) {
			return Currying.Update(idx, x, list);
		}

		/// <summary>
		/// Returns a new copy of the array with the element at the provided indexreplaced with the given value.
		/// <para />
		/// sig: Number -> a -> [a] -> [a]
		/// </summary>
		/// <param name="idx">The index to update.</param>
		/// <param name="x">The value to exist at the given index of the returned array.</param>
		/// <param name="list">The source array-like object to be updated.</param>
		/// <returns>A copy of `list` with the value at index `idx` replaced with `x`.</returns>
		/// <see cref="R.Adjust"/>
		public static dynamic Update<TSource>(RamdaPlaceholder idx, TSource x, IList<TSource> list) {
			return Currying.Update(idx, x, list);
		}

		/// <summary>
		/// Returns a new copy of the array with the element at the provided indexreplaced with the given value.
		/// <para />
		/// sig: Number -> a -> [a] -> [a]
		/// </summary>
		/// <param name="idx">The index to update.</param>
		/// <param name="x">The value to exist at the given index of the returned array.</param>
		/// <param name="list">The source array-like object to be updated.</param>
		/// <returns>A copy of `list` with the value at index `idx` replaced with `x`.</returns>
		/// <see cref="R.Adjust"/>
		public static dynamic Update<TSource>(int idx, RamdaPlaceholder x, IList<TSource> list) {
			return Currying.Update(idx, x, list);
		}

		/// <summary>
		/// Returns a new copy of the array with the element at the provided indexreplaced with the given value.
		/// <para />
		/// sig: Number -> a -> [a] -> [a]
		/// </summary>
		/// <param name="idx">The index to update.</param>
		/// <param name="x">The value to exist at the given index of the returned array.</param>
		/// <param name="list">The source array-like object to be updated.</param>
		/// <returns>A copy of `list` with the value at index `idx` replaced with `x`.</returns>
		/// <see cref="R.Adjust"/>
		public static dynamic Update<TSource>(int idx, TSource x, RamdaPlaceholder list = null) {
			return Currying.Update(idx, x, list);
		}

		/// <summary>
		/// Returns a new copy of the array with the element at the provided indexreplaced with the given value.
		/// <para />
		/// sig: Number -> a -> [a] -> [a]
		/// </summary>
		/// <param name="idx">The index to update.</param>
		/// <param name="x">The value to exist at the given index of the returned array.</param>
		/// <param name="list">The source array-like object to be updated.</param>
		/// <returns>A copy of `list` with the value at index `idx` replaced with `x`.</returns>
		/// <see cref="R.Adjust"/>
		public static dynamic Update(int idx, RamdaPlaceholder x = null, RamdaPlaceholder list = null) {
			return Currying.Update(idx, x, list);
		}

		/// <summary>
		/// Returns a new copy of the array with the element at the provided indexreplaced with the given value.
		/// <para />
		/// sig: Number -> a -> [a] -> [a]
		/// </summary>
		/// <param name="idx">The index to update.</param>
		/// <param name="x">The value to exist at the given index of the returned array.</param>
		/// <param name="list">The source array-like object to be updated.</param>
		/// <returns>A copy of `list` with the value at index `idx` replaced with `x`.</returns>
		/// <see cref="R.Adjust"/>
		public static dynamic Update(RamdaPlaceholder idx = null, RamdaPlaceholder x = null, RamdaPlaceholder list = null) {
			return Currying.Update(idx, x, list);
		}
	}
}