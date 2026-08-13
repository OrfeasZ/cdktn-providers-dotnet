using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TerminalConfiguration
{
    [JsiiInterface(nativeType: typeof(ITerminalConfigurationTippingSgd), fullyQualifiedName: "stripe.terminalConfiguration.TerminalConfigurationTippingSgd")]
    public interface ITerminalConfigurationTippingSgd
    {
        /// <summary>Fixed amounts displayed when collecting a tip.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#fixed_amounts TerminalConfiguration#fixed_amounts}
        /// </remarks>
        [JsiiProperty(name: "fixedAmounts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double[]? FixedAmounts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Percentages displayed when collecting a tip.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#percentages TerminalConfiguration#percentages}
        /// </remarks>
        [JsiiProperty(name: "percentages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double[]? Percentages
        {
            get
            {
                return null;
            }
        }

        /// <summary>Below this amount, fixed amounts will be displayed; above it, percentages will be displayed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#smart_tip_threshold TerminalConfiguration#smart_tip_threshold}
        /// </remarks>
        [JsiiProperty(name: "smartTipThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SmartTipThreshold
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITerminalConfigurationTippingSgd), fullyQualifiedName: "stripe.terminalConfiguration.TerminalConfigurationTippingSgd")]
        internal sealed class _Proxy : DeputyBase, stripe.TerminalConfiguration.ITerminalConfigurationTippingSgd
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Fixed amounts displayed when collecting a tip.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#fixed_amounts TerminalConfiguration#fixed_amounts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fixedAmounts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
            public double[]? FixedAmounts
            {
                get => GetInstanceProperty<double[]?>();
            }

            /// <summary>Percentages displayed when collecting a tip.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#percentages TerminalConfiguration#percentages}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "percentages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
            public double[]? Percentages
            {
                get => GetInstanceProperty<double[]?>();
            }

            /// <summary>Below this amount, fixed amounts will be displayed; above it, percentages will be displayed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#smart_tip_threshold TerminalConfiguration#smart_tip_threshold}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "smartTipThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SmartTipThreshold
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
