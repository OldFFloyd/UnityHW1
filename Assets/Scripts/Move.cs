using UnityEngine;

public class Move : MonoBehaviour
{
    private float _movementSpeed = 1.5f;

    private void Update()
    {
        transform.Translate(0, 0, _movementSpeed * Time.deltaTime);
    }
}