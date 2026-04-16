using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsIntent
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationKendraConfiguration), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationKendraConfiguration")]
    public interface ILexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationKendraConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lexv2models_intent#kendra_index Lexv2ModelsIntent#kendra_index}.</summary>
        [JsiiProperty(name: "kendraIndex", typeJson: "{\"primitive\":\"string\"}")]
        string KendraIndex
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lexv2models_intent#exact_response Lexv2ModelsIntent#exact_response}.</summary>
        [JsiiProperty(name: "exactResponse", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExactResponse
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lexv2models_intent#query_filter_string Lexv2ModelsIntent#query_filter_string}.</summary>
        [JsiiProperty(name: "queryFilterString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? QueryFilterString
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lexv2models_intent#query_filter_string_enabled Lexv2ModelsIntent#query_filter_string_enabled}.</summary>
        [JsiiProperty(name: "queryFilterStringEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? QueryFilterStringEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationKendraConfiguration), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationKendraConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsIntent.ILexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationKendraConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lexv2models_intent#kendra_index Lexv2ModelsIntent#kendra_index}.</summary>
            [JsiiProperty(name: "kendraIndex", typeJson: "{\"primitive\":\"string\"}")]
            public string KendraIndex
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lexv2models_intent#exact_response Lexv2ModelsIntent#exact_response}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "exactResponse", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ExactResponse
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lexv2models_intent#query_filter_string Lexv2ModelsIntent#query_filter_string}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queryFilterString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? QueryFilterString
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lexv2models_intent#query_filter_string_enabled Lexv2ModelsIntent#query_filter_string_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queryFilterStringEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? QueryFilterStringEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
