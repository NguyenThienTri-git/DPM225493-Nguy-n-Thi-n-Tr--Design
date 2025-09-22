using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_Pattern04_Prototype
{
    public abstract class Prototype
    {
        string id;
        public Prototype(string id)
        {
            this.id = id;
        }
        public string Id
        {
            get { return id; }
        }
        public abstract Prototype Clone();
    }
}
