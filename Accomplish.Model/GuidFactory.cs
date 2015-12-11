namespace Accomplish.Model
{
    using System;

    public sealed class GuidFactory : IGuidFactory
    {
        public Guid NewGuid()
        {
            return Guid.NewGuid();
        }
    }
}