using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.KmsKey
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_key oci_kms_key}.</summary>
    [JsiiClass(nativeType: typeof(oci.KmsKey.KmsKey), fullyQualifiedName: "oci.kmsKey.KmsKey", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.kmsKey.KmsKeyConfig\"}}]")]
    public class KmsKey : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_key oci_kms_key} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public KmsKey(Constructs.Construct scope, string id, oci.KmsKey.IKmsKeyConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.KmsKey.IKmsKeyConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KmsKey(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KmsKey(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a KmsKey resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the KmsKey to import.</param>
        /// <param name="importFromId">The id of the existing KmsKey that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the KmsKey to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the KmsKey to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_key#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing KmsKey that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the KmsKey to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.KmsKey.KmsKey), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAutoKeyRotationDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.kmsKey.KmsKeyAutoKeyRotationDetails\"}}]")]
        public virtual void PutAutoKeyRotationDetails(oci.KmsKey.IKmsKeyAutoKeyRotationDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.KmsKey.IKmsKeyAutoKeyRotationDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExternalKeyReference", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.kmsKey.KmsKeyExternalKeyReference\"}}]")]
        public virtual void PutExternalKeyReference(oci.KmsKey.IKmsKeyExternalKeyReference @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.KmsKey.IKmsKeyExternalKeyReference)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKeyShape", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.kmsKey.KmsKeyKeyShape\"}}]")]
        public virtual void PutKeyShape(oci.KmsKey.IKmsKeyKeyShape @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.KmsKey.IKmsKeyKeyShape)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRestoreFromFile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.kmsKey.KmsKeyRestoreFromFile\"}}]")]
        public virtual void PutRestoreFromFile(oci.KmsKey.IKmsKeyRestoreFromFile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.KmsKey.IKmsKeyRestoreFromFile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRestoreFromObjectStore", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.kmsKey.KmsKeyRestoreFromObjectStore\"}}]")]
        public virtual void PutRestoreFromObjectStore(oci.KmsKey.IKmsKeyRestoreFromObjectStore @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.KmsKey.IKmsKeyRestoreFromObjectStore)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.kmsKey.KmsKeyTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.KmsKey.IKmsKeyTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.KmsKey.IKmsKeyTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAutoKeyRotationDetails")]
        public virtual void ResetAutoKeyRotationDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDesiredState")]
        public virtual void ResetDesiredState()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExternalKeyReference")]
        public virtual void ResetExternalKeyReference()
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

        [JsiiMethod(name: "resetIsAutoRotationEnabled")]
        public virtual void ResetIsAutoRotationEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProtectionMode")]
        public virtual void ResetProtectionMode()
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
        = GetStaticProperty<string>(typeof(oci.KmsKey.KmsKey))!;

        [JsiiProperty(name: "autoKeyRotationDetails", typeJson: "{\"fqn\":\"oci.kmsKey.KmsKeyAutoKeyRotationDetailsOutputReference\"}")]
        public virtual oci.KmsKey.KmsKeyAutoKeyRotationDetailsOutputReference AutoKeyRotationDetails
        {
            get => GetInstanceProperty<oci.KmsKey.KmsKeyAutoKeyRotationDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "currentKeyVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurrentKeyVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "externalKeyReference", typeJson: "{\"fqn\":\"oci.kmsKey.KmsKeyExternalKeyReferenceOutputReference\"}")]
        public virtual oci.KmsKey.KmsKeyExternalKeyReferenceOutputReference ExternalKeyReference
        {
            get => GetInstanceProperty<oci.KmsKey.KmsKeyExternalKeyReferenceOutputReference>()!;
        }

        [JsiiProperty(name: "externalKeyReferenceDetails", typeJson: "{\"fqn\":\"oci.kmsKey.KmsKeyExternalKeyReferenceDetailsList\"}")]
        public virtual oci.KmsKey.KmsKeyExternalKeyReferenceDetailsList ExternalKeyReferenceDetails
        {
            get => GetInstanceProperty<oci.KmsKey.KmsKeyExternalKeyReferenceDetailsList>()!;
        }

        [JsiiProperty(name: "isPrimary", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsPrimary
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "keyShape", typeJson: "{\"fqn\":\"oci.kmsKey.KmsKeyKeyShapeOutputReference\"}")]
        public virtual oci.KmsKey.KmsKeyKeyShapeOutputReference KeyShape
        {
            get => GetInstanceProperty<oci.KmsKey.KmsKeyKeyShapeOutputReference>()!;
        }

        [JsiiProperty(name: "replicaDetails", typeJson: "{\"fqn\":\"oci.kmsKey.KmsKeyReplicaDetailsList\"}")]
        public virtual oci.KmsKey.KmsKeyReplicaDetailsList ReplicaDetails
        {
            get => GetInstanceProperty<oci.KmsKey.KmsKeyReplicaDetailsList>()!;
        }

        [JsiiProperty(name: "restoredFromKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RestoredFromKeyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "restoreFromFile", typeJson: "{\"fqn\":\"oci.kmsKey.KmsKeyRestoreFromFileOutputReference\"}")]
        public virtual oci.KmsKey.KmsKeyRestoreFromFileOutputReference RestoreFromFile
        {
            get => GetInstanceProperty<oci.KmsKey.KmsKeyRestoreFromFileOutputReference>()!;
        }

        [JsiiProperty(name: "restoreFromObjectStore", typeJson: "{\"fqn\":\"oci.kmsKey.KmsKeyRestoreFromObjectStoreOutputReference\"}")]
        public virtual oci.KmsKey.KmsKeyRestoreFromObjectStoreOutputReference RestoreFromObjectStore
        {
            get => GetInstanceProperty<oci.KmsKey.KmsKeyRestoreFromObjectStoreOutputReference>()!;
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

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.kmsKey.KmsKeyTimeoutsOutputReference\"}")]
        public virtual oci.KmsKey.KmsKeyTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.KmsKey.KmsKeyTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "vaultId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VaultId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoKeyRotationDetailsInput", typeJson: "{\"fqn\":\"oci.kmsKey.KmsKeyAutoKeyRotationDetails\"}", isOptional: true)]
        public virtual oci.KmsKey.IKmsKeyAutoKeyRotationDetails? AutoKeyRotationDetailsInput
        {
            get => GetInstanceProperty<oci.KmsKey.IKmsKeyAutoKeyRotationDetails?>();
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
        [JsiiProperty(name: "desiredStateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DesiredStateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "externalKeyReferenceInput", typeJson: "{\"fqn\":\"oci.kmsKey.KmsKeyExternalKeyReference\"}", isOptional: true)]
        public virtual oci.KmsKey.IKmsKeyExternalKeyReference? ExternalKeyReferenceInput
        {
            get => GetInstanceProperty<oci.KmsKey.IKmsKeyExternalKeyReference?>();
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
        [JsiiProperty(name: "isAutoRotationEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsAutoRotationEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyShapeInput", typeJson: "{\"fqn\":\"oci.kmsKey.KmsKeyKeyShape\"}", isOptional: true)]
        public virtual oci.KmsKey.IKmsKeyKeyShape? KeyShapeInput
        {
            get => GetInstanceProperty<oci.KmsKey.IKmsKeyKeyShape?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managementEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ManagementEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protectionModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProtectionModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "restoreFromFileInput", typeJson: "{\"fqn\":\"oci.kmsKey.KmsKeyRestoreFromFile\"}", isOptional: true)]
        public virtual oci.KmsKey.IKmsKeyRestoreFromFile? RestoreFromFileInput
        {
            get => GetInstanceProperty<oci.KmsKey.IKmsKeyRestoreFromFile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "restoreFromObjectStoreInput", typeJson: "{\"fqn\":\"oci.kmsKey.KmsKeyRestoreFromObjectStore\"}", isOptional: true)]
        public virtual oci.KmsKey.IKmsKeyRestoreFromObjectStore? RestoreFromObjectStoreInput
        {
            get => GetInstanceProperty<oci.KmsKey.IKmsKeyRestoreFromObjectStore?>();
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.kmsKey.KmsKeyTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
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

        [JsiiProperty(name: "desiredState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DesiredState
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "isAutoRotationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsAutoRotationEnabled
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

        [JsiiProperty(name: "managementEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagementEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "protectionMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProtectionMode
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
    }
}
