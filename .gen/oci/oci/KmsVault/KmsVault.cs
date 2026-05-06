using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.KmsVault
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_vault oci_kms_vault}.</summary>
    [JsiiClass(nativeType: typeof(oci.KmsVault.KmsVault), fullyQualifiedName: "oci.kmsVault.KmsVault", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.kmsVault.KmsVaultConfig\"}}]")]
    public class KmsVault : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_vault oci_kms_vault} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public KmsVault(Constructs.Construct scope, string id, oci.KmsVault.IKmsVaultConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.KmsVault.IKmsVaultConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KmsVault(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KmsVault(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a KmsVault resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the KmsVault to import.</param>
        /// <param name="importFromId">The id of the existing KmsVault that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the KmsVault to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the KmsVault to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_vault#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing KmsVault that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the KmsVault to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.KmsVault.KmsVault), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putExternalKeyManagerMetadata", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.kmsVault.KmsVaultExternalKeyManagerMetadata\"}}]")]
        public virtual void PutExternalKeyManagerMetadata(oci.KmsVault.IKmsVaultExternalKeyManagerMetadata @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.KmsVault.IKmsVaultExternalKeyManagerMetadata)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRestoreFromFile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.kmsVault.KmsVaultRestoreFromFile\"}}]")]
        public virtual void PutRestoreFromFile(oci.KmsVault.IKmsVaultRestoreFromFile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.KmsVault.IKmsVaultRestoreFromFile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRestoreFromObjectStore", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.kmsVault.KmsVaultRestoreFromObjectStore\"}}]")]
        public virtual void PutRestoreFromObjectStore(oci.KmsVault.IKmsVaultRestoreFromObjectStore @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.KmsVault.IKmsVaultRestoreFromObjectStore)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.kmsVault.KmsVaultTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.KmsVault.IKmsVaultTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.KmsVault.IKmsVaultTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExternalKeyManagerMetadata")]
        public virtual void ResetExternalKeyManagerMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreeformTags")]
        public virtual void ResetFreeformTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRestoreFromFile")]
        public virtual void ResetRestoreFromFile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRestoreFromObjectStore")]
        public virtual void ResetRestoreFromObjectStore()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRestoreTrigger")]
        public virtual void ResetRestoreTrigger()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeOfDeletion")]
        public virtual void ResetTimeOfDeletion()
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
        = GetStaticProperty<string>(typeof(oci.KmsVault.KmsVault))!;

        [JsiiProperty(name: "cryptoEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CryptoEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "externalKeyManagerMetadata", typeJson: "{\"fqn\":\"oci.kmsVault.KmsVaultExternalKeyManagerMetadataOutputReference\"}")]
        public virtual oci.KmsVault.KmsVaultExternalKeyManagerMetadataOutputReference ExternalKeyManagerMetadata
        {
            get => GetInstanceProperty<oci.KmsVault.KmsVaultExternalKeyManagerMetadataOutputReference>()!;
        }

        [JsiiProperty(name: "externalKeyManagerMetadataSummary", typeJson: "{\"fqn\":\"oci.kmsVault.KmsVaultExternalKeyManagerMetadataSummaryList\"}")]
        public virtual oci.KmsVault.KmsVaultExternalKeyManagerMetadataSummaryList ExternalKeyManagerMetadataSummary
        {
            get => GetInstanceProperty<oci.KmsVault.KmsVaultExternalKeyManagerMetadataSummaryList>()!;
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

        [JsiiProperty(name: "replicaDetails", typeJson: "{\"fqn\":\"oci.kmsVault.KmsVaultReplicaDetailsList\"}")]
        public virtual oci.KmsVault.KmsVaultReplicaDetailsList ReplicaDetails
        {
            get => GetInstanceProperty<oci.KmsVault.KmsVaultReplicaDetailsList>()!;
        }

        [JsiiProperty(name: "restoredFromVaultId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RestoredFromVaultId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "restoreFromFile", typeJson: "{\"fqn\":\"oci.kmsVault.KmsVaultRestoreFromFileOutputReference\"}")]
        public virtual oci.KmsVault.KmsVaultRestoreFromFileOutputReference RestoreFromFile
        {
            get => GetInstanceProperty<oci.KmsVault.KmsVaultRestoreFromFileOutputReference>()!;
        }

        [JsiiProperty(name: "restoreFromObjectStore", typeJson: "{\"fqn\":\"oci.kmsVault.KmsVaultRestoreFromObjectStoreOutputReference\"}")]
        public virtual oci.KmsVault.KmsVaultRestoreFromObjectStoreOutputReference RestoreFromObjectStore
        {
            get => GetInstanceProperty<oci.KmsVault.KmsVaultRestoreFromObjectStoreOutputReference>()!;
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

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.kmsVault.KmsVaultTimeoutsOutputReference\"}")]
        public virtual oci.KmsVault.KmsVaultTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.KmsVault.KmsVaultTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "externalKeyManagerMetadataInput", typeJson: "{\"fqn\":\"oci.kmsVault.KmsVaultExternalKeyManagerMetadata\"}", isOptional: true)]
        public virtual oci.KmsVault.IKmsVaultExternalKeyManagerMetadata? ExternalKeyManagerMetadataInput
        {
            get => GetInstanceProperty<oci.KmsVault.IKmsVaultExternalKeyManagerMetadata?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? FreeformTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "restoreFromFileInput", typeJson: "{\"fqn\":\"oci.kmsVault.KmsVaultRestoreFromFile\"}", isOptional: true)]
        public virtual oci.KmsVault.IKmsVaultRestoreFromFile? RestoreFromFileInput
        {
            get => GetInstanceProperty<oci.KmsVault.IKmsVaultRestoreFromFile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "restoreFromObjectStoreInput", typeJson: "{\"fqn\":\"oci.kmsVault.KmsVaultRestoreFromObjectStore\"}", isOptional: true)]
        public virtual oci.KmsVault.IKmsVaultRestoreFromObjectStore? RestoreFromObjectStoreInput
        {
            get => GetInstanceProperty<oci.KmsVault.IKmsVaultRestoreFromObjectStore?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "restoreTriggerInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? RestoreTriggerInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeOfDeletionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeOfDeletionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.kmsVault.KmsVaultTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vaultTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VaultTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> DefinedTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> FreeformTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "restoreTrigger", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object RestoreTrigger
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "timeOfDeletion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfDeletion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vaultType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VaultType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
