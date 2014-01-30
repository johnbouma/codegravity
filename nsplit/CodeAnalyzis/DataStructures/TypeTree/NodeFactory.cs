﻿#region usings

using System.Collections.Generic;

#endregion

namespace nsplit.CodeAnalyzis.DataStructures.TypeTree
{
    internal class NodeFactory
    {
        private readonly Stack<INode> m_Nodes;

        public NodeFactory()
        {
            m_Nodes =new Stack<INode>();
        }

        public int Count
        {
            get { return m_Nodes.Count; }
        }

        public IEnumerable<INode> Nodes
        {
            get { return m_Nodes; }
        }

        public Node CreateNode(string name, Node parent)
        {
            var node = new Node(name, Count, parent);
            m_Nodes.Push(node);
            return node;
        }

        public Leaf CreateLeaf(string name, Node parent)
        {
            var leaf = new Leaf(name, Count, parent);
            m_Nodes.Push(leaf);
            return leaf;
        }
    }
}