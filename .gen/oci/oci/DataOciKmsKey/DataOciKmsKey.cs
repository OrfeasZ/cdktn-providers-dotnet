using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciKmsKey
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/kms_key oci_kms_key}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciKmsKey.DataOciKmsKey), fullyQualifiedName: "oci.dataOciKmsKey.DataOciKmsKey", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciKmsKey.DataOciKmsKeyConfig\"}}]")]
    public class DataOciKmsKey : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/kms_key oci_kms_key} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciKmsKey(Constructs.Construct scope, string id, oci.DataOciKmsKey.IDataOciKmsKeyConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciKmsKey.IDataOciKmsKeyConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciKmsKey(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciKmsKey(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciKmsKey resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciKmsKey to import.</param>
        /// <param name="importFromId">The id of the existing DataOciKmsKey that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciKmsKey to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciKmsKey to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/kms_key#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciKmsKey that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciKmsKey to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciKmsKey.DataOciKmsKey), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(oci.DataOciKmsKey.DataOciKmsKey))!;

        [JsiiProperty(name: "autoKeyRotationDetails", typeJson: "{\"fqn\":\"oci.dataOciKmsKey.DataOciKmsKeyAutoKeyRotationDetailsList\"}")]
        public virtual oci.DataOciKmsKey.DataOciKmsKeyAutoKeyRotationDetailsList AutoKeyRotationDetails
        {
            get => GetInstanceProperty<oci.DataOciKmsKey.DataOciKmsKeyAutoKeyRotationDetailsList>()!;
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

        [JsiiProperty(name: "externalKeyReference", typeJson: "{\"fqn\":\"oci.dataOciKmsKey.DataOciKmsKeyExternalKeyReferenceList\"}")]
        public virtual oci.DataOciKmsKey.DataOciKmsKeyExternalKeyReferenceList ExternalKeyReference
        {
            get => GetInstanceProperty<oci.DataOciKmsKey.DataOciKmsKeyExternalKeyReferenceList>()!;
        }

        [JsiiProperty(name: "externalKeyReferenceDetails", typeJson: "{\"fqn\":\"oci.dataOciKmsKey.DataOciKmsKeyExternalKeyReferenceDetailsList\"}")]
        public virtual oci.DataOciKmsKey.DataOciKmsKeyExternalKeyReferenceDetailsList ExternalKeyReferenceDetails
        {
            get => GetInstanceProperty<oci.DataOciKmsKey.DataOciKmsKeyExternalKeyReferenceDetailsList>()!;
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

        [JsiiProperty(name: "keyShape", typeJson: "{\"fqn\":\"oci.dataOciKmsKey.DataOciKmsKeyKeyShapeList\"}")]
        public virtual oci.DataOciKmsKey.DataOciKmsKeyKeyShapeList KeyShape
        {
            get => GetInstanceProperty<oci.DataOciKmsKey.DataOciKmsKeyKeyShapeList>()!;
        }

        [JsiiProperty(name: "protectionMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProtectionMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "replicaDetails", typeJson: "{\"fqn\":\"oci.dataOciKmsKey.DataOciKmsKeyReplicaDetailsList\"}")]
        public virtual oci.DataOciKmsKey.DataOciKmsKeyReplicaDetailsList ReplicaDetails
        {
            get => GetInstanceProperty<oci.DataOciKmsKey.DataOciKmsKeyReplicaDetailsList>()!;
        }

        [JsiiProperty(name: "restoredFromKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RestoredFromKeyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "restoreFromFile", typeJson: "{\"fqn\":\"oci.dataOciKmsKey.DataOciKmsKeyRestoreFromFileList\"}")]
        public virtual oci.DataOciKmsKey.DataOciKmsKeyRestoreFromFileList RestoreFromFile
        {
            get => GetInstanceProperty<oci.DataOciKmsKey.DataOciKmsKeyRestoreFromFileList>()!;
        }

        [JsiiProperty(name: "restoreFromObjectStore", typeJson: "{\"fqn\":\"oci.dataOciKmsKey.DataOciKmsKeyRestoreFromObjectStoreList\"}")]
        public virtual oci.DataOciKmsKey.DataOciKmsKeyRestoreFromObjectStoreList RestoreFromObjectStore
        {
            get => GetInstanceProperty<oci.DataOciKmsKey.DataOciKmsKeyRestoreFromObjectStoreList>()!;
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
        [JsiiProperty(name: "keyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managementEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ManagementEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "managementEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagementEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
