using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedDatabase
{
    [JsiiClass(nativeType: typeof(oci.DistributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCatalogDetailsPeerDetailsDbStorageVaultDetailsOutputReference), fullyQualifiedName: "oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCatalogDetailsPeerDetailsDbStorageVaultDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DistributedDatabaseDistributedDatabaseCatalogDetailsPeerDetailsDbStorageVaultDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DistributedDatabaseDistributedDatabaseCatalogDetailsPeerDetailsDbStorageVaultDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DistributedDatabaseDistributedDatabaseCatalogDetailsPeerDetailsDbStorageVaultDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DistributedDatabaseDistributedDatabaseCatalogDetailsPeerDetailsDbStorageVaultDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAdditionalFlashCacheInPercent")]
        public virtual void ResetAdditionalFlashCacheInPercent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHighCapacityDatabaseStorage")]
        public virtual void ResetHighCapacityDatabaseStorage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "dbStorageVaultId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbStorageVaultId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "additionalFlashCacheInPercentInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AdditionalFlashCacheInPercentInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "highCapacityDatabaseStorageInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HighCapacityDatabaseStorageInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "additionalFlashCacheInPercent", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AdditionalFlashCacheInPercent
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "highCapacityDatabaseStorage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HighCapacityDatabaseStorage
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCatalogDetailsPeerDetailsDbStorageVaultDetails\"}", isOptional: true)]
        public virtual oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCatalogDetailsPeerDetailsDbStorageVaultDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCatalogDetailsPeerDetailsDbStorageVaultDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
