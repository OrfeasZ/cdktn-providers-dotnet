using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodebuildProject
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codebuildProject.CodebuildProjectEnvironmentDockerServer")]
    public class CodebuildProjectEnvironmentDockerServer : aws.CodebuildProject.ICodebuildProjectEnvironmentDockerServer
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/codebuild_project#compute_type CodebuildProject#compute_type}.</summary>
        [JsiiProperty(name: "computeType", typeJson: "{\"primitive\":\"string\"}")]
        public string ComputeType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/codebuild_project#security_group_ids CodebuildProject#security_group_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SecurityGroupIds
        {
            get;
            set;
        }
    }
}
