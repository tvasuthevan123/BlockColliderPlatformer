using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDownPerk : MonoBehaviour
{
    public PlayerMovement player;
    // Update is called once per frame
    void OnTriggerEnter(Collider info)
    {
        if(info.CompareTag("Player"))
        {
            slowMo();
        }
    }

    IEnumerator slowMo()
    {
        player.slowDown();

        yield return new WaitForSeconds(3);

        player.speedUp();
    }
}
