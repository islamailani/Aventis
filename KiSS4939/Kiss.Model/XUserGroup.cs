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
    [KnownType(typeof(XUserGroup_Right))]
    [KnownType(typeof(XUser_UserGroup))]
    public partial class XUserGroup: EntityBase<XUserGroup>, IObjectWithChangeTracker
    {
        #region Primitive Properties
    
        [DataMember]
        public int UserGroupID
        {
            get { return _userGroupID; }
            set
            {
                if (_userGroupID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'UserGroupID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _userGroupID = value;
                    OnPropertyChanged("UserGroupID");
                }
            }
        }
        private int _userGroupID;
    
        [DataMember]
        public string UserGroupName
        {
            get { return _userGroupName; }
            set
            {
                if (_userGroupName != value)
                {
                    _userGroupName = value;
                    OnPropertyChanged("UserGroupName");
                }
            }
        }
        private string _userGroupName;
    
        [DataMember]
        public Nullable<int> UserGroupNameTID
        {
            get { return _userGroupNameTID; }
            set
            {
                if (_userGroupNameTID != value)
                {
                    _userGroupNameTID = value;
                    OnPropertyChanged("UserGroupNameTID");
                }
            }
        }
        private Nullable<int> _userGroupNameTID;
    
        [DataMember]
        public bool OnlyAdminVisible
        {
            get { return _onlyAdminVisible; }
            set
            {
                if (_onlyAdminVisible != value)
                {
                    _onlyAdminVisible = value;
                    OnPropertyChanged("OnlyAdminVisible");
                }
            }
        }
        private bool _onlyAdminVisible;
    
        [DataMember]
        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    OnPropertyChanged("Description");
                }
            }
        }
        private string _description;
    
        [DataMember]
        public Nullable<int> DescriptionTID
        {
            get { return _descriptionTID; }
            set
            {
                if (_descriptionTID != value)
                {
                    _descriptionTID = value;
                    OnPropertyChanged("DescriptionTID");
                }
            }
        }
        private Nullable<int> _descriptionTID;
    
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
        public byte[] XUserGroupTS
        {
            get { return _xUserGroupTS; }
            set
            {
                if (_xUserGroupTS != value)
                {
                    _xUserGroupTS = value;
                    OnPropertyChanged("XUserGroupTS");
                }
            }
        }
        private byte[] _xUserGroupTS;

        #endregion

        #region Navigation Properties
    
        [DataMember]
        public TrackableCollection<XUserGroup_Right> XUserGroup_Right
        {
            get
            {
                if (_xUserGroup_Right == null)
                {
                    _xUserGroup_Right = new TrackableCollection<XUserGroup_Right>();
                    _xUserGroup_Right.CollectionChanged += FixupXUserGroup_Right;
                }
                return _xUserGroup_Right;
            }
            set
            {
                if (!ReferenceEquals(_xUserGroup_Right, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_xUserGroup_Right != null)
                    {
                        _xUserGroup_Right.CollectionChanged -= FixupXUserGroup_Right;
                    }
                    _xUserGroup_Right = value;
                    if (_xUserGroup_Right != null)
                    {
                        _xUserGroup_Right.CollectionChanged += FixupXUserGroup_Right;
                    }
                    OnNavigationPropertyChanged("XUserGroup_Right");
                }
            }
        }
        private TrackableCollection<XUserGroup_Right> _xUserGroup_Right;
    
        [DataMember]
        public TrackableCollection<XUser_UserGroup> XUser_UserGroup
        {
            get
            {
                if (_xUser_UserGroup == null)
                {
                    _xUser_UserGroup = new TrackableCollection<XUser_UserGroup>();
                    _xUser_UserGroup.CollectionChanged += FixupXUser_UserGroup;
                }
                return _xUser_UserGroup;
            }
            set
            {
                if (!ReferenceEquals(_xUser_UserGroup, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_xUser_UserGroup != null)
                    {
                        _xUser_UserGroup.CollectionChanged -= FixupXUser_UserGroup;
                    }
                    _xUser_UserGroup = value;
                    if (_xUser_UserGroup != null)
                    {
                        _xUser_UserGroup.CollectionChanged += FixupXUser_UserGroup;
                    }
                    OnNavigationPropertyChanged("XUser_UserGroup");
                }
            }
        }
        private TrackableCollection<XUser_UserGroup> _xUser_UserGroup;

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
            XUserGroup_Right.Clear();
            XUser_UserGroup.Clear();
        }

        #endregion

        #region Association Fixup
    
        private void FixupXUserGroup_Right(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (XUserGroup_Right item in e.NewItems)
                {
                    item.XUserGroup = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("XUserGroup_Right", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (XUserGroup_Right item in e.OldItems)
                {
                    if (ReferenceEquals(item.XUserGroup, this))
                    {
                        item.XUserGroup = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("XUserGroup_Right", item);
                    }
                }
            }
        }
    
        private void FixupXUser_UserGroup(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (XUser_UserGroup item in e.NewItems)
                {
                    item.XUserGroup = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("XUser_UserGroup", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (XUser_UserGroup item in e.OldItems)
                {
                    if (ReferenceEquals(item.XUserGroup, this))
                    {
                        item.XUserGroup = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("XUser_UserGroup", item);
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
    
    		var entity = (XUserGroup)obj;
    		if (!_userGroupID.Equals(entity.UserGroupID) || _userGroupID == 0)
    		{
    			return false;
    		}
    		
    		return true;
    	}
    	
    	public override int GetHashCode()
        {
            return _userGroupID.GetHashCode();
        }

        #endregion

    }
}