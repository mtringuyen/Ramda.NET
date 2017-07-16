﻿// <autogenerated>
//   This file was generated by T4 code generator Pipe.tt.
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
		/// Performs left-to-right function composition. The leftmost function may haveany arity; the remaining functions must be unary.In some libraries this function is named `sequence`.**Note:** The result of pipe is not automatically curried.
		/// <para />
		/// sig: (((a, b, ..., n) -> o), (o -> p), ..., (x -> y), (y -> z)) -> ((a, b, ..., n) -> z)
		/// </summary>
		/// <param name="functions">first</param>
		/// <returns>Function</returns>
		/// <see cref="R.Compose"/>
		public static dynamic Pipe(params Delegate[] functions) {
			return Currying.Pipe(functions);
		}

		/// <summary>
		/// Performs left-to-right function composition. The leftmost function may haveany arity; the remaining functions must be unary.In some libraries this function is named `sequence`.**Note:** The result of pipe is not automatically curried.
		/// <para />
		/// sig: (((a, b, ..., n) -> o), (o -> p), ..., (x -> y), (y -> z)) -> ((a, b, ..., n) -> z)
		/// </summary>
		/// <param name="functions">first</param>
		/// <returns>Function</returns>
		/// <see cref="R.Compose"/>
		public static dynamic Pipe(RamdaPlaceholder functions = null) {
			return Currying.Pipe(functions);
		}
	}
}