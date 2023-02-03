using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateOnEnter : MonoBehaviour
{
    public GameObject[] prefabList = null;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            int randomInt = Random.Range(0,prefabList.Length);
            Instantiate(prefabList[randomInt], transform.position, transform.rotation);
        }
    }
}