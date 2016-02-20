using System;

//Create a [Version] attribute that can be applied to structures, classes, interfaces, 
//enumerations and methods and holds a version in the format major.minor (e.g. 2.11). 
//Apply the version attribute to GenericList<T> class and display its version at runtime.

namespace Problem03.GenericList
{
    [AttributeUsage(AttributeTargets.Class |
        AttributeTargets.Struct |
        AttributeTargets.Enum |
        AttributeTargets.Interface |
        AttributeTargets.Method)]
    public class VersionAttribute : Attribute
    {
        private int minor;
        private int major;

        public VersionAttribute(int major, int minor)
        {
            this.minor = minor;
            this.major = major;
        }

        public override string ToString()
        {
            return string.Format("{0}.{1}", this.major, this.minor);
        }
    }
}
