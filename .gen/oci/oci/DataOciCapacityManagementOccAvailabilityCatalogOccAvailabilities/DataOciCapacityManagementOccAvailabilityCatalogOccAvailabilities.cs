using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCapacityManagementOccAvailabilityCatalogOccAvailabilities
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/capacity_management_occ_availability_catalog_occ_availabilities oci_capacity_management_occ_availability_catalog_occ_availabilities}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciCapacityManagementOccAvailabilityCatalogOccAvailabilities.DataOciCapacityManagementOccAvailabilityCatalogOccAvailabilities), fullyQualifiedName: "oci.dataOciCapacityManagementOccAvailabilityCatalogOccAvailabilities.DataOciCapacityManagementOccAvailabilityCatalogOccAvailabilities", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciCapacityManagementOccAvailabilityCatalogOccAvailabilities.DataOciCapacityManagementOccAvailabilityCatalogOccAvailabilitiesConfig\"}}]")]
    public class DataOciCapacityManagementOccAvailabilityCatalogOccAvailabilities : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/capacity_management_occ_availability_catalog_occ_availabilities oci_capacity_management_occ_availability_catalog_occ_availabilities} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciCapacityManagementOccAvailabilityCatalogOccAvailabilities(Constructs.Construct scope, string id, oci.DataOciCapacityManagementOccAvailabilityCatalogOccAvailabilities.IDataOciCapacityManagementOccAvailabilityCatalogOccAvailabilitiesConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciCapacityManagementOccAvailabilityCatalogOccAvailabilities.IDataOciCapacityManagementOccAvailabilityCatalogOccAvailabilitiesConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCapacityManagementOccAvailabilityCatalogOccAvailabilities(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCapacityManagementOccAvailabilityCatalogOccAvailabilities(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciCapacityManagementOccAvailabilityCatalogOccAvailabilities resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciCapacityManagementOccAvailabilityCatalogOccAvailabilities to import.</param>
        /// <param name="importFromId">The id of the existing DataOciCapacityManagementOccAvailabilityCatalogOccAvailabilities that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciCapacityManagementOccAvailabilityCatalogOccAvailabilities to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciCapacityManagementOccAvailabilityCatalogOccAvailabilities to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/capacity_management_occ_availability_catalog_occ_availabilities#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciCapacityManagementOccAvailabilityCatalogOccAvailabilities that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciCapacityManagementOccAvailabilityCatalogOccAvailabilities to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciCapacityManagementOccAvailabilityCatalogOccAvailabilities.DataOciCapacityManagementOccAvailabilityCatalogOccAvailabilities), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciCapacityManagementOccAvailabilityCatalogOccAvailabilities.DataOciCapacityManagementOccAvailabilityCatalogOccAvailabilitiesFilter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFilter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataOciCapacityManagementOccAvailabilityCatalogOccAvailabilities.IDataOciCapacityManagementOccAvailabilityCatalogOccAvailabilitiesFilter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciCapacityManagementOccAvailabilityCatalogOccAvailabilities.IDataOciCapacityManagementOccAvailabilityCatalogOccAvailabilitiesFilter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciCapacityManagementOccAvailabilityCatalogOccAvailabilities.IDataOciCapacityManagementOccAvailabilityCatalogOccAvailabilitiesFilter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDateExpectedCapacityHandover")]
        public virtual void ResetDateExpectedCapacityHandover()
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

        [JsiiMethod(name: "resetResourceName")]
        public virtual void ResetResourceName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceType")]
        public virtual void ResetResourceType()
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
        = GetStaticProperty<string>(typeof(oci.DataOciCapacityManagementOccAvailabilityCatalogOccAvailabilities.DataOciCapacityManagementOccAvailabilityCatalogOccAvailabilities))!;

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"oci.dataOciCapacityManagementOccAvailabilityCatalogOccAvailabilities.DataOciCapacityManagementOccAvailabilityCatalogOccAvailabilitiesFilterList\"}")]
        public virtual oci.DataOciCapacityManagementOccAvailabilityCatalogOccAvailabilities.DataOciCapacityManagementOccAvailabilityCatalogOccAvailabilitiesFilterList Filter
        {
            get => GetInstanceProperty<oci.DataOciCapacityManagementOccAvailabilityCatalogOccAvailabilities.DataOciCapacityManagementOccAvailabilityCatalogOccAvailabilitiesFilterList>()!;
        }

        [JsiiProperty(name: "occAvailabilityCollection", typeJson: "{\"fqn\":\"oci.dataOciCapacityManagementOccAvailabilityCatalogOccAvailabilities.DataOciCapacityManagementOccAvailabilityCatalogOccAvailabilitiesOccAvailabilityCollectionList\"}")]
        public virtual oci.DataOciCapacityManagementOccAvailabilityCatalogOccAvailabilities.DataOciCapacityManagementOccAvailabilityCatalogOccAvailabilitiesOccAvailabilityCollectionList OccAvailabilityCollection
        {
            get => GetInstanceProperty<oci.DataOciCapacityManagementOccAvailabilityCatalogOccAvailabilities.DataOciCapacityManagementOccAvailabilityCatalogOccAvailabilitiesOccAvailabilityCollectionList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dateExpectedCapacityHandoverInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DateExpectedCapacityHandoverInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciCapacityManagementOccAvailabilityCatalogOccAvailabilities.DataOciCapacityManagementOccAvailabilityCatalogOccAvailabilitiesFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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

        [JsiiOptional]
        [JsiiProperty(name: "occAvailabilityCatalogIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OccAvailabilityCatalogIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workloadTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WorkloadTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "dateExpectedCapacityHandover", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DateExpectedCapacityHandover
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

        [JsiiProperty(name: "occAvailabilityCatalogId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OccAvailabilityCatalogId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceType
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
