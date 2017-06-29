using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLP.Camadas.BLL
{
    public class BLLfornecedor
    {
        public List<Model.Modelfornecedor> Select(int i, Model.Modelfornecedor Vo)
        {

            DAL.DALLfornecedor dalFornecedor = new DAL.DALLfornecedor();
            return dalFornecedor.Select(i, Vo);

        }
        public List<Model.Modelfornecedor> Select()
        {

            DAL.DALLfornecedor dalFornecedor = new DAL.DALLfornecedor();
            return dalFornecedor.Select();
        }

        public List<Model.Modelfornecedor> Select(int Codigo)
        {

            DAL.DALLfornecedor dalFornecedor = new DAL.DALLfornecedor();
            return dalFornecedor.Select();

        }

        public void Insert(Model.Modelfornecedor oForn)
        {
            DAL.DALLfornecedor dalFornecedor = new DAL.DALLfornecedor();
            dalFornecedor.Insert(oForn);
        }

        public void Update(Model.Modelfornecedor oForn)
        {
            DAL.DALLfornecedor dalFornecedor = new DAL.DALLfornecedor();
            dalFornecedor.Update(oForn);
        }

        public void Delete(Model.Modelfornecedor oForn)
        {
            DAL.DALLfornecedor dalFornecedor = new DAL.DALLfornecedor();
            dalFornecedor.Delete(oForn);
        }
    }
}
