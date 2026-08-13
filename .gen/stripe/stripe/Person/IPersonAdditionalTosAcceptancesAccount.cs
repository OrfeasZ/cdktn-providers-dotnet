using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Person
{
    [JsiiInterface(nativeType: typeof(IPersonAdditionalTosAcceptancesAccount), fullyQualifiedName: "stripe.person.PersonAdditionalTosAcceptancesAccount")]
    public interface IPersonAdditionalTosAcceptancesAccount
    {
        /// <summary>The Unix timestamp marking when the legal guardian accepted the service agreement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#date Person#date}
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

        /// <summary>The IP address from which the legal guardian accepted the service agreement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#ip Person#ip}
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

        /// <summary>The user agent of the browser from which the legal guardian accepted the service agreement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#user_agent Person#user_agent}
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

        [JsiiTypeProxy(nativeType: typeof(IPersonAdditionalTosAcceptancesAccount), fullyQualifiedName: "stripe.person.PersonAdditionalTosAcceptancesAccount")]
        internal sealed class _Proxy : DeputyBase, stripe.Person.IPersonAdditionalTosAcceptancesAccount
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The Unix timestamp marking when the legal guardian accepted the service agreement.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#date Person#date}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "date", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Date
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The IP address from which the legal guardian accepted the service agreement.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#ip Person#ip}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ip
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The user agent of the browser from which the legal guardian accepted the service agreement.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#user_agent Person#user_agent}
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
