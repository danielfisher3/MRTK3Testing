using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMethods : MonoBehaviour
{
    public bool hasIntantiated = false;
    public GameObject[] prefabTospawn;
    [SerializeField] Transform spanwPos;
    GameObject spawnedPrefab = null;
   


    public void SpawnObject()
    {
        if (!hasIntantiated)
        {
            int rIndex = Random.Range(0, prefabTospawn.Length);
            spawnedPrefab = Instantiate(prefabTospawn[rIndex], spanwPos.position, Quaternion.identity);
            hasIntantiated = true;
        }
    }

    public void ShootObject()
    {
        if (hasIntantiated)
        {
            spawnedPrefab.GetComponent<Ball>().moveForward = true;
            hasIntantiated = false;
        }
    }
    
}
