using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class CollectibleCount : MonoBehaviour
{
    private TMP_Text text;
    int count;

    void Awake()
    {
        text = GetComponent<TMP_Text>();
    }

    void OnEnable() => Collectible.OnCollected += OnCollectibleCollected;
    void OnDisable() => Collectible.OnCollected -= OnCollectibleCollected;

    void OnCollectibleCollected()
    {
        text.text = (++count).ToString();
    }
}
