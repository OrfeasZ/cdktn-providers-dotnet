using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockdataautomationProject
{
    [JsiiInterface(nativeType: typeof(IBedrockdataautomationProjectCustomOutputConfigurationDocumentFallbackBlueprint), fullyQualifiedName: "aws.bedrockdataautomationProject.BedrockdataautomationProjectCustomOutputConfigurationDocumentFallbackBlueprint")]
    public interface IBedrockdataautomationProjectCustomOutputConfigurationDocumentFallbackBlueprint
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#blueprint_arn BedrockdataautomationProject#blueprint_arn}.</summary>
        [JsiiProperty(name: "blueprintArn", typeJson: "{\"primitive\":\"string\"}")]
        string BlueprintArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#blueprint_stage BedrockdataautomationProject#blueprint_stage}.</summary>
        [JsiiProperty(name: "blueprintStage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BlueprintStage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#blueprint_version BedrockdataautomationProject#blueprint_version}.</summary>
        [JsiiProperty(name: "blueprintVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BlueprintVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockdataautomationProjectCustomOutputConfigurationDocumentFallbackBlueprint), fullyQualifiedName: "aws.bedrockdataautomationProject.BedrockdataautomationProjectCustomOutputConfigurationDocumentFallbackBlueprint")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockdataautomationProject.IBedrockdataautomationProjectCustomOutputConfigurationDocumentFallbackBlueprint
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#blueprint_arn BedrockdataautomationProject#blueprint_arn}.</summary>
            [JsiiProperty(name: "blueprintArn", typeJson: "{\"primitive\":\"string\"}")]
            public string BlueprintArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#blueprint_stage BedrockdataautomationProject#blueprint_stage}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "blueprintStage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BlueprintStage
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#blueprint_version BedrockdataautomationProject#blueprint_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "blueprintVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BlueprintVersion
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
