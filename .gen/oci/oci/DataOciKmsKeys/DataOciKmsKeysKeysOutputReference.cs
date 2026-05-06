using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciKmsKeys
{
    [JsiiClass(nativeType: typeof(oci.DataOciKmsKeys.DataOciKmsKeysKeysOutputReference), fullyQualifiedName: "oci.dataOciKmsKeys.DataOciKmsKeysKeysOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciKmsKeysKeysOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciKmsKeysKeysOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciKmsKeysKeysOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciKmsKeysKeysOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "autoKeyRotationDetails", typeJson: "{\"fqn\":\"oci.dataOciKmsKeys.DataOciKmsKeysKeysAutoKeyRotationDetailsList\"}")]
        public virtual oci.DataOciKmsKeys.DataOciKmsKeysKeysAutoKeyRotationDetailsList AutoKeyRotationDetails
        {
            get => GetInstanceProperty<oci.DataOciKmsKeys.DataOciKmsKeysKeysAutoKeyRotationDetailsList>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "currentKeyVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurrentKeyVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "desiredState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DesiredState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "externalKeyReference", typeJson: "{\"fqn\":\"oci.dataOciKmsKeys.DataOciKmsKeysKeysExternalKeyReferenceList\"}")]
        public virtual oci.DataOciKmsKeys.DataOciKmsKeysKeysExternalKeyReferenceList ExternalKeyReference
        {
            get => GetInstanceProperty<oci.DataOciKmsKeys.DataOciKmsKeysKeysExternalKeyReferenceList>()!;
        }

        [JsiiProperty(name: "externalKeyReferenceDetails", typeJson: "{\"fqn\":\"oci.dataOciKmsKeys.DataOciKmsKeysKeysExternalKeyReferenceDetailsList\"}")]
        public virtual oci.DataOciKmsKeys.DataOciKmsKeysKeysExternalKeyReferenceDetailsList ExternalKeyReferenceDetails
        {
            get => GetInstanceProperty<oci.DataOciKmsKeys.DataOciKmsKeysKeysExternalKeyReferenceDetailsList>()!;
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

        [JsiiProperty(name: "isAutoRotationEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAutoRotationEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isPrimary", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsPrimary
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "keyShape", typeJson: "{\"fqn\":\"oci.dataOciKmsKeys.DataOciKmsKeysKeysKeyShapeList\"}")]
        public virtual oci.DataOciKmsKeys.DataOciKmsKeysKeysKeyShapeList KeyShape
        {
            get => GetInstanceProperty<oci.DataOciKmsKeys.DataOciKmsKeysKeysKeyShapeList>()!;
        }

        [JsiiProperty(name: "managementEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagementEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "protectionMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProtectionMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "replicaDetails", typeJson: "{\"fqn\":\"oci.dataOciKmsKeys.DataOciKmsKeysKeysReplicaDetailsList\"}")]
        public virtual oci.DataOciKmsKeys.DataOciKmsKeysKeysReplicaDetailsList ReplicaDetails
        {
            get => GetInstanceProperty<oci.DataOciKmsKeys.DataOciKmsKeysKeysReplicaDetailsList>()!;
        }

        [JsiiProperty(name: "restoredFromKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RestoredFromKeyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "restoreFromFile", typeJson: "{\"fqn\":\"oci.dataOciKmsKeys.DataOciKmsKeysKeysRestoreFromFileList\"}")]
        public virtual oci.DataOciKmsKeys.DataOciKmsKeysKeysRestoreFromFileList RestoreFromFile
        {
            get => GetInstanceProperty<oci.DataOciKmsKeys.DataOciKmsKeysKeysRestoreFromFileList>()!;
        }

        [JsiiProperty(name: "restoreFromObjectStore", typeJson: "{\"fqn\":\"oci.dataOciKmsKeys.DataOciKmsKeysKeysRestoreFromObjectStoreList\"}")]
        public virtual oci.DataOciKmsKeys.DataOciKmsKeysKeysRestoreFromObjectStoreList RestoreFromObjectStore
        {
            get => GetInstanceProperty<oci.DataOciKmsKeys.DataOciKmsKeysKeysRestoreFromObjectStoreList>()!;
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

        [JsiiProperty(name: "vaultId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VaultId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciKmsKeys.DataOciKmsKeysKeys\"}", isOptional: true)]
        public virtual oci.DataOciKmsKeys.IDataOciKmsKeysKeys? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciKmsKeys.IDataOciKmsKeysKeys?>();
            set => SetInstanceProperty(value);
        }
    }
}
