using UnityEngine;

[DisallowMultipleComponent]
public class ApplyYRotation : MonoBehaviour
{
    [SerializeField] [Range(0f, 50f)] private float speed;
    void Update()
    {
        transform.Rotate( Vector3.up * speed * Time.deltaTime, Space.World );
    }
}
