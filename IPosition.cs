using System.Collections.Generic;

namespace GeveoRovers
{
    public interface IPosition
    {
        void StartMoving(List<int> maxPoints, string moves);
    }
}
