using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCoreVirtualCircuit
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/core_virtual_circuit oci_core_virtual_circuit}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciCoreVirtualCircuit.DataOciCoreVirtualCircuit), fullyQualifiedName: "oci.dataOciCoreVirtualCircuit.DataOciCoreVirtualCircuit", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciCoreVirtualCircuit.DataOciCoreVirtualCircuitConfig\"}}]")]
    public class DataOciCoreVirtualCircuit : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/core_virtual_circuit oci_core_virtual_circuit} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciCoreVirtualCircuit(Constructs.Construct scope, string id, oci.DataOciCoreVirtualCircuit.IDataOciCoreVirtualCircuitConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciCoreVirtualCircuit.IDataOciCoreVirtualCircuitConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreVirtualCircuit(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreVirtualCircuit(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciCoreVirtualCircuit resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciCoreVirtualCircuit to import.</param>
        /// <param name="importFromId">The id of the existing DataOciCoreVirtualCircuit that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciCoreVirtualCircuit to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciCoreVirtualCircuit to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/core_virtual_circuit#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciCoreVirtualCircuit that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciCoreVirtualCircuit to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciCoreVirtualCircuit.DataOciCoreVirtualCircuit), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciCoreVirtualCircuit.DataOciCoreVirtualCircuit))!;

        [JsiiProperty(name: "bandwidthShapeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BandwidthShapeName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bgpAdminState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BgpAdminState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bgpIpv6SessionState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BgpIpv6SessionState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bgpManagement", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BgpManagement
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bgpSessionState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BgpSessionState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "crossConnectMappings", typeJson: "{\"fqn\":\"oci.dataOciCoreVirtualCircuit.DataOciCoreVirtualCircuitCrossConnectMappingsList\"}")]
        public virtual oci.DataOciCoreVirtualCircuit.DataOciCoreVirtualCircuitCrossConnectMappingsList CrossConnectMappings
        {
            get => GetInstanceProperty<oci.DataOciCoreVirtualCircuit.DataOciCoreVirtualCircuitCrossConnectMappingsList>()!;
        }

        [JsiiProperty(name: "customerAsn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerAsn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customerBgpAsn", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CustomerBgpAsn
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "gatewayId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GatewayId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipMtu", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpMtu
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isBfdEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsBfdEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isTransportMode", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsTransportMode
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "oracleBgpAsn", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OracleBgpAsn
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "providerServiceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProviderServiceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "providerServiceKeyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProviderServiceKeyName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "providerState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProviderState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicPrefixes", typeJson: "{\"fqn\":\"oci.dataOciCoreVirtualCircuit.DataOciCoreVirtualCircuitPublicPrefixesList\"}")]
        public virtual oci.DataOciCoreVirtualCircuit.DataOciCoreVirtualCircuitPublicPrefixesList PublicPrefixes
        {
            get => GetInstanceProperty<oci.DataOciCoreVirtualCircuit.DataOciCoreVirtualCircuitPublicPrefixesList>()!;
        }

        [JsiiProperty(name: "referenceComment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReferenceComment
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "routingPolicy", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RoutingPolicy
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "serviceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "virtualCircuitRedundancyMetadata", typeJson: "{\"fqn\":\"oci.dataOciCoreVirtualCircuit.DataOciCoreVirtualCircuitVirtualCircuitRedundancyMetadataList\"}")]
        public virtual oci.DataOciCoreVirtualCircuit.DataOciCoreVirtualCircuitVirtualCircuitRedundancyMetadataList VirtualCircuitRedundancyMetadata
        {
            get => GetInstanceProperty<oci.DataOciCoreVirtualCircuit.DataOciCoreVirtualCircuitVirtualCircuitRedundancyMetadataList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "virtualCircuitIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VirtualCircuitIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "virtualCircuitId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VirtualCircuitId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
