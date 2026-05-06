using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMetricExtension
{
    [JsiiClass(nativeType: typeof(oci.StackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryPropertiesOutputReference), fullyQualifiedName: "oci.stackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryPropertiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class StackMonitoringMetricExtensionQueryPropertiesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public StackMonitoringMetricExtensionQueryPropertiesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected StackMonitoringMetricExtensionQueryPropertiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StackMonitoringMetricExtensionQueryPropertiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putInParamDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.stackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryPropertiesInParamDetails\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutInParamDetails(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.StackMonitoringMetricExtension.IStackMonitoringMetricExtensionQueryPropertiesInParamDetails[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.StackMonitoringMetricExtension.IStackMonitoringMetricExtensionQueryPropertiesInParamDetails).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.StackMonitoringMetricExtension.IStackMonitoringMetricExtensionQueryPropertiesInParamDetails).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOutParamDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.stackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryPropertiesOutParamDetails\"}}]")]
        public virtual void PutOutParamDetails(oci.StackMonitoringMetricExtension.IStackMonitoringMetricExtensionQueryPropertiesOutParamDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.StackMonitoringMetricExtension.IStackMonitoringMetricExtensionQueryPropertiesOutParamDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScriptDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.stackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryPropertiesScriptDetails\"}}]")]
        public virtual void PutScriptDetails(oci.StackMonitoringMetricExtension.IStackMonitoringMetricExtensionQueryPropertiesScriptDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.StackMonitoringMetricExtension.IStackMonitoringMetricExtensionQueryPropertiesScriptDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSqlDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.stackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryPropertiesSqlDetails\"}}]")]
        public virtual void PutSqlDetails(oci.StackMonitoringMetricExtension.IStackMonitoringMetricExtensionQueryPropertiesSqlDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.StackMonitoringMetricExtension.IStackMonitoringMetricExtensionQueryPropertiesSqlDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetArguments")]
        public virtual void ResetArguments()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoRowPrefix")]
        public virtual void ResetAutoRowPrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCommand")]
        public virtual void ResetCommand()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDelimiter")]
        public virtual void ResetDelimiter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdentityMetric")]
        public virtual void ResetIdentityMetric()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInParamDetails")]
        public virtual void ResetInParamDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsMetricServiceEnabled")]
        public virtual void ResetIsMetricServiceEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJmxAttributes")]
        public virtual void ResetJmxAttributes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetManagedBeanQuery")]
        public virtual void ResetManagedBeanQuery()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutParamDetails")]
        public virtual void ResetOutParamDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProtocolType")]
        public virtual void ResetProtocolType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResponseContentType")]
        public virtual void ResetResponseContentType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScriptDetails")]
        public virtual void ResetScriptDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSqlDetails")]
        public virtual void ResetSqlDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSqlType")]
        public virtual void ResetSqlType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStartsWith")]
        public virtual void ResetStartsWith()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUrl")]
        public virtual void ResetUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "inParamDetails", typeJson: "{\"fqn\":\"oci.stackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryPropertiesInParamDetailsList\"}")]
        public virtual oci.StackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryPropertiesInParamDetailsList InParamDetails
        {
            get => GetInstanceProperty<oci.StackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryPropertiesInParamDetailsList>()!;
        }

        [JsiiProperty(name: "outParamDetails", typeJson: "{\"fqn\":\"oci.stackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryPropertiesOutParamDetailsOutputReference\"}")]
        public virtual oci.StackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryPropertiesOutParamDetailsOutputReference OutParamDetails
        {
            get => GetInstanceProperty<oci.StackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryPropertiesOutParamDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "scriptDetails", typeJson: "{\"fqn\":\"oci.stackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryPropertiesScriptDetailsOutputReference\"}")]
        public virtual oci.StackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryPropertiesScriptDetailsOutputReference ScriptDetails
        {
            get => GetInstanceProperty<oci.StackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryPropertiesScriptDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "sqlDetails", typeJson: "{\"fqn\":\"oci.stackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryPropertiesSqlDetailsOutputReference\"}")]
        public virtual oci.StackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryPropertiesSqlDetailsOutputReference SqlDetails
        {
            get => GetInstanceProperty<oci.StackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryPropertiesSqlDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "argumentsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ArgumentsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoRowPrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AutoRowPrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "collectionMethodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CollectionMethodInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "commandInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CommandInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "delimiterInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DelimiterInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityMetricInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdentityMetricInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inParamDetailsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.stackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryPropertiesInParamDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? InParamDetailsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isMetricServiceEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsMetricServiceEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jmxAttributesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JmxAttributesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managedBeanQueryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ManagedBeanQueryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outParamDetailsInput", typeJson: "{\"fqn\":\"oci.stackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryPropertiesOutParamDetails\"}", isOptional: true)]
        public virtual oci.StackMonitoringMetricExtension.IStackMonitoringMetricExtensionQueryPropertiesOutParamDetails? OutParamDetailsInput
        {
            get => GetInstanceProperty<oci.StackMonitoringMetricExtension.IStackMonitoringMetricExtensionQueryPropertiesOutParamDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protocolTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProtocolTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "responseContentTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResponseContentTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scriptDetailsInput", typeJson: "{\"fqn\":\"oci.stackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryPropertiesScriptDetails\"}", isOptional: true)]
        public virtual oci.StackMonitoringMetricExtension.IStackMonitoringMetricExtensionQueryPropertiesScriptDetails? ScriptDetailsInput
        {
            get => GetInstanceProperty<oci.StackMonitoringMetricExtension.IStackMonitoringMetricExtensionQueryPropertiesScriptDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sqlDetailsInput", typeJson: "{\"fqn\":\"oci.stackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryPropertiesSqlDetails\"}", isOptional: true)]
        public virtual oci.StackMonitoringMetricExtension.IStackMonitoringMetricExtensionQueryPropertiesSqlDetails? SqlDetailsInput
        {
            get => GetInstanceProperty<oci.StackMonitoringMetricExtension.IStackMonitoringMetricExtensionQueryPropertiesSqlDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sqlTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SqlTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "startsWithInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StartsWithInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "arguments", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arguments
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "autoRowPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutoRowPrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "collectionMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CollectionMethod
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "command", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Command
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "delimiter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Delimiter
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "identityMetric", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdentityMetric
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isMetricServiceEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsMetricServiceEnabled
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

        [JsiiProperty(name: "jmxAttributes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JmxAttributes
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "managedBeanQuery", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedBeanQuery
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "protocolType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProtocolType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "responseContentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResponseContentType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sqlType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SqlType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "startsWith", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartsWith
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Url
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.stackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryProperties\"}", isOptional: true)]
        public virtual oci.StackMonitoringMetricExtension.IStackMonitoringMetricExtensionQueryProperties? InternalValue
        {
            get => GetInstanceProperty<oci.StackMonitoringMetricExtension.IStackMonitoringMetricExtensionQueryProperties?>();
            set => SetInstanceProperty(value);
        }
    }
}
