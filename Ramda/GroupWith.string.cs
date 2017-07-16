﻿// <autogenerated>
//   This file was generated by T4 code generator GroupWith.string.tt.
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
		/// Takes a list and returns a list of lists where each sublist's elements areall "equal" according to the provided equality function.
		/// <para />
		/// sig: ((a, a) → Boolean) → [a] → [[a]]
		/// </summary>
		/// <param name="fn">Function for determining whether two given (adjacent)       elements should be in the same group</param>
		/// <param name="list">The array to group. Also accepts a string, which will be       treated as a list of characters.</param>
		/// <returns>A list that contains sublists of equal elements, whose concatenations are equal to the original list.</returns>
		public static dynamic GroupWith(Func<string, string, bool> fn, string list) {
			return Currying.GroupWith(fn, list);
		}

		/// <summary>
		/// Takes a list and returns a list of lists where each sublist's elements areall "equal" according to the provided equality function.
		/// <para />
		/// sig: ((a, a) → Boolean) → [a] → [[a]]
		/// </summary>
		/// <param name="fn">Function for determining whether two given (adjacent)       elements should be in the same group</param>
		/// <param name="list">The array to group. Also accepts a string, which will be       treated as a list of characters.</param>
		/// <returns>A list that contains sublists of equal elements, whose concatenations are equal to the original list.</returns>
		public static dynamic GroupWith(RamdaPlaceholder fn, string list) {
			return Currying.GroupWith(fn, list);
		}

		/// <summary>
		/// Takes a list and returns a list of lists where each sublist's elements areall "equal" according to the provided equality function.
		/// <para />
		/// sig: ((a, a) → Boolean) → [a] → [[a]]
		/// </summary>
		/// <param name="fn">Function for determining whether two given (adjacent)       elements should be in the same group</param>
		/// <param name="list">The array to group. Also accepts a string, which will be       treated as a list of characters.</param>
		/// <returns>A list that contains sublists of equal elements, whose concatenations are equal to the original list.</returns>
		public static dynamic GroupWith(Func<string, string, bool> fn, RamdaPlaceholder list = null) {
			return Currying.GroupWith(fn, list);
		}
	}
}