using HedonistProjeOdev.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedonistProjeOdev.SingletonPattern
{
   public class DBTool
    {
        private DBTool() { }
        private static HedonistDBEntities _hedonistEntities;
        public static HedonistDBEntities DBInstance
        {

            get
            {
                if (_hedonistEntities == null)
                {

                    _hedonistEntities = new HedonistDBEntities();
                 
                }
                return _hedonistEntities;


             
            }

        }
    }
}
