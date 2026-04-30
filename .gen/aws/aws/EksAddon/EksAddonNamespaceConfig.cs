using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksAddon
{
    [JsiiByValue(fqn: "aws.eksAddon.EksAddonNamespaceConfig")]
    public class EksAddonNamespaceConfig : aws.EksAddon.IEksAddonNamespaceConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_addon#namespace EksAddon#namespace}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Namespace
        {
            get;
            set;
        }
    }
}
