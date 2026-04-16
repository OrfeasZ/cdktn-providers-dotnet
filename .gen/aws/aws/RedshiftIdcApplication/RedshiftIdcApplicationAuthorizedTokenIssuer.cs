using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RedshiftIdcApplication
{
    [JsiiByValue(fqn: "aws.redshiftIdcApplication.RedshiftIdcApplicationAuthorizedTokenIssuer")]
    public class RedshiftIdcApplicationAuthorizedTokenIssuer : aws.RedshiftIdcApplication.IRedshiftIdcApplicationAuthorizedTokenIssuer
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/redshift_idc_application#authorized_audiences_list RedshiftIdcApplication#authorized_audiences_list}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authorizedAudiencesList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AuthorizedAudiencesList
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/redshift_idc_application#trusted_token_issuer_arn RedshiftIdcApplication#trusted_token_issuer_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trustedTokenIssuerArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TrustedTokenIssuerArn
        {
            get;
            set;
        }
    }
}
