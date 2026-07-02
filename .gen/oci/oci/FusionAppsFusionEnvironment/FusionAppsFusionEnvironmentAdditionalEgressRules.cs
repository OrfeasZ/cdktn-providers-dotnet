using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FusionAppsFusionEnvironment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fusionAppsFusionEnvironment.FusionAppsFusionEnvironmentAdditionalEgressRules")]
    public class FusionAppsFusionEnvironmentAdditionalEgressRules : oci.FusionAppsFusionEnvironment.IFusionAppsFusionEnvironmentAdditionalEgressRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/fusion_apps_fusion_environment#description FusionAppsFusionEnvironment#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public string Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/fusion_apps_fusion_environment#destination_cidr FusionAppsFusionEnvironment#destination_cidr}.</summary>
        [JsiiProperty(name: "destinationCidr", typeJson: "{\"primitive\":\"string\"}")]
        public string DestinationCidr
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/fusion_apps_fusion_environment#max_destination_port FusionAppsFusionEnvironment#max_destination_port}.</summary>
        [JsiiProperty(name: "maxDestinationPort", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxDestinationPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/fusion_apps_fusion_environment#min_destination_port FusionAppsFusionEnvironment#min_destination_port}.</summary>
        [JsiiProperty(name: "minDestinationPort", typeJson: "{\"primitive\":\"number\"}")]
        public double MinDestinationPort
        {
            get;
            set;
        }
    }
}
