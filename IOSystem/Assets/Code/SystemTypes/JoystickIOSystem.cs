using System;
using System.Collections.Generic;
using Code.Enums;
using Code.Interfaces;
using Code.Serializables;
using UnityEngine;

namespace Code.SystemTypes
{
    public class JoystickIOSystem : IIOSystem
    {
        #region Properties - Implemented

        public List<IOAction> IOSystemActions { get; set; }
        public Dictionary<string, Action> AvaibleActions { get; }
        public IOSystemType CurrentIOSystemType => IOSystemType.Joystick;

        #endregion
        
        #region Methods - Implemented

        public void Init()
        {
            IOActionsManager ioActionsManager = new IOActionsManager();
        }

        public void IODetection()
        {
            Debug.Log("Current IO System Type : " + CurrentIOSystemType);
        }

      
        #endregion

        
        
    }
}