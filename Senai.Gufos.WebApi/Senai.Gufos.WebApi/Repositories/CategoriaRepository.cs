﻿using Microsoft.AspNetCore.Authorization;
using Senai.Gufos.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufos.WebApi.Repositories
{
    public class CategoriaRepository
    {
        
        public List<Categorias> Listar()
        {
            using (GufosContext ctx = new GufosContext())
            {
                // facilitar a nossa vida
                // select * from Catrgorias
                return ctx.Categorias.ToList();
            }
        }

        // insert 
        public void Cadastrar(Categorias categoria)
        {
            using (GufosContext ctx = new GufosContext())
            {
                // insert into Categorias (nome) values (@nome);
                ctx.Categorias.Add(categoria);
                ctx.SaveChanges();
            }
        }

        
        public Categorias BuscarPorId(int id)
        {
            using (GufosContext ctx = new GufosContext())
            {
                return ctx.Categorias.FirstOrDefault(x => x.IdCategoria == id);
            }
        }

        // atualizar 
        public void Atualizar(Categorias categoria)
        {
            using (GufosContext ctx = new GufosContext())
            {
                Categorias CategoriaBuscada = ctx.Categorias.First(x => x.IdCategoria == categoria.IdCategoria);
                // update categorias set nome = @nome
                CategoriaBuscada.Nome = categoria.Nome;
                // insert - add, delete - remove, update - update
                ctx.Categorias.Update(CategoriaBuscada);
                // efetivar
                ctx.SaveChanges();
            }
        }

        // deletar
        public void Deletar(int id)
        {
            using (GufosContext ctx = new GufosContext())
            {
                // encontrar o item
                // chave primaria da tabela
                Categorias Categoria = ctx.Categorias.Find(id);
                // remover do contexto
                ctx.Categorias.Remove(Categoria);
                // efetivar as mudanças no banco de dados
                ctx.SaveChanges();
            }   
        }


    }
}
