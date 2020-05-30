using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Transform playerInfo;
    public Text score;
    void Update()
    {
        score.text = playerInfo.position.z.ToString("0");
    }
}
