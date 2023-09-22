using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Boligfirmaet__test_.Model
{
    /// <summary>
    /// The class <c> Apartment<\c> is a model of a apartment
    /// </summary>
    internal class Apartment
    {
        #region
        private short _kvm;
        private byte _numberOfRooms;
        private short _numberOfWindowsBay1Frosted;
        private short _numberOfWindowsBay1;
        private short _numberOfWindowsBay2;
        private short _numberOfWindowsBay3;

        internal short Kvm
        { 
            get { return _kvm; } 
            private set { _kvm = value; }
        }
        internal byte NumberOfRooms
        {
            get { return _numberOfRooms; }
            private set { _numberOfRooms = value; }
        }
        internal short NumberOfWindowsBay1Frosted
        {
            get { return _numberOfWindowsBay1Frosted; }
            private set { _numberOfWindowsBay1Frosted = value; }
        }
        internal short NumberOfWindowsBay1
        {
            get { return _numberOfWindowsBay1; }
            private set { _numberOfWindowsBay1 = value; }
        }
        internal short NumberOfWindowsBay2
        {
            get { return _numberOfWindowsBay2; }
            private set { _numberOfWindowsBay2 = value; }
        }
        internal short NumberOfWindowsBay3
        {
            get { return _numberOfWindowsBay3; }
            private set { _numberOfWindowsBay3 = value; }
        }
        #endregion

        #region constructor
        private Apartment()
        {

        }
        private Apartment(short kvm) : this()
        {
            _kvm = kvm;
        }
        private Apartment(short kvm, byte numberOfRooms) : this(kvm)
        {
            _numberOfRooms = numberOfRooms;
        }
        private Apartment(short kvm, byte numberOfRooms, short numberOfWindowsBay1Frosted) : this(kvm, numberOfRooms)
        {
            _numberOfWindowsBay1Frosted = numberOfWindowsBay1Frosted;
        }
        private Apartment(short kvm,byte numberOfRooms, short numberOfWindowsBay1Frosted, short numberOfWindowsBay1) : this(kvm,numberOfRooms, numberOfWindowsBay1Frosted)
        {
            _numberOfWindowsBay1 = numberOfWindowsBay1;
        }
        private Apartment(short kvm, byte numberOfRooms, short numberOfWindowsBay1Frosted, short numberOfWindowsBay1, short numberOfWindowsBay2) : this(kvm, numberOfRooms, numberOfWindowsBay1Frosted, numberOfWindowsBay1)
        {
            _numberOfWindowsBay2 = numberOfWindowsBay2;
        }
        internal Apartment(short kvm, byte numberOfRooms, short numberOfWindowsBay1Frosted, short numberOfWindowsBay1, short numberOfWindowsBay2, short numberOfWindowsBay3) : this(kvm, numberOfRooms,numberOfWindowsBay1Frosted, numberOfWindowsBay1, numberOfWindowsBay2)
        {
            _numberOfWindowsBay3 = numberOfWindowsBay3;
        }
        #endregion
    }
}
