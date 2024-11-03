using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TarefasDiario.Models;


namespace TarefasDiario.Context
{
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options){}

        public DbSet<Tarefa> Tarefas { get; set;}
    }
}