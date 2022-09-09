using Microsoft.SqlServer.TransactSql.ScriptDom;
using System;
using Microsoft.SqlServer.TransactSql.ScriptDom.Versioning;
using System.Reflection;
using System.Reflection.Emit;
using System.Collections.Generic;


namespace SSMS
{
    public abstract class DependencyNode
    {
        protected IList<DependencyNode> _DependsOn;
        protected abstract object GetValue();
        public object Value { get => GetValue(); }
    }
    public class DependencyNode<T> : DependencyNode
    {
        public DependencyNode(T nodeObject) : this (nodeObject, () => new List<DependencyNode>()) { }
        public DependencyNode(T nodeObject, Func<List<DependencyNode>> listConstructor)
        {
            _Value = nodeObject;
            _DependsOn = listConstructor();
        }
        private T _Value;
        protected override object GetValue() => _Value;
        public new T Value { get => (T)_Value; }
    }

}