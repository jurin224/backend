using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using _17_CRUD.Models;

namespace _17_CRUD.Controllers
{
  // criando a class tarefacontroller e herdando seus metodos de controller 
  public class TarefaController : Controller
  {
    //criando um objeto _tarefas que armazenara uma lista de tarefas 
    private static List<Tarefa> _tarefas = new List<Tarefa>();
    public IActionResult Index()
    {
      return View(_tarefas);
    }


    public IActionResult Adicionar()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Adicionar(Tarefa novaTarefa)
    {
      //verificando o total de tarefas da lista e somando mais 1 para o id 
      novaTarefa.Id = _tarefas.Count + 1;
      //adiconando minha nova tarefa a minha lista 
      _tarefas.Add(novaTarefa);
      //redirecionar para a pagina com a lista de tarefas 
      return RedirectToAction("Index");
    }

    public IActionResult Editar(int Id)
    {
      //estou buscando na minha lista a tarefa que desejo alterar 
      Tarefa tarefaBD = _tarefas.FirstOrDefault(t => t.Id == Id);
      //verificando se encontrou a tarefa, se ela nao é null 

      if (tarefaBD == null)
        return NotFound();
      //enviando para view tarefa encontarda que queremos editar 
      return View(tarefaBD);
    }
    [HttpPost]
    public IActionResult Editar(Tarefa tarefaEditando)
    {
      //buscando tarefa da lista 
      Tarefa tarefaDB = _tarefas.Find(t => t.Id == tarefaEditando.Id);
      //verificando se encontrou ela
      if (tarefaDB == null)
        return NotFound();
      //atualizando os dados da tarefa que ja esta na lista 
      tarefaDB.Descricao = tarefaEditando.Descricao;
      tarefaDB.Concluida = tarefaEditando.Concluida;
      //redirecionando para a lista de tarefas
      return RedirectToAction("Index");
    }

    [HttpPost]

    public IActionResult Deletar(int Id)
    {
      Tarefa tarefaBD = _tarefas.FirstOrDefault(t => t.Id == Id);
        if (tarefaBD == null)
        return NotFound();
        return View(tarefaBD);
    }
    public IActionResult Deletar(Tarefa tarefaDelentando)
    {
      Tarefa tarefaBD = _tarefas.Find(t => t.Id == tarefaDelentando.Id);
      if (tarefaBD == null)
        return NotFound();
      _tarefas.Remove(tarefaBD);

      return RedirectToAction("Index");
    }



  }
}