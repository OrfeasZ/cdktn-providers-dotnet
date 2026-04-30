using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksAddon
{
    [JsiiInterface(nativeType: typeof(IEksAddonNamespaceConfig), fullyQualifiedName: "aws.eksAddon.EksAddonNamespaceConfig")]
    public interface IEksAddonNamespaceConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_addon#namespace EksAddon#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Namespace
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEksAddonNamespaceConfig), fullyQualifiedName: "aws.eksAddon.EksAddonNamespaceConfig")]
        internal sealed class _Proxy : DeputyBase, aws.EksAddon.IEksAddonNamespaceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_addon#namespace EksAddon#namespace}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Namespace
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
