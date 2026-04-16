using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontMultitenantDistribution
{
    [JsiiClass(nativeType: typeof(aws.CloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOriginCustomOriginConfigOutputReference), fullyQualifiedName: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOriginCustomOriginConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CloudfrontMultitenantDistributionOriginCustomOriginConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public CloudfrontMultitenantDistributionOriginCustomOriginConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontMultitenantDistributionOriginCustomOriginConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontMultitenantDistributionOriginCustomOriginConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetIpAddressType")]
        public virtual void ResetIpAddressType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOriginKeepaliveTimeout")]
        public virtual void ResetOriginKeepaliveTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOriginReadTimeout")]
        public virtual void ResetOriginReadTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpPortInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HttpPortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpsPortInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HttpsPortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipAddressTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IpAddressTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "originKeepaliveTimeoutInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? OriginKeepaliveTimeoutInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "originProtocolPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OriginProtocolPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "originReadTimeoutInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? OriginReadTimeoutInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "originSslProtocolsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? OriginSslProtocolsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "httpPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HttpPort
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "httpsPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HttpsPort
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ipAddressType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpAddressType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "originKeepaliveTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OriginKeepaliveTimeout
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "originProtocolPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OriginProtocolPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "originReadTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OriginReadTimeout
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "originSslProtocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] OriginSslProtocols
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOriginCustomOriginConfig\"}]}}", isOptional: true)]
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
                        case aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionOriginCustomOriginConfig cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionOriginCustomOriginConfig).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
