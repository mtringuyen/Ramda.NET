﻿// <autogenerated>
//   This file was generated by T4 code generator AssocPath.tt.
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
		/// Makes a shallow clone of an object, setting or overriding the nodes requiredto create the given path, and placing the specific value at the tail end ofthat path. Note that this copies and flattens prototype properties onto thenew object as well. All non-primitive properties are copied by reference.
		/// <para />
		/// sig: [Idx] -> a -> {a} -> {a}
		/// </summary>
		/// <param name="path">the path to set</param>
		/// <param name="val">The new value</param>
		/// <param name="obj">The object to clone</param>
		/// <returns>A new object equivalent to the original except along the specified path.</returns>
		/// <see cref="R.DissocPath"/>
		public static dynamic AssocPath<TValue, TTarget>(IList<object> path, TValue val, TTarget obj) {
			return Currying.AssocPath(path, val, obj);
		}

		/// <summary>
		/// Makes a shallow clone of an object, setting or overriding the nodes requiredto create the given path, and placing the specific value at the tail end ofthat path. Note that this copies and flattens prototype properties onto thenew object as well. All non-primitive properties are copied by reference.
		/// <para />
		/// sig: [Idx] -> a -> {a} -> {a}
		/// </summary>
		/// <param name="path">the path to set</param>
		/// <param name="val">The new value</param>
		/// <param name="obj">The object to clone</param>
		/// <returns>A new object equivalent to the original except along the specified path.</returns>
		/// <see cref="R.DissocPath"/>
		public static dynamic AssocPath<TValue, TTarget>(RamdaPlaceholder path, TValue val, TTarget obj) {
			return Currying.AssocPath(path, val, obj);
		}

		/// <summary>
		/// Makes a shallow clone of an object, setting or overriding the nodes requiredto create the given path, and placing the specific value at the tail end ofthat path. Note that this copies and flattens prototype properties onto thenew object as well. All non-primitive properties are copied by reference.
		/// <para />
		/// sig: [Idx] -> a -> {a} -> {a}
		/// </summary>
		/// <param name="path">the path to set</param>
		/// <param name="val">The new value</param>
		/// <param name="obj">The object to clone</param>
		/// <returns>A new object equivalent to the original except along the specified path.</returns>
		/// <see cref="R.DissocPath"/>
		public static dynamic AssocPath<TTarget>(IList<object> path, RamdaPlaceholder val, TTarget obj) {
			return Currying.AssocPath(path, val, obj);
		}

		/// <summary>
		/// Makes a shallow clone of an object, setting or overriding the nodes requiredto create the given path, and placing the specific value at the tail end ofthat path. Note that this copies and flattens prototype properties onto thenew object as well. All non-primitive properties are copied by reference.
		/// <para />
		/// sig: [Idx] -> a -> {a} -> {a}
		/// </summary>
		/// <param name="path">the path to set</param>
		/// <param name="val">The new value</param>
		/// <param name="obj">The object to clone</param>
		/// <returns>A new object equivalent to the original except along the specified path.</returns>
		/// <see cref="R.DissocPath"/>
		public static dynamic AssocPath<TValue>(IList<object> path, TValue val, RamdaPlaceholder obj = null) {
			return Currying.AssocPath(path, val, obj);
		}

		/// <summary>
		/// Makes a shallow clone of an object, setting or overriding the nodes requiredto create the given path, and placing the specific value at the tail end ofthat path. Note that this copies and flattens prototype properties onto thenew object as well. All non-primitive properties are copied by reference.
		/// <para />
		/// sig: [Idx] -> a -> {a} -> {a}
		/// </summary>
		/// <param name="path">the path to set</param>
		/// <param name="val">The new value</param>
		/// <param name="obj">The object to clone</param>
		/// <returns>A new object equivalent to the original except along the specified path.</returns>
		/// <see cref="R.DissocPath"/>
		public static dynamic AssocPath(IList<object> path, RamdaPlaceholder val = null, RamdaPlaceholder obj = null) {
			return Currying.AssocPath(path, val, obj);
		}

		/// <summary>
		/// Makes a shallow clone of an object, setting or overriding the nodes requiredto create the given path, and placing the specific value at the tail end ofthat path. Note that this copies and flattens prototype properties onto thenew object as well. All non-primitive properties are copied by reference.
		/// <para />
		/// sig: [Idx] -> a -> {a} -> {a}
		/// </summary>
		/// <param name="path">the path to set</param>
		/// <param name="val">The new value</param>
		/// <param name="obj">The object to clone</param>
		/// <returns>A new object equivalent to the original except along the specified path.</returns>
		/// <see cref="R.DissocPath"/>
		public static dynamic AssocPath(RamdaPlaceholder path = null, RamdaPlaceholder val = null, RamdaPlaceholder obj = null) {
			return Currying.AssocPath(path, val, obj);
		}
	}
}