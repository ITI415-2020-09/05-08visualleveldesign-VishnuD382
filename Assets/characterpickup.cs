using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class characterpickup : MonoBehaviour
{
    public AudioClip collectSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // text goes in here.
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            AudioSource.PlayClipAtPoint(collectSound, transform.position);
            other.gameObject.SetActive(false);
        }

    }

}
