using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockdataautomationProject
{
    [JsiiInterface(nativeType: typeof(IBedrockdataautomationProjectOverrideConfigurationDocumentModalityProcessing), fullyQualifiedName: "aws.bedrockdataautomationProject.BedrockdataautomationProjectOverrideConfigurationDocumentModalityProcessing")]
    public interface IBedrockdataautomationProjectOverrideConfigurationDocumentModalityProcessing
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#state BedrockdataautomationProject#state}.</summary>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        string State
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockdataautomationProjectOverrideConfigurationDocumentModalityProcessing), fullyQualifiedName: "aws.bedrockdataautomationProject.BedrockdataautomationProjectOverrideConfigurationDocumentModalityProcessing")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockdataautomationProject.IBedrockdataautomationProjectOverrideConfigurationDocumentModalityProcessing
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#state BedrockdataautomationProject#state}.</summary>
            [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
            public string State
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
