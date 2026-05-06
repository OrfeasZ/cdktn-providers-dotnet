using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.KmsVaultReplication
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_vault_replication oci_kms_vault_replication}.</summary>
    [JsiiClass(nativeType: typeof(oci.KmsVaultReplication.KmsVaultReplication), fullyQualifiedName: "oci.kmsVaultReplication.KmsVaultReplication", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.kmsVaultReplication.KmsVaultReplicationConfig\"}}]")]
    public class KmsVaultReplication : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_vault_replication oci_kms_vault_replication} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public KmsVaultReplication(Constructs.Construct scope, string id, oci.KmsVaultReplication.IKmsVaultReplicationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.KmsVaultReplication.IKmsVaultReplicationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KmsVaultReplication(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KmsVaultReplication(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a KmsVaultReplication resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the KmsVaultReplication to import.</param>
        /// <param name="importFromId">The id of the existing KmsVaultReplication that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the KmsVaultReplication to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the KmsVaultReplication to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_vault_replication#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing KmsVaultReplication that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the KmsVaultReplication to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.KmsVaultReplication.KmsVaultReplication), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putReplicaVaultMetadata", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.kmsVaultReplication.KmsVaultReplicationReplicaVaultMetadata\"}}]")]
        public virtual void PutReplicaVaultMetadata(oci.KmsVaultReplication.IKmsVaultReplicationReplicaVaultMetadata @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.KmsVaultReplication.IKmsVaultReplicationReplicaVaultMetadata)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.kmsVaultReplication.KmsVaultReplicationTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.KmsVaultReplication.IKmsVaultReplicationTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.KmsVaultReplication.IKmsVaultReplicationTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplicaVaultMetadata")]
        public virtual void ResetReplicaVaultMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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
        = GetStaticProperty<string>(typeof(oci.KmsVaultReplication.KmsVaultReplication))!;

        [JsiiProperty(name: "cryptoEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CryptoEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managementEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagementEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "replicaVaultMetadata", typeJson: "{\"fqn\":\"oci.kmsVaultReplication.KmsVaultReplicationReplicaVaultMetadataOutputReference\"}")]
        public virtual oci.KmsVaultReplication.KmsVaultReplicationReplicaVaultMetadataOutputReference ReplicaVaultMetadata
        {
            get => GetInstanceProperty<oci.KmsVaultReplication.KmsVaultReplicationReplicaVaultMetadataOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.kmsVaultReplication.KmsVaultReplicationTimeoutsOutputReference\"}")]
        public virtual oci.KmsVaultReplication.KmsVaultReplicationTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.KmsVaultReplication.KmsVaultReplicationTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "vaultReplicaStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VaultReplicaStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicaRegionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReplicaRegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicaVaultMetadataInput", typeJson: "{\"fqn\":\"oci.kmsVaultReplication.KmsVaultReplicationReplicaVaultMetadata\"}", isOptional: true)]
        public virtual oci.KmsVaultReplication.IKmsVaultReplicationReplicaVaultMetadata? ReplicaVaultMetadataInput
        {
            get => GetInstanceProperty<oci.KmsVaultReplication.IKmsVaultReplicationReplicaVaultMetadata?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.kmsVaultReplication.KmsVaultReplicationTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vaultIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VaultIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replicaRegion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplicaRegion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vaultId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VaultId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
