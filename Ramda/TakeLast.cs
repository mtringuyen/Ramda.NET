﻿// <autogenerated>
//   This file was generated by T4 code generator TakeLast.tt.
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
		/// Returns a new list containing the last `n` elements of the given list.If `n > list.length`, returns a list of `list.length` elements.
		/// <para />
		/// sig: Number -> [a] -> [a]
		/// </summary>
		/// <param name="n">The number of elements to return.</param>
		/// <param name="xs">The collection to consider.</param>
		/// <returns>Array</returns>
		/// <see cref="R.DropLast"/>
		public static dynamic TakeLast<TSource>(int n, IList<TSource> list) {
			return Currying.TakeLast(n, list);
		}

		/// <summary>
		/// Returns a new list containing the last `n` elements of the given list.If `n > list.length`, returns a list of `list.length` elements.
		/// <para />
		/// sig: Number -> [a] -> [a]
		/// </summary>
		/// <param name="n">The number of elements to return.</param>
		/// <param name="xs">The collection to consider.</param>
		/// <returns>Array</returns>
		/// <see cref="R.DropLast"/>
		public static dynamic TakeLast<TSource>(RamdaPlaceholder n, IList<TSource> list) {
			return Currying.TakeLast(n, list);
		}

		/// <summary>
		/// Returns a new list containing the last `n` elements of the given list.If `n > list.length`, returns a list of `list.length` elements.
		/// <para />
		/// sig: Number -> [a] -> [a]
		/// </summary>
		/// <param name="n">The number of elements to return.</param>
		/// <param name="xs">The collection to consider.</param>
		/// <returns>Array</returns>
		/// <see cref="R.DropLast"/>
		public static dynamic TakeLast(int n, RamdaPlaceholder list = null) {
			return Currying.TakeLast(n, list);
		}

		/// <summary>
		/// Returns a new list containing the last `n` elements of the given list.If `n > list.length`, returns a list of `list.length` elements.
		/// <para />
		/// sig: Number -> [a] -> [a]
		/// </summary>
		/// <param name="n">The number of elements to return.</param>
		/// <param name="xs">The collection to consider.</param>
		/// <returns>Array</returns>
		/// <see cref="R.DropLast"/>
		public static dynamic TakeLast(RamdaPlaceholder n = null, RamdaPlaceholder list = null) {
			return Currying.TakeLast(n, list);
		}
	}
}