using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Pun.Demo.PunBasics;
using UnityEngine;

public class LocalVerif : MonoBehaviour
{
    [SerializeField] 
    private PhotonView pw;
    [SerializeField] 
    private Camera mainCam;
    [SerializeField] 
    private PlayerManager PM;

    [SerializeField] private CameraWork CW;
    // Start is called before the first frame update
    void Start()
    {
        if (pw.IsMine)
        {
            mainCam.enabled = true;
            PM.enabled = true;
            CW.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
