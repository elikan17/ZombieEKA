using UnityEngine;
using TMPro;


public class CollectCollectible : MonoBehaviour
{
    public AudioSource audioSource;
    

private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectible"))
        {
            Destroy(other.gameObject);
            GameManager.Instance.AddScore(1);
            audioSource.Play();
        }


        else if (other.CompareTag("Outside"))
        {
            Destroy(gameObject);
            GameManager.Instance.GameOver();
        }
    }

}
