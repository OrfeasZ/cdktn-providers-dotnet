using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.DataHcloudServer
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/data-sources/server hcloud_server}.</summary>
    [JsiiClass(nativeType: typeof(hcloud.DataHcloudServer.DataHcloudServer), fullyQualifiedName: "hcloud.dataHcloudServer.DataHcloudServer", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"hcloud.dataHcloudServer.DataHcloudServerConfig\"}}]")]
    public class DataHcloudServer : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/data-sources/server hcloud_server} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataHcloudServer(Constructs.Construct scope, string id, hcloud.DataHcloudServer.IDataHcloudServerConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, hcloud.DataHcloudServer.IDataHcloudServerConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataHcloudServer(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataHcloudServer(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataHcloudServer resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataHcloudServer to import.</param>
        /// <param name="importFromId">The id of the existing DataHcloudServer that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataHcloudServer to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataHcloudServer to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/data-sources/server#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataHcloudServer that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataHcloudServer to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(hcloud.DataHcloudServer.DataHcloudServer), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putNetwork", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"hcloud.dataHcloudServer.DataHcloudServerNetwork\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNetwork(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case hcloud.DataHcloudServer.IDataHcloudServerNetwork[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(hcloud.DataHcloudServer.IDataHcloudServerNetwork).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(hcloud.DataHcloudServer.IDataHcloudServerNetwork).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
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

        [JsiiMethod(name: "resetNetwork")]
        public virtual void ResetNetwork()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlacementGroupId")]
        public virtual void ResetPlacementGroupId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSelector")]
        public virtual void ResetSelector()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWithSelector")]
        public virtual void ResetWithSelector()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWithStatus")]
        public virtual void ResetWithStatus()
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
        = GetStaticProperty<string>(typeof(hcloud.DataHcloudServer.DataHcloudServer))!;

        [JsiiProperty(name: "backups", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Backups
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "backupWindow", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupWindow
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "datacenter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Datacenter
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deleteProtection", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DeleteProtection
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "firewallIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] FirewallIds
        {
            get => GetInstanceProperty<double[]>()!;
        }

        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Image
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipv4Address", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ipv4Address
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipv6Address", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ipv6Address
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipv6Network", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ipv6Network
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "iso", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Iso
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "labels", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Labels
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"hcloud.dataHcloudServer.DataHcloudServerNetworkList\"}")]
        public virtual hcloud.DataHcloudServer.DataHcloudServerNetworkList Network
        {
            get => GetInstanceProperty<hcloud.DataHcloudServer.DataHcloudServerNetworkList>()!;
        }

        [JsiiProperty(name: "primaryDiskSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PrimaryDiskSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "rebuildProtection", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable RebuildProtection
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "rescue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Rescue
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serverType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServerType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? IdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"hcloud.dataHcloudServer.DataHcloudServerNetwork\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NetworkInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "placementGroupIdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PlacementGroupIdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "selectorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SelectorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "withSelectorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WithSelectorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "withStatusInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? WithStatusInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Id
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "placementGroupId", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PlacementGroupId
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "selector", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Selector
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "withSelector", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WithSelector
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "withStatus", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] WithStatus
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
