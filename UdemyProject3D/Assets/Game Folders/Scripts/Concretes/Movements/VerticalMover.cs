using UnityEngine;
using UdemyProject3D.Abstracts.Controllers;
using UdemyProject3D.Abstracts.Movements;


namespace UdemyProject3D.Movements
{
    public class VerticalMover : MonoBehaviour , IMover
    {
        IEntityController _entityController;
        float _moveSpeed;
        public VerticalMover(IEntityController entityController)
        {
            _entityController = entityController;
            _moveSpeed = entityController.MoveSpeed;
        }

        public void FixedTick(float vertical = 1)
        {
            _entityController.transform.Translate(Vector3.back * Time.deltaTime * _moveSpeed * vertical);
        }
    }

}
