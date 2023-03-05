using ToDo.Business.Abstract;
using ToDo.DataAccess.Abstract;
using ToDo.DataAccess.Concrete;
using ToDo.Entities;

namespace ToDo.Business.Concrete
{
    public class ToDoManager : IToDoServis
    {
        private IToDoCRUD _toDoCrud;

        public ToDoManager()
        {
            _toDoCrud = new ToDoCRUD();
        }
        public ToDoProgram CreateToDo(ToDoProgram program)
        {
            return _toDoCrud.CreateToDo(program);
            
        }

        public void DeleteToDo(int id)
        {
            _toDoCrud.DeleteToDo(id);
        }

        public List<ToDoProgram> GetAllToDo()
        {
            return _toDoCrud.GetAllToDo();
        }

        public ToDoProgram GetToDoById(int id)
        {
            return _toDoCrud.GetToDoById(id);
        }

        public ToDoProgram UpdateToDo(ToDoProgram program)
        {
            return _toDoCrud.UpdateToDo(program);
        }
    }
}
