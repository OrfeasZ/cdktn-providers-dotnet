using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareR2DataCatalog
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareR2DataCatalog.DataCloudflareR2DataCatalogMaintenanceConfigSnapshotExpirationOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareR2DataCatalog.DataCloudflareR2DataCatalogMaintenanceConfigSnapshotExpirationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareR2DataCatalogMaintenanceConfigSnapshotExpirationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareR2DataCatalogMaintenanceConfigSnapshotExpirationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareR2DataCatalogMaintenanceConfigSnapshotExpirationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareR2DataCatalogMaintenanceConfigSnapshotExpirationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "maxSnapshotAge", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaxSnapshotAge
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "minSnapshotsToKeep", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinSnapshotsToKeep
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareR2DataCatalog.DataCloudflareR2DataCatalogMaintenanceConfigSnapshotExpiration\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareR2DataCatalog.IDataCloudflareR2DataCatalogMaintenanceConfigSnapshotExpiration? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareR2DataCatalog.IDataCloudflareR2DataCatalogMaintenanceConfigSnapshotExpiration?>();
            set => SetInstanceProperty(value);
        }
    }
}
