using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashingObject : MonoBehaviour
{
    private void Awake()
    {
        gameObject.SetActive(false);
        InvokeRepeating("FlashObject", 0f, 1.2f);
    }

    private void Update()
    {
        if (Input.anyKeyDown)
        {
            gameObject.SetActive(false);
            CancelInvoke("FlashObject");
        }
    }

    private void FlashObject()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }
}