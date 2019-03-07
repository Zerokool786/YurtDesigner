using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildMode : MonoBehaviour
{
    Vector3 objInsPosition = new Vector3(2, 0, 0); //Variable to store instantiation location
    Quaternion objInsRotation = new Quaternion(0f, 0f, 0f, 0f); // Variable to store instantiation rotation
    [SerializeField] GameObject spawnObject; //Object to instantiate

    [SerializeField] int spawnLimit = 3; //Set limit to number of object spawns
    int currentSpawns = 0; //Current number of instantiated objects

    float radius = 0.01f; //Set radius to check if objet already exists at spawn Vector
      
    
    //Instantiate object - use with button press
    public void AddObjectToScene()
    {
        if((objInsPosition != null && spawnObject != null && objInsRotation != null) && currentSpawns < spawnLimit)
        {
            Instantiate(spawnObject, objInsPosition, objInsRotation);
            currentSpawns++;
        }
        else
        {
            Debug.Log("No location set for instantiaion or spawn limit reached");
        }
    }

    /*Check if there is an object in spawn location already with Physcis.Overlap Sphere
    Detroy it if there is and call AddObjectToScene()
    This is an extension to AddObjectToScene method and doesn't have to be used
    */
    public void CheckSpawnLocation()
    {
      
        if (objInsPosition != null && currentSpawns < spawnLimit)
        {
            Collider[] hitColliders = Physics.OverlapSphere(objInsPosition, radius);
            
            Debug.Log(hitColliders[0]);

            if (hitColliders[0].tag != "Camera")//Ignore camera objects
            {
                Destroy(hitColliders[0].gameObject);
            }
            AddObjectToScene();
        }
    }
}
