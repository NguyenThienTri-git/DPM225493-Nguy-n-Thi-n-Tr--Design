using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_Pattern05_Singleton
{
    internal class Singleton
    {
        static Singleton instance;
        
        protected Singleton()
        {
        }
        public static Singleton Instance()
        {
            
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}
