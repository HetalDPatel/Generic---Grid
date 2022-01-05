using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericGridComponent_RCL
{
    public interface IGridGeneric<T>
    {

        List<T> DataSource { get; set; }
        List<T> ItemList { get; set; }
        void RefreshGrid(List<T> itemlist);
    }
}
