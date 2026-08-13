using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Source
{
    [JsiiInterface(nativeType: typeof(ISourceMandateAcceptance), fullyQualifiedName: "stripe.source.SourceMandateAcceptance")]
    public interface ISourceMandateAcceptance
    {
        /// <summary>The status of the mandate acceptance. Either `accepted` (the mandate was accepted) or `refused` (the mandate was refused).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#status Source#status}
        /// </remarks>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        string Status
        {
            get;
        }

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

        /// <summary>The parameters required to store a mandate accepted offline. Should only be set if `mandate[type]` is `offline`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#offline Source#offline}
        /// </remarks>
        [JsiiProperty(name: "offline", typeJson: "{\"fqn\":\"stripe.source.SourceMandateAcceptanceOffline\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Source.ISourceMandateAcceptanceOffline? Offline
        {
            get
            {
                return null;
            }
        }

        /// <summary>The parameters required to store a mandate accepted online. Should only be set if `mandate[type]` is `online`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#online Source#online}
        /// </remarks>
        [JsiiProperty(name: "online", typeJson: "{\"fqn\":\"stripe.source.SourceMandateAcceptanceOnline\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Source.ISourceMandateAcceptanceOnline? Online
        {
            get
            {
                return null;
            }
        }

        /// <summary>The type of acceptance information included with the mandate. Either `online` or `offline`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#type Source#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
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

        [JsiiTypeProxy(nativeType: typeof(ISourceMandateAcceptance), fullyQualifiedName: "stripe.source.SourceMandateAcceptance")]
        internal sealed class _Proxy : DeputyBase, stripe.Source.ISourceMandateAcceptance
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The status of the mandate acceptance. Either `accepted` (the mandate was accepted) or `refused` (the mandate was refused).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#status Source#status}
            /// </remarks>
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
            public string Status
            {
                get => GetInstanceProperty<string>()!;
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

            /// <summary>The parameters required to store a mandate accepted offline. Should only be set if `mandate[type]` is `offline`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#offline Source#offline}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "offline", typeJson: "{\"fqn\":\"stripe.source.SourceMandateAcceptanceOffline\"}", isOptional: true)]
            public stripe.Source.ISourceMandateAcceptanceOffline? Offline
            {
                get => GetInstanceProperty<stripe.Source.ISourceMandateAcceptanceOffline?>();
            }

            /// <summary>The parameters required to store a mandate accepted online. Should only be set if `mandate[type]` is `online`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#online Source#online}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "online", typeJson: "{\"fqn\":\"stripe.source.SourceMandateAcceptanceOnline\"}", isOptional: true)]
            public stripe.Source.ISourceMandateAcceptanceOnline? Online
            {
                get => GetInstanceProperty<stripe.Source.ISourceMandateAcceptanceOnline?>();
            }

            /// <summary>The type of acceptance information included with the mandate. Either `online` or `offline`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#type Source#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
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
