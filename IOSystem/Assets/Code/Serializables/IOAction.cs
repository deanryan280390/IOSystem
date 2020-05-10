using System;
using System.Collections.Generic;

namespace Code.Serializables
{
    [Serializable]
    public class IOAction
    {
        #region Fields

        public List<ActivatedIO> ActivatedIOList;
        public bool ActionEnabled = true;

        #endregion
    }
}