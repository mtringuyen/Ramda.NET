﻿// <autogenerated>
//   This file was generated by T4 code generator Always.tt.
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
		public static dynamic Always<TTarget>(TTarget val) {
			return Currying.Always(val);
		}
			
		public static dynamic Always<TTarget>(RamdaPlaceholder val = null) {
			return Currying.Always(val);
		}
	}
}