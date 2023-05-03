using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagement.DataStorages
{
    internal class DataStorage<T> where T : class
    {
        public DataStorage() { }
        public void Create(T data) { }
        public T GetListofData(T id) 
        {
            return id;
        }
        public void Delete(T data) { }
    }
}
