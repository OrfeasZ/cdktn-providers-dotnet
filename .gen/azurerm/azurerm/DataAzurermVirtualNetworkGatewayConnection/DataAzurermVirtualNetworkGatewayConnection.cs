using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermVirtualNetworkGatewayConnection
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/data-sources/virtual_network_gateway_connection azurerm_virtual_network_gateway_connection}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermVirtualNetworkGatewayConnection.DataAzurermVirtualNetworkGatewayConnection), fullyQualifiedName: "azurerm.dataAzurermVirtualNetworkGatewayConnection.DataAzurermVirtualNetworkGatewayConnection", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermVirtualNetworkGatewayConnection.DataAzurermVirtualNetworkGatewayConnectionConfig\"}}]")]
    public class DataAzurermVirtualNetworkGatewayConnection : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/data-sources/virtual_network_gateway_connection azurerm_virtual_network_gateway_connection} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermVirtualNetworkGatewayConnection(Constructs.Construct scope, string id, azurerm.DataAzurermVirtualNetworkGatewayConnection.IDataAzurermVirtualNetworkGatewayConnectionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermVirtualNetworkGatewayConnection.IDataAzurermVirtualNetworkGatewayConnectionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermVirtualNetworkGatewayConnection(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermVirtualNetworkGatewayConnection(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAzurermVirtualNetworkGatewayConnection resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermVirtualNetworkGatewayConnection to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermVirtualNetworkGatewayConnection that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermVirtualNetworkGatewayConnection to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermVirtualNetworkGatewayConnection to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/data-sources/virtual_network_gateway_connection#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermVirtualNetworkGatewayConnection that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermVirtualNetworkGatewayConnection to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.DataAzurermVirtualNetworkGatewayConnection.DataAzurermVirtualNetworkGatewayConnection), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermVirtualNetworkGatewayConnection.DataAzurermVirtualNetworkGatewayConnectionTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermVirtualNetworkGatewayConnection.IDataAzurermVirtualNetworkGatewayConnectionTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermVirtualNetworkGatewayConnection.IDataAzurermVirtualNetworkGatewayConnectionTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermVirtualNetworkGatewayConnection.DataAzurermVirtualNetworkGatewayConnection))!;

        [JsiiProperty(name: "authorizationKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthorizationKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bgpEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable BgpEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "connectionProtocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionProtocol
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dpdTimeoutSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DpdTimeoutSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "egressBytesTransferred", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EgressBytesTransferred
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "expressRouteCircuitId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExpressRouteCircuitId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "expressRouteGatewayBypass", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ExpressRouteGatewayBypass
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "ingressBytesTransferred", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IngressBytesTransferred
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ipsecPolicy", typeJson: "{\"fqn\":\"azurerm.dataAzurermVirtualNetworkGatewayConnection.DataAzurermVirtualNetworkGatewayConnectionIpsecPolicyList\"}")]
        public virtual azurerm.DataAzurermVirtualNetworkGatewayConnection.DataAzurermVirtualNetworkGatewayConnectionIpsecPolicyList IpsecPolicy
        {
            get => GetInstanceProperty<azurerm.DataAzurermVirtualNetworkGatewayConnection.DataAzurermVirtualNetworkGatewayConnectionIpsecPolicyList>()!;
        }

        [JsiiProperty(name: "localAzureIpAddressEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable LocalAzureIpAddressEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "localNetworkGatewayId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LocalNetworkGatewayId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerVirtualNetworkGatewayId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerVirtualNetworkGatewayId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateLinkFastPathEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable PrivateLinkFastPathEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "resourceGuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGuid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "routingWeight", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RoutingWeight
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sharedKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SharedKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Tags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermVirtualNetworkGatewayConnection.DataAzurermVirtualNetworkGatewayConnectionTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermVirtualNetworkGatewayConnection.DataAzurermVirtualNetworkGatewayConnectionTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermVirtualNetworkGatewayConnection.DataAzurermVirtualNetworkGatewayConnectionTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "trafficSelectorPolicy", typeJson: "{\"fqn\":\"azurerm.dataAzurermVirtualNetworkGatewayConnection.DataAzurermVirtualNetworkGatewayConnectionTrafficSelectorPolicyList\"}")]
        public virtual azurerm.DataAzurermVirtualNetworkGatewayConnection.DataAzurermVirtualNetworkGatewayConnectionTrafficSelectorPolicyList TrafficSelectorPolicy
        {
            get => GetInstanceProperty<azurerm.DataAzurermVirtualNetworkGatewayConnection.DataAzurermVirtualNetworkGatewayConnectionTrafficSelectorPolicyList>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "usePolicyBasedTrafficSelectors", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable UsePolicyBasedTrafficSelectors
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "virtualNetworkGatewayId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VirtualNetworkGatewayId
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.DataAzurermVirtualNetworkGatewayConnection.IDataAzurermVirtualNetworkGatewayConnectionTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermVirtualNetworkGatewayConnection.DataAzurermVirtualNetworkGatewayConnectionTimeouts\"}]}}", isOptional: true)]
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
