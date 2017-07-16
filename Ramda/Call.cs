﻿// <autogenerated>
//   This file was generated by T4 code generator Call.tt.
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
		/// <summary>
		/// Returns the result of calling its first argument with the remainingarguments. This is occasionally useful as a converging function for`R.converge`: the left branch can produce a function while the right branchproduces a value to be passed to that function as an argument.
		/// <para />
		/// sig: (*... -> a),*... -> a
		/// </summary>
		/// <param name="fn">The function to apply to the remaining arguments.</param>
		/// <param name="args">Any number of positional arguments.</param>
		/// <returns>*</returns>
		/// <see cref="R.Apply"/>
		public static dynamic Call(Delegate fn, params object[] args) {
			return Currying.Call(Delegate(fn), args);
		}

		/// <summary>
		/// Returns the result of calling its first argument with the remainingarguments. This is occasionally useful as a converging function for`R.converge`: the left branch can produce a function while the right branchproduces a value to be passed to that function as an argument.
		/// <para />
		/// sig: (*... -> a),*... -> a
		/// </summary>
		/// <param name="fn">The function to apply to the remaining arguments.</param>
		/// <param name="args">Any number of positional arguments.</param>
		/// <returns>*</returns>
		/// <see cref="R.Apply"/>
		public static dynamic Call(RamdaPlaceholder fn, params object[] args) {
			return Currying.Call(fn, args);
		}

		/// <summary>
		/// Returns the result of calling its first argument with the remainingarguments. This is occasionally useful as a converging function for`R.converge`: the left branch can produce a function while the right branchproduces a value to be passed to that function as an argument.
		/// <para />
		/// sig: (*... -> a),*... -> a
		/// </summary>
		/// <param name="fn">The function to apply to the remaining arguments.</param>
		/// <param name="args">Any number of positional arguments.</param>
		/// <returns>*</returns>
		/// <see cref="R.Apply"/>
		public static dynamic Call(Delegate fn, RamdaPlaceholder args = null) {
			return Currying.Call(Delegate(fn), args);
		}

		/// <summary>
		/// Returns the result of calling its first argument with the remainingarguments. This is occasionally useful as a converging function for`R.converge`: the left branch can produce a function while the right branchproduces a value to be passed to that function as an argument.
		/// <para />
		/// sig: (*... -> a),*... -> a
		/// </summary>
		/// <param name="fn">The function to apply to the remaining arguments.</param>
		/// <param name="args">Any number of positional arguments.</param>
		/// <returns>*</returns>
		/// <see cref="R.Apply"/>
		public static dynamic Call(dynamic fn, RamdaPlaceholder args = null) {
			return Currying.Call(Delegate(fn), args);
		}

		/// <summary>
		/// Returns the result of calling its first argument with the remainingarguments. This is occasionally useful as a converging function for`R.converge`: the left branch can produce a function while the right branchproduces a value to be passed to that function as an argument.
		/// <para />
		/// sig: (*... -> a),*... -> a
		/// </summary>
		/// <param name="fn">The function to apply to the remaining arguments.</param>
		/// <param name="args">Any number of positional arguments.</param>
		/// <returns>*</returns>
		/// <see cref="R.Apply"/>
		public static dynamic Call(dynamic fn, params object[] args) {
			return Currying.Call(Delegate(fn), args);
		}

		/// <summary>
		/// Returns the result of calling its first argument with the remainingarguments. This is occasionally useful as a converging function for`R.converge`: the left branch can produce a function while the right branchproduces a value to be passed to that function as an argument.
		/// <para />
		/// sig: (*... -> a),*... -> a
		/// </summary>
		/// <param name="fn">The function to apply to the remaining arguments.</param>
		/// <param name="args">Any number of positional arguments.</param>
		/// <returns>*</returns>
		/// <see cref="R.Apply"/>
		public static dynamic Call(RamdaPlaceholder fn = null, RamdaPlaceholder args = null) {
			return Currying.Call(fn, args);
		}
	}
}