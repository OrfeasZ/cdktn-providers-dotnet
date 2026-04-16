using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    [JsiiInterface(nativeType: typeof(IEcsServiceDeploymentConfigurationLinearConfiguration), fullyQualifiedName: "aws.ecsService.EcsServiceDeploymentConfigurationLinearConfiguration")]
    public interface IEcsServiceDeploymentConfigurationLinearConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_service#step_bake_time_in_minutes EcsService#step_bake_time_in_minutes}.</summary>
        [JsiiProperty(name: "stepBakeTimeInMinutes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StepBakeTimeInMinutes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_service#step_percent EcsService#step_percent}.</summary>
        [JsiiProperty(name: "stepPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StepPercent
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsServiceDeploymentConfigurationLinearConfiguration), fullyQualifiedName: "aws.ecsService.EcsServiceDeploymentConfigurationLinearConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.EcsService.IEcsServiceDeploymentConfigurationLinearConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_service#step_bake_time_in_minutes EcsService#step_bake_time_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stepBakeTimeInMinutes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StepBakeTimeInMinutes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_service#step_percent EcsService#step_percent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stepPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StepPercent
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
