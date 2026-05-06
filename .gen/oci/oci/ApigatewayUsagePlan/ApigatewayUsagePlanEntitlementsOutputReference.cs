using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayUsagePlan
{
    [JsiiClass(nativeType: typeof(oci.ApigatewayUsagePlan.ApigatewayUsagePlanEntitlementsOutputReference), fullyQualifiedName: "oci.apigatewayUsagePlan.ApigatewayUsagePlanEntitlementsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ApigatewayUsagePlanEntitlementsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public ApigatewayUsagePlanEntitlementsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected ApigatewayUsagePlanEntitlementsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApigatewayUsagePlanEntitlementsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putQuota", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.apigatewayUsagePlan.ApigatewayUsagePlanEntitlementsQuota\"}}]")]
        public virtual void PutQuota(oci.ApigatewayUsagePlan.IApigatewayUsagePlanEntitlementsQuota @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ApigatewayUsagePlan.IApigatewayUsagePlanEntitlementsQuota)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRateLimit", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.apigatewayUsagePlan.ApigatewayUsagePlanEntitlementsRateLimit\"}}]")]
        public virtual void PutRateLimit(oci.ApigatewayUsagePlan.IApigatewayUsagePlanEntitlementsRateLimit @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ApigatewayUsagePlan.IApigatewayUsagePlanEntitlementsRateLimit)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTargets", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apigatewayUsagePlan.ApigatewayUsagePlanEntitlementsTargets\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTargets(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.ApigatewayUsagePlan.IApigatewayUsagePlanEntitlementsTargets[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ApigatewayUsagePlan.IApigatewayUsagePlanEntitlementsTargets).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ApigatewayUsagePlan.IApigatewayUsagePlanEntitlementsTargets).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQuota")]
        public virtual void ResetQuota()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRateLimit")]
        public virtual void ResetRateLimit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargets")]
        public virtual void ResetTargets()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "quota", typeJson: "{\"fqn\":\"oci.apigatewayUsagePlan.ApigatewayUsagePlanEntitlementsQuotaOutputReference\"}")]
        public virtual oci.ApigatewayUsagePlan.ApigatewayUsagePlanEntitlementsQuotaOutputReference Quota
        {
            get => GetInstanceProperty<oci.ApigatewayUsagePlan.ApigatewayUsagePlanEntitlementsQuotaOutputReference>()!;
        }

        [JsiiProperty(name: "rateLimit", typeJson: "{\"fqn\":\"oci.apigatewayUsagePlan.ApigatewayUsagePlanEntitlementsRateLimitOutputReference\"}")]
        public virtual oci.ApigatewayUsagePlan.ApigatewayUsagePlanEntitlementsRateLimitOutputReference RateLimit
        {
            get => GetInstanceProperty<oci.ApigatewayUsagePlan.ApigatewayUsagePlanEntitlementsRateLimitOutputReference>()!;
        }

        [JsiiProperty(name: "targets", typeJson: "{\"fqn\":\"oci.apigatewayUsagePlan.ApigatewayUsagePlanEntitlementsTargetsList\"}")]
        public virtual oci.ApigatewayUsagePlan.ApigatewayUsagePlanEntitlementsTargetsList Targets
        {
            get => GetInstanceProperty<oci.ApigatewayUsagePlan.ApigatewayUsagePlanEntitlementsTargetsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
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
        [JsiiProperty(name: "quotaInput", typeJson: "{\"fqn\":\"oci.apigatewayUsagePlan.ApigatewayUsagePlanEntitlementsQuota\"}", isOptional: true)]
        public virtual oci.ApigatewayUsagePlan.IApigatewayUsagePlanEntitlementsQuota? QuotaInput
        {
            get => GetInstanceProperty<oci.ApigatewayUsagePlan.IApigatewayUsagePlanEntitlementsQuota?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rateLimitInput", typeJson: "{\"fqn\":\"oci.apigatewayUsagePlan.ApigatewayUsagePlanEntitlementsRateLimit\"}", isOptional: true)]
        public virtual oci.ApigatewayUsagePlan.IApigatewayUsagePlanEntitlementsRateLimit? RateLimitInput
        {
            get => GetInstanceProperty<oci.ApigatewayUsagePlan.IApigatewayUsagePlanEntitlementsRateLimit?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apigatewayUsagePlan.ApigatewayUsagePlanEntitlementsTargets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TargetsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
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

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.apigatewayUsagePlan.ApigatewayUsagePlanEntitlements\"}]}}", isOptional: true)]
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
                        case oci.ApigatewayUsagePlan.IApigatewayUsagePlanEntitlements cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ApigatewayUsagePlan.IApigatewayUsagePlanEntitlements).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
