using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyProject3D.Abstracts.Controllers
{
    public interface IEntityController
    {
        Transform transform { get; }
        float MoveSpeed { get; }
        float MoveBoundary { get; }

    }

}
