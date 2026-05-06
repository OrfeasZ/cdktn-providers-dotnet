using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoggingUnifiedAgentConfiguration
{
    [JsiiClass(nativeType: typeof(oci.LoggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationSourcesOutputReference), fullyQualifiedName: "oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationSourcesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class LoggingUnifiedAgentConfigurationServiceConfigurationSourcesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public LoggingUnifiedAgentConfigurationServiceConfigurationSourcesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected LoggingUnifiedAgentConfigurationServiceConfigurationSourcesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LoggingUnifiedAgentConfigurationServiceConfigurationSourcesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAdvancedOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationSourcesAdvancedOptions\"}}]")]
        public virtual void PutAdvancedOptions(oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationSourcesAdvancedOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationSourcesAdvancedOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putParser", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationSourcesParser\"}}]")]
        public virtual void PutParser(oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationSourcesParser @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationSourcesParser)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdvancedOptions")]
        public virtual void ResetAdvancedOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetChannels")]
        public virtual void ResetChannels()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomPlugin")]
        public virtual void ResetCustomPlugin()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParser")]
        public virtual void ResetParser()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPaths")]
        public virtual void ResetPaths()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "advancedOptions", typeJson: "{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationSourcesAdvancedOptionsOutputReference\"}")]
        public virtual oci.LoggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationSourcesAdvancedOptionsOutputReference AdvancedOptions
        {
            get => GetInstanceProperty<oci.LoggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationSourcesAdvancedOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "parser", typeJson: "{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationSourcesParserOutputReference\"}")]
        public virtual oci.LoggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationSourcesParserOutputReference Parser
        {
            get => GetInstanceProperty<oci.LoggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationSourcesParserOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "advancedOptionsInput", typeJson: "{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationSourcesAdvancedOptions\"}", isOptional: true)]
        public virtual oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationSourcesAdvancedOptions? AdvancedOptionsInput
        {
            get => GetInstanceProperty<oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationSourcesAdvancedOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "channelsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ChannelsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customPluginInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomPluginInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parserInput", typeJson: "{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationSourcesParser\"}", isOptional: true)]
        public virtual oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationSourcesParser? ParserInput
        {
            get => GetInstanceProperty<oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationSourcesParser?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pathsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? PathsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "channels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Channels
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "customPlugin", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomPlugin
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "paths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Paths
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationSources\"}]}}", isOptional: true)]
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
                        case oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationSources cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationSources).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
