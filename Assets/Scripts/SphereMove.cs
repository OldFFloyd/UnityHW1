using UnityEngine;

public class SphereMove : MonoBehaviour
{
    private int _movementSpeed = 1;

    private void Update()
    {
        transform.Translate(0, 0, _movementSpeed * Time.deltaTime);
    }
}