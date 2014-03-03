// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinkedListGetEnumeratorTests.cs" company="Scott Corbett">
//   Copyright (c) 2014, Scott Corbett
//   
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//   of this software and associated documentation files (the "Software"), to deal
//   in the Software without restriction, including without limitation the rights
//   to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//   copies of the Software, and to permit persons to whom the Software is
//   furnished to do so, subject to the following conditions:
//   
//   The above copyright notice and this permission notice shall be included in
//   all copies or substantial portions of the Software.
//   
//   THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//   INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A
//   PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
//   HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
//   OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
//   SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// </copyright>
// <summary>
//   Defines the LinkedListGetEnumeratorTests type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OtherStructures.Tests.Arrays.LinkedListTests
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	using OtherStructures.Arrays;
	using OtherStructures.Collections;

	/// <summary>
	/// Class containing tests to verify the behavior of the <see cref="LinkedList{T}.GetEnumerator"/> method.
	/// </summary>
	[TestClass]
	public class LinkedListGetEnumeratorTests
	{
		/// <summary>
		/// The object against which the tests will be run.
		/// </summary>
		private LinkedList<int> testObject;

		/// <summary>
		/// Initializes objects used during the execution of the test.
		/// </summary>
		[TestInitialize]
		public void TestInitialize()
		{
			this.testObject = new LinkedList<int>();
		}
		
		/// <summary>
		/// Verifies that the method under test returns the expected result.
		/// </summary>
		[TestMethod]
		public void GetEnumeratorReturnsExpectedResult()
		{
			// arrange
			var expected = new[] { 1, 10, 100 };
			var actual = new int[3];

			this.testObject.AddFront(expected[0]);
			this.testObject.AddFront(expected[1]);
			this.testObject.AddFront(expected[2]);

			// act
			var count = 0;
			foreach (var i in this.testObject)
			{
				actual[count++] = i;
			}

			// assert
			CollectionAssert.AreEquivalent(expected, actual);
		}
	}
}
