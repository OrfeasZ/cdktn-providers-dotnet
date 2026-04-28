using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiByValue(fqn: "digitalocean.app.AppSpecFunctionLogDestinationOpenSearchBasicAuth")]
    public class AppSpecFunctionLogDestinationOpenSearchBasicAuth : digitalocean.App.IAppSpecFunctionLogDestinationOpenSearchBasicAuth
    {
        /// <summary>Password for basic authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#password App#password}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Password
        {
            get;
            set;
        }

        /// <summary>user for basic authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#user App#user}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "user", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? User
        {
            get;
            set;
        }
    }
}
