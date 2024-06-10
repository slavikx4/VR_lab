using System.Collections.Generic;
using UnityEngine;

public class ButtonInteraction : MonoBehaviour
{
   
    private List<GameObject> objectsToMove;

    
    private Collider buttonCollider;

    private void Awake()
    {
        
        buttonCollider = GetComponent<Collider>();

        
        objectsToMove = new List<GameObject>();

        
        objectsToMove.Add(GameObject.Find("Cube.020"));
        objectsToMove.Add(GameObject.Find("Cube.023"));
        objectsToMove.Add(GameObject.Find("Plane"));
        objectsToMove.Add(GameObject.Find("Cube.026"));
        objectsToMove.Add(GameObject.Find("Cylinder"));
        objectsToMove.Add(GameObject.Find("Cube.019"));
        objectsToMove.Add(GameObject.Find("Cube.022"));
        objectsToMove.Add(GameObject.Find("Cube.021"));
    }

    private void Update()
    {
        
        if (buttonCollider.bounds.Contains(Camera.main.transform.position))
        {
            
            Debug.Log("Кнопка нажата!");
            MoveObjects();
        }
    }

    private void MoveObjects()
    {
        
        foreach (GameObject obj in objectsToMove)
        {
            Vector3 newPosition = obj.transform.position + new Vector3(0.05f, 0, 0); 
            obj.transform.position = newPosition;
        }
    }
}
