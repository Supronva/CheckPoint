using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarPark.InterfaceCarPark;

namespace CarPark.ClassCarPark
{
    public class CarStation:ICollection<IVehicle>
    {
        #region Fields
        private string collectionNameTaxiStation;

        private ICollection<IVehicle> vehicles = new List<IVehicle>();
        #endregion

        #region Properties
        public string CollectionNameTaxiStation
        {
            get { return collectionNameTaxiStation; }
            set { collectionNameTaxiStation = value; }
        }
    #endregion

        #region Realization of ICollection
        public void Add(IVehicle item)
        {
            vehicles.Add(item);
        }

        public void Clear()
        {
            vehicles.Clear();
        }

        public bool Contains(IVehicle item)
        {
            return vehicles.Contains(item);
        }

        public void CopyTo(IVehicle[] array, int arrayIndex)
        {
            vehicles.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get {return vehicles.Count(); }
        }

        public bool IsReadOnly
        {
            get { return vehicles.IsReadOnly; }
        }

        public bool Remove(IVehicle item)
        {
            return vehicles.Remove(item);
        }

        public IEnumerator<IVehicle> GetEnumerator()
        {
            return vehicles.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        #endregion


        #region Methods
        protected void Sort(IComparer<IVehicle> comparer)
        {
            var newList = vehicles.ToList();
            newList.Sort(comparer);
            vehicles = newList;
        }

        public void SortBy()
        {
            this.Sort(new VehicleComparerByExpenseFuel());
        }

        public IEnumerable<IVehicle> GetCarsDiapasoneForSpeedCar(double lowvalue, double highvalue)
        {
            return vehicles.Where(x => (x.SpeedCar >= lowvalue && x.SpeedCar<= highvalue));
        }

        private static int NewMethod(CarStation station)
        {
            int s = 0;
            foreach (var i in station)
            {
                s += i.PriceCar;
            }
            return s;
        }
        #endregion
    }
}
