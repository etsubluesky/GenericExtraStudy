using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExtraStudy
{
    public class NamedContainer<T>
    {
        public string Name { get; set; }
        public T Value { get; set; }

        public U ExampleMethodOfUType<U>() where U : new()
        {
            U something = new U();


            return something;
        }
    }
}
