// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RopeIndexOfCharTests.cs" company="Scott Corbett">
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
//   Defines the RopeIndexOfCharTests type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OtherStructures.Tests.BinaryTrees.RopeTests
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	using OtherStructures.BinaryTrees;

	/// <summary>
	/// Class containing tests to verify the <see cref="Rope.IndexOf(char)"/> and <see cref="Rope.IndexOf(char, int)"/>
	/// methods.
	/// </summary>
	[TestClass]
	public class RopeIndexOfCharTests
	{
		/// <summary>
		/// The index of returns location of first instance of char.
		/// </summary>
		[TestMethod]
		public void IndexOfReturnsLocationOfFirstInstanceOfChar()
		{
			// arrange
			var rope = new Rope("abc");
			rope.Append("def");
			rope.Append("ghi");

			// act
			var actual = rope.IndexOf('e');

			// assert
			Assert.AreEqual(4, actual);
		}
	}
}