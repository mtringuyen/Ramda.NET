﻿// <autogenerated>
//   This file was generated by T4 code generator Filter.tt.
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
		public static dynamic Filter<TSource>(Func<TSource, bool> pred, IList<TSource> filterable) {
			return Currying.Filter(pred, filterable);
		}

		public static dynamic Filter<TSource>(RamdaPlaceholder pred, IList<TSource> filterable) {
			return Currying.Filter(pred, filterable);
		}

		public static dynamic Filter<TSource>(Func<TSource, bool> pred, RamdaPlaceholder filterable = null) {
			return Currying.Filter(pred, filterable);
		}

		public static dynamic Filter(dynamic pred, RamdaPlaceholder filterable = null) {
			return Currying.Filter(pred, filterable);
		}

		public static dynamic Filter<TSource>(dynamic pred, IList<TSource> filterable) {
			return Currying.Filter(pred, filterable);
		}

		public static dynamic Filter(RamdaPlaceholder pred = null, RamdaPlaceholder filterable = null) {
			return Currying.Filter(pred, filterable);
		}
	}
}