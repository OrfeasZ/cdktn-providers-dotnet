using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RedhatOpenshiftCluster
{
    [JsiiInterface(nativeType: typeof(IRedhatOpenshiftClusterPlatformWorkloadIdentityProfile), fullyQualifiedName: "azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterPlatformWorkloadIdentityProfile")]
    public interface IRedhatOpenshiftClusterPlatformWorkloadIdentityProfile
    {
        /// <summary>platform_workload_identity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/redhat_openshift_cluster#platform_workload_identity RedhatOpenshiftCluster#platform_workload_identity}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterPlatformWorkloadIdentityProfilePlatformWorkloadIdentity" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "platformWorkloadIdentity", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterPlatformWorkloadIdentityProfilePlatformWorkloadIdentity\"},\"kind\":\"array\"}}]}}")]
        object PlatformWorkloadIdentity
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/redhat_openshift_cluster#upgradeable_to RedhatOpenshiftCluster#upgradeable_to}.</summary>
        [JsiiProperty(name: "upgradeableTo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UpgradeableTo
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRedhatOpenshiftClusterPlatformWorkloadIdentityProfile), fullyQualifiedName: "azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterPlatformWorkloadIdentityProfile")]
        internal sealed class _Proxy : DeputyBase, azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterPlatformWorkloadIdentityProfile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>platform_workload_identity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/redhat_openshift_cluster#platform_workload_identity RedhatOpenshiftCluster#platform_workload_identity}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterPlatformWorkloadIdentityProfilePlatformWorkloadIdentity" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "platformWorkloadIdentity", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterPlatformWorkloadIdentityProfilePlatformWorkloadIdentity\"},\"kind\":\"array\"}}]}}")]
            public object PlatformWorkloadIdentity
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/redhat_openshift_cluster#upgradeable_to RedhatOpenshiftCluster#upgradeable_to}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "upgradeableTo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UpgradeableTo
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
