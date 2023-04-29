using System;
using UnityEngine;
using UnityEngine.Events;

public class AudioVisualizer : MonoBehaviour
{
    private AudioSource source;
    public UnityEvent<float> onAnalyzed;

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
        onAnalyzed.Invoke(average);
    }
}
