﻿// <autogenerated>
//   This file was generated by T4 code generator MaxBy.tt.
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
		public static dynamic MaxBy<TArg>(Func<TArg, TArg> f, TArg a, TArg b) {
			return Currying.MaxBy(f, a, b);
		}
			
		public static dynamic MaxBy<TArg>(RamdaPlaceholder f, TArg a, TArg b) {
			return Currying.MaxBy(f, a, b);
		}

		public static dynamic MaxBy<TArg>(dynamic f, TArg a, TArg b) {
			return Currying.MaxBy(f, a, b); 
		}
					
		public static dynamic MaxBy<TArg>(dynamic f, RamdaPlaceholder a, TArg b) {
			return Currying.MaxBy(f, a, b);
		}
			
		public static dynamic MaxBy<TArg>(Func<TArg, TArg> f, RamdaPlaceholder a, TArg b) {
			return Currying.MaxBy(f, a, b);
		}
					
		public static dynamic MaxBy<TArg>(dynamic f, TArg a, RamdaPlaceholder b = null) {
			return Currying.MaxBy(f, a, b);
		}
			
		public static dynamic MaxBy<TArg>(Func<TArg, TArg> f, TArg a, RamdaPlaceholder b = null) {
			return Currying.MaxBy(f, a, b);
		}
		
		public static dynamic MaxBy<TArg>(Func<TArg, TArg> f, RamdaPlaceholder a = null, RamdaPlaceholder b = null) {
			return Currying.MaxBy(f, a, b);
		}
		
		public static dynamic MaxBy<TArg>(RamdaPlaceholder f = null, RamdaPlaceholder a = null, RamdaPlaceholder b = null) {
			return Currying.MaxBy(f, a, b);
		}
	}
}