using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciWafWebAppFirewallPolicy
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/waf_web_app_firewall_policy oci_waf_web_app_firewall_policy}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciWafWebAppFirewallPolicy.DataOciWafWebAppFirewallPolicy), fullyQualifiedName: "oci.dataOciWafWebAppFirewallPolicy.DataOciWafWebAppFirewallPolicy", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciWafWebAppFirewallPolicy.DataOciWafWebAppFirewallPolicyConfig\"}}]")]
    public class DataOciWafWebAppFirewallPolicy : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/waf_web_app_firewall_policy oci_waf_web_app_firewall_policy} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciWafWebAppFirewallPolicy(Constructs.Construct scope, string id, oci.DataOciWafWebAppFirewallPolicy.IDataOciWafWebAppFirewallPolicyConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciWafWebAppFirewallPolicy.IDataOciWafWebAppFirewallPolicyConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciWafWebAppFirewallPolicy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciWafWebAppFirewallPolicy(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciWafWebAppFirewallPolicy resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciWafWebAppFirewallPolicy to import.</param>
        /// <param name="importFromId">The id of the existing DataOciWafWebAppFirewallPolicy that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciWafWebAppFirewallPolicy to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciWafWebAppFirewallPolicy to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/waf_web_app_firewall_policy#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciWafWebAppFirewallPolicy that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciWafWebAppFirewallPolicy to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciWafWebAppFirewallPolicy.DataOciWafWebAppFirewallPolicy), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciWafWebAppFirewallPolicy.DataOciWafWebAppFirewallPolicy))!;

        [JsiiProperty(name: "actions", typeJson: "{\"fqn\":\"oci.dataOciWafWebAppFirewallPolicy.DataOciWafWebAppFirewallPolicyActionsList\"}")]
        public virtual oci.DataOciWafWebAppFirewallPolicy.DataOciWafWebAppFirewallPolicyActionsList Actions
        {
            get => GetInstanceProperty<oci.DataOciWafWebAppFirewallPolicy.DataOciWafWebAppFirewallPolicyActionsList>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requestAccessControl", typeJson: "{\"fqn\":\"oci.dataOciWafWebAppFirewallPolicy.DataOciWafWebAppFirewallPolicyRequestAccessControlList\"}")]
        public virtual oci.DataOciWafWebAppFirewallPolicy.DataOciWafWebAppFirewallPolicyRequestAccessControlList RequestAccessControl
        {
            get => GetInstanceProperty<oci.DataOciWafWebAppFirewallPolicy.DataOciWafWebAppFirewallPolicyRequestAccessControlList>()!;
        }

        [JsiiProperty(name: "requestProtection", typeJson: "{\"fqn\":\"oci.dataOciWafWebAppFirewallPolicy.DataOciWafWebAppFirewallPolicyRequestProtectionList\"}")]
        public virtual oci.DataOciWafWebAppFirewallPolicy.DataOciWafWebAppFirewallPolicyRequestProtectionList RequestProtection
        {
            get => GetInstanceProperty<oci.DataOciWafWebAppFirewallPolicy.DataOciWafWebAppFirewallPolicyRequestProtectionList>()!;
        }

        [JsiiProperty(name: "requestRateLimiting", typeJson: "{\"fqn\":\"oci.dataOciWafWebAppFirewallPolicy.DataOciWafWebAppFirewallPolicyRequestRateLimitingList\"}")]
        public virtual oci.DataOciWafWebAppFirewallPolicy.DataOciWafWebAppFirewallPolicyRequestRateLimitingList RequestRateLimiting
        {
            get => GetInstanceProperty<oci.DataOciWafWebAppFirewallPolicy.DataOciWafWebAppFirewallPolicyRequestRateLimitingList>()!;
        }

        [JsiiProperty(name: "responseAccessControl", typeJson: "{\"fqn\":\"oci.dataOciWafWebAppFirewallPolicy.DataOciWafWebAppFirewallPolicyResponseAccessControlList\"}")]
        public virtual oci.DataOciWafWebAppFirewallPolicy.DataOciWafWebAppFirewallPolicyResponseAccessControlList ResponseAccessControl
        {
            get => GetInstanceProperty<oci.DataOciWafWebAppFirewallPolicy.DataOciWafWebAppFirewallPolicyResponseAccessControlList>()!;
        }

        [JsiiProperty(name: "responseProtection", typeJson: "{\"fqn\":\"oci.dataOciWafWebAppFirewallPolicy.DataOciWafWebAppFirewallPolicyResponseProtectionList\"}")]
        public virtual oci.DataOciWafWebAppFirewallPolicy.DataOciWafWebAppFirewallPolicyResponseProtectionList ResponseProtection
        {
            get => GetInstanceProperty<oci.DataOciWafWebAppFirewallPolicy.DataOciWafWebAppFirewallPolicyResponseProtectionList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "webAppFirewallPolicyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WebAppFirewallPolicyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "webAppFirewallPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WebAppFirewallPolicyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
