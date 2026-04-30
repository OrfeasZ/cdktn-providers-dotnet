using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lexv2ModelsIntent.Lexv2ModelsIntentKendraConfiguration")]
    public class Lexv2ModelsIntentKendraConfiguration : aws.Lexv2ModelsIntent.ILexv2ModelsIntentKendraConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lexv2models_intent#kendra_index Lexv2ModelsIntent#kendra_index}.</summary>
        [JsiiProperty(name: "kendraIndex", typeJson: "{\"primitive\":\"string\"}")]
        public string KendraIndex
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lexv2models_intent#query_filter_string Lexv2ModelsIntent#query_filter_string}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "queryFilterString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? QueryFilterString
        {
            get;
            set;
        }

        private object? _queryFilterStringEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lexv2models_intent#query_filter_string_enabled Lexv2ModelsIntent#query_filter_string_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "queryFilterStringEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? QueryFilterStringEnabled
        {
            get => _queryFilterStringEnabled;
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
                _queryFilterStringEnabled = value;
            }
        }
    }
}
