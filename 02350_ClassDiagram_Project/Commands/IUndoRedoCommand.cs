namespace _02350_ClassDiagram_Project.Commands
{
    public interface IUndoRedoCommand
    {

            void Execute();
            void UnExecute();
        
    }

}
}