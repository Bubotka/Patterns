using UnityEngine;

namespace StateMachine
{
    public interface IBikeState
    {
        void Handle(BikeController controller);
    }

}    