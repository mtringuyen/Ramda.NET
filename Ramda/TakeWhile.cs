﻿// <autogenerated>
//   This file was generated by T4 code generator TakeWhile.tt.
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
		/// Returns a new list containing the first `n` elements of a given list,passing each value to the supplied predicate function, and terminating whenthe predicate function returns `false`. Excludes the element that caused thepredicate function to fail. The predicate function is passed one argument:*(value)*.Dispatches to the `takeWhile` method of the second argument, if present.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: (a -> Boolean) -> [a] -> [a]
		/// </summary>
		/// <param name="fn">The function called per iteration.</param>
		/// <param name="list">The collection to iterate over.</param>
		/// <returns>A new array.</returns>
		/// <see cref="R.DropWhile"/>
		/// <see cref="R.Transduce"/>
		/// <see cref="R.AddIndex"/>
		public static dynamic TakeWhile<TSource>(Func<TSource, bool> fn, IList<TSource> list) {
			return Currying.TakeWhile(fn, list);
		}

		/// <summary>
		/// Returns a new list containing the first `n` elements of a given list,passing each value to the supplied predicate function, and terminating whenthe predicate function returns `false`. Excludes the element that caused thepredicate function to fail. The predicate function is passed one argument:*(value)*.Dispatches to the `takeWhile` method of the second argument, if present.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: (a -> Boolean) -> [a] -> [a]
		/// </summary>
		/// <param name="fn">The function called per iteration.</param>
		/// <param name="list">The collection to iterate over.</param>
		/// <returns>A new array.</returns>
		/// <see cref="R.DropWhile"/>
		/// <see cref="R.Transduce"/>
		/// <see cref="R.AddIndex"/>
		public static dynamic TakeWhile<TSource>(RamdaPlaceholder fn, IList<TSource> list) {
			return Currying.TakeWhile(fn, list);
		}

		/// <summary>
		/// Returns a new list containing the first `n` elements of a given list,passing each value to the supplied predicate function, and terminating whenthe predicate function returns `false`. Excludes the element that caused thepredicate function to fail. The predicate function is passed one argument:*(value)*.Dispatches to the `takeWhile` method of the second argument, if present.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: (a -> Boolean) -> [a] -> [a]
		/// </summary>
		/// <param name="fn">The function called per iteration.</param>
		/// <param name="list">The collection to iterate over.</param>
		/// <returns>A new array.</returns>
		/// <see cref="R.DropWhile"/>
		/// <see cref="R.Transduce"/>
		/// <see cref="R.AddIndex"/>
		public static dynamic TakeWhile<TSource>(Func<TSource, bool> fn, RamdaPlaceholder list = null) {
			return Currying.TakeWhile(fn, list);
		}

		/// <summary>
		/// Returns a new list containing the first `n` elements of a given list,passing each value to the supplied predicate function, and terminating whenthe predicate function returns `false`. Excludes the element that caused thepredicate function to fail. The predicate function is passed one argument:*(value)*.Dispatches to the `takeWhile` method of the second argument, if present.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: (a -> Boolean) -> [a] -> [a]
		/// </summary>
		/// <param name="fn">The function called per iteration.</param>
		/// <param name="list">The collection to iterate over.</param>
		/// <returns>A new array.</returns>
		/// <see cref="R.DropWhile"/>
		/// <see cref="R.Transduce"/>
		/// <see cref="R.AddIndex"/>
		public static dynamic TakeWhile(RamdaPlaceholder fn = null, RamdaPlaceholder list = null) {
			return Currying.TakeWhile(fn, list);
		}
	}
}