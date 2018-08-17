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
    [KnownType(typeof(FaPhase))]
    [KnownType(typeof(FsDienstleistung_FsDienstleistungspaket))]
    public partial class FsDienstleistungspaket: EntityBase<FsDienstleistungspaket>, IObjectWithChangeTracker
    {
        #region Primitive Properties
    
        [DataMember]
        public int FsDienstleistungspaketID
        {
            get { return _fsDienstleistungspaketID; }
            set
            {
                if (_fsDienstleistungspaketID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'FsDienstleistungspaketID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _fsDienstleistungspaketID = value;
                    OnPropertyChanged("FsDienstleistungspaketID");
                }
            }
        }
        private int _fsDienstleistungspaketID;
    
        [DataMember]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged("Name");
                }
            }
        }
        private string _name;
    
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
        public byte[] FsDienstleistungspaketTS
        {
            get { return _fsDienstleistungspaketTS; }
            set
            {
                if (_fsDienstleistungspaketTS != value)
                {
                    _fsDienstleistungspaketTS = value;
                    OnPropertyChanged("FsDienstleistungspaketTS");
                }
            }
        }
        private byte[] _fsDienstleistungspaketTS;
    
        [DataMember]
        public Nullable<decimal> MaximaleLaufzeit
        {
            get { return _maximaleLaufzeit; }
            set
            {
                if (_maximaleLaufzeit != value)
                {
                    _maximaleLaufzeit = value;
                    OnPropertyChanged("MaximaleLaufzeit");
                }
            }
        }
        private Nullable<decimal> _maximaleLaufzeit;

        #endregion

        #region Navigation Properties
    
        [DataMember]
        public TrackableCollection<FaPhase> FaPhase_Bedarf
        {
            get
            {
                if (_faPhase_Bedarf == null)
                {
                    _faPhase_Bedarf = new TrackableCollection<FaPhase>();
                    _faPhase_Bedarf.CollectionChanged += FixupFaPhase_Bedarf;
                }
                return _faPhase_Bedarf;
            }
            set
            {
                if (!ReferenceEquals(_faPhase_Bedarf, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_faPhase_Bedarf != null)
                    {
                        _faPhase_Bedarf.CollectionChanged -= FixupFaPhase_Bedarf;
                    }
                    _faPhase_Bedarf = value;
                    if (_faPhase_Bedarf != null)
                    {
                        _faPhase_Bedarf.CollectionChanged += FixupFaPhase_Bedarf;
                    }
                    OnNavigationPropertyChanged("FaPhase_Bedarf");
                }
            }
        }
        private TrackableCollection<FaPhase> _faPhase_Bedarf;
    
        [DataMember]
        public TrackableCollection<FaPhase> FaPhase_Zugewiesen
        {
            get
            {
                if (_faPhase_Zugewiesen == null)
                {
                    _faPhase_Zugewiesen = new TrackableCollection<FaPhase>();
                    _faPhase_Zugewiesen.CollectionChanged += FixupFaPhase_Zugewiesen;
                }
                return _faPhase_Zugewiesen;
            }
            set
            {
                if (!ReferenceEquals(_faPhase_Zugewiesen, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_faPhase_Zugewiesen != null)
                    {
                        _faPhase_Zugewiesen.CollectionChanged -= FixupFaPhase_Zugewiesen;
                    }
                    _faPhase_Zugewiesen = value;
                    if (_faPhase_Zugewiesen != null)
                    {
                        _faPhase_Zugewiesen.CollectionChanged += FixupFaPhase_Zugewiesen;
                    }
                    OnNavigationPropertyChanged("FaPhase_Zugewiesen");
                }
            }
        }
        private TrackableCollection<FaPhase> _faPhase_Zugewiesen;
    
        [DataMember]
        public TrackableCollection<FsDienstleistung_FsDienstleistungspaket> FsDienstleistung_FsDienstleistungspaket
        {
            get
            {
                if (_fsDienstleistung_FsDienstleistungspaket == null)
                {
                    _fsDienstleistung_FsDienstleistungspaket = new TrackableCollection<FsDienstleistung_FsDienstleistungspaket>();
                    _fsDienstleistung_FsDienstleistungspaket.CollectionChanged += FixupFsDienstleistung_FsDienstleistungspaket;
                }
                return _fsDienstleistung_FsDienstleistungspaket;
            }
            set
            {
                if (!ReferenceEquals(_fsDienstleistung_FsDienstleistungspaket, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_fsDienstleistung_FsDienstleistungspaket != null)
                    {
                        _fsDienstleistung_FsDienstleistungspaket.CollectionChanged -= FixupFsDienstleistung_FsDienstleistungspaket;
                    }
                    _fsDienstleistung_FsDienstleistungspaket = value;
                    if (_fsDienstleistung_FsDienstleistungspaket != null)
                    {
                        _fsDienstleistung_FsDienstleistungspaket.CollectionChanged += FixupFsDienstleistung_FsDienstleistungspaket;
                    }
                    OnNavigationPropertyChanged("FsDienstleistung_FsDienstleistungspaket");
                }
            }
        }
        private TrackableCollection<FsDienstleistung_FsDienstleistungspaket> _fsDienstleistung_FsDienstleistungspaket;

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
            FaPhase_Bedarf.Clear();
            FaPhase_Zugewiesen.Clear();
            FsDienstleistung_FsDienstleistungspaket.Clear();
        }

        #endregion

        #region Association Fixup
    
        private void FixupFaPhase_Bedarf(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (FaPhase item in e.NewItems)
                {
                    item.FsDienstleistungspaket_Bedarf = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("FaPhase_Bedarf", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (FaPhase item in e.OldItems)
                {
                    if (ReferenceEquals(item.FsDienstleistungspaket_Bedarf, this))
                    {
                        item.FsDienstleistungspaket_Bedarf = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("FaPhase_Bedarf", item);
                    }
                }
            }
        }
    
        private void FixupFaPhase_Zugewiesen(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (FaPhase item in e.NewItems)
                {
                    item.FsDienstleistungspaket_Zugewiesen = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("FaPhase_Zugewiesen", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (FaPhase item in e.OldItems)
                {
                    if (ReferenceEquals(item.FsDienstleistungspaket_Zugewiesen, this))
                    {
                        item.FsDienstleistungspaket_Zugewiesen = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("FaPhase_Zugewiesen", item);
                    }
                }
            }
        }
    
        private void FixupFsDienstleistung_FsDienstleistungspaket(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (FsDienstleistung_FsDienstleistungspaket item in e.NewItems)
                {
                    item.FsDienstleistungspaket = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("FsDienstleistung_FsDienstleistungspaket", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (FsDienstleistung_FsDienstleistungspaket item in e.OldItems)
                {
                    if (ReferenceEquals(item.FsDienstleistungspaket, this))
                    {
                        item.FsDienstleistungspaket = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("FsDienstleistung_FsDienstleistungspaket", item);
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
    
    		var entity = (FsDienstleistungspaket)obj;
    		if (!_fsDienstleistungspaketID.Equals(entity.FsDienstleistungspaketID) || _fsDienstleistungspaketID == 0)
    		{
    			return false;
    		}
    		
    		return true;
    	}
    	
    	public override int GetHashCode()
        {
            return _fsDienstleistungspaketID.GetHashCode();
        }

        #endregion

    }
}