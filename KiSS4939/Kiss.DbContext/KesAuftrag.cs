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
    [KnownType(typeof(KesAuftrag_BaPerson))]
    [KnownType(typeof(KesDokument))]
    public partial class KesAuftrag : PocoEntity, IAutoIdentityEntity<int>, IAuditableEntity
    {
        public KesAuftrag()
        {
            this.KesAuftrag_BaPerson = new HashSet<KesAuftrag_BaPerson>();
            this.KesDokument = new HashSet<KesDokument>();
        }
    
        public int AutoIdentityID 
        {
            get{ return KesAuftragID; } 
        }
    
        [DataMember]
        private int _kesAuftragID;
        public int KesAuftragID
        {
            get { return _kesAuftragID; }
            set
            {
                if (_kesAuftragID != value)
                {
                    _kesAuftragID = value;
                    RaisePropertyChanged("KesAuftragID");
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
        private Nullable<System.DateTime> _datumAuftrag;
        public Nullable<System.DateTime> DatumAuftrag
        {
            get { return _datumAuftrag; }
            set
            {
                if (_datumAuftrag != value)
                {
                    _datumAuftrag = value;
                    RaisePropertyChanged("DatumAuftrag");
                }
            }
        }
    
        [DataMember]
        private Nullable<int> _documentID_Auftrag;
        public Nullable<int> DocumentID_Auftrag
        {
            get { return _documentID_Auftrag; }
            set
            {
                if (_documentID_Auftrag != value)
                {
                    _documentID_Auftrag = value;
                    RaisePropertyChanged("DocumentID_Auftrag");
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
        private Nullable<System.DateTime> _datumFrist;
        public Nullable<System.DateTime> DatumFrist
        {
            get { return _datumFrist; }
            set
            {
                if (_datumFrist != value)
                {
                    _datumFrist = value;
                    RaisePropertyChanged("DatumFrist");
                }
            }
        }
    
        [DataMember]
        private Nullable<int> _kesAuftragDurchCode;
        public Nullable<int> KesAuftragDurchCode
        {
            get { return _kesAuftragDurchCode; }
            set
            {
                if (_kesAuftragDurchCode != value)
                {
                    _kesAuftragDurchCode = value;
                    RaisePropertyChanged("KesAuftragDurchCode");
                }
            }
        }
    
        [DataMember]
        private string _anlass;
        public string Anlass
        {
            get { return _anlass; }
            set
            {
                if (_anlass != value)
                {
                    _anlass = value;
                    RaisePropertyChanged("Anlass");
                }
            }
        }
    
        [DataMember]
        private string _auftrag;
        public string Auftrag
        {
            get { return _auftrag; }
            set
            {
                if (_auftrag != value)
                {
                    _auftrag = value;
                    RaisePropertyChanged("Auftrag");
                }
            }
        }
    
        [DataMember]
        private Nullable<System.DateTime> _abschlussDatum;
        public Nullable<System.DateTime> AbschlussDatum
        {
            get { return _abschlussDatum; }
            set
            {
                if (_abschlussDatum != value)
                {
                    _abschlussDatum = value;
                    RaisePropertyChanged("AbschlussDatum");
                }
            }
        }
    
        [DataMember]
        private Nullable<int> _kesAuftragAbschlussgrundCode;
        public Nullable<int> KesAuftragAbschlussgrundCode
        {
            get { return _kesAuftragAbschlussgrundCode; }
            set
            {
                if (_kesAuftragAbschlussgrundCode != value)
                {
                    _kesAuftragAbschlussgrundCode = value;
                    RaisePropertyChanged("KesAuftragAbschlussgrundCode");
                }
            }
        }
    
        [DataMember]
        private Nullable<int> _documentID_BeschlussRueckmeldung;
        public Nullable<int> DocumentID_BeschlussRueckmeldung
        {
            get { return _documentID_BeschlussRueckmeldung; }
            set
            {
                if (_documentID_BeschlussRueckmeldung != value)
                {
                    _documentID_BeschlussRueckmeldung = value;
                    RaisePropertyChanged("DocumentID_BeschlussRueckmeldung");
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
        private byte[] _kesAuftragTS;
        public byte[] KesAuftragTS
        {
            get { return _kesAuftragTS; }
            set
            {
                if (_kesAuftragTS != value)
                {
                    _kesAuftragTS = value;
                    RaisePropertyChanged("KesAuftragTS");
                }
            }
        }
    
        [DataMember]
        private Nullable<int> _kesAuftragAbklaerungsartCode;
        public Nullable<int> KesAuftragAbklaerungsartCode
        {
            get { return _kesAuftragAbklaerungsartCode; }
            set
            {
                if (_kesAuftragAbklaerungsartCode != value)
                {
                    _kesAuftragAbklaerungsartCode = value;
                    RaisePropertyChanged("KesAuftragAbklaerungsartCode");
                }
            }
        }
    
        [DataMember]
        private bool _isKS;
        public bool IsKS
        {
            get { return _isKS; }
            set
            {
                if (_isKS != value)
                {
                    _isKS = value;
                    RaisePropertyChanged("IsKS");
                }
            }
        }
    
        [DataMember]
        private Nullable<int> _kesGefaehrdungsmeldungDurchCode;
        public Nullable<int> KesGefaehrdungsmeldungDurchCode
        {
            get { return _kesGefaehrdungsmeldungDurchCode; }
            set
            {
                if (_kesGefaehrdungsmeldungDurchCode != value)
                {
                    _kesGefaehrdungsmeldungDurchCode = value;
                    RaisePropertyChanged("KesGefaehrdungsmeldungDurchCode");
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
        [DataMember]
        private ICollection<KesAuftrag_BaPerson> _kesAuftrag_BaPerson;
        public virtual ICollection<KesAuftrag_BaPerson> KesAuftrag_BaPerson
        {
            get { return _kesAuftrag_BaPerson; }
            set
            {
                if (_kesAuftrag_BaPerson != value)
                {
                    _kesAuftrag_BaPerson = value;
                    RaisePropertyChanged("KesAuftrag_BaPerson");
                }
            }
        }
        [DataMember]
        private ICollection<KesDokument> _kesDokument;
        public virtual ICollection<KesDokument> KesDokument
        {
            get { return _kesDokument; }
            set
            {
                if (_kesDokument != value)
                {
                    _kesDokument = value;
                    RaisePropertyChanged("KesDokument");
                }
            }
        }
    }
    
}