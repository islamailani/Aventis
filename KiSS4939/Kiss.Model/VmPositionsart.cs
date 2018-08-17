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
    [KnownType(typeof(VmPosition))]
    public partial class VmPositionsart: EntityBase<VmPositionsart>, IObjectWithChangeTracker
    {
        #region Primitive Properties
    
        [DataMember]
        public int VmPositionsartID
        {
            get { return _vmPositionsartID; }
            set
            {
                if (_vmPositionsartID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'VmPositionsartID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _vmPositionsartID = value;
                    OnPropertyChanged("VmPositionsartID");
                }
            }
        }
        private int _vmPositionsartID;
    
        [DataMember]
        public int VmKategorieCode
        {
            get { return _vmKategorieCode; }
            set
            {
                if (_vmKategorieCode != value)
                {
                    _vmKategorieCode = value;
                    OnPropertyChanged("VmKategorieCode");
                }
            }
        }
        private int _vmKategorieCode;
    
        [DataMember]
        public Nullable<int> VmPositionsartTypCode
        {
            get { return _vmPositionsartTypCode; }
            set
            {
                if (_vmPositionsartTypCode != value)
                {
                    _vmPositionsartTypCode = value;
                    OnPropertyChanged("VmPositionsartTypCode");
                }
            }
        }
        private Nullable<int> _vmPositionsartTypCode;
    
        [DataMember]
        public bool IstTemplate
        {
            get { return _istTemplate; }
            set
            {
                if (_istTemplate != value)
                {
                    _istTemplate = value;
                    OnPropertyChanged("IstTemplate");
                }
            }
        }
        private bool _istTemplate;
    
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
        public int SortKey
        {
            get { return _sortKey; }
            set
            {
                if (_sortKey != value)
                {
                    _sortKey = value;
                    OnPropertyChanged("SortKey");
                }
            }
        }
        private int _sortKey;
    
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
        public byte[] VmPositionsartTS
        {
            get { return _vmPositionsartTS; }
            set
            {
                if (_vmPositionsartTS != value)
                {
                    _vmPositionsartTS = value;
                    OnPropertyChanged("VmPositionsartTS");
                }
            }
        }
        private byte[] _vmPositionsartTS;

        #endregion

        #region Navigation Properties
    
        [DataMember]
        public TrackableCollection<VmPosition> VmPosition
        {
            get
            {
                if (_vmPosition == null)
                {
                    _vmPosition = new TrackableCollection<VmPosition>();
                    _vmPosition.CollectionChanged += FixupVmPosition;
                }
                return _vmPosition;
            }
            set
            {
                if (!ReferenceEquals(_vmPosition, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_vmPosition != null)
                    {
                        _vmPosition.CollectionChanged -= FixupVmPosition;
                    }
                    _vmPosition = value;
                    if (_vmPosition != null)
                    {
                        _vmPosition.CollectionChanged += FixupVmPosition;
                    }
                    OnNavigationPropertyChanged("VmPosition");
                }
            }
        }
        private TrackableCollection<VmPosition> _vmPosition;

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
            VmPosition.Clear();
        }

        #endregion

        #region Association Fixup
    
        private void FixupVmPosition(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (VmPosition item in e.NewItems)
                {
                    item.VmPositionsart = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("VmPosition", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (VmPosition item in e.OldItems)
                {
                    if (ReferenceEquals(item.VmPositionsart, this))
                    {
                        item.VmPositionsart = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("VmPosition", item);
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
    
    		var entity = (VmPositionsart)obj;
    		if (!_vmPositionsartID.Equals(entity.VmPositionsartID) || _vmPositionsartID == 0)
    		{
    			return false;
    		}
    		
    		return true;
    	}
    	
    	public override int GetHashCode()
        {
            return _vmPositionsartID.GetHashCode();
        }

        #endregion

    }
}