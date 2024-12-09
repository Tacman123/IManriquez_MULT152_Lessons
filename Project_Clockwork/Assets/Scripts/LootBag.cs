using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootBag : MonoBehaviour
{
    public GameObject droppedItemPrefab;
    public List<Loot> lootList;

    Loot GetDroppedItem()
    {
        int randomNumber = Random.Range(1, 101); // 1-100
        List<Loot> possibleItems = new List<Loot>();
        foreach (Loot item in lootList)
        {            
            if (randomNumber <= item.dropChance)
            {
                possibleItems.Add(item);
            }
        }
        

        if (possibleItems.Count > 0)
        {
            Loot droppedItem = possibleItems[Random.Range(0, possibleItems.Count)];
            return droppedItem;
        }
        Debug.Log("No Loot Dropped");
        return null;
    }
    public void InstantiateLoot(Vector3 spawnPosition)
    {
        Loot droppedItem = GetDroppedItem();
        if (droppedItem != null)
        {
            GameObject lootGameObject = Instantiate(droppedItem.lootObject, spawnPosition, Quaternion.identity);
            lootGameObject.GetComponent<MeshRenderer>().sharedMaterial = droppedItem.lootObject.GetComponent<MeshRenderer>().sharedMaterial;
            
        }
    }
}
