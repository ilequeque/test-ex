using System.Collections;

namespace MyListApp;

public class MyList<T>: IEnumerable<T>
{private readonly List<T> _items = new();

    public void Add(T item)
    {
        _items.Add(item);
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= _items.Count)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
            return _items[index];
        }
    }

    public int Count
    {
        get
        {
            return _items.Count;
        }
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= _items.Count)
        {
            throw new IndexOutOfRangeException("Index out of range");
        }
        _items.RemoveAt(index);
    }

    public IEnumerator<T> GetEnumerator()
    {
        return _items.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}