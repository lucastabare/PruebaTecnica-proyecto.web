using Newtonsoft.Json;
using PruebaTecnica.Proyecto.web.CLIENTES;
using PruebaTecnica.Proyecto.web.ENTITY.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Proyecto.web.BUSINESS
{
    public class BUPais
    {
        private Client client;

        public BUPais()
        {
            client = new Client();
        }

        public List<ResponsePais> ListaPaises(string token);
        {
               try
               {
                    return JsonConvert.DeseralizeObject<List<ResponsePais>>
               }
               catch(Exception ex)
               {
                    throw ex;
               }
        }
    }
}
