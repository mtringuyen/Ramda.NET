﻿// <autogenerated>
//   This file was generated by T4 code generator Insert.tt.
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
		public static dynamic Insert<TSource>(int index, TSource elt, IList<TSource> list) {
			return Currying.Insert(index, elt, list);
		}
			
		public static dynamic Insert<TSource>(RamdaPlaceholder index, TSource elt, IList<TSource> list) {
			return Currying.Insert(index, elt, list);
		}
			
		public static dynamic Insert<TSource>(int index, RamdaPlaceholder elt, IList<TSource> list) {
			return Currying.Insert(index, elt, list);
		}
			
		public static dynamic Insert<TSource>(int index, TSource elt, RamdaPlaceholder list = null) {
			return Currying.Insert(index, elt, list);
		}
		
		public static dynamic Insert<TSource>(int index, RamdaPlaceholder elt = null, RamdaPlaceholder list = null) {
			return Currying.Insert(index, elt, list);
		}
		
		public static dynamic Insert<TSource>(RamdaPlaceholder index = null, RamdaPlaceholder elt = null, RamdaPlaceholder list = null) {
			return Currying.Insert(index, elt, list);
		}
	}
}