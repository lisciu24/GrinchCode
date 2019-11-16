using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grinch : MonoBehaviour
{
    public Text red;
    public Text green;
    public Text blue;

    //resources
    public short redPresents = 0;
    public short bluePresents = 0;
    public short greenPresents = 0;

    //moving
    public bool move = false;
    public float velocity = 0F;
    private Vector3 target;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "BluePresent")
        {
            bluePresents++;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "GreenPresent")
        {
            greenPresents++;
            Destroy(other.gameObject);
        }
        else if(other.gameObject.tag == "RedPresent")
        {
            redPresents++;
            Destroy(other.gameObject);
        }
        updateText();
    }

    void updateText()
    {
        blue.text = "Blue Presents: " + bluePresents;
        green.text = "Green Presents: " + greenPresents;
        red.text = "Red Presents: " + redPresents;
    }

    // Start is called before the first frame update
    void Start()
    {
        target = transform.position;

        updateText();
    }

    // Update is called once per frame
    void Update()
    {
        MoveToMouse();
        updateText();
    }

    void MoveToMouse()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(!Physics.Raycast(ray, out hit, 100.0F))
            {
                target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                target.z = transform.position.z;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, target, velocity * Time.deltaTime);
        move = (transform.position != target ? true : false);
    }
}
