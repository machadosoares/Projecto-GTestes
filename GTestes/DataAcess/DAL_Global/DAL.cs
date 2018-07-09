using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.DAL_Global
{
    public class DAL
    {

        DAL()
        {

        }

        internal bool Create(object obj)
        {
            return true;
        }

        internal object Read()
        {
            return new object();
        }

        internal bool Update()
        {
            return true;
        }
        internal bool Delete()
        {
            return true;
        }
    }
}
