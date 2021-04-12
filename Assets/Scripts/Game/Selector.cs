using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Selector : MonoBehaviour
{
    Ray ray;

    Vector2 vector;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnChoose()
    {
        RaycastHit hit;
        ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
        if (Physics.Raycast(transform.position, ray.direction, out hit))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Debug.Log("Did hit: " + hit.collider.gameObject.name);
            hit.collider.gameObject.GetComponent<Token>()?.Select();
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("Did not Hit");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, ray.direction);
    }


}
