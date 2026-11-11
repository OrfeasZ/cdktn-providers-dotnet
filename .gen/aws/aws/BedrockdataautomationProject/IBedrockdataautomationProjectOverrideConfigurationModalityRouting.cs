using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockdataautomationProject
{
    [JsiiInterface(nativeType: typeof(IBedrockdataautomationProjectOverrideConfigurationModalityRouting), fullyQualifiedName: "aws.bedrockdataautomationProject.BedrockdataautomationProjectOverrideConfigurationModalityRouting")]
    public interface IBedrockdataautomationProjectOverrideConfigurationModalityRouting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/bedrockdataautomation_project#jpeg BedrockdataautomationProject#jpeg}.</summary>
        [JsiiProperty(name: "jpeg", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Jpeg
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/bedrockdataautomation_project#mov BedrockdataautomationProject#mov}.</summary>
        [JsiiProperty(name: "mov", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Mov
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/bedrockdataautomation_project#mp4 BedrockdataautomationProject#mp4}.</summary>
        [JsiiProperty(name: "mp4", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Mp4
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/bedrockdataautomation_project#png BedrockdataautomationProject#png}.</summary>
        [JsiiProperty(name: "png", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Png
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockdataautomationProjectOverrideConfigurationModalityRouting), fullyQualifiedName: "aws.bedrockdataautomationProject.BedrockdataautomationProjectOverrideConfigurationModalityRouting")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockdataautomationProject.IBedrockdataautomationProjectOverrideConfigurationModalityRouting
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/bedrockdataautomation_project#jpeg BedrockdataautomationProject#jpeg}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jpeg", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Jpeg
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/bedrockdataautomation_project#mov BedrockdataautomationProject#mov}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mov", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Mov
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/bedrockdataautomation_project#mp4 BedrockdataautomationProject#mp4}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mp4", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Mp4
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/bedrockdataautomation_project#png BedrockdataautomationProject#png}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "png", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Png
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
