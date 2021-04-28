using System;
using System.Collections.Generic;
using System.Text;

namespace Fighter.Technical
{
    public interface IMovable
    {
        void Move(Asset asset, Direction direction);

    }

}
