using ExemploGenerico.Contracts;

namespace ExemploGenerico.DomainModels.Specifications
{
    public class NotSpecification<T>
    {

        public ISpecification<T> _left;

        public NotSpecification(ISpecification<T> left)
        {
            _left = left;
        }
        public bool IsSatisfiedBy(T t)
        {
            return !this._left.IsSatisfiedBy(t);
        }
    }
}
