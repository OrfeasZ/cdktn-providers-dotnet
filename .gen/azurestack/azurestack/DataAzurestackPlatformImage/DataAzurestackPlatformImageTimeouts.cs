using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DataAzurestackPlatformImage
{
    [JsiiByValue(fqn: "azurestack.dataAzurestackPlatformImage.DataAzurestackPlatformImageTimeouts")]
    public class DataAzurestackPlatformImageTimeouts : azurestack.DataAzurestackPlatformImage.IDataAzurestackPlatformImageTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/platform_image#read DataAzurestackPlatformImage#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
