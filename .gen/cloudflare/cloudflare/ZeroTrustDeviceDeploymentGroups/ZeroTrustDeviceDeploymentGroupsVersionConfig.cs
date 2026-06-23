using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDeviceDeploymentGroups
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustDeviceDeploymentGroups.ZeroTrustDeviceDeploymentGroupsVersionConfig")]
    public class ZeroTrustDeviceDeploymentGroupsVersionConfig : cloudflare.ZeroTrustDeviceDeploymentGroups.IZeroTrustDeviceDeploymentGroupsVersionConfig
    {
        /// <summary>The target environment for the client version (e.g., windows, macos).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/zero_trust_device_deployment_groups#target_environment ZeroTrustDeviceDeploymentGroups#target_environment}
        /// </remarks>
        [JsiiProperty(name: "targetEnvironment", typeJson: "{\"primitive\":\"string\"}")]
        public string TargetEnvironment
        {
            get;
            set;
        }

        /// <summary>The specific client version to deploy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/zero_trust_device_deployment_groups#version ZeroTrustDeviceDeploymentGroups#version}
        /// </remarks>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public string Version
        {
            get;
            set;
        }
    }
}
