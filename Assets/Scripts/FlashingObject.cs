using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashingObject : MonoBehaviour
{
    private void Awake()
    {
        gameObject.SetActive(true);
        InvokeRepeating("FlashObject", 0f, 0.7f);
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