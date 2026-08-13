using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TerminalConfiguration
{
    [JsiiByValue(fqn: "stripe.terminalConfiguration.TerminalConfigurationBbposWiseposE")]
    public class TerminalConfigurationBbposWiseposE : stripe.TerminalConfiguration.ITerminalConfigurationBbposWiseposE
    {
        /// <summary>A File ID representing an image to display on the reader.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#splashscreen TerminalConfiguration#splashscreen}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "splashscreen", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Splashscreen
        {
            get;
            set;
        }
    }
}
