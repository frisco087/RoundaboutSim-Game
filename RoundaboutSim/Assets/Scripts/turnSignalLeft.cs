using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Vehicles.Car
{
    public class turnSignalLeft : MonoBehaviour
    {
        public CarController car; // reference to the car controller, must be dragged in inspector

        private Renderer m_Renderer;
        bool lighton;
        int onOff = 0;

        private void Start()
        {
            m_Renderer = GetComponent<Renderer>();
            m_Renderer.enabled = false;
            lighton = false;
        }        



        private void Update()
        {
            
            if (Input.GetKeyDown("q"))
            {
                onOff = onOff + 1;

                print("q button was pressed" + onOff);
               
                    
                lighton = true;
                 if (onOff <= 1 && lighton == true)
                {
                    m_Renderer.enabled = true;
                }

                if(onOff > 1 && lighton == true)
                {
                    m_Renderer.enabled = false;
                    lighton = false;
                    onOff = 0;
                }
            }
                     
        }
    }
}

