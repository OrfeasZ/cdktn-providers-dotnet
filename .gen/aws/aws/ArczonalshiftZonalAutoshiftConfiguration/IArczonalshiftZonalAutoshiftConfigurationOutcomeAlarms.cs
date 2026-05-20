using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArczonalshiftZonalAutoshiftConfiguration
{
    [JsiiInterface(nativeType: typeof(IArczonalshiftZonalAutoshiftConfigurationOutcomeAlarms), fullyQualifiedName: "aws.arczonalshiftZonalAutoshiftConfiguration.ArczonalshiftZonalAutoshiftConfigurationOutcomeAlarms")]
    public interface IArczonalshiftZonalAutoshiftConfigurationOutcomeAlarms
    {
        /// <summary>ARN of the CloudWatch alarm.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/arczonalshift_zonal_autoshift_configuration#alarm_identifier ArczonalshiftZonalAutoshiftConfiguration#alarm_identifier}
        /// </remarks>
        [JsiiProperty(name: "alarmIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string AlarmIdentifier
        {
            get;
        }

        /// <summary>Type of control condition. Valid value: `CLOUDWATCH`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/arczonalshift_zonal_autoshift_configuration#type ArczonalshiftZonalAutoshiftConfiguration#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IArczonalshiftZonalAutoshiftConfigurationOutcomeAlarms), fullyQualifiedName: "aws.arczonalshiftZonalAutoshiftConfiguration.ArczonalshiftZonalAutoshiftConfigurationOutcomeAlarms")]
        internal sealed class _Proxy : DeputyBase, aws.ArczonalshiftZonalAutoshiftConfiguration.IArczonalshiftZonalAutoshiftConfigurationOutcomeAlarms
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ARN of the CloudWatch alarm.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/arczonalshift_zonal_autoshift_configuration#alarm_identifier ArczonalshiftZonalAutoshiftConfiguration#alarm_identifier}
            /// </remarks>
            [JsiiProperty(name: "alarmIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string AlarmIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Type of control condition. Valid value: `CLOUDWATCH`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/arczonalshift_zonal_autoshift_configuration#type ArczonalshiftZonalAutoshiftConfiguration#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
