﻿using System;
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
		public static dynamic Reduce<TSource, TAccmulator, TReturn>(Func<TSource, TAccmulator, TReturn> fn, TAccmulator acc, IReducible list) {
			return Currying.Reduce(Delegate(fn), acc, list);
		}

		public static dynamic Reduce<TAccmulator>(RamdaPlaceholder fn, TAccmulator acc, IReducible list) {
			return Currying.Reduce(fn, acc, list);
		}

		public static dynamic Reduce<TSource, TAccmulator, TReturn>(Func<TSource, TAccmulator, TReturn> fn, RamdaPlaceholder acc, IReducible list) {
			return Currying.Reduce(Delegate(fn), acc, list);
		}
		public static dynamic Reduce(dynamic fn, RamdaPlaceholder acc, IReducible list) {
			return Currying.Reduce(Delegate(fn), acc, list);
		}

		public static dynamic Reduce<TAccmulator>(dynamic fn, TAccmulator acc, IReducible list) {
			return Currying.Reduce(Delegate(fn), acc, list);
		}
	}
}