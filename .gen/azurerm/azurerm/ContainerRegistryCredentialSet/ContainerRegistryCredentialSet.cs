using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerRegistryCredentialSet
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_registry_credential_set azurerm_container_registry_credential_set}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.ContainerRegistryCredentialSet.ContainerRegistryCredentialSet), fullyQualifiedName: "azurerm.containerRegistryCredentialSet.ContainerRegistryCredentialSet", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.containerRegistryCredentialSet.ContainerRegistryCredentialSetConfig\"}}]")]
    public class ContainerRegistryCredentialSet : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_registry_credential_set azurerm_container_registry_credential_set} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ContainerRegistryCredentialSet(Constructs.Construct scope, string id, azurerm.ContainerRegistryCredentialSet.IContainerRegistryCredentialSetConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.ContainerRegistryCredentialSet.IContainerRegistryCredentialSetConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ContainerRegistryCredentialSet(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ContainerRegistryCredentialSet(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a ContainerRegistryCredentialSet resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ContainerRegistryCredentialSet to import.</param>
        /// <param name="importFromId">The id of the existing ContainerRegistryCredentialSet that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ContainerRegistryCredentialSet to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ContainerRegistryCredentialSet to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_registry_credential_set#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ContainerRegistryCredentialSet that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ContainerRegistryCredentialSet to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.ContainerRegistryCredentialSet.ContainerRegistryCredentialSet), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAuthenticationCredentials", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.containerRegistryCredentialSet.ContainerRegistryCredentialSetAuthenticationCredentials\"}}]")]
        public virtual void PutAuthenticationCredentials(azurerm.ContainerRegistryCredentialSet.IContainerRegistryCredentialSetAuthenticationCredentials @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ContainerRegistryCredentialSet.IContainerRegistryCredentialSetAuthenticationCredentials)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.containerRegistryCredentialSet.ContainerRegistryCredentialSetIdentity\"}}]")]
        public virtual void PutIdentity(azurerm.ContainerRegistryCredentialSet.IContainerRegistryCredentialSetIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ContainerRegistryCredentialSet.IContainerRegistryCredentialSetIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.containerRegistryCredentialSet.ContainerRegistryCredentialSetTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.ContainerRegistryCredentialSet.IContainerRegistryCredentialSetTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ContainerRegistryCredentialSet.IContainerRegistryCredentialSetTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.ContainerRegistryCredentialSet.ContainerRegistryCredentialSet))!;

        [JsiiProperty(name: "authenticationCredentials", typeJson: "{\"fqn\":\"azurerm.containerRegistryCredentialSet.ContainerRegistryCredentialSetAuthenticationCredentialsOutputReference\"}")]
        public virtual azurerm.ContainerRegistryCredentialSet.ContainerRegistryCredentialSetAuthenticationCredentialsOutputReference AuthenticationCredentials
        {
            get => GetInstanceProperty<azurerm.ContainerRegistryCredentialSet.ContainerRegistryCredentialSetAuthenticationCredentialsOutputReference>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.containerRegistryCredentialSet.ContainerRegistryCredentialSetIdentityOutputReference\"}")]
        public virtual azurerm.ContainerRegistryCredentialSet.ContainerRegistryCredentialSetIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurerm.ContainerRegistryCredentialSet.ContainerRegistryCredentialSetIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.containerRegistryCredentialSet.ContainerRegistryCredentialSetTimeoutsOutputReference\"}")]
        public virtual azurerm.ContainerRegistryCredentialSet.ContainerRegistryCredentialSetTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.ContainerRegistryCredentialSet.ContainerRegistryCredentialSetTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authenticationCredentialsInput", typeJson: "{\"fqn\":\"azurerm.containerRegistryCredentialSet.ContainerRegistryCredentialSetAuthenticationCredentials\"}", isOptional: true)]
        public virtual azurerm.ContainerRegistryCredentialSet.IContainerRegistryCredentialSetAuthenticationCredentials? AuthenticationCredentialsInput
        {
            get => GetInstanceProperty<azurerm.ContainerRegistryCredentialSet.IContainerRegistryCredentialSetAuthenticationCredentials?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerRegistryIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContainerRegistryIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurerm.containerRegistryCredentialSet.ContainerRegistryCredentialSetIdentity\"}", isOptional: true)]
        public virtual azurerm.ContainerRegistryCredentialSet.IContainerRegistryCredentialSetIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurerm.ContainerRegistryCredentialSet.IContainerRegistryCredentialSetIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loginServerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LoginServerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.ContainerRegistryCredentialSet.IContainerRegistryCredentialSetTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.containerRegistryCredentialSet.ContainerRegistryCredentialSetTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "containerRegistryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerRegistryId
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

        [JsiiProperty(name: "loginServer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoginServer
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
