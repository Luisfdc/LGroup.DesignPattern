using ExemploGenerico.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploGenerico.DomainModels.Specifications
{
    public class AndSpecification<T>
    {
        public ISpecification<T> _left;
        public ISpecification<T> _rigth;

        public AndSpecification(ISpecification<T> left, ISpecification<T> rigth)
        {
            _left = left;
            _rigth = rigth;
        }
        public bool IsSatisfiedBy(T t)
        {
            return this._left.IsSatisfiedBy(t) && this._rigth.IsSatisfiedBy(t);
        }
    }
}
