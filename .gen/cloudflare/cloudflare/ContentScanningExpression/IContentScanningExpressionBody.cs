using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ContentScanningExpression
{
    [JsiiInterface(nativeType: typeof(IContentScanningExpressionBody), fullyQualifiedName: "cloudflare.contentScanningExpression.ContentScanningExpressionBody")]
    public interface IContentScanningExpressionBody
    {
        /// <summary>Defines the ruleset expression to use in matching content objects.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/content_scanning_expression#payload ContentScanningExpression#payload}
        /// </remarks>
        [JsiiProperty(name: "payload", typeJson: "{\"primitive\":\"string\"}")]
        string Payload
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IContentScanningExpressionBody), fullyQualifiedName: "cloudflare.contentScanningExpression.ContentScanningExpressionBody")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ContentScanningExpression.IContentScanningExpressionBody
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Defines the ruleset expression to use in matching content objects.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/content_scanning_expression#payload ContentScanningExpression#payload}
            /// </remarks>
            [JsiiProperty(name: "payload", typeJson: "{\"primitive\":\"string\"}")]
            public string Payload
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
