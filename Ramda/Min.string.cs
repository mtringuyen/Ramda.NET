﻿// <autogenerated>
//   This file was generated by T4 code generator Min.string.tt.
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
		/// Returns the smaller of its two arguments.
		/// <para />
		/// sig: Ord a => a -> a -> a
		/// </summary>
		/// <param name="a">first</param>
		/// <param name="b">second</param>
		/// <returns>*</returns>
		/// <see cref="R.MinBy"/>
		/// <see cref="R.Max"/>
		public static dynamic Min(string a, string b) {
			return Currying.Min(a, b);
		}

		/// <summary>
		/// Returns the smaller of its two arguments.
		/// <para />
		/// sig: Ord a => a -> a -> a
		/// </summary>
		/// <param name="a">first</param>
		/// <param name="b">second</param>
		/// <returns>*</returns>
		/// <see cref="R.MinBy"/>
		/// <see cref="R.Max"/>
		public static dynamic Min(RamdaPlaceholder a, string b) {
			return Currying.Min(a, b);
		}

		/// <summary>
		/// Returns the smaller of its two arguments.
		/// <para />
		/// sig: Ord a => a -> a -> a
		/// </summary>
		/// <param name="a">first</param>
		/// <param name="b">second</param>
		/// <returns>*</returns>
		/// <see cref="R.MinBy"/>
		/// <see cref="R.Max"/>
		public static dynamic Min(string a, RamdaPlaceholder b = null) {
			return Currying.Min(a, b);
		}
	}
}