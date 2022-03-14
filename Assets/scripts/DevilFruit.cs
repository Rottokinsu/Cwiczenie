using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevilFruit : MonoBehaviour
{
    public Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Renderer>().material.color = renderer.material.color;
            Destroy(gameObject);
        }
    }
}
