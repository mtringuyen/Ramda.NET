﻿// <autogenerated>
//   This file was generated by T4 code generator Range.tt.
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
		public static dynamic Range(int from, int to) {
			return Currying.Range(from, to);
		}
			
		public static dynamic Range(RamdaPlaceholder from, int to) {
			return Currying.Range(from, to);
		}
			
		public static dynamic Range(int from, RamdaPlaceholder to = null) {
			return Currying.Range(from, to);
		}
		
		public static dynamic Range(RamdaPlaceholder from = null, RamdaPlaceholder to = null) {
			return Currying.Range(from, to);
		}
	}
}