using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermMonitorDataCollectionRule
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/data-sources/monitor_data_collection_rule azurerm_monitor_data_collection_rule}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRule), fullyQualifiedName: "azurerm.dataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRule", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleConfig\"}}]")]
    public class DataAzurermMonitorDataCollectionRule : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/data-sources/monitor_data_collection_rule azurerm_monitor_data_collection_rule} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermMonitorDataCollectionRule(Constructs.Construct scope, string id, azurerm.DataAzurermMonitorDataCollectionRule.IDataAzurermMonitorDataCollectionRuleConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermMonitorDataCollectionRule.IDataAzurermMonitorDataCollectionRuleConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermMonitorDataCollectionRule(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermMonitorDataCollectionRule(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAzurermMonitorDataCollectionRule resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermMonitorDataCollectionRule to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermMonitorDataCollectionRule that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermMonitorDataCollectionRule to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermMonitorDataCollectionRule to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/data-sources/monitor_data_collection_rule#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermMonitorDataCollectionRule that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermMonitorDataCollectionRule to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRule), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermMonitorDataCollectionRule.IDataAzurermMonitorDataCollectionRuleTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermMonitorDataCollectionRule.IDataAzurermMonitorDataCollectionRuleTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRule))!;

        [JsiiProperty(name: "dataCollectionEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataCollectionEndpointId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataFlow", typeJson: "{\"fqn\":\"azurerm.dataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDataFlowList\"}")]
        public virtual azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDataFlowList DataFlow
        {
            get => GetInstanceProperty<azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDataFlowList>()!;
        }

        [JsiiProperty(name: "dataSources", typeJson: "{\"fqn\":\"azurerm.dataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDataSourcesList\"}")]
        public virtual azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDataSourcesList DataSources
        {
            get => GetInstanceProperty<azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDataSourcesList>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "destinations", typeJson: "{\"fqn\":\"azurerm.dataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDestinationsList\"}")]
        public virtual azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDestinationsList Destinations
        {
            get => GetInstanceProperty<azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleDestinationsList>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.dataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleIdentityList\"}")]
        public virtual azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleIdentityList Identity
        {
            get => GetInstanceProperty<azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleIdentityList>()!;
        }

        [JsiiProperty(name: "immutableId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImmutableId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Kind
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "streamDeclaration", typeJson: "{\"fqn\":\"azurerm.dataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleStreamDeclarationList\"}")]
        public virtual azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleStreamDeclarationList StreamDeclaration
        {
            get => GetInstanceProperty<azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleStreamDeclarationList>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Tags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleTimeoutsOutputReference>()!;
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
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.DataAzurermMonitorDataCollectionRule.IDataAzurermMonitorDataCollectionRuleTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
