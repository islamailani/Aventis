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
    [KnownType(typeof(BaPerson))]
    public partial class BaPerson_Relation: EntityBase<BaPerson_Relation>, IObjectWithChangeTracker
    {
        #region Primitive Properties
    
        [DataMember]
        public int BaPerson_RelationID
        {
            get { return _baPerson_RelationID; }
            set
            {
                if (_baPerson_RelationID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'BaPerson_RelationID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _baPerson_RelationID = value;
                    OnPropertyChanged("BaPerson_RelationID");
                }
            }
        }
        private int _baPerson_RelationID;
    
        [DataMember]
        public int BaPersonID_1
        {
            get { return _baPersonID_1; }
            set
            {
                if (_baPersonID_1 != value)
                {
                    ChangeTracker.RecordOriginalValue("BaPersonID_1", _baPersonID_1);
                    if (!IsDeserializing)
                    {
                        if (BaPerson1 != null && BaPerson1.BaPersonID != value)
                        {
                            BaPerson1 = null;
                        }
                    }
                    _baPersonID_1 = value;
                    OnPropertyChanged("BaPersonID_1");
                }
            }
        }
        private int _baPersonID_1;
    
        [DataMember]
        public int BaPersonID_2
        {
            get { return _baPersonID_2; }
            set
            {
                if (_baPersonID_2 != value)
                {
                    ChangeTracker.RecordOriginalValue("BaPersonID_2", _baPersonID_2);
                    if (!IsDeserializing)
                    {
                        if (BaPerson2 != null && BaPerson2.BaPersonID != value)
                        {
                            BaPerson2 = null;
                        }
                    }
                    _baPersonID_2 = value;
                    OnPropertyChanged("BaPersonID_2");
                }
            }
        }
        private int _baPersonID_2;
    
        [DataMember]
        public Nullable<int> BaRelationID
        {
            get { return _baRelationID; }
            set
            {
                if (_baRelationID != value)
                {
                    _baRelationID = value;
                    OnPropertyChanged("BaRelationID");
                }
            }
        }
        private Nullable<int> _baRelationID;
    
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
        public byte[] BaPerson_RelationTS
        {
            get { return _baPerson_RelationTS; }
            set
            {
                if (_baPerson_RelationTS != value)
                {
                    _baPerson_RelationTS = value;
                    OnPropertyChanged("BaPerson_RelationTS");
                }
            }
        }
        private byte[] _baPerson_RelationTS;

        #endregion

        #region Navigation Properties
    
        [DataMember]
        public BaPerson BaPerson1
        {
            get { return _baPerson1; }
            set
            {
                if (!ReferenceEquals(_baPerson1, value))
                {
                    var previousValue = _baPerson1;
                    _baPerson1 = value;
                    FixupBaPerson1(previousValue);
                    OnNavigationPropertyChanged("BaPerson1");
                }
            }
        }
        private BaPerson _baPerson1;
    
        [DataMember]
        public BaPerson BaPerson2
        {
            get { return _baPerson2; }
            set
            {
                if (!ReferenceEquals(_baPerson2, value))
                {
                    var previousValue = _baPerson2;
                    _baPerson2 = value;
                    FixupBaPerson2(previousValue);
                    OnNavigationPropertyChanged("BaPerson2");
                }
            }
        }
        private BaPerson _baPerson2;

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
            BaPerson1 = null;
            BaPerson2 = null;
        }

        #endregion

        #region Association Fixup
    
        private void FixupBaPerson1(BaPerson previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.BaPerson_Relation1.Contains(this))
            {
                previousValue.BaPerson_Relation1.Remove(this);
            }
    
            if (BaPerson1 != null)
            {
                if (!BaPerson1.BaPerson_Relation1.Contains(this))
                {
                    BaPerson1.BaPerson_Relation1.Add(this);
                }
    
                BaPersonID_1 = BaPerson1.BaPersonID;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("BaPerson1")
                    && (ChangeTracker.OriginalValues["BaPerson1"] == BaPerson1))
                {
                    ChangeTracker.OriginalValues.Remove("BaPerson1");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("BaPerson1", previousValue);
                }
                if (BaPerson1 != null && !BaPerson1.ChangeTracker.ChangeTrackingEnabled)
                {
                    BaPerson1.StartTracking();
                }
            }
        }
    
        private void FixupBaPerson2(BaPerson previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.BaPerson_Relation2.Contains(this))
            {
                previousValue.BaPerson_Relation2.Remove(this);
            }
    
            if (BaPerson2 != null)
            {
                if (!BaPerson2.BaPerson_Relation2.Contains(this))
                {
                    BaPerson2.BaPerson_Relation2.Add(this);
                }
    
                BaPersonID_2 = BaPerson2.BaPersonID;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("BaPerson2")
                    && (ChangeTracker.OriginalValues["BaPerson2"] == BaPerson2))
                {
                    ChangeTracker.OriginalValues.Remove("BaPerson2");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("BaPerson2", previousValue);
                }
                if (BaPerson2 != null && !BaPerson2.ChangeTracker.ChangeTrackingEnabled)
                {
                    BaPerson2.StartTracking();
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
    
    		var entity = (BaPerson_Relation)obj;
    		if (!_baPerson_RelationID.Equals(entity.BaPerson_RelationID) || _baPerson_RelationID == 0)
    		{
    			return false;
    		}
    		
    		return true;
    	}
    	
    	public override int GetHashCode()
        {
            return _baPerson_RelationID.GetHashCode();
        }

        #endregion

    }
}