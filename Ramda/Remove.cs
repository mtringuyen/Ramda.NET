﻿// <autogenerated>
//   This file was generated by T4 code generator Remove.tt.
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
		/// Removes the sub-list of `list` starting at index `start` and containing`count` elements. _Note that this is not destructive_: it returns a copy ofthe list with the changes.<small>No lists have been harmed in the application of this function.</small>
		/// <para />
		/// sig: Number -> Number -> [a] -> [a]
		/// </summary>
		/// <param name="start">The position to start removing elements</param>
		/// <param name="count">The number of elements to remove</param>
		/// <param name="list">The list to remove from</param>
		/// <returns>A new Array with `count` elements from `start` removed.</returns>
		public static dynamic Remove<TSource>(int start, int count, IList<TSource> list) {
			return Currying.Remove(start, count, list);
		}

		/// <summary>
		/// Removes the sub-list of `list` starting at index `start` and containing`count` elements. _Note that this is not destructive_: it returns a copy ofthe list with the changes.<small>No lists have been harmed in the application of this function.</small>
		/// <para />
		/// sig: Number -> Number -> [a] -> [a]
		/// </summary>
		/// <param name="start">The position to start removing elements</param>
		/// <param name="count">The number of elements to remove</param>
		/// <param name="list">The list to remove from</param>
		/// <returns>A new Array with `count` elements from `start` removed.</returns>
		public static dynamic Remove<TSource>(RamdaPlaceholder start, int count, IList<TSource> list) {
			return Currying.Remove(start, count, list);
		}

		/// <summary>
		/// Removes the sub-list of `list` starting at index `start` and containing`count` elements. _Note that this is not destructive_: it returns a copy ofthe list with the changes.<small>No lists have been harmed in the application of this function.</small>
		/// <para />
		/// sig: Number -> Number -> [a] -> [a]
		/// </summary>
		/// <param name="start">The position to start removing elements</param>
		/// <param name="count">The number of elements to remove</param>
		/// <param name="list">The list to remove from</param>
		/// <returns>A new Array with `count` elements from `start` removed.</returns>
		public static dynamic Remove<TSource>(int start, RamdaPlaceholder count, IList<TSource> list) {
			return Currying.Remove(start, count, list);
		}

		/// <summary>
		/// Removes the sub-list of `list` starting at index `start` and containing`count` elements. _Note that this is not destructive_: it returns a copy ofthe list with the changes.<small>No lists have been harmed in the application of this function.</small>
		/// <para />
		/// sig: Number -> Number -> [a] -> [a]
		/// </summary>
		/// <param name="start">The position to start removing elements</param>
		/// <param name="count">The number of elements to remove</param>
		/// <param name="list">The list to remove from</param>
		/// <returns>A new Array with `count` elements from `start` removed.</returns>
		public static dynamic Remove(int start, int count, RamdaPlaceholder list = null) {
			return Currying.Remove(start, count, list);
		}

		/// <summary>
		/// Removes the sub-list of `list` starting at index `start` and containing`count` elements. _Note that this is not destructive_: it returns a copy ofthe list with the changes.<small>No lists have been harmed in the application of this function.</small>
		/// <para />
		/// sig: Number -> Number -> [a] -> [a]
		/// </summary>
		/// <param name="start">The position to start removing elements</param>
		/// <param name="count">The number of elements to remove</param>
		/// <param name="list">The list to remove from</param>
		/// <returns>A new Array with `count` elements from `start` removed.</returns>
		public static dynamic Remove(int start, RamdaPlaceholder count = null, RamdaPlaceholder list = null) {
			return Currying.Remove(start, count, list);
		}

		/// <summary>
		/// Removes the sub-list of `list` starting at index `start` and containing`count` elements. _Note that this is not destructive_: it returns a copy ofthe list with the changes.<small>No lists have been harmed in the application of this function.</small>
		/// <para />
		/// sig: Number -> Number -> [a] -> [a]
		/// </summary>
		/// <param name="start">The position to start removing elements</param>
		/// <param name="count">The number of elements to remove</param>
		/// <param name="list">The list to remove from</param>
		/// <returns>A new Array with `count` elements from `start` removed.</returns>
		public static dynamic Remove(RamdaPlaceholder start = null, RamdaPlaceholder count = null, RamdaPlaceholder list = null) {
			return Currying.Remove(start, count, list);
		}
	}
}