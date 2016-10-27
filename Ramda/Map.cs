﻿// <autogenerated>
//   This file was generated by T4 code generator Map.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ramda.NET
{
	public static partial class R
	{	
		public static dynamic Map<TSource, TReturn>(Func<TSource, TReturn> fn, IList<TSource> list) {
			return Currying.Map(fn, list);
		}

		public static dynamic Map<TSource>(RamdaPlaceholder fn, IList<TSource> list) {
			return Currying.Map(fn, list);
		}

		public static dynamic Map<TSource, TReturn>(Func<TSource, TReturn> fn, RamdaPlaceholder list = null) {
			return Currying.Map(fn, list);
		}

		public static dynamic Map(dynamic fn, RamdaPlaceholder list = null) {
			return Currying.Map(fn, list);
		}

		public static dynamic Map<TSource>(dynamic fn, IList<TSource> list) {
			return Currying.Map(fn, list);
		}

		public static dynamic Map(RamdaPlaceholder fn = null, RamdaPlaceholder list = null) {
			return Currying.Map(fn, list);
		}
	}
}