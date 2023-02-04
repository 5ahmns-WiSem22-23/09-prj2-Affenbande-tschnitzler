using System.Collections;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using TMPro;

public class FlashingObject : MonoBehaviour
{
    private TMP_Text flashingText;

    private void Start()
    {
        flashingText = GetComponent<TMP_Text>();
        StartCoroutine(FlashingText());
    }

    private IEnumerator FlashingText()
    {
        while (true)
        {
            flashingText.enabled = true;
            yield return new WaitForSeconds(1f);
            flashingText.enabled = false;
            yield return new WaitForSeconds(1f);
        }
    }

    private void Update()
    {
        if (Input.anyKeyDown)
        {
            StopCoroutine(FlashingText());
            gameObject.SetActive(false);
        }
    }
}