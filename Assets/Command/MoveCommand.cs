using UnityEngine;

namespace Command
{
    public abstract class MoveCommand
    {
        protected readonly Transform transform;
        protected readonly float stepDistance;

        public MoveCommand(Transform transform, float stepDistance=1f)
        {
            this.transform = transform;
            this.stepDistance = stepDistance;
        }

        public abstract void Execute();
        public abstract void Undo();
    }
}