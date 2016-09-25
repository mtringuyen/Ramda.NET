﻿// <autogenerated>
//   This file was generated by T4 code generator GroupWith.tt.
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
		public static dynamic GroupWith<TSource>(dynamic fn, IList<TSource> list) {
			return Currying.GroupWith(fn, list);
		}
			
		public static dynamic GroupWith<TSource>(Func<TSource, TSource, bool> fn, IList<TSource> list) {
			return Currying.GroupWith(fn, list);
		}
		
		public static dynamic GroupWith(dynamic fn, RamdaPlaceholder list = null) {
			return Currying.GroupWith(fn, list);
		}
		
		public static dynamic GroupWith<TSource>(RamdaPlaceholder fn, IList<TSource> list) {
			return Currying.GroupWith(fn, list); 
		}
		
		public static dynamic GroupWith<TSource>(Func<TSource, TSource, bool> fn, RamdaPlaceholder list = null) {
			return Currying.GroupWith(fn, list); 
		}
		
		public static dynamic GroupWith<TSource>(RamdaPlaceholder fn = null, RamdaPlaceholder list = null) {
			return Currying.GroupWith(fn, list);
		}
	}
}