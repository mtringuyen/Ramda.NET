﻿// <autogenerated>
//   This file was generated by T4 code generator Product.int.tt.
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
		/// Multiplies together all the elements of a list.
		/// <para />
		/// sig: [Number] -> Number
		/// </summary>
		/// <param name="list">An array of numbers</param>
		/// <returns>The product of all the numbers in the list.</returns>
		/// <see cref="R.Reduce"/>
		public static dynamic Product(IList<int> list) {
			return Currying.Product(list);
		}
	}
}