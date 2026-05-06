using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstance
{
    [JsiiInterface(nativeType: typeof(ICoreInstancePreemptibleInstanceConfig), fullyQualifiedName: "oci.coreInstance.CoreInstancePreemptibleInstanceConfig")]
    public interface ICoreInstancePreemptibleInstanceConfig
    {
        /// <summary>preemption_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#preemption_action CoreInstance#preemption_action}
        /// </remarks>
        [JsiiProperty(name: "preemptionAction", typeJson: "{\"fqn\":\"oci.coreInstance.CoreInstancePreemptibleInstanceConfigPreemptionAction\"}")]
        oci.CoreInstance.ICoreInstancePreemptibleInstanceConfigPreemptionAction PreemptionAction
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreInstancePreemptibleInstanceConfig), fullyQualifiedName: "oci.coreInstance.CoreInstancePreemptibleInstanceConfig")]
        internal sealed class _Proxy : DeputyBase, oci.CoreInstance.ICoreInstancePreemptibleInstanceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>preemption_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#preemption_action CoreInstance#preemption_action}
            /// </remarks>
            [JsiiProperty(name: "preemptionAction", typeJson: "{\"fqn\":\"oci.coreInstance.CoreInstancePreemptibleInstanceConfigPreemptionAction\"}")]
            public oci.CoreInstance.ICoreInstancePreemptibleInstanceConfigPreemptionAction PreemptionAction
            {
                get => GetInstanceProperty<oci.CoreInstance.ICoreInstancePreemptibleInstanceConfigPreemptionAction>()!;
            }
        }
    }
}
