using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PaymentcryptographyKey
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.paymentcryptographyKey.PaymentcryptographyKeyKeyAttributes")]
    public class PaymentcryptographyKeyKeyAttributes : aws.PaymentcryptographyKey.IPaymentcryptographyKeyKeyAttributes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/paymentcryptography_key#key_algorithm PaymentcryptographyKey#key_algorithm}.</summary>
        [JsiiProperty(name: "keyAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyAlgorithm
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/paymentcryptography_key#key_class PaymentcryptographyKey#key_class}.</summary>
        [JsiiProperty(name: "keyClass", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyClass
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/paymentcryptography_key#key_usage PaymentcryptographyKey#key_usage}.</summary>
        [JsiiProperty(name: "keyUsage", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyUsage
        {
            get;
            set;
        }

        private object? _keyModesOfUse;

        /// <summary>key_modes_of_use block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/paymentcryptography_key#key_modes_of_use PaymentcryptographyKey#key_modes_of_use}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keyModesOfUse", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.paymentcryptographyKey.PaymentcryptographyKeyKeyAttributesKeyModesOfUse\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? KeyModesOfUse
        {
            get => _keyModesOfUse;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.PaymentcryptographyKey.IPaymentcryptographyKeyKeyAttributesKeyModesOfUse[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.PaymentcryptographyKey.IPaymentcryptographyKeyKeyAttributesKeyModesOfUse).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _keyModesOfUse = value;
            }
        }
    }
}
