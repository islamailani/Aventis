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

namespace KiSSSvc.SAP.PSCD.WebServiceHelper.WebReferences.UserSenden {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="MI_KISS_ANSPER_UPDATEBinding", Namespace="http://STZH")]
    public partial class MI_KISS_ANSPER_UPDATEService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback MI_KISS_ANSPER_UPDATEOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public MI_KISS_ANSPER_UPDATEService() {
            this.Url = global::KiSSSvc.SAP.PSCD.WebServiceHelper.Properties.Settings.Default.KiSSSvc_SAP_PSCD_WebServiceHelper_WebReferences_UserSenden_MI_KISS_ANSPER_UPDATEService;
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
        public event MI_KISS_ANSPER_UPDATECompletedEventHandler MI_KISS_ANSPER_UPDATECompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://sap.com/xi/WebService/soap1.1", RequestElementName="_-STZH_-KISS_ANSPER_UPDATE", RequestNamespace="urn:sap-com:document:sap:rfc:functions", ResponseElementName="_-STZH_-KISS_ANSPER_UPDATE.Response", ResponseNamespace="urn:sap-com:document:sap:rfc:functions", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void MI_KISS_ANSPER_UPDATE([System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)] ref _STZH_SOZ_ANSPER[] IT_ANSPER) {
            object[] results = this.Invoke("MI_KISS_ANSPER_UPDATE", new object[] {
                        IT_ANSPER});
            IT_ANSPER = ((_STZH_SOZ_ANSPER[])(results[0]));
        }
        
        /// <remarks/>
        public void MI_KISS_ANSPER_UPDATEAsync(_STZH_SOZ_ANSPER[] IT_ANSPER) {
            this.MI_KISS_ANSPER_UPDATEAsync(IT_ANSPER, null);
        }
        
        /// <remarks/>
        public void MI_KISS_ANSPER_UPDATEAsync(_STZH_SOZ_ANSPER[] IT_ANSPER, object userState) {
            if ((this.MI_KISS_ANSPER_UPDATEOperationCompleted == null)) {
                this.MI_KISS_ANSPER_UPDATEOperationCompleted = new System.Threading.SendOrPostCallback(this.OnMI_KISS_ANSPER_UPDATEOperationCompleted);
            }
            this.InvokeAsync("MI_KISS_ANSPER_UPDATE", new object[] {
                        IT_ANSPER}, this.MI_KISS_ANSPER_UPDATEOperationCompleted, userState);
        }
        
        private void OnMI_KISS_ANSPER_UPDATEOperationCompleted(object arg) {
            if ((this.MI_KISS_ANSPER_UPDATECompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.MI_KISS_ANSPER_UPDATECompleted(this, new MI_KISS_ANSPER_UPDATECompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="_-STZH_-SOZ_ANSPER", Namespace="urn:sap-com:document:sap:rfc:functions")]
    public partial class _STZH_SOZ_ANSPER {
        
        private string mANDTField;
        
        private string aNSPART_IDField;
        
        private string kUERZELField;
        
        private string nACHNAMEField;
        
        private string vORNAMEField;
        
        private string tELEFONField;
        
        private string fAXField;
        
        private string eMAILField;
        
        private string _STZH_SOZ_SZField;
        
        private string _STZH_SOZ_QTField;
        
        private string _STZH_SOZ_LIN_01Field;
        
        private string _STZH_SOZ_LIN_02Field;
        
        private string _STZH_SOZ_LIN_03Field;
        
        private string _STZH_SOZ_LIN_04Field;
        
        private string _STZH_SOZ_LIN_05Field;
        
        private string _STZH_SOZ_LIN_06Field;
        
        private string _STZH_SOZ_LIN_07Field;
        
        private string _STZH_SOZ_LIN_08Field;
        
        private string _STZH_SOZ_LIN_09Field;
        
        private string _STZH_SOZ_LIN_10Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MANDT {
            get {
                return this.mANDTField;
            }
            set {
                this.mANDTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ANSPART_ID {
            get {
                return this.aNSPART_IDField;
            }
            set {
                this.aNSPART_IDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string KUERZEL {
            get {
                return this.kUERZELField;
            }
            set {
                this.kUERZELField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NACHNAME {
            get {
                return this.nACHNAMEField;
            }
            set {
                this.nACHNAMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string VORNAME {
            get {
                return this.vORNAMEField;
            }
            set {
                this.vORNAMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TELEFON {
            get {
                return this.tELEFONField;
            }
            set {
                this.tELEFONField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FAX {
            get {
                return this.fAXField;
            }
            set {
                this.fAXField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string EMAIL {
            get {
                return this.eMAILField;
            }
            set {
                this.eMAILField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_-STZH_-SOZ_SZ", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string _STZH_SOZ_SZ {
            get {
                return this._STZH_SOZ_SZField;
            }
            set {
                this._STZH_SOZ_SZField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_-STZH_-SOZ_QT", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string _STZH_SOZ_QT {
            get {
                return this._STZH_SOZ_QTField;
            }
            set {
                this._STZH_SOZ_QTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_-STZH_-SOZ_LIN_01", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string _STZH_SOZ_LIN_01 {
            get {
                return this._STZH_SOZ_LIN_01Field;
            }
            set {
                this._STZH_SOZ_LIN_01Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_-STZH_-SOZ_LIN_02", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string _STZH_SOZ_LIN_02 {
            get {
                return this._STZH_SOZ_LIN_02Field;
            }
            set {
                this._STZH_SOZ_LIN_02Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_-STZH_-SOZ_LIN_03", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string _STZH_SOZ_LIN_03 {
            get {
                return this._STZH_SOZ_LIN_03Field;
            }
            set {
                this._STZH_SOZ_LIN_03Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_-STZH_-SOZ_LIN_04", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string _STZH_SOZ_LIN_04 {
            get {
                return this._STZH_SOZ_LIN_04Field;
            }
            set {
                this._STZH_SOZ_LIN_04Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_-STZH_-SOZ_LIN_05", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string _STZH_SOZ_LIN_05 {
            get {
                return this._STZH_SOZ_LIN_05Field;
            }
            set {
                this._STZH_SOZ_LIN_05Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_-STZH_-SOZ_LIN_06", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string _STZH_SOZ_LIN_06 {
            get {
                return this._STZH_SOZ_LIN_06Field;
            }
            set {
                this._STZH_SOZ_LIN_06Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_-STZH_-SOZ_LIN_07", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string _STZH_SOZ_LIN_07 {
            get {
                return this._STZH_SOZ_LIN_07Field;
            }
            set {
                this._STZH_SOZ_LIN_07Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_-STZH_-SOZ_LIN_08", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string _STZH_SOZ_LIN_08 {
            get {
                return this._STZH_SOZ_LIN_08Field;
            }
            set {
                this._STZH_SOZ_LIN_08Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_-STZH_-SOZ_LIN_09", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string _STZH_SOZ_LIN_09 {
            get {
                return this._STZH_SOZ_LIN_09Field;
            }
            set {
                this._STZH_SOZ_LIN_09Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_-STZH_-SOZ_LIN_10", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string _STZH_SOZ_LIN_10 {
            get {
                return this._STZH_SOZ_LIN_10Field;
            }
            set {
                this._STZH_SOZ_LIN_10Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void MI_KISS_ANSPER_UPDATECompletedEventHandler(object sender, MI_KISS_ANSPER_UPDATECompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MI_KISS_ANSPER_UPDATECompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal MI_KISS_ANSPER_UPDATECompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public _STZH_SOZ_ANSPER[] IT_ANSPER {
            get {
                this.RaiseExceptionIfNecessary();
                return ((_STZH_SOZ_ANSPER[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591