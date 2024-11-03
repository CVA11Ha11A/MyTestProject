using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerTest : MonoBehaviour
{
    private Rigidbody rb = null;
    private BoxCollider boxCollider = null;

    public float moveSpeed = 10f;

    private void Awake()
    {
        this.rb = this.GetComponent<Rigidbody>();

        moveSpeed = 30f;
    }

    void Start()
    {
        Camera.main.AddComponent<CameraFollowTarget>();
        Camera.main.AddComponent<CameraFollowTarget>().SetFollowTarget(this.transform);

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        float xVelo = Input.GetAxis("Horizontal");
        float zVelo = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(xVelo, 0f, zVelo) * moveSpeed;
    }




}
