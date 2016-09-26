﻿// <autogenerated>
//   This file was generated by T4 code generator PropSatisfies.tt.
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
		public static dynamic PropSatisfies<TArg, TTarget>(Func<TArg, bool> pred, string name, TTarget obj) {
			return Currying.PropSatisfies(pred, name, obj);
		}
			
		public static dynamic PropSatisfies<TArg, TTarget>(RamdaPlaceholder pred, string name, TTarget obj) {
			return Currying.PropSatisfies(pred, name, obj);
		}

		public static dynamic PropSatisfies<TTarget>(dynamic pred, string name, TTarget obj) {
			return Currying.PropSatisfies(pred, name, obj); 
		}
					
		public static dynamic PropSatisfies<TTarget>(dynamic pred, RamdaPlaceholder name, TTarget obj) {
			return Currying.PropSatisfies(pred, name, obj);
		}
			
		public static dynamic PropSatisfies<TArg, TTarget>(Func<TArg, bool> pred, RamdaPlaceholder name, TTarget obj) {
			return Currying.PropSatisfies(pred, name, obj);
		}
					
		public static dynamic PropSatisfies(dynamic pred, string name, RamdaPlaceholder obj = null) {
			return Currying.PropSatisfies(pred, name, obj);
		}
			
		public static dynamic PropSatisfies<TArg, TTarget>(Func<TArg, bool> pred, string name, RamdaPlaceholder obj = null) {
			return Currying.PropSatisfies(pred, name, obj);
		}
		
		public static dynamic PropSatisfies<TArg, TTarget>(Func<TArg, bool> pred, RamdaPlaceholder name = null, RamdaPlaceholder obj = null) {
			return Currying.PropSatisfies(pred, name, obj);
		}
		
		public static dynamic PropSatisfies<TArg, TTarget>(RamdaPlaceholder pred = null, RamdaPlaceholder name = null, RamdaPlaceholder obj = null) {
			return Currying.PropSatisfies(pred, name, obj);
		}
	}
}