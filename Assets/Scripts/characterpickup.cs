using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class characterpickup : MonoBehaviour
{
    public AudioClip collectSound;
    public Text scoreGT;

    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreGO = GameObject.Find("Score");
        scoreGT = scoreGO.GetComponent<Text>();
        scoreGT.text = "0";
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

            int score = int.Parse(scoreGT.text);
            score += 1;
            scoreGT.text = score.ToString();

            Remaining.score = Remaining.score - 1;
        }

    }

}
