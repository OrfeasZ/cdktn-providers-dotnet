using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDeviceDeploymentGroups
{
    [JsiiInterface(nativeType: typeof(IZeroTrustDeviceDeploymentGroupsVersionConfig), fullyQualifiedName: "cloudflare.zeroTrustDeviceDeploymentGroups.ZeroTrustDeviceDeploymentGroupsVersionConfig")]
    public interface IZeroTrustDeviceDeploymentGroupsVersionConfig
    {
        /// <summary>The target environment for the client version (e.g., windows, macos).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/zero_trust_device_deployment_groups#target_environment ZeroTrustDeviceDeploymentGroups#target_environment}
        /// </remarks>
        [JsiiProperty(name: "targetEnvironment", typeJson: "{\"primitive\":\"string\"}")]
        string TargetEnvironment
        {
            get;
        }

        /// <summary>The specific client version to deploy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/zero_trust_device_deployment_groups#version ZeroTrustDeviceDeploymentGroups#version}
        /// </remarks>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        string Version
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustDeviceDeploymentGroupsVersionConfig), fullyQualifiedName: "cloudflare.zeroTrustDeviceDeploymentGroups.ZeroTrustDeviceDeploymentGroupsVersionConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustDeviceDeploymentGroups.IZeroTrustDeviceDeploymentGroupsVersionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The target environment for the client version (e.g., windows, macos).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/zero_trust_device_deployment_groups#target_environment ZeroTrustDeviceDeploymentGroups#target_environment}
            /// </remarks>
            [JsiiProperty(name: "targetEnvironment", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetEnvironment
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The specific client version to deploy.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/zero_trust_device_deployment_groups#version ZeroTrustDeviceDeploymentGroups#version}
            /// </remarks>
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
            public string Version
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
