using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOsManagementHubSoftwareSourceModuleStreamProfiles
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/os_management_hub_software_source_module_stream_profiles oci_os_management_hub_software_source_module_stream_profiles}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciOsManagementHubSoftwareSourceModuleStreamProfiles.DataOciOsManagementHubSoftwareSourceModuleStreamProfiles), fullyQualifiedName: "oci.dataOciOsManagementHubSoftwareSourceModuleStreamProfiles.DataOciOsManagementHubSoftwareSourceModuleStreamProfiles", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciOsManagementHubSoftwareSourceModuleStreamProfiles.DataOciOsManagementHubSoftwareSourceModuleStreamProfilesConfig\"}}]")]
    public class DataOciOsManagementHubSoftwareSourceModuleStreamProfiles : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/os_management_hub_software_source_module_stream_profiles oci_os_management_hub_software_source_module_stream_profiles} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciOsManagementHubSoftwareSourceModuleStreamProfiles(Constructs.Construct scope, string id, oci.DataOciOsManagementHubSoftwareSourceModuleStreamProfiles.IDataOciOsManagementHubSoftwareSourceModuleStreamProfilesConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciOsManagementHubSoftwareSourceModuleStreamProfiles.IDataOciOsManagementHubSoftwareSourceModuleStreamProfilesConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOsManagementHubSoftwareSourceModuleStreamProfiles(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOsManagementHubSoftwareSourceModuleStreamProfiles(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciOsManagementHubSoftwareSourceModuleStreamProfiles resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciOsManagementHubSoftwareSourceModuleStreamProfiles to import.</param>
        /// <param name="importFromId">The id of the existing DataOciOsManagementHubSoftwareSourceModuleStreamProfiles that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciOsManagementHubSoftwareSourceModuleStreamProfiles to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciOsManagementHubSoftwareSourceModuleStreamProfiles to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/os_management_hub_software_source_module_stream_profiles#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciOsManagementHubSoftwareSourceModuleStreamProfiles that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciOsManagementHubSoftwareSourceModuleStreamProfiles to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciOsManagementHubSoftwareSourceModuleStreamProfiles.DataOciOsManagementHubSoftwareSourceModuleStreamProfiles), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciOsManagementHubSoftwareSourceModuleStreamProfiles.DataOciOsManagementHubSoftwareSourceModuleStreamProfilesFilter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFilter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataOciOsManagementHubSoftwareSourceModuleStreamProfiles.IDataOciOsManagementHubSoftwareSourceModuleStreamProfilesFilter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciOsManagementHubSoftwareSourceModuleStreamProfiles.IDataOciOsManagementHubSoftwareSourceModuleStreamProfilesFilter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciOsManagementHubSoftwareSourceModuleStreamProfiles.IDataOciOsManagementHubSoftwareSourceModuleStreamProfilesFilter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
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

        [JsiiMethod(name: "resetModuleName")]
        public virtual void ResetModuleName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStreamName")]
        public virtual void ResetStreamName()
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
        = GetStaticProperty<string>(typeof(oci.DataOciOsManagementHubSoftwareSourceModuleStreamProfiles.DataOciOsManagementHubSoftwareSourceModuleStreamProfiles))!;

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubSoftwareSourceModuleStreamProfiles.DataOciOsManagementHubSoftwareSourceModuleStreamProfilesFilterList\"}")]
        public virtual oci.DataOciOsManagementHubSoftwareSourceModuleStreamProfiles.DataOciOsManagementHubSoftwareSourceModuleStreamProfilesFilterList Filter
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubSoftwareSourceModuleStreamProfiles.DataOciOsManagementHubSoftwareSourceModuleStreamProfilesFilterList>()!;
        }

        [JsiiProperty(name: "moduleStreamProfileCollection", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubSoftwareSourceModuleStreamProfiles.DataOciOsManagementHubSoftwareSourceModuleStreamProfilesModuleStreamProfileCollectionList\"}")]
        public virtual oci.DataOciOsManagementHubSoftwareSourceModuleStreamProfiles.DataOciOsManagementHubSoftwareSourceModuleStreamProfilesModuleStreamProfileCollectionList ModuleStreamProfileCollection
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubSoftwareSourceModuleStreamProfiles.DataOciOsManagementHubSoftwareSourceModuleStreamProfilesModuleStreamProfileCollectionList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciOsManagementHubSoftwareSourceModuleStreamProfiles.DataOciOsManagementHubSoftwareSourceModuleStreamProfilesFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        [JsiiProperty(name: "moduleNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModuleNameInput
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
        [JsiiProperty(name: "softwareSourceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SoftwareSourceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "streamNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StreamNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "moduleName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModuleName
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

        [JsiiProperty(name: "softwareSourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SoftwareSourceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "streamName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StreamName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
