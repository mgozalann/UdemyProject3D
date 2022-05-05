using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyProject3D.Abstracts.Movements
{
    public interface IMover
    {
        void FixedTick(float direction);
    }

}
