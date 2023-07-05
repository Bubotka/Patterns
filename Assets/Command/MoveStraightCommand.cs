using UnityEngine;

namespace Command
{
    class MoveStraightCommand : MoveCommand
    {
        public MoveStraightCommand(Transform transform, float stepDistance=1f) 
        : base(transform, stepDistance)
        {
        }

        public override void Execute()
        {
            transform.position += Vector3.right * stepDistance;
        }

        public override void Undo()
        {
            transform.position -= Vector3.right * stepDistance;
        }
    }
    
    class MoveDiagonalCommand : MoveCommand
    {
        private Vector3 directionDiagonal = new Vector3(1f,-1f,0f).normalized;
        
        public MoveDiagonalCommand(Transform transform, float stepDistance=1f) 
            : base(transform, stepDistance)
        {
        }

        public override void Execute()
        {
            transform.position += directionDiagonal* stepDistance;
        }

        public override void Undo()
        {
            transform.position -= directionDiagonal* stepDistance;
        }
    }
}