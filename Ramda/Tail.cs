﻿// <autogenerated>
//   This file was generated by T4 code generator Tail.tt.
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
		public static dynamic Tail<TValue>(IList<TValue> list) {
			return Currying.Tail(list);
		}
			
		public static dynamic Tail<TValue>(RamdaPlaceholder list = null) {
			return Currying.Tail(list);
		}
	}
}