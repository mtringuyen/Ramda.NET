﻿// <autogenerated>
//   This file was generated by T4 code generator Append.tt.
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
		/// Returns a new list containing the contents of the given list, followed bythe given element.
		/// <para />
		/// sig: a -> [a] -> [a]
		/// </summary>
		/// <param name="el">The element to add to the end of the new list.</param>
		/// <param name="list">The list of elements to add a new item to.       list.</param>
		/// <returns>A new list containing the elements of the old list followed by `el`.</returns>
		/// <see cref="R.Prepend"/>
		public static dynamic Append<TSource>(TSource el, IList<TSource> list) {
			return Currying.Append(el, list);
		}

		/// <summary>
		/// Returns a new list containing the contents of the given list, followed bythe given element.
		/// <para />
		/// sig: a -> [a] -> [a]
		/// </summary>
		/// <param name="el">The element to add to the end of the new list.</param>
		/// <param name="list">The list of elements to add a new item to.       list.</param>
		/// <returns>A new list containing the elements of the old list followed by `el`.</returns>
		/// <see cref="R.Prepend"/>
		public static dynamic Append<TSource>(RamdaPlaceholder el, IList<TSource> list) {
			return Currying.Append(el, list);
		}

		/// <summary>
		/// Returns a new list containing the contents of the given list, followed bythe given element.
		/// <para />
		/// sig: a -> [a] -> [a]
		/// </summary>
		/// <param name="el">The element to add to the end of the new list.</param>
		/// <param name="list">The list of elements to add a new item to.       list.</param>
		/// <returns>A new list containing the elements of the old list followed by `el`.</returns>
		/// <see cref="R.Prepend"/>
		public static dynamic Append<TSource>(TSource el, RamdaPlaceholder list = null) {
			return Currying.Append(el, list);
		}

		/// <summary>
		/// Returns a new list containing the contents of the given list, followed bythe given element.
		/// <para />
		/// sig: a -> [a] -> [a]
		/// </summary>
		/// <param name="el">The element to add to the end of the new list.</param>
		/// <param name="list">The list of elements to add a new item to.       list.</param>
		/// <returns>A new list containing the elements of the old list followed by `el`.</returns>
		/// <see cref="R.Prepend"/>
		public static dynamic Append(RamdaPlaceholder el = null, RamdaPlaceholder list = null) {
			return Currying.Append(el, list);
		}
	}
}