using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCapacityManagementInternalNamespaceOccOverviews
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/capacity_management_internal_namespace_occ_overviews oci_capacity_management_internal_namespace_occ_overviews}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciCapacityManagementInternalNamespaceOccOverviews.DataOciCapacityManagementInternalNamespaceOccOverviews), fullyQualifiedName: "oci.dataOciCapacityManagementInternalNamespaceOccOverviews.DataOciCapacityManagementInternalNamespaceOccOverviews", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciCapacityManagementInternalNamespaceOccOverviews.DataOciCapacityManagementInternalNamespaceOccOverviewsConfig\"}}]")]
    public class DataOciCapacityManagementInternalNamespaceOccOverviews : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/capacity_management_internal_namespace_occ_overviews oci_capacity_management_internal_namespace_occ_overviews} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciCapacityManagementInternalNamespaceOccOverviews(Constructs.Construct scope, string id, oci.DataOciCapacityManagementInternalNamespaceOccOverviews.IDataOciCapacityManagementInternalNamespaceOccOverviewsConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciCapacityManagementInternalNamespaceOccOverviews.IDataOciCapacityManagementInternalNamespaceOccOverviewsConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCapacityManagementInternalNamespaceOccOverviews(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCapacityManagementInternalNamespaceOccOverviews(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciCapacityManagementInternalNamespaceOccOverviews resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciCapacityManagementInternalNamespaceOccOverviews to import.</param>
        /// <param name="importFromId">The id of the existing DataOciCapacityManagementInternalNamespaceOccOverviews that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciCapacityManagementInternalNamespaceOccOverviews to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciCapacityManagementInternalNamespaceOccOverviews to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/capacity_management_internal_namespace_occ_overviews#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciCapacityManagementInternalNamespaceOccOverviews that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciCapacityManagementInternalNamespaceOccOverviews to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciCapacityManagementInternalNamespaceOccOverviews.DataOciCapacityManagementInternalNamespaceOccOverviews), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciCapacityManagementInternalNamespaceOccOverviews.DataOciCapacityManagementInternalNamespaceOccOverviewsFilter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFilter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataOciCapacityManagementInternalNamespaceOccOverviews.IDataOciCapacityManagementInternalNamespaceOccOverviewsFilter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciCapacityManagementInternalNamespaceOccOverviews.IDataOciCapacityManagementInternalNamespaceOccOverviewsFilter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciCapacityManagementInternalNamespaceOccOverviews.IDataOciCapacityManagementInternalNamespaceOccOverviewsFilter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFrom")]
        public virtual void ResetFrom()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTo")]
        public virtual void ResetTo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWorkloadType")]
        public virtual void ResetWorkloadType()
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
        = GetStaticProperty<string>(typeof(oci.DataOciCapacityManagementInternalNamespaceOccOverviews.DataOciCapacityManagementInternalNamespaceOccOverviews))!;

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"oci.dataOciCapacityManagementInternalNamespaceOccOverviews.DataOciCapacityManagementInternalNamespaceOccOverviewsFilterList\"}")]
        public virtual oci.DataOciCapacityManagementInternalNamespaceOccOverviews.DataOciCapacityManagementInternalNamespaceOccOverviewsFilterList Filter
        {
            get => GetInstanceProperty<oci.DataOciCapacityManagementInternalNamespaceOccOverviews.DataOciCapacityManagementInternalNamespaceOccOverviewsFilterList>()!;
        }

        [JsiiProperty(name: "occOverviewCollection", typeJson: "{\"fqn\":\"oci.dataOciCapacityManagementInternalNamespaceOccOverviews.DataOciCapacityManagementInternalNamespaceOccOverviewsOccOverviewCollectionList\"}")]
        public virtual oci.DataOciCapacityManagementInternalNamespaceOccOverviews.DataOciCapacityManagementInternalNamespaceOccOverviewsOccOverviewCollectionList OccOverviewCollection
        {
            get => GetInstanceProperty<oci.DataOciCapacityManagementInternalNamespaceOccOverviews.DataOciCapacityManagementInternalNamespaceOccOverviewsOccOverviewCollectionList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciCapacityManagementInternalNamespaceOccOverviews.DataOciCapacityManagementInternalNamespaceOccOverviewsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FilterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fromInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FromInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "namespaceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamespaceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "occCustomerGroupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OccCustomerGroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "toInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ToInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workloadTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WorkloadTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "from", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string From
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

        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Namespace
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "occCustomerGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OccCustomerGroupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "to", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string To
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "workloadType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkloadType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
