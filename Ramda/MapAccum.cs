﻿// <autogenerated>
//   This file was generated by T4 code generator MapAccum.tt.
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
		/// The mapAccum function behaves like a combination of map and reduce; itapplies a function to each element of a list, passing an accumulatingparameter from left to right, and returning a final value of thisaccumulator together with the new list.The iterator function receives two arguments, *acc* and *value*, and shouldreturn a tuple *[acc, value]*.
		/// <para />
		/// sig: (acc -> x -> (acc, y)) -> acc -> [x] -> (acc, [y])
		/// </summary>
		/// <param name="fn">The function to be called on every element of the input `list`.</param>
		/// <param name="acc">The accumulator value.</param>
		/// <param name="list">The list to iterate over.</param>
		/// <returns>The final, accumulated value.</returns>
		/// <see cref="R.AddIndex"/>
		/// <see cref="R.MapAccum"/>
		public static dynamic MapAccum<TArg, TSource, TAccmulator>(Func<TArg, TArg, Tuple<object, object>> fn, TAccmulator acc, IList<TSource> list) {
			return Currying.MapAccum(Delegate(fn), acc, list);
		}

		/// <summary>
		/// The mapAccum function behaves like a combination of map and reduce; itapplies a function to each element of a list, passing an accumulatingparameter from left to right, and returning a final value of thisaccumulator together with the new list.The iterator function receives two arguments, *acc* and *value*, and shouldreturn a tuple *[acc, value]*.
		/// <para />
		/// sig: (acc -> x -> (acc, y)) -> acc -> [x] -> (acc, [y])
		/// </summary>
		/// <param name="fn">The function to be called on every element of the input `list`.</param>
		/// <param name="acc">The accumulator value.</param>
		/// <param name="list">The list to iterate over.</param>
		/// <returns>The final, accumulated value.</returns>
		/// <see cref="R.AddIndex"/>
		/// <see cref="R.MapAccum"/>
		public static dynamic MapAccum<TSource, TAccmulator>(RamdaPlaceholder fn, TAccmulator acc, IList<TSource> list) {
			return Currying.MapAccum(fn, acc, list);
		}

		/// <summary>
		/// The mapAccum function behaves like a combination of map and reduce; itapplies a function to each element of a list, passing an accumulatingparameter from left to right, and returning a final value of thisaccumulator together with the new list.The iterator function receives two arguments, *acc* and *value*, and shouldreturn a tuple *[acc, value]*.
		/// <para />
		/// sig: (acc -> x -> (acc, y)) -> acc -> [x] -> (acc, [y])
		/// </summary>
		/// <param name="fn">The function to be called on every element of the input `list`.</param>
		/// <param name="acc">The accumulator value.</param>
		/// <param name="list">The list to iterate over.</param>
		/// <returns>The final, accumulated value.</returns>
		/// <see cref="R.AddIndex"/>
		/// <see cref="R.MapAccum"/>
		public static dynamic MapAccum<TArg, TSource>(Func<TArg, TArg, Tuple<object, object>> fn, RamdaPlaceholder acc, IList<TSource> list) {
			return Currying.MapAccum(Delegate(fn), acc, list);
		}

		/// <summary>
		/// The mapAccum function behaves like a combination of map and reduce; itapplies a function to each element of a list, passing an accumulatingparameter from left to right, and returning a final value of thisaccumulator together with the new list.The iterator function receives two arguments, *acc* and *value*, and shouldreturn a tuple *[acc, value]*.
		/// <para />
		/// sig: (acc -> x -> (acc, y)) -> acc -> [x] -> (acc, [y])
		/// </summary>
		/// <param name="fn">The function to be called on every element of the input `list`.</param>
		/// <param name="acc">The accumulator value.</param>
		/// <param name="list">The list to iterate over.</param>
		/// <returns>The final, accumulated value.</returns>
		/// <see cref="R.AddIndex"/>
		/// <see cref="R.MapAccum"/>
		public static dynamic MapAccum<TArg, TAccmulator>(Func<TArg, TArg, Tuple<object, object>> fn, TAccmulator acc, RamdaPlaceholder list = null) {
			return Currying.MapAccum(Delegate(fn), acc, list);
		}

		/// <summary>
		/// The mapAccum function behaves like a combination of map and reduce; itapplies a function to each element of a list, passing an accumulatingparameter from left to right, and returning a final value of thisaccumulator together with the new list.The iterator function receives two arguments, *acc* and *value*, and shouldreturn a tuple *[acc, value]*.
		/// <para />
		/// sig: (acc -> x -> (acc, y)) -> acc -> [x] -> (acc, [y])
		/// </summary>
		/// <param name="fn">The function to be called on every element of the input `list`.</param>
		/// <param name="acc">The accumulator value.</param>
		/// <param name="list">The list to iterate over.</param>
		/// <returns>The final, accumulated value.</returns>
		/// <see cref="R.AddIndex"/>
		/// <see cref="R.MapAccum"/>
		public static dynamic MapAccum<TArg>(Func<TArg, TArg, Tuple<object, object>> fn, RamdaPlaceholder acc = null, RamdaPlaceholder list = null) {
			return Currying.MapAccum(Delegate(fn), acc, list);
		}

		/// <summary>
		/// The mapAccum function behaves like a combination of map and reduce; itapplies a function to each element of a list, passing an accumulatingparameter from left to right, and returning a final value of thisaccumulator together with the new list.The iterator function receives two arguments, *acc* and *value*, and shouldreturn a tuple *[acc, value]*.
		/// <para />
		/// sig: (acc -> x -> (acc, y)) -> acc -> [x] -> (acc, [y])
		/// </summary>
		/// <param name="fn">The function to be called on every element of the input `list`.</param>
		/// <param name="acc">The accumulator value.</param>
		/// <param name="list">The list to iterate over.</param>
		/// <returns>The final, accumulated value.</returns>
		/// <see cref="R.AddIndex"/>
		/// <see cref="R.MapAccum"/>
		public static dynamic MapAccum<TSource>(dynamic fn, RamdaPlaceholder acc, IList<TSource> list) {
			return Currying.MapAccum(Delegate(fn), acc, list);
		}

		/// <summary>
		/// The mapAccum function behaves like a combination of map and reduce; itapplies a function to each element of a list, passing an accumulatingparameter from left to right, and returning a final value of thisaccumulator together with the new list.The iterator function receives two arguments, *acc* and *value*, and shouldreturn a tuple *[acc, value]*.
		/// <para />
		/// sig: (acc -> x -> (acc, y)) -> acc -> [x] -> (acc, [y])
		/// </summary>
		/// <param name="fn">The function to be called on every element of the input `list`.</param>
		/// <param name="acc">The accumulator value.</param>
		/// <param name="list">The list to iterate over.</param>
		/// <returns>The final, accumulated value.</returns>
		/// <see cref="R.AddIndex"/>
		/// <see cref="R.MapAccum"/>
		public static dynamic MapAccum<TAccmulator>(dynamic fn, TAccmulator acc, RamdaPlaceholder list = null) {
			return Currying.MapAccum(Delegate(fn), acc, list);
		}

		/// <summary>
		/// The mapAccum function behaves like a combination of map and reduce; itapplies a function to each element of a list, passing an accumulatingparameter from left to right, and returning a final value of thisaccumulator together with the new list.The iterator function receives two arguments, *acc* and *value*, and shouldreturn a tuple *[acc, value]*.
		/// <para />
		/// sig: (acc -> x -> (acc, y)) -> acc -> [x] -> (acc, [y])
		/// </summary>
		/// <param name="fn">The function to be called on every element of the input `list`.</param>
		/// <param name="acc">The accumulator value.</param>
		/// <param name="list">The list to iterate over.</param>
		/// <returns>The final, accumulated value.</returns>
		/// <see cref="R.AddIndex"/>
		/// <see cref="R.MapAccum"/>
		public static dynamic MapAccum(dynamic fn, RamdaPlaceholder acc = null, RamdaPlaceholder list = null) {
			return Currying.MapAccum(Delegate(fn), acc, list);
		}

		/// <summary>
		/// The mapAccum function behaves like a combination of map and reduce; itapplies a function to each element of a list, passing an accumulatingparameter from left to right, and returning a final value of thisaccumulator together with the new list.The iterator function receives two arguments, *acc* and *value*, and shouldreturn a tuple *[acc, value]*.
		/// <para />
		/// sig: (acc -> x -> (acc, y)) -> acc -> [x] -> (acc, [y])
		/// </summary>
		/// <param name="fn">The function to be called on every element of the input `list`.</param>
		/// <param name="acc">The accumulator value.</param>
		/// <param name="list">The list to iterate over.</param>
		/// <returns>The final, accumulated value.</returns>
		/// <see cref="R.AddIndex"/>
		/// <see cref="R.MapAccum"/>
		public static dynamic MapAccum<TSource, TAccmulator>(dynamic fn, TAccmulator acc, IList<TSource> list) {
			return Currying.MapAccum(Delegate(fn), acc, list);
		}

		/// <summary>
		/// The mapAccum function behaves like a combination of map and reduce; itapplies a function to each element of a list, passing an accumulatingparameter from left to right, and returning a final value of thisaccumulator together with the new list.The iterator function receives two arguments, *acc* and *value*, and shouldreturn a tuple *[acc, value]*.
		/// <para />
		/// sig: (acc -> x -> (acc, y)) -> acc -> [x] -> (acc, [y])
		/// </summary>
		/// <param name="fn">The function to be called on every element of the input `list`.</param>
		/// <param name="acc">The accumulator value.</param>
		/// <param name="list">The list to iterate over.</param>
		/// <returns>The final, accumulated value.</returns>
		/// <see cref="R.AddIndex"/>
		/// <see cref="R.MapAccum"/>
		public static dynamic MapAccum(RamdaPlaceholder fn = null, RamdaPlaceholder acc = null, RamdaPlaceholder list = null) {
			return Currying.MapAccum(fn, acc, list);
		}
	}
}