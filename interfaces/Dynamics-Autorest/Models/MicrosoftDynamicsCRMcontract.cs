// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Spice.Interfaces.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.contract
    /// </summary>
    public partial class MicrosoftDynamicsCRMcontract
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMcontract
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMcontract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMcontract
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMcontract(int? utcconversiontimezonecode = default(int?), System.DateTimeOffset? billingstarton = default(System.DateTimeOffset?), decimal? totaldiscount = default(decimal?), decimal? totalpriceBase = default(decimal?), string title = default(string), string _owningbusinessunitValue = default(string), string entityimageUrl = default(string), string _billingaccountidValue = default(string), string contractid = default(string), string contractnumber = default(string), string _createdonbehalfbyValue = default(string), string _originatingcontractValue = default(string), string _billingcontactidValue = default(string), string _billtoaddressValue = default(string), string _modifiedonbehalfbyValue = default(string), string _contactidValue = default(string), string _createdbyValue = default(string), int? allotmenttypecode = default(int?), string _customeridValue = default(string), string _accountidValue = default(string), string effectivitycalendar = default(string), string _billingcustomeridValue = default(string), string entityimageid = default(string), int? billingfrequencycode = default(int?), string _contracttemplateidValue = default(string), decimal? totalprice = default(decimal?), string contractlanguage = default(string), string _modifiedbyValue = default(string), int? statuscode = default(int?), string emailaddress = default(string), decimal? exchangerate = default(decimal?), string versionnumber = default(string), string _owningteamValue = default(string), System.DateTimeOffset? billingendon = default(System.DateTimeOffset?), System.DateTimeOffset? cancelon = default(System.DateTimeOffset?), int? duration = default(int?), string _owninguserValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), decimal? totaldiscountBase = default(decimal?), byte[] entityimage = default(byte[]), long? entityimageTimestamp = default(long?), int? statecode = default(int?), string _serviceaddressValue = default(string), decimal? netprice = default(decimal?), string _owneridValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? contractservicelevelcode = default(int?), string contracttemplateabbreviation = default(string), System.DateTimeOffset? activeon = default(System.DateTimeOffset?), string _transactioncurrencyidValue = default(string), int? importsequencenumber = default(int?), int? timezoneruleversionnumber = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), decimal? netpriceBase = default(decimal?), bool? usediscountaspercentage = default(bool?), System.DateTimeOffset? expireson = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMactivitypointer> contractActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMsyncerror> contractSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMactivityparty> contractActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMduplicaterecord> contractDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> contractDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> contractAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> contractMailboxTrackingFolder = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> contractProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> contractBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> contractPrincipalobjectattributeaccess = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMappointment> contractAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMemail> contractEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> contractFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMletter> contractLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMphonecall> contractPhonecalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMtask> contractTasks = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> contractRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMsocialactivity> contractSocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMconnection> contractConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMconnection> contractConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMannotation> contractAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMserviceappointment> contractServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), MicrosoftDynamicsCRMaccount billingcustomeridAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMaccount customeridAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMcontact billingcustomeridContact = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMcontact customeridContact = default(MicrosoftDynamicsCRMcontact), IList<MicrosoftDynamicsCRMincident> contractCases = default(IList<MicrosoftDynamicsCRMincident>), IList<MicrosoftDynamicsCRMcontractdetail> contractLineItems = default(IList<MicrosoftDynamicsCRMcontractdetail>), MicrosoftDynamicsCRMcontract originatingcontract = default(MicrosoftDynamicsCRMcontract), IList<MicrosoftDynamicsCRMcontract> contractOriginatingContract = default(IList<MicrosoftDynamicsCRMcontract>), IList<MicrosoftDynamicsCRMcontact> servicecontractcontactsAssociation = default(IList<MicrosoftDynamicsCRMcontact>), MicrosoftDynamicsCRMcontracttemplate contracttemplateid = default(MicrosoftDynamicsCRMcontracttemplate), MicrosoftDynamicsCRMcustomeraddress billtoaddress = default(MicrosoftDynamicsCRMcustomeraddress), MicrosoftDynamicsCRMcustomeraddress serviceaddress = default(MicrosoftDynamicsCRMcustomeraddress), IList<MicrosoftDynamicsCRMspiceRequiredchecks> contractSpiceRequiredcheckses = default(IList<MicrosoftDynamicsCRMspiceRequiredchecks>))
        {
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Billingstarton = billingstarton;
            Totaldiscount = totaldiscount;
            TotalpriceBase = totalpriceBase;
            Title = title;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            EntityimageUrl = entityimageUrl;
            this._billingaccountidValue = _billingaccountidValue;
            Contractid = contractid;
            Contractnumber = contractnumber;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._originatingcontractValue = _originatingcontractValue;
            this._billingcontactidValue = _billingcontactidValue;
            this._billtoaddressValue = _billtoaddressValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._contactidValue = _contactidValue;
            this._createdbyValue = _createdbyValue;
            Allotmenttypecode = allotmenttypecode;
            this._customeridValue = _customeridValue;
            this._accountidValue = _accountidValue;
            Effectivitycalendar = effectivitycalendar;
            this._billingcustomeridValue = _billingcustomeridValue;
            Entityimageid = entityimageid;
            Billingfrequencycode = billingfrequencycode;
            this._contracttemplateidValue = _contracttemplateidValue;
            Totalprice = totalprice;
            Contractlanguage = contractlanguage;
            this._modifiedbyValue = _modifiedbyValue;
            Statuscode = statuscode;
            Emailaddress = emailaddress;
            Exchangerate = exchangerate;
            Versionnumber = versionnumber;
            this._owningteamValue = _owningteamValue;
            Billingendon = billingendon;
            Cancelon = cancelon;
            Duration = duration;
            this._owninguserValue = _owninguserValue;
            Modifiedon = modifiedon;
            TotaldiscountBase = totaldiscountBase;
            Entityimage = entityimage;
            EntityimageTimestamp = entityimageTimestamp;
            Statecode = statecode;
            this._serviceaddressValue = _serviceaddressValue;
            Netprice = netprice;
            this._owneridValue = _owneridValue;
            Overriddencreatedon = overriddencreatedon;
            Contractservicelevelcode = contractservicelevelcode;
            Contracttemplateabbreviation = contracttemplateabbreviation;
            Activeon = activeon;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Importsequencenumber = importsequencenumber;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Createdon = createdon;
            NetpriceBase = netpriceBase;
            Usediscountaspercentage = usediscountaspercentage;
            Expireson = expireson;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            ContractActivityPointers = contractActivityPointers;
            ContractSyncErrors = contractSyncErrors;
            ContractActivityParties = contractActivityParties;
            ContractDuplicateMatchingRecord = contractDuplicateMatchingRecord;
            ContractDuplicateBaseRecord = contractDuplicateBaseRecord;
            ContractAsyncOperations = contractAsyncOperations;
            ContractMailboxTrackingFolder = contractMailboxTrackingFolder;
            ContractProcessSessions = contractProcessSessions;
            ContractBulkDeleteFailures = contractBulkDeleteFailures;
            ContractPrincipalobjectattributeaccess = contractPrincipalobjectattributeaccess;
            Transactioncurrencyid = transactioncurrencyid;
            ContractAppointments = contractAppointments;
            ContractEmails = contractEmails;
            ContractFaxes = contractFaxes;
            ContractLetters = contractLetters;
            ContractPhonecalls = contractPhonecalls;
            ContractTasks = contractTasks;
            ContractRecurringAppointmentMasters = contractRecurringAppointmentMasters;
            ContractSocialActivities = contractSocialActivities;
            ContractConnections1 = contractConnections1;
            ContractConnections2 = contractConnections2;
            ContractAnnotation = contractAnnotation;
            ContractServiceAppointments = contractServiceAppointments;
            BillingcustomeridAccount = billingcustomeridAccount;
            CustomeridAccount = customeridAccount;
            BillingcustomeridContact = billingcustomeridContact;
            CustomeridContact = customeridContact;
            ContractCases = contractCases;
            ContractLineItems = contractLineItems;
            Originatingcontract = originatingcontract;
            ContractOriginatingContract = contractOriginatingContract;
            ServicecontractcontactsAssociation = servicecontractcontactsAssociation;
            Contracttemplateid = contracttemplateid;
            Billtoaddress = billtoaddress;
            Serviceaddress = serviceaddress;
            ContractSpiceRequiredcheckses = contractSpiceRequiredcheckses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billingstarton")]
        public System.DateTimeOffset? Billingstarton { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totaldiscount")]
        public decimal? Totaldiscount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalprice_base")]
        public decimal? TotalpriceBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_url")]
        public string EntityimageUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_billingaccountid_value")]
        public string _billingaccountidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contractid")]
        public string Contractid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contractnumber")]
        public string Contractnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_originatingcontract_value")]
        public string _originatingcontractValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_billingcontactid_value")]
        public string _billingcontactidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_billtoaddress_value")]
        public string _billtoaddressValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_contactid_value")]
        public string _contactidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "allotmenttypecode")]
        public int? Allotmenttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_customerid_value")]
        public string _customeridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_accountid_value")]
        public string _accountidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "effectivitycalendar")]
        public string Effectivitycalendar { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_billingcustomerid_value")]
        public string _billingcustomeridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimageid")]
        public string Entityimageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billingfrequencycode")]
        public int? Billingfrequencycode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_contracttemplateid_value")]
        public string _contracttemplateidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalprice")]
        public decimal? Totalprice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contractlanguage")]
        public string Contractlanguage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailaddress")]
        public string Emailaddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billingendon")]
        public System.DateTimeOffset? Billingendon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cancelon")]
        public System.DateTimeOffset? Cancelon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totaldiscount_base")]
        public decimal? TotaldiscountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(Base64UrlJsonConverter))]
        [JsonProperty(PropertyName = "entityimage")]
        public byte[] Entityimage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_timestamp")]
        public long? EntityimageTimestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_serviceaddress_value")]
        public string _serviceaddressValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "netprice")]
        public decimal? Netprice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contractservicelevelcode")]
        public int? Contractservicelevelcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contracttemplateabbreviation")]
        public string Contracttemplateabbreviation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activeon")]
        public System.DateTimeOffset? Activeon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "netprice_base")]
        public decimal? NetpriceBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "usediscountaspercentage")]
        public bool? Usediscountaspercentage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "expireson")]
        public System.DateTimeOffset? Expireson { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Contract_ActivityPointers")]
        public IList<MicrosoftDynamicsCRMactivitypointer> ContractActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Contract_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> ContractSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contract_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> ContractActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Contract_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> ContractDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Contract_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> ContractDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Contract_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ContractAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Contract_MailboxTrackingFolder")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ContractMailboxTrackingFolder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Contract_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> ContractProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Contract_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> ContractBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contract_principalobjectattributeaccess")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ContractPrincipalobjectattributeaccess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Contract_Appointments")]
        public IList<MicrosoftDynamicsCRMappointment> ContractAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Contract_Emails")]
        public IList<MicrosoftDynamicsCRMemail> ContractEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Contract_Faxes")]
        public IList<MicrosoftDynamicsCRMfax> ContractFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Contract_Letters")]
        public IList<MicrosoftDynamicsCRMletter> ContractLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Contract_Phonecalls")]
        public IList<MicrosoftDynamicsCRMphonecall> ContractPhonecalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Contract_Tasks")]
        public IList<MicrosoftDynamicsCRMtask> ContractTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Contract_RecurringAppointmentMasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> ContractRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Contract_SocialActivities")]
        public IList<MicrosoftDynamicsCRMsocialactivity> ContractSocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contract_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> ContractConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contract_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> ContractConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Contract_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> ContractAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Contract_ServiceAppointments")]
        public IList<MicrosoftDynamicsCRMserviceappointment> ContractServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billingcustomerid_account")]
        public MicrosoftDynamicsCRMaccount BillingcustomeridAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customerid_account")]
        public MicrosoftDynamicsCRMaccount CustomeridAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billingcustomerid_contact")]
        public MicrosoftDynamicsCRMcontact BillingcustomeridContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customerid_contact")]
        public MicrosoftDynamicsCRMcontact CustomeridContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contract_cases")]
        public IList<MicrosoftDynamicsCRMincident> ContractCases { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contract_line_items")]
        public IList<MicrosoftDynamicsCRMcontractdetail> ContractLineItems { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "originatingcontract")]
        public MicrosoftDynamicsCRMcontract Originatingcontract { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contract_originating_contract")]
        public IList<MicrosoftDynamicsCRMcontract> ContractOriginatingContract { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "servicecontractcontacts_association")]
        public IList<MicrosoftDynamicsCRMcontact> ServicecontractcontactsAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contracttemplateid")]
        public MicrosoftDynamicsCRMcontracttemplate Contracttemplateid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billtoaddress")]
        public MicrosoftDynamicsCRMcustomeraddress Billtoaddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceaddress")]
        public MicrosoftDynamicsCRMcustomeraddress Serviceaddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contract_spice_requiredcheckses")]
        public IList<MicrosoftDynamicsCRMspiceRequiredchecks> ContractSpiceRequiredcheckses { get; set; }

    }
}
