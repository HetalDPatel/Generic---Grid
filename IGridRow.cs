using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericGridComponent_RCL
{
    public interface IGridRow<T>
    {
        public Grid<T> Grid { get; set; }
        public T Record { get; set; }
    }
}
