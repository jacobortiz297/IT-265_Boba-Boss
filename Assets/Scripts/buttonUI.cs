using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonUI : MonoBehaviour
{
    public player player;
    public void increasePoints()
    {
        player.points++;
    }
}
