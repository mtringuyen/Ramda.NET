﻿// <autogenerated>
//   This file was generated by T4 code generator GroupBy.list.tt.
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
		/// Splits a list into sub-lists stored in an object, based on the result ofcalling a String-returning function on each element, and grouping theresults according to values returned.Dispatches to the `groupBy` method of the second argument, if present.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: (a -> String) -> [a] -> {String: [a]}
		/// </summary>
		/// <param name="fn">Function :: a -> String</param>
		/// <param name="list">The array to group</param>
		/// <returns>An object with the output of `fn` for keys, mapped to arrays of elements that produced that key when passed to `fn`.</returns>
		/// <see cref="R.Transduce"/>
		public static dynamic GroupBy<TSource>(Func<TSource, string> fn, IList<TSource> list) {
			return Currying.GroupBy(Delegate(fn), list);
		}

		/// <summary>
		/// Splits a list into sub-lists stored in an object, based on the result ofcalling a String-returning function on each element, and grouping theresults according to values returned.Dispatches to the `groupBy` method of the second argument, if present.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: (a -> String) -> [a] -> {String: [a]}
		/// </summary>
		/// <param name="fn">Function :: a -> String</param>
		/// <param name="list">The array to group</param>
		/// <returns>An object with the output of `fn` for keys, mapped to arrays of elements that produced that key when passed to `fn`.</returns>
		/// <see cref="R.Transduce"/>
		public static dynamic GroupBy<TSource>(RamdaPlaceholder fn, IList<TSource> list) {
			return Currying.GroupBy(fn, list);
		}

		/// <summary>
		/// Splits a list into sub-lists stored in an object, based on the result ofcalling a String-returning function on each element, and grouping theresults according to values returned.Dispatches to the `groupBy` method of the second argument, if present.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: (a -> String) -> [a] -> {String: [a]}
		/// </summary>
		/// <param name="fn">Function :: a -> String</param>
		/// <param name="list">The array to group</param>
		/// <returns>An object with the output of `fn` for keys, mapped to arrays of elements that produced that key when passed to `fn`.</returns>
		/// <see cref="R.Transduce"/>
		public static dynamic GroupBy<TSource>(Func<TSource, string> fn, RamdaPlaceholder list = null) {
			return Currying.GroupBy(Delegate(fn), list);
		}

		/// <summary>
		/// Splits a list into sub-lists stored in an object, based on the result ofcalling a String-returning function on each element, and grouping theresults according to values returned.Dispatches to the `groupBy` method of the second argument, if present.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: (a -> String) -> [a] -> {String: [a]}
		/// </summary>
		/// <param name="fn">Function :: a -> String</param>
		/// <param name="list">The array to group</param>
		/// <returns>An object with the output of `fn` for keys, mapped to arrays of elements that produced that key when passed to `fn`.</returns>
		/// <see cref="R.Transduce"/>
		public static dynamic GroupBy(dynamic fn, RamdaPlaceholder list = null) {
			return Currying.GroupBy(Delegate(fn), list);
		}

		/// <summary>
		/// Splits a list into sub-lists stored in an object, based on the result ofcalling a String-returning function on each element, and grouping theresults according to values returned.Dispatches to the `groupBy` method of the second argument, if present.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: (a -> String) -> [a] -> {String: [a]}
		/// </summary>
		/// <param name="fn">Function :: a -> String</param>
		/// <param name="list">The array to group</param>
		/// <returns>An object with the output of `fn` for keys, mapped to arrays of elements that produced that key when passed to `fn`.</returns>
		/// <see cref="R.Transduce"/>
		public static dynamic GroupBy<TSource>(dynamic fn, IList<TSource> list) {
			return Currying.GroupBy(Delegate(fn), list);
		}

		/// <summary>
		/// Splits a list into sub-lists stored in an object, based on the result ofcalling a String-returning function on each element, and grouping theresults according to values returned.Dispatches to the `groupBy` method of the second argument, if present.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: (a -> String) -> [a] -> {String: [a]}
		/// </summary>
		/// <param name="fn">Function :: a -> String</param>
		/// <param name="list">The array to group</param>
		/// <returns>An object with the output of `fn` for keys, mapped to arrays of elements that produced that key when passed to `fn`.</returns>
		/// <see cref="R.Transduce"/>
		public static dynamic GroupBy(RamdaPlaceholder fn = null, RamdaPlaceholder list = null) {
			return Currying.GroupBy(fn, list);
		}
	}
}