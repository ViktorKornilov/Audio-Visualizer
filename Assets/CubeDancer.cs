using UnityEngine;

public class CubeDancer : MonoBehaviour
{
    public float size = 5;
    public float power = 2;
    public float shrinkSpeed = 3;

    private float currentPoint;
    
    public void Dance(float average)
    {
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
