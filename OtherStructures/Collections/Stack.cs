// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Stack.cs" company="Scott Corbett">
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
//   Defines the Stack type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OtherStructures.Collections
{
	using System.Collections.Generic;

	/// <summary>
	/// Class defining a stack type data structure. A stack implemments "Last In, First Out" behavior for its elements.
	/// This means that the first item put onto the stack will be the last item taken off of the stack.
	/// </summary>
	/// <typeparam name="T">
	/// The type of entity making up the elements of the stack
	/// </typeparam>
	/// <remarks>
	/// This implementation should not be used for production code. The .NET framework provides an implementation of this
	/// class that is almost certainly a lot better than what's found here.
	/// </remarks>
	public class Stack<T> : IEnumerable<T>
	{
		/// <summary>
		/// The array of backing items for the stack.
		/// </summary>
		/// <remarks>
		/// The array is initialized to avoid special cases in the implementation code.
		/// </remarks>
		private T[] items = new T[0];

		/// <summary>
		/// The number of items currently stored in the array.
		/// </summary>
		private int size;

		// could use my LinkedList as a backer or the System.Collections.Generic.LinkedList. Alternatively, could use an array to back the stack. This would help with performance
		// count
		// push
		// pop
		// peek
		// clear

		/// <summary>
		/// Enumerates each item in the stack in a LIFO order. The stack remains unaltered.
		/// </summary>
		/// <returns>
		/// The <see cref="IEnumerator{T}"/>.
		/// </returns>
		public IEnumerator<T> GetEnumerator()
		{
			for (var i = this.size - 1; i >= 0; i--)
			{
				yield return this.items[i];
			}
		}

		/// <inheritdoc />
		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}
	}
}