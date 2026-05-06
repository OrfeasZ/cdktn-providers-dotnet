using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDblmPatchManagementDatabases
{
    [JsiiClass(nativeType: typeof(oci.DataOciDblmPatchManagementDatabases.DataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDblmPatchManagementDatabases.DataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "additionalPatches", typeJson: "{\"fqn\":\"oci.dataOciDblmPatchManagementDatabases.DataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItemsAdditionalPatchesList\"}")]
        public virtual oci.DataOciDblmPatchManagementDatabases.DataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItemsAdditionalPatchesList AdditionalPatches
        {
            get => GetInstanceProperty<oci.DataOciDblmPatchManagementDatabases.DataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItemsAdditionalPatchesList>()!;
        }

        [JsiiProperty(name: "currentPatchWatermark", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurrentPatchWatermark
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "hostOrCluster", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostOrCluster
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "imageDetails", typeJson: "{\"fqn\":\"oci.dataOciDblmPatchManagementDatabases.DataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItemsImageDetailsList\"}")]
        public virtual oci.DataOciDblmPatchManagementDatabases.DataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItemsImageDetailsList ImageDetails
        {
            get => GetInstanceProperty<oci.DataOciDblmPatchManagementDatabases.DataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItemsImageDetailsList>()!;
        }

        [JsiiProperty(name: "oracleHomePath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OracleHomePath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "patchActivityDetails", typeJson: "{\"fqn\":\"oci.dataOciDblmPatchManagementDatabases.DataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItemsPatchActivityDetailsList\"}")]
        public virtual oci.DataOciDblmPatchManagementDatabases.DataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItemsPatchActivityDetailsList PatchActivityDetails
        {
            get => GetInstanceProperty<oci.DataOciDblmPatchManagementDatabases.DataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItemsPatchActivityDetailsList>()!;
        }

        [JsiiProperty(name: "patchComplianceDetails", typeJson: "{\"fqn\":\"oci.dataOciDblmPatchManagementDatabases.DataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItemsPatchComplianceDetailsList\"}")]
        public virtual oci.DataOciDblmPatchManagementDatabases.DataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItemsPatchComplianceDetailsList PatchComplianceDetails
        {
            get => GetInstanceProperty<oci.DataOciDblmPatchManagementDatabases.DataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItemsPatchComplianceDetailsList>()!;
        }

        [JsiiProperty(name: "patchUser", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PatchUser
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "release", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Release
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "releaseFullVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReleaseFullVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sudoFilePath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SudoFilePath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "vulnerabilitiesSummary", typeJson: "{\"fqn\":\"oci.dataOciDblmPatchManagementDatabases.DataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItemsVulnerabilitiesSummaryList\"}")]
        public virtual oci.DataOciDblmPatchManagementDatabases.DataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItemsVulnerabilitiesSummaryList VulnerabilitiesSummary
        {
            get => GetInstanceProperty<oci.DataOciDblmPatchManagementDatabases.DataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItemsVulnerabilitiesSummaryList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDblmPatchManagementDatabases.DataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDblmPatchManagementDatabases.IDataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDblmPatchManagementDatabases.IDataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
