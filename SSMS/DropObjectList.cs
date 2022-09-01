using System;
using System.Collections.Generic;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using System.Collections;
using System.Linq;

namespace SSMS
{
    public class DropObjectList : IList<TSqlFragment>
    {
        private IList<TSqlFragment> _list = new List<TSqlFragment>();

        public TSqlFragment this[int index] { get => _list[index]; set => _list[index] = value; }

        // If the fragment type being added is the same as the current item (add checks end, insert checks position)
        // then check to see if the item has an Objects collection. If it does, add the items to the objects collection
        // If it doesn't, add a new primary item to the list

        public int Count => _list.Count;

        public bool IsReadOnly => _list.IsReadOnly;

        public void Insert(int index, TSqlFragment item)
        {
            Add(item, lookupFunction, (() => _list.Insert(index, item)));

            TSqlFragment lookupFunction() // Get the specified index if it exists, otherwise return null
            {
                if (index >= 0 & index < _list.Count)
                {
                    return _list[index];
                }
                return null;
            }
        }

        private void Add(TSqlFragment item, Func<TSqlFragment> itemRetrievalFunction, Action insertionProcIfNotFound)
        {
            if (item is DropObjectsStatement dropObjectsStatement)
            {
                if (itemRetrievalFunction() is DropObjectsStatement lastFragment)
                {
                    if (item.GetType().IsAssignableTo(lastFragment.GetType()))
                    {
                        foreach (var thisObject in dropObjectsStatement.Objects)
                        {
                            lastFragment.Objects.Insert(0, thisObject);
                        }
                        return;
                    }
                }
            }
            insertionProcIfNotFound();
        }
        public void Add(TSqlFragment item)
        {
            Add(item, (() => _list.LastOrDefault()), (() => _list.Add(item)));
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(TSqlFragment item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(TSqlFragment[] array, int arrayIndex)
        {
            _list.CopyTo(array, arrayIndex);
        }

        public IEnumerator<TSqlFragment> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        public int IndexOf(TSqlFragment item)
        {
            return _list.IndexOf(item);
        }

        public bool Remove(TSqlFragment item)
        {
            return _list.Remove(item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_list).GetEnumerator();
        }
    }
}
