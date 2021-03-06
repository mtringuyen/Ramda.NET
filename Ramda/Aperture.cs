﻿// <autogenerated>
//   This file was generated by T4 code generator Aperture.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
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
		/// <summary>
		/// Returns a new list, composed of n-tuples of consecutive elements If `n` isgreater than the length of the list, an empty list is returned.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: Number -> [a] -> [[a]]
		/// </summary>
		/// <param name="n">The size of the tuples to create</param>
		/// <param name="list">The list to split into `n`-length tuples</param>
		/// <returns>The resulting list of `n`-length tuples</returns>
		/// <see cref="R.Transduce"/>
		public static dynamic Aperture<TSource>(int n, IList<TSource> list) {
			return Currying.Aperture(n, list);
		}

		/// <summary>
		/// Returns a new list, composed of n-tuples of consecutive elements If `n` isgreater than the length of the list, an empty list is returned.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: Number -> [a] -> [[a]]
		/// </summary>
		/// <param name="n">The size of the tuples to create</param>
		/// <param name="list">The list to split into `n`-length tuples</param>
		/// <returns>The resulting list of `n`-length tuples</returns>
		/// <see cref="R.Transduce"/>
		public static dynamic Aperture<TSource>(RamdaPlaceholder n, IList<TSource> list) {
			return Currying.Aperture(n, list);
		}

		/// <summary>
		/// Returns a new list, composed of n-tuples of consecutive elements If `n` isgreater than the length of the list, an empty list is returned.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: Number -> [a] -> [[a]]
		/// </summary>
		/// <param name="n">The size of the tuples to create</param>
		/// <param name="list">The list to split into `n`-length tuples</param>
		/// <returns>The resulting list of `n`-length tuples</returns>
		/// <see cref="R.Transduce"/>
		public static dynamic Aperture(int n, RamdaPlaceholder list = null) {
			return Currying.Aperture(n, list);
		}

		/// <summary>
		/// Returns a new list, composed of n-tuples of consecutive elements If `n` isgreater than the length of the list, an empty list is returned.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: Number -> [a] -> [[a]]
		/// </summary>
		/// <param name="n">The size of the tuples to create</param>
		/// <param name="list">The list to split into `n`-length tuples</param>
		/// <returns>The resulting list of `n`-length tuples</returns>
		/// <see cref="R.Transduce"/>
		public static dynamic Aperture(RamdaPlaceholder n = null, RamdaPlaceholder list = null) {
			return Currying.Aperture(n, list);
		}
	}
}