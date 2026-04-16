using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ConnectivityDirectoryService
{
    [JsiiClass(nativeType: typeof(cloudflare.ConnectivityDirectoryService.ConnectivityDirectoryServiceHostOutputReference), fullyQualifiedName: "cloudflare.connectivityDirectoryService.ConnectivityDirectoryServiceHostOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ConnectivityDirectoryServiceHostOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ConnectivityDirectoryServiceHostOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConnectivityDirectoryServiceHostOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConnectivityDirectoryServiceHostOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putNetwork", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.connectivityDirectoryService.ConnectivityDirectoryServiceHostNetwork\"}}]")]
        public virtual void PutNetwork(cloudflare.ConnectivityDirectoryService.IConnectivityDirectoryServiceHostNetwork @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ConnectivityDirectoryService.IConnectivityDirectoryServiceHostNetwork)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResolverNetwork", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.connectivityDirectoryService.ConnectivityDirectoryServiceHostResolverNetwork\"}}]")]
        public virtual void PutResolverNetwork(cloudflare.ConnectivityDirectoryService.IConnectivityDirectoryServiceHostResolverNetwork @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ConnectivityDirectoryService.IConnectivityDirectoryServiceHostResolverNetwork)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHostname")]
        public virtual void ResetHostname()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpv4")]
        public virtual void ResetIpv4()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpv6")]
        public virtual void ResetIpv6()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetwork")]
        public virtual void ResetNetwork()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResolverNetwork")]
        public virtual void ResetResolverNetwork()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"cloudflare.connectivityDirectoryService.ConnectivityDirectoryServiceHostNetworkOutputReference\"}")]
        public virtual cloudflare.ConnectivityDirectoryService.ConnectivityDirectoryServiceHostNetworkOutputReference Network
        {
            get => GetInstanceProperty<cloudflare.ConnectivityDirectoryService.ConnectivityDirectoryServiceHostNetworkOutputReference>()!;
        }

        [JsiiProperty(name: "resolverNetwork", typeJson: "{\"fqn\":\"cloudflare.connectivityDirectoryService.ConnectivityDirectoryServiceHostResolverNetworkOutputReference\"}")]
        public virtual cloudflare.ConnectivityDirectoryService.ConnectivityDirectoryServiceHostResolverNetworkOutputReference ResolverNetwork
        {
            get => GetInstanceProperty<cloudflare.ConnectivityDirectoryService.ConnectivityDirectoryServiceHostResolverNetworkOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostnameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HostnameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipv4Input", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Ipv4Input
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipv6Input", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Ipv6Input
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.connectivityDirectoryService.ConnectivityDirectoryServiceHostNetwork\"}]}}", isOptional: true)]
        public virtual object? NetworkInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resolverNetworkInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.connectivityDirectoryService.ConnectivityDirectoryServiceHostResolverNetwork\"}]}}", isOptional: true)]
        public virtual object? ResolverNetworkInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Hostname
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ipv4", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ipv4
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ipv6", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ipv6
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.connectivityDirectoryService.ConnectivityDirectoryServiceHost\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.ConnectivityDirectoryService.IConnectivityDirectoryServiceHost cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ConnectivityDirectoryService.IConnectivityDirectoryServiceHost).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
