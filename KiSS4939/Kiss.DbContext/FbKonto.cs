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
    [KnownType(typeof(FbPeriode))]
    public partial class FbKonto : PocoEntity, IAutoIdentityEntity<int>
    {
        public int AutoIdentityID 
        {
            get{ return FbKontoID; } 
        }
    
        [DataMember]
        private int _fbKontoID;
        public int FbKontoID
        {
            get { return _fbKontoID; }
            set
            {
                if (_fbKontoID != value)
                {
                    _fbKontoID = value;
                    RaisePropertyChanged("FbKontoID");
                }
            }
        }
    
        [DataMember]
        private Nullable<int> _fbPeriodeID;
        public Nullable<int> FbPeriodeID
        {
            get { return _fbPeriodeID; }
            set
            {
                if (_fbPeriodeID != value)
                {
                    _fbPeriodeID = value;
                    RaisePropertyChanged("FbPeriodeID");
                    if (FbPeriode != null && FbPeriode.FbPeriodeID != value)
                    {
                        FbPeriode = null;
                    }
                }
            }
        }
    
        [DataMember]
        private int _kontoKlasseCode;
        public int KontoKlasseCode
        {
            get { return _kontoKlasseCode; }
            set
            {
                if (_kontoKlasseCode != value)
                {
                    _kontoKlasseCode = value;
                    RaisePropertyChanged("KontoKlasseCode");
                }
            }
        }
    
        [DataMember]
        private int _kontoTypCode;
        public int KontoTypCode
        {
            get { return _kontoTypCode; }
            set
            {
                if (_kontoTypCode != value)
                {
                    _kontoTypCode = value;
                    RaisePropertyChanged("KontoTypCode");
                }
            }
        }
    
        [DataMember]
        private int _kontoNr;
        public int KontoNr
        {
            get { return _kontoNr; }
            set
            {
                if (_kontoNr != value)
                {
                    _kontoNr = value;
                    RaisePropertyChanged("KontoNr");
                }
            }
        }
    
        [DataMember]
        private string _kontoName;
        public string KontoName
        {
            get { return _kontoName; }
            set
            {
                if (_kontoName != value)
                {
                    _kontoName = value;
                    RaisePropertyChanged("KontoName");
                }
            }
        }
    
        [DataMember]
        private decimal _eroeffnungsSaldo;
        public decimal EroeffnungsSaldo
        {
            get { return _eroeffnungsSaldo; }
            set
            {
                if (_eroeffnungsSaldo != value)
                {
                    _eroeffnungsSaldo = value;
                    RaisePropertyChanged("EroeffnungsSaldo");
                }
            }
        }
    
        [DataMember]
        private string _saldoGruppeName;
        public string SaldoGruppeName
        {
            get { return _saldoGruppeName; }
            set
            {
                if (_saldoGruppeName != value)
                {
                    _saldoGruppeName = value;
                    RaisePropertyChanged("SaldoGruppeName");
                }
            }
        }
    
        [DataMember]
        private Nullable<int> _fbDTAZugangID;
        public Nullable<int> FbDTAZugangID
        {
            get { return _fbDTAZugangID; }
            set
            {
                if (_fbDTAZugangID != value)
                {
                    _fbDTAZugangID = value;
                    RaisePropertyChanged("FbDTAZugangID");
                }
            }
        }
    
        [DataMember]
        private byte[] _fbKontoTS;
        public byte[] FbKontoTS
        {
            get { return _fbKontoTS; }
            set
            {
                if (_fbKontoTS != value)
                {
                    _fbKontoTS = value;
                    RaisePropertyChanged("FbKontoTS");
                }
            }
        }
    
        [DataMember]
        private string _fbDepotNr;
        public string FbDepotNr
        {
            get { return _fbDepotNr; }
            set
            {
                if (_fbDepotNr != value)
                {
                    _fbDepotNr = value;
                    RaisePropertyChanged("FbDepotNr");
                }
            }
        }
    
        [DataMember]
        private string _eroeffnungsSaldoModifier;
        public string EroeffnungsSaldoModifier
        {
            get { return _eroeffnungsSaldoModifier; }
            set
            {
                if (_eroeffnungsSaldoModifier != value)
                {
                    _eroeffnungsSaldoModifier = value;
                    RaisePropertyChanged("EroeffnungsSaldoModifier");
                }
            }
        }
    
        [DataMember]
        private Nullable<System.DateTime> _eroeffnungsSaldoModified;
        public Nullable<System.DateTime> EroeffnungsSaldoModified
        {
            get { return _eroeffnungsSaldoModified; }
            set
            {
                if (_eroeffnungsSaldoModified != value)
                {
                    _eroeffnungsSaldoModified = value;
                    RaisePropertyChanged("EroeffnungsSaldoModified");
                }
            }
        }
    
        [DataMember]
        private string _eroeffnungsSaldoCreator;
        public string EroeffnungsSaldoCreator
        {
            get { return _eroeffnungsSaldoCreator; }
            set
            {
                if (_eroeffnungsSaldoCreator != value)
                {
                    _eroeffnungsSaldoCreator = value;
                    RaisePropertyChanged("EroeffnungsSaldoCreator");
                }
            }
        }
    
        [DataMember]
        private Nullable<System.DateTime> _eroeffnungsSaldoCreated;
        public Nullable<System.DateTime> EroeffnungsSaldoCreated
        {
            get { return _eroeffnungsSaldoCreated; }
            set
            {
                if (_eroeffnungsSaldoCreated != value)
                {
                    _eroeffnungsSaldoCreated = value;
                    RaisePropertyChanged("EroeffnungsSaldoCreated");
                }
            }
        }
    
        [DataMember]
        private Nullable<decimal> _eroeffnungsSaldo_AtCreation;
        public Nullable<decimal> EroeffnungsSaldo_AtCreation
        {
            get { return _eroeffnungsSaldo_AtCreation; }
            set
            {
                if (_eroeffnungsSaldo_AtCreation != value)
                {
                    _eroeffnungsSaldo_AtCreation = value;
                    RaisePropertyChanged("EroeffnungsSaldo_AtCreation");
                }
            }
        }
    
    
        [DataMember]
        private FbPeriode _fbPeriode;
        public virtual FbPeriode FbPeriode
        {
            get { return _fbPeriode; }
            set
            {
                if (_fbPeriode != value)
                {
                    _fbPeriode = value;
                    RaisePropertyChanged("FbPeriode");
    
                    if (value != null)
                    {
                        FbPeriodeID = value.FbPeriodeID;
                    }
                }
            }
        }
    }
    
}