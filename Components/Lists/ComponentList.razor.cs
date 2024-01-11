using System.Collections;
using Microsoft.AspNetCore.Components;

namespace EasyBlazor.Components.Lists;

public partial class ComponentList<T> : StateComponent, IEnumerable<T> where T: StateComponent
{
    [Parameter] public List<T> items { get; set; } = new();

    public int Count => items.Count;
    public int Length => items.Count;

    public T this[int index]
    {
        get => items[index];
        set
        {
            items[index] = value;
            this.Update();
        }
    }
    
    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    public IEnumerator<T> GetEnumerator()
    {
        return items.GetEnumerator();
    }

    public bool Exists(Predicate<T> elements) => items.Exists(elements);
    public bool Contains(T element) => items.Contains(element);
    public int? FindIndex(Predicate<T> elements) => items.FindIndex(elements);
    
    public void Add(T element)
    {
        items.Add(element);
        this.Update();
    }

    public void AddRange(IEnumerable<T> range)
    {
        items.AddRange(range);
        this.Update();
    }

    public void Insert(int index, T element)
    {
        items.Insert(index, element);
        this.Update();
    }

    public void Remove(T element)
    {
        items.Remove(element);
        this.Update();
    }

    public void RemoveAt(int index)
    {
        items.RemoveAt(index);
        this.Update();
    }

    public void Clear()
    {
        items.Clear();
        this.Update();
    }
    
    public static ComponentList<T> operator +(ComponentList<T> list, IEnumerable<T> value)
    {
        list.AddRange(value);
        return list;
    }
    
    public static ComponentList<T> operator +(ComponentList<T> list, T element)
    {
        list.Add(element);
        list.Update();
        return list;
    }
    
    public static ComponentList<T> operator -(ComponentList<T> list, T element)
    {
        list.Remove(element);
        list.Update();
        return list;
    }   
}