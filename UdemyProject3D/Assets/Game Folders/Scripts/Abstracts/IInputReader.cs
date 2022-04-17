using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UdemyProject3D.Abstracts.Inputs
{
    public interface IInputReader
    {
        float Horizontal { get; }
        bool IsJump { get; }
    }
}

