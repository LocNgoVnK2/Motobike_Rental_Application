using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CategoryBUS
    {
        public static DataTable GetCategoryBUS()
        {
            return CategoryDAO.GetCategoryDAO();
        }
    }
}
