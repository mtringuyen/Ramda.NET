﻿// <autogenerated>
//   This file was generated by T4 code generator Reject.tt.
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
		/// The complement of `filter`.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: Filterable f => (a -> Boolean) -> f a -> f a
		/// </summary>
		/// <param name="pred">first</param>
		/// <param name="filterable">second</param>
		/// <returns>Array</returns>
		/// <see cref="R.Filter"/>
		/// <see cref="R.Transduce"/>
		/// <see cref="R.AddIndex"/>
		public static dynamic Reject<TTarget, TArg>(Func<TArg, bool> pred, TTarget filterable) {
			return Currying.Reject(Delegate(pred), filterable);
		}

		/// <summary>
		/// The complement of `filter`.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: Filterable f => (a -> Boolean) -> f a -> f a
		/// </summary>
		/// <param name="pred">first</param>
		/// <param name="filterable">second</param>
		/// <returns>Array</returns>
		/// <see cref="R.Filter"/>
		/// <see cref="R.Transduce"/>
		/// <see cref="R.AddIndex"/>
		public static dynamic Reject<TTarget>(RamdaPlaceholder pred, TTarget filterable) {
			return Currying.Reject(pred, filterable);
		}

		/// <summary>
		/// The complement of `filter`.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: Filterable f => (a -> Boolean) -> f a -> f a
		/// </summary>
		/// <param name="pred">first</param>
		/// <param name="filterable">second</param>
		/// <returns>Array</returns>
		/// <see cref="R.Filter"/>
		/// <see cref="R.Transduce"/>
		/// <see cref="R.AddIndex"/>
		public static dynamic Reject<TArg>(Func<TArg, bool> pred, RamdaPlaceholder filterable = null) {
			return Currying.Reject(Delegate(pred), filterable);
		}

		/// <summary>
		/// The complement of `filter`.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: Filterable f => (a -> Boolean) -> f a -> f a
		/// </summary>
		/// <param name="pred">first</param>
		/// <param name="filterable">second</param>
		/// <returns>Array</returns>
		/// <see cref="R.Filter"/>
		/// <see cref="R.Transduce"/>
		/// <see cref="R.AddIndex"/>
		public static dynamic Reject(dynamic pred, RamdaPlaceholder filterable = null) {
			return Currying.Reject(Delegate(pred), filterable);
		}

		/// <summary>
		/// The complement of `filter`.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: Filterable f => (a -> Boolean) -> f a -> f a
		/// </summary>
		/// <param name="pred">first</param>
		/// <param name="filterable">second</param>
		/// <returns>Array</returns>
		/// <see cref="R.Filter"/>
		/// <see cref="R.Transduce"/>
		/// <see cref="R.AddIndex"/>
		public static dynamic Reject<TTarget>(dynamic pred, TTarget filterable) {
			return Currying.Reject(Delegate(pred), filterable);
		}

		/// <summary>
		/// The complement of `filter`.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: Filterable f => (a -> Boolean) -> f a -> f a
		/// </summary>
		/// <param name="pred">first</param>
		/// <param name="filterable">second</param>
		/// <returns>Array</returns>
		/// <see cref="R.Filter"/>
		/// <see cref="R.Transduce"/>
		/// <see cref="R.AddIndex"/>
		public static dynamic Reject(RamdaPlaceholder pred = null, RamdaPlaceholder filterable = null) {
			return Currying.Reject(pred, filterable);
		}
	}
}