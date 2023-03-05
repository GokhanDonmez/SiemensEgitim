using ToDo.DataAccess.Abstract;
using ToDo.Entities;

namespace ToDo.DataAccess.Concrete
{
    public class ToDoCRUD : IToDoCRUD
    {
        public ToDoProgram CreateToDo(ToDoProgram program)
        {
            using (var todoDbContext = new ToDoDbContext())
            {
                 todoDbContext.ToDoSet.Add(program);
                 todoDbContext.SaveChanges();
                 return program;
            }
        }

        public void DeleteToDo(int id) 
        {
            using (var todoDbContext = new ToDoDbContext())
            {
                var deletedProgram = GetToDoById(id);
                 todoDbContext.ToDoSet.Remove(deletedProgram);
                 todoDbContext.SaveChanges();
            }
        }

        public List<ToDoProgram> GetAllToDo()
        {
            using (var todoDbContext = new ToDoDbContext())
            {
                return todoDbContext.ToDoSet.ToList();
            }
        }

        public ToDoProgram GetToDoById(int id)
        {
            using (var todoDbContext = new ToDoDbContext())
            {
                return todoDbContext.ToDoSet.Find(id);
            }
        }

        public ToDoProgram UpdateToDo(ToDoProgram program)
        {
            using (var todoDbContext = new ToDoDbContext())
            {
                todoDbContext.ToDoSet.Update(program);
                todoDbContext.SaveChanges();
                return program;
            }
        }
    }
}
