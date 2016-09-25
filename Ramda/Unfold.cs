﻿// <autogenerated>
//   This file was generated by T4 code generator Unfold.tt.
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
		public static dynamic Unfold(dynamic fn, int seed) {
			return Currying.Unfold(fn, seed);
		}
			
		public static dynamic Unfold(Func<int, dynamic> fn, int seed) {
			return Currying.Unfold(fn, seed);
		}
		
		public static dynamic Unfold(dynamic fn, RamdaPlaceholder seed = null) {
			return Currying.Unfold(fn, seed);
		}
		
		public static dynamic Unfold(RamdaPlaceholder fn, int seed) {
			return Currying.Unfold(fn, seed); 
		}
		
		public static dynamic Unfold(Func<int, dynamic> fn, RamdaPlaceholder seed = null) {
			return Currying.Unfold(fn, seed); 
		}
		
		public static dynamic Unfold(RamdaPlaceholder fn = null, RamdaPlaceholder seed = null) {
			return Currying.Unfold(fn, seed);
		}
	}
}