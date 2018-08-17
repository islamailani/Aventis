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
    [KnownType(typeof(XClass))]
    [KnownType(typeof(XUserGroup_Right))]
    public partial class XRight : PocoEntity, IAutoIdentityEntity<int>, IAuditableEntity
    {
        public XRight()
        {
            this.XUserGroup_Right = new HashSet<XUserGroup_Right>();
        }
    
        public int AutoIdentityID 
        {
            get{ return RightID; } 
        }
    
        [DataMember]
        private int _rightID;
        public int RightID
        {
            get { return _rightID; }
            set
            {
                if (_rightID != value)
                {
                    _rightID = value;
                    RaisePropertyChanged("RightID");
                }
            }
        }
    
        [DataMember]
        private int _xClassID;
        public int XClassID
        {
            get { return _xClassID; }
            set
            {
                if (_xClassID != value)
                {
                    _xClassID = value;
                    RaisePropertyChanged("XClassID");
                    if (XClass != null && XClass.XClassID != value)
                    {
                        XClass = null;
                    }
                }
            }
        }
    
        [DataMember]
        private string _className;
        public string ClassName
        {
            get { return _className; }
            set
            {
                if (_className != value)
                {
                    _className = value;
                    RaisePropertyChanged("ClassName");
                }
            }
        }
    
        [DataMember]
        private string _rightName;
        public string RightName
        {
            get { return _rightName; }
            set
            {
                if (_rightName != value)
                {
                    _rightName = value;
                    RaisePropertyChanged("RightName");
                }
            }
        }
    
        [DataMember]
        private string _userText;
        public string UserText
        {
            get { return _userText; }
            set
            {
                if (_userText != value)
                {
                    _userText = value;
                    RaisePropertyChanged("UserText");
                }
            }
        }
    
        [DataMember]
        private string _description;
        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    RaisePropertyChanged("Description");
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
        private byte[] _xRightTS;
        public byte[] XRightTS
        {
            get { return _xRightTS; }
            set
            {
                if (_xRightTS != value)
                {
                    _xRightTS = value;
                    RaisePropertyChanged("XRightTS");
                }
            }
        }
    
    
        [DataMember]
        private XClass _xClass;
        public virtual XClass XClass
        {
            get { return _xClass; }
            set
            {
                if (_xClass != value)
                {
                    _xClass = value;
                    RaisePropertyChanged("XClass");
    
                    if (value != null)
                    {
                        XClassID = value.XClassID;
                    }
                }
            }
        }
        [DataMember]
        private ICollection<XUserGroup_Right> _xUserGroup_Right;
        public virtual ICollection<XUserGroup_Right> XUserGroup_Right
        {
            get { return _xUserGroup_Right; }
            set
            {
                if (_xUserGroup_Right != value)
                {
                    _xUserGroup_Right = value;
                    RaisePropertyChanged("XUserGroup_Right");
                }
            }
        }
    }
    
}