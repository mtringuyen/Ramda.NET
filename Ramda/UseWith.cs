﻿// <autogenerated>
//   This file was generated by T4 code generator UseWith.tt.
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
		public static dynamic UseWith<TSource>(Delegate fn, IList<TSource> transformers) {
			return Currying.UseWith(fn, transformers);
		}

		public static dynamic UseWith(dynamic fn, dynamic transformers) {
			return Currying.UseWith(fn, transformers); 
		}
					
		public static dynamic UseWith(RamdaPlaceholder fn, dynamic transformers) {
			return Currying.UseWith(fn, transformers);
		}
			
		public static dynamic UseWith<TSource>(RamdaPlaceholder fn, IList<TSource> transformers) {
			return Currying.UseWith(fn, transformers);
		}
					
		public static dynamic UseWith(dynamic fn, RamdaPlaceholder transformers = null) {
			return Currying.UseWith(fn, transformers);
		}
			
		public static dynamic UseWith<TSource>(Delegate fn, RamdaPlaceholder transformers = null) {
			return Currying.UseWith(fn, transformers);
		}
		
		public static dynamic UseWith<TSource>(RamdaPlaceholder fn = null, RamdaPlaceholder transformers = null) {
			return Currying.UseWith(fn, transformers);
		}
	}
}