using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Boligfirmaet__test_.Model
{
    /// <summary>
    /// This is a model of the company  
    /// </summary>
    internal class HousingCompany
    {
        #region
        private double _money;
        private List<Apartment> _apartments = new List<Apartment>();
        private List<Employee> _workers = new List<Employee>();

        #endregion
        #region
        internal double Money
        {
            get { return _money; }
            set { _money = value; }
        }
        internal List<Apartment> Apartments
        {
            get { return  _apartments; }
            set { _apartments = value;}
        }
        internal List<Employee> Workers
        {
            get { return _workers; }
            set { _workers = value; }
        }
        #endregion
        #region constructor
        private HousingCompany()
        {

        }
        internal HousingCompany(long money) : this()
        {
            _money = money;
        }
        #endregion
    }
}
