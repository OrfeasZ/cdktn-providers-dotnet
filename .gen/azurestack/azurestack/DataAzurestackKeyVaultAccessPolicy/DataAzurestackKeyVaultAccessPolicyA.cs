using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DataAzurestackKeyVaultAccessPolicy
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/key_vault_access_policy azurestack_key_vault_access_policy}.</summary>
    [JsiiClass(nativeType: typeof(azurestack.DataAzurestackKeyVaultAccessPolicy.DataAzurestackKeyVaultAccessPolicyA), fullyQualifiedName: "azurestack.dataAzurestackKeyVaultAccessPolicy.DataAzurestackKeyVaultAccessPolicyA", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurestack.dataAzurestackKeyVaultAccessPolicy.DataAzurestackKeyVaultAccessPolicyAConfig\"}}]")]
    public class DataAzurestackKeyVaultAccessPolicyA : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/key_vault_access_policy azurestack_key_vault_access_policy} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurestackKeyVaultAccessPolicyA(Constructs.Construct scope, string id, azurestack.DataAzurestackKeyVaultAccessPolicy.IDataAzurestackKeyVaultAccessPolicyAConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurestack.DataAzurestackKeyVaultAccessPolicy.IDataAzurestackKeyVaultAccessPolicyAConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurestackKeyVaultAccessPolicyA(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurestackKeyVaultAccessPolicyA(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAzurestackKeyVaultAccessPolicyA resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurestackKeyVaultAccessPolicyA to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurestackKeyVaultAccessPolicyA that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurestackKeyVaultAccessPolicyA to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurestackKeyVaultAccessPolicyA to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/key_vault_access_policy#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurestackKeyVaultAccessPolicyA that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurestackKeyVaultAccessPolicyA to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurestack.DataAzurestackKeyVaultAccessPolicy.DataAzurestackKeyVaultAccessPolicyA), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.dataAzurestackKeyVaultAccessPolicy.DataAzurestackKeyVaultAccessPolicyTimeouts\"}}]")]
        public virtual void PutTimeouts(azurestack.DataAzurestackKeyVaultAccessPolicy.IDataAzurestackKeyVaultAccessPolicyTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.DataAzurestackKeyVaultAccessPolicy.IDataAzurestackKeyVaultAccessPolicyTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurestack.DataAzurestackKeyVaultAccessPolicy.DataAzurestackKeyVaultAccessPolicyA))!;

        [JsiiProperty(name: "certificatePermissions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] CertificatePermissions
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "keyPermissions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] KeyPermissions
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "secretPermissions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecretPermissions
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurestack.dataAzurestackKeyVaultAccessPolicy.DataAzurestackKeyVaultAccessPolicyTimeoutsOutputReference\"}")]
        public virtual azurestack.DataAzurestackKeyVaultAccessPolicy.DataAzurestackKeyVaultAccessPolicyTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurestack.DataAzurestackKeyVaultAccessPolicy.DataAzurestackKeyVaultAccessPolicyTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurestack.DataAzurestackKeyVaultAccessPolicy.IDataAzurestackKeyVaultAccessPolicyTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurestack.dataAzurestackKeyVaultAccessPolicy.DataAzurestackKeyVaultAccessPolicyTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
