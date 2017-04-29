﻿// <autogenerated>
//   This file was generated by T4 code generator Join.tt.
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
		public static dynamic Join<TSource>(string separator, IList<TSource> xs) {
			return Currying.Join(separator, xs);
		}

		public static dynamic Join<TSource>(RamdaPlaceholder separator, IList<TSource> xs) {
			return Currying.Join(separator, xs);
		}

		public static dynamic Join(string separator, RamdaPlaceholder xs = null) {
			return Currying.Join(separator, xs);
		}

		public static dynamic Join(RamdaPlaceholder separator = null, RamdaPlaceholder xs = null) {
			return Currying.Join(separator, xs);
		}
	}
}