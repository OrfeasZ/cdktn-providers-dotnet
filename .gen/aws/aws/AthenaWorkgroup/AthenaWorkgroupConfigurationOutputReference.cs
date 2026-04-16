using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AthenaWorkgroup
{
    [JsiiClass(nativeType: typeof(aws.AthenaWorkgroup.AthenaWorkgroupConfigurationOutputReference), fullyQualifiedName: "aws.athenaWorkgroup.AthenaWorkgroupConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AthenaWorkgroupConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AthenaWorkgroupConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AthenaWorkgroupConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AthenaWorkgroupConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCustomerContentEncryptionConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationCustomerContentEncryptionConfiguration\"}}]")]
        public virtual void PutCustomerContentEncryptionConfiguration(aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationCustomerContentEncryptionConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationCustomerContentEncryptionConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEngineVersion", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationEngineVersion\"}}]")]
        public virtual void PutEngineVersion(aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationEngineVersion @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationEngineVersion)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdentityCenterConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationIdentityCenterConfiguration\"}}]")]
        public virtual void PutIdentityCenterConfiguration(aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationIdentityCenterConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationIdentityCenterConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putManagedQueryResultsConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationManagedQueryResultsConfiguration\"}}]")]
        public virtual void PutManagedQueryResultsConfiguration(aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationManagedQueryResultsConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationManagedQueryResultsConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMonitoringConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfiguration\"}}]")]
        public virtual void PutMonitoringConfiguration(aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putQueryResultsS3AccessGrantsConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationQueryResultsS3AccessGrantsConfiguration\"}}]")]
        public virtual void PutQueryResultsS3AccessGrantsConfiguration(aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationQueryResultsS3AccessGrantsConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationQueryResultsS3AccessGrantsConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResultConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationResultConfiguration\"}}]")]
        public virtual void PutResultConfiguration(aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationResultConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationResultConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBytesScannedCutoffPerQuery")]
        public virtual void ResetBytesScannedCutoffPerQuery()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomerContentEncryptionConfiguration")]
        public virtual void ResetCustomerContentEncryptionConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnableMinimumEncryptionConfiguration")]
        public virtual void ResetEnableMinimumEncryptionConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnforceWorkgroupConfiguration")]
        public virtual void ResetEnforceWorkgroupConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEngineVersion")]
        public virtual void ResetEngineVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExecutionRole")]
        public virtual void ResetExecutionRole()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdentityCenterConfiguration")]
        public virtual void ResetIdentityCenterConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetManagedQueryResultsConfiguration")]
        public virtual void ResetManagedQueryResultsConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMonitoringConfiguration")]
        public virtual void ResetMonitoringConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPublishCloudwatchMetricsEnabled")]
        public virtual void ResetPublishCloudwatchMetricsEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQueryResultsS3AccessGrantsConfiguration")]
        public virtual void ResetQueryResultsS3AccessGrantsConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequesterPaysEnabled")]
        public virtual void ResetRequesterPaysEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResultConfiguration")]
        public virtual void ResetResultConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "customerContentEncryptionConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationCustomerContentEncryptionConfigurationOutputReference\"}")]
        public virtual aws.AthenaWorkgroup.AthenaWorkgroupConfigurationCustomerContentEncryptionConfigurationOutputReference CustomerContentEncryptionConfiguration
        {
            get => GetInstanceProperty<aws.AthenaWorkgroup.AthenaWorkgroupConfigurationCustomerContentEncryptionConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "engineVersion", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationEngineVersionOutputReference\"}")]
        public virtual aws.AthenaWorkgroup.AthenaWorkgroupConfigurationEngineVersionOutputReference EngineVersion
        {
            get => GetInstanceProperty<aws.AthenaWorkgroup.AthenaWorkgroupConfigurationEngineVersionOutputReference>()!;
        }

        [JsiiProperty(name: "identityCenterConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationIdentityCenterConfigurationOutputReference\"}")]
        public virtual aws.AthenaWorkgroup.AthenaWorkgroupConfigurationIdentityCenterConfigurationOutputReference IdentityCenterConfiguration
        {
            get => GetInstanceProperty<aws.AthenaWorkgroup.AthenaWorkgroupConfigurationIdentityCenterConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "managedQueryResultsConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationManagedQueryResultsConfigurationOutputReference\"}")]
        public virtual aws.AthenaWorkgroup.AthenaWorkgroupConfigurationManagedQueryResultsConfigurationOutputReference ManagedQueryResultsConfiguration
        {
            get => GetInstanceProperty<aws.AthenaWorkgroup.AthenaWorkgroupConfigurationManagedQueryResultsConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "monitoringConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfigurationOutputReference\"}")]
        public virtual aws.AthenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfigurationOutputReference MonitoringConfiguration
        {
            get => GetInstanceProperty<aws.AthenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "queryResultsS3AccessGrantsConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationQueryResultsS3AccessGrantsConfigurationOutputReference\"}")]
        public virtual aws.AthenaWorkgroup.AthenaWorkgroupConfigurationQueryResultsS3AccessGrantsConfigurationOutputReference QueryResultsS3AccessGrantsConfiguration
        {
            get => GetInstanceProperty<aws.AthenaWorkgroup.AthenaWorkgroupConfigurationQueryResultsS3AccessGrantsConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "resultConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationResultConfigurationOutputReference\"}")]
        public virtual aws.AthenaWorkgroup.AthenaWorkgroupConfigurationResultConfigurationOutputReference ResultConfiguration
        {
            get => GetInstanceProperty<aws.AthenaWorkgroup.AthenaWorkgroupConfigurationResultConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bytesScannedCutoffPerQueryInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BytesScannedCutoffPerQueryInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customerContentEncryptionConfigurationInput", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationCustomerContentEncryptionConfiguration\"}", isOptional: true)]
        public virtual aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationCustomerContentEncryptionConfiguration? CustomerContentEncryptionConfigurationInput
        {
            get => GetInstanceProperty<aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationCustomerContentEncryptionConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableMinimumEncryptionConfigurationInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableMinimumEncryptionConfigurationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enforceWorkgroupConfigurationInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnforceWorkgroupConfigurationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "engineVersionInput", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationEngineVersion\"}", isOptional: true)]
        public virtual aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationEngineVersion? EngineVersionInput
        {
            get => GetInstanceProperty<aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationEngineVersion?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "executionRoleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExecutionRoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityCenterConfigurationInput", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationIdentityCenterConfiguration\"}", isOptional: true)]
        public virtual aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationIdentityCenterConfiguration? IdentityCenterConfigurationInput
        {
            get => GetInstanceProperty<aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationIdentityCenterConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managedQueryResultsConfigurationInput", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationManagedQueryResultsConfiguration\"}", isOptional: true)]
        public virtual aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationManagedQueryResultsConfiguration? ManagedQueryResultsConfigurationInput
        {
            get => GetInstanceProperty<aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationManagedQueryResultsConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "monitoringConfigurationInput", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfiguration\"}", isOptional: true)]
        public virtual aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfiguration? MonitoringConfigurationInput
        {
            get => GetInstanceProperty<aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publishCloudwatchMetricsEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? PublishCloudwatchMetricsEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryResultsS3AccessGrantsConfigurationInput", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationQueryResultsS3AccessGrantsConfiguration\"}", isOptional: true)]
        public virtual aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationQueryResultsS3AccessGrantsConfiguration? QueryResultsS3AccessGrantsConfigurationInput
        {
            get => GetInstanceProperty<aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationQueryResultsS3AccessGrantsConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requesterPaysEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? RequesterPaysEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resultConfigurationInput", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationResultConfiguration\"}", isOptional: true)]
        public virtual aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationResultConfiguration? ResultConfigurationInput
        {
            get => GetInstanceProperty<aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationResultConfiguration?>();
        }

        [JsiiProperty(name: "bytesScannedCutoffPerQuery", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BytesScannedCutoffPerQuery
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enableMinimumEncryptionConfiguration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object EnableMinimumEncryptionConfiguration
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

        [JsiiProperty(name: "enforceWorkgroupConfiguration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object EnforceWorkgroupConfiguration
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

        [JsiiProperty(name: "executionRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutionRole
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "publishCloudwatchMetricsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object PublishCloudwatchMetricsEnabled
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

        [JsiiProperty(name: "requesterPaysEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object RequesterPaysEnabled
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfiguration\"}", isOptional: true)]
        public virtual aws.AthenaWorkgroup.IAthenaWorkgroupConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.AthenaWorkgroup.IAthenaWorkgroupConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
