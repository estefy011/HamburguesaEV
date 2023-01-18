using HamburguesaEV.Models;
using SQLite;


namespace HamburguesaEV.Data
{
    public class EV_BurgerDatabase
    {
        string _dbPath;
        private SQLiteConnection conn;
        public EV_BurgerDatabase(string DatabasePath)
        {
            _dbPath = DatabasePath;
        }
        private void Init()
        {
            if (conn != null)
                return;
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<BurgerEV>();
        }
        public int AddNewBurger(BurgerEV burgerEV)
        {
            Init();
            // int result = conn.Insert(burger);
            //  return result;
            if (burgerEV.Id != 0)
            {
                conn.Update(burgerEV);
                return burgerEV.Id;
            }
            else
            {
                return conn.Insert(burgerEV);
            }
        }
        public List<BurgerEV> GetAllBurgers()
        {
            Init();
            List<BurgerEV> burgersEV = conn.Table<BurgerEV>().ToList();
            return burgersEV;
        }
        public int DeleteBurger(BurgerEV itemEV)
        {
            Init();

            return conn.Delete(itemEV);
        }

    }
}
