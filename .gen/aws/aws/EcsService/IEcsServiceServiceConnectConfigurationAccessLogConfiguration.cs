using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    [JsiiInterface(nativeType: typeof(IEcsServiceServiceConnectConfigurationAccessLogConfiguration), fullyQualifiedName: "aws.ecsService.EcsServiceServiceConnectConfigurationAccessLogConfiguration")]
    public interface IEcsServiceServiceConnectConfigurationAccessLogConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_service#format EcsService#format}.</summary>
        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
        string Format
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_service#include_query_parameters EcsService#include_query_parameters}.</summary>
        [JsiiProperty(name: "includeQueryParameters", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IncludeQueryParameters
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsServiceServiceConnectConfigurationAccessLogConfiguration), fullyQualifiedName: "aws.ecsService.EcsServiceServiceConnectConfigurationAccessLogConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.EcsService.IEcsServiceServiceConnectConfigurationAccessLogConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_service#format EcsService#format}.</summary>
            [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
            public string Format
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_service#include_query_parameters EcsService#include_query_parameters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "includeQueryParameters", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IncludeQueryParameters
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
