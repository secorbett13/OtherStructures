// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Rope.cs" company="Scott Corbett">
//   Copyright 2014, Scott Corbett. All rights reserved. More than likely the rights are going to be opened up. For now,
//   all users are entitled to use the code as long as they include this notice in the header of any files used directly.
//   Any compiled library made for Other Structures can be used free of charge. If the library is decompiled, the
//   copyright notice needs to be inserted into the header of the decompiled files.
// </copyright>
// <summary>
//   Defines the Rope type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OtherStructures.BinaryTrees
{
	using System;

	/// <summary>
	/// Class implementation of the Rope data structure. The Rope data structure composed of 1 to n smaller strings
	/// and allows for efficiently storing and manipulating them as a very large string.
	/// </summary>
	/// <remarks>
	/// See http://en.wikipedia.org/wiki/Rope_(computer_science) for more information
	/// </remarks>
	public class Rope
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Rope"/> class.
		/// </summary>
		/// <param name="rootString">
		/// The root string.
		/// </param>
		public Rope(string rootString)
		{
			this.Chars = rootString.ToCharArray();
			this.Length = this.Chars.Length;
		}

		/// <summary>
		/// Gets the character array for the current Rope. If the Rope has a "left" node, this field is null
		/// </summary>
		public char[] Chars { get; private set; }

		/// <summary>
		/// Gets the cached length of the root characters.
		/// </summary>
		public int Length { get; private set; }

		// insert(int index, string newString)
		// insert(int index, char[] newArray)
		// append(string)
		// prepend(string)
		// delete
		// IndexOf(char c) => gets the first instance of...
		// Indexof(char c, int start) => gets the first instance of c starting at the provided index
		// ToString()

		public int IndexOf(char c)
		{
			throw new NotImplementedException();
		}

		private class Node
		{
			private char[] chars;

			public Node(string rootString)
			{
				this.chars = rootString.ToCharArray();
			}

			public Node(char[] rootChars)
			{
				this.chars = rootChars;
				this.NodeLength = this.chars.Length;
			}

			public int NodeLength { get; private set; }

			public Node Left { get; set; }

			public Node Sibling { get; set; }
		}
	}
}