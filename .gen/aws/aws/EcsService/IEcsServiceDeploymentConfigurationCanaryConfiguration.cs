using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    [JsiiInterface(nativeType: typeof(IEcsServiceDeploymentConfigurationCanaryConfiguration), fullyQualifiedName: "aws.ecsService.EcsServiceDeploymentConfigurationCanaryConfiguration")]
    public interface IEcsServiceDeploymentConfigurationCanaryConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_service#canary_bake_time_in_minutes EcsService#canary_bake_time_in_minutes}.</summary>
        [JsiiProperty(name: "canaryBakeTimeInMinutes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CanaryBakeTimeInMinutes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_service#canary_percent EcsService#canary_percent}.</summary>
        [JsiiProperty(name: "canaryPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CanaryPercent
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsServiceDeploymentConfigurationCanaryConfiguration), fullyQualifiedName: "aws.ecsService.EcsServiceDeploymentConfigurationCanaryConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.EcsService.IEcsServiceDeploymentConfigurationCanaryConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_service#canary_bake_time_in_minutes EcsService#canary_bake_time_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "canaryBakeTimeInMinutes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CanaryBakeTimeInMinutes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_service#canary_percent EcsService#canary_percent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "canaryPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CanaryPercent
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
