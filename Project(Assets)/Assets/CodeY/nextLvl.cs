using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLvl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D nextLvl)
    {          
        if (nextLvl.CompareTag("LevelFinished"))
        {
            SceneManager.LoadScene("Win-Screen");
        }
    }

}
