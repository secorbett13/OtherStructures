// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RopeAppendTests.cs" company="Scott Corbett">
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
//   Class containing tests to verify the behavior of the <see cref="Rope.Append(char[])" /> and <see cref="Rope.Append(string)" />
//   methods.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OtherStructures.Tests.BinaryTrees.RopeTests
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	using OtherStructures.BinaryTrees;

	/// <summary>
	/// Class containing tests to verify the behavior of the <see cref="Rope.Append(char[])"/> and <see cref="Rope.Append(string)"/>
	/// methods.
	/// </summary>
	[TestClass]
	public class RopeAppendTests
	{
		/// <summary>
		/// Verifies that <see cref="Rope.Append(char[])"/> correctly appends a <see cref="Rope"/> to a 
		/// <see cref="Rope"/> that does not have any child <see cref="Rope"/> entities.
		/// </summary>
		[TestMethod]
		public void AppendWithCharArrayPutsNewCharArrayAtEndOfRope()
		{
			// arrange
			var rootValue = "test".ToCharArray();
			var rootRope = new Rope(rootValue);
			var insertValue = "again".ToCharArray();

			// act
			rootRope.Append(insertValue);

			// assert
			CollectionAssert.AreEquivalent(rootValue, rootRope.Left.Value.ToCharArray());
			CollectionAssert.AreEquivalent(insertValue, rootRope.NextSibling.Value.ToCharArray());
			Assert.AreEqual(rootValue.Length, rootRope.Length);
		}

		/// <summary>
		/// Veirifies that <see cref="Rope.Append(char[])"/> sets the root rope of the chain to null
		/// when appending to a <see cref="Rope"/> with no child <see cref="Rope"/> entities.
		/// </summary>
		[TestMethod]
		public void AppendWithCharsNullsRootRopeChars()
		{
			// arrange
			var rootValue = "test".ToCharArray();
			var rootRope = new Rope(rootValue);
			var insertValue = "again".ToCharArray();

			// act
			rootRope.Append(insertValue);

			// assert
			Assert.IsNull(rootRope.Value);
		}

		/// <summary>
		/// Verifies that <see cref="Rope.Append(string)"/> correctly appends a <see cref="Rope"/> to a 
		/// <see cref="Rope"/> that does not have any child <see cref="Rope"/> entities.
		/// </summary>
		[TestMethod]
		public void AppendWithStringPutsNewCharArrayAtEndOfRope()
		{
			var rootValue = "test".ToCharArray();
			var rootRope = new Rope("test");
			const string InsertValue = "again";

			// act
			rootRope.Append(InsertValue);

			// assert
			CollectionAssert.AreEquivalent(rootValue, rootRope.Left.Value.ToCharArray());
			CollectionAssert.AreEquivalent(InsertValue.ToCharArray(), rootRope.NextSibling.Value.ToCharArray());
			Assert.AreEqual(rootValue.Length, rootRope.Length);
		}

		/// <summary>
		/// Verifies that the when <see cref="Rope.Append(char[])"/> is called against a <see cref="Rope"/>
		/// with child <see cref="Rope"/> entities that the new characters are placed at the end of the rope.
		/// </summary>
		[TestMethod]
		public void AppendPlacesNewCharsAtEndOfRope()
		{
			// arrange
			const string LastRopeChars = "end";
			var rootRope = new Rope("start");
			rootRope.Append("middle");

			// act
			rootRope.Append(LastRopeChars);

			// assert
			CollectionAssert.AreEquivalent(LastRopeChars.ToCharArray(), rootRope.NextSibling.NextSibling.Value.ToCharArray());
		}
	}
}
