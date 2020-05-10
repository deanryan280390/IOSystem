using System;
using Code.Enums;
using Code.Interfaces;
using Code.ScriptableObjects;
using UnityEngine;

public class IOSystemController : MonoBehaviour
{
    public IOConfiguration IOConfiguration;
    public IOSystemType CurrentIoSystemType;
    public IIOSystem currentIOSystem;
    
    // Start is called before the first frame update
    void Start()
    {
        if (IOConfiguration == null)
        {
            throw new InvalidOperationException("No IO Config");
        }

        Debug.Log("CurrentIoSystemType :" + CurrentIoSystemType);
        
        currentIOSystem = IOConfiguration.CreatIoSystemFactory(CurrentIoSystemType);
        
        Debug.Log("CurrentIoSystemType :" + currentIOSystem.CurrentIOSystemType);
        
        currentIOSystem.Init();
    }

    // Update is called once per frame
    void Update()
    {
        currentIOSystem?.IODetection();
    }
}
