using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RedhatOpenshiftCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterPlatformWorkloadIdentityProfile")]
    public class RedhatOpenshiftClusterPlatformWorkloadIdentityProfile : azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterPlatformWorkloadIdentityProfile
    {
        private object _platformWorkloadIdentity;

        /// <summary>platform_workload_identity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/redhat_openshift_cluster#platform_workload_identity RedhatOpenshiftCluster#platform_workload_identity}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterPlatformWorkloadIdentityProfilePlatformWorkloadIdentity" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "platformWorkloadIdentity", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterPlatformWorkloadIdentityProfilePlatformWorkloadIdentity\"},\"kind\":\"array\"}}]}}")]
        public object PlatformWorkloadIdentity
        {
            get => _platformWorkloadIdentity;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterPlatformWorkloadIdentityProfilePlatformWorkloadIdentity[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterPlatformWorkloadIdentityProfilePlatformWorkloadIdentity).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterPlatformWorkloadIdentityProfilePlatformWorkloadIdentity).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _platformWorkloadIdentity = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/redhat_openshift_cluster#upgradeable_to RedhatOpenshiftCluster#upgradeable_to}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "upgradeableTo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UpgradeableTo
        {
            get;
            set;
        }
    }
}
