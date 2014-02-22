// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RopeConstructorTests.cs" company="Scott Corbett">
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
//   Class containing tests to verify the behavior of the <see cref="Rope" /> constructors.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OtherStructures.Tests.BinaryTrees.RopeTests
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	using OtherStructures.BinaryTrees;

	/// <summary>
	/// Class containing tests to verify the behavior of the <see cref="Rope"/> constructors.
	/// </summary>
	[TestClass]
	public class RopeConstructorTests
	{
		/// <summary>
		/// Verifies that <see cref="Rope(string)"/> properly sets the <see cref="Rope.Chars"/> and <see cref="Rope.Length"/> values
		/// correctly.
		/// </summary>
		[TestMethod]
		public void ConstructorSetsFieldsCorrectly()
		{
			// arrange
			const string RopeString = "testing";

			// act
			var actual = new Rope(RopeString);

			// assert
			CollectionAssert.AreEquivalent(RopeString.ToCharArray(), actual.Chars);
			Assert.AreEqual(RopeString.Length, actual.Length);
		}

		/// <summary>
		/// Verifies that <see cref="Rope(char[])"/> properly sets the <see cref="Rope.Chars"/> and <see cref="Rope.Length"/> values
		/// correctly.
		/// </summary>
		[TestMethod]
		public void ConstructorByCharArraySetsFieldsCorrectly()
		{
			// arrange
			var ropeString = "testing".ToCharArray();

			// act
			var actual = new Rope(ropeString);

			// assert
			CollectionAssert.AreEquivalent(ropeString, actual.Chars);
			Assert.AreEqual(ropeString.Length, actual.Length);
		}
	}
}
