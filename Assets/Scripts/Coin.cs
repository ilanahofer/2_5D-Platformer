using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // OnTriggerEnter
    // give the player a coin
    // notify either player or UI
    // destroy this object

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Player player = other.transform.GetComponent<Player>();

            if(player != null)
            {
                player.AddCoin();
            }
            
            Destroy(this.gameObject);
        }
    }
}
