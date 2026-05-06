using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreCaptureFilter
{
    [JsiiClass(nativeType: typeof(oci.CoreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesOutputReference), fullyQualifiedName: "oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CoreCaptureFilterFlowLogCaptureFilterRulesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public CoreCaptureFilterFlowLogCaptureFilterRulesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected CoreCaptureFilterFlowLogCaptureFilterRulesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreCaptureFilterFlowLogCaptureFilterRulesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIcmpOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesIcmpOptions\"}}]")]
        public virtual void PutIcmpOptions(oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesIcmpOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesIcmpOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTcpOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesTcpOptions\"}}]")]
        public virtual void PutTcpOptions(oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesTcpOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesTcpOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUdpOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesUdpOptions\"}}]")]
        public virtual void PutUdpOptions(oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesUdpOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesUdpOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDestinationCidr")]
        public virtual void ResetDestinationCidr()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFlowLogType")]
        public virtual void ResetFlowLogType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIcmpOptions")]
        public virtual void ResetIcmpOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsEnabled")]
        public virtual void ResetIsEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPriority")]
        public virtual void ResetPriority()
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

        [JsiiMethod(name: "resetSamplingRate")]
        public virtual void ResetSamplingRate()
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

        [JsiiProperty(name: "icmpOptions", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesIcmpOptionsOutputReference\"}")]
        public virtual oci.CoreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesIcmpOptionsOutputReference IcmpOptions
        {
            get => GetInstanceProperty<oci.CoreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesIcmpOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "tcpOptions", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesTcpOptionsOutputReference\"}")]
        public virtual oci.CoreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesTcpOptionsOutputReference TcpOptions
        {
            get => GetInstanceProperty<oci.CoreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesTcpOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "udpOptions", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesUdpOptionsOutputReference\"}")]
        public virtual oci.CoreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesUdpOptionsOutputReference UdpOptions
        {
            get => GetInstanceProperty<oci.CoreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesUdpOptionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationCidrInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DestinationCidrInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "flowLogTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FlowLogTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "icmpOptionsInput", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesIcmpOptions\"}", isOptional: true)]
        public virtual oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesIcmpOptions? IcmpOptionsInput
        {
            get => GetInstanceProperty<oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesIcmpOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "priorityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PriorityInput
        {
            get => GetInstanceProperty<double?>();
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
        [JsiiProperty(name: "samplingRateInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SamplingRateInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceCidrInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceCidrInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tcpOptionsInput", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesTcpOptions\"}", isOptional: true)]
        public virtual oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesTcpOptions? TcpOptionsInput
        {
            get => GetInstanceProperty<oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesTcpOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "udpOptionsInput", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesUdpOptions\"}", isOptional: true)]
        public virtual oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesUdpOptions? UdpOptionsInput
        {
            get => GetInstanceProperty<oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesUdpOptions?>();
        }

        [JsiiProperty(name: "destinationCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DestinationCidr
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "flowLogType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FlowLogType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

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

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Priority
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "samplingRate", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SamplingRate
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceCidr
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRules\"}]}}", isOptional: true)]
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
                        case oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRules cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRules).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
