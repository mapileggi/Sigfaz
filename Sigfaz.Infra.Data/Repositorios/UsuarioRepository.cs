﻿using Sigfaz.Dominio.Entidades;
using Sigfaz.Dominio.Interfaces.Repositorios;
using Sigfaz.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sigfaz.Infra.Data.Repositorios
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly SigfazContext _db;

        public UsuarioRepository()
        {
            _db = new SigfazContext();
        }

        public Usuario ObterPorId(string id)
        {
            return _db.Usuarios.Find(id);
        }

        public IEnumerable<Usuario> ObterTodos()
        {
            return _db.Usuarios.ToList();
        }
        public void DesativarLock(string id)
        {
            _db.Usuarios.Find(id).LockoutEnabled = false;
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}