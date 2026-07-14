using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappVolumeBucketWithServer
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/netapp_volume_bucket_with_server azurerm_netapp_volume_bucket_with_server}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.NetappVolumeBucketWithServer.NetappVolumeBucketWithServer), fullyQualifiedName: "azurerm.netappVolumeBucketWithServer.NetappVolumeBucketWithServer", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.netappVolumeBucketWithServer.NetappVolumeBucketWithServerConfig\"}}]")]
    public class NetappVolumeBucketWithServer : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/netapp_volume_bucket_with_server azurerm_netapp_volume_bucket_with_server} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public NetappVolumeBucketWithServer(Constructs.Construct scope, string id, azurerm.NetappVolumeBucketWithServer.INetappVolumeBucketWithServerConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.NetappVolumeBucketWithServer.INetappVolumeBucketWithServerConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetappVolumeBucketWithServer(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetappVolumeBucketWithServer(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a NetappVolumeBucketWithServer resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the NetappVolumeBucketWithServer to import.</param>
        /// <param name="importFromId">The id of the existing NetappVolumeBucketWithServer that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the NetappVolumeBucketWithServer to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the NetappVolumeBucketWithServer to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/netapp_volume_bucket_with_server#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing NetappVolumeBucketWithServer that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the NetappVolumeBucketWithServer to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.NetappVolumeBucketWithServer.NetappVolumeBucketWithServer), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putFileSystemNfsUser", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.netappVolumeBucketWithServer.NetappVolumeBucketWithServerFileSystemNfsUser\"}}]")]
        public virtual void PutFileSystemNfsUser(azurerm.NetappVolumeBucketWithServer.INetappVolumeBucketWithServerFileSystemNfsUser @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NetappVolumeBucketWithServer.INetappVolumeBucketWithServerFileSystemNfsUser)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKeyVault", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.netappVolumeBucketWithServer.NetappVolumeBucketWithServerKeyVault\"}}]")]
        public virtual void PutKeyVault(azurerm.NetappVolumeBucketWithServer.INetappVolumeBucketWithServerKeyVault @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NetappVolumeBucketWithServer.INetappVolumeBucketWithServerKeyVault)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServer", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.netappVolumeBucketWithServer.NetappVolumeBucketWithServerServer\"}}]")]
        public virtual void PutServer(azurerm.NetappVolumeBucketWithServer.INetappVolumeBucketWithServerServer @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NetappVolumeBucketWithServer.INetappVolumeBucketWithServerServer)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.netappVolumeBucketWithServer.NetappVolumeBucketWithServerTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.NetappVolumeBucketWithServer.INetappVolumeBucketWithServerTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NetappVolumeBucketWithServer.INetappVolumeBucketWithServerTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFileSystemCifsUsername")]
        public virtual void ResetFileSystemCifsUsername()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFileSystemNfsUser")]
        public virtual void ResetFileSystemNfsUser()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKeyVault")]
        public virtual void ResetKeyVault()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPath")]
        public virtual void ResetPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPermissions")]
        public virtual void ResetPermissions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(azurerm.NetappVolumeBucketWithServer.NetappVolumeBucketWithServer))!;

        [JsiiProperty(name: "fileSystemNfsUser", typeJson: "{\"fqn\":\"azurerm.netappVolumeBucketWithServer.NetappVolumeBucketWithServerFileSystemNfsUserOutputReference\"}")]
        public virtual azurerm.NetappVolumeBucketWithServer.NetappVolumeBucketWithServerFileSystemNfsUserOutputReference FileSystemNfsUser
        {
            get => GetInstanceProperty<azurerm.NetappVolumeBucketWithServer.NetappVolumeBucketWithServerFileSystemNfsUserOutputReference>()!;
        }

        [JsiiProperty(name: "keyVault", typeJson: "{\"fqn\":\"azurerm.netappVolumeBucketWithServer.NetappVolumeBucketWithServerKeyVaultOutputReference\"}")]
        public virtual azurerm.NetappVolumeBucketWithServer.NetappVolumeBucketWithServerKeyVaultOutputReference KeyVault
        {
            get => GetInstanceProperty<azurerm.NetappVolumeBucketWithServer.NetappVolumeBucketWithServerKeyVaultOutputReference>()!;
        }

        [JsiiProperty(name: "server", typeJson: "{\"fqn\":\"azurerm.netappVolumeBucketWithServer.NetappVolumeBucketWithServerServerOutputReference\"}")]
        public virtual azurerm.NetappVolumeBucketWithServer.NetappVolumeBucketWithServerServerOutputReference Server
        {
            get => GetInstanceProperty<azurerm.NetappVolumeBucketWithServer.NetappVolumeBucketWithServerServerOutputReference>()!;
        }

        [JsiiProperty(name: "serverCertificateCommonName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServerCertificateCommonName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serverCertificateExpiryDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServerCertificateExpiryDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serverIpAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServerIpAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.netappVolumeBucketWithServer.NetappVolumeBucketWithServerTimeoutsOutputReference\"}")]
        public virtual azurerm.NetappVolumeBucketWithServer.NetappVolumeBucketWithServerTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.NetappVolumeBucketWithServer.NetappVolumeBucketWithServerTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileSystemCifsUsernameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FileSystemCifsUsernameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileSystemNfsUserInput", typeJson: "{\"fqn\":\"azurerm.netappVolumeBucketWithServer.NetappVolumeBucketWithServerFileSystemNfsUser\"}", isOptional: true)]
        public virtual azurerm.NetappVolumeBucketWithServer.INetappVolumeBucketWithServerFileSystemNfsUser? FileSystemNfsUserInput
        {
            get => GetInstanceProperty<azurerm.NetappVolumeBucketWithServer.INetappVolumeBucketWithServerFileSystemNfsUser?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyVaultInput", typeJson: "{\"fqn\":\"azurerm.netappVolumeBucketWithServer.NetappVolumeBucketWithServerKeyVault\"}", isOptional: true)]
        public virtual azurerm.NetappVolumeBucketWithServer.INetappVolumeBucketWithServerKeyVault? KeyVaultInput
        {
            get => GetInstanceProperty<azurerm.NetappVolumeBucketWithServer.INetappVolumeBucketWithServerKeyVault?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "permissionsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PermissionsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverInput", typeJson: "{\"fqn\":\"azurerm.netappVolumeBucketWithServer.NetappVolumeBucketWithServerServer\"}", isOptional: true)]
        public virtual azurerm.NetappVolumeBucketWithServer.INetappVolumeBucketWithServerServer? ServerInput
        {
            get => GetInstanceProperty<azurerm.NetappVolumeBucketWithServer.INetappVolumeBucketWithServerServer?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.NetappVolumeBucketWithServer.INetappVolumeBucketWithServerTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.netappVolumeBucketWithServer.NetappVolumeBucketWithServerTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "volumeIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VolumeIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "fileSystemCifsUsername", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FileSystemCifsUsername
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Path
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "permissions", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Permissions
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "volumeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VolumeId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
