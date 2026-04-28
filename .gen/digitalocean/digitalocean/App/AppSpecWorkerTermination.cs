using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiByValue(fqn: "digitalocean.app.AppSpecWorkerTermination")]
    public class AppSpecWorkerTermination : digitalocean.App.IAppSpecWorkerTermination
    {
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
