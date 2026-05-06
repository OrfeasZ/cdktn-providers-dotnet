using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineCluster
{
    [JsiiInterface(nativeType: typeof(IContainerengineClusterOptionsAdmissionControllerOptions), fullyQualifiedName: "oci.containerengineCluster.ContainerengineClusterOptionsAdmissionControllerOptions")]
    public interface IContainerengineClusterOptionsAdmissionControllerOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#is_pod_security_policy_enabled ContainerengineCluster#is_pod_security_policy_enabled}.</summary>
        [JsiiProperty(name: "isPodSecurityPolicyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsPodSecurityPolicyEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerengineClusterOptionsAdmissionControllerOptions), fullyQualifiedName: "oci.containerengineCluster.ContainerengineClusterOptionsAdmissionControllerOptions")]
        internal sealed class _Proxy : DeputyBase, oci.ContainerengineCluster.IContainerengineClusterOptionsAdmissionControllerOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#is_pod_security_policy_enabled ContainerengineCluster#is_pod_security_policy_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isPodSecurityPolicyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsPodSecurityPolicyEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
