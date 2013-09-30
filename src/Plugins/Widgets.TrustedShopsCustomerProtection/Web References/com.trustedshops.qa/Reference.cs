﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.18052
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Der Quellcode wurde automatisch mit Microsoft.VSDesigner generiert. Version 4.0.30319.18052.
// 
#pragma warning disable 1591

namespace SmartStore.Plugin.Widgets.TrustedShopsCustomerProtection.com.trustedshops.qa {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="TSProtectionBinding", Namespace="http://protection.action.b2b.ts.nhp.com/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(baseEntity))]
    public partial class TSProtectionService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback aliveOperationCompleted;
        
        private System.Threading.SendOrPostCallback checkCertificateOperationCompleted;
        
        private System.Threading.SendOrPostCallback checkLoginOperationCompleted;
        
        private System.Threading.SendOrPostCallback checkShopStatusOperationCompleted;
        
        private System.Threading.SendOrPostCallback getProtectionItemsOperationCompleted;
        
        private System.Threading.SendOrPostCallback pingOperationCompleted;
        
        private System.Threading.SendOrPostCallback protectWithAverageDeliveryDaysOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public TSProtectionService() {
            this.Url = global::SmartStore.Plugin.Widgets.TrustedShopsCustomerProtection.Properties.Settings.Default.SmartStore_Plugin_Widgets_TrustedShopsCustomerProtection_com_trustedshops_qa_TSProtectionService;
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
        public event aliveCompletedEventHandler aliveCompleted;
        
        /// <remarks/>
        public event checkCertificateCompletedEventHandler checkCertificateCompleted;
        
        /// <remarks/>
        public event checkLoginCompletedEventHandler checkLoginCompleted;
        
        /// <remarks/>
        public event checkShopStatusCompletedEventHandler checkShopStatusCompleted;
        
        /// <remarks/>
        public event getProtectionItemsCompletedEventHandler getProtectionItemsCompleted;
        
        /// <remarks/>
        public event pingCompletedEventHandler pingCompleted;
        
        /// <remarks/>
        public event protectWithAverageDeliveryDaysCompletedEventHandler protectWithAverageDeliveryDaysCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="http://protection.action.b2b.ts.nhp.com/", ResponseNamespace="http://protection.action.b2b.ts.nhp.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal)]
        [return: System.Xml.Serialization.XmlElementAttribute("return")]
        public int alive() {
            object[] results = this.Invoke("alive", new object[0]);
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void aliveAsync() {
            this.aliveAsync(null);
        }
        
        /// <remarks/>
        public void aliveAsync(object userState) {
            if ((this.aliveOperationCompleted == null)) {
                this.aliveOperationCompleted = new System.Threading.SendOrPostCallback(this.OnaliveOperationCompleted);
            }
            this.InvokeAsync("alive", new object[0], this.aliveOperationCompleted, userState);
        }
        
        private void OnaliveOperationCompleted(object arg) {
            if ((this.aliveCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.aliveCompleted(this, new aliveCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="http://protection.action.b2b.ts.nhp.com/", ResponseNamespace="http://protection.action.b2b.ts.nhp.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal)]
        [return: System.Xml.Serialization.XmlElementAttribute("certificateStatus")]
        public CertificateStatus checkCertificate(string tsId) {
            object[] results = this.Invoke("checkCertificate", new object[] {
                        tsId});
            return ((CertificateStatus)(results[0]));
        }
        
        /// <remarks/>
        public void checkCertificateAsync(string tsId) {
            this.checkCertificateAsync(tsId, null);
        }
        
        /// <remarks/>
        public void checkCertificateAsync(string tsId, object userState) {
            if ((this.checkCertificateOperationCompleted == null)) {
                this.checkCertificateOperationCompleted = new System.Threading.SendOrPostCallback(this.OncheckCertificateOperationCompleted);
            }
            this.InvokeAsync("checkCertificate", new object[] {
                        tsId}, this.checkCertificateOperationCompleted, userState);
        }
        
        private void OncheckCertificateOperationCompleted(object arg) {
            if ((this.checkCertificateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.checkCertificateCompleted(this, new checkCertificateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="http://protection.action.b2b.ts.nhp.com/", ResponseNamespace="http://protection.action.b2b.ts.nhp.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal)]
        [return: System.Xml.Serialization.XmlElementAttribute("checkLogin")]
        public long checkLogin(string tsId, string wsUser, string wsPassword) {
            object[] results = this.Invoke("checkLogin", new object[] {
                        tsId,
                        wsUser,
                        wsPassword});
            return ((long)(results[0]));
        }
        
        /// <remarks/>
        public void checkLoginAsync(string tsId, string wsUser, string wsPassword) {
            this.checkLoginAsync(tsId, wsUser, wsPassword, null);
        }
        
        /// <remarks/>
        public void checkLoginAsync(string tsId, string wsUser, string wsPassword, object userState) {
            if ((this.checkLoginOperationCompleted == null)) {
                this.checkLoginOperationCompleted = new System.Threading.SendOrPostCallback(this.OncheckLoginOperationCompleted);
            }
            this.InvokeAsync("checkLogin", new object[] {
                        tsId,
                        wsUser,
                        wsPassword}, this.checkLoginOperationCompleted, userState);
        }
        
        private void OncheckLoginOperationCompleted(object arg) {
            if ((this.checkLoginCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.checkLoginCompleted(this, new checkLoginCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="http://protection.action.b2b.ts.nhp.com/", ResponseNamespace="http://protection.action.b2b.ts.nhp.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal)]
        [return: System.Xml.Serialization.XmlElementAttribute("shopStatus")]
        public long checkShopStatus(string tsId, string tsProductId, string wsUser, string wsPassword) {
            object[] results = this.Invoke("checkShopStatus", new object[] {
                        tsId,
                        tsProductId,
                        wsUser,
                        wsPassword});
            return ((long)(results[0]));
        }
        
        /// <remarks/>
        public void checkShopStatusAsync(string tsId, string tsProductId, string wsUser, string wsPassword) {
            this.checkShopStatusAsync(tsId, tsProductId, wsUser, wsPassword, null);
        }
        
        /// <remarks/>
        public void checkShopStatusAsync(string tsId, string tsProductId, string wsUser, string wsPassword, object userState) {
            if ((this.checkShopStatusOperationCompleted == null)) {
                this.checkShopStatusOperationCompleted = new System.Threading.SendOrPostCallback(this.OncheckShopStatusOperationCompleted);
            }
            this.InvokeAsync("checkShopStatus", new object[] {
                        tsId,
                        tsProductId,
                        wsUser,
                        wsPassword}, this.checkShopStatusOperationCompleted, userState);
        }
        
        private void OncheckShopStatusOperationCompleted(object arg) {
            if ((this.checkShopStatusCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.checkShopStatusCompleted(this, new checkShopStatusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="http://protection.action.b2b.ts.nhp.com/", ResponseNamespace="http://protection.action.b2b.ts.nhp.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal)]
        [return: System.Xml.Serialization.XmlArrayAttribute("getProtectionItems")]
        [return: System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public protectionItem[] getProtectionItems(string tsId) {
            object[] results = this.Invoke("getProtectionItems", new object[] {
                        tsId});
            return ((protectionItem[])(results[0]));
        }
        
        /// <remarks/>
        public void getProtectionItemsAsync(string tsId) {
            this.getProtectionItemsAsync(tsId, null);
        }
        
        /// <remarks/>
        public void getProtectionItemsAsync(string tsId, object userState) {
            if ((this.getProtectionItemsOperationCompleted == null)) {
                this.getProtectionItemsOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetProtectionItemsOperationCompleted);
            }
            this.InvokeAsync("getProtectionItems", new object[] {
                        tsId}, this.getProtectionItemsOperationCompleted, userState);
        }
        
        private void OngetProtectionItemsOperationCompleted(object arg) {
            if ((this.getProtectionItemsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getProtectionItemsCompleted(this, new getProtectionItemsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="http://protection.action.b2b.ts.nhp.com/", ResponseNamespace="http://protection.action.b2b.ts.nhp.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal)]
        [return: System.Xml.Serialization.XmlElementAttribute("return")]
        public int ping(int arg0) {
            object[] results = this.Invoke("ping", new object[] {
                        arg0});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void pingAsync(int arg0) {
            this.pingAsync(arg0, null);
        }
        
        /// <remarks/>
        public void pingAsync(int arg0, object userState) {
            if ((this.pingOperationCompleted == null)) {
                this.pingOperationCompleted = new System.Threading.SendOrPostCallback(this.OnpingOperationCompleted);
            }
            this.InvokeAsync("ping", new object[] {
                        arg0}, this.pingOperationCompleted, userState);
        }
        
        private void OnpingOperationCompleted(object arg) {
            if ((this.pingCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.pingCompleted(this, new pingCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="http://protection.action.b2b.ts.nhp.com/", ResponseNamespace="http://protection.action.b2b.ts.nhp.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal)]
        [return: System.Xml.Serialization.XmlElementAttribute("protectionNumber")]
        public long protectWithAverageDeliveryDays(string tsId, string tsProductId, decimal amount, string currency, string paymentType, string buyerEmail, string shopCustomerID, string shopOrderID, System.DateTime orderDate, string wsUser, string wsPassword) {
            object[] results = this.Invoke("protectWithAverageDeliveryDays", new object[] {
                        tsId,
                        tsProductId,
                        amount,
                        currency,
                        paymentType,
                        buyerEmail,
                        shopCustomerID,
                        shopOrderID,
                        orderDate,
                        wsUser,
                        wsPassword});
            return ((long)(results[0]));
        }
        
        /// <remarks/>
        public void protectWithAverageDeliveryDaysAsync(string tsId, string tsProductId, decimal amount, string currency, string paymentType, string buyerEmail, string shopCustomerID, string shopOrderID, System.DateTime orderDate, string wsUser, string wsPassword) {
            this.protectWithAverageDeliveryDaysAsync(tsId, tsProductId, amount, currency, paymentType, buyerEmail, shopCustomerID, shopOrderID, orderDate, wsUser, wsPassword, null);
        }
        
        /// <remarks/>
        public void protectWithAverageDeliveryDaysAsync(string tsId, string tsProductId, decimal amount, string currency, string paymentType, string buyerEmail, string shopCustomerID, string shopOrderID, System.DateTime orderDate, string wsUser, string wsPassword, object userState) {
            if ((this.protectWithAverageDeliveryDaysOperationCompleted == null)) {
                this.protectWithAverageDeliveryDaysOperationCompleted = new System.Threading.SendOrPostCallback(this.OnprotectWithAverageDeliveryDaysOperationCompleted);
            }
            this.InvokeAsync("protectWithAverageDeliveryDays", new object[] {
                        tsId,
                        tsProductId,
                        amount,
                        currency,
                        paymentType,
                        buyerEmail,
                        shopCustomerID,
                        shopOrderID,
                        orderDate,
                        wsUser,
                        wsPassword}, this.protectWithAverageDeliveryDaysOperationCompleted, userState);
        }
        
        private void OnprotectWithAverageDeliveryDaysOperationCompleted(object arg) {
            if ((this.protectWithAverageDeliveryDaysCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.protectWithAverageDeliveryDaysCompleted(this, new protectWithAverageDeliveryDaysCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://protection.action.b2b.ts.nhp.com/")]
    public partial class CertificateStatus {
        
        private string certificationLanguageField;
        
        private string stateEnumField;
        
        private string tsIDField;
        
        private string typeEnumField;
        
        private string urlField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string certificationLanguage {
            get {
                return this.certificationLanguageField;
            }
            set {
                this.certificationLanguageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string stateEnum {
            get {
                return this.stateEnumField;
            }
            set {
                this.stateEnumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string tsID {
            get {
                return this.tsIDField;
            }
            set {
                this.tsIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string typeEnum {
            get {
                return this.typeEnumField;
            }
            set {
                this.typeEnumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(protectionItem))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://protection.action.b2b.ts.nhp.com/")]
    public partial class baseEntity {
        
        private System.DateTime creationDateField;
        
        private bool creationDateFieldSpecified;
        
        private long idField;
        
        private bool idFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.DateTime creationDate {
            get {
                return this.creationDateField;
            }
            set {
                this.creationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool creationDateSpecified {
            get {
                return this.creationDateFieldSpecified;
            }
            set {
                this.creationDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://protection.action.b2b.ts.nhp.com/")]
    public partial class protectionItem : baseEntity {
        
        private currencyEnum currencyField;
        
        private bool currencyFieldSpecified;
        
        private decimal grossFeeField;
        
        private bool grossFeeFieldSpecified;
        
        private decimal netFeeField;
        
        private bool netFeeFieldSpecified;
        
        private decimal protectedAmountDecimalField;
        
        private bool protectedAmountDecimalFieldSpecified;
        
        private int protectionDurationIntField;
        
        private string tsProductIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public currencyEnum currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool currencySpecified {
            get {
                return this.currencyFieldSpecified;
            }
            set {
                this.currencyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal grossFee {
            get {
                return this.grossFeeField;
            }
            set {
                this.grossFeeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool grossFeeSpecified {
            get {
                return this.grossFeeFieldSpecified;
            }
            set {
                this.grossFeeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal netFee {
            get {
                return this.netFeeField;
            }
            set {
                this.netFeeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool netFeeSpecified {
            get {
                return this.netFeeFieldSpecified;
            }
            set {
                this.netFeeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal protectedAmountDecimal {
            get {
                return this.protectedAmountDecimalField;
            }
            set {
                this.protectedAmountDecimalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool protectedAmountDecimalSpecified {
            get {
                return this.protectedAmountDecimalFieldSpecified;
            }
            set {
                this.protectedAmountDecimalFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int protectionDurationInt {
            get {
                return this.protectionDurationIntField;
            }
            set {
                this.protectionDurationIntField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string tsProductID {
            get {
                return this.tsProductIDField;
            }
            set {
                this.tsProductIDField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://protection.action.b2b.ts.nhp.com/")]
    public enum currencyEnum {
        
        /// <remarks/>
        EUR,
        
        /// <remarks/>
        USD,
        
        /// <remarks/>
        AUD,
        
        /// <remarks/>
        CAD,
        
        /// <remarks/>
        CHF,
        
        /// <remarks/>
        DKK,
        
        /// <remarks/>
        GBP,
        
        /// <remarks/>
        JPY,
        
        /// <remarks/>
        NZD,
        
        /// <remarks/>
        SEK,
        
        /// <remarks/>
        PLN,
        
        /// <remarks/>
        NOK,
        
        /// <remarks/>
        BGN,
        
        /// <remarks/>
        LVL,
        
        /// <remarks/>
        LTL,
        
        /// <remarks/>
        RON,
        
        /// <remarks/>
        RUB,
        
        /// <remarks/>
        TRY,
        
        /// <remarks/>
        CZK,
        
        /// <remarks/>
        HUF,
        
        /// <remarks/>
        HRK,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void aliveCompletedEventHandler(object sender, aliveCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class aliveCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal aliveCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void checkCertificateCompletedEventHandler(object sender, checkCertificateCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class checkCertificateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal checkCertificateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public CertificateStatus Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((CertificateStatus)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void checkLoginCompletedEventHandler(object sender, checkLoginCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class checkLoginCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal checkLoginCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public long Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((long)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void checkShopStatusCompletedEventHandler(object sender, checkShopStatusCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class checkShopStatusCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal checkShopStatusCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public long Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((long)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void getProtectionItemsCompletedEventHandler(object sender, getProtectionItemsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getProtectionItemsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getProtectionItemsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public protectionItem[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((protectionItem[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void pingCompletedEventHandler(object sender, pingCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class pingCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal pingCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void protectWithAverageDeliveryDaysCompletedEventHandler(object sender, protectWithAverageDeliveryDaysCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class protectWithAverageDeliveryDaysCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal protectWithAverageDeliveryDaysCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public long Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((long)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591