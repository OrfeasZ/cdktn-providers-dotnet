using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.CustomHostname
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.customHostname.CustomHostnameSslCustomCertBundle")]
    public class CustomHostnameSslCustomCertBundle : cloudflare.CustomHostname.ICustomHostnameSslCustomCertBundle
    {
        /// <summary>If a custom uploaded certificate is used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/custom_hostname#custom_certificate CustomHostname#custom_certificate}
        /// </remarks>
        [JsiiProperty(name: "customCertificate", typeJson: "{\"primitive\":\"string\"}")]
        public string CustomCertificate
        {
            get;
            set;
        }

        /// <summary>The key for a custom uploaded certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/custom_hostname#custom_key CustomHostname#custom_key}
        /// </remarks>
        [JsiiProperty(name: "customKey", typeJson: "{\"primitive\":\"string\"}")]
        public string CustomKey
        {
            get;
            set;
        }
    }
}
