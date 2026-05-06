using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreSecurityList
{
    [JsiiClass(nativeType: typeof(oci.CoreSecurityList.CoreSecurityListEgressSecurityRulesOutputReference), fullyQualifiedName: "oci.coreSecurityList.CoreSecurityListEgressSecurityRulesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CoreSecurityListEgressSecurityRulesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public CoreSecurityListEgressSecurityRulesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected CoreSecurityListEgressSecurityRulesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreSecurityListEgressSecurityRulesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIcmpOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreSecurityList.CoreSecurityListEgressSecurityRulesIcmpOptions\"}}]")]
        public virtual void PutIcmpOptions(oci.CoreSecurityList.ICoreSecurityListEgressSecurityRulesIcmpOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreSecurityList.ICoreSecurityListEgressSecurityRulesIcmpOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTcpOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreSecurityList.CoreSecurityListEgressSecurityRulesTcpOptions\"}}]")]
        public virtual void PutTcpOptions(oci.CoreSecurityList.ICoreSecurityListEgressSecurityRulesTcpOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreSecurityList.ICoreSecurityListEgressSecurityRulesTcpOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUdpOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreSecurityList.CoreSecurityListEgressSecurityRulesUdpOptions\"}}]")]
        public virtual void PutUdpOptions(oci.CoreSecurityList.ICoreSecurityListEgressSecurityRulesUdpOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreSecurityList.ICoreSecurityListEgressSecurityRulesUdpOptions)}, new object[]{@value});
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

        [JsiiProperty(name: "icmpOptions", typeJson: "{\"fqn\":\"oci.coreSecurityList.CoreSecurityListEgressSecurityRulesIcmpOptionsOutputReference\"}")]
        public virtual oci.CoreSecurityList.CoreSecurityListEgressSecurityRulesIcmpOptionsOutputReference IcmpOptions
        {
            get => GetInstanceProperty<oci.CoreSecurityList.CoreSecurityListEgressSecurityRulesIcmpOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "tcpOptions", typeJson: "{\"fqn\":\"oci.coreSecurityList.CoreSecurityListEgressSecurityRulesTcpOptionsOutputReference\"}")]
        public virtual oci.CoreSecurityList.CoreSecurityListEgressSecurityRulesTcpOptionsOutputReference TcpOptions
        {
            get => GetInstanceProperty<oci.CoreSecurityList.CoreSecurityListEgressSecurityRulesTcpOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "udpOptions", typeJson: "{\"fqn\":\"oci.coreSecurityList.CoreSecurityListEgressSecurityRulesUdpOptionsOutputReference\"}")]
        public virtual oci.CoreSecurityList.CoreSecurityListEgressSecurityRulesUdpOptionsOutputReference UdpOptions
        {
            get => GetInstanceProperty<oci.CoreSecurityList.CoreSecurityListEgressSecurityRulesUdpOptionsOutputReference>()!;
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
        [JsiiProperty(name: "icmpOptionsInput", typeJson: "{\"fqn\":\"oci.coreSecurityList.CoreSecurityListEgressSecurityRulesIcmpOptions\"}", isOptional: true)]
        public virtual oci.CoreSecurityList.ICoreSecurityListEgressSecurityRulesIcmpOptions? IcmpOptionsInput
        {
            get => GetInstanceProperty<oci.CoreSecurityList.ICoreSecurityListEgressSecurityRulesIcmpOptions?>();
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
        [JsiiProperty(name: "tcpOptionsInput", typeJson: "{\"fqn\":\"oci.coreSecurityList.CoreSecurityListEgressSecurityRulesTcpOptions\"}", isOptional: true)]
        public virtual oci.CoreSecurityList.ICoreSecurityListEgressSecurityRulesTcpOptions? TcpOptionsInput
        {
            get => GetInstanceProperty<oci.CoreSecurityList.ICoreSecurityListEgressSecurityRulesTcpOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "udpOptionsInput", typeJson: "{\"fqn\":\"oci.coreSecurityList.CoreSecurityListEgressSecurityRulesUdpOptions\"}", isOptional: true)]
        public virtual oci.CoreSecurityList.ICoreSecurityListEgressSecurityRulesUdpOptions? UdpOptionsInput
        {
            get => GetInstanceProperty<oci.CoreSecurityList.ICoreSecurityListEgressSecurityRulesUdpOptions?>();
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.coreSecurityList.CoreSecurityListEgressSecurityRules\"}]}}", isOptional: true)]
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
                        case oci.CoreSecurityList.ICoreSecurityListEgressSecurityRules cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CoreSecurityList.ICoreSecurityListEgressSecurityRules).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
