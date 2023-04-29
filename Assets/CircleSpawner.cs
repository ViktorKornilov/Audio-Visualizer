using System;
using UnityEngine;

public class CircleSpawner : MonoBehaviour
{
    public GameObject prefab;

    public int count = 12;
    public float distance = 5;
    
    private void Start()
    {
        var step = 360f / count;
        for (var angle = 0f; angle < 360f; angle += step)
        {
            var x = Mathf.Cos(angle * Mathf.Deg2Rad);
            var y = Mathf.Sin(angle * Mathf.Deg2Rad);

            var obj = Instantiate(prefab,transform);
            obj.transform.localPosition = new Vector3(x, y, 0) * distance;
            obj.transform.LookAt(transform);
        }
    }
}
