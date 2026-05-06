using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciApigatewayDeployment
{
    [JsiiClass(nativeType: typeof(oci.DataOciApigatewayDeployment.DataOciApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyOutputReference), fullyQualifiedName: "oci.dataOciApigatewayDeployment.DataOciApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "clientDetails", typeJson: "{\"fqn\":\"oci.dataOciApigatewayDeployment.DataOciApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyClientDetailsList\"}")]
        public virtual oci.DataOciApigatewayDeployment.DataOciApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyClientDetailsList ClientDetails
        {
            get => GetInstanceProperty<oci.DataOciApigatewayDeployment.DataOciApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyClientDetailsList>()!;
        }

        [JsiiProperty(name: "fallbackRedirectPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FallbackRedirectPath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logoutPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogoutPath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maxExpiryDurationInHours", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxExpiryDurationInHours
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "responseCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResponseCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "responseHeaderTransformations", typeJson: "{\"fqn\":\"oci.dataOciApigatewayDeployment.DataOciApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyResponseHeaderTransformationsList\"}")]
        public virtual oci.DataOciApigatewayDeployment.DataOciApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyResponseHeaderTransformationsList ResponseHeaderTransformations
        {
            get => GetInstanceProperty<oci.DataOciApigatewayDeployment.DataOciApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicyResponseHeaderTransformationsList>()!;
        }

        [JsiiProperty(name: "responseMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResponseMessage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "responseType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResponseType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Scopes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "sourceUriDetails", typeJson: "{\"fqn\":\"oci.dataOciApigatewayDeployment.DataOciApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicySourceUriDetailsList\"}")]
        public virtual oci.DataOciApigatewayDeployment.DataOciApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicySourceUriDetailsList SourceUriDetails
        {
            get => GetInstanceProperty<oci.DataOciApigatewayDeployment.DataOciApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicySourceUriDetailsList>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "useCookiesForIntermediateSteps", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable UseCookiesForIntermediateSteps
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "useCookiesForSession", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable UseCookiesForSession
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "usePkce", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable UsePkce
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciApigatewayDeployment.DataOciApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicy\"}", isOptional: true)]
        public virtual oci.DataOciApigatewayDeployment.IDataOciApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicy? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciApigatewayDeployment.IDataOciApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationFailurePolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
