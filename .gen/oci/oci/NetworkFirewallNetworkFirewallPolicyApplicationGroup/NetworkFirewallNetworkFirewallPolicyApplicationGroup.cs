using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.NetworkFirewallNetworkFirewallPolicyApplicationGroup
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_application_group oci_network_firewall_network_firewall_policy_application_group}.</summary>
    [JsiiClass(nativeType: typeof(oci.NetworkFirewallNetworkFirewallPolicyApplicationGroup.NetworkFirewallNetworkFirewallPolicyApplicationGroup), fullyQualifiedName: "oci.networkFirewallNetworkFirewallPolicyApplicationGroup.NetworkFirewallNetworkFirewallPolicyApplicationGroup", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicyApplicationGroup.NetworkFirewallNetworkFirewallPolicyApplicationGroupConfig\"}}]")]
    public class NetworkFirewallNetworkFirewallPolicyApplicationGroup : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_application_group oci_network_firewall_network_firewall_policy_application_group} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public NetworkFirewallNetworkFirewallPolicyApplicationGroup(Constructs.Construct scope, string id, oci.NetworkFirewallNetworkFirewallPolicyApplicationGroup.INetworkFirewallNetworkFirewallPolicyApplicationGroupConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.NetworkFirewallNetworkFirewallPolicyApplicationGroup.INetworkFirewallNetworkFirewallPolicyApplicationGroupConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkFirewallNetworkFirewallPolicyApplicationGroup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkFirewallNetworkFirewallPolicyApplicationGroup(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a NetworkFirewallNetworkFirewallPolicyApplicationGroup resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the NetworkFirewallNetworkFirewallPolicyApplicationGroup to import.</param>
        /// <param name="importFromId">The id of the existing NetworkFirewallNetworkFirewallPolicyApplicationGroup that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the NetworkFirewallNetworkFirewallPolicyApplicationGroup to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the NetworkFirewallNetworkFirewallPolicyApplicationGroup to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_firewall_network_firewall_policy_application_group#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing NetworkFirewallNetworkFirewallPolicyApplicationGroup that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the NetworkFirewallNetworkFirewallPolicyApplicationGroup to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.NetworkFirewallNetworkFirewallPolicyApplicationGroup.NetworkFirewallNetworkFirewallPolicyApplicationGroup), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicyApplicationGroup.NetworkFirewallNetworkFirewallPolicyApplicationGroupTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.NetworkFirewallNetworkFirewallPolicyApplicationGroup.INetworkFirewallNetworkFirewallPolicyApplicationGroupTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.NetworkFirewallNetworkFirewallPolicyApplicationGroup.INetworkFirewallNetworkFirewallPolicyApplicationGroupTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(oci.NetworkFirewallNetworkFirewallPolicyApplicationGroup.NetworkFirewallNetworkFirewallPolicyApplicationGroup))!;

        [JsiiProperty(name: "parentResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentResourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicyApplicationGroup.NetworkFirewallNetworkFirewallPolicyApplicationGroupTimeoutsOutputReference\"}")]
        public virtual oci.NetworkFirewallNetworkFirewallPolicyApplicationGroup.NetworkFirewallNetworkFirewallPolicyApplicationGroupTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.NetworkFirewallNetworkFirewallPolicyApplicationGroup.NetworkFirewallNetworkFirewallPolicyApplicationGroupTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "totalApps", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalApps
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "appsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AppsInput
        {
            get => GetInstanceProperty<string[]?>();
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
        [JsiiProperty(name: "networkFirewallPolicyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NetworkFirewallPolicyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.networkFirewallNetworkFirewallPolicyApplicationGroup.NetworkFirewallNetworkFirewallPolicyApplicationGroupTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "apps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Apps
        {
            get => GetInstanceProperty<string[]>()!;
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

        [JsiiProperty(name: "networkFirewallPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkFirewallPolicyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
