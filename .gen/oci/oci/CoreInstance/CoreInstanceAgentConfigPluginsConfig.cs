using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreInstance.CoreInstanceAgentConfigPluginsConfig")]
    public class CoreInstanceAgentConfigPluginsConfig : oci.CoreInstance.ICoreInstanceAgentConfigPluginsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#desired_state CoreInstance#desired_state}.</summary>
        [JsiiProperty(name: "desiredState", typeJson: "{\"primitive\":\"string\"}")]
        public string DesiredState
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#name CoreInstance#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
