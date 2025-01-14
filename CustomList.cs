namespace MyCustomList;

public class MyList
{
    private int[] _array;
    public int Capacity { get; set; }
    public int Count { get; set; }

    public MyList()
    {
        _array = new int[10];
        Capacity = _array.Length;
        Count = 0;
    }

    public MyList(int length)
    {
        _array = new int[length];
        Capacity = length;
        Count = 0;
    }

    public MyList(int length, int element)
    {
        _array = new int[length];
        _array[0] = element;
        Capacity = length;
        Count = 1;
    }

    public void Veiwer()
    {
        for (int i = 0; i < _array.Length; i++)
        {
            Console.WriteLine(_array[i]);
        }
    }

    public void Add(int element)
    {
        if (Count >= Capacity)
        {
            Resize();
        }
        _array[Count] = element;
        Count++;
    }

    /*Реализовать перегрузку 3 следующих методов Add();*/

    public void Add(int[] elements)
    {
        if ((Count + elements.Length) >= Capacity)
        {
            ResizeMas(elements);
        }

        for (int i = 0; i < elements.Length; i++)
        {
            _array[Count++] = elements[i];
        }
        Capacity = _array.Length;
    }

    public void Add(int index, int element)
    {
        if (Count >= Capacity)
        {
            Resize();
        }
        int newLength = _array.Length;
        var newArray = new int[newLength];
        Array.Copy(_array, newArray, index);
        newArray[index] = element;
        Array.Copy(_array, index, newArray, index + 1, _array.Length - (index + 1));
        _array = newArray;
        Count++;
        Capacity = _array.Length;
    }

    public void Add(int index, int[] elements)
    {
        if ((Count + elements.Length) >= Capacity)
        {
            ResizeMas(elements);
        }
        int newLength = _array.Length;
        var newArray = new int[newLength];
        for (int i = 0; i < index; i++)
        {
            newArray[i] = _array[i];
        }
        for (int j = 0, k = index; j < elements.Length; j++, k++)
        {
            newArray[k] = elements[j];
        }

        for (int d = index, f = index + elements.Length; d < Count; d++, f++)
        {
            newArray[f] = _array[d];
        }
        _array = newArray;
        Count = Count + elements.Length;
        Capacity = _array.Length;
    }

    public int this[int index]
    {
        get
        {
            if (index >= Count || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            return _array[index];
        }
        set
        {
            if (index >= Count || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            _array[index] = value;
        }
    }

    private void Resize()
    {
        int newLength = _array.Length * 2;
        var newArray = new int[newLength];
        Array.Copy(_array, newArray, Count);
        _array = newArray;
    }

    private void ResizeMas(int[] elementsMas)
    {
        int newLength = (_array.Length + elementsMas.Length) * 2;
        var newArray = new int[newLength];
        Array.Copy(_array, newArray, Count);
        _array = newArray;
    }

}