﻿// <autogenerated>
//   This file was generated by T4 code generator Juxt.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Dynamic;
using System.Collections;
using static Ramda.NET.Currying;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ramda.NET
{
	public static partial class R
	{	
		public static dynamic Juxt<TSource, TResult>(IList<Func<TSource, TResult>> fns) {
			return Currying.Juxt(fns);
		}

		public static dynamic Juxt(RamdaPlaceholder fns = null) {
			return Currying.Juxt(fns);
		}
	}
}