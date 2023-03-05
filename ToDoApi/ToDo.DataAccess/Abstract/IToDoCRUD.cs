using ToDo.Entities;

namespace ToDo.DataAccess.Abstract;

public interface IToDoCRUD
{
    List<ToDoProgram> GetAllToDo();

    ToDoProgram GetToDoById(int id);

    ToDoProgram UpdateToDo(ToDoProgram program);

    ToDoProgram CreateToDo(ToDoProgram program);

    void DeleteToDo(int id);
}