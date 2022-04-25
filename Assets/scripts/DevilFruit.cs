using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DevilFruit : MonoBehaviour
{
    public Renderer renderer;
    public ParticleSystem awubie;

    private bool collected = false;
    // Start is called before the first frame update
    void Start()
    {
        collected = false;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(1.2f, 1.1f, 0);
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") == true && collected == false) 
        {
            collected = true;
            transform.DOMoveY(transform.position.y + 6.0f, 2.0f);
            other.GetComponent<Renderer>().material.color = renderer.material.color;
            renderer.material.DOFade(0, 1.0f)
                .OnComplete(() =>
                {
                    Destroy(gameObject);
                 });

            other.GetComponent<Player>().points += 1;
            awubie.Pause();
        }
    }
}
