using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciApigatewayApiDeploymentSpecification
{
    [JsiiClass(nativeType: typeof(oci.DataOciApigatewayApiDeploymentSpecification.DataOciApigatewayApiDeploymentSpecificationRequestPoliciesOutputReference), fullyQualifiedName: "oci.dataOciApigatewayApiDeploymentSpecification.DataOciApigatewayApiDeploymentSpecificationRequestPoliciesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciApigatewayApiDeploymentSpecificationRequestPoliciesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciApigatewayApiDeploymentSpecificationRequestPoliciesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciApigatewayApiDeploymentSpecificationRequestPoliciesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciApigatewayApiDeploymentSpecificationRequestPoliciesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "authentication", typeJson: "{\"fqn\":\"oci.dataOciApigatewayApiDeploymentSpecification.DataOciApigatewayApiDeploymentSpecificationRequestPoliciesAuthenticationList\"}")]
        public virtual oci.DataOciApigatewayApiDeploymentSpecification.DataOciApigatewayApiDeploymentSpecificationRequestPoliciesAuthenticationList Authentication
        {
            get => GetInstanceProperty<oci.DataOciApigatewayApiDeploymentSpecification.DataOciApigatewayApiDeploymentSpecificationRequestPoliciesAuthenticationList>()!;
        }

        [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"oci.dataOciApigatewayApiDeploymentSpecification.DataOciApigatewayApiDeploymentSpecificationRequestPoliciesCorsList\"}")]
        public virtual oci.DataOciApigatewayApiDeploymentSpecification.DataOciApigatewayApiDeploymentSpecificationRequestPoliciesCorsList Cors
        {
            get => GetInstanceProperty<oci.DataOciApigatewayApiDeploymentSpecification.DataOciApigatewayApiDeploymentSpecificationRequestPoliciesCorsList>()!;
        }

        [JsiiProperty(name: "dynamicAuthentication", typeJson: "{\"fqn\":\"oci.dataOciApigatewayApiDeploymentSpecification.DataOciApigatewayApiDeploymentSpecificationRequestPoliciesDynamicAuthenticationList\"}")]
        public virtual oci.DataOciApigatewayApiDeploymentSpecification.DataOciApigatewayApiDeploymentSpecificationRequestPoliciesDynamicAuthenticationList DynamicAuthentication
        {
            get => GetInstanceProperty<oci.DataOciApigatewayApiDeploymentSpecification.DataOciApigatewayApiDeploymentSpecificationRequestPoliciesDynamicAuthenticationList>()!;
        }

        [JsiiProperty(name: "mutualTls", typeJson: "{\"fqn\":\"oci.dataOciApigatewayApiDeploymentSpecification.DataOciApigatewayApiDeploymentSpecificationRequestPoliciesMutualTlsList\"}")]
        public virtual oci.DataOciApigatewayApiDeploymentSpecification.DataOciApigatewayApiDeploymentSpecificationRequestPoliciesMutualTlsList MutualTls
        {
            get => GetInstanceProperty<oci.DataOciApigatewayApiDeploymentSpecification.DataOciApigatewayApiDeploymentSpecificationRequestPoliciesMutualTlsList>()!;
        }

        [JsiiProperty(name: "rateLimiting", typeJson: "{\"fqn\":\"oci.dataOciApigatewayApiDeploymentSpecification.DataOciApigatewayApiDeploymentSpecificationRequestPoliciesRateLimitingList\"}")]
        public virtual oci.DataOciApigatewayApiDeploymentSpecification.DataOciApigatewayApiDeploymentSpecificationRequestPoliciesRateLimitingList RateLimiting
        {
            get => GetInstanceProperty<oci.DataOciApigatewayApiDeploymentSpecification.DataOciApigatewayApiDeploymentSpecificationRequestPoliciesRateLimitingList>()!;
        }

        [JsiiProperty(name: "usagePlans", typeJson: "{\"fqn\":\"oci.dataOciApigatewayApiDeploymentSpecification.DataOciApigatewayApiDeploymentSpecificationRequestPoliciesUsagePlansList\"}")]
        public virtual oci.DataOciApigatewayApiDeploymentSpecification.DataOciApigatewayApiDeploymentSpecificationRequestPoliciesUsagePlansList UsagePlans
        {
            get => GetInstanceProperty<oci.DataOciApigatewayApiDeploymentSpecification.DataOciApigatewayApiDeploymentSpecificationRequestPoliciesUsagePlansList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciApigatewayApiDeploymentSpecification.DataOciApigatewayApiDeploymentSpecificationRequestPolicies\"}", isOptional: true)]
        public virtual oci.DataOciApigatewayApiDeploymentSpecification.IDataOciApigatewayApiDeploymentSpecificationRequestPolicies? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciApigatewayApiDeploymentSpecification.IDataOciApigatewayApiDeploymentSpecificationRequestPolicies?>();
            set => SetInstanceProperty(value);
        }
    }
}
