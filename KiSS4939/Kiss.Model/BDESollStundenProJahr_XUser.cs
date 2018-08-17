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
    [KnownType(typeof(XUser))]
    public partial class BDESollStundenProJahr_XUser: EntityBase<BDESollStundenProJahr_XUser>, IObjectWithChangeTracker
    {
        #region Primitive Properties
    
        [DataMember]
        public int BDESollStundenProJahr_XUserID
        {
            get { return _bDESollStundenProJahr_XUserID; }
            set
            {
                if (_bDESollStundenProJahr_XUserID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'BDESollStundenProJahr_XUserID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _bDESollStundenProJahr_XUserID = value;
                    OnPropertyChanged("BDESollStundenProJahr_XUserID");
                }
            }
        }
        private int _bDESollStundenProJahr_XUserID;
    
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
        public int Jahr
        {
            get { return _jahr; }
            set
            {
                if (_jahr != value)
                {
                    _jahr = value;
                    OnPropertyChanged("Jahr");
                }
            }
        }
        private int _jahr;
    
        [DataMember]
        public decimal JanuarStd
        {
            get { return _januarStd; }
            set
            {
                if (_januarStd != value)
                {
                    _januarStd = value;
                    OnPropertyChanged("JanuarStd");
                }
            }
        }
        private decimal _januarStd;
    
        [DataMember]
        public decimal FebruarStd
        {
            get { return _februarStd; }
            set
            {
                if (_februarStd != value)
                {
                    _februarStd = value;
                    OnPropertyChanged("FebruarStd");
                }
            }
        }
        private decimal _februarStd;
    
        [DataMember]
        public decimal MaerzStd
        {
            get { return _maerzStd; }
            set
            {
                if (_maerzStd != value)
                {
                    _maerzStd = value;
                    OnPropertyChanged("MaerzStd");
                }
            }
        }
        private decimal _maerzStd;
    
        [DataMember]
        public decimal AprilStd
        {
            get { return _aprilStd; }
            set
            {
                if (_aprilStd != value)
                {
                    _aprilStd = value;
                    OnPropertyChanged("AprilStd");
                }
            }
        }
        private decimal _aprilStd;
    
        [DataMember]
        public decimal MaiStd
        {
            get { return _maiStd; }
            set
            {
                if (_maiStd != value)
                {
                    _maiStd = value;
                    OnPropertyChanged("MaiStd");
                }
            }
        }
        private decimal _maiStd;
    
        [DataMember]
        public decimal JuniStd
        {
            get { return _juniStd; }
            set
            {
                if (_juniStd != value)
                {
                    _juniStd = value;
                    OnPropertyChanged("JuniStd");
                }
            }
        }
        private decimal _juniStd;
    
        [DataMember]
        public decimal JuliStd
        {
            get { return _juliStd; }
            set
            {
                if (_juliStd != value)
                {
                    _juliStd = value;
                    OnPropertyChanged("JuliStd");
                }
            }
        }
        private decimal _juliStd;
    
        [DataMember]
        public decimal AugustStd
        {
            get { return _augustStd; }
            set
            {
                if (_augustStd != value)
                {
                    _augustStd = value;
                    OnPropertyChanged("AugustStd");
                }
            }
        }
        private decimal _augustStd;
    
        [DataMember]
        public decimal SeptemberStd
        {
            get { return _septemberStd; }
            set
            {
                if (_septemberStd != value)
                {
                    _septemberStd = value;
                    OnPropertyChanged("SeptemberStd");
                }
            }
        }
        private decimal _septemberStd;
    
        [DataMember]
        public decimal OktoberStd
        {
            get { return _oktoberStd; }
            set
            {
                if (_oktoberStd != value)
                {
                    _oktoberStd = value;
                    OnPropertyChanged("OktoberStd");
                }
            }
        }
        private decimal _oktoberStd;
    
        [DataMember]
        public decimal NovemberStd
        {
            get { return _novemberStd; }
            set
            {
                if (_novemberStd != value)
                {
                    _novemberStd = value;
                    OnPropertyChanged("NovemberStd");
                }
            }
        }
        private decimal _novemberStd;
    
        [DataMember]
        public decimal DezemberStd
        {
            get { return _dezemberStd; }
            set
            {
                if (_dezemberStd != value)
                {
                    _dezemberStd = value;
                    OnPropertyChanged("DezemberStd");
                }
            }
        }
        private decimal _dezemberStd;
    
        [DataMember]
        public decimal TotalStd
        {
            get { return _totalStd; }
            set
            {
                if (_totalStd != value)
                {
                    _totalStd = value;
                    OnPropertyChanged("TotalStd");
                }
            }
        }
        private decimal _totalStd;
    
        [DataMember]
        public bool ManualEdit
        {
            get { return _manualEdit; }
            set
            {
                if (_manualEdit != value)
                {
                    _manualEdit = value;
                    OnPropertyChanged("ManualEdit");
                }
            }
        }
        private bool _manualEdit;
    
        [DataMember]
        public byte[] BDESollStundenProJahr_XUserTS
        {
            get { return _bDESollStundenProJahr_XUserTS; }
            set
            {
                if (_bDESollStundenProJahr_XUserTS != value)
                {
                    _bDESollStundenProJahr_XUserTS = value;
                    OnPropertyChanged("BDESollStundenProJahr_XUserTS");
                }
            }
        }
        private byte[] _bDESollStundenProJahr_XUserTS;
    
        [DataMember]
        public Nullable<int> VerID
        {
            get { return _verID; }
            set
            {
                if (_verID != value)
                {
                    _verID = value;
                    OnPropertyChanged("VerID");
                }
            }
        }
        private Nullable<int> _verID;

        #endregion

        #region Navigation Properties
    
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
            XUser = null;
        }

        #endregion

        #region Association Fixup
    
        private void FixupXUser(XUser previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.BDESollStundenProJahr_XUser.Contains(this))
            {
                previousValue.BDESollStundenProJahr_XUser.Remove(this);
            }
    
            if (XUser != null)
            {
                if (!XUser.BDESollStundenProJahr_XUser.Contains(this))
                {
                    XUser.BDESollStundenProJahr_XUser.Add(this);
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
    
    		var entity = (BDESollStundenProJahr_XUser)obj;
    		if (!_bDESollStundenProJahr_XUserID.Equals(entity.BDESollStundenProJahr_XUserID) || _bDESollStundenProJahr_XUserID == 0)
    		{
    			return false;
    		}
    		
    		return true;
    	}
    	
    	public override int GetHashCode()
        {
            return _bDESollStundenProJahr_XUserID.GetHashCode();
        }

        #endregion

    }
}