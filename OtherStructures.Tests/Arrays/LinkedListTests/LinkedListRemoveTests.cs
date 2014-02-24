// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinkedListRemoveTests.cs" company="Scott Corbett">
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
//   Defines the LinkedListRemoveTests type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OtherStructures.Tests.Arrays.LinkedListTests
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	using OtherStructures.Arrays;

	/// <summary>
	/// Class containing tests to verify the behavior of the <see cref="LinkedList{T}"/> "remove" methods.
	/// </summary>
	[TestClass]
	public class LinkedListRemoveTests
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
		/// Verifies that the <see cref="LinkedList{T}.RemoveFirst"/> method removes the first element of the list
		/// and decrements the count.
		/// </summary>
		[TestMethod]
		public void RemoveFirstRemovesFirstItemFromList()
		{
			// arrange
			this.testObject.AddFront(1);
			this.testObject.AddFront(2);

			// act
			var startHeadVal = this.testObject.First.Value;
			var startCount = this.testObject.Count;

			this.testObject.RemoveFirst();

			var endHeadVal = this.testObject.First.Value;
			var endCount = this.testObject.Count;

			// assert
			Assert.AreEqual(2, startHeadVal, "startHeadVal");
			Assert.AreEqual(2, startCount, "startCount");
			Assert.AreEqual(1, endHeadVal, "endHeadVal");
			Assert.AreEqual(1, endCount, "endCount");
		}

		/// <summary>
		/// Verifies that the <see cref="LinkedList{T}.RemoveFirst"/> method sets the <see cref="LinkedList{T}.First"/>
		/// and <see cref="LinkedList{T}.Last"/> pointers to null when removing the last item
		/// </summary>
		[TestMethod]
		public void RemoveFirstOnLengthOneListSetsNullPointers()
		{
			// arrange
			this.testObject.AddFront(1);

			// act
			var startHasFirst = this.testObject.First != null;
			var startHasLast = this.testObject.Last != null;
			this.testObject.RemoveFirst();
			var endHasFirst = this.testObject.First == null;
			var endHasLast = this.testObject.Last == null;

			// assert
			Assert.IsTrue(startHasFirst);
			Assert.IsTrue(startHasLast);
			Assert.IsTrue(endHasFirst);
			Assert.IsTrue(endHasLast);
		}

		/// <summary>
		/// Verifies that the <see cref="LinkedList{T}.RemoveLast"/> method removes the last element of the list
		/// and decrements the count.
		/// </summary>
		[TestMethod]
		public void RemoveLastRemovesLastItemFromList()
		{
			// arrange
			this.testObject.AddFront(1);
			this.testObject.AddFront(2);
			var expectedStartLast = this.testObject.Last;
			var expectedEndLast = this.testObject.First;

			// act
			var startLastVal = this.testObject.Last;
			var startCount = this.testObject.Count;

			this.testObject.RemoveLast();

			var endLastVal = this.testObject.Last;
			var endCount = this.testObject.Count;

			// assert
			Assert.AreEqual(expectedStartLast, startLastVal, "startLastVal");
			Assert.AreEqual(2, startCount, "startCount");
			Assert.AreEqual(expectedEndLast, endLastVal, "endLastVal");
			Assert.AreEqual(1, endCount, "endCount");
		}
	}
}
