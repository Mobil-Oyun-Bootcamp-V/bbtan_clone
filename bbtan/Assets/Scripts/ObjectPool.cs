using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool
{
    private Queue<GameObject> _queue;
    public void CreatePoolObjects(GameObject BaseGo,int size,Transform parent = null)
    {
        _queue = new Queue<GameObject>();

        for(int i = 0; i < size; i++)
        {
            GameObject GO;
            if (parent)
            {
                GO = GameObject.Instantiate(BaseGo, parent);
            }
            else
            {
                GO = GameObject.Instantiate(BaseGo);
            }
            GO.SetActive(false);
            _queue.Enqueue(GO);
        }
    }
    public GameObject GetGameObject()

    {
        GameObject GO = _queue.Dequeue();
        GO.SetActive(true);
        _queue.Enqueue(GO);
        return GO;
    }
}
