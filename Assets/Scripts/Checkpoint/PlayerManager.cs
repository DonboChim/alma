using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{

    private GameMaster gm;
    private HPmanager hpManager;

    // Start is called before the first frame update
    void Start()
    {
        //gm = GameObject.FindGameObjectsWithTag
        hpManager = transform.GetComponent<HPmanager>();
        gm = FindObjectOfType<GameMaster>();
        transform.position = gm.ultimocheckpos;
    }

    // Update is called once per frame
    void Update()
    {
        if (hpManager.currentlifePoints <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }


    }

   
}
