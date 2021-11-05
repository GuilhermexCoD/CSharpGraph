using System.Collections;
using System.Collections.Generic;

public class Vertex<T>
{
    private T data;
    private string label;

    public Vertex(T data)
    {
        this.label = data.GetHashCode().ToString();
        this.data = data;
    }

    public Vertex(string label,T data)
    {
        this.label = label;
        this.data = data;
    }

    public T GetData()
    {
        return data;
    }

    public override string ToString()
    {
        return data.ToString();
    }
}
