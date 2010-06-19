using PeanutButter.Business.Entities;
using PeanutButter.Business.Entities.Enums;

namespace PeanutButter.Business.Facade
{
    public interface IBusinessLayerManager
    {
        void AddBread(Bread bread);

        void AddFlavoring(Flavoring flavoring);

        void Slice(int numberOfSlices);

        void AddTopping(Topping topping);
    }
}
