﻿// <autogenerated>
//   This file was generated by T4 code generator Into.object.tt.
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
		public static dynamic Into<TSource>(object acc, Func<ITransformer, ITransformer> xf, IList<TSource> list) {
			return Currying.Into(acc, xf, list);
		}

		public static dynamic Into<TSource>(object acc, RamdaPlaceholder xf, IList<TSource> list) {
			return Currying.Into(acc, xf, list);
		}

		public static dynamic Into(object acc, Func<ITransformer, ITransformer> xf, RamdaPlaceholder list = null) {
			return Currying.Into(acc, xf, list);
		}

		public static dynamic Into(object acc, RamdaPlaceholder xf = null, RamdaPlaceholder list = null) {
			return Currying.Into(acc, xf, list);
		}

		public static dynamic Into(object acc, dynamic xf, RamdaPlaceholder list = null) {
			return Currying.Into(acc, xf, list);
		}

		public static dynamic Into<TSource>(object acc, dynamic xf, IList<TSource> list) {
			return Currying.Into(acc, xf, list);
		}
	}
}