// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RopeDepthAndWidthTests.cs" company="Scott Corbett">
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
//   Defines the RopeDepthAndWidthTests type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OtherStructures.Tests.BinaryTrees.RopeTests
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	using OtherStructures.BinaryTrees;

	/// <summary>
	/// Class containing tests to verify the behavior of the <see cref="Rope.Depth"/> and <see cref="Rope.Width"/>
	/// properties.
	/// </summary>
	[TestClass]
	public class RopeDepthAndWidthTests
	{
		/// <summary>
		/// Verifies that the <see cref="Rope.Depth"/> return 1 when the target <see cref="Rope"/> doesn't have any
		/// "left" children.
		/// </summary>
		[TestMethod]
		public void DepthReturns0WhenNoLeftNodes()
		{
			// arrange
			var newRope = new Rope("test");

			// act
			var actual = newRope.Depth;

			// assert
			Assert.AreEqual(1, actual);
		}

		/// <summary>
		/// Verifies that the <see cref="Rope.Depth"/> return the count of "left" children for the <see cref="Rope"/>.
		/// </summary>
		[TestMethod]
		public void DepthReturnsCorrectValueWhenLeftNodesExist()
		{
			// arrange
			var rootRope = new Rope("root") { Left = new Rope("first") { Left = new Rope("second") } };

			// act
			var actual = rootRope.Depth;

			// assert
			Assert.AreEqual(3, actual);
		}

		/// <summary>
		/// Verifies that the <see cref="Rope.Width"/> return 1 when the target <see cref="Rope"/> doesn't have any
		/// "next siblings".
		/// </summary>
		[TestMethod]
		public void WidthReturns1WhenNoNextSiblings()
		{
			// arrange
			var newRope = new Rope("test");

			// act
			var actual = newRope.Width;

			// assert
			Assert.AreEqual(1, actual);
		}

		/// <summary>
		/// Verifies that the <see cref="Rope.Width"/> return the count of "next siblings" for the <see cref="Rope"/>.
		/// </summary>
		[TestMethod]
		public void WidthReturnsCorrectValueWhenNextSiblingsExist()
		{
			// arrange
			var rootRope = new Rope("root") { NextSibling = new Rope("first") { NextSibling = new Rope("second") } };

			// act
			var actual = rootRope.Width;

			// assert
			Assert.AreEqual(3, actual);
		}
	}
}