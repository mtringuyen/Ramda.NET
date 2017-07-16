﻿// <autogenerated>
//   This file was generated by T4 code generator ConstructN.tt.
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
		/// Wraps a constructor function inside a curried function that can be calledwith the same arguments and returns the same type. The arity of the functionreturned is specified to allow using variadic constructor functions.
		/// <para />
		/// sig: Number -> (* -> {*}) -> (* -> {*})
		/// </summary>
		/// <param name="n">The arity of the constructor function.</param>
		/// <param name="Fn">The constructor function to wrap.</param>
		/// <returns>A wrapped, curried constructor function.</returns>
		public static dynamic ConstructN(int n, Delegate Fn) {
			return Currying.ConstructN(n, Delegate(Fn));
		}

		/// <summary>
		/// Wraps a constructor function inside a curried function that can be calledwith the same arguments and returns the same type. The arity of the functionreturned is specified to allow using variadic constructor functions.
		/// <para />
		/// sig: Number -> (* -> {*}) -> (* -> {*})
		/// </summary>
		/// <param name="n">The arity of the constructor function.</param>
		/// <param name="Fn">The constructor function to wrap.</param>
		/// <returns>A wrapped, curried constructor function.</returns>
		public static dynamic ConstructN(RamdaPlaceholder n, Delegate Fn) {
			return Currying.ConstructN(n, Delegate(Fn));
		}

		/// <summary>
		/// Wraps a constructor function inside a curried function that can be calledwith the same arguments and returns the same type. The arity of the functionreturned is specified to allow using variadic constructor functions.
		/// <para />
		/// sig: Number -> (* -> {*}) -> (* -> {*})
		/// </summary>
		/// <param name="n">The arity of the constructor function.</param>
		/// <param name="Fn">The constructor function to wrap.</param>
		/// <returns>A wrapped, curried constructor function.</returns>
		public static dynamic ConstructN(int n, RamdaPlaceholder Fn = null) {
			return Currying.ConstructN(n, Fn);
		}

		/// <summary>
		/// Wraps a constructor function inside a curried function that can be calledwith the same arguments and returns the same type. The arity of the functionreturned is specified to allow using variadic constructor functions.
		/// <para />
		/// sig: Number -> (* -> {*}) -> (* -> {*})
		/// </summary>
		/// <param name="n">The arity of the constructor function.</param>
		/// <param name="Fn">The constructor function to wrap.</param>
		/// <returns>A wrapped, curried constructor function.</returns>
		public static dynamic ConstructN(RamdaPlaceholder n, dynamic Fn) {
			return Currying.ConstructN(n, Delegate(Fn));
		}

		/// <summary>
		/// Wraps a constructor function inside a curried function that can be calledwith the same arguments and returns the same type. The arity of the functionreturned is specified to allow using variadic constructor functions.
		/// <para />
		/// sig: Number -> (* -> {*}) -> (* -> {*})
		/// </summary>
		/// <param name="n">The arity of the constructor function.</param>
		/// <param name="Fn">The constructor function to wrap.</param>
		/// <returns>A wrapped, curried constructor function.</returns>
		public static dynamic ConstructN(int n, dynamic Fn) {
			return Currying.ConstructN(n, Delegate(Fn));
		}

		/// <summary>
		/// Wraps a constructor function inside a curried function that can be calledwith the same arguments and returns the same type. The arity of the functionreturned is specified to allow using variadic constructor functions.
		/// <para />
		/// sig: Number -> (* -> {*}) -> (* -> {*})
		/// </summary>
		/// <param name="n">The arity of the constructor function.</param>
		/// <param name="Fn">The constructor function to wrap.</param>
		/// <returns>A wrapped, curried constructor function.</returns>
		public static dynamic ConstructN(RamdaPlaceholder n = null, RamdaPlaceholder Fn = null) {
			return Currying.ConstructN(n, Fn);
		}
	}
}