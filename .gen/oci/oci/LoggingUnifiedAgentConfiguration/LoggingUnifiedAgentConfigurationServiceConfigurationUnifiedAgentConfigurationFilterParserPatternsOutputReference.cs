using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoggingUnifiedAgentConfiguration
{
    [JsiiClass(nativeType: typeof(oci.LoggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParserPatternsOutputReference), fullyQualifiedName: "oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParserPatternsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class LoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParserPatternsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public LoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParserPatternsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected LoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParserPatternsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParserPatternsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetFieldTimeFormat")]
        public virtual void ResetFieldTimeFormat()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFieldTimeKey")]
        public virtual void ResetFieldTimeKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFieldTimeZone")]
        public virtual void ResetFieldTimeZone()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPattern")]
        public virtual void ResetPattern()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "fieldTimeFormatInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FieldTimeFormatInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fieldTimeKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FieldTimeKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fieldTimeZoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FieldTimeZoneInput
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
        [JsiiProperty(name: "patternInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PatternInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "fieldTimeFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FieldTimeFormat
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fieldTimeKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FieldTimeKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fieldTimeZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FieldTimeZone
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

        [JsiiProperty(name: "pattern", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Pattern
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParserPatterns\"}]}}", isOptional: true)]
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
                        case oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParserPatterns cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParserPatterns).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
