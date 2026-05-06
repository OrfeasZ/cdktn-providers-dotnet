using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatascienceModelDeployment
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatascienceModelDeployment.DataOciDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsOutputReference), fullyQualifiedName: "oci.dataOciDatascienceModelDeployment.DataOciDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "bandwidthMbps", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BandwidthMbps
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "instanceConfiguration", typeJson: "{\"fqn\":\"oci.dataOciDatascienceModelDeployment.DataOciDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsInstanceConfigurationList\"}")]
        public virtual oci.DataOciDatascienceModelDeployment.DataOciDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsInstanceConfigurationList InstanceConfiguration
        {
            get => GetInstanceProperty<oci.DataOciDatascienceModelDeployment.DataOciDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsInstanceConfigurationList>()!;
        }

        [JsiiProperty(name: "maximumBandwidthMbps", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumBandwidthMbps
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scalingPolicy", typeJson: "{\"fqn\":\"oci.dataOciDatascienceModelDeployment.DataOciDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyList\"}")]
        public virtual oci.DataOciDatascienceModelDeployment.DataOciDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyList ScalingPolicy
        {
            get => GetInstanceProperty<oci.DataOciDatascienceModelDeployment.DataOciDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatascienceModelDeployment.DataOciDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetails\"}", isOptional: true)]
        public virtual oci.DataOciDatascienceModelDeployment.IDataOciDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatascienceModelDeployment.IDataOciDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
