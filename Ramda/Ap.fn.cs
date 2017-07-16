﻿// <autogenerated>
//   This file was generated by T4 code generator Ap.fn.tt.
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
		/// ap applies a list of functions to a list of values.Dispatches to the `ap` method of the second argument, if present. Alsotreats curried functions as applicatives.
		/// <para />
		/// sig: [a -> b] -> [a] -> [b]
		/// </summary>
		/// <param name="fns">An array of functions</param>
		/// <param name="vs">An array of values</param>
		/// <returns>An array of results of applying each of `fns` to all of `vs` in turn.</returns>
		public static dynamic Ap<TSource>(Func<TSource, TSource> fns, Func<TSource, TSource> vs) {
			return Currying.Ap(fns, vs);
		}

		/// <summary>
		/// ap applies a list of functions to a list of values.Dispatches to the `ap` method of the second argument, if present. Alsotreats curried functions as applicatives.
		/// <para />
		/// sig: [a -> b] -> [a] -> [b]
		/// </summary>
		/// <param name="fns">An array of functions</param>
		/// <param name="vs">An array of values</param>
		/// <returns>An array of results of applying each of `fns` to all of `vs` in turn.</returns>
		public static dynamic Ap<TSource>(RamdaPlaceholder fns, Func<TSource, TSource> vs) {
			return Currying.Ap(fns, vs);
		}

		/// <summary>
		/// ap applies a list of functions to a list of values.Dispatches to the `ap` method of the second argument, if present. Alsotreats curried functions as applicatives.
		/// <para />
		/// sig: [a -> b] -> [a] -> [b]
		/// </summary>
		/// <param name="fns">An array of functions</param>
		/// <param name="vs">An array of values</param>
		/// <returns>An array of results of applying each of `fns` to all of `vs` in turn.</returns>
		public static dynamic Ap<TSource>(Func<TSource, TSource> fns, RamdaPlaceholder vs = null) {
			return Currying.Ap(fns, vs);
		}
	}
}