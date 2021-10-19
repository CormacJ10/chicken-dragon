using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingChicken : MonoBehaviour
{
    enum RotAxis {x,y,z,ran,sez,timed,flow};
    [SerializeField] private GameObject chicken;
    [SerializeField] private int rotateSpeed = 1;
    [SerializeField] private RotAxis rotAxis= RotAxis.x;
    [SerializeField] private float timedTimer = 2;
    private float timedTimeRemaining = 0;
    private int rollAxis;
    private int rollDir;
    private int dir = 1;
    
    void Start()
    {
        rollAxis = Random.Range(1, 4);
        rollDir = Random.Range(1, 3);
    }
    void Update()
    {
        if(rotAxis == RotAxis.x)
            transform.Rotate(rotateSpeed, 0, 0);
        else if (rotAxis == RotAxis.y)
            transform.Rotate(0,rotateSpeed, 0);
        else if (rotAxis == RotAxis.z)
            transform.Rotate(0,0, rotateSpeed);
        else if (rotAxis == RotAxis.ran || rotAxis == RotAxis.sez)
        {
            rollAxis = Random.Range(1, 4);
            rollDir = Random.Range(1, 3);
            if (rotAxis == RotAxis.sez)
            {
                dir = rollDir * 2 - 3; //Just made it -1 or 1
            }
            switch (rollAxis)
            {
                case (1):
                    transform.Rotate(rotateSpeed*dir, 0, 0);
                    break;
                case (2):
                    transform.Rotate(0,rotateSpeed*dir, 0);
                    break;
                case (3):
                    transform.Rotate(0,0,rotateSpeed*dir);
                    break;
            }
        }

        else if (rotAxis == RotAxis.timed)
        {
            if (timedTimeRemaining > 0)
            {
                timedTimeRemaining -= Time.deltaTime;

                switch (rollAxis)
                {
                    case (1):
                        transform.Rotate(rotateSpeed * dir, 0, 0);
                        break;
                    case (2):
                        transform.Rotate(0, rotateSpeed * dir, 0);
                        break;
                    case (3):
                        transform.Rotate(0, 0, rotateSpeed * dir);
                        break;
                }
            }
            else
            {
                timedTimeRemaining = timedTimer;
                rollAxis = Random.Range(1, 4);
                rollDir = Random.Range(1, 3);
                dir = rollDir * 2 - 3; //Just made it -1 or 1
            }
            
        }
        else if (rotAxis == RotAxis.flow)
        {
            if (timedTimeRemaining > 0)
            {
                timedTimeRemaining -= Time.deltaTime;

                switch (rollAxis)
                {
                    case (1):
                        transform.Rotate(0, rotateSpeed * dir, rotateSpeed * dir);
                        break;
                    case (2):
                        transform.Rotate(rotateSpeed * dir, 0, rotateSpeed * dir);
                        break;
                    case (3):
                        transform.Rotate(rotateSpeed * dir, rotateSpeed * dir,0);
                        break;
                }
            }
            else
            {
                timedTimeRemaining = timedTimer;
                rollAxis = Random.Range(1, 4);
                rollDir = Random.Range(1, 3);
                dir = rollDir * 2 - 3; //Just made it -1 or 1
            }
        }
    }
}