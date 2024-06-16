using UnityEngine;

public class Mover : MonoBehaviour
{
    private float _movementSpeed = 2f;

    private void Update()
    {
        transform.Translate(0, 0, _movementSpeed * Time.deltaTime);
    }
}