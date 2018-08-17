﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.34209.
// 
#pragma warning disable 1591

namespace KiSSSvc.SAP.PSCD.WebServiceHelper.WebReferences.AusgleichLesen {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="MI_AUSGL_SENDEN_NEWBinding", Namespace="http://STZH")]
    public partial class MI_AUSGL_SENDEN_NEWService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback MI_AUSGL_SENDEN_NEWOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public MI_AUSGL_SENDEN_NEWService() {
            this.Url = global::KiSSSvc.SAP.PSCD.WebServiceHelper.Properties.Settings.Default.KiSSSvc_SAP_PSCD_WebServiceHelper_WebReferences_AusgleichLesen_MI_AUSGL_SENDEN_NEWService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event MI_AUSGL_SENDEN_NEWCompletedEventHandler MI_AUSGL_SENDEN_NEWCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://sap.com/xi/WebService/soap1.1", RequestElementName="_-STZH_-FI_PSCDAUSGLEICH001", RequestNamespace="urn:sap-com:document:sap:rfc:functions", ResponseElementName="_-STZH_-FI_PSCDAUSGLEICH001.Response", ResponseNamespace="urn:sap-com:document:sap:rfc:functions", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void MI_AUSGL_SENDEN_NEW([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string COMMAND, [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)] ref _STZH_FI_AUSGLEICHMELDUNG_KISS[] AUSGEGLICHEN) {
            object[] results = this.Invoke("MI_AUSGL_SENDEN_NEW", new object[] {
                        COMMAND,
                        AUSGEGLICHEN});
            AUSGEGLICHEN = ((_STZH_FI_AUSGLEICHMELDUNG_KISS[])(results[0]));
        }
        
        /// <remarks/>
        public void MI_AUSGL_SENDEN_NEWAsync(string COMMAND, _STZH_FI_AUSGLEICHMELDUNG_KISS[] AUSGEGLICHEN) {
            this.MI_AUSGL_SENDEN_NEWAsync(COMMAND, AUSGEGLICHEN, null);
        }
        
        /// <remarks/>
        public void MI_AUSGL_SENDEN_NEWAsync(string COMMAND, _STZH_FI_AUSGLEICHMELDUNG_KISS[] AUSGEGLICHEN, object userState) {
            if ((this.MI_AUSGL_SENDEN_NEWOperationCompleted == null)) {
                this.MI_AUSGL_SENDEN_NEWOperationCompleted = new System.Threading.SendOrPostCallback(this.OnMI_AUSGL_SENDEN_NEWOperationCompleted);
            }
            this.InvokeAsync("MI_AUSGL_SENDEN_NEW", new object[] {
                        COMMAND,
                        AUSGEGLICHEN}, this.MI_AUSGL_SENDEN_NEWOperationCompleted, userState);
        }
        
        private void OnMI_AUSGL_SENDEN_NEWOperationCompleted(object arg) {
            if ((this.MI_AUSGL_SENDEN_NEWCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.MI_AUSGL_SENDEN_NEWCompleted(this, new MI_AUSGL_SENDEN_NEWCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="_-STZH_-FI_AUSGLEICHMELDUNG_KISS", Namespace="urn:sap-com:document:sap:rfc:functions")]
    public partial class _STZH_FI_AUSGLEICHMELDUNG_KISS {
        
        private string oPBELField;
        
        private string oPUPWField;
        
        private string oPUPKField;
        
        private string oPUPZField;
        
        private string gPARTField;
        
        private string vTREFField;
        
        private string eZDATField;
        
        private string aUGDTField;
        
        private decimal aUGBTField;
        
        private bool aUGBTFieldSpecified;
        
        private string aUGBLField;
        
        private string aUGRDField;
        
        private string wVSTATField;
        
        private string kEYZ1Field;
        
        private string pOSZAField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OPBEL {
            get {
                return this.oPBELField;
            }
            set {
                this.oPBELField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OPUPW {
            get {
                return this.oPUPWField;
            }
            set {
                this.oPUPWField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OPUPK {
            get {
                return this.oPUPKField;
            }
            set {
                this.oPUPKField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OPUPZ {
            get {
                return this.oPUPZField;
            }
            set {
                this.oPUPZField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string GPART {
            get {
                return this.gPARTField;
            }
            set {
                this.gPARTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string VTREF {
            get {
                return this.vTREFField;
            }
            set {
                this.vTREFField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string EZDAT {
            get {
                return this.eZDATField;
            }
            set {
                this.eZDATField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AUGDT {
            get {
                return this.aUGDTField;
            }
            set {
                this.aUGDTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal AUGBT {
            get {
                return this.aUGBTField;
            }
            set {
                this.aUGBTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AUGBTSpecified {
            get {
                return this.aUGBTFieldSpecified;
            }
            set {
                this.aUGBTFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AUGBL {
            get {
                return this.aUGBLField;
            }
            set {
                this.aUGBLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AUGRD {
            get {
                return this.aUGRDField;
            }
            set {
                this.aUGRDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string WVSTAT {
            get {
                return this.wVSTATField;
            }
            set {
                this.wVSTATField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string KEYZ1 {
            get {
                return this.kEYZ1Field;
            }
            set {
                this.kEYZ1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string POSZA {
            get {
                return this.pOSZAField;
            }
            set {
                this.pOSZAField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void MI_AUSGL_SENDEN_NEWCompletedEventHandler(object sender, MI_AUSGL_SENDEN_NEWCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MI_AUSGL_SENDEN_NEWCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal MI_AUSGL_SENDEN_NEWCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public _STZH_FI_AUSGLEICHMELDUNG_KISS[] AUSGEGLICHEN {
            get {
                this.RaiseExceptionIfNecessary();
                return ((_STZH_FI_AUSGLEICHMELDUNG_KISS[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591