using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNetappVolumeBucket
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/netapp_volume_bucket azurerm_netapp_volume_bucket}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermNetappVolumeBucket.DataAzurermNetappVolumeBucket), fullyQualifiedName: "azurerm.dataAzurermNetappVolumeBucket.DataAzurermNetappVolumeBucket", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermNetappVolumeBucket.DataAzurermNetappVolumeBucketConfig\"}}]")]
    public class DataAzurermNetappVolumeBucket : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/netapp_volume_bucket azurerm_netapp_volume_bucket} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermNetappVolumeBucket(Constructs.Construct scope, string id, azurerm.DataAzurermNetappVolumeBucket.IDataAzurermNetappVolumeBucketConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermNetappVolumeBucket.IDataAzurermNetappVolumeBucketConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermNetappVolumeBucket(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermNetappVolumeBucket(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAzurermNetappVolumeBucket resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermNetappVolumeBucket to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermNetappVolumeBucket that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermNetappVolumeBucket to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermNetappVolumeBucket to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/netapp_volume_bucket#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermNetappVolumeBucket that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermNetappVolumeBucket to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.DataAzurermNetappVolumeBucket.DataAzurermNetappVolumeBucket), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermNetappVolumeBucket.DataAzurermNetappVolumeBucketTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermNetappVolumeBucket.IDataAzurermNetappVolumeBucketTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermNetappVolumeBucket.IDataAzurermNetappVolumeBucketTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermNetappVolumeBucket.DataAzurermNetappVolumeBucket))!;

        [JsiiProperty(name: "fileSystemCifsUsername", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FileSystemCifsUsername
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fileSystemNfsUser", typeJson: "{\"fqn\":\"azurerm.dataAzurermNetappVolumeBucket.DataAzurermNetappVolumeBucketFileSystemNfsUserList\"}")]
        public virtual azurerm.DataAzurermNetappVolumeBucket.DataAzurermNetappVolumeBucketFileSystemNfsUserList FileSystemNfsUser
        {
            get => GetInstanceProperty<azurerm.DataAzurermNetappVolumeBucket.DataAzurermNetappVolumeBucketFileSystemNfsUserList>()!;
        }

        [JsiiProperty(name: "keyVault", typeJson: "{\"fqn\":\"azurerm.dataAzurermNetappVolumeBucket.DataAzurermNetappVolumeBucketKeyVaultList\"}")]
        public virtual azurerm.DataAzurermNetappVolumeBucket.DataAzurermNetappVolumeBucketKeyVaultList KeyVault
        {
            get => GetInstanceProperty<azurerm.DataAzurermNetappVolumeBucket.DataAzurermNetappVolumeBucketKeyVaultList>()!;
        }

        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Path
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "permissions", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Permissions
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermNetappVolumeBucket.DataAzurermNetappVolumeBucketTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermNetappVolumeBucket.DataAzurermNetappVolumeBucketTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermNetappVolumeBucket.DataAzurermNetappVolumeBucketTimeoutsOutputReference>()!;
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
        [JsiiProperty(name: "netappVolumeIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NetappVolumeIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.DataAzurermNetappVolumeBucket.IDataAzurermNetappVolumeBucketTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermNetappVolumeBucket.DataAzurermNetappVolumeBucketTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
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

        [JsiiProperty(name: "netappVolumeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetappVolumeId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
