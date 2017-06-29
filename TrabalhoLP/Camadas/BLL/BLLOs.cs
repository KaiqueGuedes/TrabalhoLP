using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace TrabalhoLP.Camadas.BLL
{
    public class BLLOs
    {
        public DataTable Visualizar()
        {
            DAL.DALLOs dallOr = new DAL.DALLOs();
            return dallOr.Visualizar();
        }

        public DataTable VisualizarP()
        {
            DAL.DALLOs dallOr = new DAL.DALLOs();
            return dallOr.VisualizarP();
        }

        public List<Model.Os> Select()
        {
            DAL.DALLOs dalOr = new DAL.DALLOs();
            return dalOr.Select2();
        }

        public List<Model.Os> Selectvo(int i, Model.Os Vo)
        {

            DAL.DALLOs dalOr = new DAL.DALLOs();
            return dalOr.Selectvo(i, Vo);

        }

        public List<Model.OsP> SelectvoP(int i, Model.OsP Vo)
        {

            DAL.DALLOs dalOr = new DAL.DALLOs();
            return dalOr.SelectvoP(i, Vo);

        }

        public List<Model.Os> SelectCli(string cliente)
        {

            DAL.DALLOs dalOrca = new DAL.DALLOs();
            return dalOrca.SelectCli(cliente);

        }

        public List<Model.Os> SelectInt(int idOs)
        {

            DAL.DALLOs dalOrca = new DAL.DALLOs();
            return dalOrca.SelectInt(idOs);

        }

        public void Insert(Model.Os oOr, List<Model.ModelProduto> lp)
        {
            DAL.DALLOs dalOr = new DAL.DALLOs();
            dalOr.Insert(oOr, lp);
        }

        public void Update(Model.Os oOr, List<Model.ModelProduto> lp)
        {

            DAL.DALLOs dalOr = new DAL.DALLOs();
            dalOr.Update(oOr, lp);
        }

        public void Delete(Model.Os  oOr)
        {
            DAL.DALLOs dalOr = new DAL.DALLOs();
            dalOr.Delete(oOr);
        }

    }
}

