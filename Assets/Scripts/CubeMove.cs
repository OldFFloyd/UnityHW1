using UnityEngine;

public class CubeMove : MonoBehaviour
{
    private float _moveSpeedMultiplier = 3f;
    private float _scaleSpeedMultiplier = 0.1f;
    private float _rotateSpeedMultiplier = 70f;

    private void Update()
    {
        transform.Translate(Vector3.forward * _moveSpeedMultiplier * Time.deltaTime);

        transform.localScale += Vector3.one * _scaleSpeedMultiplier * Time.deltaTime;

        transform.Rotate(Vector3.up * _rotateSpeedMultiplier * Time.deltaTime);
    }
}