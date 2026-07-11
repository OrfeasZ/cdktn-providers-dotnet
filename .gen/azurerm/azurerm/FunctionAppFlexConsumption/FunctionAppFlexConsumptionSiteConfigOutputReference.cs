using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FunctionAppFlexConsumption
{
    [JsiiClass(nativeType: typeof(azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionSiteConfigOutputReference), fullyQualifiedName: "azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionSiteConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FunctionAppFlexConsumptionSiteConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public FunctionAppFlexConsumptionSiteConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected FunctionAppFlexConsumptionSiteConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FunctionAppFlexConsumptionSiteConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAppServiceLogs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionSiteConfigAppServiceLogs\"}}]")]
        public virtual void PutAppServiceLogs(azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionSiteConfigAppServiceLogs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionSiteConfigAppServiceLogs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCors", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionSiteConfigCors\"}}]")]
        public virtual void PutCors(azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionSiteConfigCors @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionSiteConfigCors)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionSiteConfigIpRestriction" />)[]</param>
        [JsiiMethod(name: "putIpRestriction", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionSiteConfigIpRestriction\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutIpRestriction(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionSiteConfigIpRestriction[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionSiteConfigIpRestriction).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionSiteConfigIpRestriction).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionSiteConfigScmIpRestriction" />)[]</param>
        [JsiiMethod(name: "putScmIpRestriction", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionSiteConfigScmIpRestriction\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutScmIpRestriction(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionSiteConfigScmIpRestriction[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionSiteConfigScmIpRestriction).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionSiteConfigScmIpRestriction).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApiDefinitionUrl")]
        public virtual void ResetApiDefinitionUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetApiManagementApiId")]
        public virtual void ResetApiManagementApiId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAppCommandLine")]
        public virtual void ResetAppCommandLine()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetApplicationInsightsConnectionString")]
        public virtual void ResetApplicationInsightsConnectionString()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetApplicationInsightsKey")]
        public virtual void ResetApplicationInsightsKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAppServiceLogs")]
        public virtual void ResetAppServiceLogs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContainerRegistryManagedIdentityClientId")]
        public virtual void ResetContainerRegistryManagedIdentityClientId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContainerRegistryUseManagedIdentity")]
        public virtual void ResetContainerRegistryUseManagedIdentity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCors")]
        public virtual void ResetCors()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultDocuments")]
        public virtual void ResetDefaultDocuments()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetElasticInstanceMinimum")]
        public virtual void ResetElasticInstanceMinimum()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheckEvictionTimeInMin")]
        public virtual void ResetHealthCheckEvictionTimeInMin()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheckPath")]
        public virtual void ResetHealthCheckPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttp2Enabled")]
        public virtual void ResetHttp2Enabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpRestriction")]
        public virtual void ResetIpRestriction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpRestrictionDefaultAction")]
        public virtual void ResetIpRestrictionDefaultAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoadBalancingMode")]
        public virtual void ResetLoadBalancingMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetManagedPipelineMode")]
        public virtual void ResetManagedPipelineMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinimumTlsVersion")]
        public virtual void ResetMinimumTlsVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRemoteDebuggingEnabled")]
        public virtual void ResetRemoteDebuggingEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRemoteDebuggingVersion")]
        public virtual void ResetRemoteDebuggingVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRuntimeScaleMonitoringEnabled")]
        public virtual void ResetRuntimeScaleMonitoringEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScmIpRestriction")]
        public virtual void ResetScmIpRestriction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScmIpRestrictionDefaultAction")]
        public virtual void ResetScmIpRestrictionDefaultAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScmMinimumTlsVersion")]
        public virtual void ResetScmMinimumTlsVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScmUseMainIpRestriction")]
        public virtual void ResetScmUseMainIpRestriction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUse32BitWorker")]
        public virtual void ResetUse32BitWorker()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVnetRouteAllEnabled")]
        public virtual void ResetVnetRouteAllEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWebsocketsEnabled")]
        public virtual void ResetWebsocketsEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWorkerCount")]
        public virtual void ResetWorkerCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "appServiceLogs", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionSiteConfigAppServiceLogsOutputReference\"}")]
        public virtual azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionSiteConfigAppServiceLogsOutputReference AppServiceLogs
        {
            get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionSiteConfigAppServiceLogsOutputReference>()!;
        }

        [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionSiteConfigCorsOutputReference\"}")]
        public virtual azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionSiteConfigCorsOutputReference Cors
        {
            get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionSiteConfigCorsOutputReference>()!;
        }

        [JsiiProperty(name: "detailedErrorLoggingEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DetailedErrorLoggingEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "ipRestriction", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionSiteConfigIpRestrictionList\"}")]
        public virtual azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionSiteConfigIpRestrictionList IpRestriction
        {
            get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionSiteConfigIpRestrictionList>()!;
        }

        [JsiiProperty(name: "scmIpRestriction", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionSiteConfigScmIpRestrictionList\"}")]
        public virtual azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionSiteConfigScmIpRestrictionList ScmIpRestriction
        {
            get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.FunctionAppFlexConsumptionSiteConfigScmIpRestrictionList>()!;
        }

        [JsiiProperty(name: "scmType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScmType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiDefinitionUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApiDefinitionUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiManagementApiIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApiManagementApiIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "appCommandLineInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AppCommandLineInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationInsightsConnectionStringInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApplicationInsightsConnectionStringInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationInsightsKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApplicationInsightsKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "appServiceLogsInput", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionSiteConfigAppServiceLogs\"}", isOptional: true)]
        public virtual azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionSiteConfigAppServiceLogs? AppServiceLogsInput
        {
            get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionSiteConfigAppServiceLogs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerRegistryManagedIdentityClientIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContainerRegistryManagedIdentityClientIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "containerRegistryUseManagedIdentityInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ContainerRegistryUseManagedIdentityInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "corsInput", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionSiteConfigCors\"}", isOptional: true)]
        public virtual azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionSiteConfigCors? CorsInput
        {
            get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionSiteConfigCors?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultDocumentsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? DefaultDocumentsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "elasticInstanceMinimumInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ElasticInstanceMinimumInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckEvictionTimeInMinInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HealthCheckEvictionTimeInMinInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckPathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HealthCheckPathInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "http2EnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? Http2EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipRestrictionDefaultActionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IpRestrictionDefaultActionInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionSiteConfigIpRestriction" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipRestrictionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionSiteConfigIpRestriction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? IpRestrictionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loadBalancingModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LoadBalancingModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managedPipelineModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ManagedPipelineModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minimumTlsVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MinimumTlsVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "remoteDebuggingEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? RemoteDebuggingEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "remoteDebuggingVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RemoteDebuggingVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "runtimeScaleMonitoringEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? RuntimeScaleMonitoringEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scmIpRestrictionDefaultActionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScmIpRestrictionDefaultActionInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionSiteConfigScmIpRestriction" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scmIpRestrictionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionSiteConfigScmIpRestriction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ScmIpRestrictionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scmMinimumTlsVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScmMinimumTlsVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scmUseMainIpRestrictionInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ScmUseMainIpRestrictionInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "use32BitWorkerInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? Use32BitWorkerInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vnetRouteAllEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? VnetRouteAllEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "websocketsEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? WebsocketsEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workerCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? WorkerCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "apiDefinitionUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApiDefinitionUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "apiManagementApiId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApiManagementApiId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "appCommandLine", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AppCommandLine
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "applicationInsightsConnectionString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationInsightsConnectionString
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "applicationInsightsKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationInsightsKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "containerRegistryManagedIdentityClientId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerRegistryManagedIdentityClientId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "containerRegistryUseManagedIdentity", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object ContainerRegistryUseManagedIdentity
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

        [JsiiProperty(name: "defaultDocuments", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DefaultDocuments
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "elasticInstanceMinimum", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ElasticInstanceMinimum
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "healthCheckEvictionTimeInMin", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HealthCheckEvictionTimeInMin
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "healthCheckPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HealthCheckPath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "http2Enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Http2Enabled
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

        [JsiiProperty(name: "ipRestrictionDefaultAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpRestrictionDefaultAction
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loadBalancingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoadBalancingMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "managedPipelineMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedPipelineMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minimumTlsVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MinimumTlsVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "remoteDebuggingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object RemoteDebuggingEnabled
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

        [JsiiProperty(name: "remoteDebuggingVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RemoteDebuggingVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "runtimeScaleMonitoringEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object RuntimeScaleMonitoringEnabled
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

        [JsiiProperty(name: "scmIpRestrictionDefaultAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScmIpRestrictionDefaultAction
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scmMinimumTlsVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScmMinimumTlsVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "scmUseMainIpRestriction", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object ScmUseMainIpRestriction
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

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "use32BitWorker", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Use32BitWorker
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

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "vnetRouteAllEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object VnetRouteAllEnabled
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

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "websocketsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object WebsocketsEnabled
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

        [JsiiProperty(name: "workerCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WorkerCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionSiteConfig\"}", isOptional: true)]
        public virtual azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionSiteConfig? InternalValue
        {
            get => GetInstanceProperty<azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionSiteConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
