using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayDeployment
{
    [JsiiClass(nativeType: typeof(oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationOutputReference), fullyQualifiedName: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApigatewayDeploymentSpecificationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApigatewayDeploymentSpecificationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApigatewayDeploymentSpecificationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApigatewayDeploymentSpecificationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLoggingPolicies", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationLoggingPolicies\"}}]")]
        public virtual void PutLoggingPolicies(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationLoggingPolicies @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationLoggingPolicies)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRequestPolicies", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPolicies\"}}]")]
        public virtual void PutRequestPolicies(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPolicies @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPolicies)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRoutes", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutes\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRoutes(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutes[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutes).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutes).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetLoggingPolicies")]
        public virtual void ResetLoggingPolicies()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequestPolicies")]
        public virtual void ResetRequestPolicies()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "loggingPolicies", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationLoggingPoliciesOutputReference\"}")]
        public virtual oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationLoggingPoliciesOutputReference LoggingPolicies
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationLoggingPoliciesOutputReference>()!;
        }

        [JsiiProperty(name: "requestPolicies", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesOutputReference\"}")]
        public virtual oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesOutputReference RequestPolicies
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesOutputReference>()!;
        }

        [JsiiProperty(name: "routes", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesList\"}")]
        public virtual oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRoutesList Routes
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRoutesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "loggingPoliciesInput", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationLoggingPolicies\"}", isOptional: true)]
        public virtual oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationLoggingPolicies? LoggingPoliciesInput
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationLoggingPolicies?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestPoliciesInput", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPolicies\"}", isOptional: true)]
        public virtual oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPolicies? RequestPoliciesInput
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPolicies?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RoutesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecification\"}", isOptional: true)]
        public virtual oci.ApigatewayDeployment.IApigatewayDeploymentSpecification? InternalValue
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.IApigatewayDeploymentSpecification?>();
            set => SetInstanceProperty(value);
        }
    }
}
