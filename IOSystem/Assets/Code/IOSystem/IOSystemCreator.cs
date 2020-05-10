using Code.Enums;
using Code.Interfaces;

namespace Code.IOSystemFactory
{
    public abstract class IOSystemCreator
    {
        public abstract IIOSystem GetIOSystem(IOSystemType currentIOSystemType);
    }
}