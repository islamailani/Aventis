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
    [KnownType(typeof(XUser))]
    [KnownType(typeof(XUserGroup))]
    public partial class XUser_UserGroup : PocoEntity, IAutoIdentityEntity<int>
    {
        public int AutoIdentityID 
        {
            get{ return XUser_UserGroupID; } 
        }
    
        [DataMember]
        private int _xUser_UserGroupID;
        public int XUser_UserGroupID
        {
            get { return _xUser_UserGroupID; }
            set
            {
                if (_xUser_UserGroupID != value)
                {
                    _xUser_UserGroupID = value;
                    RaisePropertyChanged("XUser_UserGroupID");
                }
            }
        }
    
        [DataMember]
        private int _userID;
        public int UserID
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
        private int _userGroupID;
        public int UserGroupID
        {
            get { return _userGroupID; }
            set
            {
                if (_userGroupID != value)
                {
                    _userGroupID = value;
                    RaisePropertyChanged("UserGroupID");
                    if (XUserGroup != null && XUserGroup.UserGroupID != value)
                    {
                        XUserGroup = null;
                    }
                }
            }
        }
    
        [DataMember]
        private byte[] _xUser_UserGroupTS;
        public byte[] XUser_UserGroupTS
        {
            get { return _xUser_UserGroupTS; }
            set
            {
                if (_xUser_UserGroupTS != value)
                {
                    _xUser_UserGroupTS = value;
                    RaisePropertyChanged("XUser_UserGroupTS");
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
        private XUserGroup _xUserGroup;
        public virtual XUserGroup XUserGroup
        {
            get { return _xUserGroup; }
            set
            {
                if (_xUserGroup != value)
                {
                    _xUserGroup = value;
                    RaisePropertyChanged("XUserGroup");
    
                    if (value != null)
                    {
                        UserGroupID = value.UserGroupID;
                    }
                }
            }
        }
    }
    
}