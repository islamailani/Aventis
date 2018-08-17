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
    [KnownType(typeof(KesMassnahme))]
    [KnownType(typeof(XDocument))]
    public partial class KesMassnahmeBericht: EntityBase<KesMassnahmeBericht>, IObjectWithChangeTracker
    {
        #region Primitive Properties
    
        [DataMember]
        public int KesMassnahmeBerichtID
        {
            get { return _kesMassnahmeBerichtID; }
            set
            {
                if (_kesMassnahmeBerichtID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'KesMassnahmeBerichtID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _kesMassnahmeBerichtID = value;
                    OnPropertyChanged("KesMassnahmeBerichtID");
                }
            }
        }
        private int _kesMassnahmeBerichtID;
    
        [DataMember]
        public int KesMassnahmeID
        {
            get { return _kesMassnahmeID; }
            set
            {
                if (_kesMassnahmeID != value)
                {
                    ChangeTracker.RecordOriginalValue("KesMassnahmeID", _kesMassnahmeID);
                    if (!IsDeserializing)
                    {
                        if (KesMassnahme != null && KesMassnahme.KesMassnahmeID != value)
                        {
                            KesMassnahme = null;
                        }
                    }
                    _kesMassnahmeID = value;
                    OnPropertyChanged("KesMassnahmeID");
                }
            }
        }
        private int _kesMassnahmeID;
    
        [DataMember]
        public Nullable<System.DateTime> DatumVon
        {
            get { return _datumVon; }
            set
            {
                if (_datumVon != value)
                {
                    _datumVon = value;
                    OnPropertyChanged("DatumVon");
                }
            }
        }
        private Nullable<System.DateTime> _datumVon;
    
        [DataMember]
        public Nullable<System.DateTime> DatumBis
        {
            get { return _datumBis; }
            set
            {
                if (_datumBis != value)
                {
                    _datumBis = value;
                    OnPropertyChanged("DatumBis");
                }
            }
        }
        private Nullable<System.DateTime> _datumBis;
    
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
        public Nullable<int> DocumentID_Bericht
        {
            get { return _documentID_Bericht; }
            set
            {
                if (_documentID_Bericht != value)
                {
                    ChangeTracker.RecordOriginalValue("DocumentID_Bericht", _documentID_Bericht);
                    if (!IsDeserializing)
                    {
                        if (XDocumentBericht != null && XDocumentBericht.DocumentID != value)
                        {
                            XDocumentBericht = null;
                        }
                    }
                    _documentID_Bericht = value;
                    OnPropertyChanged("DocumentID_Bericht");
                }
            }
        }
        private Nullable<int> _documentID_Bericht;
    
        [DataMember]
        public Nullable<int> DocumentID_Versand
        {
            get { return _documentID_Versand; }
            set
            {
                if (_documentID_Versand != value)
                {
                    ChangeTracker.RecordOriginalValue("DocumentID_Versand", _documentID_Versand);
                    if (!IsDeserializing)
                    {
                        if (XDocumentVersand != null && XDocumentVersand.DocumentID != value)
                        {
                            XDocumentVersand = null;
                        }
                    }
                    _documentID_Versand = value;
                    OnPropertyChanged("DocumentID_Versand");
                }
            }
        }
        private Nullable<int> _documentID_Versand;
    
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
        public byte[] KesMassnahmeBerichtTS
        {
            get { return _kesMassnahmeBerichtTS; }
            set
            {
                if (_kesMassnahmeBerichtTS != value)
                {
                    _kesMassnahmeBerichtTS = value;
                    OnPropertyChanged("KesMassnahmeBerichtTS");
                }
            }
        }
        private byte[] _kesMassnahmeBerichtTS;
    
        [DataMember]
        public Nullable<int> KesMassnahmeBerichtsartCode
        {
            get { return _kesMassnahmeBerichtsartCode; }
            set
            {
                if (_kesMassnahmeBerichtsartCode != value)
                {
                    _kesMassnahmeBerichtsartCode = value;
                    OnPropertyChanged("KesMassnahmeBerichtsartCode");
                }
            }
        }
        private Nullable<int> _kesMassnahmeBerichtsartCode;
    
        [DataMember]
        public Nullable<int> DocumentID_VerfuegungKESB
        {
            get { return _documentID_VerfuegungKESB; }
            set
            {
                if (_documentID_VerfuegungKESB != value)
                {
                    ChangeTracker.RecordOriginalValue("DocumentID_VerfuegungKESB", _documentID_VerfuegungKESB);
                    if (!IsDeserializing)
                    {
                        if (XDocumentVerfuegungKesb != null && XDocumentVerfuegungKesb.DocumentID != value)
                        {
                            XDocumentVerfuegungKesb = null;
                        }
                    }
                    _documentID_VerfuegungKESB = value;
                    OnPropertyChanged("DocumentID_VerfuegungKESB");
                }
            }
        }
        private Nullable<int> _documentID_VerfuegungKESB;
    
        [DataMember]
        public Nullable<System.DateTime> DatumVerfuegungKESB
        {
            get { return _datumVerfuegungKESB; }
            set
            {
                if (_datumVerfuegungKESB != value)
                {
                    _datumVerfuegungKESB = value;
                    OnPropertyChanged("DatumVerfuegungKESB");
                }
            }
        }
        private Nullable<System.DateTime> _datumVerfuegungKESB;
    
        [DataMember]
        public Nullable<int> DocumentID_Rechnung
        {
            get { return _documentID_Rechnung; }
            set
            {
                if (_documentID_Rechnung != value)
                {
                    ChangeTracker.RecordOriginalValue("DocumentID_Rechnung", _documentID_Rechnung);
                    if (!IsDeserializing)
                    {
                        if (XDocumentRechnung != null && XDocumentRechnung.DocumentID != value)
                        {
                            XDocumentRechnung = null;
                        }
                    }
                    _documentID_Rechnung = value;
                    OnPropertyChanged("DocumentID_Rechnung");
                }
            }
        }
        private Nullable<int> _documentID_Rechnung;
    
        [DataMember]
        public bool IsDeleted
        {
            get { return _isDeleted; }
            set
            {
                if (_isDeleted != value)
                {
                    _isDeleted = value;
                    OnPropertyChanged("IsDeleted");
                }
            }
        }
        private bool _isDeleted;
    
        [DataMember]
        public Nullable<System.DateTime> DatumVersand
        {
            get { return _datumVersand; }
            set
            {
                if (_datumVersand != value)
                {
                    _datumVersand = value;
                    OnPropertyChanged("DatumVersand");
                }
            }
        }
        private Nullable<System.DateTime> _datumVersand;
    
        [DataMember]
        public Nullable<System.DateTime> DatumBelegeZurueck
        {
            get { return _datumBelegeZurueck; }
            set
            {
                if (_datumBelegeZurueck != value)
                {
                    _datumBelegeZurueck = value;
                    OnPropertyChanged("DatumBelegeZurueck");
                }
            }
        }
        private Nullable<System.DateTime> _datumBelegeZurueck;

        #endregion

        #region Navigation Properties
    
        [DataMember]
        public KesMassnahme KesMassnahme
        {
            get { return _kesMassnahme; }
            set
            {
                if (!ReferenceEquals(_kesMassnahme, value))
                {
                    var previousValue = _kesMassnahme;
                    _kesMassnahme = value;
                    FixupKesMassnahme(previousValue);
                    OnNavigationPropertyChanged("KesMassnahme");
                }
            }
        }
        private KesMassnahme _kesMassnahme;
    
        [DataMember]
        public XDocument XDocumentBericht
        {
            get { return _xDocumentBericht; }
            set
            {
                if (!ReferenceEquals(_xDocumentBericht, value))
                {
                    var previousValue = _xDocumentBericht;
                    _xDocumentBericht = value;
                    FixupXDocumentBericht(previousValue);
                    OnNavigationPropertyChanged("XDocumentBericht");
                }
            }
        }
        private XDocument _xDocumentBericht;
    
        [DataMember]
        public XDocument XDocumentVerfuegungKesb
        {
            get { return _xDocumentVerfuegungKesb; }
            set
            {
                if (!ReferenceEquals(_xDocumentVerfuegungKesb, value))
                {
                    var previousValue = _xDocumentVerfuegungKesb;
                    _xDocumentVerfuegungKesb = value;
                    FixupXDocumentVerfuegungKesb(previousValue);
                    OnNavigationPropertyChanged("XDocumentVerfuegungKesb");
                }
            }
        }
        private XDocument _xDocumentVerfuegungKesb;
    
        [DataMember]
        public XDocument XDocumentVersand
        {
            get { return _xDocumentVersand; }
            set
            {
                if (!ReferenceEquals(_xDocumentVersand, value))
                {
                    var previousValue = _xDocumentVersand;
                    _xDocumentVersand = value;
                    FixupXDocumentVersand(previousValue);
                    OnNavigationPropertyChanged("XDocumentVersand");
                }
            }
        }
        private XDocument _xDocumentVersand;
    
        [DataMember]
        public XDocument XDocumentRechnung
        {
            get { return _xDocumentRechnung; }
            set
            {
                if (!ReferenceEquals(_xDocumentRechnung, value))
                {
                    var previousValue = _xDocumentRechnung;
                    _xDocumentRechnung = value;
                    FixupXDocumentRechnung(previousValue);
                    OnNavigationPropertyChanged("XDocumentRechnung");
                }
            }
        }
        private XDocument _xDocumentRechnung;

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
            KesMassnahme = null;
            XDocumentBericht = null;
            XDocumentVerfuegungKesb = null;
            XDocumentVersand = null;
            XDocumentRechnung = null;
        }

        #endregion

        #region Association Fixup
    
        private void FixupKesMassnahme(KesMassnahme previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.KesMassnahmeBericht.Contains(this))
            {
                previousValue.KesMassnahmeBericht.Remove(this);
            }
    
            if (KesMassnahme != null)
            {
                if (!KesMassnahme.KesMassnahmeBericht.Contains(this))
                {
                    KesMassnahme.KesMassnahmeBericht.Add(this);
                }
    
                KesMassnahmeID = KesMassnahme.KesMassnahmeID;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("KesMassnahme")
                    && (ChangeTracker.OriginalValues["KesMassnahme"] == KesMassnahme))
                {
                    ChangeTracker.OriginalValues.Remove("KesMassnahme");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("KesMassnahme", previousValue);
                }
                if (KesMassnahme != null && !KesMassnahme.ChangeTracker.ChangeTrackingEnabled)
                {
                    KesMassnahme.StartTracking();
                }
            }
        }
    
        private void FixupXDocumentBericht(XDocument previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.KesMassnahmeBericht.Contains(this))
            {
                previousValue.KesMassnahmeBericht.Remove(this);
            }
    
            if (XDocumentBericht != null)
            {
                if (!XDocumentBericht.KesMassnahmeBericht.Contains(this))
                {
                    XDocumentBericht.KesMassnahmeBericht.Add(this);
                }
    
                DocumentID_Bericht = XDocumentBericht.DocumentID;
            }
            else if (!skipKeys)
            {
                DocumentID_Bericht = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("XDocumentBericht")
                    && (ChangeTracker.OriginalValues["XDocumentBericht"] == XDocumentBericht))
                {
                    ChangeTracker.OriginalValues.Remove("XDocumentBericht");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("XDocumentBericht", previousValue);
                }
                if (XDocumentBericht != null && !XDocumentBericht.ChangeTracker.ChangeTrackingEnabled)
                {
                    XDocumentBericht.StartTracking();
                }
            }
        }
    
        private void FixupXDocumentVerfuegungKesb(XDocument previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.KesMassnahmeBerichtVerfuegungKesb.Contains(this))
            {
                previousValue.KesMassnahmeBerichtVerfuegungKesb.Remove(this);
            }
    
            if (XDocumentVerfuegungKesb != null)
            {
                if (!XDocumentVerfuegungKesb.KesMassnahmeBerichtVerfuegungKesb.Contains(this))
                {
                    XDocumentVerfuegungKesb.KesMassnahmeBerichtVerfuegungKesb.Add(this);
                }
    
                DocumentID_VerfuegungKESB = XDocumentVerfuegungKesb.DocumentID;
            }
            else if (!skipKeys)
            {
                DocumentID_VerfuegungKESB = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("XDocumentVerfuegungKesb")
                    && (ChangeTracker.OriginalValues["XDocumentVerfuegungKesb"] == XDocumentVerfuegungKesb))
                {
                    ChangeTracker.OriginalValues.Remove("XDocumentVerfuegungKesb");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("XDocumentVerfuegungKesb", previousValue);
                }
                if (XDocumentVerfuegungKesb != null && !XDocumentVerfuegungKesb.ChangeTracker.ChangeTrackingEnabled)
                {
                    XDocumentVerfuegungKesb.StartTracking();
                }
            }
        }
    
        private void FixupXDocumentVersand(XDocument previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.KesMassnahmeBerichtVersand.Contains(this))
            {
                previousValue.KesMassnahmeBerichtVersand.Remove(this);
            }
    
            if (XDocumentVersand != null)
            {
                if (!XDocumentVersand.KesMassnahmeBerichtVersand.Contains(this))
                {
                    XDocumentVersand.KesMassnahmeBerichtVersand.Add(this);
                }
    
                DocumentID_Versand = XDocumentVersand.DocumentID;
            }
            else if (!skipKeys)
            {
                DocumentID_Versand = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("XDocumentVersand")
                    && (ChangeTracker.OriginalValues["XDocumentVersand"] == XDocumentVersand))
                {
                    ChangeTracker.OriginalValues.Remove("XDocumentVersand");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("XDocumentVersand", previousValue);
                }
                if (XDocumentVersand != null && !XDocumentVersand.ChangeTracker.ChangeTrackingEnabled)
                {
                    XDocumentVersand.StartTracking();
                }
            }
        }
    
        private void FixupXDocumentRechnung(XDocument previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.KesMassnahmeBerichtRechnung.Contains(this))
            {
                previousValue.KesMassnahmeBerichtRechnung.Remove(this);
            }
    
            if (XDocumentRechnung != null)
            {
                if (!XDocumentRechnung.KesMassnahmeBerichtRechnung.Contains(this))
                {
                    XDocumentRechnung.KesMassnahmeBerichtRechnung.Add(this);
                }
    
                DocumentID_Rechnung = XDocumentRechnung.DocumentID;
            }
            else if (!skipKeys)
            {
                DocumentID_Rechnung = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("XDocumentRechnung")
                    && (ChangeTracker.OriginalValues["XDocumentRechnung"] == XDocumentRechnung))
                {
                    ChangeTracker.OriginalValues.Remove("XDocumentRechnung");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("XDocumentRechnung", previousValue);
                }
                if (XDocumentRechnung != null && !XDocumentRechnung.ChangeTracker.ChangeTrackingEnabled)
                {
                    XDocumentRechnung.StartTracking();
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
    
    		var entity = (KesMassnahmeBericht)obj;
    		if (!_kesMassnahmeBerichtID.Equals(entity.KesMassnahmeBerichtID) || _kesMassnahmeBerichtID == 0)
    		{
    			return false;
    		}
    		
    		return true;
    	}
    	
    	public override int GetHashCode()
        {
            return _kesMassnahmeBerichtID.GetHashCode();
        }

        #endregion

    }
}