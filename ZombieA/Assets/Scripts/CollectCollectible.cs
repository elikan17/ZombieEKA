using UnityEngine;
using TMPro;


public class CollectCollectible : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectible"))
        {
            Destroy(other.gameObject);
            GameManager.Instance.AddScore(1);
        }
   


        else if (other.CompareTag("Outside"))
        {
            Destroy(gameObject);
            GameManager.Instance.GameOver();
        }
    }

}
