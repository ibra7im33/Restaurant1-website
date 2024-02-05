namespace Restorent.Models.Repositories
{
    public class MasterMenuRepository : IRepository<MasterMenu>
    {
        IList<MasterMenu> _masters;
        public MasterMenuRepository()
        {
            
        }
        public void Active(int id, MasterMenu entity)
        {
            throw new NotImplementedException();
        }

        public void Add(MasterMenu entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id, MasterMenu entity)
        {
            throw new NotImplementedException();
        }

        public MasterMenu Find(int T)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, MasterMenu entity)
        {
            throw new NotImplementedException();
        }

        public IList<MasterMenu> View()
        {
            throw new NotImplementedException(); 
        }

        public IList<MasterMenu> ViewFormClient()
        {
            throw new NotImplementedException();
        }
    }
}
