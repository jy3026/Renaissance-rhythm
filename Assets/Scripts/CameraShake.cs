using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public float shakeTime = 1.0f;
    public float shakeSpeed = 2.0f;
    public float shakeAmount = 1.0f;

    private Transform cam;

    void Start()
    {
        cam = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(Shake());
        }
    }

    IEnumerator Shake()
    {
        Vector3 originPosition = cam.localPosition;

        float elapsedTime = 0.0f;

        while (elapsedTime < shakeTime)
        {
            Vector3 randomPoint = originPosition + Random.insideUnitSphere * shakeAmount;
            cam.localPosition = Vector3.Lerp(cam.localPosition, randomPoint, Time.deltaTime * shakeSpeed);

            yield return null;

            elapsedTime += Time.deltaTime;
        }

        cam.localPosition = originPosition;
    }
}
