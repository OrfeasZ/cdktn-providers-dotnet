using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatascienceModelDeployment
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatascienceModelDeployment.DataOciDatascienceModelDeploymentModelDeploymentConfigurationDetailsOutputReference), fullyQualifiedName: "oci.dataOciDatascienceModelDeployment.DataOciDatascienceModelDeploymentModelDeploymentConfigurationDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatascienceModelDeploymentModelDeploymentConfigurationDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatascienceModelDeploymentModelDeploymentConfigurationDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatascienceModelDeploymentModelDeploymentConfigurationDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatascienceModelDeploymentModelDeploymentConfigurationDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "deploymentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "environmentConfigurationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceModelDeployment.DataOciDatascienceModelDeploymentModelDeploymentConfigurationDetailsEnvironmentConfigurationDetailsList\"}")]
        public virtual oci.DataOciDatascienceModelDeployment.DataOciDatascienceModelDeploymentModelDeploymentConfigurationDetailsEnvironmentConfigurationDetailsList EnvironmentConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceModelDeployment.DataOciDatascienceModelDeploymentModelDeploymentConfigurationDetailsEnvironmentConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "infrastructureConfigurationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceModelDeployment.DataOciDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsList\"}")]
        public virtual oci.DataOciDatascienceModelDeployment.DataOciDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsList InfrastructureConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceModelDeployment.DataOciDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "modelConfigurationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceModelDeployment.DataOciDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsList\"}")]
        public virtual oci.DataOciDatascienceModelDeployment.DataOciDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsList ModelConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceModelDeployment.DataOciDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "modelGroupConfigurationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceModelDeployment.DataOciDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelGroupConfigurationDetailsList\"}")]
        public virtual oci.DataOciDatascienceModelDeployment.DataOciDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelGroupConfigurationDetailsList ModelGroupConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceModelDeployment.DataOciDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelGroupConfigurationDetailsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatascienceModelDeployment.DataOciDatascienceModelDeploymentModelDeploymentConfigurationDetails\"}", isOptional: true)]
        public virtual oci.DataOciDatascienceModelDeployment.IDataOciDatascienceModelDeploymentModelDeploymentConfigurationDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatascienceModelDeployment.IDataOciDatascienceModelDeploymentModelDeploymentConfigurationDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
