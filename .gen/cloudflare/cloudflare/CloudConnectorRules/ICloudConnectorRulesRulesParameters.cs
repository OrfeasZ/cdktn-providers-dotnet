using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.CloudConnectorRules
{
    [JsiiInterface(nativeType: typeof(ICloudConnectorRulesRulesParameters), fullyQualifiedName: "cloudflare.cloudConnectorRules.CloudConnectorRulesRulesParameters")]
    public interface ICloudConnectorRulesRulesParameters
    {
        /// <summary>Host to perform Cloud Connection to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/cloud_connector_rules#host CloudConnectorRules#host}
        /// </remarks>
        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Host
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudConnectorRulesRulesParameters), fullyQualifiedName: "cloudflare.cloudConnectorRules.CloudConnectorRulesRulesParameters")]
        internal sealed class _Proxy : DeputyBase, cloudflare.CloudConnectorRules.ICloudConnectorRulesRulesParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Host to perform Cloud Connection to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/cloud_connector_rules#host CloudConnectorRules#host}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Host
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
