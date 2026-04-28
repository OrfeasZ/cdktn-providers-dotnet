using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiByValue(fqn: "digitalocean.app.AppSpecServiceTermination")]
    public class AppSpecServiceTermination : digitalocean.App.IAppSpecServiceTermination
    {
        /// <summary>The number of seconds to wait between selecting a container instance for termination and issuing the TERM signal.</summary>
        /// <remarks>
        /// Selecting a container instance for termination begins an asynchronous drain of new requests on upstream load-balancers. Default: 15 seconds, Minimum 1, Maximum 110.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#drain_seconds App#drain_seconds}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "drainSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DrainSeconds
        {
            get;
            set;
        }

        /// <summary>The number of seconds to wait between sending a TERM signal to a container and issuing a KILL which causes immediate shutdown.</summary>
        /// <remarks>
        /// Default: 120, Minimum 1, Maximum 600.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#grace_period_seconds App#grace_period_seconds}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "gracePeriodSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? GracePeriodSeconds
        {
            get;
            set;
        }
    }
}
