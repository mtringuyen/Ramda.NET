﻿// <autogenerated>
//   This file was generated by T4 code generator Insert.source.tartget.tt.
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
		/// Inserts the supplied element into the list, at index `index`. _Note thatthis is not destructive_: it returns a copy of the list with the changes.<![CDATA[<]]>small<![CDATA[>]]>No lists have been harmed in the application of this function.<![CDATA[<]]>/small<![CDATA[>]]>
		/// <para />
		/// sig: Number -> a -> [a] -> [a]
		/// </summary>
		/// <param name="index">The position to insert the element</param>
		/// <param name="elt">The element to insert into the Array</param>
		/// <param name="list">The list to insert into</param>
		/// <returns>A new Array with `elt` inserted at `index`.</returns>
		public static dynamic Insert<TSource, TTarget>(int index, TTarget elt, IList<TSource> list) {
			return Currying.Insert(index, elt, list);
		}

		/// <summary>
		/// Inserts the supplied element into the list, at index `index`. _Note thatthis is not destructive_: it returns a copy of the list with the changes.<![CDATA[<]]>small<![CDATA[>]]>No lists have been harmed in the application of this function.<![CDATA[<]]>/small<![CDATA[>]]>
		/// <para />
		/// sig: Number -> a -> [a] -> [a]
		/// </summary>
		/// <param name="index">The position to insert the element</param>
		/// <param name="elt">The element to insert into the Array</param>
		/// <param name="list">The list to insert into</param>
		/// <returns>A new Array with `elt` inserted at `index`.</returns>
		public static dynamic Insert<TSource, TTarget>(RamdaPlaceholder index, TTarget elt, IList<TSource> list) {
			return Currying.Insert(index, elt, list);
		}

		/// <summary>
		/// Inserts the supplied element into the list, at index `index`. _Note thatthis is not destructive_: it returns a copy of the list with the changes.<![CDATA[<]]>small<![CDATA[>]]>No lists have been harmed in the application of this function.<![CDATA[<]]>/small<![CDATA[>]]>
		/// <para />
		/// sig: Number -> a -> [a] -> [a]
		/// </summary>
		/// <param name="index">The position to insert the element</param>
		/// <param name="elt">The element to insert into the Array</param>
		/// <param name="list">The list to insert into</param>
		/// <returns>A new Array with `elt` inserted at `index`.</returns>
		public static dynamic Insert<TSource, TTarget>(int index, RamdaPlaceholder elt, IList<TSource> list) {
			return Currying.Insert(index, elt, list);
		}

		/// <summary>
		/// Inserts the supplied element into the list, at index `index`. _Note thatthis is not destructive_: it returns a copy of the list with the changes.<![CDATA[<]]>small<![CDATA[>]]>No lists have been harmed in the application of this function.<![CDATA[<]]>/small<![CDATA[>]]>
		/// <para />
		/// sig: Number -> a -> [a] -> [a]
		/// </summary>
		/// <param name="index">The position to insert the element</param>
		/// <param name="elt">The element to insert into the Array</param>
		/// <param name="list">The list to insert into</param>
		/// <returns>A new Array with `elt` inserted at `index`.</returns>
		public static dynamic Insert<TSource, TTarget>(int index, TTarget elt, RamdaPlaceholder list = null) {
			return Currying.Insert(index, elt, list);
		}

		/// <summary>
		/// Inserts the supplied element into the list, at index `index`. _Note thatthis is not destructive_: it returns a copy of the list with the changes.<![CDATA[<]]>small<![CDATA[>]]>No lists have been harmed in the application of this function.<![CDATA[<]]>/small<![CDATA[>]]>
		/// <para />
		/// sig: Number -> a -> [a] -> [a]
		/// </summary>
		/// <param name="index">The position to insert the element</param>
		/// <param name="elt">The element to insert into the Array</param>
		/// <param name="list">The list to insert into</param>
		/// <returns>A new Array with `elt` inserted at `index`.</returns>
		public static dynamic Insert<TSource, TTarget>(int index, RamdaPlaceholder elt = null, RamdaPlaceholder list = null) {
			return Currying.Insert(index, elt, list);
		}
	}
}