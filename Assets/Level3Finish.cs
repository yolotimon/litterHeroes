using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3Finish : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && SC_2DCoin.totalCoins >= 20)
        {
            SceneManager.LoadScene("level3end");
            Debug.Log("Level completed");
            AIChaise.health = 3;
        }

        else if (collision.gameObject.CompareTag("Player") && SC_2DCoin.totalCoins < 20)
        {
            Debug.Log("Not enough coins");
        }
    }
}
