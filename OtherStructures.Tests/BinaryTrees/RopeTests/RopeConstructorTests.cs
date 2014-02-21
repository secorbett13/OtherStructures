// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RopeConstructorTests.cs" company="Scott Corbett">
//   Copyright 2014, Scott Corbett. All rights reserved. More than likely the rights are going to be opened up. For now,
//   all users are entitled to use the code as long as they include this notice in the header of any files used directly.
//   Any compiled library made for Other Structures can be used free of charge. If the library is decompiled, the
//   copyright notice needs to be inserted into the header of the decompiled files.
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
