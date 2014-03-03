// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinkedList.cs" company="Scott Corbett">
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
//   Defines the LinkedList type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OtherStructures.Arrays
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	/// <summary>
	/// Implementation of a linked list structure. Linked lists are lists of a common type where each node connects
	/// to the following node via a pointer.
	/// </summary>
	/// <typeparam name="T">
	/// The type of entity being stored in the linked list
	/// </typeparam>
	/// <remarks>
	/// This implementation should not be used for production code. The .NET framework provides an implementation of this
	/// class that is almost certainly a lot better than what's found here.
	/// </remarks>
	public class LinkedList<T> : IEnumerable<T>
		where T : IEquatable<T>
	{
		/// <summary>
		/// Gets the first element in the linked list.
		/// </summary>
		public LinkedListNode<T> First { get; private set; }

		/// <summary>
		/// Gets the last element.
		/// </summary>
		public LinkedListNode<T> Last { get; private set; }

		/// <summary>
		/// Gets the number of items in the list.
		/// </summary>
		public int Count { get; private set; }

		/// <summary>
		/// Adds a new <see cref="LinkedListNode{T}"/> to the head of the linked list.
		/// </summary>
		/// <param name="entity">
		/// The entity to be added.
		/// </param>
		public void AddFront(T entity)
		{
			var newNode = new LinkedListNode<T>(entity) { Next = this.First };

			if (this.First == null)
			{
				this.First = newNode;
				this.Last = newNode;
			}
			else
			{
				newNode.Next = this.First;
				this.First = newNode;
			}

			this.Count++;
		}

		/// <summary>
		/// Adds a new <see cref="LinkedListNode{T}"/> to the end of the list.
		/// </summary>
		/// <param name="entity">
		/// The entity to be added.
		/// </param>
		public void AddEnd(T entity)
		{
			var newNode = new LinkedListNode<T>(entity);

			if (this.First == null)
			{
				this.First = newNode;
				this.First.Next = newNode;
			}
			else
			{
				this.Last.Next = newNode;
			}

			this.Last = newNode;

			this.Count++;
		}

		/// <summary>
		/// Removes the first element of the list. If there are no items in the list, nothing happens.
		/// </summary>
		public void RemoveFirst()
		{
			if (this.Count == 0)
			{
				return;
			}

			this.First = this.First.Next;
			this.Count--;

			if (this.Count == 0)
			{
				this.Last = null;
			}
		}

		/// <summary>
		/// Removes the last element in the list. If there are no items in the list, nothing happens.
		/// </summary>
		public void RemoveLast()
		{
			if (this.Count == 0)
			{
				return;
			}

			if (this.Count == 1)
			{
				this.First = null;
				this.Last = null;
			}
			else
			{
				var current = this.First;

				while (current.Next != this.Last)
				{
					current = current.Next;
				}

				current.Next = null;
				this.Last = current;
			}

			this.Count--;
		}

		public void Find(T entity)
		{
			throw new NotImplementedException();
		}


		/// <inheritdoc />
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			var current = this.First;

			while (current != null)
			{
				yield return current.Value;
				current = current.Next;
			}
		}

		/// <inheritdoc />
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<T>)this).GetEnumerator();
		}


		#region ICollection methods
		// Count is already implemented
		// public void Add(T entity)
		// public bool Contains(T entity)
		// public void CopyTo(T[] array, int arrayIndex)
		// public bool IsReadonly {get;}
		// public bool Remove(T entity)
		// public bool Clear()
		#endregion
	}

	public class LinkedListNode<TNode>
	{
		public LinkedListNode(TNode entity)
		{
			this.Value = entity;
		}

		public TNode Value { get; private set; }

		public LinkedListNode<TNode> Next { get; set; }
	}
}