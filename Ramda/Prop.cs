﻿// <autogenerated>
//   This file was generated by T4 code generator Prop.tt.
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
		public static dynamic Prop<TTarget>(string p, TTarget obj) {
			return Currying.Prop(p, obj);
		}
		
		public static dynamic Prop<TTarget>(RamdaPlaceholder p, TTarget obj) {
			return Currying.Prop(p, obj); 
		}
		
		public static dynamic Prop<TTarget>(string p, RamdaPlaceholder obj = null) {
			return Currying.Prop(p, obj); 
		}
		
		public static dynamic Prop<TTarget>(RamdaPlaceholder p = null, RamdaPlaceholder obj = null) {
			return Currying.Prop(p, obj);
		}
	}
}