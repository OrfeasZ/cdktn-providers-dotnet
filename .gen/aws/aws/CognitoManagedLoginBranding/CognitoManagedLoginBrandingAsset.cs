using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoManagedLoginBranding
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cognitoManagedLoginBranding.CognitoManagedLoginBrandingAsset")]
    public class CognitoManagedLoginBrandingAsset : aws.CognitoManagedLoginBranding.ICognitoManagedLoginBrandingAsset
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cognito_managed_login_branding#category CognitoManagedLoginBranding#category}.</summary>
        [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}")]
        public string Category
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cognito_managed_login_branding#color_mode CognitoManagedLoginBranding#color_mode}.</summary>
        [JsiiProperty(name: "colorMode", typeJson: "{\"primitive\":\"string\"}")]
        public string ColorMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cognito_managed_login_branding#extension CognitoManagedLoginBranding#extension}.</summary>
        [JsiiProperty(name: "extension", typeJson: "{\"primitive\":\"string\"}")]
        public string Extension
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cognito_managed_login_branding#bytes CognitoManagedLoginBranding#bytes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Bytes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cognito_managed_login_branding#resource_id CognitoManagedLoginBranding#resource_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceId
        {
            get;
            set;
        }
    }
}
