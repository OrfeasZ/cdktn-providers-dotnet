using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrserverlessApplication
{
    [JsiiClass(nativeType: typeof(aws.EmrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfigurationOutputReference), fullyQualifiedName: "aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLogTypes", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfigurationLogTypes\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLogTypes(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfigurationLogTypes[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfigurationLogTypes).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfigurationLogTypes).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEncryptionKeyArn")]
        public virtual void ResetEncryptionKeyArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogGroupName")]
        public virtual void ResetLogGroupName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogStreamNamePrefix")]
        public virtual void ResetLogStreamNamePrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogTypes")]
        public virtual void ResetLogTypes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "logTypes", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfigurationLogTypesList\"}")]
        public virtual aws.EmrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfigurationLogTypesList LogTypes
        {
            get => GetInstanceProperty<aws.EmrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfigurationLogTypesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionKeyArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EncryptionKeyArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logStreamNamePrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogStreamNamePrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logTypesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfigurationLogTypes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LogTypesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Enabled
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

        [JsiiProperty(name: "encryptionKeyArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EncryptionKeyArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logStreamNamePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogStreamNamePrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfiguration\"}", isOptional: true)]
        public virtual aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
