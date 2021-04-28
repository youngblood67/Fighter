using Fighter.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fighter.Technical
{
    public interface IRotationable
    {
        void Rotate(Asset asset, Rotation rotation);

    }

}
