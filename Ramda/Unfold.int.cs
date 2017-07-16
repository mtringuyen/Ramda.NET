﻿// <autogenerated>
//   This file was generated by T4 code generator Unfold.int.tt.
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
		/// Builds a list from a seed value. Accepts an iterator function, which returnseither false to stop iteration or an array of length 2 containing the valueto add to the resulting list and the seed to be used in the next call to theiterator function.The iterator function receives one argument: *(seed)*.
		/// <para />
		/// sig: (a -> [b]) -> * -> [b]
		/// </summary>
		/// <param name="fn">The iterator function. receives one argument, `seed`, and returns       either false to quit iteration or an array of length two to proceed. The element       at index 0 of this array will be added to the resulting array, and the element       at index 1 will be passed to the next call to `fn`.</param>
		/// <param name="seed">The seed value.</param>
		/// <returns>The final list.</returns>
		public static dynamic Unfold(Func<int, dynamic> fn, int seed) {
			return Currying.Unfold(Delegate(fn), seed);
		}

		/// <summary>
		/// Builds a list from a seed value. Accepts an iterator function, which returnseither false to stop iteration or an array of length 2 containing the valueto add to the resulting list and the seed to be used in the next call to theiterator function.The iterator function receives one argument: *(seed)*.
		/// <para />
		/// sig: (a -> [b]) -> * -> [b]
		/// </summary>
		/// <param name="fn">The iterator function. receives one argument, `seed`, and returns       either false to quit iteration or an array of length two to proceed. The element       at index 0 of this array will be added to the resulting array, and the element       at index 1 will be passed to the next call to `fn`.</param>
		/// <param name="seed">The seed value.</param>
		/// <returns>The final list.</returns>
		public static dynamic Unfold(RamdaPlaceholder fn, int seed) {
			return Currying.Unfold(fn, seed);
		}

		/// <summary>
		/// Builds a list from a seed value. Accepts an iterator function, which returnseither false to stop iteration or an array of length 2 containing the valueto add to the resulting list and the seed to be used in the next call to theiterator function.The iterator function receives one argument: *(seed)*.
		/// <para />
		/// sig: (a -> [b]) -> * -> [b]
		/// </summary>
		/// <param name="fn">The iterator function. receives one argument, `seed`, and returns       either false to quit iteration or an array of length two to proceed. The element       at index 0 of this array will be added to the resulting array, and the element       at index 1 will be passed to the next call to `fn`.</param>
		/// <param name="seed">The seed value.</param>
		/// <returns>The final list.</returns>
		public static dynamic Unfold(Func<int, dynamic> fn, RamdaPlaceholder seed = null) {
			return Currying.Unfold(Delegate(fn), seed);
		}

		/// <summary>
		/// Builds a list from a seed value. Accepts an iterator function, which returnseither false to stop iteration or an array of length 2 containing the valueto add to the resulting list and the seed to be used in the next call to theiterator function.The iterator function receives one argument: *(seed)*.
		/// <para />
		/// sig: (a -> [b]) -> * -> [b]
		/// </summary>
		/// <param name="fn">The iterator function. receives one argument, `seed`, and returns       either false to quit iteration or an array of length two to proceed. The element       at index 0 of this array will be added to the resulting array, and the element       at index 1 will be passed to the next call to `fn`.</param>
		/// <param name="seed">The seed value.</param>
		/// <returns>The final list.</returns>
		public static dynamic Unfold(dynamic fn, RamdaPlaceholder seed = null) {
			return Currying.Unfold(Delegate(fn), seed);
		}

		/// <summary>
		/// Builds a list from a seed value. Accepts an iterator function, which returnseither false to stop iteration or an array of length 2 containing the valueto add to the resulting list and the seed to be used in the next call to theiterator function.The iterator function receives one argument: *(seed)*.
		/// <para />
		/// sig: (a -> [b]) -> * -> [b]
		/// </summary>
		/// <param name="fn">The iterator function. receives one argument, `seed`, and returns       either false to quit iteration or an array of length two to proceed. The element       at index 0 of this array will be added to the resulting array, and the element       at index 1 will be passed to the next call to `fn`.</param>
		/// <param name="seed">The seed value.</param>
		/// <returns>The final list.</returns>
		public static dynamic Unfold(dynamic fn, int seed) {
			return Currying.Unfold(Delegate(fn), seed);
		}

		/// <summary>
		/// Builds a list from a seed value. Accepts an iterator function, which returnseither false to stop iteration or an array of length 2 containing the valueto add to the resulting list and the seed to be used in the next call to theiterator function.The iterator function receives one argument: *(seed)*.
		/// <para />
		/// sig: (a -> [b]) -> * -> [b]
		/// </summary>
		/// <param name="fn">The iterator function. receives one argument, `seed`, and returns       either false to quit iteration or an array of length two to proceed. The element       at index 0 of this array will be added to the resulting array, and the element       at index 1 will be passed to the next call to `fn`.</param>
		/// <param name="seed">The seed value.</param>
		/// <returns>The final list.</returns>
		public static dynamic Unfold(RamdaPlaceholder fn = null, RamdaPlaceholder seed = null) {
			return Currying.Unfold(fn, seed);
		}
	}
}