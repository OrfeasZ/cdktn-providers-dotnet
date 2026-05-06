using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciNetworkLoadBalancerNetworkLoadBalancer
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/network_load_balancer_network_load_balancer oci_network_load_balancer_network_load_balancer}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciNetworkLoadBalancerNetworkLoadBalancer.DataOciNetworkLoadBalancerNetworkLoadBalancer), fullyQualifiedName: "oci.dataOciNetworkLoadBalancerNetworkLoadBalancer.DataOciNetworkLoadBalancerNetworkLoadBalancer", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciNetworkLoadBalancerNetworkLoadBalancer.DataOciNetworkLoadBalancerNetworkLoadBalancerConfig\"}}]")]
    public class DataOciNetworkLoadBalancerNetworkLoadBalancer : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/network_load_balancer_network_load_balancer oci_network_load_balancer_network_load_balancer} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciNetworkLoadBalancerNetworkLoadBalancer(Constructs.Construct scope, string id, oci.DataOciNetworkLoadBalancerNetworkLoadBalancer.IDataOciNetworkLoadBalancerNetworkLoadBalancerConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciNetworkLoadBalancerNetworkLoadBalancer.IDataOciNetworkLoadBalancerNetworkLoadBalancerConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciNetworkLoadBalancerNetworkLoadBalancer(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciNetworkLoadBalancerNetworkLoadBalancer(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciNetworkLoadBalancerNetworkLoadBalancer resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciNetworkLoadBalancerNetworkLoadBalancer to import.</param>
        /// <param name="importFromId">The id of the existing DataOciNetworkLoadBalancerNetworkLoadBalancer that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciNetworkLoadBalancerNetworkLoadBalancer to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciNetworkLoadBalancerNetworkLoadBalancer to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/network_load_balancer_network_load_balancer#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciNetworkLoadBalancerNetworkLoadBalancer that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciNetworkLoadBalancerNetworkLoadBalancer to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciNetworkLoadBalancerNetworkLoadBalancer.DataOciNetworkLoadBalancerNetworkLoadBalancer), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciNetworkLoadBalancerNetworkLoadBalancer.DataOciNetworkLoadBalancerNetworkLoadBalancer))!;

        [JsiiProperty(name: "assignedIpv6", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssignedIpv6
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "assignedPrivateIpv4", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssignedPrivateIpv4
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "ipAddresses", typeJson: "{\"fqn\":\"oci.dataOciNetworkLoadBalancerNetworkLoadBalancer.DataOciNetworkLoadBalancerNetworkLoadBalancerIpAddressesList\"}")]
        public virtual oci.DataOciNetworkLoadBalancerNetworkLoadBalancer.DataOciNetworkLoadBalancerNetworkLoadBalancerIpAddressesList IpAddresses
        {
            get => GetInstanceProperty<oci.DataOciNetworkLoadBalancerNetworkLoadBalancer.DataOciNetworkLoadBalancerNetworkLoadBalancerIpAddressesList>()!;
        }

        [JsiiProperty(name: "isPreserveSourceDestination", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsPreserveSourceDestination
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isPrivate", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsPrivate
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isSymmetricHashEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSymmetricHashEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NetworkSecurityGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "nlbIpVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NlbIpVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "reservedIps", typeJson: "{\"fqn\":\"oci.dataOciNetworkLoadBalancerNetworkLoadBalancer.DataOciNetworkLoadBalancerNetworkLoadBalancerReservedIpsList\"}")]
        public virtual oci.DataOciNetworkLoadBalancerNetworkLoadBalancer.DataOciNetworkLoadBalancerNetworkLoadBalancerReservedIpsList ReservedIps
        {
            get => GetInstanceProperty<oci.DataOciNetworkLoadBalancerNetworkLoadBalancer.DataOciNetworkLoadBalancerNetworkLoadBalancerReservedIpsList>()!;
        }

        [JsiiProperty(name: "securityAttributes", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SecurityAttributes
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subnetIpv6Cidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetIpv6Cidr
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
        [JsiiProperty(name: "networkLoadBalancerIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NetworkLoadBalancerIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "networkLoadBalancerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkLoadBalancerId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
