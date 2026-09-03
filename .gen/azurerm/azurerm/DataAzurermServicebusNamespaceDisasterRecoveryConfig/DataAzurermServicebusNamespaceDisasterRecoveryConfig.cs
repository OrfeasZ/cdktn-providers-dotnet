using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermServicebusNamespaceDisasterRecoveryConfig
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/servicebus_namespace_disaster_recovery_config azurerm_servicebus_namespace_disaster_recovery_config}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermServicebusNamespaceDisasterRecoveryConfig.DataAzurermServicebusNamespaceDisasterRecoveryConfig), fullyQualifiedName: "azurerm.dataAzurermServicebusNamespaceDisasterRecoveryConfig.DataAzurermServicebusNamespaceDisasterRecoveryConfig", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermServicebusNamespaceDisasterRecoveryConfig.DataAzurermServicebusNamespaceDisasterRecoveryConfigConfig\"}}]")]
    public class DataAzurermServicebusNamespaceDisasterRecoveryConfig : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/servicebus_namespace_disaster_recovery_config azurerm_servicebus_namespace_disaster_recovery_config} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermServicebusNamespaceDisasterRecoveryConfig(Constructs.Construct scope, string id, azurerm.DataAzurermServicebusNamespaceDisasterRecoveryConfig.IDataAzurermServicebusNamespaceDisasterRecoveryConfigConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermServicebusNamespaceDisasterRecoveryConfig.IDataAzurermServicebusNamespaceDisasterRecoveryConfigConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermServicebusNamespaceDisasterRecoveryConfig(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermServicebusNamespaceDisasterRecoveryConfig(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAzurermServicebusNamespaceDisasterRecoveryConfig resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermServicebusNamespaceDisasterRecoveryConfig to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermServicebusNamespaceDisasterRecoveryConfig that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermServicebusNamespaceDisasterRecoveryConfig to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermServicebusNamespaceDisasterRecoveryConfig to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/servicebus_namespace_disaster_recovery_config#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermServicebusNamespaceDisasterRecoveryConfig that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermServicebusNamespaceDisasterRecoveryConfig to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.DataAzurermServicebusNamespaceDisasterRecoveryConfig.DataAzurermServicebusNamespaceDisasterRecoveryConfig), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermServicebusNamespaceDisasterRecoveryConfig.DataAzurermServicebusNamespaceDisasterRecoveryConfigTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermServicebusNamespaceDisasterRecoveryConfig.IDataAzurermServicebusNamespaceDisasterRecoveryConfigTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermServicebusNamespaceDisasterRecoveryConfig.IDataAzurermServicebusNamespaceDisasterRecoveryConfigTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAliasAuthorizationRuleId")]
        public virtual void ResetAliasAuthorizationRuleId()
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
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermServicebusNamespaceDisasterRecoveryConfig.DataAzurermServicebusNamespaceDisasterRecoveryConfig))!;

        [JsiiProperty(name: "defaultPrimaryKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultPrimaryKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultSecondaryKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultSecondaryKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "partnerNamespaceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PartnerNamespaceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryConnectionStringAlias", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryConnectionStringAlias
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryConnectionStringAlias", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryConnectionStringAlias
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermServicebusNamespaceDisasterRecoveryConfig.DataAzurermServicebusNamespaceDisasterRecoveryConfigTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermServicebusNamespaceDisasterRecoveryConfig.DataAzurermServicebusNamespaceDisasterRecoveryConfigTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermServicebusNamespaceDisasterRecoveryConfig.DataAzurermServicebusNamespaceDisasterRecoveryConfigTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "aliasAuthorizationRuleIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AliasAuthorizationRuleIdInput
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
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "namespaceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamespaceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.DataAzurermServicebusNamespaceDisasterRecoveryConfig.IDataAzurermServicebusNamespaceDisasterRecoveryConfigTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermServicebusNamespaceDisasterRecoveryConfig.DataAzurermServicebusNamespaceDisasterRecoveryConfigTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "aliasAuthorizationRuleId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AliasAuthorizationRuleId
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "namespaceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NamespaceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
