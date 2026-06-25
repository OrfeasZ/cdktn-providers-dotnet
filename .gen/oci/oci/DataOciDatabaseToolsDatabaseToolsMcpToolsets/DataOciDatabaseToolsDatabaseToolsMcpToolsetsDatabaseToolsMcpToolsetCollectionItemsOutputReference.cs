using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseToolsDatabaseToolsMcpToolsets
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseToolsDatabaseToolsMcpToolsets.DataOciDatabaseToolsDatabaseToolsMcpToolsetsDatabaseToolsMcpToolsetCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseToolsDatabaseToolsMcpToolsets.DataOciDatabaseToolsDatabaseToolsMcpToolsetsDatabaseToolsMcpToolsetCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseToolsDatabaseToolsMcpToolsetsDatabaseToolsMcpToolsetCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseToolsDatabaseToolsMcpToolsetsDatabaseToolsMcpToolsetCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseToolsDatabaseToolsMcpToolsetsDatabaseToolsMcpToolsetCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseToolsDatabaseToolsMcpToolsetsDatabaseToolsMcpToolsetCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "allowedRoles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedRoles
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseToolsMcpServerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseToolsMcpServerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultExecutionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultExecutionType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "generativeAiSemanticStoreId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GenerativeAiSemanticStoreId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "locks", typeJson: "{\"fqn\":\"oci.dataOciDatabaseToolsDatabaseToolsMcpToolsets.DataOciDatabaseToolsDatabaseToolsMcpToolsetsDatabaseToolsMcpToolsetCollectionItemsLocksList\"}")]
        public virtual oci.DataOciDatabaseToolsDatabaseToolsMcpToolsets.DataOciDatabaseToolsDatabaseToolsMcpToolsetsDatabaseToolsMcpToolsetCollectionItemsLocksList Locks
        {
            get => GetInstanceProperty<oci.DataOciDatabaseToolsDatabaseToolsMcpToolsets.DataOciDatabaseToolsDatabaseToolsMcpToolsetsDatabaseToolsMcpToolsetCollectionItemsLocksList>()!;
        }

        [JsiiProperty(name: "reports", typeJson: "{\"fqn\":\"oci.dataOciDatabaseToolsDatabaseToolsMcpToolsets.DataOciDatabaseToolsDatabaseToolsMcpToolsetsDatabaseToolsMcpToolsetCollectionItemsReportsList\"}")]
        public virtual oci.DataOciDatabaseToolsDatabaseToolsMcpToolsets.DataOciDatabaseToolsDatabaseToolsMcpToolsetsDatabaseToolsMcpToolsetCollectionItemsReportsList Reports
        {
            get => GetInstanceProperty<oci.DataOciDatabaseToolsDatabaseToolsMcpToolsets.DataOciDatabaseToolsDatabaseToolsMcpToolsetsDatabaseToolsMcpToolsetCollectionItemsReportsList>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"oci.dataOciDatabaseToolsDatabaseToolsMcpToolsets.DataOciDatabaseToolsDatabaseToolsMcpToolsetsDatabaseToolsMcpToolsetCollectionItemsSourceList\"}")]
        public virtual oci.DataOciDatabaseToolsDatabaseToolsMcpToolsets.DataOciDatabaseToolsDatabaseToolsMcpToolsetsDatabaseToolsMcpToolsetCollectionItemsSourceList Source
        {
            get => GetInstanceProperty<oci.DataOciDatabaseToolsDatabaseToolsMcpToolsets.DataOciDatabaseToolsDatabaseToolsMcpToolsetsDatabaseToolsMcpToolsetCollectionItemsSourceList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "toolDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ToolDescription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "toolName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ToolName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tools", typeJson: "{\"fqn\":\"oci.dataOciDatabaseToolsDatabaseToolsMcpToolsets.DataOciDatabaseToolsDatabaseToolsMcpToolsetsDatabaseToolsMcpToolsetCollectionItemsToolsList\"}")]
        public virtual oci.DataOciDatabaseToolsDatabaseToolsMcpToolsets.DataOciDatabaseToolsDatabaseToolsMcpToolsetsDatabaseToolsMcpToolsetCollectionItemsToolsList Tools
        {
            get => GetInstanceProperty<oci.DataOciDatabaseToolsDatabaseToolsMcpToolsets.DataOciDatabaseToolsDatabaseToolsMcpToolsetsDatabaseToolsMcpToolsetCollectionItemsToolsList>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "variables", typeJson: "{\"fqn\":\"oci.dataOciDatabaseToolsDatabaseToolsMcpToolsets.DataOciDatabaseToolsDatabaseToolsMcpToolsetsDatabaseToolsMcpToolsetCollectionItemsVariablesList\"}")]
        public virtual oci.DataOciDatabaseToolsDatabaseToolsMcpToolsets.DataOciDatabaseToolsDatabaseToolsMcpToolsetsDatabaseToolsMcpToolsetCollectionItemsVariablesList Variables
        {
            get => GetInstanceProperty<oci.DataOciDatabaseToolsDatabaseToolsMcpToolsets.DataOciDatabaseToolsDatabaseToolsMcpToolsetsDatabaseToolsMcpToolsetCollectionItemsVariablesList>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Version
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseToolsDatabaseToolsMcpToolsets.DataOciDatabaseToolsDatabaseToolsMcpToolsetsDatabaseToolsMcpToolsetCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseToolsDatabaseToolsMcpToolsets.IDataOciDatabaseToolsDatabaseToolsMcpToolsetsDatabaseToolsMcpToolsetCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseToolsDatabaseToolsMcpToolsets.IDataOciDatabaseToolsDatabaseToolsMcpToolsetsDatabaseToolsMcpToolsetCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
