using System;
using UnityEngine;

public class AudioVisualizer : MonoBehaviour
{
    private AudioSource source;
    public float size = 5;
    public float power = 2;
    public float shrinkSpeed = 3;

    private float currentPoint;
    
    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    private void Update()
    {
        float[] samples = new float[733];
        source.clip.GetData(samples,source.timeSamples);

        float sum = 0;
        foreach (var sample in samples)
        {
            sum += Mathf.Abs(sample);
        }

        float average = sum / 733;
        
        

        float modifiedAverage = Mathf.Pow(average, power) * size;
        if (modifiedAverage > currentPoint)
        {
            currentPoint = modifiedAverage;
        }
        else
        {
            currentPoint -= Time.deltaTime * shrinkSpeed;
        }
        
        transform.localScale = Vector3.one + Vector3.one * currentPoint;
        transform.Rotate(0,modifiedAverage,0);
    }
}
