using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_General_Concepts
{
    interface ICrudRepository<T>
    {
        bool Create(string model);
        bool Read();
        bool Update();
        bool Delete();
        void GetAll();

    }
}
