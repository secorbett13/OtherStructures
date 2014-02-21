// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RopeAppendTests.cs" company="Scott Corbett">
//   Copyright 2014, Scott Corbett. All rights reserved. More than likely the rights are going to be opened up. For now,
//   all users are entitled to use the code as long as they include this notice in the header of any files used directly.
//   Any compiled library made for Other Structures can be used free of charge. If the library is decompiled, the
//   copyright notice needs to be inserted into the header of the decompiled files.
// </copyright>
// <summary>
//   Defines the RopeAppendTests type.
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
		/// Verifies that <see cref="Rope.Append(char[])"/> correctly appends a Rope to the target instance.
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
			CollectionAssert.AreEquivalent(rootValue, rootRope.Left.Chars);
			CollectionAssert.AreEquivalent(insertValue, rootRope.NextSibling.Chars);
			Assert.AreEqual(rootValue.Length, rootRope.Length);
		}

		/// <summary>
		/// Verifies that <see cref="Rope.Append(string)"/> correctly appends a Rope to the target instance.
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
			CollectionAssert.AreEquivalent(rootValue, rootRope.Left.Chars);
			CollectionAssert.AreEquivalent(InsertValue.ToCharArray(), rootRope.NextSibling.Chars);
			Assert.AreEqual(rootValue.Length, rootRope.Length);
		}
	}
}
