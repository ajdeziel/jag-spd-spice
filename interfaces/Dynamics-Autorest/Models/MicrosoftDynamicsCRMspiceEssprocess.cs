// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Spice.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.spice_essprocess
    /// </summary>
    public partial class MicrosoftDynamicsCRMspiceEssprocess
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMspiceEssprocess class.
        /// </summary>
        public MicrosoftDynamicsCRMspiceEssprocess()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMspiceEssprocess class.
        /// </summary>
        public MicrosoftDynamicsCRMspiceEssprocess(string _processidValue = default(string), int? timezoneruleversionnumber = default(int?), string businessprocessflowinstanceid = default(string), System.DateTimeOffset? activestagestartedon = default(System.DateTimeOffset?), int? statecode = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), string _createdbyValue = default(string), string _organizationidValue = default(string), string _createdonbehalfbyValue = default(string), string _activestageidValue = default(string), string _modifiedbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string traversedpath = default(string), string bpfName = default(string), int? importsequencenumber = default(int?), int? utcconversiontimezonecode = default(int?), System.DateTimeOffset? completedon = default(System.DateTimeOffset?), int? bpfDuration = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _bpfIncidentidValue = default(string), int? statuscode = default(int?), string versionnumber = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMprocessstage activestageid = default(MicrosoftDynamicsCRMprocessstage), MicrosoftDynamicsCRMworkflow processid = default(MicrosoftDynamicsCRMworkflow), IList<MicrosoftDynamicsCRMsyncerror> spiceEssprocessSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> spiceEssprocessAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMworkflowlog> spiceEssprocessWorkflowLogs = default(IList<MicrosoftDynamicsCRMworkflowlog>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> spiceEssprocessMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> spiceEssprocessProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> spiceEssprocessBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> spiceEssprocessPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMincident bpfIncidentid = default(MicrosoftDynamicsCRMincident))
        {
            this._processidValue = _processidValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Businessprocessflowinstanceid = businessprocessflowinstanceid;
            Activestagestartedon = activestagestartedon;
            Statecode = statecode;
            Overriddencreatedon = overriddencreatedon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._createdbyValue = _createdbyValue;
            this._organizationidValue = _organizationidValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._activestageidValue = _activestageidValue;
            this._modifiedbyValue = _modifiedbyValue;
            Createdon = createdon;
            Traversedpath = traversedpath;
            BpfName = bpfName;
            Importsequencenumber = importsequencenumber;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Completedon = completedon;
            BpfDuration = bpfDuration;
            Modifiedon = modifiedon;
            this._bpfIncidentidValue = _bpfIncidentidValue;
            Statuscode = statuscode;
            Versionnumber = versionnumber;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            Activestageid = activestageid;
            Processid = processid;
            SpiceEssprocessSyncErrors = spiceEssprocessSyncErrors;
            SpiceEssprocessAsyncOperations = spiceEssprocessAsyncOperations;
            SpiceEssprocessWorkflowLogs = spiceEssprocessWorkflowLogs;
            SpiceEssprocessMailboxTrackingFolders = spiceEssprocessMailboxTrackingFolders;
            SpiceEssprocessProcessSession = spiceEssprocessProcessSession;
            SpiceEssprocessBulkDeleteFailures = spiceEssprocessBulkDeleteFailures;
            SpiceEssprocessPrincipalObjectAttributeAccesses = spiceEssprocessPrincipalObjectAttributeAccesses;
            BpfIncidentid = bpfIncidentid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_processid_value")]
        public string _processidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "businessprocessflowinstanceid")]
        public string Businessprocessflowinstanceid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activestagestartedon")]
        public System.DateTimeOffset? Activestagestartedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_activestageid_value")]
        public string _activestageidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bpf_name")]
        public string BpfName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "completedon")]
        public System.DateTimeOffset? Completedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bpf_duration")]
        public int? BpfDuration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_bpf_incidentid_value")]
        public string _bpfIncidentidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

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
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activestageid")]
        public MicrosoftDynamicsCRMprocessstage Activestageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public MicrosoftDynamicsCRMworkflow Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_essprocess_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SpiceEssprocessSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_essprocess_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SpiceEssprocessAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_essprocess_WorkflowLogs")]
        public IList<MicrosoftDynamicsCRMworkflowlog> SpiceEssprocessWorkflowLogs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_essprocess_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> SpiceEssprocessMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_essprocess_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> SpiceEssprocessProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_essprocess_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> SpiceEssprocessBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_essprocess_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> SpiceEssprocessPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bpf_incidentid")]
        public MicrosoftDynamicsCRMincident BpfIncidentid { get; set; }

    }
}
