using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.LoadBalancerPool
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/load_balancer_pool cloudflare_load_balancer_pool}.</summary>
    [JsiiClass(nativeType: typeof(cloudflare.LoadBalancerPool.LoadBalancerPool), fullyQualifiedName: "cloudflare.loadBalancerPool.LoadBalancerPool", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolConfig\"}}]")]
    public class LoadBalancerPool : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/load_balancer_pool cloudflare_load_balancer_pool} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LoadBalancerPool(Constructs.Construct scope, string id, cloudflare.LoadBalancerPool.ILoadBalancerPoolConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, cloudflare.LoadBalancerPool.ILoadBalancerPoolConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LoadBalancerPool(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LoadBalancerPool(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a LoadBalancerPool resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the LoadBalancerPool to import.</param>
        /// <param name="importFromId">The id of the existing LoadBalancerPool that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the LoadBalancerPool to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the LoadBalancerPool to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/load_balancer_pool#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing LoadBalancerPool that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the LoadBalancerPool to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(cloudflare.LoadBalancerPool.LoadBalancerPool), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putLoadShedding", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolLoadShedding\"}}]")]
        public virtual void PutLoadShedding(cloudflare.LoadBalancerPool.ILoadBalancerPoolLoadShedding @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.LoadBalancerPool.ILoadBalancerPoolLoadShedding)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNotificationFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolNotificationFilter\"}}]")]
        public virtual void PutNotificationFilter(cloudflare.LoadBalancerPool.ILoadBalancerPoolNotificationFilter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.LoadBalancerPool.ILoadBalancerPoolNotificationFilter)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOrigins", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolOrigins\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutOrigins(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case cloudflare.LoadBalancerPool.ILoadBalancerPoolOrigins[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.LoadBalancerPool.ILoadBalancerPoolOrigins).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.LoadBalancerPool.ILoadBalancerPoolOrigins).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOriginSteering", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolOriginSteering\"}}]")]
        public virtual void PutOriginSteering(cloudflare.LoadBalancerPool.ILoadBalancerPoolOriginSteering @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.LoadBalancerPool.ILoadBalancerPoolOriginSteering)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccountId")]
        public virtual void ResetAccountId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCheckRegions")]
        public virtual void ResetCheckRegions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnabled")]
        public virtual void ResetEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLatitude")]
        public virtual void ResetLatitude()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoadShedding")]
        public virtual void ResetLoadShedding()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLongitude")]
        public virtual void ResetLongitude()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinimumOrigins")]
        public virtual void ResetMinimumOrigins()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMonitor")]
        public virtual void ResetMonitor()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMonitorGroup")]
        public virtual void ResetMonitorGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNotificationEmail")]
        public virtual void ResetNotificationEmail()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNotificationFilter")]
        public virtual void ResetNotificationFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOriginSteering")]
        public virtual void ResetOriginSteering()
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
        = GetStaticProperty<string>(typeof(cloudflare.LoadBalancerPool.LoadBalancerPool))!;

        [JsiiProperty(name: "createdOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "disabledAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisabledAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "loadShedding", typeJson: "{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolLoadSheddingOutputReference\"}")]
        public virtual cloudflare.LoadBalancerPool.LoadBalancerPoolLoadSheddingOutputReference LoadShedding
        {
            get => GetInstanceProperty<cloudflare.LoadBalancerPool.LoadBalancerPoolLoadSheddingOutputReference>()!;
        }

        [JsiiProperty(name: "modifiedOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModifiedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networks", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Networks
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "notificationFilter", typeJson: "{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolNotificationFilterOutputReference\"}")]
        public virtual cloudflare.LoadBalancerPool.LoadBalancerPoolNotificationFilterOutputReference NotificationFilter
        {
            get => GetInstanceProperty<cloudflare.LoadBalancerPool.LoadBalancerPoolNotificationFilterOutputReference>()!;
        }

        [JsiiProperty(name: "origins", typeJson: "{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolOriginsList\"}")]
        public virtual cloudflare.LoadBalancerPool.LoadBalancerPoolOriginsList Origins
        {
            get => GetInstanceProperty<cloudflare.LoadBalancerPool.LoadBalancerPoolOriginsList>()!;
        }

        [JsiiProperty(name: "originSteering", typeJson: "{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolOriginSteeringOutputReference\"}")]
        public virtual cloudflare.LoadBalancerPool.LoadBalancerPoolOriginSteeringOutputReference OriginSteering
        {
            get => GetInstanceProperty<cloudflare.LoadBalancerPool.LoadBalancerPoolOriginSteeringOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "checkRegionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? CheckRegionsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "latitudeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? LatitudeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loadSheddingInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolLoadShedding\"}]}}", isOptional: true)]
        public virtual object? LoadSheddingInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "longitudeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? LongitudeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minimumOriginsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinimumOriginsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "monitorGroupInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MonitorGroupInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "monitorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MonitorInput
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
        [JsiiProperty(name: "notificationEmailInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NotificationEmailInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "notificationFilterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolNotificationFilter\"}]}}", isOptional: true)]
        public virtual object? NotificationFilterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "originsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolOrigins\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? OriginsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "originSteeringInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolOriginSteering\"}]}}", isOptional: true)]
        public virtual object? OriginSteeringInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "checkRegions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] CheckRegions
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Enabled
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

        [JsiiProperty(name: "latitude", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Latitude
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "longitude", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Longitude
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minimumOrigins", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinimumOrigins
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "monitor", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Monitor
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "monitorGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MonitorGroup
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

        [JsiiProperty(name: "notificationEmail", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NotificationEmail
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
