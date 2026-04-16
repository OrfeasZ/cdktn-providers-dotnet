using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.DataHcloudStorageBox
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/data-sources/storage_box hcloud_storage_box}.</summary>
    [JsiiClass(nativeType: typeof(hcloud.DataHcloudStorageBox.DataHcloudStorageBox), fullyQualifiedName: "hcloud.dataHcloudStorageBox.DataHcloudStorageBox", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"hcloud.dataHcloudStorageBox.DataHcloudStorageBoxConfig\"}}]")]
    public class DataHcloudStorageBox : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/data-sources/storage_box hcloud_storage_box} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataHcloudStorageBox(Constructs.Construct scope, string id, hcloud.DataHcloudStorageBox.IDataHcloudStorageBoxConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, hcloud.DataHcloudStorageBox.IDataHcloudStorageBoxConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataHcloudStorageBox(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataHcloudStorageBox(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataHcloudStorageBox resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataHcloudStorageBox to import.</param>
        /// <param name="importFromId">The id of the existing DataHcloudStorageBox that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataHcloudStorageBox to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataHcloudStorageBox to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/data-sources/storage_box#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataHcloudStorageBox that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataHcloudStorageBox to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(hcloud.DataHcloudStorageBox.DataHcloudStorageBox), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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

        [JsiiMethod(name: "resetWithSelector")]
        public virtual void ResetWithSelector()
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
        = GetStaticProperty<string>(typeof(hcloud.DataHcloudStorageBox.DataHcloudStorageBox))!;

        [JsiiProperty(name: "accessSettings", typeJson: "{\"fqn\":\"hcloud.dataHcloudStorageBox.DataHcloudStorageBoxAccessSettingsOutputReference\"}")]
        public virtual hcloud.DataHcloudStorageBox.DataHcloudStorageBoxAccessSettingsOutputReference AccessSettings
        {
            get => GetInstanceProperty<hcloud.DataHcloudStorageBox.DataHcloudStorageBoxAccessSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "deleteProtection", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DeleteProtection
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
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

        [JsiiProperty(name: "server", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Server
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "snapshotPlan", typeJson: "{\"fqn\":\"hcloud.dataHcloudStorageBox.DataHcloudStorageBoxSnapshotPlanOutputReference\"}")]
        public virtual hcloud.DataHcloudStorageBox.DataHcloudStorageBoxSnapshotPlanOutputReference SnapshotPlan
        {
            get => GetInstanceProperty<hcloud.DataHcloudStorageBox.DataHcloudStorageBoxSnapshotPlanOutputReference>()!;
        }

        [JsiiProperty(name: "storageBoxType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageBoxType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemAttribute", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SystemAttribute
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Username
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
        [JsiiProperty(name: "withSelectorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WithSelectorInput
        {
            get => GetInstanceProperty<string?>();
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

        [JsiiProperty(name: "withSelector", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WithSelector
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
