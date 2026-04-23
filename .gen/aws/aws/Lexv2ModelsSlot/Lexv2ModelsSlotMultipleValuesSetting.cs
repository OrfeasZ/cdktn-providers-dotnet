using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsSlot
{
    [JsiiByValue(fqn: "aws.lexv2ModelsSlot.Lexv2ModelsSlotMultipleValuesSetting")]
    public class Lexv2ModelsSlotMultipleValuesSetting : aws.Lexv2ModelsSlot.ILexv2ModelsSlotMultipleValuesSetting
    {
        private object? _allowMultipleValues;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lexv2models_slot#allow_multiple_values Lexv2ModelsSlot#allow_multiple_values}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowMultipleValues", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AllowMultipleValues
        {
            get => _allowMultipleValues;
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
                _allowMultipleValues = value;
            }
        }
    }
}
