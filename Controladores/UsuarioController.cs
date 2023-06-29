using CeluCenter.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeluCenter.Controladores
{
    internal class UsuarioController
    {
        CompraVenta _context = new CompraVenta();
        public bool Login(string usuario, string password)
        {
            var UsuarioLogin = _context.Usuario.Where(x => x.Nom_Usuario == usuario && x.Password == password).SingleOrDefault();
            if (UsuarioLogin != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
