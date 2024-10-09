using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildGraph : MonoBehaviour
{
    [SerializeField] private Transform prefab;

    // Start is called before the first frame update
    void Start()
    {
        GameObject container = new GameObject("Graph");
        for(int i = 0; i < 100; i++)
        {
            var point = Instantiate(prefab, Vector3.zero, Quaternion.identity, container.transform);
            var position = Vector3.zero;
            position.x = (i + 0.5f) - 1f;
            position.y = i;
            point.transform.position = position;
        }   
    }
}
