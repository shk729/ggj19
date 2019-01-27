using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPoint : MonoBehaviour
{

    public string victoryScene;
    public string victoryName;
    // Start is called before the first frame update
    void Start()
    {
        Component[] spawners = this.transform.parent.GetComponentsInChildren<SpawnPoint>();
        var el = Mathf.FloorToInt( Random.Range(0f, spawners.Length) );
        this.transform.position = spawners[el].transform.position;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.name == victoryName) UnityEngine.SceneManagement.SceneManager.LoadScene(victoryScene);
    }
}
