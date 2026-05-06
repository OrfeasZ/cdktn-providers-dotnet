using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayDeployment
{
    [JsiiClass(nativeType: typeof(oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsOutputReference), fullyQualifiedName: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFilterQueryParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsFilterQueryParameters\"}}]")]
        public virtual void PutFilterQueryParameters(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsFilterQueryParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsFilterQueryParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRenameQueryParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsRenameQueryParameters\"}}]")]
        public virtual void PutRenameQueryParameters(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsRenameQueryParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsRenameQueryParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSetQueryParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsSetQueryParameters\"}}]")]
        public virtual void PutSetQueryParameters(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsSetQueryParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsSetQueryParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFilterQueryParameters")]
        public virtual void ResetFilterQueryParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRenameQueryParameters")]
        public virtual void ResetRenameQueryParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSetQueryParameters")]
        public virtual void ResetSetQueryParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "filterQueryParameters", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsFilterQueryParametersOutputReference\"}")]
        public virtual oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsFilterQueryParametersOutputReference FilterQueryParameters
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsFilterQueryParametersOutputReference>()!;
        }

        [JsiiProperty(name: "renameQueryParameters", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsRenameQueryParametersOutputReference\"}")]
        public virtual oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsRenameQueryParametersOutputReference RenameQueryParameters
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsRenameQueryParametersOutputReference>()!;
        }

        [JsiiProperty(name: "setQueryParameters", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsSetQueryParametersOutputReference\"}")]
        public virtual oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsSetQueryParametersOutputReference SetQueryParameters
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsSetQueryParametersOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterQueryParametersInput", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsFilterQueryParameters\"}", isOptional: true)]
        public virtual oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsFilterQueryParameters? FilterQueryParametersInput
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsFilterQueryParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "renameQueryParametersInput", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsRenameQueryParameters\"}", isOptional: true)]
        public virtual oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsRenameQueryParameters? RenameQueryParametersInput
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsRenameQueryParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "setQueryParametersInput", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsSetQueryParameters\"}", isOptional: true)]
        public virtual oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsSetQueryParameters? SetQueryParametersInput
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsSetQueryParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformations\"}", isOptional: true)]
        public virtual oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformations? InternalValue
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformations?>();
            set => SetInstanceProperty(value);
        }
    }
}
