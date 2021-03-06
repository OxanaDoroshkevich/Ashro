﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class Asparagus : MonoBehaviour
{
    public int countTime = 0;
    GameObject myGameObject;
    Rigidbody projectile;
    GameObject cylinder;
    List<GameObject> goList = new List<GameObject>();
    public int amountAsparagusx = 18;
    public int amountAsparagusy = 18;
    public GameObject game;
    Rigidbody rb;
    int nameCount = 0;
    public float locationx;
    public float locationy;
    public float distanceX;
    public float distance;
    public Transform AsparagusParent;
    public Transform AsparagusPrefab;


    //GamePosition
    public Vector3 gamePosition;

    //GameRotation
    public Quaternion gameRotation;

    //GameScale
    public Vector3 gameScale;
    

    // Use this for initialization
    void Start()
    {
        Assert.IsNotNull(AsparagusPrefab,"NoPrefab");
        setGameTransforms();

        Debug.Log("gamePosition.x " + gamePosition.x);
        locationx = gamePosition.x -1.5f;
        //locationy = gamePosition.z - (0.2f * gameScale.y);
        distance = 0.25f;
        Debug.Log("Distance "+distance);
        setFirstAsparagusLevel();

    }


    // Update is called once per frame
    void Update()
    {

    }





    public void setFirstAsparagusLevel()
    {
        for (int i = 0; i < amountAsparagusx; i++)
        {
            locationx = locationx + distance;
            Debug.Log("gamePosition.z " + gamePosition.z);
            locationy = gamePosition.z - 3.5f;
            for (int j = 0; j < amountAsparagusy; j++)
            {
                locationy = locationy + distance;
                var asparagus = Instantiate(AsparagusPrefab);

                Debug.Log("gamePosition.y " + gamePosition.y);
                asparagus.transform.position = new Vector3(locationx, gamePosition.y - 0.00001f, locationy);
                asparagus.transform.parent = AsparagusParent.transform;
            }
        }

                
    }

    public void setGameTransforms()
    {
        gamePosition = AppManager.Instance.PlaneLocation;
        
        gameRotation = AppManager.Instance.PlaneRotation;
        gameScale = AppManager.Instance.PlaneScale;


    }

}
