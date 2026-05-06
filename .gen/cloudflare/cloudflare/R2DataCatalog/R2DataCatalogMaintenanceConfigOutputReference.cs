using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.R2DataCatalog
{
    [JsiiClass(nativeType: typeof(cloudflare.R2DataCatalog.R2DataCatalogMaintenanceConfigOutputReference), fullyQualifiedName: "cloudflare.r2DataCatalog.R2DataCatalogMaintenanceConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class R2DataCatalogMaintenanceConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public R2DataCatalogMaintenanceConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected R2DataCatalogMaintenanceConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected R2DataCatalogMaintenanceConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compaction", typeJson: "{\"fqn\":\"cloudflare.r2DataCatalog.R2DataCatalogMaintenanceConfigCompactionOutputReference\"}")]
        public virtual cloudflare.R2DataCatalog.R2DataCatalogMaintenanceConfigCompactionOutputReference Compaction
        {
            get => GetInstanceProperty<cloudflare.R2DataCatalog.R2DataCatalogMaintenanceConfigCompactionOutputReference>()!;
        }

        [JsiiProperty(name: "snapshotExpiration", typeJson: "{\"fqn\":\"cloudflare.r2DataCatalog.R2DataCatalogMaintenanceConfigSnapshotExpirationOutputReference\"}")]
        public virtual cloudflare.R2DataCatalog.R2DataCatalogMaintenanceConfigSnapshotExpirationOutputReference SnapshotExpiration
        {
            get => GetInstanceProperty<cloudflare.R2DataCatalog.R2DataCatalogMaintenanceConfigSnapshotExpirationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.r2DataCatalog.R2DataCatalogMaintenanceConfig\"}", isOptional: true)]
        public virtual cloudflare.R2DataCatalog.IR2DataCatalogMaintenanceConfig? InternalValue
        {
            get => GetInstanceProperty<cloudflare.R2DataCatalog.IR2DataCatalogMaintenanceConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
