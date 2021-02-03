using System;

namespace UIArtify.Interfaces
{
    public interface IQuery
    {
        public UInt16 QueryNumber { get; set; }
        
        public String QueryText { get; set; }

    }
}