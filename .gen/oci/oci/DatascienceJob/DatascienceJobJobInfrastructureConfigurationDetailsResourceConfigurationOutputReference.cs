using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceJob
{
    [JsiiClass(nativeType: typeof(oci.DatascienceJob.DatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationOutputReference), fullyQualifiedName: "oci.datascienceJob.DatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putResourceLimitConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceJob.DatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfiguration\"}}]")]
        public virtual void PutResourceLimitConfiguration(oci.DatascienceJob.IDatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceJob.IDatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceRequestConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceJob.DatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration\"}}]")]
        public virtual void PutResourceRequestConfiguration(oci.DatascienceJob.IDatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceJob.IDatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration)}, new object[]{@value});
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

        [JsiiProperty(name: "resourceLimitConfiguration", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfigurationOutputReference\"}")]
        public virtual oci.DatascienceJob.DatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfigurationOutputReference ResourceLimitConfiguration
        {
            get => GetInstanceProperty<oci.DatascienceJob.DatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "resourceRequestConfiguration", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfigurationOutputReference\"}")]
        public virtual oci.DatascienceJob.DatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfigurationOutputReference ResourceRequestConfiguration
        {
            get => GetInstanceProperty<oci.DatascienceJob.DatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceLimitConfigurationInput", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfiguration\"}", isOptional: true)]
        public virtual oci.DatascienceJob.IDatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfiguration? ResourceLimitConfigurationInput
        {
            get => GetInstanceProperty<oci.DatascienceJob.IDatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceRequestConfigurationInput", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration\"}", isOptional: true)]
        public virtual oci.DatascienceJob.IDatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration? ResourceRequestConfigurationInput
        {
            get => GetInstanceProperty<oci.DatascienceJob.IDatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobInfrastructureConfigurationDetailsResourceConfiguration\"}", isOptional: true)]
        public virtual oci.DatascienceJob.IDatascienceJobJobInfrastructureConfigurationDetailsResourceConfiguration? InternalValue
        {
            get => GetInstanceProperty<oci.DatascienceJob.IDatascienceJobJobInfrastructureConfigurationDetailsResourceConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
