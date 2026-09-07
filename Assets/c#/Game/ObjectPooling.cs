using System;
using System.Collections.Generic;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{
  public GameObject prefabToCreate;
  public List<GameObject> createObject;
   
  public void Start()
  {
    createObject = new List<GameObject>();
  }

  public void SpawnOnject(Quaternion rot, Vector3 pos)
  {
    Debug.Log("Spawning ");
    for(int i = 0; i < createObject.Count; i++)
    {
      if (!createObject[i].activeInHierarchy)
      {
        createObject[i].transform.SetPositionAndRotation(pos,rot);
        createObject[i].SetActive(true);
        return;
      }
    }

    Instantiate(prefabToCreate);
  }
  
}
