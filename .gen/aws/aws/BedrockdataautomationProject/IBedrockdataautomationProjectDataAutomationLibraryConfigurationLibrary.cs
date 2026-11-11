using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockdataautomationProject
{
    [JsiiInterface(nativeType: typeof(IBedrockdataautomationProjectDataAutomationLibraryConfigurationLibrary), fullyQualifiedName: "aws.bedrockdataautomationProject.BedrockdataautomationProjectDataAutomationLibraryConfigurationLibrary")]
    public interface IBedrockdataautomationProjectDataAutomationLibraryConfigurationLibrary
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/bedrockdataautomation_project#library_arn BedrockdataautomationProject#library_arn}.</summary>
        [JsiiProperty(name: "libraryArn", typeJson: "{\"primitive\":\"string\"}")]
        string LibraryArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockdataautomationProjectDataAutomationLibraryConfigurationLibrary), fullyQualifiedName: "aws.bedrockdataautomationProject.BedrockdataautomationProjectDataAutomationLibraryConfigurationLibrary")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockdataautomationProject.IBedrockdataautomationProjectDataAutomationLibraryConfigurationLibrary
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/bedrockdataautomation_project#library_arn BedrockdataautomationProject#library_arn}.</summary>
            [JsiiProperty(name: "libraryArn", typeJson: "{\"primitive\":\"string\"}")]
            public string LibraryArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
