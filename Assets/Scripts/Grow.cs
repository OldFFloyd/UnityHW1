using UnityEngine;

public class Grow : MonoBehaviour
{
    [SerializeField] private Vector3 _scaleSpeed;

    private void Update()
    {
        transform.localScale += _scaleSpeed * Time.deltaTime;
    }
}