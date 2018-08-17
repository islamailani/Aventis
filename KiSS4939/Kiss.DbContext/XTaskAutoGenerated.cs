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
    [KnownType(typeof(XTask))]
    public partial class XTaskAutoGenerated : PocoEntity, IAutoIdentityEntity<int>, IAuditableEntity
    {
        public int AutoIdentityID 
        {
            get{ return XTaskAutoGeneratedID; } 
        }
    
        [DataMember]
        private int _xTaskAutoGeneratedID;
        public int XTaskAutoGeneratedID
        {
            get { return _xTaskAutoGeneratedID; }
            set
            {
                if (_xTaskAutoGeneratedID != value)
                {
                    _xTaskAutoGeneratedID = value;
                    RaisePropertyChanged("XTaskAutoGeneratedID");
                }
            }
        }
    
        [DataMember]
        private int _xTaskID;
        public int XTaskID
        {
            get { return _xTaskID; }
            set
            {
                if (_xTaskID != value)
                {
                    _xTaskID = value;
                    RaisePropertyChanged("XTaskID");
                    if (XTask != null && XTask.XTaskID != value)
                    {
                        XTask = null;
                    }
                }
            }
        }
    
        [DataMember]
        private string _referenceTable;
        public string ReferenceTable
        {
            get { return _referenceTable; }
            set
            {
                if (_referenceTable != value)
                {
                    _referenceTable = value;
                    RaisePropertyChanged("ReferenceTable");
                }
            }
        }
    
        [DataMember]
        private Nullable<int> _referenceID;
        public Nullable<int> ReferenceID
        {
            get { return _referenceID; }
            set
            {
                if (_referenceID != value)
                {
                    _referenceID = value;
                    RaisePropertyChanged("ReferenceID");
                }
            }
        }
    
        [DataMember]
        private int _xTaskAutoGeneratedTypeCode;
        public int XTaskAutoGeneratedTypeCode
        {
            get { return _xTaskAutoGeneratedTypeCode; }
            set
            {
                if (_xTaskAutoGeneratedTypeCode != value)
                {
                    _xTaskAutoGeneratedTypeCode = value;
                    RaisePropertyChanged("XTaskAutoGeneratedTypeCode");
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
        private byte[] _xTaskAutoGeneratedTS;
        public byte[] XTaskAutoGeneratedTS
        {
            get { return _xTaskAutoGeneratedTS; }
            set
            {
                if (_xTaskAutoGeneratedTS != value)
                {
                    _xTaskAutoGeneratedTS = value;
                    RaisePropertyChanged("XTaskAutoGeneratedTS");
                }
            }
        }
    
    
        [DataMember]
        private XTask _xTask;
        public virtual XTask XTask
        {
            get { return _xTask; }
            set
            {
                if (_xTask != value)
                {
                    _xTask = value;
                    RaisePropertyChanged("XTask");
    
                    if (value != null)
                    {
                        XTaskID = value.XTaskID;
                    }
                }
            }
        }
    }
    
}