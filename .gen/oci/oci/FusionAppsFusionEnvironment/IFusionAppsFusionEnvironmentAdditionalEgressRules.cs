using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FusionAppsFusionEnvironment
{
    [JsiiInterface(nativeType: typeof(IFusionAppsFusionEnvironmentAdditionalEgressRules), fullyQualifiedName: "oci.fusionAppsFusionEnvironment.FusionAppsFusionEnvironmentAdditionalEgressRules")]
    public interface IFusionAppsFusionEnvironmentAdditionalEgressRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/fusion_apps_fusion_environment#description FusionAppsFusionEnvironment#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        string Description
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/fusion_apps_fusion_environment#destination_cidr FusionAppsFusionEnvironment#destination_cidr}.</summary>
        [JsiiProperty(name: "destinationCidr", typeJson: "{\"primitive\":\"string\"}")]
        string DestinationCidr
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/fusion_apps_fusion_environment#max_destination_port FusionAppsFusionEnvironment#max_destination_port}.</summary>
        [JsiiProperty(name: "maxDestinationPort", typeJson: "{\"primitive\":\"number\"}")]
        double MaxDestinationPort
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/fusion_apps_fusion_environment#min_destination_port FusionAppsFusionEnvironment#min_destination_port}.</summary>
        [JsiiProperty(name: "minDestinationPort", typeJson: "{\"primitive\":\"number\"}")]
        double MinDestinationPort
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IFusionAppsFusionEnvironmentAdditionalEgressRules), fullyQualifiedName: "oci.fusionAppsFusionEnvironment.FusionAppsFusionEnvironmentAdditionalEgressRules")]
        internal sealed class _Proxy : DeputyBase, oci.FusionAppsFusionEnvironment.IFusionAppsFusionEnvironmentAdditionalEgressRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/fusion_apps_fusion_environment#description FusionAppsFusionEnvironment#description}.</summary>
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
            public string Description
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/fusion_apps_fusion_environment#destination_cidr FusionAppsFusionEnvironment#destination_cidr}.</summary>
            [JsiiProperty(name: "destinationCidr", typeJson: "{\"primitive\":\"string\"}")]
            public string DestinationCidr
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/fusion_apps_fusion_environment#max_destination_port FusionAppsFusionEnvironment#max_destination_port}.</summary>
            [JsiiProperty(name: "maxDestinationPort", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxDestinationPort
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/fusion_apps_fusion_environment#min_destination_port FusionAppsFusionEnvironment#min_destination_port}.</summary>
            [JsiiProperty(name: "minDestinationPort", typeJson: "{\"primitive\":\"number\"}")]
            public double MinDestinationPort
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
