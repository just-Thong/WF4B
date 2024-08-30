using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class DanhSachMonHoc
    {
        public ArrayList ds;
        public DanhSachMonHoc() { ds = new ArrayList(); }
        public MonHoc this[int index]
        {
            get { return ds[index] as MonHoc; }
            set { ds[index] = value; }
        }
        public void Them(MonHoc monHoc)
        {
            ds.Add(monHoc);
        }
        public override string ToString()
        {
            string s = "Danh sach mon hoc: ";
            foreach (object monHoc in ds)
            {
                s += monHoc as MonHoc + ";";
            }
            return s;
        }
    }
}
