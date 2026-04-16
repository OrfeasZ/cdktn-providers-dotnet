using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustGatewayPolicy
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_gateway_policy cloudflare_zero_trust_gateway_policy}.</summary>
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicy), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicy", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyConfig\"}}]")]
    public class DataCloudflareZeroTrustGatewayPolicy : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_gateway_policy cloudflare_zero_trust_gateway_policy} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataCloudflareZeroTrustGatewayPolicy(Constructs.Construct scope, string id, cloudflare.DataCloudflareZeroTrustGatewayPolicy.IDataCloudflareZeroTrustGatewayPolicyConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, cloudflare.DataCloudflareZeroTrustGatewayPolicy.IDataCloudflareZeroTrustGatewayPolicyConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustGatewayPolicy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustGatewayPolicy(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataCloudflareZeroTrustGatewayPolicy resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataCloudflareZeroTrustGatewayPolicy to import.</param>
        /// <param name="importFromId">The id of the existing DataCloudflareZeroTrustGatewayPolicy that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataCloudflareZeroTrustGatewayPolicy to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataCloudflareZeroTrustGatewayPolicy to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_gateway_policy#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataCloudflareZeroTrustGatewayPolicy that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataCloudflareZeroTrustGatewayPolicy to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicy), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicy))!;

        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Action
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deletedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeletedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "devicePosture", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DevicePosture
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Enabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "expiration", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyExpirationOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyExpirationOutputReference Expiration
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyExpirationOutputReference>()!;
        }

        [JsiiProperty(name: "filters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Filters
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Identity
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "precedence", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Precedence
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "readOnly", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ReadOnly
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "ruleSettings", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsOutputReference RuleSettings
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "schedule", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyScheduleOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyScheduleOutputReference Schedule
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyScheduleOutputReference>()!;
        }

        [JsiiProperty(name: "sharable", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Sharable
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "sourceAccount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceAccount
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "traffic", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Traffic
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Version
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "warningStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WarningStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ruleIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RuleIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ruleId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuleId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
