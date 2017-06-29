using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLP.Camadas.BLL
{
    public class BLLProduto
    {
        public List<Model.ModelProduto> Select(int i, Model.ModelProduto Vo)
        {
            
            Camadas.DAL.DALLproduto dalProduto = new Camadas.DAL.DALLproduto();
            return dalProduto.Select(i, Vo);

        }

        public List<Model.ModelProduto> Select()
        {
            DAL.DALLproduto dalProduto = new DAL.DALLproduto();
            return dalProduto.Select();
        }

        public List<Model.ModelProduto> SelectById(int id)
        {
            DAL.DALLproduto dalProduto = new DAL.DALLproduto();
            return dalProduto.SelectById(id);
        }

        public List<Model.ModelProduto> SelectByNome(string nome)
        {
            DAL.DALLproduto dalProduto = new DAL.DALLproduto();
            return dalProduto.SelectByNome(nome);
        }

        public void Insert(Model.ModelProduto oProd)
        {
            DAL.DALLproduto dalProduto = new DAL.DALLproduto();
            dalProduto.Insert(oProd);
        }       

        public void Update(Model.ModelProduto oProd)
        {
            DAL.DALLproduto dalProduto = new DAL.DALLproduto();
            dalProduto.Update(oProd);
        }

        public void Update2(Model.ModelProduto oProd)
        {

            DAL.DALLproduto dalProd = new DAL.DALLproduto();
            dalProd.Update2(oProd);

        }

        public void Update3(Model.ModelProduto oProd)
        {
            DAL.DALLproduto dalProd = new DAL.DALLproduto();
            dalProd.Update3(oProd);
        }

        public void Delete(Model.ModelProduto oProd)
        {
            DAL.DALLproduto dalProduto = new DAL.DALLproduto();
            dalProduto.Delete(oProd);
        }
    }
}
