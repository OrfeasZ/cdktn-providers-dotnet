using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayInstanceServerType
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/data-sources/instance_server_type scaleway_instance_server_type}.</summary>
    [JsiiClass(nativeType: typeof(scaleway.DataScalewayInstanceServerType.DataScalewayInstanceServerType), fullyQualifiedName: "scaleway.dataScalewayInstanceServerType.DataScalewayInstanceServerType", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"scaleway.dataScalewayInstanceServerType.DataScalewayInstanceServerTypeConfig\"}}]")]
    public class DataScalewayInstanceServerType : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/data-sources/instance_server_type scaleway_instance_server_type} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataScalewayInstanceServerType(Constructs.Construct scope, string id, scaleway.DataScalewayInstanceServerType.IDataScalewayInstanceServerTypeConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, scaleway.DataScalewayInstanceServerType.IDataScalewayInstanceServerTypeConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayInstanceServerType(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayInstanceServerType(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataScalewayInstanceServerType resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataScalewayInstanceServerType to import.</param>
        /// <param name="importFromId">The id of the existing DataScalewayInstanceServerType that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataScalewayInstanceServerType to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataScalewayInstanceServerType to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/data-sources/instance_server_type#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataScalewayInstanceServerType that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataScalewayInstanceServerType to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(scaleway.DataScalewayInstanceServerType.DataScalewayInstanceServerType), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetZone")]
        public virtual void ResetZone()
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
        = GetStaticProperty<string>(typeof(scaleway.DataScalewayInstanceServerType.DataScalewayInstanceServerType))!;

        [JsiiProperty(name: "arch", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arch
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "availability", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Availability
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "capabilities", typeJson: "{\"fqn\":\"scaleway.dataScalewayInstanceServerType.DataScalewayInstanceServerTypeCapabilitiesList\"}")]
        public virtual scaleway.DataScalewayInstanceServerType.DataScalewayInstanceServerTypeCapabilitiesList Capabilities
        {
            get => GetInstanceProperty<scaleway.DataScalewayInstanceServerType.DataScalewayInstanceServerTypeCapabilitiesList>()!;
        }

        [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Cpu
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "endOfService", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EndOfService
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "gpu", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Gpu
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "hourlyPrice", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HourlyPrice
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"scaleway.dataScalewayInstanceServerType.DataScalewayInstanceServerTypeNetworkList\"}")]
        public virtual scaleway.DataScalewayInstanceServerType.DataScalewayInstanceServerTypeNetworkList Network
        {
            get => GetInstanceProperty<scaleway.DataScalewayInstanceServerType.DataScalewayInstanceServerTypeNetworkList>()!;
        }

        [JsiiProperty(name: "ram", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Ram
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "volumes", typeJson: "{\"fqn\":\"scaleway.dataScalewayInstanceServerType.DataScalewayInstanceServerTypeVolumesList\"}")]
        public virtual scaleway.DataScalewayInstanceServerType.DataScalewayInstanceServerTypeVolumesList Volumes
        {
            get => GetInstanceProperty<scaleway.DataScalewayInstanceServerType.DataScalewayInstanceServerTypeVolumesList>()!;
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
        [JsiiProperty(name: "zoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ZoneInput
        {
            get => GetInstanceProperty<string?>();
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

        [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Zone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
