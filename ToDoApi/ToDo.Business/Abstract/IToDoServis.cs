using ToDo.Entities;

namespace ToDo.Business.Abstract;

public interface IToDoServis
{
    List<ToDoProgram> GetAllToDo();

    ToDoProgram GetToDoById(int id);

    ToDoProgram UpdateToDo(ToDoProgram program);

    ToDoProgram CreateToDo(ToDoProgram program);

    void DeleteToDo(int id);
}