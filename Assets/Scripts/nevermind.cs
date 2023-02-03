using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imdonewithit : MonoBehaviour
{
    public GameObject[] prefabList;
    public GameObject[] coordinates;

    public int[] prefabCount;

    [SerializeField] int firstPrefabCount;
    [SerializeField] int secondPrefabCount;
    [SerializeField] int thirdPrefabCount;
    [SerializeField] int fourthPrefabCount;

    void Awake()
    {
        prefabCount[0] = 1;
        prefabCount[1] = 1;
        prefabCount[2] = 1;
        prefabCount[3] = 1;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            int randomInt = Random.Range(0, prefabList.Length);


            Instantiate(prefabList[randomInt], coordinates[randomInt].transform.position, coordinates[randomInt].transform.rotation);



            if (randomInt == 0) { prefabCount[0] = prefabCount[0]++; };
            if (randomInt == 1) { prefabCount[1] = prefabCount[1]++; };
            if (randomInt == 2) { prefabCount[2] = prefabCount[2]++; };
            if (randomInt == 3) { prefabCount[3] = prefabCount[3]++; };
        }
    }
}



//make a spawn counter and use the int as a multiplier for the transform position