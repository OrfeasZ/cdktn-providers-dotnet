using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.InstancePrivateNic
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_private_nic scaleway_instance_private_nic}.</summary>
    [JsiiClass(nativeType: typeof(scaleway.InstancePrivateNic.InstancePrivateNic), fullyQualifiedName: "scaleway.instancePrivateNic.InstancePrivateNic", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"scaleway.instancePrivateNic.InstancePrivateNicConfig\"}}]")]
    public class InstancePrivateNic : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_private_nic scaleway_instance_private_nic} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public InstancePrivateNic(Constructs.Construct scope, string id, scaleway.InstancePrivateNic.IInstancePrivateNicConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, scaleway.InstancePrivateNic.IInstancePrivateNicConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected InstancePrivateNic(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected InstancePrivateNic(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a InstancePrivateNic resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the InstancePrivateNic to import.</param>
        /// <param name="importFromId">The id of the existing InstancePrivateNic that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the InstancePrivateNic to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the InstancePrivateNic to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_private_nic#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing InstancePrivateNic that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the InstancePrivateNic to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(scaleway.InstancePrivateNic.InstancePrivateNic), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putPrivateIps", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.instancePrivateNic.InstancePrivateNicPrivateIps\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPrivateIps(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case scaleway.InstancePrivateNic.IInstancePrivateNicPrivateIps[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(scaleway.InstancePrivateNic.IInstancePrivateNicPrivateIps).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(scaleway.InstancePrivateNic.IInstancePrivateNicPrivateIps).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.instancePrivateNic.InstancePrivateNicTimeouts\"}}]")]
        public virtual void PutTimeouts(scaleway.InstancePrivateNic.IInstancePrivateNicTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.InstancePrivateNic.IInstancePrivateNicTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpamIpIds")]
        public virtual void ResetIpamIpIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpIds")]
        public virtual void ResetIpIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivateIps")]
        public virtual void ResetPrivateIps()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(scaleway.InstancePrivateNic.InstancePrivateNic))!;

        [JsiiProperty(name: "macAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MacAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateIps", typeJson: "{\"fqn\":\"scaleway.instancePrivateNic.InstancePrivateNicPrivateIpsList\"}")]
        public virtual scaleway.InstancePrivateNic.InstancePrivateNicPrivateIpsList PrivateIps
        {
            get => GetInstanceProperty<scaleway.InstancePrivateNic.InstancePrivateNicPrivateIpsList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.instancePrivateNic.InstancePrivateNicTimeoutsOutputReference\"}")]
        public virtual scaleway.InstancePrivateNic.InstancePrivateNicTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<scaleway.InstancePrivateNic.InstancePrivateNicTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipamIpIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? IpamIpIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? IpIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateIpsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.instancePrivateNic.InstancePrivateNicPrivateIps\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PrivateIpsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateNetworkIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrivateNetworkIdInput
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
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TagsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"scaleway.instancePrivateNic.InstancePrivateNicTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
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

        [JsiiProperty(name: "ipamIpIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IpamIpIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ipIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IpIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "privateNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateNetworkId
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

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tags
        {
            get => GetInstanceProperty<string[]>()!;
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
