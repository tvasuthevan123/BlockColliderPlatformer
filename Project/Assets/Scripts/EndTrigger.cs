using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter(Collider info)
    {
        if(info.CompareTag("Player"))
        {
            gameManager.completeLevel();
        }
        
    }
}
