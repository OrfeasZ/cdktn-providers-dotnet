using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontConnectionFunction
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfrontConnectionFunction.CloudfrontConnectionFunctionConnectionFunctionConfigKeyValueStoreAssociation")]
    public class CloudfrontConnectionFunctionConnectionFunctionConfigKeyValueStoreAssociation : aws.CloudfrontConnectionFunction.ICloudfrontConnectionFunctionConnectionFunctionConfigKeyValueStoreAssociation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_connection_function#key_value_store_arn CloudfrontConnectionFunction#key_value_store_arn}.</summary>
        [JsiiProperty(name: "keyValueStoreArn", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyValueStoreArn
        {
            get;
            set;
        }
    }
}
