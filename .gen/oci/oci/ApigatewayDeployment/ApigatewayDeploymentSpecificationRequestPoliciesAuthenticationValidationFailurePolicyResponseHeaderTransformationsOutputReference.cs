using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayDeployment
{
    [JsiiClass(nativeType: typeof(oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformationsOutputReference), fullyQualifiedName: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformationsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformationsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformationsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformationsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformationsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFilterHeaders", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformationsFilterHeaders\"}}]")]
        public virtual void PutFilterHeaders(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformationsFilterHeaders @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformationsFilterHeaders)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRenameHeaders", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformationsRenameHeaders\"}}]")]
        public virtual void PutRenameHeaders(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformationsRenameHeaders @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformationsRenameHeaders)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSetHeaders", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformationsSetHeaders\"}}]")]
        public virtual void PutSetHeaders(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformationsSetHeaders @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformationsSetHeaders)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFilterHeaders")]
        public virtual void ResetFilterHeaders()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRenameHeaders")]
        public virtual void ResetRenameHeaders()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSetHeaders")]
        public virtual void ResetSetHeaders()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "filterHeaders", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformationsFilterHeadersOutputReference\"}")]
        public virtual oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformationsFilterHeadersOutputReference FilterHeaders
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformationsFilterHeadersOutputReference>()!;
        }

        [JsiiProperty(name: "renameHeaders", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformationsRenameHeadersOutputReference\"}")]
        public virtual oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformationsRenameHeadersOutputReference RenameHeaders
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformationsRenameHeadersOutputReference>()!;
        }

        [JsiiProperty(name: "setHeaders", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformationsSetHeadersOutputReference\"}")]
        public virtual oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformationsSetHeadersOutputReference SetHeaders
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformationsSetHeadersOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterHeadersInput", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformationsFilterHeaders\"}", isOptional: true)]
        public virtual oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformationsFilterHeaders? FilterHeadersInput
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformationsFilterHeaders?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "renameHeadersInput", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformationsRenameHeaders\"}", isOptional: true)]
        public virtual oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformationsRenameHeaders? RenameHeadersInput
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformationsRenameHeaders?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "setHeadersInput", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformationsSetHeaders\"}", isOptional: true)]
        public virtual oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformationsSetHeaders? SetHeadersInput
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformationsSetHeaders?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformations\"}", isOptional: true)]
        public virtual oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformations? InternalValue
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformations?>();
            set => SetInstanceProperty(value);
        }
    }
}
