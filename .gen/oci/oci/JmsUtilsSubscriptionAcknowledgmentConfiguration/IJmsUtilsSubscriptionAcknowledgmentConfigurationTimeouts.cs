using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsUtilsSubscriptionAcknowledgmentConfiguration
{
    [JsiiInterface(nativeType: typeof(IJmsUtilsSubscriptionAcknowledgmentConfigurationTimeouts), fullyQualifiedName: "oci.jmsUtilsSubscriptionAcknowledgmentConfiguration.JmsUtilsSubscriptionAcknowledgmentConfigurationTimeouts")]
    public interface IJmsUtilsSubscriptionAcknowledgmentConfigurationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_utils_subscription_acknowledgment_configuration#create JmsUtilsSubscriptionAcknowledgmentConfiguration#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_utils_subscription_acknowledgment_configuration#delete JmsUtilsSubscriptionAcknowledgmentConfiguration#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_utils_subscription_acknowledgment_configuration#update JmsUtilsSubscriptionAcknowledgmentConfiguration#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IJmsUtilsSubscriptionAcknowledgmentConfigurationTimeouts), fullyQualifiedName: "oci.jmsUtilsSubscriptionAcknowledgmentConfiguration.JmsUtilsSubscriptionAcknowledgmentConfigurationTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.JmsUtilsSubscriptionAcknowledgmentConfiguration.IJmsUtilsSubscriptionAcknowledgmentConfigurationTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_utils_subscription_acknowledgment_configuration#create JmsUtilsSubscriptionAcknowledgmentConfiguration#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_utils_subscription_acknowledgment_configuration#delete JmsUtilsSubscriptionAcknowledgmentConfiguration#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_utils_subscription_acknowledgment_configuration#update JmsUtilsSubscriptionAcknowledgmentConfiguration#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
