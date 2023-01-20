using UnityEngine;

public class FlickeringLight : MonoBehaviour
{
    public float minIntensity = 0.25f;
    public float maxIntensity = 0.5f;
    public float flickerSpeed = 0.05f;

    private Light light;

    void Start()
    {
        light = GetComponent<Light>();
    }

    void Update()
    {
        float randomValue = Random.Range(minIntensity, maxIntensity);
        light.intensity = Mathf.Lerp(light.intensity, randomValue, flickerSpeed * Time.deltaTime);
    }
}
