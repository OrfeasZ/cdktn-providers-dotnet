using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatascienceModelDeployments
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatascienceModelDeployments.DataOciDatascienceModelDeploymentsModelDeploymentsModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesOutputReference), fullyQualifiedName: "oci.dataOciDatascienceModelDeployments.DataOciDatascienceModelDeploymentsModelDeploymentsModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatascienceModelDeploymentsModelDeploymentsModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatascienceModelDeploymentsModelDeploymentsModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatascienceModelDeploymentsModelDeploymentsModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatascienceModelDeploymentsModelDeploymentsModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "metricExpressionRuleType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MetricExpressionRuleType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "metricType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MetricType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scaleInConfiguration", typeJson: "{\"fqn\":\"oci.dataOciDatascienceModelDeployments.DataOciDatascienceModelDeploymentsModelDeploymentsModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleInConfigurationList\"}")]
        public virtual oci.DataOciDatascienceModelDeployments.DataOciDatascienceModelDeploymentsModelDeploymentsModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleInConfigurationList ScaleInConfiguration
        {
            get => GetInstanceProperty<oci.DataOciDatascienceModelDeployments.DataOciDatascienceModelDeploymentsModelDeploymentsModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleInConfigurationList>()!;
        }

        [JsiiProperty(name: "scaleOutConfiguration", typeJson: "{\"fqn\":\"oci.dataOciDatascienceModelDeployments.DataOciDatascienceModelDeploymentsModelDeploymentsModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleOutConfigurationList\"}")]
        public virtual oci.DataOciDatascienceModelDeployments.DataOciDatascienceModelDeploymentsModelDeploymentsModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleOutConfigurationList ScaleOutConfiguration
        {
            get => GetInstanceProperty<oci.DataOciDatascienceModelDeployments.DataOciDatascienceModelDeploymentsModelDeploymentsModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleOutConfigurationList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatascienceModelDeployments.DataOciDatascienceModelDeploymentsModelDeploymentsModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesRules\"}", isOptional: true)]
        public virtual oci.DataOciDatascienceModelDeployments.IDataOciDatascienceModelDeploymentsModelDeploymentsModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesRules? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatascienceModelDeployments.IDataOciDatascienceModelDeploymentsModelDeploymentsModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesRules?>();
            set => SetInstanceProperty(value);
        }
    }
}
