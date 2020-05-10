using System.Collections.Generic;
using Code.Enums;
using Code.Interfaces;
using Code.Serializables;
using UnityEngine;

namespace Code.ScriptableObjects
{
    [CreateAssetMenu(menuName = "IO System /IO Config", fileName = "IOSystemConfig")]
    public class IOConfiguration : ScriptableObject
    {
        #region Fields
        public List<IOAction> IOActions;
        #endregion

        #region Methods
        public IIOSystem CreatIoSystemFactory(IOSystemType currentIOType)
        {
            IOSystem.IOSystemFactory ioSystemFactory = new IOSystem.IOSystemFactory();
            IIOSystem currentIoSystem = ioSystemFactory.GetIOSystem(currentIOType);
            currentIoSystem.IOSystemActions = IOActions;
            return currentIoSystem;
        }
        #endregion
    }
}