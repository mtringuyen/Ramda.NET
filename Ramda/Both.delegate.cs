﻿using System;

namespace Ramda.NET
{
    public static partial class R
    {
        // <summary>
        /// A function which calls the two provided functions and returns the `&&`of the results.It returns the result of the first function if it is false-y and the resultof the second function otherwise. Note that this is short-circuited,meaning that the second function will not be invoked if the first returns afalse-y value.In addition to functions, `R.both` also accepts any fantasy-land compatibleapplicative functor.
        /// <para />
        /// sig: (*... -> Boolean) -> (*... -> Boolean) -> (*... -> Boolean)
        /// </summary>
        /// <param name="f">A predicate</param>
        /// <param name="g">Another predicate</param>
        /// <returns>a function that applies its arguments to `f` and `g` and `&&`s their outputs together.</returns>
        /// <see cref="R.And"/>
        public static dynamic Both(Delegate f, Delegate g) {
            return Currying.Both(new DelegateDecorator(f), new DelegateDecorator(g));
        }

        // <summary>
        /// A function which calls the two provided functions and returns the `&&`of the results.It returns the result of the first function if it is false-y and the resultof the second function otherwise. Note that this is short-circuited,meaning that the second function will not be invoked if the first returns afalse-y value.In addition to functions, `R.both` also accepts any fantasy-land compatibleapplicative functor.
        /// <para />
        /// sig: (*... -> Boolean) -> (*... -> Boolean) -> (*... -> Boolean)
        /// </summary>
        /// <param name="f">A predicate</param>
        /// <param name="g">Another predicate</param>
        /// <returns>a function that applies its arguments to `f` and `g` and `&&`s their outputs together.</returns>
        /// <see cref="R.And"/>
        public static dynamic Both(dynamic f, Delegate g) {
            return Currying.Both(f, new DelegateDecorator(g));
        }

        // <summary>
        /// A function which calls the two provided functions and returns the `&&`of the results.It returns the result of the first function if it is false-y and the resultof the second function otherwise. Note that this is short-circuited,meaning that the second function will not be invoked if the first returns afalse-y value.In addition to functions, `R.both` also accepts any fantasy-land compatibleapplicative functor.
        /// <para />
        /// sig: (*... -> Boolean) -> (*... -> Boolean) -> (*... -> Boolean)
        /// </summary>
        /// <param name="f">A predicate</param>
        /// <param name="g">Another predicate</param>
        /// <returns>a function that applies its arguments to `f` and `g` and `&&`s their outputs together.</returns>
        /// <see cref="R.And"/>
        public static dynamic Both(Delegate f, dynamic g) {
            return Currying.Both(new DelegateDecorator(f), g);
        }
    }
}
