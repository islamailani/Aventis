//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Kiss.DbContext
{
    [DataContract(IsReference = true)]
    [KnownType(typeof(FaLeistung))]
    [KnownType(typeof(XUser))]
    public partial class FaLeistungArchiv : PocoEntity, IAutoIdentityEntity<int>
    {
        public int AutoIdentityID 
        {
            get{ return FaLeistungArchivID; } 
        }
    
        [DataMember]
        private int _faLeistungArchivID;
        public int FaLeistungArchivID
        {
            get { return _faLeistungArchivID; }
            set
            {
                if (_faLeistungArchivID != value)
                {
                    _faLeistungArchivID = value;
                    RaisePropertyChanged("FaLeistungArchivID");
                }
            }
        }
    
        [DataMember]
        private int _archiveID;
        public int ArchiveID
        {
            get { return _archiveID; }
            set
            {
                if (_archiveID != value)
                {
                    _archiveID = value;
                    RaisePropertyChanged("ArchiveID");
                }
            }
        }
    
        [DataMember]
        private int _faLeistungID;
        public int FaLeistungID
        {
            get { return _faLeistungID; }
            set
            {
                if (_faLeistungID != value)
                {
                    _faLeistungID = value;
                    RaisePropertyChanged("FaLeistungID");
                    if (FaLeistung != null && FaLeistung.FaLeistungID != value)
                    {
                        FaLeistung = null;
                    }
                }
            }
        }
    
        [DataMember]
        private string _archivNr;
        public string ArchivNr
        {
            get { return _archivNr; }
            set
            {
                if (_archivNr != value)
                {
                    _archivNr = value;
                    RaisePropertyChanged("ArchivNr");
                }
            }
        }
    
        [DataMember]
        private System.DateTime _checkIn;
        public System.DateTime CheckIn
        {
            get { return _checkIn; }
            set
            {
                if (_checkIn != value)
                {
                    _checkIn = value;
                    RaisePropertyChanged("CheckIn");
                }
            }
        }
    
        [DataMember]
        private Nullable<System.DateTime> _checkOut;
        public Nullable<System.DateTime> CheckOut
        {
            get { return _checkOut; }
            set
            {
                if (_checkOut != value)
                {
                    _checkOut = value;
                    RaisePropertyChanged("CheckOut");
                }
            }
        }
    
        [DataMember]
        private int _checkInUserID;
        public int CheckInUserID
        {
            get { return _checkInUserID; }
            set
            {
                if (_checkInUserID != value)
                {
                    _checkInUserID = value;
                    RaisePropertyChanged("CheckInUserID");
                    if (XUser != null && XUser.UserID != value)
                    {
                        XUser = null;
                    }
                }
            }
        }
    
        [DataMember]
        private Nullable<int> _checkOutUserID;
        public Nullable<int> CheckOutUserID
        {
            get { return _checkOutUserID; }
            set
            {
                if (_checkOutUserID != value)
                {
                    _checkOutUserID = value;
                    RaisePropertyChanged("CheckOutUserID");
                    if (XUser1 != null && XUser1.UserID != value)
                    {
                        XUser1 = null;
                    }
                }
            }
        }
    
        [DataMember]
        private byte[] _faLeistungArchivTS;
        public byte[] FaLeistungArchivTS
        {
            get { return _faLeistungArchivTS; }
            set
            {
                if (_faLeistungArchivTS != value)
                {
                    _faLeistungArchivTS = value;
                    RaisePropertyChanged("FaLeistungArchivTS");
                }
            }
        }
    
    
        [DataMember]
        private FaLeistung _faLeistung;
        public virtual FaLeistung FaLeistung
        {
            get { return _faLeistung; }
            set
            {
                if (_faLeistung != value)
                {
                    _faLeistung = value;
                    RaisePropertyChanged("FaLeistung");
    
                    if (value != null)
                    {
                        FaLeistungID = value.FaLeistungID;
                    }
                }
            }
        }
        [DataMember]
        private XUser _xUser;
        public virtual XUser XUser
        {
            get { return _xUser; }
            set
            {
                if (_xUser != value)
                {
                    _xUser = value;
                    RaisePropertyChanged("XUser");
    
                    if (value != null)
                    {
                        CheckInUserID = value.UserID;
                    }
                }
            }
        }
        [DataMember]
        private XUser _xUser1;
        public virtual XUser XUser1
        {
            get { return _xUser1; }
            set
            {
                if (_xUser1 != value)
                {
                    _xUser1 = value;
                    RaisePropertyChanged("XUser1");
    
                    if (value != null)
                    {
                        CheckOutUserID = value.UserID;
                    }
                }
            }
        }
    }
    
}