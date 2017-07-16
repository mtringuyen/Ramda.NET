﻿// <autogenerated>
//   This file was generated by T4 code generator Range.tt.
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
		/// Returns a list of numbers from `from` (inclusive) to `to` (exclusive).
		/// <para />
		/// sig: Number -> Number -> [Number]
		/// </summary>
		/// <param name="from">The first number in the list.</param>
		/// <param name="to">One more than the last number in the list.</param>
		/// <returns>The list of numbers in tthe set `[a, b)`.</returns>
		public static dynamic Range(int from, int to) {
			return Currying.Range(from, to);
		}

		/// <summary>
		/// Returns a list of numbers from `from` (inclusive) to `to` (exclusive).
		/// <para />
		/// sig: Number -> Number -> [Number]
		/// </summary>
		/// <param name="from">The first number in the list.</param>
		/// <param name="to">One more than the last number in the list.</param>
		/// <returns>The list of numbers in tthe set `[a, b)`.</returns>
		public static dynamic Range(RamdaPlaceholder from, int to) {
			return Currying.Range(from, to);
		}

		/// <summary>
		/// Returns a list of numbers from `from` (inclusive) to `to` (exclusive).
		/// <para />
		/// sig: Number -> Number -> [Number]
		/// </summary>
		/// <param name="from">The first number in the list.</param>
		/// <param name="to">One more than the last number in the list.</param>
		/// <returns>The list of numbers in tthe set `[a, b)`.</returns>
		public static dynamic Range(int from, RamdaPlaceholder to = null) {
			return Currying.Range(from, to);
		}

		/// <summary>
		/// Returns a list of numbers from `from` (inclusive) to `to` (exclusive).
		/// <para />
		/// sig: Number -> Number -> [Number]
		/// </summary>
		/// <param name="from">The first number in the list.</param>
		/// <param name="to">One more than the last number in the list.</param>
		/// <returns>The list of numbers in tthe set `[a, b)`.</returns>
		public static dynamic Range(RamdaPlaceholder from = null, RamdaPlaceholder to = null) {
			return Currying.Range(from, to);
		}
	}
}