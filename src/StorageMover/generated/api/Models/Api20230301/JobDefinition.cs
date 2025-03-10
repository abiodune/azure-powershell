// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Extensions;

    /// <summary>The Job Definition resource.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.DoNotFormat]
    public partial class JobDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinition,
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionInternal,
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20.Resource();

        /// <summary>Name of the Agent to assign for new Job Runs of this Job Definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inlined)]
        public string AgentName { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionPropertiesInternal)Property).AgentName; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionPropertiesInternal)Property).AgentName = value ?? null; }

        /// <summary>
        /// Fully qualified resource id of the Agent to assign for new Job Runs of this Job Definition.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inlined)]
        public string AgentResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionPropertiesInternal)Property).AgentResourceId; }

        /// <summary>Strategy to use for copy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.CopyMode CopyMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionPropertiesInternal)Property).CopyMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionPropertiesInternal)Property).CopyMode = value ; }

        /// <summary>A description for the Job Definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inlined)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionPropertiesInternal)Property).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionPropertiesInternal)Property).Description = value ?? null; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20.IResourceInternal)__resource).Id; }

        /// <summary>The name of the Job Run in a non-terminal state, if exists.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inlined)]
        public string LatestJobRunName { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionPropertiesInternal)Property).LatestJobRunName; }

        /// <summary>
        /// The fully qualified resource ID of the Job Run in a non-terminal state, if exists.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inlined)]
        public string LatestJobRunResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionPropertiesInternal)Property).LatestJobRunResourceId; }

        /// <summary>The current status of the Job Run in a non-terminal state, if exists.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.JobRunStatus? LatestJobRunStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionPropertiesInternal)Property).LatestJobRunStatus; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for AgentResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionInternal.AgentResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionPropertiesInternal)Property).AgentResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionPropertiesInternal)Property).AgentResourceId = value; }

        /// <summary>Internal Acessors for LatestJobRunName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionInternal.LatestJobRunName { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionPropertiesInternal)Property).LatestJobRunName; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionPropertiesInternal)Property).LatestJobRunName = value; }

        /// <summary>Internal Acessors for LatestJobRunResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionInternal.LatestJobRunResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionPropertiesInternal)Property).LatestJobRunResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionPropertiesInternal)Property).LatestJobRunResourceId = value; }

        /// <summary>Internal Acessors for LatestJobRunStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.JobRunStatus? Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionInternal.LatestJobRunStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionPropertiesInternal)Property).LatestJobRunStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionPropertiesInternal)Property).LatestJobRunStatus = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionProperties Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.JobDefinitionProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for SourceResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionInternal.SourceResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionPropertiesInternal)Property).SourceResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionPropertiesInternal)Property).SourceResourceId = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20.ISystemData Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionInternal.SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20.SystemData()); set { {_systemData = value;} } }

        /// <summary>Internal Acessors for TargetResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionInternal.TargetResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionPropertiesInternal)Property).TargetResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionPropertiesInternal)Property).TargetResourceId = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionProperties _property;

        /// <summary>Job definition properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.JobDefinitionProperties()); set => this._property = value; }

        /// <summary>The provisioning state of this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionPropertiesInternal)Property).ProvisioningState; }

        /// <summary>The name of the source Endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inlined)]
        public string SourceName { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionPropertiesInternal)Property).SourceName; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionPropertiesInternal)Property).SourceName = value ; }

        /// <summary>Fully qualified resource ID of the source Endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inlined)]
        public string SourceResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionPropertiesInternal)Property).SourceResourceId; }

        /// <summary>The subpath to use when reading from the source Endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inlined)]
        public string SourceSubpath { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionPropertiesInternal)Property).SourceSubpath; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionPropertiesInternal)Property).SourceSubpath = value ?? null; }

        /// <summary>Backing field for <see cref="SystemData" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20.ISystemData _systemData;

        /// <summary>Resource system metadata.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20.ISystemData SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20.SystemData()); }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inlined)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20.ISystemDataInternal)SystemData).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20.ISystemDataInternal)SystemData).CreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inlined)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20.ISystemDataInternal)SystemData).CreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20.ISystemDataInternal)SystemData).CreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20.ISystemDataInternal)SystemData).CreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20.ISystemDataInternal)SystemData).CreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inlined)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20.ISystemDataInternal)SystemData).LastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20.ISystemDataInternal)SystemData).LastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inlined)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20.ISystemDataInternal)SystemData).LastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20.ISystemDataInternal)SystemData).LastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20.ISystemDataInternal)SystemData).LastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20.ISystemDataInternal)SystemData).LastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.CreatedByType)""); }

        /// <summary>The name of the target Endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inlined)]
        public string TargetName { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionPropertiesInternal)Property).TargetName; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionPropertiesInternal)Property).TargetName = value ; }

        /// <summary>Fully qualified resource ID of the target Endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inlined)]
        public string TargetResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionPropertiesInternal)Property).TargetResourceId; }

        /// <summary>The subpath to use when writing to the target Endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inlined)]
        public string TargetSubpath { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionPropertiesInternal)Property).TargetSubpath; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionPropertiesInternal)Property).TargetSubpath = value ?? null; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="JobDefinition" /> instance.</summary>
        public JobDefinition()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// The Job Definition resource.
    public partial interface IJobDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20.IResource
    {
        /// <summary>Name of the Agent to assign for new Job Runs of this Job Definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the Agent to assign for new Job Runs of this Job Definition.",
        SerializedName = @"agentName",
        PossibleTypes = new [] { typeof(string) })]
        string AgentName { get; set; }
        /// <summary>
        /// Fully qualified resource id of the Agent to assign for new Job Runs of this Job Definition.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Fully qualified resource id of the Agent to assign for new Job Runs of this Job Definition.",
        SerializedName = @"agentResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string AgentResourceId { get;  }
        /// <summary>Strategy to use for copy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Strategy to use for copy.",
        SerializedName = @"copyMode",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.CopyMode) })]
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.CopyMode CopyMode { get; set; }
        /// <summary>A description for the Job Definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A description for the Job Definition.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>The name of the Job Run in a non-terminal state, if exists.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The name of the Job Run in a non-terminal state, if exists.",
        SerializedName = @"latestJobRunName",
        PossibleTypes = new [] { typeof(string) })]
        string LatestJobRunName { get;  }
        /// <summary>
        /// The fully qualified resource ID of the Job Run in a non-terminal state, if exists.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The fully qualified resource ID of the Job Run in a non-terminal state, if exists.",
        SerializedName = @"latestJobRunResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string LatestJobRunResourceId { get;  }
        /// <summary>The current status of the Job Run in a non-terminal state, if exists.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The current status of the Job Run in a non-terminal state, if exists.",
        SerializedName = @"latestJobRunStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.JobRunStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.JobRunStatus? LatestJobRunStatus { get;  }
        /// <summary>The provisioning state of this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of this resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>The name of the source Endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the source Endpoint.",
        SerializedName = @"sourceName",
        PossibleTypes = new [] { typeof(string) })]
        string SourceName { get; set; }
        /// <summary>Fully qualified resource ID of the source Endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Fully qualified resource ID of the source Endpoint.",
        SerializedName = @"sourceResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string SourceResourceId { get;  }
        /// <summary>The subpath to use when reading from the source Endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The subpath to use when reading from the source Endpoint.",
        SerializedName = @"sourceSubpath",
        PossibleTypes = new [] { typeof(string) })]
        string SourceSubpath { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource creation (UTC).",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that created the resource.",
        SerializedName = @"createdBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that created the resource.",
        SerializedName = @"createdByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource last modification (UTC)",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that last modified the resource.",
        SerializedName = @"lastModifiedBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that last modified the resource.",
        SerializedName = @"lastModifiedByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }
        /// <summary>The name of the target Endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the target Endpoint.",
        SerializedName = @"targetName",
        PossibleTypes = new [] { typeof(string) })]
        string TargetName { get; set; }
        /// <summary>Fully qualified resource ID of the target Endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Fully qualified resource ID of the target Endpoint.",
        SerializedName = @"targetResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetResourceId { get;  }
        /// <summary>The subpath to use when writing to the target Endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The subpath to use when writing to the target Endpoint.",
        SerializedName = @"targetSubpath",
        PossibleTypes = new [] { typeof(string) })]
        string TargetSubpath { get; set; }

    }
    /// The Job Definition resource.
    internal partial interface IJobDefinitionInternal :
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20.IResourceInternal
    {
        /// <summary>Name of the Agent to assign for new Job Runs of this Job Definition.</summary>
        string AgentName { get; set; }
        /// <summary>
        /// Fully qualified resource id of the Agent to assign for new Job Runs of this Job Definition.
        /// </summary>
        string AgentResourceId { get; set; }
        /// <summary>Strategy to use for copy.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.CopyMode CopyMode { get; set; }
        /// <summary>A description for the Job Definition.</summary>
        string Description { get; set; }
        /// <summary>The name of the Job Run in a non-terminal state, if exists.</summary>
        string LatestJobRunName { get; set; }
        /// <summary>
        /// The fully qualified resource ID of the Job Run in a non-terminal state, if exists.
        /// </summary>
        string LatestJobRunResourceId { get; set; }
        /// <summary>The current status of the Job Run in a non-terminal state, if exists.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.JobRunStatus? LatestJobRunStatus { get; set; }
        /// <summary>Job definition properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IJobDefinitionProperties Property { get; set; }
        /// <summary>The provisioning state of this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>The name of the source Endpoint.</summary>
        string SourceName { get; set; }
        /// <summary>Fully qualified resource ID of the source Endpoint.</summary>
        string SourceResourceId { get; set; }
        /// <summary>The subpath to use when reading from the source Endpoint.</summary>
        string SourceSubpath { get; set; }
        /// <summary>Resource system metadata.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20.ISystemData SystemData { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }
        /// <summary>The name of the target Endpoint.</summary>
        string TargetName { get; set; }
        /// <summary>Fully qualified resource ID of the target Endpoint.</summary>
        string TargetResourceId { get; set; }
        /// <summary>The subpath to use when writing to the target Endpoint.</summary>
        string TargetSubpath { get; set; }

    }
}