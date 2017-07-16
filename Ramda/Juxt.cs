﻿// <autogenerated>
//   This file was generated by T4 code generator Juxt.tt.
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
		/// juxt applies a list of functions to a list of values.
		/// <para />
		/// sig: [(a, b, ..., m) -> n] -> ((a, b, ..., m) -> [n])
		/// </summary>
		/// <param name="fns">An array of functions</param>
		/// <returns>A function that returns a list of values after applying each of the original `fns` to its parameters.</returns>
		/// <see cref="R.ApplySpec"/>
		public static dynamic Juxt<TSource, TResult>(IList<Func<TSource, TResult>> fns) {
			return Currying.Juxt(fns);
		}

		/// <summary>
		/// juxt applies a list of functions to a list of values.
		/// <para />
		/// sig: [(a, b, ..., m) -> n] -> ((a, b, ..., m) -> [n])
		/// </summary>
		/// <param name="fns">An array of functions</param>
		/// <returns>A function that returns a list of values after applying each of the original `fns` to its parameters.</returns>
		/// <see cref="R.ApplySpec"/>
		public static dynamic Juxt(RamdaPlaceholder fns = null) {
			return Currying.Juxt(fns);
		}
	}
}