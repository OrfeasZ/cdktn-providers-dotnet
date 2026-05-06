using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCorePeerRegionForRemotePeerings
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/core_peer_region_for_remote_peerings oci_core_peer_region_for_remote_peerings}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciCorePeerRegionForRemotePeerings.DataOciCorePeerRegionForRemotePeerings), fullyQualifiedName: "oci.dataOciCorePeerRegionForRemotePeerings.DataOciCorePeerRegionForRemotePeerings", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"oci.dataOciCorePeerRegionForRemotePeerings.DataOciCorePeerRegionForRemotePeeringsConfig\"}}]")]
    public class DataOciCorePeerRegionForRemotePeerings : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/core_peer_region_for_remote_peerings oci_core_peer_region_for_remote_peerings} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciCorePeerRegionForRemotePeerings(Constructs.Construct scope, string id, oci.DataOciCorePeerRegionForRemotePeerings.IDataOciCorePeerRegionForRemotePeeringsConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciCorePeerRegionForRemotePeerings.IDataOciCorePeerRegionForRemotePeeringsConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCorePeerRegionForRemotePeerings(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCorePeerRegionForRemotePeerings(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciCorePeerRegionForRemotePeerings resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciCorePeerRegionForRemotePeerings to import.</param>
        /// <param name="importFromId">The id of the existing DataOciCorePeerRegionForRemotePeerings that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciCorePeerRegionForRemotePeerings to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciCorePeerRegionForRemotePeerings to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/core_peer_region_for_remote_peerings#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciCorePeerRegionForRemotePeerings that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciCorePeerRegionForRemotePeerings to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciCorePeerRegionForRemotePeerings.DataOciCorePeerRegionForRemotePeerings), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciCorePeerRegionForRemotePeerings.DataOciCorePeerRegionForRemotePeeringsFilter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFilter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataOciCorePeerRegionForRemotePeerings.IDataOciCorePeerRegionForRemotePeeringsFilter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciCorePeerRegionForRemotePeerings.IDataOciCorePeerRegionForRemotePeeringsFilter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciCorePeerRegionForRemotePeerings.IDataOciCorePeerRegionForRemotePeeringsFilter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(oci.DataOciCorePeerRegionForRemotePeerings.DataOciCorePeerRegionForRemotePeerings))!;

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"oci.dataOciCorePeerRegionForRemotePeerings.DataOciCorePeerRegionForRemotePeeringsFilterList\"}")]
        public virtual oci.DataOciCorePeerRegionForRemotePeerings.DataOciCorePeerRegionForRemotePeeringsFilterList Filter
        {
            get => GetInstanceProperty<oci.DataOciCorePeerRegionForRemotePeerings.DataOciCorePeerRegionForRemotePeeringsFilterList>()!;
        }

        [JsiiProperty(name: "peerRegionForRemotePeerings", typeJson: "{\"fqn\":\"oci.dataOciCorePeerRegionForRemotePeerings.DataOciCorePeerRegionForRemotePeeringsPeerRegionForRemotePeeringsList\"}")]
        public virtual oci.DataOciCorePeerRegionForRemotePeerings.DataOciCorePeerRegionForRemotePeeringsPeerRegionForRemotePeeringsList PeerRegionForRemotePeerings
        {
            get => GetInstanceProperty<oci.DataOciCorePeerRegionForRemotePeerings.DataOciCorePeerRegionForRemotePeeringsPeerRegionForRemotePeeringsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciCorePeerRegionForRemotePeerings.DataOciCorePeerRegionForRemotePeeringsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
