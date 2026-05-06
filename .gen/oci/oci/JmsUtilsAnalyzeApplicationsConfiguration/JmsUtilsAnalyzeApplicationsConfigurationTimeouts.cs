using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsUtilsAnalyzeApplicationsConfiguration
{
    [JsiiByValue(fqn: "oci.jmsUtilsAnalyzeApplicationsConfiguration.JmsUtilsAnalyzeApplicationsConfigurationTimeouts")]
    public class JmsUtilsAnalyzeApplicationsConfigurationTimeouts : oci.JmsUtilsAnalyzeApplicationsConfiguration.IJmsUtilsAnalyzeApplicationsConfigurationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_utils_analyze_applications_configuration#create JmsUtilsAnalyzeApplicationsConfiguration#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_utils_analyze_applications_configuration#delete JmsUtilsAnalyzeApplicationsConfiguration#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_utils_analyze_applications_configuration#update JmsUtilsAnalyzeApplicationsConfiguration#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
