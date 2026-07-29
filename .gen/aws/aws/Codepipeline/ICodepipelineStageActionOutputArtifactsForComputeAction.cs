using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codepipeline
{
    [JsiiInterface(nativeType: typeof(ICodepipelineStageActionOutputArtifactsForComputeAction), fullyQualifiedName: "aws.codepipeline.CodepipelineStageActionOutputArtifactsForComputeAction")]
    public interface ICodepipelineStageActionOutputArtifactsForComputeAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.0/docs/resources/codepipeline#name Codepipeline#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.0/docs/resources/codepipeline#files Codepipeline#files}.</summary>
        [JsiiProperty(name: "files", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Files
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodepipelineStageActionOutputArtifactsForComputeAction), fullyQualifiedName: "aws.codepipeline.CodepipelineStageActionOutputArtifactsForComputeAction")]
        internal sealed class _Proxy : DeputyBase, aws.Codepipeline.ICodepipelineStageActionOutputArtifactsForComputeAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.0/docs/resources/codepipeline#name Codepipeline#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.0/docs/resources/codepipeline#files Codepipeline#files}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "files", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Files
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
