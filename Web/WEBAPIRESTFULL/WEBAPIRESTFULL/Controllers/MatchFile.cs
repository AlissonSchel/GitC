﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WEBAPIRESTFULL.Models;
using WEBAPIRESTFULL.Utils;

namespace WEBAPIRESTFULL.Controllers
{
    public class MatchFile : Single<MatchFile>
    {
        BibliotecaContextDB bibliotecaContextDB = new BibliotecaContextDB();
        public int QuantidadeUsuarios()
        {
            return bibliotecaContextDB.Usuarios.Count();
        }
    }
}