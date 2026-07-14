using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNetappAccountEncryption
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/data-sources/netapp_account_encryption azurerm_netapp_account_encryption}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermNetappAccountEncryption.DataAzurermNetappAccountEncryption), fullyQualifiedName: "azurerm.dataAzurermNetappAccountEncryption.DataAzurermNetappAccountEncryption", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermNetappAccountEncryption.DataAzurermNetappAccountEncryptionConfig\"}}]")]
    public class DataAzurermNetappAccountEncryption : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/data-sources/netapp_account_encryption azurerm_netapp_account_encryption} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermNetappAccountEncryption(Constructs.Construct scope, string id, azurerm.DataAzurermNetappAccountEncryption.IDataAzurermNetappAccountEncryptionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermNetappAccountEncryption.IDataAzurermNetappAccountEncryptionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermNetappAccountEncryption(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermNetappAccountEncryption(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAzurermNetappAccountEncryption resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermNetappAccountEncryption to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermNetappAccountEncryption that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermNetappAccountEncryption to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermNetappAccountEncryption to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/data-sources/netapp_account_encryption#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermNetappAccountEncryption that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermNetappAccountEncryption to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.DataAzurermNetappAccountEncryption.DataAzurermNetappAccountEncryption), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermNetappAccountEncryption.DataAzurermNetappAccountEncryptionTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermNetappAccountEncryption.IDataAzurermNetappAccountEncryptionTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermNetappAccountEncryption.IDataAzurermNetappAccountEncryptionTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermNetappAccountEncryption.DataAzurermNetappAccountEncryption))!;

        [JsiiProperty(name: "crossTenantKeyVaultResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CrossTenantKeyVaultResourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "encryptionKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EncryptionKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "federatedClientId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FederatedClientId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemAssignedIdentityPrincipalId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SystemAssignedIdentityPrincipalId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermNetappAccountEncryption.DataAzurermNetappAccountEncryptionTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermNetappAccountEncryption.DataAzurermNetappAccountEncryptionTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermNetappAccountEncryption.DataAzurermNetappAccountEncryptionTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "userAssignedIdentityId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserAssignedIdentityId
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
        [JsiiProperty(name: "netappAccountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NetappAccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.DataAzurermNetappAccountEncryption.IDataAzurermNetappAccountEncryptionTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermNetappAccountEncryption.DataAzurermNetappAccountEncryptionTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "netappAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetappAccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
