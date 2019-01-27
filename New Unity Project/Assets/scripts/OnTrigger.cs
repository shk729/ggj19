using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour
{
    public string victoryScene;
    public string victoryName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.name == victoryName) UnityEngine.SceneManagement.SceneManager.LoadScene(victoryScene);
    }
}
