﻿// <autogenerated>
//   This file was generated by T4 code generator Chain.tt.
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
		/// `chain` maps a function over a list and concatenates the results. `chain`is also known as `flatMap` in some librariesDispatches to the `chain` method of the second argument, if present,according to the [FantasyLand Chain spec](https://github.com/fantasyland/fantasy-land#chain).
		/// <para />
		/// sig: Chain m => (a -> m b) -> m a -> m b
		/// </summary>
		/// <param name="fn">The function to map with</param>
		/// <param name="list">The list to map over</param>
		/// <returns>The result of flat-mapping `list` with `fn`</returns>
		public static dynamic Chain<TSource>(Delegate fn, IList<TSource> list) {
			return Currying.Chain(Delegate(fn), list);
		}

		/// <summary>
		/// `chain` maps a function over a list and concatenates the results. `chain`is also known as `flatMap` in some librariesDispatches to the `chain` method of the second argument, if present,according to the [FantasyLand Chain spec](https://github.com/fantasyland/fantasy-land#chain).
		/// <para />
		/// sig: Chain m => (a -> m b) -> m a -> m b
		/// </summary>
		/// <param name="fn">The function to map with</param>
		/// <param name="list">The list to map over</param>
		/// <returns>The result of flat-mapping `list` with `fn`</returns>
		public static dynamic Chain<TSource>(RamdaPlaceholder fn, IList<TSource> list) {
			return Currying.Chain(fn, list);
		}

		/// <summary>
		/// `chain` maps a function over a list and concatenates the results. `chain`is also known as `flatMap` in some librariesDispatches to the `chain` method of the second argument, if present,according to the [FantasyLand Chain spec](https://github.com/fantasyland/fantasy-land#chain).
		/// <para />
		/// sig: Chain m => (a -> m b) -> m a -> m b
		/// </summary>
		/// <param name="fn">The function to map with</param>
		/// <param name="list">The list to map over</param>
		/// <returns>The result of flat-mapping `list` with `fn`</returns>
		public static dynamic Chain(Delegate fn, RamdaPlaceholder list = null) {
			return Currying.Chain(Delegate(fn), list);
		}

		/// <summary>
		/// `chain` maps a function over a list and concatenates the results. `chain`is also known as `flatMap` in some librariesDispatches to the `chain` method of the second argument, if present,according to the [FantasyLand Chain spec](https://github.com/fantasyland/fantasy-land#chain).
		/// <para />
		/// sig: Chain m => (a -> m b) -> m a -> m b
		/// </summary>
		/// <param name="fn">The function to map with</param>
		/// <param name="list">The list to map over</param>
		/// <returns>The result of flat-mapping `list` with `fn`</returns>
		public static dynamic Chain(dynamic fn, RamdaPlaceholder list = null) {
			return Currying.Chain(Delegate(fn), list);
		}

		/// <summary>
		/// `chain` maps a function over a list and concatenates the results. `chain`is also known as `flatMap` in some librariesDispatches to the `chain` method of the second argument, if present,according to the [FantasyLand Chain spec](https://github.com/fantasyland/fantasy-land#chain).
		/// <para />
		/// sig: Chain m => (a -> m b) -> m a -> m b
		/// </summary>
		/// <param name="fn">The function to map with</param>
		/// <param name="list">The list to map over</param>
		/// <returns>The result of flat-mapping `list` with `fn`</returns>
		public static dynamic Chain<TSource>(dynamic fn, IList<TSource> list) {
			return Currying.Chain(Delegate(fn), list);
		}

		/// <summary>
		/// `chain` maps a function over a list and concatenates the results. `chain`is also known as `flatMap` in some librariesDispatches to the `chain` method of the second argument, if present,according to the [FantasyLand Chain spec](https://github.com/fantasyland/fantasy-land#chain).
		/// <para />
		/// sig: Chain m => (a -> m b) -> m a -> m b
		/// </summary>
		/// <param name="fn">The function to map with</param>
		/// <param name="list">The list to map over</param>
		/// <returns>The result of flat-mapping `list` with `fn`</returns>
		public static dynamic Chain(RamdaPlaceholder fn = null, RamdaPlaceholder list = null) {
			return Currying.Chain(fn, list);
		}
	}
}