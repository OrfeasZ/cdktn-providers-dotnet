using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementBackend
{
    [JsiiClass(nativeType: typeof(azurerm.ApiManagementBackend.ApiManagementBackendCircuitBreakerRuleOutputReference), fullyQualifiedName: "azurerm.apiManagementBackend.ApiManagementBackendCircuitBreakerRuleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApiManagementBackendCircuitBreakerRuleOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApiManagementBackendCircuitBreakerRuleOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApiManagementBackendCircuitBreakerRuleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiManagementBackendCircuitBreakerRuleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFailureCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.apiManagementBackend.ApiManagementBackendCircuitBreakerRuleFailureCondition\"}}]")]
        public virtual void PutFailureCondition(azurerm.ApiManagementBackend.IApiManagementBackendCircuitBreakerRuleFailureCondition @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ApiManagementBackend.IApiManagementBackendCircuitBreakerRuleFailureCondition)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAcceptRetryAfterEnabled")]
        public virtual void ResetAcceptRetryAfterEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "failureCondition", typeJson: "{\"fqn\":\"azurerm.apiManagementBackend.ApiManagementBackendCircuitBreakerRuleFailureConditionOutputReference\"}")]
        public virtual azurerm.ApiManagementBackend.ApiManagementBackendCircuitBreakerRuleFailureConditionOutputReference FailureCondition
        {
            get => GetInstanceProperty<azurerm.ApiManagementBackend.ApiManagementBackendCircuitBreakerRuleFailureConditionOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acceptRetryAfterEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AcceptRetryAfterEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "failureConditionInput", typeJson: "{\"fqn\":\"azurerm.apiManagementBackend.ApiManagementBackendCircuitBreakerRuleFailureCondition\"}", isOptional: true)]
        public virtual azurerm.ApiManagementBackend.IApiManagementBackendCircuitBreakerRuleFailureCondition? FailureConditionInput
        {
            get => GetInstanceProperty<azurerm.ApiManagementBackend.IApiManagementBackendCircuitBreakerRuleFailureCondition?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tripDurationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TripDurationInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "acceptRetryAfterEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object AcceptRetryAfterEnabled
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tripDuration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TripDuration
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.apiManagementBackend.ApiManagementBackendCircuitBreakerRule\"}", isOptional: true)]
        public virtual azurerm.ApiManagementBackend.IApiManagementBackendCircuitBreakerRule? InternalValue
        {
            get => GetInstanceProperty<azurerm.ApiManagementBackend.IApiManagementBackendCircuitBreakerRule?>();
            set => SetInstanceProperty(value);
        }
    }
}
