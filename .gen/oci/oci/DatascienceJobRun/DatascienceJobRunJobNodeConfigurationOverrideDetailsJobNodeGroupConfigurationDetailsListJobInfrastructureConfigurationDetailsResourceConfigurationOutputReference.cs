using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceJobRun
{
    [JsiiClass(nativeType: typeof(oci.DatascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationOutputReference), fullyQualifiedName: "oci.datascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putResourceLimitConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfiguration\"}}]")]
        public virtual void PutResourceLimitConfiguration(oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceRequestConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration\"}}]")]
        public virtual void PutResourceRequestConfiguration(oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration)}, new object[]{@value});
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

        [JsiiProperty(name: "resourceLimitConfiguration", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfigurationOutputReference\"}")]
        public virtual oci.DatascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfigurationOutputReference ResourceLimitConfiguration
        {
            get => GetInstanceProperty<oci.DatascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "resourceRequestConfiguration", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfigurationOutputReference\"}")]
        public virtual oci.DatascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfigurationOutputReference ResourceRequestConfiguration
        {
            get => GetInstanceProperty<oci.DatascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceLimitConfigurationInput", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfiguration\"}", isOptional: true)]
        public virtual oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfiguration? ResourceLimitConfigurationInput
        {
            get => GetInstanceProperty<oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceRequestConfigurationInput", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration\"}", isOptional: true)]
        public virtual oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration? ResourceRequestConfigurationInput
        {
            get => GetInstanceProperty<oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfiguration\"}", isOptional: true)]
        public virtual oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfiguration? InternalValue
        {
            get => GetInstanceProperty<oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
