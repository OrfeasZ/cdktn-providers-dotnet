using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontConnectionFunction
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfrontConnectionFunction.CloudfrontConnectionFunctionConnectionFunctionConfig")]
    public class CloudfrontConnectionFunctionConnectionFunctionConfig : aws.CloudfrontConnectionFunction.ICloudfrontConnectionFunctionConnectionFunctionConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_connection_function#comment CloudfrontConnectionFunction#comment}.</summary>
        [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}")]
        public string Comment
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_connection_function#runtime CloudfrontConnectionFunction#runtime}.</summary>
        [JsiiProperty(name: "runtime", typeJson: "{\"primitive\":\"string\"}")]
        public string Runtime
        {
            get;
            set;
        }

        private object? _keyValueStoreAssociation;

        /// <summary>key_value_store_association block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_connection_function#key_value_store_association CloudfrontConnectionFunction#key_value_store_association}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keyValueStoreAssociation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontConnectionFunction.CloudfrontConnectionFunctionConnectionFunctionConfigKeyValueStoreAssociation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? KeyValueStoreAssociation
        {
            get => _keyValueStoreAssociation;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudfrontConnectionFunction.ICloudfrontConnectionFunctionConnectionFunctionConfigKeyValueStoreAssociation[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudfrontConnectionFunction.ICloudfrontConnectionFunctionConnectionFunctionConfigKeyValueStoreAssociation).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _keyValueStoreAssociation = value;
            }
        }
    }
}
