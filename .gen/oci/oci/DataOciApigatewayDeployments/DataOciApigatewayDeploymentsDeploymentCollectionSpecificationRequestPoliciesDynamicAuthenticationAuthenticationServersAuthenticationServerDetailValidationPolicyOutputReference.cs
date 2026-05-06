using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciApigatewayDeployments
{
    [JsiiClass(nativeType: typeof(oci.DataOciApigatewayDeployments.DataOciApigatewayDeploymentsDeploymentCollectionSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationPolicyOutputReference), fullyQualifiedName: "oci.dataOciApigatewayDeployments.DataOciApigatewayDeploymentsDeploymentCollectionSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciApigatewayDeploymentsDeploymentCollectionSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationPolicyOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciApigatewayDeploymentsDeploymentCollectionSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationPolicyOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciApigatewayDeploymentsDeploymentCollectionSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciApigatewayDeploymentsDeploymentCollectionSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "additionalValidationPolicy", typeJson: "{\"fqn\":\"oci.dataOciApigatewayDeployments.DataOciApigatewayDeploymentsDeploymentCollectionSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationPolicyAdditionalValidationPolicyList\"}")]
        public virtual oci.DataOciApigatewayDeployments.DataOciApigatewayDeploymentsDeploymentCollectionSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationPolicyAdditionalValidationPolicyList AdditionalValidationPolicy
        {
            get => GetInstanceProperty<oci.DataOciApigatewayDeployments.DataOciApigatewayDeploymentsDeploymentCollectionSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationPolicyAdditionalValidationPolicyList>()!;
        }

        [JsiiProperty(name: "clientDetails", typeJson: "{\"fqn\":\"oci.dataOciApigatewayDeployments.DataOciApigatewayDeploymentsDeploymentCollectionSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationPolicyClientDetailsList\"}")]
        public virtual oci.DataOciApigatewayDeployments.DataOciApigatewayDeploymentsDeploymentCollectionSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationPolicyClientDetailsList ClientDetails
        {
            get => GetInstanceProperty<oci.DataOciApigatewayDeployments.DataOciApigatewayDeploymentsDeploymentCollectionSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationPolicyClientDetailsList>()!;
        }

        [JsiiProperty(name: "isSslVerifyDisabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSslVerifyDisabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "keys", typeJson: "{\"fqn\":\"oci.dataOciApigatewayDeployments.DataOciApigatewayDeploymentsDeploymentCollectionSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationPolicyKeysList\"}")]
        public virtual oci.DataOciApigatewayDeployments.DataOciApigatewayDeploymentsDeploymentCollectionSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationPolicyKeysList Keys
        {
            get => GetInstanceProperty<oci.DataOciApigatewayDeployments.DataOciApigatewayDeploymentsDeploymentCollectionSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationPolicyKeysList>()!;
        }

        [JsiiProperty(name: "maxCacheDurationInHours", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxCacheDurationInHours
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sourceUriDetails", typeJson: "{\"fqn\":\"oci.dataOciApigatewayDeployments.DataOciApigatewayDeploymentsDeploymentCollectionSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationPolicySourceUriDetailsList\"}")]
        public virtual oci.DataOciApigatewayDeployments.DataOciApigatewayDeploymentsDeploymentCollectionSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationPolicySourceUriDetailsList SourceUriDetails
        {
            get => GetInstanceProperty<oci.DataOciApigatewayDeployments.DataOciApigatewayDeploymentsDeploymentCollectionSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationPolicySourceUriDetailsList>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Uri
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciApigatewayDeployments.DataOciApigatewayDeploymentsDeploymentCollectionSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationPolicy\"}", isOptional: true)]
        public virtual oci.DataOciApigatewayDeployments.IDataOciApigatewayDeploymentsDeploymentCollectionSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationPolicy? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciApigatewayDeployments.IDataOciApigatewayDeploymentsDeploymentCollectionSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
