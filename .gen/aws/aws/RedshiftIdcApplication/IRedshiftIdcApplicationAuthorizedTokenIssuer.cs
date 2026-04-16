using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RedshiftIdcApplication
{
    [JsiiInterface(nativeType: typeof(IRedshiftIdcApplicationAuthorizedTokenIssuer), fullyQualifiedName: "aws.redshiftIdcApplication.RedshiftIdcApplicationAuthorizedTokenIssuer")]
    public interface IRedshiftIdcApplicationAuthorizedTokenIssuer
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/redshift_idc_application#authorized_audiences_list RedshiftIdcApplication#authorized_audiences_list}.</summary>
        [JsiiProperty(name: "authorizedAudiencesList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AuthorizedAudiencesList
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/redshift_idc_application#trusted_token_issuer_arn RedshiftIdcApplication#trusted_token_issuer_arn}.</summary>
        [JsiiProperty(name: "trustedTokenIssuerArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TrustedTokenIssuerArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRedshiftIdcApplicationAuthorizedTokenIssuer), fullyQualifiedName: "aws.redshiftIdcApplication.RedshiftIdcApplicationAuthorizedTokenIssuer")]
        internal sealed class _Proxy : DeputyBase, aws.RedshiftIdcApplication.IRedshiftIdcApplicationAuthorizedTokenIssuer
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/redshift_idc_application#authorized_audiences_list RedshiftIdcApplication#authorized_audiences_list}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authorizedAudiencesList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AuthorizedAudiencesList
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/redshift_idc_application#trusted_token_issuer_arn RedshiftIdcApplication#trusted_token_issuer_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "trustedTokenIssuerArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TrustedTokenIssuerArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
