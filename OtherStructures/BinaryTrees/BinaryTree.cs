// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BinaryTree.cs" company="Scott Corbett">
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
//   Defines the BinaryTree type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OtherStructures.BinaryTrees
{
	using System;
	using System.Collections.Generic;

	/// <summary>
	/// Implementation of a generic binary tree structure.
	/// </summary>
	/// <typeparam name="T">
	/// The type of entity stored in each node of the tree
	/// </typeparam>
	public class BinaryTree<T> : IEnumerable<T>
		where T : IComparable<T>
	{
		/// <summary>
		/// Gets the head or root node of the tree.
		/// </summary>
		public BinaryTreeNode<T> Head { get; private set; }

		public BinaryTreeNode<T> Find(BinaryTreeNode<T> node, T value)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Enumerates each item in the stack in a FIFO order. The queue remains unaltered.
		/// </summary>
		/// <returns>
		/// The <see cref="IEnumerator{T}"/>.
		/// </returns>
		public IEnumerator<T> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		/// <inheritdoc />
		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}
	}

	/// <summary>
	/// The binary tree node.
	/// </summary>
	/// <typeparam name="TNode">
	/// The type of entity encapsulated by the node
	/// </typeparam>
	public class BinaryTreeNode<TNode>
		where TNode : IComparable<TNode>
	{
		/// <summary>
		/// Gets the value of the entity stored in the node.
		/// </summary>
		public TNode Value { get; private set; }

		/// <summary>
		/// Gets or sets the parent <see cref="BinaryTreeNode{T}"/> of the current node.
		/// </summary>
		public BinaryTreeNode<TNode> Parent { get; set; } 

		/// <summary>
		/// Gets or sets the left child of the <see cref="BinaryTreeNode{T}"/>.
		/// </summary>
		public BinaryTreeNode<TNode> Left { get; set; }

		/// <summary>
		/// Gets or sets the right child of the <see cref="BinaryTreeNode{T}"/>.
		/// </summary>
		public BinaryTreeNode<TNode> Right { get; set; }
	}
}