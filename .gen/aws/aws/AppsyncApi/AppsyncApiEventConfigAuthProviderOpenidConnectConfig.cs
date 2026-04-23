using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncApi
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appsyncApi.AppsyncApiEventConfigAuthProviderOpenidConnectConfig")]
    public class AppsyncApiEventConfigAuthProviderOpenidConnectConfig : aws.AppsyncApi.IAppsyncApiEventConfigAuthProviderOpenidConnectConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appsync_api#issuer AppsyncApi#issuer}.</summary>
        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
        public string Issuer
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appsync_api#auth_ttl AppsyncApi#auth_ttl}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AuthTtl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appsync_api#client_id AppsyncApi#client_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appsync_api#iat_ttl AppsyncApi#iat_ttl}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "iatTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IatTtl
        {
            get;
            set;
        }
    }
}
