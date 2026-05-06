using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayDeployment
{
    [JsiiClass(nativeType: typeof(oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyResponseHeaderTransformationsOutputReference), fullyQualifiedName: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyResponseHeaderTransformationsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyResponseHeaderTransformationsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyResponseHeaderTransformationsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyResponseHeaderTransformationsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyResponseHeaderTransformationsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFilterHeaders", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyResponseHeaderTransformationsFilterHeaders\"}}]")]
        public virtual void PutFilterHeaders(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyResponseHeaderTransformationsFilterHeaders @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyResponseHeaderTransformationsFilterHeaders)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRenameHeaders", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyResponseHeaderTransformationsRenameHeaders\"}}]")]
        public virtual void PutRenameHeaders(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyResponseHeaderTransformationsRenameHeaders @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyResponseHeaderTransformationsRenameHeaders)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSetHeaders", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyResponseHeaderTransformationsSetHeaders\"}}]")]
        public virtual void PutSetHeaders(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyResponseHeaderTransformationsSetHeaders @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyResponseHeaderTransformationsSetHeaders)}, new object[]{@value});
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

        [JsiiProperty(name: "filterHeaders", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyResponseHeaderTransformationsFilterHeadersOutputReference\"}")]
        public virtual oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyResponseHeaderTransformationsFilterHeadersOutputReference FilterHeaders
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyResponseHeaderTransformationsFilterHeadersOutputReference>()!;
        }

        [JsiiProperty(name: "renameHeaders", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyResponseHeaderTransformationsRenameHeadersOutputReference\"}")]
        public virtual oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyResponseHeaderTransformationsRenameHeadersOutputReference RenameHeaders
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyResponseHeaderTransformationsRenameHeadersOutputReference>()!;
        }

        [JsiiProperty(name: "setHeaders", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyResponseHeaderTransformationsSetHeadersOutputReference\"}")]
        public virtual oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyResponseHeaderTransformationsSetHeadersOutputReference SetHeaders
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyResponseHeaderTransformationsSetHeadersOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterHeadersInput", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyResponseHeaderTransformationsFilterHeaders\"}", isOptional: true)]
        public virtual oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyResponseHeaderTransformationsFilterHeaders? FilterHeadersInput
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyResponseHeaderTransformationsFilterHeaders?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "renameHeadersInput", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyResponseHeaderTransformationsRenameHeaders\"}", isOptional: true)]
        public virtual oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyResponseHeaderTransformationsRenameHeaders? RenameHeadersInput
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyResponseHeaderTransformationsRenameHeaders?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "setHeadersInput", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyResponseHeaderTransformationsSetHeaders\"}", isOptional: true)]
        public virtual oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyResponseHeaderTransformationsSetHeaders? SetHeadersInput
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyResponseHeaderTransformationsSetHeaders?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyResponseHeaderTransformations\"}", isOptional: true)]
        public virtual oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyResponseHeaderTransformations? InternalValue
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyResponseHeaderTransformations?>();
            set => SetInstanceProperty(value);
        }
    }
}
