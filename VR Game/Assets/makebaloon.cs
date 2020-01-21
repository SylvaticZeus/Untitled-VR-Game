using System.Collections;
using UnityEngine;

public class makebaloon : MonoBehaviour
{
    public GameObject baloon;
    public Rigidbody rb;
    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0)) {
            GameObject clone;
            clone = Instantiate(baloon);
            rb = clone.GetComponent<Rigidbody>();
            rb.isKinematic = false;
        }
    }
}
