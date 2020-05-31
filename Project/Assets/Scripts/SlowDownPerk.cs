using System.Collections;
using UnityEngine;

public class SlowDownPerk : MonoBehaviour
{
    public PlayerMovement player;

    public float duration;
    // Update is called once per frame
    void OnTriggerEnter(Collider info)
    {
        if(info.CompareTag("Player"))
        {
            StartCoroutine(slowMo());
        }
    }

    IEnumerator slowMo()
    {
        Debug.Log("Player slowed");
        player.slowDown();

        yield return new WaitForSeconds(duration);

        Debug.Log("Player speed up");
        player.speedUp();
    }
}
