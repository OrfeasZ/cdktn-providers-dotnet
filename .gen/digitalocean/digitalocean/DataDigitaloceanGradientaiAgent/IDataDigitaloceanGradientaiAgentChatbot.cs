using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanGradientaiAgent
{
    [JsiiInterface(nativeType: typeof(IDataDigitaloceanGradientaiAgentChatbot), fullyQualifiedName: "digitalocean.dataDigitaloceanGradientaiAgent.DataDigitaloceanGradientaiAgentChatbot")]
    public interface IDataDigitaloceanGradientaiAgentChatbot
    {
        /// <summary>Background color for the chatbot button.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#button_background_color DataDigitaloceanGradientaiAgent#button_background_color}
        /// </remarks>
        [JsiiProperty(name: "buttonBackgroundColor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ButtonBackgroundColor
        {
            get
            {
                return null;
            }
        }

        /// <summary>Logo for the chatbot.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#logo DataDigitaloceanGradientaiAgent#logo}
        /// </remarks>
        [JsiiProperty(name: "logo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Logo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the chatbot.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#name DataDigitaloceanGradientaiAgent#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Primary color for the chatbot.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#primary_color DataDigitaloceanGradientaiAgent#primary_color}
        /// </remarks>
        [JsiiProperty(name: "primaryColor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrimaryColor
        {
            get
            {
                return null;
            }
        }

        /// <summary>Secondary color for the chatbot.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#secondary_color DataDigitaloceanGradientaiAgent#secondary_color}
        /// </remarks>
        [JsiiProperty(name: "secondaryColor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecondaryColor
        {
            get
            {
                return null;
            }
        }

        /// <summary>Starting message for the chatbot.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#starting_message DataDigitaloceanGradientaiAgent#starting_message}
        /// </remarks>
        [JsiiProperty(name: "startingMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StartingMessage
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataDigitaloceanGradientaiAgentChatbot), fullyQualifiedName: "digitalocean.dataDigitaloceanGradientaiAgent.DataDigitaloceanGradientaiAgentChatbot")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DataDigitaloceanGradientaiAgent.IDataDigitaloceanGradientaiAgentChatbot
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Background color for the chatbot button.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#button_background_color DataDigitaloceanGradientaiAgent#button_background_color}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "buttonBackgroundColor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ButtonBackgroundColor
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Logo for the chatbot.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#logo DataDigitaloceanGradientaiAgent#logo}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Logo
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Name of the chatbot.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#name DataDigitaloceanGradientaiAgent#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Primary color for the chatbot.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#primary_color DataDigitaloceanGradientaiAgent#primary_color}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "primaryColor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrimaryColor
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Secondary color for the chatbot.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#secondary_color DataDigitaloceanGradientaiAgent#secondary_color}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secondaryColor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecondaryColor
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Starting message for the chatbot.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#starting_message DataDigitaloceanGradientaiAgent#starting_message}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "startingMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StartingMessage
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
