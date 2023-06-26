using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CategoryDTO
    {

        private int id;
        private string name;
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public CategoryDTO(int id, string name)
            {
                Id = id;
                Name = name;
            }
        

    }
}
