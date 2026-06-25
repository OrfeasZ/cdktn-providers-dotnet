using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelDeployment
{
    [JsiiClass(nativeType: typeof(oci.DatascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfigurationOutputReference), fullyQualifiedName: "oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putResourceLimitConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfigurationResourceLimitConfiguration\"}}]")]
        public virtual void PutResourceLimitConfiguration(oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfigurationResourceLimitConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfigurationResourceLimitConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceRequestConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfigurationResourceRequestConfiguration\"}}]")]
        public virtual void PutResourceRequestConfiguration(oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfigurationResourceRequestConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfigurationResourceRequestConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetResourceLimitConfiguration")]
        public virtual void ResetResourceLimitConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "resourceLimitConfiguration", typeJson: "{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfigurationResourceLimitConfigurationOutputReference\"}")]
        public virtual oci.DatascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfigurationResourceLimitConfigurationOutputReference ResourceLimitConfiguration
        {
            get => GetInstanceProperty<oci.DatascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfigurationResourceLimitConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "resourceRequestConfiguration", typeJson: "{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfigurationResourceRequestConfigurationOutputReference\"}")]
        public virtual oci.DatascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfigurationResourceRequestConfigurationOutputReference ResourceRequestConfiguration
        {
            get => GetInstanceProperty<oci.DatascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfigurationResourceRequestConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceLimitConfigurationInput", typeJson: "{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfigurationResourceLimitConfiguration\"}", isOptional: true)]
        public virtual oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfigurationResourceLimitConfiguration? ResourceLimitConfigurationInput
        {
            get => GetInstanceProperty<oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfigurationResourceLimitConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceRequestConfigurationInput", typeJson: "{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfigurationResourceRequestConfiguration\"}", isOptional: true)]
        public virtual oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfigurationResourceRequestConfiguration? ResourceRequestConfigurationInput
        {
            get => GetInstanceProperty<oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfigurationResourceRequestConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfiguration\"}", isOptional: true)]
        public virtual oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfiguration? InternalValue
        {
            get => GetInstanceProperty<oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
