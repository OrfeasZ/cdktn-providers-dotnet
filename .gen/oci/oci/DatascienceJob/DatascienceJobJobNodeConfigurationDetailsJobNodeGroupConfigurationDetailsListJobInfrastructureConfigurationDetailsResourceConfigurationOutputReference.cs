using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceJob
{
    [JsiiClass(nativeType: typeof(oci.DatascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationOutputReference), fullyQualifiedName: "oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putResourceLimitConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfiguration\"}}]")]
        public virtual void PutResourceLimitConfiguration(oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceRequestConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration\"}}]")]
        public virtual void PutResourceRequestConfiguration(oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetResourceLimitConfiguration")]
        public virtual void ResetResourceLimitConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceRequestConfiguration")]
        public virtual void ResetResourceRequestConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "resourceLimitConfiguration", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfigurationOutputReference\"}")]
        public virtual oci.DatascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfigurationOutputReference ResourceLimitConfiguration
        {
            get => GetInstanceProperty<oci.DatascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "resourceRequestConfiguration", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfigurationOutputReference\"}")]
        public virtual oci.DatascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfigurationOutputReference ResourceRequestConfiguration
        {
            get => GetInstanceProperty<oci.DatascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceLimitConfigurationInput", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfiguration\"}", isOptional: true)]
        public virtual oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfiguration? ResourceLimitConfigurationInput
        {
            get => GetInstanceProperty<oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceRequestConfigurationInput", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration\"}", isOptional: true)]
        public virtual oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration? ResourceRequestConfigurationInput
        {
            get => GetInstanceProperty<oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfiguration\"}", isOptional: true)]
        public virtual oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfiguration? InternalValue
        {
            get => GetInstanceProperty<oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
