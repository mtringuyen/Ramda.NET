﻿// <autogenerated>
//   This file was generated by T4 code generator Always.tt.
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
		/// Returns a function that always returns the given value. Note that fornon-primitives the value returned is a reference to the original value.This function is known as `const`, `constant`, or `K` (for K combinator) inother languages and libraries.
		/// <para />
		/// sig: a -> (* -> a)
		/// </summary>
		/// <param name="val">The value to wrap in a function</param>
		/// <returns>A Function :: * -> val.</returns>
		public static dynamic Always<TTarget>(TTarget val) {
			return Currying.Always(val);
		}

		/// <summary>
		/// Returns a function that always returns the given value. Note that fornon-primitives the value returned is a reference to the original value.This function is known as `const`, `constant`, or `K` (for K combinator) inother languages and libraries.
		/// <para />
		/// sig: a -> (* -> a)
		/// </summary>
		/// <param name="val">The value to wrap in a function</param>
		/// <returns>A Function :: * -> val.</returns>
		public static dynamic Always(RamdaPlaceholder val = null) {
			return Currying.Always(val);
		}
	}
}