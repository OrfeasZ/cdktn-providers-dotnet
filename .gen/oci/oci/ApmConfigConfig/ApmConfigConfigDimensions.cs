using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmConfigConfig
{
    [JsiiByValue(fqn: "oci.apmConfigConfig.ApmConfigConfigDimensions")]
    public class ApmConfigConfigDimensions : oci.ApmConfigConfig.IApmConfigConfigDimensions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_config_config#name ApmConfigConfig#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_config_config#value_source ApmConfigConfig#value_source}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "valueSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ValueSource
        {
            get;
            set;
        }
    }
}
