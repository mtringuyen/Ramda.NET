﻿// <autogenerated>
//   This file was generated by T4 code generator Add.double.tt.
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
		public static dynamic Add(double a, double b) {
			return Currying.Add(a, b);
		}
			
		public static dynamic Add(RamdaPlaceholder a, double b) {
			return Currying.Add(a, b);
		}
			
		public static dynamic Add(double a, RamdaPlaceholder b = null) {
			return Currying.Add(a, b);
		}
		
		public static dynamic Add(RamdaPlaceholder a = null, RamdaPlaceholder b = null) {
			return Currying.Add(a, b);
		}
	}
}