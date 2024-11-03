using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowTarget : MonoBehaviour
{

    private Transform target = null;

    void Start()
    {
        this.transform.rotation = Quaternion.Euler(35f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void LateUpdate()
    {
        if (this.target == null)
        {
            this.target = GameObject.FindWithTag("Player").transform;

            if (this.target == null)
            {
                return;
            }
        }

        else
        {
            Vector3 pos = new Vector3(target.transform.position.x,
                target.transform.position.y + 10, target.transform.position.z - 10);
            this.transform.position = pos;
        }


    }       // LateUpdate()


    public void SetFollowTarget(Transform _target)
    {
        this.target = _target;
    }

}       // ClassEnd
