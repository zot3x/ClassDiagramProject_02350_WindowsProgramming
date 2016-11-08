using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.CommandWpf;

namespace _02350_ClassDiagram_Project.Commands
{
    class UndoRedoCommand
    {

        private static readonly UndoRedoCommand _self = new UndoRedoCommand();
        private readonly Stack<IUndoRedoCommand> _undoStack = new Stack<IUndoRedoCommand>();
        private readonly Stack<IUndoRedoCommand> _redoStack = new Stack<IUndoRedoCommand>();


        private UndoRedoCommand():base()
        {
        }

        public static UndoRedoCommand Instance => _self;

        public RelayCommand UndoCommand => new RelayCommand(Undo, CanUndo);
        public RelayCommand RedoCommand => new RelayCommand(Redo, CanRedo);

        public void AddAndExecute(IUndoRedoCommand command)
        {
            _undoStack.Push(command);
            _redoStack.Clear();
            command.Execute();
            UpdateCommandStatus();
        }

        public bool CanUndo() => _undoStack.Any();
        public void Undo()
        {
            IUndoRedoCommand command = _undoStack.Pop();
            _redoStack.Push(command);
            command.UnExecute();
            UpdateCommandStatus();
        }

        public bool CanRedo() => _redoStack.Any();
        public void Redo()
        {
            IUndoRedoCommand command = _redoStack.Pop();
            _undoStack.Push(command);
            command.Execute();
            UpdateCommandStatus();

        }

        private void UpdateCommandStatus()
        {
            UndoCommand.RaiseCanExecuteChanged();
            RedoCommand.RaiseCanExecuteChanged();
        }
    }




}
}
