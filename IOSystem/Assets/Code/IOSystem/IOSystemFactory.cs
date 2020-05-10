using System;
using Code.Enums;
using Code.Interfaces;
using Code.IOSystemFactory;
using Code.SystemTypes;

namespace Code.IOSystem
{
    public class IOSystemFactory :  IOSystemCreator
    {
        public override IIOSystem GetIOSystem(IOSystemType currentIOSystemType)
        {
            switch (currentIOSystemType)
            {
                case IOSystemType.Touch:
                    return new TouchIOSystem();
                case IOSystemType.Joystick:
                    return new JoystickIOSystem();
                case IOSystemType.Keys:
                    return new KeysIOSystem();
                default:
                    throw new ArgumentOutOfRangeException(nameof(currentIOSystemType), currentIOSystemType, null);
            }
        }
    }
}





