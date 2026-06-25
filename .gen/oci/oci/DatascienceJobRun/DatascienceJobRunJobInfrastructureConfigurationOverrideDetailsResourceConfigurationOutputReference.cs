using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceJobRun
{
    [JsiiClass(nativeType: typeof(oci.DatascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationOutputReference), fullyQualifiedName: "oci.datascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putResourceLimitConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationResourceLimitConfiguration\"}}]")]
        public virtual void PutResourceLimitConfiguration(oci.DatascienceJobRun.IDatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationResourceLimitConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceJobRun.IDatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationResourceLimitConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceRequestConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationResourceRequestConfiguration\"}}]")]
        public virtual void PutResourceRequestConfiguration(oci.DatascienceJobRun.IDatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationResourceRequestConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceJobRun.IDatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationResourceRequestConfiguration)}, new object[]{@value});
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

        [JsiiProperty(name: "resourceLimitConfiguration", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationResourceLimitConfigurationOutputReference\"}")]
        public virtual oci.DatascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationResourceLimitConfigurationOutputReference ResourceLimitConfiguration
        {
            get => GetInstanceProperty<oci.DatascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationResourceLimitConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "resourceRequestConfiguration", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationResourceRequestConfigurationOutputReference\"}")]
        public virtual oci.DatascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationResourceRequestConfigurationOutputReference ResourceRequestConfiguration
        {
            get => GetInstanceProperty<oci.DatascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationResourceRequestConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceLimitConfigurationInput", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationResourceLimitConfiguration\"}", isOptional: true)]
        public virtual oci.DatascienceJobRun.IDatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationResourceLimitConfiguration? ResourceLimitConfigurationInput
        {
            get => GetInstanceProperty<oci.DatascienceJobRun.IDatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationResourceLimitConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceRequestConfigurationInput", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationResourceRequestConfiguration\"}", isOptional: true)]
        public virtual oci.DatascienceJobRun.IDatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationResourceRequestConfiguration? ResourceRequestConfigurationInput
        {
            get => GetInstanceProperty<oci.DatascienceJobRun.IDatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationResourceRequestConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfiguration\"}", isOptional: true)]
        public virtual oci.DatascienceJobRun.IDatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfiguration? InternalValue
        {
            get => GetInstanceProperty<oci.DatascienceJobRun.IDatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
