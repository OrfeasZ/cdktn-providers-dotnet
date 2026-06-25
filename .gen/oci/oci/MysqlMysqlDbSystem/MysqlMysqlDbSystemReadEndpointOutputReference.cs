using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlDbSystem
{
    [JsiiClass(nativeType: typeof(oci.MysqlMysqlDbSystem.MysqlMysqlDbSystemReadEndpointOutputReference), fullyQualifiedName: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemReadEndpointOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MysqlMysqlDbSystemReadEndpointOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MysqlMysqlDbSystemReadEndpointOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MysqlMysqlDbSystemReadEndpointOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MysqlMysqlDbSystemReadEndpointOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putReadEndpointIpv6AddressIpv6SubnetCidrPairDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemReadEndpointReadEndpointIpv6AddressIpv6SubnetCidrPairDetails\"}}]")]
        public virtual void PutReadEndpointIpv6AddressIpv6SubnetCidrPairDetails(oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemReadEndpointReadEndpointIpv6AddressIpv6SubnetCidrPairDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemReadEndpointReadEndpointIpv6AddressIpv6SubnetCidrPairDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetExcludeIps")]
        public virtual void ResetExcludeIps()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsEnabled")]
        public virtual void ResetIsEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReadEndpointHostnameLabel")]
        public virtual void ResetReadEndpointHostnameLabel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReadEndpointIpAddress")]
        public virtual void ResetReadEndpointIpAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReadEndpointIpv6AddressIpv6SubnetCidrPairDetails")]
        public virtual void ResetReadEndpointIpv6AddressIpv6SubnetCidrPairDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "readEndpointIpv6AddressIpv6SubnetCidrPairDetails", typeJson: "{\"fqn\":\"oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemReadEndpointReadEndpointIpv6AddressIpv6SubnetCidrPairDetailsOutputReference\"}")]
        public virtual oci.MysqlMysqlDbSystem.MysqlMysqlDbSystemReadEndpointReadEndpointIpv6AddressIpv6SubnetCidrPairDetailsOutputReference ReadEndpointIpv6AddressIpv6SubnetCidrPairDetails
        {
            get => GetInstanceProperty<oci.MysqlMysqlDbSystem.MysqlMysqlDbSystemReadEndpointReadEndpointIpv6AddressIpv6SubnetCidrPairDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "excludeIpsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ExcludeIpsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "readEndpointHostnameLabelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReadEndpointHostnameLabelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "readEndpointIpAddressInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReadEndpointIpAddressInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "readEndpointIpv6AddressIpv6SubnetCidrPairDetailsInput", typeJson: "{\"fqn\":\"oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemReadEndpointReadEndpointIpv6AddressIpv6SubnetCidrPairDetails\"}", isOptional: true)]
        public virtual oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemReadEndpointReadEndpointIpv6AddressIpv6SubnetCidrPairDetails? ReadEndpointIpv6AddressIpv6SubnetCidrPairDetailsInput
        {
            get => GetInstanceProperty<oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemReadEndpointReadEndpointIpv6AddressIpv6SubnetCidrPairDetails?>();
        }

        [JsiiProperty(name: "excludeIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ExcludeIps
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsEnabled
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

        [JsiiProperty(name: "readEndpointHostnameLabel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReadEndpointHostnameLabel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "readEndpointIpAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReadEndpointIpAddress
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemReadEndpoint\"}", isOptional: true)]
        public virtual oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemReadEndpoint? InternalValue
        {
            get => GetInstanceProperty<oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemReadEndpoint?>();
            set => SetInstanceProperty(value);
        }
    }
}
