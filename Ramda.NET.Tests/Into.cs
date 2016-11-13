﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Dynamic;
using System.Collections.Generic;

namespace Ramda.NET.Tests
{
    [TestClass]
    public class Into
    {
        private Func<int, bool> isOdd = b => b % 2 == 1;

        public class AddXfTransformer : ITransformer
        {
            public object Init() => R.Always(0);

            public object Result(object result) => R.Identity(R.__);

            public object Step(object result, object input) => R.Add(R.__);
        }

        [TestMethod]
        public void Into_Transduces_Into_Arrays() {
            var res1 = (double[])R.Into(new object[0], R.Map(R.Add(1)), new[] { 1, 2, 3, 4 });
            var res2 = (int[])R.Into(new object[0], R.Filter(isOdd), new[] { 1, 2, 3, 4 });

            CollectionAssert.AreEqual(res1, new double[] { 2, 3, 4, 5 });
            CollectionAssert.AreEqual(res2, new[] { 1, 3 });
            //Assert.AreEqual(R.Into(new object[0], R.Compose(R.Map(R.Add(1)), R.Take(2)), new[] { 1, 2, 3, 4 }), new[] { 2, 3 });
        }

        [TestMethod]
        public void Into_Transduces_Into_Strings() {
            Assert.AreEqual((string)R.Into(string.Empty, R.Map(R.Add(1)), new[] { 1, 2, 3, 4 }), "2345");
            Assert.AreEqual((string)R.Into(string.Empty, R.Filter(isOdd), new[] { 1, 2, 3, 4 }), "13");
            //Assert.AreEqual(R.Into(string.Empty, R.Compose(R.Map(R.Add(1)), R.Take(2)), new[] { '2', '3', '4' }), new[] { '2', '3' });
        }

        [TestMethod]
        public void Into_Transduces_Into_Objects() {
            var expected = new Dictionary<string, object> {
                ["a"] = 1,
                ["b"] = 2
            };

            IDictionary<string, object> traget = R.Into(new ExpandoObject(), new Func<object, dynamic>(R.Identity), new object[] { new object[] { "a", 1 }, new object[] { "b", 2 } });

            CollectionAssert.AreEqual(new Dictionary<string, object>(traget), expected);

            expected.Add("c", 3);
            traget = R.Into(new ExpandoObject(), new Func<object, dynamic>(R.Identity), new object[] { new { a = 1 }, new { b = 2 }, new { c = 3 } });

            CollectionAssert.AreEqual(new Dictionary<string, object>(traget), expected);
        }

        [TestMethod]
        public void Into_Dispatches_To_Objects_That_Implement_Reduce() {
            var obj = new {
                x = new[] { 1, 2, 3 },
                Reduce = new Func<string>(() => "override")
            };

            Assert.AreEqual(R.Into(new object[0], R.Map(R.Add(1)), obj), "override");
            Assert.AreEqual(R.Into(new object[0], R.Filter(isOdd), obj), "override");
        }

        [TestMethod]
        public void Into_Is_Curried() {
            var intoArray = R.Into(new object[0]);
            var add2 = R.Map(R.Add(2));
            var result = intoArray(add2);
            var res = (double[])result(new[] { 1, 2, 3, 4 });

            CollectionAssert.AreEqual(res, new double[] { 3, 4, 5, 6 });
        }

        [TestMethod]
        public void Into_Allows_Custom_Transformer() {
            var intoSum = R.Into(new AddXfTransformer());
            var add2 = R.Map(R.Add(2));
            var result = intoSum(add2);

            Assert.AreEqual(result(new[] { 1, 2, 3, 4 }), 18);
        }

        [TestMethod]
        public void Into_Correctly_Reports_The_Arity_Of_Curried_Versions() {
            var sum = R.Into(new object[0], R.Map(new Func<int, int, dynamic>(R.Add)));

            Assert.AreEqual((int)sum.Length, 1);
        }
    }
}
