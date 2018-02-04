﻿using System.Data.Entity;

namespace Harvin.Models
{
    public class Entities : DbContext {
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ClienteLogin> ClienteLogin { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<FormaPagamento> FormaPagamentos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<FuncionarioLogin> FuncionarioLogin { get; set; }
        public DbSet<Item> Itens { get; set; }
        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<HistoricoDeAtividade> HistoricoDeAtividades { get; set; }
        public DbSet<Configuracao> Configuracoes { get; set; }
    }
}