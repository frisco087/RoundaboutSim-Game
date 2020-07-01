using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowUI : MonoBehaviour
{
    public GameObject UiObject;
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        UiObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("collide");
        if (other.tag == "Player")
        {
            Debug.Log("Player");
            UiObject.SetActive(true);
        }

        
    }
    void OnTriggerExit(Collider other)
    {    
        UiObject.SetActive(false);
        Destroy(cube);
        Debug.Log("Destory");
    }
}
