using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreDefaultSecurityList
{
    [JsiiClass(nativeType: typeof(oci.CoreDefaultSecurityList.CoreDefaultSecurityListIngressSecurityRulesOutputReference), fullyQualifiedName: "oci.coreDefaultSecurityList.CoreDefaultSecurityListIngressSecurityRulesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CoreDefaultSecurityListIngressSecurityRulesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public CoreDefaultSecurityListIngressSecurityRulesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected CoreDefaultSecurityListIngressSecurityRulesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreDefaultSecurityListIngressSecurityRulesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIcmpOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreDefaultSecurityList.CoreDefaultSecurityListIngressSecurityRulesIcmpOptions\"}}]")]
        public virtual void PutIcmpOptions(oci.CoreDefaultSecurityList.ICoreDefaultSecurityListIngressSecurityRulesIcmpOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreDefaultSecurityList.ICoreDefaultSecurityListIngressSecurityRulesIcmpOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTcpOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreDefaultSecurityList.CoreDefaultSecurityListIngressSecurityRulesTcpOptions\"}}]")]
        public virtual void PutTcpOptions(oci.CoreDefaultSecurityList.ICoreDefaultSecurityListIngressSecurityRulesTcpOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreDefaultSecurityList.ICoreDefaultSecurityListIngressSecurityRulesTcpOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUdpOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreDefaultSecurityList.CoreDefaultSecurityListIngressSecurityRulesUdpOptions\"}}]")]
        public virtual void PutUdpOptions(oci.CoreDefaultSecurityList.ICoreDefaultSecurityListIngressSecurityRulesUdpOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreDefaultSecurityList.ICoreDefaultSecurityListIngressSecurityRulesUdpOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIcmpOptions")]
        public virtual void ResetIcmpOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceType")]
        public virtual void ResetSourceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStateless")]
        public virtual void ResetStateless()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTcpOptions")]
        public virtual void ResetTcpOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUdpOptions")]
        public virtual void ResetUdpOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "icmpOptions", typeJson: "{\"fqn\":\"oci.coreDefaultSecurityList.CoreDefaultSecurityListIngressSecurityRulesIcmpOptionsOutputReference\"}")]
        public virtual oci.CoreDefaultSecurityList.CoreDefaultSecurityListIngressSecurityRulesIcmpOptionsOutputReference IcmpOptions
        {
            get => GetInstanceProperty<oci.CoreDefaultSecurityList.CoreDefaultSecurityListIngressSecurityRulesIcmpOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "tcpOptions", typeJson: "{\"fqn\":\"oci.coreDefaultSecurityList.CoreDefaultSecurityListIngressSecurityRulesTcpOptionsOutputReference\"}")]
        public virtual oci.CoreDefaultSecurityList.CoreDefaultSecurityListIngressSecurityRulesTcpOptionsOutputReference TcpOptions
        {
            get => GetInstanceProperty<oci.CoreDefaultSecurityList.CoreDefaultSecurityListIngressSecurityRulesTcpOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "udpOptions", typeJson: "{\"fqn\":\"oci.coreDefaultSecurityList.CoreDefaultSecurityListIngressSecurityRulesUdpOptionsOutputReference\"}")]
        public virtual oci.CoreDefaultSecurityList.CoreDefaultSecurityListIngressSecurityRulesUdpOptionsOutputReference UdpOptions
        {
            get => GetInstanceProperty<oci.CoreDefaultSecurityList.CoreDefaultSecurityListIngressSecurityRulesUdpOptionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "icmpOptionsInput", typeJson: "{\"fqn\":\"oci.coreDefaultSecurityList.CoreDefaultSecurityListIngressSecurityRulesIcmpOptions\"}", isOptional: true)]
        public virtual oci.CoreDefaultSecurityList.ICoreDefaultSecurityListIngressSecurityRulesIcmpOptions? IcmpOptionsInput
        {
            get => GetInstanceProperty<oci.CoreDefaultSecurityList.ICoreDefaultSecurityListIngressSecurityRulesIcmpOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protocolInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProtocolInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statelessInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? StatelessInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tcpOptionsInput", typeJson: "{\"fqn\":\"oci.coreDefaultSecurityList.CoreDefaultSecurityListIngressSecurityRulesTcpOptions\"}", isOptional: true)]
        public virtual oci.CoreDefaultSecurityList.ICoreDefaultSecurityListIngressSecurityRulesTcpOptions? TcpOptionsInput
        {
            get => GetInstanceProperty<oci.CoreDefaultSecurityList.ICoreDefaultSecurityListIngressSecurityRulesTcpOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "udpOptionsInput", typeJson: "{\"fqn\":\"oci.coreDefaultSecurityList.CoreDefaultSecurityListIngressSecurityRulesUdpOptions\"}", isOptional: true)]
        public virtual oci.CoreDefaultSecurityList.ICoreDefaultSecurityListIngressSecurityRulesUdpOptions? UdpOptionsInput
        {
            get => GetInstanceProperty<oci.CoreDefaultSecurityList.ICoreDefaultSecurityListIngressSecurityRulesUdpOptions?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Protocol
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Source
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stateless", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Stateless
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

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.coreDefaultSecurityList.CoreDefaultSecurityListIngressSecurityRules\"}]}}", isOptional: true)]
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
                        case oci.CoreDefaultSecurityList.ICoreDefaultSecurityListIngressSecurityRules cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CoreDefaultSecurityList.ICoreDefaultSecurityListIngressSecurityRules).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
