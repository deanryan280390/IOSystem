using System;
using System.Collections.Generic;
using Code.Enums;

namespace Code.Serializables
{
    [Serializable]
    public class ActivatedIO
    {
        #region Fields

        public ConfiguredActions ConfiguredActions;
        public IOSystemOptions IOSystemOptions;
        public List<string> IOActivator;
        
        #endregion
    }
}
