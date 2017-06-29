using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLP.Camadas.BLL
{
    public class BLLVendedor
    {
        public List<Model.ModelVendedor> Select(int i, Model.ModelVendedor Vo)
        {

            DAL.DALLVendedor dalVendedor = new DAL.DALLVendedor();
            return dalVendedor.Select(i, Vo);

        }
        public List<Model.ModelVendedor> Select()
        {

            DAL.DALLVendedor dalVendedor = new DAL.DALLVendedor();
            return dalVendedor.Select();
        }

        public List<Model.ModelVendedor> Select(int Codigo)
        {

            DAL.DALLVendedor dalVendedor = new DAL.DALLVendedor();
            return dalVendedor.Select();

        }

        public void Insert(Model.ModelVendedor oForn)
        {
            DAL.DALLVendedor dalVendedor = new DAL.DALLVendedor();
            dalVendedor.Insert(oForn);
        }

        public void Update(Model.ModelVendedor oForn)
        {
            DAL.DALLVendedor dalVendedor = new DAL.DALLVendedor();
            dalVendedor.Update(oForn);
        }

        public void Delete(Model.ModelVendedor oForn)
        {
            DAL.DALLVendedor dalVendedor = new DAL.DALLVendedor();
            dalVendedor.Delete(oForn);
        }
    }
}

   