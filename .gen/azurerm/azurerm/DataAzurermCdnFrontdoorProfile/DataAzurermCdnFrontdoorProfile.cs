using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermCdnFrontdoorProfile
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/data-sources/cdn_frontdoor_profile azurerm_cdn_frontdoor_profile}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermCdnFrontdoorProfile.DataAzurermCdnFrontdoorProfile), fullyQualifiedName: "azurerm.dataAzurermCdnFrontdoorProfile.DataAzurermCdnFrontdoorProfile", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermCdnFrontdoorProfile.DataAzurermCdnFrontdoorProfileConfig\"}}]")]
    public class DataAzurermCdnFrontdoorProfile : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/data-sources/cdn_frontdoor_profile azurerm_cdn_frontdoor_profile} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermCdnFrontdoorProfile(Constructs.Construct scope, string id, azurerm.DataAzurermCdnFrontdoorProfile.IDataAzurermCdnFrontdoorProfileConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermCdnFrontdoorProfile.IDataAzurermCdnFrontdoorProfileConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermCdnFrontdoorProfile(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermCdnFrontdoorProfile(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAzurermCdnFrontdoorProfile resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermCdnFrontdoorProfile to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermCdnFrontdoorProfile that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermCdnFrontdoorProfile to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermCdnFrontdoorProfile to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/data-sources/cdn_frontdoor_profile#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermCdnFrontdoorProfile that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermCdnFrontdoorProfile to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.DataAzurermCdnFrontdoorProfile.DataAzurermCdnFrontdoorProfile), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermCdnFrontdoorProfile.DataAzurermCdnFrontdoorProfileTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermCdnFrontdoorProfile.IDataAzurermCdnFrontdoorProfileTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermCdnFrontdoorProfile.IDataAzurermCdnFrontdoorProfileTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermCdnFrontdoorProfile.DataAzurermCdnFrontdoorProfile))!;

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.dataAzurermCdnFrontdoorProfile.DataAzurermCdnFrontdoorProfileIdentityList\"}")]
        public virtual azurerm.DataAzurermCdnFrontdoorProfile.DataAzurermCdnFrontdoorProfileIdentityList Identity
        {
            get => GetInstanceProperty<azurerm.DataAzurermCdnFrontdoorProfile.DataAzurermCdnFrontdoorProfileIdentityList>()!;
        }

        [JsiiProperty(name: "logScrubbingRule", typeJson: "{\"fqn\":\"azurerm.dataAzurermCdnFrontdoorProfile.DataAzurermCdnFrontdoorProfileLogScrubbingRuleList\"}")]
        public virtual azurerm.DataAzurermCdnFrontdoorProfile.DataAzurermCdnFrontdoorProfileLogScrubbingRuleList LogScrubbingRule
        {
            get => GetInstanceProperty<azurerm.DataAzurermCdnFrontdoorProfile.DataAzurermCdnFrontdoorProfileLogScrubbingRuleList>()!;
        }

        [JsiiProperty(name: "resourceGuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGuid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "responseTimeoutSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ResponseTimeoutSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "skuName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SkuName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Tags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermCdnFrontdoorProfile.DataAzurermCdnFrontdoorProfileTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermCdnFrontdoorProfile.DataAzurermCdnFrontdoorProfileTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermCdnFrontdoorProfile.DataAzurermCdnFrontdoorProfileTimeoutsOutputReference>()!;
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.DataAzurermCdnFrontdoorProfile.IDataAzurermCdnFrontdoorProfileTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermCdnFrontdoorProfile.DataAzurermCdnFrontdoorProfileTimeouts\"}]}}", isOptional: true)]
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
