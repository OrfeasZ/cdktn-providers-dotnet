using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool libvirt_pool}.</summary>
    [JsiiClass(nativeType: typeof(libvirt.Pool.Pool), fullyQualifiedName: "libvirt.pool.Pool", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"libvirt.pool.PoolConfig\"}}]")]
    public class Pool : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool libvirt_pool} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Pool(Constructs.Construct scope, string id, libvirt.Pool.IPoolConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, libvirt.Pool.IPoolConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Pool(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Pool(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a Pool resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the Pool to import.</param>
        /// <param name="importFromId">The id of the existing Pool that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the Pool to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the Pool to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing Pool that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the Pool to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(libvirt.Pool.Pool), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCreate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.pool.PoolCreate\"}}]")]
        public virtual void PutCreate(libvirt.Pool.IPoolCreate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Pool.IPoolCreate)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDestroy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.pool.PoolDestroy\"}}]")]
        public virtual void PutDestroy(libvirt.Pool.IPoolDestroy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Pool.IPoolDestroy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFeatures", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.pool.PoolFeatures\"}}]")]
        public virtual void PutFeatures(libvirt.Pool.IPoolFeatures @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Pool.IPoolFeatures)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFsCommandline", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.pool.PoolFsCommandline\"}}]")]
        public virtual void PutFsCommandline(libvirt.Pool.IPoolFsCommandline @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Pool.IPoolFsCommandline)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRbdCommandline", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.pool.PoolRbdCommandline\"}}]")]
        public virtual void PutRbdCommandline(libvirt.Pool.IPoolRbdCommandline @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Pool.IPoolRbdCommandline)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRefresh", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.pool.PoolRefresh\"}}]")]
        public virtual void PutRefresh(libvirt.Pool.IPoolRefresh @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Pool.IPoolRefresh)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.pool.PoolSource\"}}]")]
        public virtual void PutSource(libvirt.Pool.IPoolSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Pool.IPoolSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.pool.PoolTarget\"}}]")]
        public virtual void PutTarget(libvirt.Pool.IPoolTarget @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Pool.IPoolTarget)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAllocationUnit")]
        public virtual void ResetAllocationUnit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAvailableUnit")]
        public virtual void ResetAvailableUnit()
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

        [JsiiMethod(name: "resetDestroy")]
        public virtual void ResetDestroy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFeatures")]
        public virtual void ResetFeatures()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFsCommandline")]
        public virtual void ResetFsCommandline()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRbdCommandline")]
        public virtual void ResetRbdCommandline()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRefresh")]
        public virtual void ResetRefresh()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSource")]
        public virtual void ResetSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTarget")]
        public virtual void ResetTarget()
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
        = GetStaticProperty<string>(typeof(libvirt.Pool.Pool))!;

        [JsiiProperty(name: "allocation", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Allocation
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "available", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Available
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "capacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Capacity
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "create", typeJson: "{\"fqn\":\"libvirt.pool.PoolCreateOutputReference\"}")]
        public virtual libvirt.Pool.PoolCreateOutputReference Create
        {
            get => GetInstanceProperty<libvirt.Pool.PoolCreateOutputReference>()!;
        }

        [JsiiProperty(name: "destroy", typeJson: "{\"fqn\":\"libvirt.pool.PoolDestroyOutputReference\"}")]
        public virtual libvirt.Pool.PoolDestroyOutputReference Destroy
        {
            get => GetInstanceProperty<libvirt.Pool.PoolDestroyOutputReference>()!;
        }

        [JsiiProperty(name: "features", typeJson: "{\"fqn\":\"libvirt.pool.PoolFeaturesOutputReference\"}")]
        public virtual libvirt.Pool.PoolFeaturesOutputReference Features
        {
            get => GetInstanceProperty<libvirt.Pool.PoolFeaturesOutputReference>()!;
        }

        [JsiiProperty(name: "fsCommandline", typeJson: "{\"fqn\":\"libvirt.pool.PoolFsCommandlineOutputReference\"}")]
        public virtual libvirt.Pool.PoolFsCommandlineOutputReference FsCommandline
        {
            get => GetInstanceProperty<libvirt.Pool.PoolFsCommandlineOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rbdCommandline", typeJson: "{\"fqn\":\"libvirt.pool.PoolRbdCommandlineOutputReference\"}")]
        public virtual libvirt.Pool.PoolRbdCommandlineOutputReference RbdCommandline
        {
            get => GetInstanceProperty<libvirt.Pool.PoolRbdCommandlineOutputReference>()!;
        }

        [JsiiProperty(name: "refresh", typeJson: "{\"fqn\":\"libvirt.pool.PoolRefreshOutputReference\"}")]
        public virtual libvirt.Pool.PoolRefreshOutputReference Refresh
        {
            get => GetInstanceProperty<libvirt.Pool.PoolRefreshOutputReference>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.pool.PoolSourceOutputReference\"}")]
        public virtual libvirt.Pool.PoolSourceOutputReference Source
        {
            get => GetInstanceProperty<libvirt.Pool.PoolSourceOutputReference>()!;
        }

        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"libvirt.pool.PoolTargetOutputReference\"}")]
        public virtual libvirt.Pool.PoolTargetOutputReference Target
        {
            get => GetInstanceProperty<libvirt.Pool.PoolTargetOutputReference>()!;
        }

        [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Uuid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allocationUnitInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AllocationUnitInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "availableUnitInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AvailableUnitInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityUnitInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CapacityUnitInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "createInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.pool.PoolCreate\"}]}}", isOptional: true)]
        public virtual object? CreateInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "destroyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.pool.PoolDestroy\"}]}}", isOptional: true)]
        public virtual object? DestroyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "featuresInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.pool.PoolFeatures\"}]}}", isOptional: true)]
        public virtual object? FeaturesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fsCommandlineInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.pool.PoolFsCommandline\"}]}}", isOptional: true)]
        public virtual object? FsCommandlineInput
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
        [JsiiProperty(name: "rbdCommandlineInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.pool.PoolRbdCommandline\"}]}}", isOptional: true)]
        public virtual object? RbdCommandlineInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "refreshInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.pool.PoolRefresh\"}]}}", isOptional: true)]
        public virtual object? RefreshInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.pool.PoolSource\"}]}}", isOptional: true)]
        public virtual object? SourceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.pool.PoolTarget\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "availableUnit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailableUnit
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
