using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StreamAnalyticsFunctionJavascriptUda
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.streamAnalyticsFunctionJavascriptUda.StreamAnalyticsFunctionJavascriptUdaInput")]
    public class StreamAnalyticsFunctionJavascriptUdaInput : azurerm.StreamAnalyticsFunctionJavascriptUda.IStreamAnalyticsFunctionJavascriptUdaInput
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_function_javascript_uda#type StreamAnalyticsFunctionJavascriptUda#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        private object? _configurationParameter;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_function_javascript_uda#configuration_parameter StreamAnalyticsFunctionJavascriptUda#configuration_parameter}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "configurationParameter", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ConfigurationParameter
        {
            get => _configurationParameter;
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
                _configurationParameter = value;
            }
        }
    }
}
