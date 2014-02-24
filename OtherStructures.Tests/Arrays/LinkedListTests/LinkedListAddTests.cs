// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinkedListAddTests.cs" company="Scott Corbett">
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
//   Defines the LinkedListAddTests type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OtherStructures.Tests.Arrays.LinkedListTests
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	using OtherStructures.Arrays;

	/// <summary>
	/// Class containing tests to verify the behavior of the <see cref="LinkedList{T}"/> "add" method
	/// </summary>
	[TestClass]
	public class LinkedListAddTests
	{
		/// <summary>
		/// Verifies that the <see cref="LinkedList{T}.AddFront"/> adds the item to the head of the list.
		/// </summary>
		[TestMethod]
		public void AddFrontInsertsItemAtEndOfList()
		{
			// arrange
			var list = new LinkedList<int>();

			// act
			list.AddFront(1);
			list.AddFront(2);

			// assert
			Assert.AreEqual(2, list.First.Value);
			Assert.AreEqual(2, list.Length);
		}

		/// <summary>
		/// Verifies that <see cref="LinkedList{T}.AddFront"/> sets <see cref="LinkedList{T}.Last"/> correctly
		/// when called on an empty list.
		/// </summary>
		[TestMethod]
		public void AddFrontSetsLastItem()
		{
			// arrange
			var list = new LinkedList<int>();

			// act
			list.AddFront(1);

			// assert
			Assert.AreEqual(1, list.Last.Value);
		}

		/// <summary>
		/// Verifies that the <see cref="LinkedList{T}.AddEnd"/> sets the <see cref="LinkedList{T}.First"/> instance
		/// properly.
		/// </summary>
		[TestMethod]
		public void AddEndOnEmptyListSetsFirstCorrectly()
		{
			// arrange
			var list = new LinkedList<int>();

			// act
			list.AddEnd(1);

			// assert
			Assert.AreEqual(1, list.First.Value);
		}

		/// <summary>
		/// Verifies that the <see cref="LinkedList{T}.AddEnd"/> adds the item to the tail of the list.
		/// </summary>
		[TestMethod]
		public void AddEndInsertsItemAtEndOfList()
		{
			var list = new LinkedList<int>();

			// act
			list.AddEnd(1);
			list.AddEnd(2);

			// assert
			Assert.AreEqual(2, list.Last.Value);
			Assert.AreEqual(2, list.Length);
		}
	}
}
