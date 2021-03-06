﻿// <autogenerated>
//   This file was generated by T4 code generator CurryN.tt.
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
		/// Returns a curried equivalent of the provided function, with the specifiedarity. The curried function has two unusual capabilities. First, itsarguments needn't be provided one at a time. If `g` is `R.curryN(3, f)`, thefollowing are equivalent:  - `g(1)(2)(3)`  - `g(1)(2, 3)`  - `g(1, 2)(3)`  - `g(1, 2, 3)`Secondly, the special placeholder value `R.__` may be used to specify"gaps", allowing partial application of any combination of arguments,regardless of their positions. If `g` is as above and `_` is `R.__`, thefollowing are equivalent:  - `g(1, 2, 3)`  - `g(_, 2, 3)(1)`  - `g(_, _, 3)(1)(2)`  - `g(_, _, 3)(1, 2)`  - `g(_, 2)(1)(3)`  - `g(_, 2)(1, 3)`  - `g(_, 2)(_, 3)(1)`
		/// <para />
		/// sig: Number -> (* -> a) -> (* -> a)
		/// </summary>
		/// <param name="length">The arity for the returned function.</param>
		/// <param name="fn">The function to curry.</param>
		/// <returns>A new, curried function.</returns>
		/// <see cref="R.Curry"/>
		public static dynamic CurryN(int length, Delegate fn) {
			return Currying.CurryN(length, Delegate(fn));
		}

		/// <summary>
		/// Returns a curried equivalent of the provided function, with the specifiedarity. The curried function has two unusual capabilities. First, itsarguments needn't be provided one at a time. If `g` is `R.curryN(3, f)`, thefollowing are equivalent:  - `g(1)(2)(3)`  - `g(1)(2, 3)`  - `g(1, 2)(3)`  - `g(1, 2, 3)`Secondly, the special placeholder value `R.__` may be used to specify"gaps", allowing partial application of any combination of arguments,regardless of their positions. If `g` is as above and `_` is `R.__`, thefollowing are equivalent:  - `g(1, 2, 3)`  - `g(_, 2, 3)(1)`  - `g(_, _, 3)(1)(2)`  - `g(_, _, 3)(1, 2)`  - `g(_, 2)(1)(3)`  - `g(_, 2)(1, 3)`  - `g(_, 2)(_, 3)(1)`
		/// <para />
		/// sig: Number -> (* -> a) -> (* -> a)
		/// </summary>
		/// <param name="length">The arity for the returned function.</param>
		/// <param name="fn">The function to curry.</param>
		/// <returns>A new, curried function.</returns>
		/// <see cref="R.Curry"/>
		public static dynamic CurryN(RamdaPlaceholder length, Delegate fn) {
			return Currying.CurryN(length, Delegate(fn));
		}

		/// <summary>
		/// Returns a curried equivalent of the provided function, with the specifiedarity. The curried function has two unusual capabilities. First, itsarguments needn't be provided one at a time. If `g` is `R.curryN(3, f)`, thefollowing are equivalent:  - `g(1)(2)(3)`  - `g(1)(2, 3)`  - `g(1, 2)(3)`  - `g(1, 2, 3)`Secondly, the special placeholder value `R.__` may be used to specify"gaps", allowing partial application of any combination of arguments,regardless of their positions. If `g` is as above and `_` is `R.__`, thefollowing are equivalent:  - `g(1, 2, 3)`  - `g(_, 2, 3)(1)`  - `g(_, _, 3)(1)(2)`  - `g(_, _, 3)(1, 2)`  - `g(_, 2)(1)(3)`  - `g(_, 2)(1, 3)`  - `g(_, 2)(_, 3)(1)`
		/// <para />
		/// sig: Number -> (* -> a) -> (* -> a)
		/// </summary>
		/// <param name="length">The arity for the returned function.</param>
		/// <param name="fn">The function to curry.</param>
		/// <returns>A new, curried function.</returns>
		/// <see cref="R.Curry"/>
		public static dynamic CurryN(int length, RamdaPlaceholder fn = null) {
			return Currying.CurryN(length, fn);
		}

		/// <summary>
		/// Returns a curried equivalent of the provided function, with the specifiedarity. The curried function has two unusual capabilities. First, itsarguments needn't be provided one at a time. If `g` is `R.curryN(3, f)`, thefollowing are equivalent:  - `g(1)(2)(3)`  - `g(1)(2, 3)`  - `g(1, 2)(3)`  - `g(1, 2, 3)`Secondly, the special placeholder value `R.__` may be used to specify"gaps", allowing partial application of any combination of arguments,regardless of their positions. If `g` is as above and `_` is `R.__`, thefollowing are equivalent:  - `g(1, 2, 3)`  - `g(_, 2, 3)(1)`  - `g(_, _, 3)(1)(2)`  - `g(_, _, 3)(1, 2)`  - `g(_, 2)(1)(3)`  - `g(_, 2)(1, 3)`  - `g(_, 2)(_, 3)(1)`
		/// <para />
		/// sig: Number -> (* -> a) -> (* -> a)
		/// </summary>
		/// <param name="length">The arity for the returned function.</param>
		/// <param name="fn">The function to curry.</param>
		/// <returns>A new, curried function.</returns>
		/// <see cref="R.Curry"/>
		public static dynamic CurryN(RamdaPlaceholder length, dynamic fn) {
			return Currying.CurryN(length, Delegate(fn));
		}

		/// <summary>
		/// Returns a curried equivalent of the provided function, with the specifiedarity. The curried function has two unusual capabilities. First, itsarguments needn't be provided one at a time. If `g` is `R.curryN(3, f)`, thefollowing are equivalent:  - `g(1)(2)(3)`  - `g(1)(2, 3)`  - `g(1, 2)(3)`  - `g(1, 2, 3)`Secondly, the special placeholder value `R.__` may be used to specify"gaps", allowing partial application of any combination of arguments,regardless of their positions. If `g` is as above and `_` is `R.__`, thefollowing are equivalent:  - `g(1, 2, 3)`  - `g(_, 2, 3)(1)`  - `g(_, _, 3)(1)(2)`  - `g(_, _, 3)(1, 2)`  - `g(_, 2)(1)(3)`  - `g(_, 2)(1, 3)`  - `g(_, 2)(_, 3)(1)`
		/// <para />
		/// sig: Number -> (* -> a) -> (* -> a)
		/// </summary>
		/// <param name="length">The arity for the returned function.</param>
		/// <param name="fn">The function to curry.</param>
		/// <returns>A new, curried function.</returns>
		/// <see cref="R.Curry"/>
		public static dynamic CurryN(int length, dynamic fn) {
			return Currying.CurryN(length, Delegate(fn));
		}

		/// <summary>
		/// Returns a curried equivalent of the provided function, with the specifiedarity. The curried function has two unusual capabilities. First, itsarguments needn't be provided one at a time. If `g` is `R.curryN(3, f)`, thefollowing are equivalent:  - `g(1)(2)(3)`  - `g(1)(2, 3)`  - `g(1, 2)(3)`  - `g(1, 2, 3)`Secondly, the special placeholder value `R.__` may be used to specify"gaps", allowing partial application of any combination of arguments,regardless of their positions. If `g` is as above and `_` is `R.__`, thefollowing are equivalent:  - `g(1, 2, 3)`  - `g(_, 2, 3)(1)`  - `g(_, _, 3)(1)(2)`  - `g(_, _, 3)(1, 2)`  - `g(_, 2)(1)(3)`  - `g(_, 2)(1, 3)`  - `g(_, 2)(_, 3)(1)`
		/// <para />
		/// sig: Number -> (* -> a) -> (* -> a)
		/// </summary>
		/// <param name="length">The arity for the returned function.</param>
		/// <param name="fn">The function to curry.</param>
		/// <returns>A new, curried function.</returns>
		/// <see cref="R.Curry"/>
		public static dynamic CurryN(RamdaPlaceholder length = null, RamdaPlaceholder fn = null) {
			return Currying.CurryN(length, fn);
		}
	}
}