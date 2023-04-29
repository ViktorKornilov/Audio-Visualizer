using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereDancer : MonoBehaviour
{
    private void Start()
    {
        var visualizer = FindObjectOfType<AudioVisualizer>();
        visualizer.onAnalyzed.AddListener(Dance);
    }

    void Dance(float average)
    {
        transform.localPosition = -transform.forward * average * 10f;
    }
}
