using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateOnEnter : MonoBehaviour
{
    public GameObject[] prefabs;
    public int[] prefabCounter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) 
        { 
            int randomInt = Random.Range(0, 3);

            if (randomInt == 0)
            {

            }
        }
    }
}
