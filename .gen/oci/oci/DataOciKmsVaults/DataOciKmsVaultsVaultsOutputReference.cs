using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciKmsVaults
{
    [JsiiClass(nativeType: typeof(oci.DataOciKmsVaults.DataOciKmsVaultsVaultsOutputReference), fullyQualifiedName: "oci.dataOciKmsVaults.DataOciKmsVaultsVaultsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciKmsVaultsVaultsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciKmsVaultsVaultsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciKmsVaultsVaultsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciKmsVaultsVaultsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cryptoEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CryptoEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "externalKeyManagerMetadata", typeJson: "{\"fqn\":\"oci.dataOciKmsVaults.DataOciKmsVaultsVaultsExternalKeyManagerMetadataList\"}")]
        public virtual oci.DataOciKmsVaults.DataOciKmsVaultsVaultsExternalKeyManagerMetadataList ExternalKeyManagerMetadata
        {
            get => GetInstanceProperty<oci.DataOciKmsVaults.DataOciKmsVaultsVaultsExternalKeyManagerMetadataList>()!;
        }

        [JsiiProperty(name: "externalKeyManagerMetadataSummary", typeJson: "{\"fqn\":\"oci.dataOciKmsVaults.DataOciKmsVaultsVaultsExternalKeyManagerMetadataSummaryList\"}")]
        public virtual oci.DataOciKmsVaults.DataOciKmsVaultsVaultsExternalKeyManagerMetadataSummaryList ExternalKeyManagerMetadataSummary
        {
            get => GetInstanceProperty<oci.DataOciKmsVaults.DataOciKmsVaultsVaultsExternalKeyManagerMetadataSummaryList>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isPrimary", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsPrimary
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isVaultReplicable", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsVaultReplicable
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "managementEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagementEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "replicaDetails", typeJson: "{\"fqn\":\"oci.dataOciKmsVaults.DataOciKmsVaultsVaultsReplicaDetailsList\"}")]
        public virtual oci.DataOciKmsVaults.DataOciKmsVaultsVaultsReplicaDetailsList ReplicaDetails
        {
            get => GetInstanceProperty<oci.DataOciKmsVaults.DataOciKmsVaultsVaultsReplicaDetailsList>()!;
        }

        [JsiiProperty(name: "restoredFromVaultId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RestoredFromVaultId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "restoreFromFile", typeJson: "{\"fqn\":\"oci.dataOciKmsVaults.DataOciKmsVaultsVaultsRestoreFromFileList\"}")]
        public virtual oci.DataOciKmsVaults.DataOciKmsVaultsVaultsRestoreFromFileList RestoreFromFile
        {
            get => GetInstanceProperty<oci.DataOciKmsVaults.DataOciKmsVaultsVaultsRestoreFromFileList>()!;
        }

        [JsiiProperty(name: "restoreFromObjectStore", typeJson: "{\"fqn\":\"oci.dataOciKmsVaults.DataOciKmsVaultsVaultsRestoreFromObjectStoreList\"}")]
        public virtual oci.DataOciKmsVaults.DataOciKmsVaultsVaultsRestoreFromObjectStoreList RestoreFromObjectStore
        {
            get => GetInstanceProperty<oci.DataOciKmsVaults.DataOciKmsVaultsVaultsRestoreFromObjectStoreList>()!;
        }

        [JsiiProperty(name: "restoreTrigger", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable RestoreTrigger
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeOfDeletion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfDeletion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vaultType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VaultType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciKmsVaults.DataOciKmsVaultsVaults\"}", isOptional: true)]
        public virtual oci.DataOciKmsVaults.IDataOciKmsVaultsVaults? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciKmsVaults.IDataOciKmsVaultsVaults?>();
            set => SetInstanceProperty(value);
        }
    }
}
