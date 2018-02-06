﻿using Harvin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Harvin.DAO {
    public class CategoriaDAO {
        private static Entities entities = Singleton.Instance.Entities;
        
        // Retorna Categorias
        public static List<Categoria> ListaCategorias() {
            try {
                return entities.Categorias.ToList();
            }
            catch (Exception e) {
                return null;
            }
        }

        // Busca Categoria Por Nome
        public static Categoria BuscarCategoriaPorNome(Categoria categoria)
        {
            return entities.Categorias.FirstOrDefault(x => x.Nome.Equals(categoria.Nome));
        }

        // Busca Categoria por Id
        public static Categoria BuscarCategoriaPorId(int id)
        {
            return entities.Categorias.Find(id);
        }

        // Verifica se Existe Produtos em Categoria
        public static bool VerificaSeExisteProdutosEmCategoria(Categoria categoria)
        {
            List<Produto> produtos = ProdutoDAO.RetornaProdutos();
            foreach (var item in produtos)
            {
                if (item.Categoria.Id == categoria.Id)
                {
                    return true;
                }
            }

            return false;
        }
    }
}