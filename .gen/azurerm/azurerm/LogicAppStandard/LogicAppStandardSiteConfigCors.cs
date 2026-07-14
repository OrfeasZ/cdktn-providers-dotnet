using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LogicAppStandard
{
    [JsiiByValue(fqn: "azurerm.logicAppStandard.LogicAppStandardSiteConfigCors")]
    public class LogicAppStandardSiteConfigCors : azurerm.LogicAppStandard.ILogicAppStandardSiteConfigCors
    {
        /// <summary>Specifies a list of origins that should be allowed to make cross-origin calls.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/logic_app_standard#allowed_origins LogicAppStandard#allowed_origins}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowedOrigins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowedOrigins
        {
            get;
            set;
        }

        private object? _supportCredentials;

        /// <summary>Are credentials allowed in CORS requests? Defaults to `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/logic_app_standard#support_credentials LogicAppStandard#support_credentials}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "supportCredentials", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? SupportCredentials
        {
            get => _supportCredentials;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _supportCredentials = value;
            }
        }
    }
}
