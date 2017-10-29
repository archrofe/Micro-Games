using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    [Header("Movement")]
    public Transform handPos1;
    public Transform handPos2;
    public float handSpeed;
    public bool handOnTop;

    // Use this for initialization
    void Start()
    {
        handOnTop = false;
    }

    // Update is called once per frame
    void Update()
    {
        UpAndDownMovement();
    }

    #region Movement
    void UpAndDownMovement()
    {
        if (handOnTop == false)
        {
            GoDown();

            if (transform.position == handPos2.position)
            {
                handOnTop = true;
            }
        }

        if (handOnTop == true)
        {
            GoUp();

            if (transform.position == handPos1.position)
            {
                handOnTop = false;
            }
        }
    }

    void GoDown()
    {
        transform.position = Vector3.MoveTowards(transform.position, handPos2.position, handSpeed * Time.deltaTime);
    }

    void GoUp()
    {
        transform.position = Vector3.MoveTowards(transform.position, handPos1.position, handSpeed * Time.deltaTime);
    }
    #endregion
}
