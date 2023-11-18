using UnityEngine;

public class PutStamp : MonoBehaviour
{
    public GameObject decalPrefab;
    public Transform objectPosition;
    public float rayLenght;

    private void Update()
    {
        var ray = new Ray(objectPosition.position, -objectPosition.up);
        // Debug.DrawRay(ray.origin, ray.direction * rayLenght);
        Physics.Raycast(ray, out var hit, rayLenght);
        if (hit.collider.tag == "document")
        {
            var normalToRotation = Quaternion.FromToRotation(Vector3.up, hit.normal);
            Instantiate(decalPrefab, hit.point, normalToRotation);
        }
    }
}