﻿// <autogenerated>
//   This file was generated by T4 code generator Unfold.list..tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Dynamic;
using System.Collections;
using System.Threading.Tasks;
using static Ramda.NET.Currying;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ramda.NET
{
	public static partial class R
	{	
		public static dynamic Unfold(Func<int, dynamic> fn, IList<int> seed) {
			return Currying.Unfold(Delegate(fn), seed);
		}

		public static dynamic Unfold(RamdaPlaceholder fn, IList<int> seed) {
			return Currying.Unfold(fn, seed);
		}

		public static dynamic Unfold(dynamic fn, IList<int> seed) {
			return Currying.Unfold(Delegate(fn), seed);
		}
	}
}