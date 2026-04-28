using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayBaremetalServer
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/data-sources/baremetal_server scaleway_baremetal_server}.</summary>
    [JsiiClass(nativeType: typeof(scaleway.DataScalewayBaremetalServer.DataScalewayBaremetalServer), fullyQualifiedName: "scaleway.dataScalewayBaremetalServer.DataScalewayBaremetalServer", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"scaleway.dataScalewayBaremetalServer.DataScalewayBaremetalServerConfig\"}}]")]
    public class DataScalewayBaremetalServer : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/data-sources/baremetal_server scaleway_baremetal_server} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataScalewayBaremetalServer(Constructs.Construct scope, string id, scaleway.DataScalewayBaremetalServer.IDataScalewayBaremetalServerConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, scaleway.DataScalewayBaremetalServer.IDataScalewayBaremetalServerConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayBaremetalServer(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayBaremetalServer(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataScalewayBaremetalServer resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataScalewayBaremetalServer to import.</param>
        /// <param name="importFromId">The id of the existing DataScalewayBaremetalServer that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataScalewayBaremetalServer to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataScalewayBaremetalServer to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/data-sources/baremetal_server#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataScalewayBaremetalServer that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataScalewayBaremetalServer to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(scaleway.DataScalewayBaremetalServer.DataScalewayBaremetalServer), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProjectId")]
        public virtual void ResetProjectId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServerId")]
        public virtual void ResetServerId()
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
        = GetStaticProperty<string>(typeof(scaleway.DataScalewayBaremetalServer.DataScalewayBaremetalServer))!;

        [JsiiProperty(name: "cloudInit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudInit
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Domain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Hostname
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "installConfigAfterward", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable InstallConfigAfterward
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "ips", typeJson: "{\"fqn\":\"scaleway.dataScalewayBaremetalServer.DataScalewayBaremetalServerIpsList\"}")]
        public virtual scaleway.DataScalewayBaremetalServer.DataScalewayBaremetalServerIpsList Ips
        {
            get => GetInstanceProperty<scaleway.DataScalewayBaremetalServer.DataScalewayBaremetalServerIpsList>()!;
        }

        [JsiiProperty(name: "ipv4", typeJson: "{\"fqn\":\"scaleway.dataScalewayBaremetalServer.DataScalewayBaremetalServerIpv4List\"}")]
        public virtual scaleway.DataScalewayBaremetalServer.DataScalewayBaremetalServerIpv4List Ipv4
        {
            get => GetInstanceProperty<scaleway.DataScalewayBaremetalServer.DataScalewayBaremetalServerIpv4List>()!;
        }

        [JsiiProperty(name: "ipv6", typeJson: "{\"fqn\":\"scaleway.dataScalewayBaremetalServer.DataScalewayBaremetalServerIpv6List\"}")]
        public virtual scaleway.DataScalewayBaremetalServer.DataScalewayBaremetalServerIpv6List Ipv6
        {
            get => GetInstanceProperty<scaleway.DataScalewayBaremetalServer.DataScalewayBaremetalServerIpv6List>()!;
        }

        [JsiiProperty(name: "offer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Offer
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "offerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OfferId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "offerName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OfferName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "options", typeJson: "{\"fqn\":\"scaleway.dataScalewayBaremetalServer.DataScalewayBaremetalServerOptionsList\"}")]
        public virtual scaleway.DataScalewayBaremetalServer.DataScalewayBaremetalServerOptionsList Options
        {
            get => GetInstanceProperty<scaleway.DataScalewayBaremetalServer.DataScalewayBaremetalServerOptionsList>()!;
        }

        [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OrganizationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "os", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Os
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "osName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OsName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "partitioning", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Partitioning
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Password
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "passwordWo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PasswordWo
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "passwordWoVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PasswordWoVersion
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "privateIps", typeJson: "{\"fqn\":\"scaleway.dataScalewayBaremetalServer.DataScalewayBaremetalServerPrivateIpsList\"}")]
        public virtual scaleway.DataScalewayBaremetalServer.DataScalewayBaremetalServerPrivateIpsList PrivateIps
        {
            get => GetInstanceProperty<scaleway.DataScalewayBaremetalServer.DataScalewayBaremetalServerPrivateIpsList>()!;
        }

        [JsiiProperty(name: "privateNetwork", typeJson: "{\"fqn\":\"scaleway.dataScalewayBaremetalServer.DataScalewayBaremetalServerPrivateNetworkList\"}")]
        public virtual scaleway.DataScalewayBaremetalServer.DataScalewayBaremetalServerPrivateNetworkList PrivateNetwork
        {
            get => GetInstanceProperty<scaleway.DataScalewayBaremetalServer.DataScalewayBaremetalServerPrivateNetworkList>()!;
        }

        [JsiiProperty(name: "protected", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Protected
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "reinstallOnConfigChanges", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ReinstallOnConfigChanges
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "servicePassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServicePassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "servicePasswordWo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServicePasswordWo
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "servicePasswordWoVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ServicePasswordWoVersion
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "serviceUser", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceUser
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sshKeyIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SshKeyIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tags
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "user", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string User
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
        [JsiiProperty(name: "projectIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProjectIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServerIdInput
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

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serverId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServerId
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
