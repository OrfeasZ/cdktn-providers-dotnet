using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreCaptureFilter
{
    [JsiiClass(nativeType: typeof(oci.CoreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesOutputReference), fullyQualifiedName: "oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CoreCaptureFilterVtapCaptureFilterRulesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public CoreCaptureFilterVtapCaptureFilterRulesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected CoreCaptureFilterVtapCaptureFilterRulesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreCaptureFilterVtapCaptureFilterRulesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIcmpOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesIcmpOptions\"}}]")]
        public virtual void PutIcmpOptions(oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesIcmpOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesIcmpOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTcpOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesTcpOptions\"}}]")]
        public virtual void PutTcpOptions(oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesTcpOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesTcpOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUdpOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesUdpOptions\"}}]")]
        public virtual void PutUdpOptions(oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesUdpOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesUdpOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDestinationCidr")]
        public virtual void ResetDestinationCidr()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIcmpOptions")]
        public virtual void ResetIcmpOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProtocol")]
        public virtual void ResetProtocol()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRuleAction")]
        public virtual void ResetRuleAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceCidr")]
        public virtual void ResetSourceCidr()
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

        [JsiiProperty(name: "icmpOptions", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesIcmpOptionsOutputReference\"}")]
        public virtual oci.CoreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesIcmpOptionsOutputReference IcmpOptions
        {
            get => GetInstanceProperty<oci.CoreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesIcmpOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "tcpOptions", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesTcpOptionsOutputReference\"}")]
        public virtual oci.CoreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesTcpOptionsOutputReference TcpOptions
        {
            get => GetInstanceProperty<oci.CoreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesTcpOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "udpOptions", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesUdpOptionsOutputReference\"}")]
        public virtual oci.CoreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesUdpOptionsOutputReference UdpOptions
        {
            get => GetInstanceProperty<oci.CoreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesUdpOptionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationCidrInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DestinationCidrInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "icmpOptionsInput", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesIcmpOptions\"}", isOptional: true)]
        public virtual oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesIcmpOptions? IcmpOptionsInput
        {
            get => GetInstanceProperty<oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesIcmpOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protocolInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProtocolInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ruleActionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RuleActionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceCidrInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceCidrInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tcpOptionsInput", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesTcpOptions\"}", isOptional: true)]
        public virtual oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesTcpOptions? TcpOptionsInput
        {
            get => GetInstanceProperty<oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesTcpOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trafficDirectionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TrafficDirectionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "udpOptionsInput", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesUdpOptions\"}", isOptional: true)]
        public virtual oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesUdpOptions? UdpOptionsInput
        {
            get => GetInstanceProperty<oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesUdpOptions?>();
        }

        [JsiiProperty(name: "destinationCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DestinationCidr
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

        [JsiiProperty(name: "ruleAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuleAction
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceCidr
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "trafficDirection", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrafficDirection
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRules\"}]}}", isOptional: true)]
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
                        case oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRules cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRules).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
