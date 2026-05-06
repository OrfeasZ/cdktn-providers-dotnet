using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.VaultSecret
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret oci_vault_secret}.</summary>
    [JsiiClass(nativeType: typeof(oci.VaultSecret.VaultSecret), fullyQualifiedName: "oci.vaultSecret.VaultSecret", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.vaultSecret.VaultSecretConfig\"}}]")]
    public class VaultSecret : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret oci_vault_secret} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public VaultSecret(Constructs.Construct scope, string id, oci.VaultSecret.IVaultSecretConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.VaultSecret.IVaultSecretConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VaultSecret(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VaultSecret(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a VaultSecret resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the VaultSecret to import.</param>
        /// <param name="importFromId">The id of the existing VaultSecret that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the VaultSecret to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the VaultSecret to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing VaultSecret that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the VaultSecret to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.VaultSecret.VaultSecret), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putReplicationConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.vaultSecret.VaultSecretReplicationConfig\"}}]")]
        public virtual void PutReplicationConfig(oci.VaultSecret.IVaultSecretReplicationConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.VaultSecret.IVaultSecretReplicationConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRotationConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.vaultSecret.VaultSecretRotationConfig\"}}]")]
        public virtual void PutRotationConfig(oci.VaultSecret.IVaultSecretRotationConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.VaultSecret.IVaultSecretRotationConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSecretContent", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.vaultSecret.VaultSecretSecretContent\"}}]")]
        public virtual void PutSecretContent(oci.VaultSecret.IVaultSecretSecretContent @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.VaultSecret.IVaultSecretSecretContent)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSecretGenerationContext", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.vaultSecret.VaultSecretSecretGenerationContext\"}}]")]
        public virtual void PutSecretGenerationContext(oci.VaultSecret.IVaultSecretSecretGenerationContext @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.VaultSecret.IVaultSecretSecretGenerationContext)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSecretRules", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.vaultSecret.VaultSecretSecretRules\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSecretRules(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.VaultSecret.IVaultSecretSecretRules[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.VaultSecret.IVaultSecretSecretRules).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.VaultSecret.IVaultSecretSecretRules).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.vaultSecret.VaultSecretTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.VaultSecret.IVaultSecretTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.VaultSecret.IVaultSecretTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnableAutoGeneration")]
        public virtual void ResetEnableAutoGeneration()
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

        [JsiiMethod(name: "resetMetadata")]
        public virtual void ResetMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplicationConfig")]
        public virtual void ResetReplicationConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRotationConfig")]
        public virtual void ResetRotationConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecretContent")]
        public virtual void ResetSecretContent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecretGenerationContext")]
        public virtual void ResetSecretGenerationContext()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecretRules")]
        public virtual void ResetSecretRules()
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
        = GetStaticProperty<string>(typeof(oci.VaultSecret.VaultSecret))!;

        [JsiiProperty(name: "currentVersionNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurrentVersionNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isAutoGenerationEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAutoGenerationEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isReplica", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsReplica
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lastRotationTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastRotationTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nextRotationTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NextRotationTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "replicationConfig", typeJson: "{\"fqn\":\"oci.vaultSecret.VaultSecretReplicationConfigOutputReference\"}")]
        public virtual oci.VaultSecret.VaultSecretReplicationConfigOutputReference ReplicationConfig
        {
            get => GetInstanceProperty<oci.VaultSecret.VaultSecretReplicationConfigOutputReference>()!;
        }

        [JsiiProperty(name: "rotationConfig", typeJson: "{\"fqn\":\"oci.vaultSecret.VaultSecretRotationConfigOutputReference\"}")]
        public virtual oci.VaultSecret.VaultSecretRotationConfigOutputReference RotationConfig
        {
            get => GetInstanceProperty<oci.VaultSecret.VaultSecretRotationConfigOutputReference>()!;
        }

        [JsiiProperty(name: "rotationStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RotationStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secretContent", typeJson: "{\"fqn\":\"oci.vaultSecret.VaultSecretSecretContentOutputReference\"}")]
        public virtual oci.VaultSecret.VaultSecretSecretContentOutputReference SecretContent
        {
            get => GetInstanceProperty<oci.VaultSecret.VaultSecretSecretContentOutputReference>()!;
        }

        [JsiiProperty(name: "secretGenerationContext", typeJson: "{\"fqn\":\"oci.vaultSecret.VaultSecretSecretGenerationContextOutputReference\"}")]
        public virtual oci.VaultSecret.VaultSecretSecretGenerationContextOutputReference SecretGenerationContext
        {
            get => GetInstanceProperty<oci.VaultSecret.VaultSecretSecretGenerationContextOutputReference>()!;
        }

        [JsiiProperty(name: "secretRules", typeJson: "{\"fqn\":\"oci.vaultSecret.VaultSecretSecretRulesList\"}")]
        public virtual oci.VaultSecret.VaultSecretSecretRulesList SecretRules
        {
            get => GetInstanceProperty<oci.VaultSecret.VaultSecretSecretRulesList>()!;
        }

        [JsiiProperty(name: "sourceRegionInformation", typeJson: "{\"fqn\":\"oci.vaultSecret.VaultSecretSourceRegionInformationList\"}")]
        public virtual oci.VaultSecret.VaultSecretSourceRegionInformationList SourceRegionInformation
        {
            get => GetInstanceProperty<oci.VaultSecret.VaultSecretSourceRegionInformationList>()!;
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

        [JsiiProperty(name: "timeOfCurrentVersionExpiry", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfCurrentVersionExpiry
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeOfDeletion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfDeletion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.vaultSecret.VaultSecretTimeoutsOutputReference\"}")]
        public virtual oci.VaultSecret.VaultSecretTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.VaultSecret.VaultSecretTimeoutsOutputReference>()!;
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
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableAutoGenerationInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableAutoGenerationInput
        {
            get => GetInstanceProperty<object?>();
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
        [JsiiProperty(name: "keyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? MetadataInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicationConfigInput", typeJson: "{\"fqn\":\"oci.vaultSecret.VaultSecretReplicationConfig\"}", isOptional: true)]
        public virtual oci.VaultSecret.IVaultSecretReplicationConfig? ReplicationConfigInput
        {
            get => GetInstanceProperty<oci.VaultSecret.IVaultSecretReplicationConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rotationConfigInput", typeJson: "{\"fqn\":\"oci.vaultSecret.VaultSecretRotationConfig\"}", isOptional: true)]
        public virtual oci.VaultSecret.IVaultSecretRotationConfig? RotationConfigInput
        {
            get => GetInstanceProperty<oci.VaultSecret.IVaultSecretRotationConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secretContentInput", typeJson: "{\"fqn\":\"oci.vaultSecret.VaultSecretSecretContent\"}", isOptional: true)]
        public virtual oci.VaultSecret.IVaultSecretSecretContent? SecretContentInput
        {
            get => GetInstanceProperty<oci.VaultSecret.IVaultSecretSecretContent?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secretGenerationContextInput", typeJson: "{\"fqn\":\"oci.vaultSecret.VaultSecretSecretGenerationContext\"}", isOptional: true)]
        public virtual oci.VaultSecret.IVaultSecretSecretGenerationContext? SecretGenerationContextInput
        {
            get => GetInstanceProperty<oci.VaultSecret.IVaultSecretSecretGenerationContext?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secretNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecretNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secretRulesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.vaultSecret.VaultSecretSecretRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SecretRulesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.vaultSecret.VaultSecretTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enableAutoGeneration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object EnableAutoGeneration
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

        [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecretName
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
