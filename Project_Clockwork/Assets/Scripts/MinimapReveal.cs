using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinimapReveal : MonoBehaviour
{
    public Image minimapMask;
    public float revealDistance = 10f;
    public float revealSpeed = 5f;

    private Vector3 lastPosition;
    private bool isRevealing = false;

    void Start()
    {
        lastPosition = transform.position;
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, lastPosition);

        if (distance >= revealDistance && !isRevealing)
        {
            StartCoroutine(RevealMinimap());
            lastPosition = transform.position;
        }
    }

    IEnumerator RevealMinimap()
    {
        isRevealing = true;
        float fillAmount = minimapMask.fillAmount;

        while (fillAmount > 0f)
        {
            fillAmount -= revealSpeed * Time.deltaTime;
            minimapMask.fillAmount = fillAmount;
            yield return null;
        }
        isRevealing = false;
    }
}
