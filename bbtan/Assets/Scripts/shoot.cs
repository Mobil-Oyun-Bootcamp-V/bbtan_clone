using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private int size;
    [SerializeField] private Transform parent;

    private void Start()
    {
        ObjectPool pool = new ObjectPool();
        pool.CreatePoolObjects(prefab, size);
    }
}
