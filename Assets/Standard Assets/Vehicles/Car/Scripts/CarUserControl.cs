using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using Mirror;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : NetworkBehaviour
    {
        private CarController m_Car; // the car controller we want to use
        public Vector3 spawnPointPos;
        private Vector3 startPoint= new Vector3(0,0,0);
       //[SerializeField] GameObject spawnPoint;

        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }

        private void Update()
        {
            if (!isLocalPlayer)
            {
                return;
            }
            if (Input.GetKeyDown(KeyCode.LeftControl) && spawnPointPos!=startPoint)
            {
                CmdRespawnVehicle();
            }

        }


        private void FixedUpdate()
        {
            if (!isLocalPlayer)
            {
                return;
            }
            // pass the input to the car!
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            float v = CrossPlatformInputManager.GetAxis("Vertical");
#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            m_Car.Move(h, v, v, handbrake);
#else
            m_Car.Move(h, v, v, 0f);
#endif
        }

        
        void CmdRespawnVehicle()
        {
            transform.position = spawnPointPos;
            //transform.rotation = Quaternion.Euler(spawnPointPos);

        }
    }
}
