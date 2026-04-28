using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace acme.Provider
{
    [JsiiInterface(nativeType: typeof(IAcmeProviderConfig), fullyQualifiedName: "acme.provider.AcmeProviderConfig")]
    public interface IAcmeProviderConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.1/docs#server_url AcmeProvider#server_url}.</summary>
        [JsiiProperty(name: "serverUrl", typeJson: "{\"primitive\":\"string\"}")]
        string ServerUrl
        {
            get;
        }

        /// <summary>Alias name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.1/docs#alias AcmeProvider#alias}
        /// </remarks>
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Alias
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAcmeProviderConfig), fullyQualifiedName: "acme.provider.AcmeProviderConfig")]
        internal sealed class _Proxy : DeputyBase, acme.Provider.IAcmeProviderConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.1/docs#server_url AcmeProvider#server_url}.</summary>
            [JsiiProperty(name: "serverUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string ServerUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Alias name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.1/docs#alias AcmeProvider#alias}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Alias
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
