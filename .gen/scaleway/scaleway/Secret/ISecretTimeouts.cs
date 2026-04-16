using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.Secret
{
    [JsiiInterface(nativeType: typeof(ISecretTimeouts), fullyQualifiedName: "scaleway.secret.SecretTimeouts")]
    public interface ISecretTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/secret#default Secret#default}.</summary>
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Default
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISecretTimeouts), fullyQualifiedName: "scaleway.secret.SecretTimeouts")]
        internal sealed class _Proxy : DeputyBase, scaleway.Secret.ISecretTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/secret#default Secret#default}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Default
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
