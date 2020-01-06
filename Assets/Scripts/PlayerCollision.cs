using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    private GameObject getText1;
    private GameObject getText2;

    private void Start()
    {
        this.getText1 = GameObject.Find("GameClearText");
        this.getText2 = GameObject.Find("GameOverText");
    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            this.getText2.GetComponent<Text>().text = "Game Over";
            movement.enabled = false;
        }

        if (collisionInfo.collider.tag == "ClearTag")
        {
            this.getText1.GetComponent<Text>().text = "Game Clear!!";
            movement.enabled = false;
        }
    }
}
