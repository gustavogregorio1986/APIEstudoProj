﻿using APIEstudoProj.Data.Contexto;
using APIEstudoProj.Data.Repositorio.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace APIEstudoProj.Data.Repositorio
{
    public class GenericRepositorio<T> : IGenericRepositorio<T>, IDisposable where T : class
    {
        private readonly APIEstudoProjContexto _db;

        public GenericRepositorio()
        {
            var options = new DbContextOptionsBuilder<APIEstudoProjContexto>().UseSqlServer("ConnectionStrings").Options;
            _db = new APIEstudoProjContexto(options);
        }

        public void Adicionar(T entidade)
        {
            _db.Set<T>().Add(entidade);
            Commit();
           
        }

        public void Atualizar(T entidade)
        {
            _db.Entry(entidade).State = EntityState.Modified;
            Commit();
        }

        public T Buscar(params object[] Key)
        {
            return _db.Set<T>().Find(Key);
        }

        public void Commit()
        {
            _db.SaveChanges();
        }

        public void Deletar(int i)
        {
            var obj = Buscar(i);
            _db.Set<T>().Remove(obj);
            Commit();
        }

        public void Dispose()
        {
            if (_db != null)
            {
                _db.Dispose();
            }

            GC.SuppressFinalize(this);
        }

        public List<T> Obter(Expression<Func<T, bool>> predicate)
        {
            return _db.Set<T>().Where(predicate).ToList();
        }

        public List<T> ObterTodos()
        {
            return _db.Set<T>().ToList();
        }

        public T Primeiro(Expression<Func<T, bool>> predicate)
        {
            return _db.Set<T>().Where(predicate).FirstOrDefault();
        }
    }
}
