﻿// <autogenerated>
//   This file was generated by T4 code generator Join.tt.
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
		/// Returns a string made by inserting the `separator` between each element andconcatenating all the elements into a single string.
		/// <para />
		/// sig: String -> [a] -> String
		/// </summary>
		/// <param name="separator">The string used to separate the elements.</param>
		/// <param name="xs">The elements to join into a string.</param>
		/// <returns>str The string made by concatenating `xs` with `separator`.</returns>
		/// <see cref="R.Split"/>
		public static dynamic Join<TSource>(string separator, IList<TSource> xs) {
			return Currying.Join(separator, xs);
		}

		/// <summary>
		/// Returns a string made by inserting the `separator` between each element andconcatenating all the elements into a single string.
		/// <para />
		/// sig: String -> [a] -> String
		/// </summary>
		/// <param name="separator">The string used to separate the elements.</param>
		/// <param name="xs">The elements to join into a string.</param>
		/// <returns>str The string made by concatenating `xs` with `separator`.</returns>
		/// <see cref="R.Split"/>
		public static dynamic Join<TSource>(RamdaPlaceholder separator, IList<TSource> xs) {
			return Currying.Join(separator, xs);
		}

		/// <summary>
		/// Returns a string made by inserting the `separator` between each element andconcatenating all the elements into a single string.
		/// <para />
		/// sig: String -> [a] -> String
		/// </summary>
		/// <param name="separator">The string used to separate the elements.</param>
		/// <param name="xs">The elements to join into a string.</param>
		/// <returns>str The string made by concatenating `xs` with `separator`.</returns>
		/// <see cref="R.Split"/>
		public static dynamic Join(string separator, RamdaPlaceholder xs = null) {
			return Currying.Join(separator, xs);
		}

		/// <summary>
		/// Returns a string made by inserting the `separator` between each element andconcatenating all the elements into a single string.
		/// <para />
		/// sig: String -> [a] -> String
		/// </summary>
		/// <param name="separator">The string used to separate the elements.</param>
		/// <param name="xs">The elements to join into a string.</param>
		/// <returns>str The string made by concatenating `xs` with `separator`.</returns>
		/// <see cref="R.Split"/>
		public static dynamic Join(RamdaPlaceholder separator = null, RamdaPlaceholder xs = null) {
			return Currying.Join(separator, xs);
		}
	}
}