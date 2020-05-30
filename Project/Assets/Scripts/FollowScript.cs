using UnityEngine;

public class FollowScript : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTransform.position + offset;
        // transform.position.Set(playerTransform.position.x, playerTransform.position.y + 4, playerTransform.position.z-4);
    }
}
