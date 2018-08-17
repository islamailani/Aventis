//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;

namespace Kiss.Model
{
    [DataContract(IsReference = true)]
    [KnownType(typeof(BaInstitution))]
    [KnownType(typeof(BaPerson))]
    [KnownType(typeof(FaLeistung))]
    [KnownType(typeof(XUser))]
    [KnownType(typeof(FaDokumentAblage_BaPerson))]
    [KnownType(typeof(XDocument))]
    public partial class FaDokumentAblage: EntityBase<FaDokumentAblage>, IObjectWithChangeTracker
    {
        #region Primitive Properties
    
        [DataMember]
        public int FaDokumentAblageID
        {
            get { return _faDokumentAblageID; }
            set
            {
                if (_faDokumentAblageID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'FaDokumentAblageID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _faDokumentAblageID = value;
                    OnPropertyChanged("FaDokumentAblageID");
                }
            }
        }
        private int _faDokumentAblageID;
    
        [DataMember]
        public int FaLeistungID
        {
            get { return _faLeistungID; }
            set
            {
                if (_faLeistungID != value)
                {
                    ChangeTracker.RecordOriginalValue("FaLeistungID", _faLeistungID);
                    if (!IsDeserializing)
                    {
                        if (FaLeistung != null && FaLeistung.FaLeistungID != value)
                        {
                            FaLeistung = null;
                        }
                    }
                    _faLeistungID = value;
                    OnPropertyChanged("FaLeistungID");
                }
            }
        }
        private int _faLeistungID;
    
        [DataMember]
        public int UserID
        {
            get { return _userID; }
            set
            {
                if (_userID != value)
                {
                    ChangeTracker.RecordOriginalValue("UserID", _userID);
                    if (!IsDeserializing)
                    {
                        if (XUser != null && XUser.UserID != value)
                        {
                            XUser = null;
                        }
                    }
                    _userID = value;
                    OnPropertyChanged("UserID");
                }
            }
        }
        private int _userID;
    
        [DataMember]
        public Nullable<int> BaPersonID_Adressat
        {
            get { return _baPersonID_Adressat; }
            set
            {
                if (_baPersonID_Adressat != value)
                {
                    ChangeTracker.RecordOriginalValue("BaPersonID_Adressat", _baPersonID_Adressat);
                    if (!IsDeserializing)
                    {
                        if (BaPerson != null && BaPerson.BaPersonID != value)
                        {
                            BaPerson = null;
                        }
                    }
                    _baPersonID_Adressat = value;
                    OnPropertyChanged("BaPersonID_Adressat");
                }
            }
        }
        private Nullable<int> _baPersonID_Adressat;
    
        [DataMember]
        public Nullable<int> BaInstitutionID_Adressat
        {
            get { return _baInstitutionID_Adressat; }
            set
            {
                if (_baInstitutionID_Adressat != value)
                {
                    ChangeTracker.RecordOriginalValue("BaInstitutionID_Adressat", _baInstitutionID_Adressat);
                    if (!IsDeserializing)
                    {
                        if (BaInstitution != null && BaInstitution.BaInstitutionID != value)
                        {
                            BaInstitution = null;
                        }
                    }
                    _baInstitutionID_Adressat = value;
                    OnPropertyChanged("BaInstitutionID_Adressat");
                }
            }
        }
        private Nullable<int> _baInstitutionID_Adressat;
    
        [DataMember]
        public Nullable<int> FaDokumentAblageInhaltCode
        {
            get { return _faDokumentAblageInhaltCode; }
            set
            {
                if (_faDokumentAblageInhaltCode != value)
                {
                    _faDokumentAblageInhaltCode = value;
                    OnPropertyChanged("FaDokumentAblageInhaltCode");
                }
            }
        }
        private Nullable<int> _faDokumentAblageInhaltCode;
    
        [DataMember]
        public Nullable<System.DateTime> DatumErstellung
        {
            get { return _datumErstellung; }
            set
            {
                if (_datumErstellung != value)
                {
                    _datumErstellung = value;
                    OnPropertyChanged("DatumErstellung");
                }
            }
        }
        private Nullable<System.DateTime> _datumErstellung;
    
        [DataMember]
        public Nullable<System.DateTime> DatumGueltigVon
        {
            get { return _datumGueltigVon; }
            set
            {
                if (_datumGueltigVon != value)
                {
                    _datumGueltigVon = value;
                    OnPropertyChanged("DatumGueltigVon");
                }
            }
        }
        private Nullable<System.DateTime> _datumGueltigVon;
    
        [DataMember]
        public Nullable<System.DateTime> DatumGueltigBis
        {
            get { return _datumGueltigBis; }
            set
            {
                if (_datumGueltigBis != value)
                {
                    _datumGueltigBis = value;
                    OnPropertyChanged("DatumGueltigBis");
                }
            }
        }
        private Nullable<System.DateTime> _datumGueltigBis;
    
        [DataMember]
        public string Stichwort
        {
            get { return _stichwort; }
            set
            {
                if (_stichwort != value)
                {
                    _stichwort = value;
                    OnPropertyChanged("Stichwort");
                }
            }
        }
        private string _stichwort;
    
        [DataMember]
        public string Bemerkung
        {
            get { return _bemerkung; }
            set
            {
                if (_bemerkung != value)
                {
                    _bemerkung = value;
                    OnPropertyChanged("Bemerkung");
                }
            }
        }
        private string _bemerkung;
    
        [DataMember]
        public Nullable<int> DocumentID
        {
            get { return _documentID; }
            set
            {
                if (_documentID != value)
                {
                    ChangeTracker.RecordOriginalValue("DocumentID", _documentID);
                    if (!IsDeserializing)
                    {
                        if (XDocument != null && XDocument.DocumentID != value)
                        {
                            XDocument = null;
                        }
                    }
                    _documentID = value;
                    OnPropertyChanged("DocumentID");
                }
            }
        }
        private Nullable<int> _documentID;
    
        [DataMember]
        public string Creator
        {
            get { return _creator; }
            set
            {
                if (_creator != value)
                {
                    _creator = value;
                    OnPropertyChanged("Creator");
                }
            }
        }
        private string _creator;
    
        [DataMember]
        public System.DateTime Created
        {
            get { return _created; }
            set
            {
                if (_created != value)
                {
                    _created = value;
                    OnPropertyChanged("Created");
                }
            }
        }
        private System.DateTime _created;
    
        [DataMember]
        public string Modifier
        {
            get { return _modifier; }
            set
            {
                if (_modifier != value)
                {
                    _modifier = value;
                    OnPropertyChanged("Modifier");
                }
            }
        }
        private string _modifier;
    
        [DataMember]
        public System.DateTime Modified
        {
            get { return _modified; }
            set
            {
                if (_modified != value)
                {
                    _modified = value;
                    OnPropertyChanged("Modified");
                }
            }
        }
        private System.DateTime _modified;
    
        [DataMember]
        public byte[] FaDokumentAblageTS
        {
            get { return _faDokumentAblageTS; }
            set
            {
                if (_faDokumentAblageTS != value)
                {
                    _faDokumentAblageTS = value;
                    OnPropertyChanged("FaDokumentAblageTS");
                }
            }
        }
        private byte[] _faDokumentAblageTS;
    
        [DataMember]
        public string FaThemaDokAblageCodes
        {
            get { return _faThemaDokAblageCodes; }
            set
            {
                if (_faThemaDokAblageCodes != value)
                {
                    _faThemaDokAblageCodes = value;
                    OnPropertyChanged("FaThemaDokAblageCodes");
                }
            }
        }
        private string _faThemaDokAblageCodes;

        #endregion

        #region Navigation Properties
    
        [DataMember]
        public BaInstitution BaInstitution
        {
            get { return _baInstitution; }
            set
            {
                if (!ReferenceEquals(_baInstitution, value))
                {
                    var previousValue = _baInstitution;
                    _baInstitution = value;
                    FixupBaInstitution(previousValue);
                    OnNavigationPropertyChanged("BaInstitution");
                }
            }
        }
        private BaInstitution _baInstitution;
    
        [DataMember]
        public BaPerson BaPerson
        {
            get { return _baPerson; }
            set
            {
                if (!ReferenceEquals(_baPerson, value))
                {
                    var previousValue = _baPerson;
                    _baPerson = value;
                    FixupBaPerson(previousValue);
                    OnNavigationPropertyChanged("BaPerson");
                }
            }
        }
        private BaPerson _baPerson;
    
        [DataMember]
        public FaLeistung FaLeistung
        {
            get { return _faLeistung; }
            set
            {
                if (!ReferenceEquals(_faLeistung, value))
                {
                    var previousValue = _faLeistung;
                    _faLeistung = value;
                    FixupFaLeistung(previousValue);
                    OnNavigationPropertyChanged("FaLeistung");
                }
            }
        }
        private FaLeistung _faLeistung;
    
        [DataMember]
        public XUser XUser
        {
            get { return _xUser; }
            set
            {
                if (!ReferenceEquals(_xUser, value))
                {
                    var previousValue = _xUser;
                    _xUser = value;
                    FixupXUser(previousValue);
                    OnNavigationPropertyChanged("XUser");
                }
            }
        }
        private XUser _xUser;
    
        [DataMember]
        public TrackableCollection<FaDokumentAblage_BaPerson> FaDokumentAblage_BaPerson
        {
            get
            {
                if (_faDokumentAblage_BaPerson == null)
                {
                    _faDokumentAblage_BaPerson = new TrackableCollection<FaDokumentAblage_BaPerson>();
                    _faDokumentAblage_BaPerson.CollectionChanged += FixupFaDokumentAblage_BaPerson;
                }
                return _faDokumentAblage_BaPerson;
            }
            set
            {
                if (!ReferenceEquals(_faDokumentAblage_BaPerson, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_faDokumentAblage_BaPerson != null)
                    {
                        _faDokumentAblage_BaPerson.CollectionChanged -= FixupFaDokumentAblage_BaPerson;
                    }
                    _faDokumentAblage_BaPerson = value;
                    if (_faDokumentAblage_BaPerson != null)
                    {
                        _faDokumentAblage_BaPerson.CollectionChanged += FixupFaDokumentAblage_BaPerson;
                    }
                    OnNavigationPropertyChanged("FaDokumentAblage_BaPerson");
                }
            }
        }
        private TrackableCollection<FaDokumentAblage_BaPerson> _faDokumentAblage_BaPerson;
    
        [DataMember]
        public XDocument XDocument
        {
            get { return _xDocument; }
            set
            {
                if (!ReferenceEquals(_xDocument, value))
                {
                    var previousValue = _xDocument;
                    _xDocument = value;
                    FixupXDocument(previousValue);
                    OnNavigationPropertyChanged("XDocument");
                }
            }
        }
        private XDocument _xDocument;

        #endregion

        #region ChangeTracking
    
        protected bool IsDeserializing { get; private set; }
    
        [OnDeserializing]
        public void OnDeserializingMethod(StreamingContext context)
        {
            IsDeserializing = true;
        }
    
        [OnDeserialized]
        public void OnDeserializedMethod(StreamingContext context)
        {
            IsDeserializing = false;
            ChangeTracker.ChangeTrackingEnabled = true;
        }
    
        protected override void ClearNavigationProperties()
        {
            BaInstitution = null;
            BaPerson = null;
            FaLeistung = null;
            XUser = null;
            FaDokumentAblage_BaPerson.Clear();
            XDocument = null;
        }

        #endregion

        #region Association Fixup
    
        private void FixupBaInstitution(BaInstitution previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.FaDokumentAblage.Contains(this))
            {
                previousValue.FaDokumentAblage.Remove(this);
            }
    
            if (BaInstitution != null)
            {
                if (!BaInstitution.FaDokumentAblage.Contains(this))
                {
                    BaInstitution.FaDokumentAblage.Add(this);
                }
    
                BaInstitutionID_Adressat = BaInstitution.BaInstitutionID;
            }
            else if (!skipKeys)
            {
                BaInstitutionID_Adressat = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("BaInstitution")
                    && (ChangeTracker.OriginalValues["BaInstitution"] == BaInstitution))
                {
                    ChangeTracker.OriginalValues.Remove("BaInstitution");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("BaInstitution", previousValue);
                }
                if (BaInstitution != null && !BaInstitution.ChangeTracker.ChangeTrackingEnabled)
                {
                    BaInstitution.StartTracking();
                }
            }
        }
    
        private void FixupBaPerson(BaPerson previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.FaDokumentAblage.Contains(this))
            {
                previousValue.FaDokumentAblage.Remove(this);
            }
    
            if (BaPerson != null)
            {
                if (!BaPerson.FaDokumentAblage.Contains(this))
                {
                    BaPerson.FaDokumentAblage.Add(this);
                }
    
                BaPersonID_Adressat = BaPerson.BaPersonID;
            }
            else if (!skipKeys)
            {
                BaPersonID_Adressat = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("BaPerson")
                    && (ChangeTracker.OriginalValues["BaPerson"] == BaPerson))
                {
                    ChangeTracker.OriginalValues.Remove("BaPerson");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("BaPerson", previousValue);
                }
                if (BaPerson != null && !BaPerson.ChangeTracker.ChangeTrackingEnabled)
                {
                    BaPerson.StartTracking();
                }
            }
        }
    
        private void FixupFaLeistung(FaLeistung previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.FaDokumentAblage.Contains(this))
            {
                previousValue.FaDokumentAblage.Remove(this);
            }
    
            if (FaLeistung != null)
            {
                if (!FaLeistung.FaDokumentAblage.Contains(this))
                {
                    FaLeistung.FaDokumentAblage.Add(this);
                }
    
                FaLeistungID = FaLeistung.FaLeistungID;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("FaLeistung")
                    && (ChangeTracker.OriginalValues["FaLeistung"] == FaLeistung))
                {
                    ChangeTracker.OriginalValues.Remove("FaLeistung");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("FaLeistung", previousValue);
                }
                if (FaLeistung != null && !FaLeistung.ChangeTracker.ChangeTrackingEnabled)
                {
                    FaLeistung.StartTracking();
                }
            }
        }
    
        private void FixupXUser(XUser previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.FaDokumentAblage.Contains(this))
            {
                previousValue.FaDokumentAblage.Remove(this);
            }
    
            if (XUser != null)
            {
                if (!XUser.FaDokumentAblage.Contains(this))
                {
                    XUser.FaDokumentAblage.Add(this);
                }
    
                UserID = XUser.UserID;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("XUser")
                    && (ChangeTracker.OriginalValues["XUser"] == XUser))
                {
                    ChangeTracker.OriginalValues.Remove("XUser");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("XUser", previousValue);
                }
                if (XUser != null && !XUser.ChangeTracker.ChangeTrackingEnabled)
                {
                    XUser.StartTracking();
                }
            }
        }
    
        private void FixupXDocument(XDocument previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.FaDokumentAblage.Contains(this))
            {
                previousValue.FaDokumentAblage.Remove(this);
            }
    
            if (XDocument != null)
            {
                if (!XDocument.FaDokumentAblage.Contains(this))
                {
                    XDocument.FaDokumentAblage.Add(this);
                }
    
                DocumentID = XDocument.DocumentID;
            }
            else if (!skipKeys)
            {
                DocumentID = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("XDocument")
                    && (ChangeTracker.OriginalValues["XDocument"] == XDocument))
                {
                    ChangeTracker.OriginalValues.Remove("XDocument");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("XDocument", previousValue);
                }
                if (XDocument != null && !XDocument.ChangeTracker.ChangeTrackingEnabled)
                {
                    XDocument.StartTracking();
                }
            }
        }
    
        private void FixupFaDokumentAblage_BaPerson(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (FaDokumentAblage_BaPerson item in e.NewItems)
                {
                    item.FaDokumentAblage = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("FaDokumentAblage_BaPerson", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (FaDokumentAblage_BaPerson item in e.OldItems)
                {
                    if (ReferenceEquals(item.FaDokumentAblage, this))
                    {
                        item.FaDokumentAblage = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("FaDokumentAblage_BaPerson", item);
                    }
                }
            }
        }

        #endregion

        #region Methods
    
    	public override bool Equals(object obj)
    	{
    		if (obj == null)
    		{
    			return false;
    		}
    		
    		if (ReferenceEquals(this, obj))
    		{
    			return true;
    		}
    
    		if (GetType() != obj.GetType())
    		{
    			return false;
    		}
    
    		var entity = (FaDokumentAblage)obj;
    		if (!_faDokumentAblageID.Equals(entity.FaDokumentAblageID) || _faDokumentAblageID == 0)
    		{
    			return false;
    		}
    		
    		return true;
    	}
    	
    	public override int GetHashCode()
        {
            return _faDokumentAblageID.GetHashCode();
        }

        #endregion

    }
}