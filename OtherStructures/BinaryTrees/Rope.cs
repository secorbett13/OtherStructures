// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Rope.cs" company="Scott Corbett">
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
//   Class implementation of the Rope data structure. The Rope data structure composed of 1 to n smaller strings
//   and allows for efficiently storing and manipulating them as a very large string.
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
		/// The string that will be converted to a character array for the root rope node.
		/// </param>
		public Rope(string rootString)
		{
			this.Value = rootString;
			this.Length = this.Value.Length;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Rope"/> class.
		/// </summary>
		/// <param name="rootValue">
		/// The root chars.
		/// </param>
		public Rope(char[] rootValue)
		{
			this.Value = new string(rootValue);
			this.Length = this.Value.Length;
		}

		/// <summary>
		/// Gets the character array for the current Rope. If the Rope has a "left" node, this field is null
		/// </summary>
		public string Value { get; private set; }

		/// <summary>
		/// Gets the cached length of the root characters.
		/// </summary>
		public int Length { get; private set; }

		/// <summary>
		/// Gets or sets the "left" <see cref="Rope"/> instance under the root.
		/// </summary>
		public Rope Left { get; set; }

		/// <summary>
		/// Gets or sets the next sibling.
		/// </summary>
		/// <remarks>
		/// The next sibling is analagous to the right node on a binary tree
		/// </remarks>
		public Rope NextSibling { get; set; }

		/// <summary>
		/// Gets the depth of the <see cref="Rope"/>. The depth is calculated as the count of contiguous left
		/// children nodes of the current <see cref="Rope"/>
		/// </summary>
		public int Depth 
		{
			get
			{
				return 1 + (this.Left != null ? this.Left.Depth : 0);
			}
		}

		/// <summary>
		/// Gets the width of the <see cref="Rope"/>. The width is calculated as the count of contiguous
		/// "next sibling" nodes for the current instance.
		/// </summary>
		public int Width
		{
			get
			{
				return 1 + (this.NextSibling != null ? this.NextSibling.Width : 0);
			}
		}

		/// <summary>
		/// Appends the provided character array to the end of the <see cref="Rope"/>.
		/// </summary>
		/// <param name="newChars">
		/// The new array of characters to be appended.
		/// </param>
		public void Append(char[] newChars)
		{
			this.Append(new string(newChars));
		}

		/// <summary>
		/// Appends the provided string to the end of the <see cref="Rope"/>.
		/// </summary>
		/// <param name="newString">
		/// The string of characters to be appended.
		/// </param>
		public void Append(string newString)
		{
			if (this.NextSibling != null)
			{
				this.NextSibling.Append(newString);
				return;
			}

			var newRope = new Rope(newString);
			var newLeft = new Rope(this.Value) { NextSibling = this.NextSibling };

			this.Left = newLeft;
			this.NextSibling = newRope;
			this.Value = null;
		}

		/// <summary>
		/// Finds the index of a particular character within this instance and all of it's children.
		/// </summary>
		/// <param name="c">
		/// The character to be found.
		/// </param>
		/// <returns>
		/// The index of the first instance of the requested character.
		/// </returns>
		public int IndexOf(char c)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Finds the index of a particular character within the <see cref="Rope"/> starting at the
		/// provided instance.
		/// </summary>
		/// <param name="c">
		/// The character to be found.
		/// </param>
		/// <param name="start">
		/// The start index. Ropes are considered to be "0 based" indexes.
		/// </param>
		/// <returns>
		/// The <see cref="int"/>.
		/// </returns>
		public int IndexOf(char c, int start)
		{
			throw new NotImplementedException();
		}

		// insert(int index, string newString)
		// insert(int index, char[] newArray)

		// delete
		// IndexOf(char c) => gets the first instance of...
		// Indexof(char c, int start) => gets the first instance of c starting at the provided index
		// ToString()
	}
}