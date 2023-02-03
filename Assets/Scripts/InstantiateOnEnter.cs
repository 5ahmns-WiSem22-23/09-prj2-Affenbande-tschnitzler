using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateOnEnter : MonoBehaviour
{
    public GameObject[] prefabList;
    public GameObject[] coordinates;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            int randomInt = Random.Range(0,prefabList.Length);
            Instantiate(prefabList[randomInt], coordinates[randomInt]., transform.rotation);
        }
    }
}