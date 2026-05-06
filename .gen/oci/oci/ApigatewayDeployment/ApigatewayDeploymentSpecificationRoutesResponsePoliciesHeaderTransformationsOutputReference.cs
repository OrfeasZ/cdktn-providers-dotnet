using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayDeployment
{
    [JsiiClass(nativeType: typeof(oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformationsOutputReference), fullyQualifiedName: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformationsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformationsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformationsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformationsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformationsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFilterHeaders", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformationsFilterHeaders\"}}]")]
        public virtual void PutFilterHeaders(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformationsFilterHeaders @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformationsFilterHeaders)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRenameHeaders", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformationsRenameHeaders\"}}]")]
        public virtual void PutRenameHeaders(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformationsRenameHeaders @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformationsRenameHeaders)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSetHeaders", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformationsSetHeaders\"}}]")]
        public virtual void PutSetHeaders(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformationsSetHeaders @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformationsSetHeaders)}, new object[]{@value});
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

        [JsiiProperty(name: "filterHeaders", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformationsFilterHeadersOutputReference\"}")]
        public virtual oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformationsFilterHeadersOutputReference FilterHeaders
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformationsFilterHeadersOutputReference>()!;
        }

        [JsiiProperty(name: "renameHeaders", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformationsRenameHeadersOutputReference\"}")]
        public virtual oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformationsRenameHeadersOutputReference RenameHeaders
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformationsRenameHeadersOutputReference>()!;
        }

        [JsiiProperty(name: "setHeaders", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformationsSetHeadersOutputReference\"}")]
        public virtual oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformationsSetHeadersOutputReference SetHeaders
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformationsSetHeadersOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterHeadersInput", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformationsFilterHeaders\"}", isOptional: true)]
        public virtual oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformationsFilterHeaders? FilterHeadersInput
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformationsFilterHeaders?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "renameHeadersInput", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformationsRenameHeaders\"}", isOptional: true)]
        public virtual oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformationsRenameHeaders? RenameHeadersInput
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformationsRenameHeaders?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "setHeadersInput", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformationsSetHeaders\"}", isOptional: true)]
        public virtual oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformationsSetHeaders? SetHeadersInput
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformationsSetHeaders?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformations\"}", isOptional: true)]
        public virtual oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformations? InternalValue
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformations?>();
            set => SetInstanceProperty(value);
        }
    }
}
