using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class ItemCollector : MonoBehaviour
{
    public int cherries = 0;

    [SerializeField] private TextMeshProUGUI cherriesText;

    [SerializeField] private AudioSource collectionSoundEffect;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Cherry"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            cherries++;
            cherriesText.text = "Items: " + cherries;
        }
    }
}
