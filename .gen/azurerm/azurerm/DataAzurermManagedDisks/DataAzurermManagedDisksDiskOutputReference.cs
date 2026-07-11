using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermManagedDisks
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermManagedDisks.DataAzurermManagedDisksDiskOutputReference), fullyQualifiedName: "azurerm.dataAzurermManagedDisks.DataAzurermManagedDisksDiskOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermManagedDisksDiskOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermManagedDisksDiskOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermManagedDisksDiskOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermManagedDisksDiskOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "createOption", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreateOption
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "diskAccessId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DiskAccessId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "diskEncryptionSetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DiskEncryptionSetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "diskIopsReadWrite", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DiskIopsReadWrite
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "diskMbpsReadWrite", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DiskMbpsReadWrite
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "diskSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DiskSizeInGb
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "encryptionSettings", typeJson: "{\"fqn\":\"azurerm.dataAzurermManagedDisks.DataAzurermManagedDisksDiskEncryptionSettingsList\"}")]
        public virtual azurerm.DataAzurermManagedDisks.DataAzurermManagedDisksDiskEncryptionSettingsList EncryptionSettings
        {
            get => GetInstanceProperty<azurerm.DataAzurermManagedDisks.DataAzurermManagedDisksDiskEncryptionSettingsList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "imageReferenceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageReferenceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkAccessPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkAccessPolicy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "osType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OsType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceResourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceUri
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageAccountId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageAccountType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageAccountType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Tags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "zones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Zones
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermManagedDisks.DataAzurermManagedDisksDisk\"}", isOptional: true)]
        public virtual azurerm.DataAzurermManagedDisks.IDataAzurermManagedDisksDisk? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermManagedDisks.IDataAzurermManagedDisksDisk?>();
            set => SetInstanceProperty(value);
        }
    }
}
