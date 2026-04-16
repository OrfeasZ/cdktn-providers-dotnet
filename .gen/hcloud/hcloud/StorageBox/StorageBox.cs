using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.StorageBox
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/resources/storage_box hcloud_storage_box}.</summary>
    [JsiiClass(nativeType: typeof(hcloud.StorageBox.StorageBox), fullyQualifiedName: "hcloud.storageBox.StorageBox", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"hcloud.storageBox.StorageBoxConfig\"}}]")]
    public class StorageBox : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/resources/storage_box hcloud_storage_box} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public StorageBox(Constructs.Construct scope, string id, hcloud.StorageBox.IStorageBoxConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, hcloud.StorageBox.IStorageBoxConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StorageBox(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StorageBox(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a StorageBox resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the StorageBox to import.</param>
        /// <param name="importFromId">The id of the existing StorageBox that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the StorageBox to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the StorageBox to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/resources/storage_box#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing StorageBox that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the StorageBox to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(hcloud.StorageBox.StorageBox), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAccessSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"hcloud.storageBox.StorageBoxAccessSettings\"}}]")]
        public virtual void PutAccessSettings(hcloud.StorageBox.IStorageBoxAccessSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(hcloud.StorageBox.IStorageBoxAccessSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSnapshotPlan", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"hcloud.storageBox.StorageBoxSnapshotPlan\"}}]")]
        public virtual void PutSnapshotPlan(hcloud.StorageBox.IStorageBoxSnapshotPlan @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(hcloud.StorageBox.IStorageBoxSnapshotPlan)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccessSettings")]
        public virtual void ResetAccessSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeleteProtection")]
        public virtual void ResetDeleteProtection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLabels")]
        public virtual void ResetLabels()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSnapshotPlan")]
        public virtual void ResetSnapshotPlan()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSshKeys")]
        public virtual void ResetSshKeys()
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
        = GetStaticProperty<string>(typeof(hcloud.StorageBox.StorageBox))!;

        [JsiiProperty(name: "accessSettings", typeJson: "{\"fqn\":\"hcloud.storageBox.StorageBoxAccessSettingsOutputReference\"}")]
        public virtual hcloud.StorageBox.StorageBoxAccessSettingsOutputReference AccessSettings
        {
            get => GetInstanceProperty<hcloud.StorageBox.StorageBoxAccessSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Id
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "server", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Server
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "snapshotPlan", typeJson: "{\"fqn\":\"hcloud.storageBox.StorageBoxSnapshotPlanOutputReference\"}")]
        public virtual hcloud.StorageBox.StorageBoxSnapshotPlanOutputReference SnapshotPlan
        {
            get => GetInstanceProperty<hcloud.StorageBox.StorageBoxSnapshotPlanOutputReference>()!;
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
        [JsiiProperty(name: "accessSettingsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"hcloud.storageBox.StorageBoxAccessSettings\"}]}}", isOptional: true)]
        public virtual object? AccessSettingsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deleteProtectionInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DeleteProtectionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "labelsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? LabelsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocationInput
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
        [JsiiProperty(name: "passwordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snapshotPlanInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"hcloud.storageBox.StorageBoxSnapshotPlan\"}]}}", isOptional: true)]
        public virtual object? SnapshotPlanInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sshKeysInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SshKeysInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageBoxTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StorageBoxTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "deleteProtection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object DeleteProtection
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
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

        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Password
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sshKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SshKeys
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storageBoxType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageBoxType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
