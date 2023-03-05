using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDo.Business.Abstract;
using ToDo.Business.Concrete;
using ToDo.Entities;

namespace TODO.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgramsController : ControllerBase
    {
        private IToDoServis _toDoServis;

        public ProgramsController()
        {
            _toDoServis = new ToDoManager();
        }
        [HttpGet]
        public List<ToDoProgram> Get()
        {
            return _toDoServis.GetAllToDo();
        }

        [HttpGet("{id}")] 
        public ToDoProgram Get(int id)
        {
            return _toDoServis.GetToDoById(id);
        }
        [HttpPost]
        public ToDoProgram Post([FromBody] ToDoProgram program)
        {
            return _toDoServis.CreateToDo(program);
        }

        [HttpPut]
        public ToDoProgram Put([FromBody] ToDoProgram program)
        {
            return _toDoServis.UpdateToDo(program);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _toDoServis.DeleteToDo(id); 
        }
    }
}
