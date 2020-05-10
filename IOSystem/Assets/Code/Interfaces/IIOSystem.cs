using System;
using System.Collections.Generic;
using Code.Enums;
using Code.Serializables;

namespace Code.Interfaces
{
    public interface IIOSystem
    {
        void Init();
        void IODetection();
        IOSystemType CurrentIOSystemType { get; }
        List<IOAction> IOSystemActions { get; set; }
        Dictionary<string, Action> AvaibleActions { get; }
    }
}