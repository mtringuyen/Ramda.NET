﻿// <autogenerated>
//   This file was generated by T4 code generator ObjOf.tt.
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
		/// Creates an object containing a single key:value pair.
		/// <para />
		/// sig: String -> a -> {String:a}
		/// </summary>
		/// <param name="key">first</param>
		/// <param name="val">second</param>
		/// <returns>Object</returns>
		/// <see cref="R.Pair"/>
		public static dynamic ObjOf<TSource>(string key, TSource val) {
			return Currying.ObjOf(key, val);
		}

		/// <summary>
		/// Creates an object containing a single key:value pair.
		/// <para />
		/// sig: String -> a -> {String:a}
		/// </summary>
		/// <param name="key">first</param>
		/// <param name="val">second</param>
		/// <returns>Object</returns>
		/// <see cref="R.Pair"/>
		public static dynamic ObjOf<TSource>(RamdaPlaceholder key, TSource val) {
			return Currying.ObjOf(key, val);
		}

		/// <summary>
		/// Creates an object containing a single key:value pair.
		/// <para />
		/// sig: String -> a -> {String:a}
		/// </summary>
		/// <param name="key">first</param>
		/// <param name="val">second</param>
		/// <returns>Object</returns>
		/// <see cref="R.Pair"/>
		public static dynamic ObjOf(string key, RamdaPlaceholder val = null) {
			return Currying.ObjOf(key, val);
		}

		/// <summary>
		/// Creates an object containing a single key:value pair.
		/// <para />
		/// sig: String -> a -> {String:a}
		/// </summary>
		/// <param name="key">first</param>
		/// <param name="val">second</param>
		/// <returns>Object</returns>
		/// <see cref="R.Pair"/>
		public static dynamic ObjOf(RamdaPlaceholder key = null, RamdaPlaceholder val = null) {
			return Currying.ObjOf(key, val);
		}
	}
}