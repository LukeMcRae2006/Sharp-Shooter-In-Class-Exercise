using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float timeToSpawn, timeToSpawnSetter;
    public GameObject enemyObj;
    public int index = 0;
    public GameObject textUI;

    void Update()
    {
        if (index < 5)
        {
            if (timeToSpawn > 0)
            {
                timeToSpawn -= Time.deltaTime;
            }
            else
            {
                Instantiate(enemyObj, transform.position, transform.rotation);
                index++;
                timeToSpawn = timeToSpawnSetter;

            }
        }

       
        // Find all active GameObjects with the tag "target"
        GameObject[] targets = GameObject.FindGameObjectsWithTag("Target");

        // If the array is empty, set the bool to true
        if (targets.Length == 0)
        {
            textUI.SetActive(true);
        }

    }
    }





