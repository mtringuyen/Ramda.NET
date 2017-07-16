﻿// <autogenerated>
//   This file was generated by T4 code generator Dissoc.tt.
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
		/// Returns a new object that does not contain a `prop` property.
		/// <para />
		/// sig: String -> {k: v} -> {k: v}
		/// </summary>
		/// <param name="prop">The name of the property to dissociate</param>
		/// <param name="obj">The object to clone</param>
		/// <returns>A new object equivalent to the original but without the specified property</returns>
		/// <see cref="R.Assoc"/>
		public static dynamic Dissoc<TTarget>(string prop, TTarget obj) {
			return Currying.Dissoc(prop, obj);
		}

		/// <summary>
		/// Returns a new object that does not contain a `prop` property.
		/// <para />
		/// sig: String -> {k: v} -> {k: v}
		/// </summary>
		/// <param name="prop">The name of the property to dissociate</param>
		/// <param name="obj">The object to clone</param>
		/// <returns>A new object equivalent to the original but without the specified property</returns>
		/// <see cref="R.Assoc"/>
		public static dynamic Dissoc<TTarget>(RamdaPlaceholder prop, TTarget obj) {
			return Currying.Dissoc(prop, obj);
		}

		/// <summary>
		/// Returns a new object that does not contain a `prop` property.
		/// <para />
		/// sig: String -> {k: v} -> {k: v}
		/// </summary>
		/// <param name="prop">The name of the property to dissociate</param>
		/// <param name="obj">The object to clone</param>
		/// <returns>A new object equivalent to the original but without the specified property</returns>
		/// <see cref="R.Assoc"/>
		public static dynamic Dissoc(string prop, RamdaPlaceholder obj = null) {
			return Currying.Dissoc(prop, obj);
		}

		/// <summary>
		/// Returns a new object that does not contain a `prop` property.
		/// <para />
		/// sig: String -> {k: v} -> {k: v}
		/// </summary>
		/// <param name="prop">The name of the property to dissociate</param>
		/// <param name="obj">The object to clone</param>
		/// <returns>A new object equivalent to the original but without the specified property</returns>
		/// <see cref="R.Assoc"/>
		public static dynamic Dissoc(RamdaPlaceholder prop = null, RamdaPlaceholder obj = null) {
			return Currying.Dissoc(prop, obj);
		}
	}
}