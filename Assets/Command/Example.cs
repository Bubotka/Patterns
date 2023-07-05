using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace Command
{
    public class Example : MonoBehaviour
    {
        [SerializeField] private Button _btnStepStraight;
        [SerializeField] private Button _btnStepDiagonal;
        [SerializeField] private Button _btnUndo;
        [SerializeField] private Transform _pivotTransform;
        [SerializeField] private float _stepDistance =1f;

        private List<MoveCommand> _moveJornal = new List<MoveCommand>();
        
        private void OnEnable()
        {
            _btnStepStraight.onClick.AddListener(StepStraight);
            _btnStepDiagonal.onClick.AddListener(StepDiagonal);
            _btnUndo.onClick.AddListener(UndoLastMove);
        }
        
        private void OnDisable()
        {
            _btnStepStraight.onClick.RemoveListener(StepStraight);
            _btnStepDiagonal.onClick.RemoveListener(StepDiagonal);
            _btnUndo.onClick.RemoveListener(UndoLastMove);
        }

        private void UndoLastMove()
        {
            if (_moveJornal.Count > 0)
            {
                MoveCommand lastMove = _moveJornal.Last();
                
                lastMove.Undo();

                _moveJornal.Remove(lastMove);

            }
        }

        private void StepDiagonal()
        {
            MoveDiagonalCommand command = new MoveDiagonalCommand(_pivotTransform, _stepDistance);
            command.Execute();
            _moveJornal.Add(command);
        }

        private void StepStraight()
        {
            MoveStraightCommand command = new MoveStraightCommand(_pivotTransform, _stepDistance);
            command.Execute();
            _moveJornal.Add(command);
        }
    }
}
