using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDistributedDatabaseDistributedDatabases
{
    [JsiiClass(nativeType: typeof(oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsGsmDetailsOutputReference), fullyQualifiedName: "oci.dataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsGsmDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsGsmDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsGsmDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsGsmDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsGsmDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "computeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ComputeCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dataStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataStorageSizeInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "gsmImageDetails", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsGsmDetailsGsmImageDetailsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsGsmDetailsGsmImageDetailsList GsmImageDetails
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsGsmDetailsGsmImageDetailsList>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsGsmDetailsMetadataList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsGsmDetailsMetadataList Metadata
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsGsmDetailsMetadataList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "supportingResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SupportingResourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeSslCertificateExpires", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeSslCertificateExpires
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsGsmDetails\"}", isOptional: true)]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabases.IDataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsGsmDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabases.IDataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsGsmDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
