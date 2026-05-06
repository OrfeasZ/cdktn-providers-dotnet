using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFleetAppsManagementCatalogItem
{
    [JsiiClass(nativeType: typeof(oci.DataOciFleetAppsManagementCatalogItem.DataOciFleetAppsManagementCatalogItemCatalogSourcePayloadOutputReference), fullyQualifiedName: "oci.dataOciFleetAppsManagementCatalogItem.DataOciFleetAppsManagementCatalogItemCatalogSourcePayloadOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciFleetAppsManagementCatalogItemCatalogSourcePayloadOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciFleetAppsManagementCatalogItemCatalogSourcePayloadOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciFleetAppsManagementCatalogItemCatalogSourcePayloadOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFleetAppsManagementCatalogItemCatalogSourcePayloadOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accessUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessUri
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "branchName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BranchName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bucket
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configSourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigSourceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configurationSourceProviderId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigurationSourceProviderId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "listingId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ListingId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "longDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LongDescription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Namespace
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Object
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "repositoryUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RepositoryUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "templateDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TemplateDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeExpires", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeExpires
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "workingDirectory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkingDirectory
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "zipFileBase64Encoded", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ZipFileBase64Encoded
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementCatalogItem.DataOciFleetAppsManagementCatalogItemCatalogSourcePayload\"}", isOptional: true)]
        public virtual oci.DataOciFleetAppsManagementCatalogItem.IDataOciFleetAppsManagementCatalogItemCatalogSourcePayload? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementCatalogItem.IDataOciFleetAppsManagementCatalogItemCatalogSourcePayload?>();
            set => SetInstanceProperty(value);
        }
    }
}
