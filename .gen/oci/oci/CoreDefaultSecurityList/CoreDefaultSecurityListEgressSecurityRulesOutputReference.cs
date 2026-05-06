using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreDefaultSecurityList
{
    [JsiiClass(nativeType: typeof(oci.CoreDefaultSecurityList.CoreDefaultSecurityListEgressSecurityRulesOutputReference), fullyQualifiedName: "oci.coreDefaultSecurityList.CoreDefaultSecurityListEgressSecurityRulesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CoreDefaultSecurityListEgressSecurityRulesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public CoreDefaultSecurityListEgressSecurityRulesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected CoreDefaultSecurityListEgressSecurityRulesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreDefaultSecurityListEgressSecurityRulesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIcmpOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreDefaultSecurityList.CoreDefaultSecurityListEgressSecurityRulesIcmpOptions\"}}]")]
        public virtual void PutIcmpOptions(oci.CoreDefaultSecurityList.ICoreDefaultSecurityListEgressSecurityRulesIcmpOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreDefaultSecurityList.ICoreDefaultSecurityListEgressSecurityRulesIcmpOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTcpOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreDefaultSecurityList.CoreDefaultSecurityListEgressSecurityRulesTcpOptions\"}}]")]
        public virtual void PutTcpOptions(oci.CoreDefaultSecurityList.ICoreDefaultSecurityListEgressSecurityRulesTcpOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreDefaultSecurityList.ICoreDefaultSecurityListEgressSecurityRulesTcpOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUdpOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreDefaultSecurityList.CoreDefaultSecurityListEgressSecurityRulesUdpOptions\"}}]")]
        public virtual void PutUdpOptions(oci.CoreDefaultSecurityList.ICoreDefaultSecurityListEgressSecurityRulesUdpOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreDefaultSecurityList.ICoreDefaultSecurityListEgressSecurityRulesUdpOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDestinationType")]
        public virtual void ResetDestinationType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIcmpOptions")]
        public virtual void ResetIcmpOptions()
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

        [JsiiProperty(name: "icmpOptions", typeJson: "{\"fqn\":\"oci.coreDefaultSecurityList.CoreDefaultSecurityListEgressSecurityRulesIcmpOptionsOutputReference\"}")]
        public virtual oci.CoreDefaultSecurityList.CoreDefaultSecurityListEgressSecurityRulesIcmpOptionsOutputReference IcmpOptions
        {
            get => GetInstanceProperty<oci.CoreDefaultSecurityList.CoreDefaultSecurityListEgressSecurityRulesIcmpOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "tcpOptions", typeJson: "{\"fqn\":\"oci.coreDefaultSecurityList.CoreDefaultSecurityListEgressSecurityRulesTcpOptionsOutputReference\"}")]
        public virtual oci.CoreDefaultSecurityList.CoreDefaultSecurityListEgressSecurityRulesTcpOptionsOutputReference TcpOptions
        {
            get => GetInstanceProperty<oci.CoreDefaultSecurityList.CoreDefaultSecurityListEgressSecurityRulesTcpOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "udpOptions", typeJson: "{\"fqn\":\"oci.coreDefaultSecurityList.CoreDefaultSecurityListEgressSecurityRulesUdpOptionsOutputReference\"}")]
        public virtual oci.CoreDefaultSecurityList.CoreDefaultSecurityListEgressSecurityRulesUdpOptionsOutputReference UdpOptions
        {
            get => GetInstanceProperty<oci.CoreDefaultSecurityList.CoreDefaultSecurityListEgressSecurityRulesUdpOptionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DestinationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DestinationTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "icmpOptionsInput", typeJson: "{\"fqn\":\"oci.coreDefaultSecurityList.CoreDefaultSecurityListEgressSecurityRulesIcmpOptions\"}", isOptional: true)]
        public virtual oci.CoreDefaultSecurityList.ICoreDefaultSecurityListEgressSecurityRulesIcmpOptions? IcmpOptionsInput
        {
            get => GetInstanceProperty<oci.CoreDefaultSecurityList.ICoreDefaultSecurityListEgressSecurityRulesIcmpOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protocolInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProtocolInput
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
        [JsiiProperty(name: "tcpOptionsInput", typeJson: "{\"fqn\":\"oci.coreDefaultSecurityList.CoreDefaultSecurityListEgressSecurityRulesTcpOptions\"}", isOptional: true)]
        public virtual oci.CoreDefaultSecurityList.ICoreDefaultSecurityListEgressSecurityRulesTcpOptions? TcpOptionsInput
        {
            get => GetInstanceProperty<oci.CoreDefaultSecurityList.ICoreDefaultSecurityListEgressSecurityRulesTcpOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "udpOptionsInput", typeJson: "{\"fqn\":\"oci.coreDefaultSecurityList.CoreDefaultSecurityListEgressSecurityRulesUdpOptions\"}", isOptional: true)]
        public virtual oci.CoreDefaultSecurityList.ICoreDefaultSecurityListEgressSecurityRulesUdpOptions? UdpOptionsInput
        {
            get => GetInstanceProperty<oci.CoreDefaultSecurityList.ICoreDefaultSecurityListEgressSecurityRulesUdpOptions?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Destination
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "destinationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DestinationType
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.coreDefaultSecurityList.CoreDefaultSecurityListEgressSecurityRules\"}]}}", isOptional: true)]
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
                        case oci.CoreDefaultSecurityList.ICoreDefaultSecurityListEgressSecurityRules cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CoreDefaultSecurityList.ICoreDefaultSecurityListEgressSecurityRules).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
