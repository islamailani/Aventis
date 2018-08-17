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
    [KnownType(typeof(BaInstitution))]
    [KnownType(typeof(FaLeistung))]
    [KnownType(typeof(XUser))]
    public partial class KesPflegekinderaufsicht : PocoEntity, IAutoIdentityEntity<int>, IAuditableEntity
    {
        public int AutoIdentityID 
        {
            get{ return KesPflegekinderaufsichtID; } 
        }
    
        [DataMember]
        private int _kesPflegekinderaufsichtID;
        public int KesPflegekinderaufsichtID
        {
            get { return _kesPflegekinderaufsichtID; }
            set
            {
                if (_kesPflegekinderaufsichtID != value)
                {
                    _kesPflegekinderaufsichtID = value;
                    RaisePropertyChanged("KesPflegekinderaufsichtID");
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
        private Nullable<int> _userID;
        public Nullable<int> UserID
        {
            get { return _userID; }
            set
            {
                if (_userID != value)
                {
                    _userID = value;
                    RaisePropertyChanged("UserID");
                    if (XUser != null && XUser.UserID != value)
                    {
                        XUser = null;
                    }
                }
            }
        }
    
        [DataMember]
        private Nullable<int> _baInstitutionID;
        public Nullable<int> BaInstitutionID
        {
            get { return _baInstitutionID; }
            set
            {
                if (_baInstitutionID != value)
                {
                    _baInstitutionID = value;
                    RaisePropertyChanged("BaInstitutionID");
                    if (BaInstitution != null && BaInstitution.BaInstitutionID != value)
                    {
                        BaInstitution = null;
                    }
                }
            }
        }
    
        [DataMember]
        private Nullable<System.DateTime> _datumVon;
        public Nullable<System.DateTime> DatumVon
        {
            get { return _datumVon; }
            set
            {
                if (_datumVon != value)
                {
                    _datumVon = value;
                    RaisePropertyChanged("DatumVon");
                }
            }
        }
    
        [DataMember]
        private Nullable<System.DateTime> _datumBis;
        public Nullable<System.DateTime> DatumBis
        {
            get { return _datumBis; }
            set
            {
                if (_datumBis != value)
                {
                    _datumBis = value;
                    RaisePropertyChanged("DatumBis");
                }
            }
        }
    
        [DataMember]
        private Nullable<int> _kesPflegeartCode;
        public Nullable<int> KesPflegeartCode
        {
            get { return _kesPflegeartCode; }
            set
            {
                if (_kesPflegeartCode != value)
                {
                    _kesPflegeartCode = value;
                    RaisePropertyChanged("KesPflegeartCode");
                }
            }
        }
    
        [DataMember]
        private string _creator;
        public string Creator
        {
            get { return _creator; }
            set
            {
                if (_creator != value)
                {
                    _creator = value;
                    RaisePropertyChanged("Creator");
                }
            }
        }
    
        [DataMember]
        private System.DateTime _created;
        public System.DateTime Created
        {
            get { return _created; }
            set
            {
                if (_created != value)
                {
                    _created = value;
                    RaisePropertyChanged("Created");
                }
            }
        }
    
        [DataMember]
        private string _modifier;
        public string Modifier
        {
            get { return _modifier; }
            set
            {
                if (_modifier != value)
                {
                    _modifier = value;
                    RaisePropertyChanged("Modifier");
                }
            }
        }
    
        [DataMember]
        private System.DateTime _modified;
        public System.DateTime Modified
        {
            get { return _modified; }
            set
            {
                if (_modified != value)
                {
                    _modified = value;
                    RaisePropertyChanged("Modified");
                }
            }
        }
    
        [DataMember]
        private byte[] _kesPflegekinderaufsichtTS;
        public byte[] KesPflegekinderaufsichtTS
        {
            get { return _kesPflegekinderaufsichtTS; }
            set
            {
                if (_kesPflegekinderaufsichtTS != value)
                {
                    _kesPflegekinderaufsichtTS = value;
                    RaisePropertyChanged("KesPflegekinderaufsichtTS");
                }
            }
        }
    
    
        [DataMember]
        private BaInstitution _baInstitution;
        public virtual BaInstitution BaInstitution
        {
            get { return _baInstitution; }
            set
            {
                if (_baInstitution != value)
                {
                    _baInstitution = value;
                    RaisePropertyChanged("BaInstitution");
    
                    if (value != null)
                    {
                        BaInstitutionID = value.BaInstitutionID;
                    }
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
                        UserID = value.UserID;
                    }
                }
            }
        }
    }
    
}