using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Throw : MonoBehaviour {

    public GameObject spherePrefab;
    public GameObject cubePrefab;
    public Material green;
    public Material red;

    Perceptron p;

    void Start () {
        p = GetComponent<Perceptron>();
    }
    
    void Update () {
        if (Keyboard.current == null) return;

        if (Keyboard.current.digit1Key.wasPressedThisFrame)
        {
            GameObject g = Instantiate(spherePrefab, Camera.main.transform.position, Camera.main.transform.rotation);
            g.GetComponent<Renderer>().material = red;
            g.GetComponent<Rigidbody>().AddForce(0, 0, 500);
            p.SendInput(0, 0, 0);
        }
        else if (Keyboard.current.digit2Key.wasPressedThisFrame)
        {
            GameObject g = Instantiate(spherePrefab, Camera.main.transform.position, Camera.main.transform.rotation);
            g.GetComponent<Renderer>().material = green;
            g.GetComponent<Rigidbody>().AddForce(0, 0, 500);
            p.SendInput(0, 1, 1);
        }
        else if (Keyboard.current.digit3Key.wasPressedThisFrame)
        {
            GameObject g = Instantiate(cubePrefab, Camera.main.transform.position, Camera.main.transform.rotation);
            g.GetComponent<Renderer>().material = red;
            g.GetComponent<Rigidbody>().AddForce(0, 0, 500);
            p.SendInput(1, 0, 1);
        }
        else if (Keyboard.current.digit4Key.wasPressedThisFrame)
        {
            GameObject g = Instantiate(cubePrefab, Camera.main.transform.position, Camera.main.transform.rotation);
            g.GetComponent<Renderer>().material = green;
            g.GetComponent<Rigidbody>().AddForce(0, 0, 500);
            p.SendInput(1, 1, 1);
        }
    }
}