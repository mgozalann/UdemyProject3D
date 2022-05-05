using UnityEngine;
using UdemyProject3D.Abstracts.Controllers;
using UdemyProject3D.Abstracts.Movements;




namespace UdemyProject3D.Movements
{
    public class HorizontalMover : MonoBehaviour, IMover
    {
        IEntityController _entityController;
        float _moveBoundary;
        float _moveSpeed;

        public HorizontalMover(IEntityController entityController)
        {
            _entityController = entityController;
            _moveSpeed = entityController.MoveSpeed;
            _moveBoundary = entityController.MoveBoundary;
        }

        public void FixedTick(float horizontal)
        {
            if (horizontal == 0f) return;
            _entityController.transform.Translate(Vector3.right * horizontal * Time.deltaTime * _moveSpeed);
            float xBoundary = Mathf.Clamp(_entityController.transform.position.x, -_moveBoundary, _moveBoundary);
            _entityController.transform.position = new Vector3(xBoundary, _entityController.transform.position.y, _entityController.transform.position.z);
        }
    }

}
