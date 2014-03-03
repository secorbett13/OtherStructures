// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Queue.cs" company="Scott Corbett">
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
//   Defines the Queue type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OtherStructures.Collections
{
	using System.Collections.Generic;

	/// <summary>
	/// Class defining a queue type data structure. A queue implemments "First In, First Out" behavior for its elements.
	/// This means that the first item put into the queue will be the first item taken off out.
	/// </summary>
	/// <typeparam name="T">
	/// The type of entity making up the elements of the queue
	/// </typeparam>
	/// <remarks>
	/// This implementation should not be used for production code. The .NET framework provides an implementation of this
	/// class that is almost certainly a lot better than what's found here.
	/// </remarks>
	public class Queue<T> : IEnumerable<T>
	{
		/// <summary>
		/// The entities making up the queue
		/// </summary>
		private List<T> items;

		/// <summary>
		/// Initializes a new instance of the <see cref="Queue{T}"/> class.
		/// </summary>
		public Queue()
		{
			this.items = new List<T>();
		}
		
		// methods
		// Enqueue - adds an item to the end of the queue
		// Dequeue - gets the "head" of the queue, removes it from the list and returns it
		// Peek - gets the "head" of the queue and returns it without removing it
		// Count - length of the queue
		// Clear - empties the queue
		
		/// <summary>
		/// Enumerates each item in the stack in a FIFO order. The queue remains unaltered.
		/// </summary>
		/// <returns>
		/// The <see cref="IEnumerator{T}"/>.
		/// </returns>
		public IEnumerator<T> GetEnumerator()
		{
			return this.items.GetEnumerator();
		}

		/// <inheritdoc />
		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}
	}
}