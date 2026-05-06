using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciTenantmanagercontrolplaneOrganizations
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/tenantmanagercontrolplane_organizations oci_tenantmanagercontrolplane_organizations}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciTenantmanagercontrolplaneOrganizations.DataOciTenantmanagercontrolplaneOrganizations), fullyQualifiedName: "oci.dataOciTenantmanagercontrolplaneOrganizations.DataOciTenantmanagercontrolplaneOrganizations", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciTenantmanagercontrolplaneOrganizations.DataOciTenantmanagercontrolplaneOrganizationsConfig\"}}]")]
    public class DataOciTenantmanagercontrolplaneOrganizations : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/tenantmanagercontrolplane_organizations oci_tenantmanagercontrolplane_organizations} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciTenantmanagercontrolplaneOrganizations(Constructs.Construct scope, string id, oci.DataOciTenantmanagercontrolplaneOrganizations.IDataOciTenantmanagercontrolplaneOrganizationsConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciTenantmanagercontrolplaneOrganizations.IDataOciTenantmanagercontrolplaneOrganizationsConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciTenantmanagercontrolplaneOrganizations(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciTenantmanagercontrolplaneOrganizations(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciTenantmanagercontrolplaneOrganizations resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciTenantmanagercontrolplaneOrganizations to import.</param>
        /// <param name="importFromId">The id of the existing DataOciTenantmanagercontrolplaneOrganizations that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciTenantmanagercontrolplaneOrganizations to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciTenantmanagercontrolplaneOrganizations to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/tenantmanagercontrolplane_organizations#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciTenantmanagercontrolplaneOrganizations that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciTenantmanagercontrolplaneOrganizations to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciTenantmanagercontrolplaneOrganizations.DataOciTenantmanagercontrolplaneOrganizations), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciTenantmanagercontrolplaneOrganizations.DataOciTenantmanagercontrolplaneOrganizationsFilter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFilter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataOciTenantmanagercontrolplaneOrganizations.IDataOciTenantmanagercontrolplaneOrganizationsFilter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciTenantmanagercontrolplaneOrganizations.IDataOciTenantmanagercontrolplaneOrganizationsFilter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciTenantmanagercontrolplaneOrganizations.IDataOciTenantmanagercontrolplaneOrganizationsFilter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
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
        = GetStaticProperty<string>(typeof(oci.DataOciTenantmanagercontrolplaneOrganizations.DataOciTenantmanagercontrolplaneOrganizations))!;

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"oci.dataOciTenantmanagercontrolplaneOrganizations.DataOciTenantmanagercontrolplaneOrganizationsFilterList\"}")]
        public virtual oci.DataOciTenantmanagercontrolplaneOrganizations.DataOciTenantmanagercontrolplaneOrganizationsFilterList Filter
        {
            get => GetInstanceProperty<oci.DataOciTenantmanagercontrolplaneOrganizations.DataOciTenantmanagercontrolplaneOrganizationsFilterList>()!;
        }

        [JsiiProperty(name: "organizationCollection", typeJson: "{\"fqn\":\"oci.dataOciTenantmanagercontrolplaneOrganizations.DataOciTenantmanagercontrolplaneOrganizationsOrganizationCollectionList\"}")]
        public virtual oci.DataOciTenantmanagercontrolplaneOrganizations.DataOciTenantmanagercontrolplaneOrganizationsOrganizationCollectionList OrganizationCollection
        {
            get => GetInstanceProperty<oci.DataOciTenantmanagercontrolplaneOrganizations.DataOciTenantmanagercontrolplaneOrganizationsOrganizationCollectionList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciTenantmanagercontrolplaneOrganizations.DataOciTenantmanagercontrolplaneOrganizationsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
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
