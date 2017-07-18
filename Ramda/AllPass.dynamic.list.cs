﻿// <autogenerated>
//   This file was generated by T4 code generator AllPass.dynamic.list.tt.
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
		/// Takes a list of predicates and returns a predicate that returns true for agiven list of arguments if every one of the provided predicates is satisfiedby those arguments.The function returned is a curried function whose arity matches that of thehighest-arity predicate.
		/// <para />
		/// sig: [(*... -> Boolean)] -> (*... -> Boolean)
		/// </summary>
		/// <param name="predicates">An array of predicates to check</param>
		/// <returns>The combined predicate</returns>
		/// <see cref="R.AnyPass"/>
		public static dynamic AllPass(IList<dynamic> preds) {
			return Currying.AllPass(preds);
		}
	}
}