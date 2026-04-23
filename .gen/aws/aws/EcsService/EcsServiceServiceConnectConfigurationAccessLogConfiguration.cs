using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecsService.EcsServiceServiceConnectConfigurationAccessLogConfiguration")]
    public class EcsServiceServiceConnectConfigurationAccessLogConfiguration : aws.EcsService.IEcsServiceServiceConnectConfigurationAccessLogConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_service#format EcsService#format}.</summary>
        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
        public string Format
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_service#include_query_parameters EcsService#include_query_parameters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includeQueryParameters", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IncludeQueryParameters
        {
            get;
            set;
        }
    }
}
