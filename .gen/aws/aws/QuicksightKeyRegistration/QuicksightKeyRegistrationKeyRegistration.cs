using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightKeyRegistration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.quicksightKeyRegistration.QuicksightKeyRegistrationKeyRegistration")]
    public class QuicksightKeyRegistrationKeyRegistration : aws.QuicksightKeyRegistration.IQuicksightKeyRegistrationKeyRegistration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/quicksight_key_registration#key_arn QuicksightKeyRegistration#key_arn}.</summary>
        [JsiiProperty(name: "keyArn", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyArn
        {
            get;
            set;
        }

        private object? _defaultKey;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/quicksight_key_registration#default_key QuicksightKeyRegistration#default_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultKey", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DefaultKey
        {
            get => _defaultKey;
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
                _defaultKey = value;
            }
        }
    }
}
