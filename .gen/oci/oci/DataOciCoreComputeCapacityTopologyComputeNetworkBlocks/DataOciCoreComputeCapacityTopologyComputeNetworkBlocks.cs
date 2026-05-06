using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCoreComputeCapacityTopologyComputeNetworkBlocks
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/core_compute_capacity_topology_compute_network_blocks oci_core_compute_capacity_topology_compute_network_blocks}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciCoreComputeCapacityTopologyComputeNetworkBlocks.DataOciCoreComputeCapacityTopologyComputeNetworkBlocks), fullyQualifiedName: "oci.dataOciCoreComputeCapacityTopologyComputeNetworkBlocks.DataOciCoreComputeCapacityTopologyComputeNetworkBlocks", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciCoreComputeCapacityTopologyComputeNetworkBlocks.DataOciCoreComputeCapacityTopologyComputeNetworkBlocksConfig\"}}]")]
    public class DataOciCoreComputeCapacityTopologyComputeNetworkBlocks : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/core_compute_capacity_topology_compute_network_blocks oci_core_compute_capacity_topology_compute_network_blocks} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciCoreComputeCapacityTopologyComputeNetworkBlocks(Constructs.Construct scope, string id, oci.DataOciCoreComputeCapacityTopologyComputeNetworkBlocks.IDataOciCoreComputeCapacityTopologyComputeNetworkBlocksConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciCoreComputeCapacityTopologyComputeNetworkBlocks.IDataOciCoreComputeCapacityTopologyComputeNetworkBlocksConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreComputeCapacityTopologyComputeNetworkBlocks(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreComputeCapacityTopologyComputeNetworkBlocks(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciCoreComputeCapacityTopologyComputeNetworkBlocks resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciCoreComputeCapacityTopologyComputeNetworkBlocks to import.</param>
        /// <param name="importFromId">The id of the existing DataOciCoreComputeCapacityTopologyComputeNetworkBlocks that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciCoreComputeCapacityTopologyComputeNetworkBlocks to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciCoreComputeCapacityTopologyComputeNetworkBlocks to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/core_compute_capacity_topology_compute_network_blocks#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciCoreComputeCapacityTopologyComputeNetworkBlocks that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciCoreComputeCapacityTopologyComputeNetworkBlocks to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciCoreComputeCapacityTopologyComputeNetworkBlocks.DataOciCoreComputeCapacityTopologyComputeNetworkBlocks), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciCoreComputeCapacityTopologyComputeNetworkBlocks.DataOciCoreComputeCapacityTopologyComputeNetworkBlocksFilter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFilter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataOciCoreComputeCapacityTopologyComputeNetworkBlocks.IDataOciCoreComputeCapacityTopologyComputeNetworkBlocksFilter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciCoreComputeCapacityTopologyComputeNetworkBlocks.IDataOciCoreComputeCapacityTopologyComputeNetworkBlocksFilter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciCoreComputeCapacityTopologyComputeNetworkBlocks.IDataOciCoreComputeCapacityTopologyComputeNetworkBlocksFilter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAvailabilityDomain")]
        public virtual void ResetAvailabilityDomain()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCompartmentId")]
        public virtual void ResetCompartmentId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetComputeHpcIslandId")]
        public virtual void ResetComputeHpcIslandId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(oci.DataOciCoreComputeCapacityTopologyComputeNetworkBlocks.DataOciCoreComputeCapacityTopologyComputeNetworkBlocks))!;

        [JsiiProperty(name: "computeNetworkBlockCollection", typeJson: "{\"fqn\":\"oci.dataOciCoreComputeCapacityTopologyComputeNetworkBlocks.DataOciCoreComputeCapacityTopologyComputeNetworkBlocksComputeNetworkBlockCollectionList\"}")]
        public virtual oci.DataOciCoreComputeCapacityTopologyComputeNetworkBlocks.DataOciCoreComputeCapacityTopologyComputeNetworkBlocksComputeNetworkBlockCollectionList ComputeNetworkBlockCollection
        {
            get => GetInstanceProperty<oci.DataOciCoreComputeCapacityTopologyComputeNetworkBlocks.DataOciCoreComputeCapacityTopologyComputeNetworkBlocksComputeNetworkBlockCollectionList>()!;
        }

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"oci.dataOciCoreComputeCapacityTopologyComputeNetworkBlocks.DataOciCoreComputeCapacityTopologyComputeNetworkBlocksFilterList\"}")]
        public virtual oci.DataOciCoreComputeCapacityTopologyComputeNetworkBlocks.DataOciCoreComputeCapacityTopologyComputeNetworkBlocksFilterList Filter
        {
            get => GetInstanceProperty<oci.DataOciCoreComputeCapacityTopologyComputeNetworkBlocks.DataOciCoreComputeCapacityTopologyComputeNetworkBlocksFilterList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilityDomainInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AvailabilityDomainInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeCapacityTopologyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ComputeCapacityTopologyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeHpcIslandIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ComputeHpcIslandIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciCoreComputeCapacityTopologyComputeNetworkBlocks.DataOciCoreComputeCapacityTopologyComputeNetworkBlocksFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FilterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "computeCapacityTopologyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeCapacityTopologyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "computeHpcIslandId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeHpcIslandId
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
    }
}
