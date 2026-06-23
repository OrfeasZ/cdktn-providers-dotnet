using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Volume
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume libvirt_volume}.</summary>
    [JsiiClass(nativeType: typeof(libvirt.Volume.Volume), fullyQualifiedName: "libvirt.volume.Volume", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"libvirt.volume.VolumeConfig\"}}]")]
    public class Volume : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume libvirt_volume} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Volume(Constructs.Construct scope, string id, libvirt.Volume.IVolumeConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, libvirt.Volume.IVolumeConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Volume(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Volume(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a Volume resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the Volume to import.</param>
        /// <param name="importFromId">The id of the existing Volume that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the Volume to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the Volume to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing Volume that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the Volume to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(libvirt.Volume.Volume), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putBackingStore", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.volume.VolumeBackingStore\"}}]")]
        public virtual void PutBackingStore(libvirt.Volume.IVolumeBackingStore @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Volume.IVolumeBackingStore)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCreate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.volume.VolumeCreate\"}}]")]
        public virtual void PutCreate(libvirt.Volume.IVolumeCreate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Volume.IVolumeCreate)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.volume.VolumeTarget\"}}]")]
        public virtual void PutTarget(libvirt.Volume.IVolumeTarget @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Volume.IVolumeTarget)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAllocationUnit")]
        public virtual void ResetAllocationUnit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBackingStore")]
        public virtual void ResetBackingStore()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCapacity")]
        public virtual void ResetCapacity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCapacityUnit")]
        public virtual void ResetCapacityUnit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreate")]
        public virtual void ResetCreate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPhysicalUnit")]
        public virtual void ResetPhysicalUnit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTarget")]
        public virtual void ResetTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetType")]
        public virtual void ResetType()
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
        = GetStaticProperty<string>(typeof(libvirt.Volume.Volume))!;

        [JsiiProperty(name: "allocation", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Allocation
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "backingStore", typeJson: "{\"fqn\":\"libvirt.volume.VolumeBackingStoreOutputReference\"}")]
        public virtual libvirt.Volume.VolumeBackingStoreOutputReference BackingStore
        {
            get => GetInstanceProperty<libvirt.Volume.VolumeBackingStoreOutputReference>()!;
        }

        [JsiiProperty(name: "create", typeJson: "{\"fqn\":\"libvirt.volume.VolumeCreateOutputReference\"}")]
        public virtual libvirt.Volume.VolumeCreateOutputReference Create
        {
            get => GetInstanceProperty<libvirt.Volume.VolumeCreateOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Path
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "physical", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Physical
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"libvirt.volume.VolumeTargetOutputReference\"}")]
        public virtual libvirt.Volume.VolumeTargetOutputReference Target
        {
            get => GetInstanceProperty<libvirt.Volume.VolumeTargetOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allocationUnitInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AllocationUnitInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "backingStoreInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.volume.VolumeBackingStore\"}]}}", isOptional: true)]
        public virtual object? BackingStoreInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CapacityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityUnitInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CapacityUnitInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "createInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.volume.VolumeCreate\"}]}}", isOptional: true)]
        public virtual object? CreateInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "physicalUnitInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PhysicalUnitInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "poolInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PoolInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.volume.VolumeTarget\"}]}}", isOptional: true)]
        public virtual object? TargetInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "allocationUnit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AllocationUnit
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "capacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Capacity
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "capacityUnit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CapacityUnit
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

        [JsiiProperty(name: "physicalUnit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PhysicalUnit
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pool", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Pool
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
