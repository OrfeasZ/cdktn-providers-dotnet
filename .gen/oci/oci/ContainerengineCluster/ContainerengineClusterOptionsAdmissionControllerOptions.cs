using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineCluster
{
    [JsiiByValue(fqn: "oci.containerengineCluster.ContainerengineClusterOptionsAdmissionControllerOptions")]
    public class ContainerengineClusterOptionsAdmissionControllerOptions : oci.ContainerengineCluster.IContainerengineClusterOptionsAdmissionControllerOptions
    {
        private object? _isPodSecurityPolicyEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#is_pod_security_policy_enabled ContainerengineCluster#is_pod_security_policy_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isPodSecurityPolicyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsPodSecurityPolicyEnabled
        {
            get => _isPodSecurityPolicyEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isPodSecurityPolicyEnabled = value;
            }
        }
    }
}
