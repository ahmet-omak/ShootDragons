using System.Collections.Generic;
using UnityEngine;

public abstract class GenericPoolManager<T> : MonoBehaviour where T:Component
{
    [SerializeField] T PoolObject;
    [SerializeField] int PoolObjectCount;

    Queue<T> poolObjects = new Queue<T>();
    private void Awake()
    {
        SingletonThisObject();
    }
    protected abstract void SingletonThisObject();

    private void Start()
    {
        InsertPoolObjectsToPool();
    }

    private void InsertPoolObjectsToPool()
    {
        for (int i = 0; i < PoolObjectCount; i++)
        {
            T newPoolObject = Instantiate(PoolObject,this.transform);
            newPoolObject.gameObject.SetActive(false);
            poolObjects.Enqueue(newPoolObject);
        }
    }

    public T GetPoolObject()
    {
        if (poolObjects.Count == 0)
        {
            InsertNewPoolObject();
        }
        return poolObjects.Dequeue();
    }

    private void InsertNewPoolObject()
    {
        for (int i = 0; i < PoolObjectCount; i++)
        {
            T newPoolObject = Instantiate(PoolObject,transform);
            newPoolObject.gameObject.SetActive(false);
            poolObjects.Enqueue(newPoolObject);
        }
    }

    public void SetPoolObject(T poolObject)
    {
        poolObject.gameObject.SetActive(false);
        poolObjects.Enqueue(poolObject);
    }

    public abstract void ResetPoolObjects();
}
