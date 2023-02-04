using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EnterButtonSpawner : MonoBehaviour
{
    public GameObject[] prefabsToSpawn;
    public Transform[] spawnPoints;
    public Vector3[] offsets;
    public string[] playerNames;
    public TextMeshProUGUI winText;
    public GameObject panel;
    private bool canSpawn = true;

    private int[] spawnCounters;


    private void Start()
    {
        spawnCounters = new int[prefabsToSpawn.Length];
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && canSpawn)
        {
            int randomIndex = Random.Range(0, prefabsToSpawn.Length);
            GameObject prefabToInstantiate = prefabsToSpawn[randomIndex];
            Transform spawnPoint = spawnPoints[randomIndex];
            Vector3 spawnLocation = spawnPoint.position + offsets[randomIndex] * spawnCounters[randomIndex];
            Instantiate(prefabToInstantiate, spawnLocation, spawnPoint.rotation);
            spawnCounters[randomIndex]++;
            if (spawnCounters[randomIndex] == 5)
            {
                winText.text = "Player " + playerNames[randomIndex] + " won!";
                StopSpawning();
                winText.gameObject.SetActive(true);
                panel.SetActive(true);
                StartCoroutine(RestartAfterDelay());
            }
        }
    }
    IEnumerator RestartAfterDelay()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    void StopSpawning()
    {
        canSpawn = false;
    }
}
