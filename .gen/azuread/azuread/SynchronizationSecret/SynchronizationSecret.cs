using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.SynchronizationSecret
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/synchronization_secret azuread_synchronization_secret}.</summary>
    [JsiiClass(nativeType: typeof(azuread.SynchronizationSecret.SynchronizationSecret), fullyQualifiedName: "azuread.synchronizationSecret.SynchronizationSecret", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azuread.synchronizationSecret.SynchronizationSecretConfig\"}}]")]
    public class SynchronizationSecret : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/synchronization_secret azuread_synchronization_secret} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SynchronizationSecret(Constructs.Construct scope, string id, azuread.SynchronizationSecret.ISynchronizationSecretConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azuread.SynchronizationSecret.ISynchronizationSecretConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SynchronizationSecret(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SynchronizationSecret(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a SynchronizationSecret resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the SynchronizationSecret to import.</param>
        /// <param name="importFromId">The id of the existing SynchronizationSecret that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the SynchronizationSecret to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the SynchronizationSecret to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/synchronization_secret#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing SynchronizationSecret that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the SynchronizationSecret to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azuread.SynchronizationSecret.SynchronizationSecret), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.SynchronizationSecret.ISynchronizationSecretCredential" />)[]</param>
        [JsiiMethod(name: "putCredential", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.synchronizationSecret.SynchronizationSecretCredential\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCredential(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azuread.SynchronizationSecret.ISynchronizationSecretCredential[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.SynchronizationSecret.ISynchronizationSecretCredential).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.SynchronizationSecret.ISynchronizationSecretCredential).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.synchronizationSecret.SynchronizationSecretTimeouts\"}}]")]
        public virtual void PutTimeouts(azuread.SynchronizationSecret.ISynchronizationSecretTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.SynchronizationSecret.ISynchronizationSecretTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCredential")]
        public virtual void ResetCredential()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(azuread.SynchronizationSecret.SynchronizationSecret))!;

        [JsiiProperty(name: "credential", typeJson: "{\"fqn\":\"azuread.synchronizationSecret.SynchronizationSecretCredentialList\"}")]
        public virtual azuread.SynchronizationSecret.SynchronizationSecretCredentialList Credential
        {
            get => GetInstanceProperty<azuread.SynchronizationSecret.SynchronizationSecretCredentialList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.synchronizationSecret.SynchronizationSecretTimeoutsOutputReference\"}")]
        public virtual azuread.SynchronizationSecret.SynchronizationSecretTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azuread.SynchronizationSecret.SynchronizationSecretTimeoutsOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.SynchronizationSecret.ISynchronizationSecretCredential" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "credentialInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.synchronizationSecret.SynchronizationSecretCredential\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CredentialInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "servicePrincipalIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServicePrincipalIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azuread.SynchronizationSecret.ISynchronizationSecretTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azuread.synchronizationSecret.SynchronizationSecretTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "servicePrincipalId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServicePrincipalId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
