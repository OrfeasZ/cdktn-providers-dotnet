using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontMultitenantDistribution
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOriginCustomOriginConfig")]
    public class CloudfrontMultitenantDistributionOriginCustomOriginConfig : aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionOriginCustomOriginConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#http_port CloudfrontMultitenantDistribution#http_port}.</summary>
        [JsiiProperty(name: "httpPort", typeJson: "{\"primitive\":\"number\"}")]
        public double HttpPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#https_port CloudfrontMultitenantDistribution#https_port}.</summary>
        [JsiiProperty(name: "httpsPort", typeJson: "{\"primitive\":\"number\"}")]
        public double HttpsPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#origin_protocol_policy CloudfrontMultitenantDistribution#origin_protocol_policy}.</summary>
        [JsiiProperty(name: "originProtocolPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public string OriginProtocolPolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#origin_ssl_protocols CloudfrontMultitenantDistribution#origin_ssl_protocols}.</summary>
        [JsiiProperty(name: "originSslProtocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] OriginSslProtocols
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#ip_address_type CloudfrontMultitenantDistribution#ip_address_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipAddressType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IpAddressType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#origin_keepalive_timeout CloudfrontMultitenantDistribution#origin_keepalive_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "originKeepaliveTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? OriginKeepaliveTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#origin_read_timeout CloudfrontMultitenantDistribution#origin_read_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "originReadTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? OriginReadTimeout
        {
            get;
            set;
        }
    }
}
