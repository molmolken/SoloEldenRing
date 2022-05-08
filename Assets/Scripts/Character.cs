using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    const float MoveSpeed = 200f;

    const float MoveLimit = 180f;

    RectTransform t;

    void Start()
    {
        t = GetComponent<RectTransform>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            var pos = t.localPosition;
            if (-MoveLimit < pos.x)
            {
                var x = pos.x - MoveSpeed * Time.deltaTime;
                t.localPosition = new Vector3(x, pos.y, pos.z);
            }
        }
        else if (Input.GetKey(KeyCode.D))
        {
            var pos = t.localPosition;
            if (pos.x < MoveLimit)
            {
                var x = pos.x + MoveSpeed * Time.deltaTime;
                t.localPosition = new Vector3(x, pos.y, pos.z);
            }
        }
    }
}
