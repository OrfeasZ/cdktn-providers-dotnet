using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TerminalConfiguration
{
    [JsiiByValue(fqn: "stripe.terminalConfiguration.TerminalConfigurationTippingCzk")]
    public class TerminalConfigurationTippingCzk : stripe.TerminalConfiguration.ITerminalConfigurationTippingCzk
    {
        /// <summary>Fixed amounts displayed when collecting a tip.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#fixed_amounts TerminalConfiguration#fixed_amounts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fixedAmounts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        public double[]? FixedAmounts
        {
            get;
            set;
        }

        /// <summary>Percentages displayed when collecting a tip.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#percentages TerminalConfiguration#percentages}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "percentages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        public double[]? Percentages
        {
            get;
            set;
        }

        /// <summary>Below this amount, fixed amounts will be displayed; above it, percentages will be displayed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#smart_tip_threshold TerminalConfiguration#smart_tip_threshold}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "smartTipThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SmartTipThreshold
        {
            get;
            set;
        }
    }
}
