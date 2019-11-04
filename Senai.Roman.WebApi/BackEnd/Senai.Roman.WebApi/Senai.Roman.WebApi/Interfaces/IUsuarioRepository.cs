﻿using Senai.Roman.WebApi.Domains;
using Senai.Roman.WebApi.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Roman.WebApi.Interfaces
{
    interface IUsuarioRepository
    {
        Usuarios BuscarPorEmailESenha(LoginViewModel login);
        void Cadastrar(Usuarios usuario);
         
    }
}
