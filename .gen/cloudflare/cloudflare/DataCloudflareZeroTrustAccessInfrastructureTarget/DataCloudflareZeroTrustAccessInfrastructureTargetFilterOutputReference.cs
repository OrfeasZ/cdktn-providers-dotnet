using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessInfrastructureTarget
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustAccessInfrastructureTarget.DataCloudflareZeroTrustAccessInfrastructureTargetFilterOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessInfrastructureTarget.DataCloudflareZeroTrustAccessInfrastructureTargetFilterOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustAccessInfrastructureTargetFilterOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustAccessInfrastructureTargetFilterOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustAccessInfrastructureTargetFilterOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustAccessInfrastructureTargetFilterOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCreatedAfter")]
        public virtual void ResetCreatedAfter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreatedBefore")]
        public virtual void ResetCreatedBefore()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDirection")]
        public virtual void ResetDirection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHostname")]
        public virtual void ResetHostname()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHostnameContains")]
        public virtual void ResetHostnameContains()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpLike")]
        public virtual void ResetIpLike()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIps")]
        public virtual void ResetIps()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpV4")]
        public virtual void ResetIpV4()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpv4End")]
        public virtual void ResetIpv4End()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpv4Start")]
        public virtual void ResetIpv4Start()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpV6")]
        public virtual void ResetIpV6()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpv6End")]
        public virtual void ResetIpv6End()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpv6Start")]
        public virtual void ResetIpv6Start()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetModifiedAfter")]
        public virtual void ResetModifiedAfter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetModifiedBefore")]
        public virtual void ResetModifiedBefore()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOrder")]
        public virtual void ResetOrder()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetIds")]
        public virtual void ResetTargetIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVirtualNetworkId")]
        public virtual void ResetVirtualNetworkId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "createdAfterInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CreatedAfterInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "createdBeforeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CreatedBeforeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "directionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DirectionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostnameContainsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HostnameContainsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostnameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HostnameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipLikeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IpLikeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? IpsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipv4EndInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Ipv4EndInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipV4Input", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IpV4Input
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipv4StartInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Ipv4StartInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipv6EndInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Ipv6EndInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipV6Input", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IpV6Input
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipv6StartInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Ipv6StartInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modifiedAfterInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModifiedAfterInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modifiedBeforeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModifiedBeforeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "orderInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OrderInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TargetIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "virtualNetworkIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VirtualNetworkIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "createdAfter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAfter
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "createdBefore", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedBefore
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Direction
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Hostname
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hostnameContains", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostnameContains
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ipLike", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpLike
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ips", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Ips
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ipV4", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpV4
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ipv4End", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ipv4End
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ipv4Start", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ipv4Start
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ipV6", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpV6
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ipv6End", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ipv6End
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ipv6Start", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ipv6Start
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "modifiedAfter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModifiedAfter
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "modifiedBefore", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModifiedBefore
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Order
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TargetIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "virtualNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VirtualNetworkId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessInfrastructureTarget.DataCloudflareZeroTrustAccessInfrastructureTargetFilter\"}]}}", isOptional: true)]
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
                        case cloudflare.DataCloudflareZeroTrustAccessInfrastructureTarget.IDataCloudflareZeroTrustAccessInfrastructureTargetFilter cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.DataCloudflareZeroTrustAccessInfrastructureTarget.IDataCloudflareZeroTrustAccessInfrastructureTargetFilter).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
