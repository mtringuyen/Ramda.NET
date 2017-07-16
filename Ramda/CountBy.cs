﻿// <autogenerated>
//   This file was generated by T4 code generator CountBy.tt.
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
		/// Counts the elements of a list according to how many match each value of akey generated by the supplied function. Returns an object mapping the keysproduced by `fn` to the number of occurrences in the list. Note that allkeys are coerced to strings because of how JavaScript objects work.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: (a -> String) -> [a] -> {*}
		/// </summary>
		/// <param name="fn">The function used to map values to keys.</param>
		/// <param name="list">The list to count elements from.</param>
		/// <returns>An object mapping keys to number of occurrences in the list.</returns>
		public static dynamic CountBy<TSource>(Func<TSource, string> fn, IList<TSource> list) {
			return Currying.CountBy(Delegate(fn), list);
		}

		/// <summary>
		/// Counts the elements of a list according to how many match each value of akey generated by the supplied function. Returns an object mapping the keysproduced by `fn` to the number of occurrences in the list. Note that allkeys are coerced to strings because of how JavaScript objects work.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: (a -> String) -> [a] -> {*}
		/// </summary>
		/// <param name="fn">The function used to map values to keys.</param>
		/// <param name="list">The list to count elements from.</param>
		/// <returns>An object mapping keys to number of occurrences in the list.</returns>
		public static dynamic CountBy<TSource>(RamdaPlaceholder fn, IList<TSource> list) {
			return Currying.CountBy(fn, list);
		}

		/// <summary>
		/// Counts the elements of a list according to how many match each value of akey generated by the supplied function. Returns an object mapping the keysproduced by `fn` to the number of occurrences in the list. Note that allkeys are coerced to strings because of how JavaScript objects work.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: (a -> String) -> [a] -> {*}
		/// </summary>
		/// <param name="fn">The function used to map values to keys.</param>
		/// <param name="list">The list to count elements from.</param>
		/// <returns>An object mapping keys to number of occurrences in the list.</returns>
		public static dynamic CountBy<TSource>(Func<TSource, string> fn, RamdaPlaceholder list = null) {
			return Currying.CountBy(Delegate(fn), list);
		}

		/// <summary>
		/// Counts the elements of a list according to how many match each value of akey generated by the supplied function. Returns an object mapping the keysproduced by `fn` to the number of occurrences in the list. Note that allkeys are coerced to strings because of how JavaScript objects work.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: (a -> String) -> [a] -> {*}
		/// </summary>
		/// <param name="fn">The function used to map values to keys.</param>
		/// <param name="list">The list to count elements from.</param>
		/// <returns>An object mapping keys to number of occurrences in the list.</returns>
		public static dynamic CountBy(dynamic fn, RamdaPlaceholder list = null) {
			return Currying.CountBy(Delegate(fn), list);
		}

		/// <summary>
		/// Counts the elements of a list according to how many match each value of akey generated by the supplied function. Returns an object mapping the keysproduced by `fn` to the number of occurrences in the list. Note that allkeys are coerced to strings because of how JavaScript objects work.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: (a -> String) -> [a] -> {*}
		/// </summary>
		/// <param name="fn">The function used to map values to keys.</param>
		/// <param name="list">The list to count elements from.</param>
		/// <returns>An object mapping keys to number of occurrences in the list.</returns>
		public static dynamic CountBy<TSource>(dynamic fn, IList<TSource> list) {
			return Currying.CountBy(Delegate(fn), list);
		}

		/// <summary>
		/// Counts the elements of a list according to how many match each value of akey generated by the supplied function. Returns an object mapping the keysproduced by `fn` to the number of occurrences in the list. Note that allkeys are coerced to strings because of how JavaScript objects work.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: (a -> String) -> [a] -> {*}
		/// </summary>
		/// <param name="fn">The function used to map values to keys.</param>
		/// <param name="list">The list to count elements from.</param>
		/// <returns>An object mapping keys to number of occurrences in the list.</returns>
		public static dynamic CountBy(RamdaPlaceholder fn = null, RamdaPlaceholder list = null) {
			return Currying.CountBy(fn, list);
		}
	}
}