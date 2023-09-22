using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Boligfirmaet__test_.Model
{
    internal abstract class Employee
    {
        private int _hourlyRate;
        private string _type;

        public int HourlyRate
        {
            get { return _hourlyRate; }
            set { _hourlyRate = value; }
        }
        protected string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        #region constructor
        protected Employee(string type)
        {
            Type = type;
        }
        protected Employee(string type, int hourlyRate) : this(type)
        {
            HourlyRate = hourlyRate;
        }
        #endregion
    }
}
