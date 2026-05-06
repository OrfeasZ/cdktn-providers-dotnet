using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsUtilsSubscriptionAcknowledgmentConfiguration
{
    [JsiiByValue(fqn: "oci.jmsUtilsSubscriptionAcknowledgmentConfiguration.JmsUtilsSubscriptionAcknowledgmentConfigurationTimeouts")]
    public class JmsUtilsSubscriptionAcknowledgmentConfigurationTimeouts : oci.JmsUtilsSubscriptionAcknowledgmentConfiguration.IJmsUtilsSubscriptionAcknowledgmentConfigurationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_utils_subscription_acknowledgment_configuration#create JmsUtilsSubscriptionAcknowledgmentConfiguration#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_utils_subscription_acknowledgment_configuration#delete JmsUtilsSubscriptionAcknowledgmentConfiguration#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_utils_subscription_acknowledgment_configuration#update JmsUtilsSubscriptionAcknowledgmentConfiguration#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
