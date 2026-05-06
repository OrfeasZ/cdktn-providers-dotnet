using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayDeployment
{
    [JsiiClass(nativeType: typeof(oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyOutputReference), fullyQualifiedName: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAdditionalValidationPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyAdditionalValidationPolicy\"}}]")]
        public virtual void PutAdditionalValidationPolicy(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyAdditionalValidationPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyAdditionalValidationPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putClientDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyClientDetails\"}}]")]
        public virtual void PutClientDetails(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyClientDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyClientDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKeys", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyKeys\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutKeys(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyKeys[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyKeys).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyKeys).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourceUriDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicySourceUriDetails\"}}]")]
        public virtual void PutSourceUriDetails(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicySourceUriDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicySourceUriDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdditionalValidationPolicy")]
        public virtual void ResetAdditionalValidationPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientDetails")]
        public virtual void ResetClientDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsSslVerifyDisabled")]
        public virtual void ResetIsSslVerifyDisabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKeys")]
        public virtual void ResetKeys()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxCacheDurationInHours")]
        public virtual void ResetMaxCacheDurationInHours()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceUriDetails")]
        public virtual void ResetSourceUriDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUri")]
        public virtual void ResetUri()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "additionalValidationPolicy", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyAdditionalValidationPolicyOutputReference\"}")]
        public virtual oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyAdditionalValidationPolicyOutputReference AdditionalValidationPolicy
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyAdditionalValidationPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "clientDetails", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyClientDetailsOutputReference\"}")]
        public virtual oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyClientDetailsOutputReference ClientDetails
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyClientDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "keys", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyKeysList\"}")]
        public virtual oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyKeysList Keys
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyKeysList>()!;
        }

        [JsiiProperty(name: "sourceUriDetails", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicySourceUriDetailsOutputReference\"}")]
        public virtual oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicySourceUriDetailsOutputReference SourceUriDetails
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicySourceUriDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "additionalValidationPolicyInput", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyAdditionalValidationPolicy\"}", isOptional: true)]
        public virtual oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyAdditionalValidationPolicy? AdditionalValidationPolicyInput
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyAdditionalValidationPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientDetailsInput", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyClientDetails\"}", isOptional: true)]
        public virtual oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyClientDetails? ClientDetailsInput
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyClientDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isSslVerifyDisabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsSslVerifyDisabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keysInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyKeys\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? KeysInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxCacheDurationInHoursInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxCacheDurationInHoursInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceUriDetailsInput", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicySourceUriDetails\"}", isOptional: true)]
        public virtual oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicySourceUriDetails? SourceUriDetailsInput
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicySourceUriDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "uriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "isSslVerifyDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsSslVerifyDisabled
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

        [JsiiProperty(name: "maxCacheDurationInHours", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxCacheDurationInHours
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Uri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicy\"}", isOptional: true)]
        public virtual oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicy? InternalValue
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
