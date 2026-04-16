using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncApi
{
    [JsiiInterface(nativeType: typeof(IAppsyncApiEventConfigAuthProviderOpenidConnectConfig), fullyQualifiedName: "aws.appsyncApi.AppsyncApiEventConfigAuthProviderOpenidConnectConfig")]
    public interface IAppsyncApiEventConfigAuthProviderOpenidConnectConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_api#issuer AppsyncApi#issuer}.</summary>
        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
        string Issuer
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_api#auth_ttl AppsyncApi#auth_ttl}.</summary>
        [JsiiProperty(name: "authTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AuthTtl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_api#client_id AppsyncApi#client_id}.</summary>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_api#iat_ttl AppsyncApi#iat_ttl}.</summary>
        [JsiiProperty(name: "iatTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IatTtl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncApiEventConfigAuthProviderOpenidConnectConfig), fullyQualifiedName: "aws.appsyncApi.AppsyncApiEventConfigAuthProviderOpenidConnectConfig")]
        internal sealed class _Proxy : DeputyBase, aws.AppsyncApi.IAppsyncApiEventConfigAuthProviderOpenidConnectConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_api#issuer AppsyncApi#issuer}.</summary>
            [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
            public string Issuer
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_api#auth_ttl AppsyncApi#auth_ttl}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AuthTtl
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_api#client_id AppsyncApi#client_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_api#iat_ttl AppsyncApi#iat_ttl}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "iatTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IatTtl
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
