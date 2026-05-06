using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BastionSession
{
    [JsiiInterface(nativeType: typeof(IBastionSessionKeyDetails), fullyQualifiedName: "oci.bastionSession.BastionSessionKeyDetails")]
    public interface IBastionSessionKeyDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bastion_session#public_key_content BastionSession#public_key_content}.</summary>
        [JsiiProperty(name: "publicKeyContent", typeJson: "{\"primitive\":\"string\"}")]
        string PublicKeyContent
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBastionSessionKeyDetails), fullyQualifiedName: "oci.bastionSession.BastionSessionKeyDetails")]
        internal sealed class _Proxy : DeputyBase, oci.BastionSession.IBastionSessionKeyDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bastion_session#public_key_content BastionSession#public_key_content}.</summary>
            [JsiiProperty(name: "publicKeyContent", typeJson: "{\"primitive\":\"string\"}")]
            public string PublicKeyContent
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
