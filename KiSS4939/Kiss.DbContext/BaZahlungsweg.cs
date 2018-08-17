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
    [KnownType(typeof(BaBank))]
    [KnownType(typeof(BaInstitution))]
    [KnownType(typeof(BaLand))]
    [KnownType(typeof(BaPerson))]
    public partial class BaZahlungsweg : PocoEntity, IAutoIdentityEntity<int>
    {
        public int AutoIdentityID 
        {
            get{ return BaZahlungswegID; } 
        }
    
        [DataMember]
        private int _baZahlungswegID;
        public int BaZahlungswegID
        {
            get { return _baZahlungswegID; }
            set
            {
                if (_baZahlungswegID != value)
                {
                    _baZahlungswegID = value;
                    RaisePropertyChanged("BaZahlungswegID");
                }
            }
        }
    
        [DataMember]
        private Nullable<int> _baPersonID;
        public Nullable<int> BaPersonID
        {
            get { return _baPersonID; }
            set
            {
                if (_baPersonID != value)
                {
                    _baPersonID = value;
                    RaisePropertyChanged("BaPersonID");
                    if (BaPerson != null && BaPerson.BaPersonID != value)
                    {
                        BaPerson = null;
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
        private System.DateTime _datumVon;
        public System.DateTime DatumVon
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
        private Nullable<int> _einzahlungsscheinCode;
        public Nullable<int> EinzahlungsscheinCode
        {
            get { return _einzahlungsscheinCode; }
            set
            {
                if (_einzahlungsscheinCode != value)
                {
                    _einzahlungsscheinCode = value;
                    RaisePropertyChanged("EinzahlungsscheinCode");
                }
            }
        }
    
        [DataMember]
        private Nullable<int> _baBankID;
        public Nullable<int> BaBankID
        {
            get { return _baBankID; }
            set
            {
                if (_baBankID != value)
                {
                    _baBankID = value;
                    RaisePropertyChanged("BaBankID");
                    if (BaBank != null && BaBank.BaBankID != value)
                    {
                        BaBank = null;
                    }
                }
            }
        }
    
        [DataMember]
        private string _bankKontoNummer;
        public string BankKontoNummer
        {
            get { return _bankKontoNummer; }
            set
            {
                if (_bankKontoNummer != value)
                {
                    _bankKontoNummer = value;
                    RaisePropertyChanged("BankKontoNummer");
                }
            }
        }
    
        [DataMember]
        private string _iBANNummer;
        public string IBANNummer
        {
            get { return _iBANNummer; }
            set
            {
                if (_iBANNummer != value)
                {
                    _iBANNummer = value;
                    RaisePropertyChanged("IBANNummer");
                }
            }
        }
    
        [DataMember]
        private string _postKontoNummer;
        public string PostKontoNummer
        {
            get { return _postKontoNummer; }
            set
            {
                if (_postKontoNummer != value)
                {
                    _postKontoNummer = value;
                    RaisePropertyChanged("PostKontoNummer");
                }
            }
        }
    
        [DataMember]
        private string _referenzNummer;
        public string ReferenzNummer
        {
            get { return _referenzNummer; }
            set
            {
                if (_referenzNummer != value)
                {
                    _referenzNummer = value;
                    RaisePropertyChanged("ReferenzNummer");
                }
            }
        }
    
        [DataMember]
        private string _adresseName;
        public string AdresseName
        {
            get { return _adresseName; }
            set
            {
                if (_adresseName != value)
                {
                    _adresseName = value;
                    RaisePropertyChanged("AdresseName");
                }
            }
        }
    
        [DataMember]
        private string _adresseName2;
        public string AdresseName2
        {
            get { return _adresseName2; }
            set
            {
                if (_adresseName2 != value)
                {
                    _adresseName2 = value;
                    RaisePropertyChanged("AdresseName2");
                }
            }
        }
    
        [DataMember]
        private string _adresseStrasse;
        public string AdresseStrasse
        {
            get { return _adresseStrasse; }
            set
            {
                if (_adresseStrasse != value)
                {
                    _adresseStrasse = value;
                    RaisePropertyChanged("AdresseStrasse");
                }
            }
        }
    
        [DataMember]
        private string _adresseHausNr;
        public string AdresseHausNr
        {
            get { return _adresseHausNr; }
            set
            {
                if (_adresseHausNr != value)
                {
                    _adresseHausNr = value;
                    RaisePropertyChanged("AdresseHausNr");
                }
            }
        }
    
        [DataMember]
        private string _adressePostfach;
        public string AdressePostfach
        {
            get { return _adressePostfach; }
            set
            {
                if (_adressePostfach != value)
                {
                    _adressePostfach = value;
                    RaisePropertyChanged("AdressePostfach");
                }
            }
        }
    
        [DataMember]
        private string _adressePLZ;
        public string AdressePLZ
        {
            get { return _adressePLZ; }
            set
            {
                if (_adressePLZ != value)
                {
                    _adressePLZ = value;
                    RaisePropertyChanged("AdressePLZ");
                }
            }
        }
    
        [DataMember]
        private string _adresseOrt;
        public string AdresseOrt
        {
            get { return _adresseOrt; }
            set
            {
                if (_adresseOrt != value)
                {
                    _adresseOrt = value;
                    RaisePropertyChanged("AdresseOrt");
                }
            }
        }
    
        [DataMember]
        private Nullable<int> _adresseLandCode;
        public Nullable<int> AdresseLandCode
        {
            get { return _adresseLandCode; }
            set
            {
                if (_adresseLandCode != value)
                {
                    _adresseLandCode = value;
                    RaisePropertyChanged("AdresseLandCode");
                    if (BaLand != null && BaLand.BaLandID != value)
                    {
                        BaLand = null;
                    }
                }
            }
        }
    
        [DataMember]
        private string _baZahlwegModulStdCodes;
        public string BaZahlwegModulStdCodes
        {
            get { return _baZahlwegModulStdCodes; }
            set
            {
                if (_baZahlwegModulStdCodes != value)
                {
                    _baZahlwegModulStdCodes = value;
                    RaisePropertyChanged("BaZahlwegModulStdCodes");
                }
            }
        }
    
        [DataMember]
        private byte[] _baZahlungswegTS;
        public byte[] BaZahlungswegTS
        {
            get { return _baZahlungswegTS; }
            set
            {
                if (_baZahlungswegTS != value)
                {
                    _baZahlungswegTS = value;
                    RaisePropertyChanged("BaZahlungswegTS");
                }
            }
        }
    
    
        [DataMember]
        private BaBank _baBank;
        public virtual BaBank BaBank
        {
            get { return _baBank; }
            set
            {
                if (_baBank != value)
                {
                    _baBank = value;
                    RaisePropertyChanged("BaBank");
    
                    if (value != null)
                    {
                        BaBankID = value.BaBankID;
                    }
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
        private BaLand _baLand;
        public virtual BaLand BaLand
        {
            get { return _baLand; }
            set
            {
                if (_baLand != value)
                {
                    _baLand = value;
                    RaisePropertyChanged("BaLand");
    
                    if (value != null)
                    {
                        AdresseLandCode = value.BaLandID;
                    }
                }
            }
        }
        [DataMember]
        private BaPerson _baPerson;
        public virtual BaPerson BaPerson
        {
            get { return _baPerson; }
            set
            {
                if (_baPerson != value)
                {
                    _baPerson = value;
                    RaisePropertyChanged("BaPerson");
    
                    if (value != null)
                    {
                        BaPersonID = value.BaPersonID;
                    }
                }
            }
        }
    }
    
}