using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grinch : MonoBehaviour
{
    //resources
    public short redPresents = 0;
    public short bluePresents = 0;
    public short greenPresents = 0;

    //moving
    public bool move = false;
    public float velocity = 0F;
    private Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MoveToMouse();
    }

    void MoveToMouse()
    {
        if (Input.GetMouseButtonDown(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
        }

        transform.position = Vector3.MoveTowards(transform.position, target, velocity * Time.deltaTime);
        move = (transform.position != target ? true : false);
    }
}
