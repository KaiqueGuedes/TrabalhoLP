using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLP.Camadas.BLL
{
   public  class BLLcliente
    {
        public List<Model.Modelcliente> Select(int i, Model.Modelcliente Vo)
        {

            DAL.DALLcliente dalCliente = new DAL.DALLcliente();
            return dalCliente.Select(i, Vo);

        }

        public List<Model.Modelcliente> Select()
        {

            DAL.DALLcliente dalCliente = new DAL.DALLcliente();
            return dalCliente.Select();
        }

        public List<Model.Modelcliente> Select(int Codigo)
        {

            DAL.DALLcliente dalCliente = new DAL.DALLcliente();
            return dalCliente.Select();

        }

        public void Insert(Model.Modelcliente oCli)
        {
            DAL.DALLcliente dalCliente = new DAL.DALLcliente();
            dalCliente.Insert(oCli);
        }

        public void Update(Model.Modelcliente oCli)
        {
            DAL.DALLcliente dalCli = new DAL.DALLcliente();
            dalCli.Update(oCli);
        }

        public void Delete(Model.Modelcliente oCli)
        {
            DAL.DALLcliente dalCli = new DAL.DALLcliente();
            dalCli.Delete(oCli);
        }

    }

}

