using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerFall : MonoBehaviour
{
    public PlayerMovement movement;

    private GameObject getText2;

    //private bool isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        this.getText2 = GameObject.Find("GameOverText");
    }

    // Update is called once per frame
    void Update()
    {
        float bottomY = gameObject.transform.position.y;
        float bottomX = gameObject.transform.rotation.x;

        if(gameObject.transform.position.y < 0.0)
        {
            this.getText2.GetComponent<Text>().text = "Game Over";
            movement.enabled = false;
        }



        //if (this.isGameOver == true)
        //{
        if (Input.GetKey(KeyCode.Space))
            {
                SceneManager.LoadScene("MainScene");
            }
        //}
    }


}
