﻿// <autogenerated>
//   This file was generated by T4 code generator DropLast.tt.
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
		public static dynamic DropLast<TSource>(int n, IEnumerable<TSource> xs) {
			return Currying.DropLast(n, xs);
		}

		public static dynamic DropLast<TSource>(RamdaPlaceholder n, IEnumerable<TSource> xs) {
			return Currying.DropLast(n, xs);
		}

		public static dynamic DropLast(int n, RamdaPlaceholder xs = null) {
			return Currying.DropLast(n, xs);
		}

		public static dynamic DropLast(RamdaPlaceholder n = null, RamdaPlaceholder xs = null) {
			return Currying.DropLast(n, xs);
		}
	}
}