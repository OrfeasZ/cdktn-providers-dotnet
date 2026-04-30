using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoManagedLoginBranding
{
    [JsiiInterface(nativeType: typeof(ICognitoManagedLoginBrandingAsset), fullyQualifiedName: "aws.cognitoManagedLoginBranding.CognitoManagedLoginBrandingAsset")]
    public interface ICognitoManagedLoginBrandingAsset
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cognito_managed_login_branding#category CognitoManagedLoginBranding#category}.</summary>
        [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}")]
        string Category
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cognito_managed_login_branding#color_mode CognitoManagedLoginBranding#color_mode}.</summary>
        [JsiiProperty(name: "colorMode", typeJson: "{\"primitive\":\"string\"}")]
        string ColorMode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cognito_managed_login_branding#extension CognitoManagedLoginBranding#extension}.</summary>
        [JsiiProperty(name: "extension", typeJson: "{\"primitive\":\"string\"}")]
        string Extension
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cognito_managed_login_branding#bytes CognitoManagedLoginBranding#bytes}.</summary>
        [JsiiProperty(name: "bytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Bytes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cognito_managed_login_branding#resource_id CognitoManagedLoginBranding#resource_id}.</summary>
        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoManagedLoginBrandingAsset), fullyQualifiedName: "aws.cognitoManagedLoginBranding.CognitoManagedLoginBrandingAsset")]
        internal sealed class _Proxy : DeputyBase, aws.CognitoManagedLoginBranding.ICognitoManagedLoginBrandingAsset
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cognito_managed_login_branding#category CognitoManagedLoginBranding#category}.</summary>
            [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}")]
            public string Category
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cognito_managed_login_branding#color_mode CognitoManagedLoginBranding#color_mode}.</summary>
            [JsiiProperty(name: "colorMode", typeJson: "{\"primitive\":\"string\"}")]
            public string ColorMode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cognito_managed_login_branding#extension CognitoManagedLoginBranding#extension}.</summary>
            [JsiiProperty(name: "extension", typeJson: "{\"primitive\":\"string\"}")]
            public string Extension
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cognito_managed_login_branding#bytes CognitoManagedLoginBranding#bytes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Bytes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cognito_managed_login_branding#resource_id CognitoManagedLoginBranding#resource_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
