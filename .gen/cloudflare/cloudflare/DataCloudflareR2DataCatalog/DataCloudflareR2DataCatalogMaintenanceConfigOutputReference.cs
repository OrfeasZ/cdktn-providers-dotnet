using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareR2DataCatalog
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareR2DataCatalog.DataCloudflareR2DataCatalogMaintenanceConfigOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareR2DataCatalog.DataCloudflareR2DataCatalogMaintenanceConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareR2DataCatalogMaintenanceConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareR2DataCatalogMaintenanceConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareR2DataCatalogMaintenanceConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareR2DataCatalogMaintenanceConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compaction", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareR2DataCatalog.DataCloudflareR2DataCatalogMaintenanceConfigCompactionOutputReference\"}")]
        public virtual cloudflare.DataCloudflareR2DataCatalog.DataCloudflareR2DataCatalogMaintenanceConfigCompactionOutputReference Compaction
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareR2DataCatalog.DataCloudflareR2DataCatalogMaintenanceConfigCompactionOutputReference>()!;
        }

        [JsiiProperty(name: "snapshotExpiration", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareR2DataCatalog.DataCloudflareR2DataCatalogMaintenanceConfigSnapshotExpirationOutputReference\"}")]
        public virtual cloudflare.DataCloudflareR2DataCatalog.DataCloudflareR2DataCatalogMaintenanceConfigSnapshotExpirationOutputReference SnapshotExpiration
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareR2DataCatalog.DataCloudflareR2DataCatalogMaintenanceConfigSnapshotExpirationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareR2DataCatalog.DataCloudflareR2DataCatalogMaintenanceConfig\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareR2DataCatalog.IDataCloudflareR2DataCatalogMaintenanceConfig? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareR2DataCatalog.IDataCloudflareR2DataCatalogMaintenanceConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
