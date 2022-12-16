using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField]
    float speed = 0.05f;

    void Update()
    {
        Rigidbody b = GetComponent<Rigidbody>();
        Vector3 pos = transform.position;

        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            pos.x += speed;
        }
        if (Input.GetKey(KeyCode.W))
        {
            pos.z += speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            pos.z -= speed;
        }
        transform.position = pos;
    }
    int keysFound = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key"))
        {
            keysFound++;
            Debug.Log("Keys found" + keysFound);
        }
    }
    public int KeysFound()
    {
        return keysFound;
    }
}
