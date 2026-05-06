using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.KmsGeneratedKey
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_generated_key oci_kms_generated_key}.</summary>
    [JsiiClass(nativeType: typeof(oci.KmsGeneratedKey.KmsGeneratedKey), fullyQualifiedName: "oci.kmsGeneratedKey.KmsGeneratedKey", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.kmsGeneratedKey.KmsGeneratedKeyConfig\"}}]")]
    public class KmsGeneratedKey : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_generated_key oci_kms_generated_key} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public KmsGeneratedKey(Constructs.Construct scope, string id, oci.KmsGeneratedKey.IKmsGeneratedKeyConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.KmsGeneratedKey.IKmsGeneratedKeyConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KmsGeneratedKey(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KmsGeneratedKey(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a KmsGeneratedKey resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the KmsGeneratedKey to import.</param>
        /// <param name="importFromId">The id of the existing KmsGeneratedKey that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the KmsGeneratedKey to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the KmsGeneratedKey to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_generated_key#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing KmsGeneratedKey that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the KmsGeneratedKey to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.KmsGeneratedKey.KmsGeneratedKey), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putKeyShape", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.kmsGeneratedKey.KmsGeneratedKeyKeyShape\"}}]")]
        public virtual void PutKeyShape(oci.KmsGeneratedKey.IKmsGeneratedKeyKeyShape @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.KmsGeneratedKey.IKmsGeneratedKeyKeyShape)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.kmsGeneratedKey.KmsGeneratedKeyTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.KmsGeneratedKey.IKmsGeneratedKeyTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.KmsGeneratedKey.IKmsGeneratedKeyTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAssociatedData")]
        public virtual void ResetAssociatedData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoggingContext")]
        public virtual void ResetLoggingContext()
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
        = GetStaticProperty<string>(typeof(oci.KmsGeneratedKey.KmsGeneratedKey))!;

        [JsiiProperty(name: "ciphertext", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ciphertext
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyShape", typeJson: "{\"fqn\":\"oci.kmsGeneratedKey.KmsGeneratedKeyKeyShapeOutputReference\"}")]
        public virtual oci.KmsGeneratedKey.KmsGeneratedKeyKeyShapeOutputReference KeyShape
        {
            get => GetInstanceProperty<oci.KmsGeneratedKey.KmsGeneratedKeyKeyShapeOutputReference>()!;
        }

        [JsiiProperty(name: "plaintext", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Plaintext
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "plaintextChecksum", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlaintextChecksum
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.kmsGeneratedKey.KmsGeneratedKeyTimeoutsOutputReference\"}")]
        public virtual oci.KmsGeneratedKey.KmsGeneratedKeyTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.KmsGeneratedKey.KmsGeneratedKeyTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "associatedDataInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? AssociatedDataInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cryptoEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CryptoEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "includePlaintextKeyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IncludePlaintextKeyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyShapeInput", typeJson: "{\"fqn\":\"oci.kmsGeneratedKey.KmsGeneratedKeyKeyShape\"}", isOptional: true)]
        public virtual oci.KmsGeneratedKey.IKmsGeneratedKeyKeyShape? KeyShapeInput
        {
            get => GetInstanceProperty<oci.KmsGeneratedKey.IKmsGeneratedKeyKeyShape?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loggingContextInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? LoggingContextInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.kmsGeneratedKey.KmsGeneratedKeyTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "associatedData", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> AssociatedData
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cryptoEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CryptoEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "includePlaintextKey", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IncludePlaintextKey
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

        [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loggingContext", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> LoggingContext
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
