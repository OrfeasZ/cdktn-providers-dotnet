using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codepipeline
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codepipeline.CodepipelineStageActionOutputArtifactsForComputeAction")]
    public class CodepipelineStageActionOutputArtifactsForComputeAction : aws.Codepipeline.ICodepipelineStageActionOutputArtifactsForComputeAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/codepipeline#name Codepipeline#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/codepipeline#files Codepipeline#files}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "files", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Files
        {
            get;
            set;
        }
    }
}
