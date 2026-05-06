using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayDeployment
{
    [JsiiClass(nativeType: typeof(oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesRateLimitingOutputReference), fullyQualifiedName: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesRateLimitingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApigatewayDeploymentSpecificationRequestPoliciesRateLimitingOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApigatewayDeploymentSpecificationRequestPoliciesRateLimitingOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApigatewayDeploymentSpecificationRequestPoliciesRateLimitingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApigatewayDeploymentSpecificationRequestPoliciesRateLimitingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "rateInRequestsPerSecondInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RateInRequestsPerSecondInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rateKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RateKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "rateInRequestsPerSecond", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RateInRequestsPerSecond
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rateKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RateKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesRateLimiting\"}", isOptional: true)]
        public virtual oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesRateLimiting? InternalValue
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesRateLimiting?>();
            set => SetInstanceProperty(value);
        }
    }
}
