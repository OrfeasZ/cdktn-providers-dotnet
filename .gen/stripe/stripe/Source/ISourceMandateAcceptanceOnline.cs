using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Source
{
    [JsiiInterface(nativeType: typeof(ISourceMandateAcceptanceOnline), fullyQualifiedName: "stripe.source.SourceMandateAcceptanceOnline")]
    public interface ISourceMandateAcceptanceOnline
    {
        /// <summary>The Unix timestamp (in seconds) when the mandate was accepted or refused by the customer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#date Source#date}
        /// </remarks>
        [JsiiProperty(name: "date", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Date
        {
            get
            {
                return null;
            }
        }

        /// <summary>The IP address from which the mandate was accepted or refused by the customer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#ip Source#ip}
        /// </remarks>
        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ip
        {
            get
            {
                return null;
            }
        }

        /// <summary>The user agent of the browser from which the mandate was accepted or refused by the customer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#user_agent Source#user_agent}
        /// </remarks>
        [JsiiProperty(name: "userAgent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserAgent
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISourceMandateAcceptanceOnline), fullyQualifiedName: "stripe.source.SourceMandateAcceptanceOnline")]
        internal sealed class _Proxy : DeputyBase, stripe.Source.ISourceMandateAcceptanceOnline
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The Unix timestamp (in seconds) when the mandate was accepted or refused by the customer.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#date Source#date}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "date", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Date
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The IP address from which the mandate was accepted or refused by the customer.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#ip Source#ip}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ip
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The user agent of the browser from which the mandate was accepted or refused by the customer.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#user_agent Source#user_agent}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "userAgent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserAgent
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
