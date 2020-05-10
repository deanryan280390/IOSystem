using System;
using System.Collections.Generic;
using Code.Actions;
using Code.Enums;

namespace Code.Serializables
{
    [Serializable]
    public class IOActionsManager
    {   
        #region Fields  
        
        public Dictionary<string, Action> AvaibleActionsDictionary;
        
        #endregion

        #region Methods

        
        /// <summary>
        /// these are configurable actions and can be removed and added
        /// </summary>
        public IOActionsManager()
        {
            Action Delete = () => AvailableActions.Delete();
            Action Select = () => AvailableActions.Select();
            Action Save = () => AvailableActions.Save();

            AvaibleActionsDictionary = new Dictionary<string, Action>();
            AvaibleActionsDictionary.Add(ConfiguredActions.Delete.ToString(), Delete);
            AvaibleActionsDictionary.Add(ConfiguredActions.Save.ToString(), Save);
            AvaibleActionsDictionary.Add(ConfiguredActions.Select.ToString(), Select);
        }
        
        #endregion
    }
}