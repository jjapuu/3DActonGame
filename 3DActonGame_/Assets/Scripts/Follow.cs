using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform targrt;
    public Vector3 offset;

    void Update()
    {
        transform.position = targrt.position + offset;
    }
}
