using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.SecretVersion
{
    [JsiiByValue(fqn: "scaleway.secretVersion.SecretVersionTimeouts")]
    public class SecretVersionTimeouts : scaleway.SecretVersion.ISecretVersionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/secret_version#default SecretVersion#default}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Default
        {
            get;
            set;
        }
    }
}
