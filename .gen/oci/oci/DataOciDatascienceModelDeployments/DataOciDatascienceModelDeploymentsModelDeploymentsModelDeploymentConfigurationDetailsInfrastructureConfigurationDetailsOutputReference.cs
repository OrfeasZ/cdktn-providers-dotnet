using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatascienceModelDeployments
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatascienceModelDeployments.DataOciDatascienceModelDeploymentsModelDeploymentsModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsOutputReference), fullyQualifiedName: "oci.dataOciDatascienceModelDeployments.DataOciDatascienceModelDeploymentsModelDeploymentsModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatascienceModelDeploymentsModelDeploymentsModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatascienceModelDeploymentsModelDeploymentsModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatascienceModelDeploymentsModelDeploymentsModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatascienceModelDeploymentsModelDeploymentsModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "bandwidthMbps", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BandwidthMbps
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "infrastructureType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InfrastructureType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceConfiguration", typeJson: "{\"fqn\":\"oci.dataOciDatascienceModelDeployments.DataOciDatascienceModelDeploymentsModelDeploymentsModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsInstanceConfigurationList\"}")]
        public virtual oci.DataOciDatascienceModelDeployments.DataOciDatascienceModelDeploymentsModelDeploymentsModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsInstanceConfigurationList InstanceConfiguration
        {
            get => GetInstanceProperty<oci.DataOciDatascienceModelDeployments.DataOciDatascienceModelDeploymentsModelDeploymentsModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsInstanceConfigurationList>()!;
        }

        [JsiiProperty(name: "maximumBandwidthMbps", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumBandwidthMbps
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "scalingPolicy", typeJson: "{\"fqn\":\"oci.dataOciDatascienceModelDeployments.DataOciDatascienceModelDeploymentsModelDeploymentsModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyList\"}")]
        public virtual oci.DataOciDatascienceModelDeployments.DataOciDatascienceModelDeploymentsModelDeploymentsModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyList ScalingPolicy
        {
            get => GetInstanceProperty<oci.DataOciDatascienceModelDeployments.DataOciDatascienceModelDeploymentsModelDeploymentsModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatascienceModelDeployments.DataOciDatascienceModelDeploymentsModelDeploymentsModelDeploymentConfigurationDetailsInfrastructureConfigurationDetails\"}", isOptional: true)]
        public virtual oci.DataOciDatascienceModelDeployments.IDataOciDatascienceModelDeploymentsModelDeploymentsModelDeploymentConfigurationDetailsInfrastructureConfigurationDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatascienceModelDeployments.IDataOciDatascienceModelDeploymentsModelDeploymentsModelDeploymentConfigurationDetailsInfrastructureConfigurationDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
