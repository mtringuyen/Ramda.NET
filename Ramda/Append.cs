﻿// <autogenerated>
//   This file was generated by T4 code generator Append.tt.
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
		public static dynamic Append<TSource>(TSource el, IList<TSource> list) {
			return Currying.Append(el, list);
		}
			
		public static dynamic Append<TSource>(RamdaPlaceholder el, IList<TSource> list) {
			return Currying.Append(el, list);
		}
			
		public static dynamic Append<TSource>(TSource el, RamdaPlaceholder list = null) {
			return Currying.Append(el, list);
		}
		
		public static dynamic Append<TSource>(RamdaPlaceholder el = null, RamdaPlaceholder list = null) {
			return Currying.Append(el, list);
		}
	}
}