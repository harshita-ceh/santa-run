using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPool<T>
{
    //hepls define object pool
    //generic interface
    T Pull();
    void Push(T t);
}
