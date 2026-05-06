using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFleetAppsManagementRunbookVersions
{
    [JsiiClass(nativeType: typeof(oci.DataOciFleetAppsManagementRunbookVersions.DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsTasksTaskRecordDetailsExecutionDetailsOutputReference), fullyQualifiedName: "oci.dataOciFleetAppsManagementRunbookVersions.DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsTasksTaskRecordDetailsExecutionDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsTasksTaskRecordDetailsExecutionDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsTasksTaskRecordDetailsExecutionDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsTasksTaskRecordDetailsExecutionDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsTasksTaskRecordDetailsExecutionDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "catalogId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CatalogId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "command", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Command
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configFile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigFile
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "content", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementRunbookVersions.DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsTasksTaskRecordDetailsExecutionDetailsContentList\"}")]
        public virtual oci.DataOciFleetAppsManagementRunbookVersions.DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsTasksTaskRecordDetailsExecutionDetailsContentList Content
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementRunbookVersions.DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsTasksTaskRecordDetailsExecutionDetailsContentList>()!;
        }

        [JsiiProperty(name: "credentials", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementRunbookVersions.DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsTasksTaskRecordDetailsExecutionDetailsCredentialsList\"}")]
        public virtual oci.DataOciFleetAppsManagementRunbookVersions.DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsTasksTaskRecordDetailsExecutionDetailsCredentialsList Credentials
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementRunbookVersions.DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsTasksTaskRecordDetailsExecutionDetailsCredentialsList>()!;
        }

        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Endpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "executionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutionType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isExecutableContent", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsExecutableContent
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isLocked", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsLocked
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isReadOutputVariableEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsReadOutputVariableEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "targetCompartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetCompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "variables", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementRunbookVersions.DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsTasksTaskRecordDetailsExecutionDetailsVariablesList\"}")]
        public virtual oci.DataOciFleetAppsManagementRunbookVersions.DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsTasksTaskRecordDetailsExecutionDetailsVariablesList Variables
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementRunbookVersions.DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsTasksTaskRecordDetailsExecutionDetailsVariablesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementRunbookVersions.DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsTasksTaskRecordDetailsExecutionDetails\"}", isOptional: true)]
        public virtual oci.DataOciFleetAppsManagementRunbookVersions.IDataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsTasksTaskRecordDetailsExecutionDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementRunbookVersions.IDataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsTasksTaskRecordDetailsExecutionDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
